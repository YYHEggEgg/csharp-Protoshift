using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitProtosManager
{
    private readonly GitInvoke _gitInvoke;
    private readonly LoggerChannel _logger;
    private static readonly HttpClient _client = new();

    public const string DefaultSource = "https://github.com/YYHEggEgg/mihomo-protos.git";

    public GitProtosManager(string path, string protocol_friendlyname)
    {
        _gitInvoke = new(path);
        _logger = Log.GetChannel(protocol_friendlyname);
    }

    public bool HasUpdateAvaliable()
    {
        try
        {
            return _gitInvoke.GetBehindCommits() > 0;
        }
        catch (Exception ex)
        {
            _logger.LogWarn(ex.ToString());
            _logger.LogWarn($"git fetch update-check failed. Update check skipped.");
            return false;
        }
    }

    public bool TryGitPullUpdate()
    {
        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
        {
            WorkingDirectory = _gitInvoke.BaseGitDirectory,
            Arguments = "pull"
        };
        try
        {
            var p = Process.Start(startInfo);
            p?.WaitForExit();
            if (p?.ExitCode != 0)
            {
                _logger.LogWarn($"git pull update exited with code {p?.ExitCode.ToString() ?? "<failed to launch>"}.");
                return false;
            }
            else return true;
        }
        catch (Exception ex)
        {
            _logger.LogWarn(ex.ToString());
            _logger.LogWarn($"git pull update failed.");
            return false;
        }
    }

    public bool TryGitCheckoutTo(string branchname)
    {
        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
        {
            WorkingDirectory = _gitInvoke.BaseGitDirectory,
            Arguments = $"checkout {branchname}"
        };
        try
        {
            var p = Process.Start(startInfo);
            p?.WaitForExit();
            if (p?.ExitCode != 0)
            {
                _logger.LogWarn($"git checkout (switch branch) exited with code {p?.ExitCode.ToString() ?? "<failed to launch>"}.");
                return false;
            }
            else return true;
        }
        catch (Exception ex)
        {
            _logger.LogWarn(ex.ToString());
            _logger.LogWarn($"git checkout (switch branch) failed.");
            return false;
        }
    }

    /// <summary>
    /// Create a backup at the same parent directory with
    /// <see cref="_gitInvoke.BaseGitDirectory"/>.<paramref name="backupsuffix"/> .
    /// </summary>
    public void CreateBackup(string backupsuffix) =>
        Tools.CopyDir(_gitInvoke.BaseGitDirectory, $"{_gitInvoke.BaseGitDirectory}.{backupsuffix}");

    public void Destroy() =>
        Directory.Delete(_gitInvoke.BaseGitDirectory, true);

    public async Task<ProtoStatInfo?> GetProtoStat(string protostatUrl) =>
        await _client.GetFromJsonAsync<ProtoStatInfo>(protostatUrl,
            new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            });

    public async Task CheckAndInitAsync(string target_dir, 
        string branch, string? remote_repo = null)
    {
        if (!Directory.Exists(target_dir))
        {
            await OuterInvoke.Run(new OuterInvokeInfo
            {
                CmdLine = $"clone --single-branch --branch {branch} {remote_repo} {target_dir}",
                AutoTerminateReason = "git clone failed. ",
                ProcessPath = OuterInvokeConfig.git_path,
                StartingNotice = $"Start cloning protobuf (Branch: {branch})",
            }, 15260);
        }
    }
}
