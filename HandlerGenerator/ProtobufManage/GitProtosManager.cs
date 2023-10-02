using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitProtosManager
{
    private readonly GitInvoke _gitInvoke;
    public readonly LoggerChannel Logger;
    private static readonly HttpClient _client = new();

    public const string DefaultSource = "https://github.com/YYHEggEgg/mihomo-protos.git";
    public string BaseGitDirectory => _gitInvoke.BaseGitDirectory;
    public bool IsValidGitRepository => _gitInvoke.IsValidGitRepository;
    [Obsolete("The whole program sometimes get stuck and this bug cannot be fixed.", true)]
    public bool DifferentFromRemote() => _gitInvoke.DifferentFromRemote();

    public bool IsDMCAProofBranch => !Tools.DirNonExistsOrEmpty(Path.Combine(BaseGitDirectory, "Proto2json_Output"));

    public GitProtosManager(string path, string protocol_friendlyname)
    {
        _gitInvoke = new(path);
        Logger = Log.GetChannel(protocol_friendlyname);
    }

    public bool HasUpdateAvaliable()
    {
        if (!IsValidGitRepository) return false;
        try
        {
            _gitInvoke.Fetch();
            return _gitInvoke.GetBehindCommits() > 0;
        }
        catch (Exception ex)
        {
            Logger.LogWarn(ex.ToString());
            Logger.LogWarn($"git fetch update-check failed. Update check skipped.");
            return false;
        }
    }

    public bool TryGitPullUpdate()
    {
        if (!IsValidGitRepository) return false;
        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
        {
            WorkingDirectory = BaseGitDirectory,
            Arguments = "pull"
        };
        try
        {
            var p = Process.Start(startInfo);
            p?.WaitForExit();
            if (p?.ExitCode != 0)
            {
                Logger.LogWarn($"git pull update exited with code {p?.ExitCode.ToString() ?? "<failed to launch>"}.");
                return false;
            }
            else return true;
        }
        catch (Exception ex)
        {
            Logger.LogWarn(ex.ToString());
            Logger.LogWarn($"git pull update failed.");
            return false;
        }
    }

    public bool TryCloneHere(string remoteUrl_git, string? branch)
    {
        var cloneargs = "clone ";
        if (branch != null) cloneargs += $"--branch {branch} ";
        cloneargs += $"{remoteUrl_git} {Path.GetFullPath(BaseGitDirectory)}";

        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
        {
            Arguments = cloneargs
        };
        try
        {
            var p = Process.Start(startInfo);
            p?.WaitForExit();
            if (p?.ExitCode != 0)
            {
                Logger.LogWarn($"git clone exited with code {p?.ExitCode.ToString() ?? "<failed to launch>"}.");
                return false;
            }
            else return true;
        }
        catch (Exception ex)
        {
            Logger.LogWarn(ex.ToString());
            Logger.LogWarn($"git clone failed, remote: {remoteUrl_git}, branch: {branch ?? "<default>"}.");
            return false;
        }
    }

    private bool TryGitCheckoutTo(string branchname)
    {
        if (!IsValidGitRepository) return false;
        _gitInvoke.Fetch();
        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
        {
            WorkingDirectory = BaseGitDirectory,
            Arguments = $"checkout {branchname}"
        };
        try
        {
            var p = Process.Start(startInfo);
            p?.WaitForExit();
            if (p?.ExitCode != 0)
            {
                Logger.LogWarn($"git checkout (switch branch) exited with code {p?.ExitCode.ToString() ?? "<failed to launch>"}.");
                return false;
            }
            else return true;
        }
        catch (Exception ex)
        {
            Logger.LogWarn(ex.ToString());
            Logger.LogWarn($"git checkout (switch branch) failed.");
            return false;
        }
    }

    /// <summary>
    /// Create a backup at the same parent directory with
    /// <see cref="BaseGitDirectory"/>.<paramref name="backupsuffix"/> .
    /// </summary>
    public void CreateBackup(string backupsuffix) =>
        Tools.CopyDir(BaseGitDirectory, 
            Tools.AddNumberedSuffixToPath($"{BaseGitDirectory}.{backupsuffix}"));

    public void Destroy()
    {
        try
        {
            Directory.Delete(BaseGitDirectory, true);
        }
        catch (Exception ex)
        {
            if (!Directory.Exists(BaseGitDirectory)) return;
            Log.Erro(ex.ToString(), nameof(GitProtosManager));
            Log.Erro($"Can't delete old directory. Please manually close " +
                $"programs using '{BaseGitDirectory}' and type 'y' to retry.");
            var rsp = Console.ReadLine();
            if (rsp?.ToLower() == "y") Destroy();
            else
            {
                Log.Erro($"Program terminated because the git clone target " +
                    $"directory is occupied. Exit code is 43211.");
                Environment.Exit(43211);
            }
        }
    }

    private async Task<ProtoStatInfo?> DownloadProtoStatJson(string protostatUrl)
    {
        try
        {
            return await _client.GetFromJsonAsync<ProtoStatInfo>(protostatUrl,
                new JsonSerializerOptions
                {
                    AllowTrailingCommas = true,
                    ReadCommentHandling = JsonCommentHandling.Skip,
                    Converters =
                    {
                        new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)
                    }
                });
        }
        catch (Exception ex)
        {
            Logger.LogWarn($"Fetch protostat.json failed: {ex}");
            return null;
        }
    }

    /// <summary>
    /// Get <c>protostat.json</c> from the specified repository.
    /// </summary>
    /// <param name="repoUrl_git">
    /// The remote repository, which must be a GitHub repository
    /// url with <c>.git</c> suffix.
    /// </param>
    /// <param name="branch">The target branch.</param>
    /// <param name="relative_path">
    /// The relative path where the file is in this repository.
    /// </param>
    /// <param name="localUpdateCallback">
    /// The func should be called to update the local git repository.
    /// Usually do business like <c>git pull</c>. Should return true
    /// when succeeded.
    /// </param>
    /// <returns></returns>
    public async Task<ProtoStatInfo?> GetProtoStatInfo(string repoUrl_git, 
        string branch, string relative_path, Func<bool> localUpdateCallback)
    {
        // Confirm the remote repo status.
        if (GitInvoke.IsGitHubRemote(repoUrl_git))
        {
            // If the repository is GitHub, then the protostat.json
            // can be fetched by raw without any cloning.

            // Example:
            // https://github.com/YYHEggEgg/mihomo-protos, branch='3.4_live', path='protostat.json'
            // -->
            // https://github.com/YYHEggEgg/mihomo-protos/raw/3.4_live/protostat.json
            // or https://raw.githubusercontent.com/YYHEggEgg/mihomo-protos/3.4_live/protostat.json

            var github_baseUrl = repoUrl_git.Substring(0, repoUrl_git.Length - ".git".Length);
            return await DownloadProtoStatJson($"{github_baseUrl}/raw/{branch}/{relative_path}");
        }
        else
        {
            if (!localUpdateCallback() || !File.Exists(
                Path.Combine(BaseGitDirectory, relative_path))) return null;
            return JsonSerializer.Deserialize<ProtoStatInfo>(await File.ReadAllTextAsync(
                Path.Combine(BaseGitDirectory, relative_path)));
        }
    }

    public string? GetCurrentBranch()
    {
        var rtn = _gitInvoke.GetCurrentBranch();
        if (rtn != null && !_gitInvoke.GetLocalBranches().Contains(rtn)) return null;
        else return rtn;
    }

    /// <summary>
    /// Try switch the repo to the certain branch.
    /// </summary>
    /// <param name="branch"></param>
    /// <returns>
    /// Return true if the switch is actually performed,
    /// and return false when branch switch is
    /// unnecessary or there's a git failure.
    /// </returns>
    public bool TryAutoSwitchToBranch(string? branch)
    {
        if (branch == null) return false;
        if (!_gitInvoke.IsValidGitRepository) return false;
        if (_gitInvoke.GetCurrentBranch() == branch) return false;
        return TryGitCheckoutTo(branch);
    }
}
