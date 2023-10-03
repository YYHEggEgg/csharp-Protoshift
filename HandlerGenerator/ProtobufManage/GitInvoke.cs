using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitInvoke
{
    private string _baseGitDir;
    public string BaseGitDirectory
    {
        get => _baseGitDir;
        set => _baseGitDir = Path.GetFullPath(value);
    }

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    public GitInvoke(string path)
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    {
        BaseGitDirectory = path;
    }

    public static bool CheckGitInstallation()
    {
        var versionInfo = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path,
            Environment.CurrentDirectory, "--version");
        if (versionInfo == null) return false;
        else
        {
            Log.Info($"Got installed Git version: {versionInfo}", nameof(GitInvoke));
            return true;
        }
    }

    public static bool IsGitHubRemote(string gitPath) =>
        Regex.IsMatch(gitPath, "^https:\\/\\/github\\.com\\/[0-9A-Za-z]+\\/[0-9A-Za-z-_\\.]{1,100}\\.git$");

    public bool IsValidGitRepository => !Tools.DirNonExistsOrEmpty($"{_baseGitDir}/.git");
    /// <summary>
    /// The <c>user.name</c> git config on the current computer.
    /// </summary>
    public string? GetGlobalAuthor() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "config --global --get user.name");
    /// <summary>
    /// The <c>user.email</c> git config on the current computer.
    /// </summary>
    public string? GetGlobalEmail() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "config --global --get user.email");
    /// <summary>
    /// The current branch name working on. 
    /// </summary>
    /// <returns></returns>
    public string? GetCurrentBranch() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "rev-parse --abbrev-ref HEAD");
    /// <summary>
    /// Get the author of the last made commit.
    /// </summary>
    public string? GetLastCommitAuthor() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "log --pretty=format:\"%an\" HEAD -1");
    /// <summary>
    /// Get the email of the last made commit.
    /// </summary>
    public string? GetLastCommitEmail() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "log --pretty=format:\"%ae\" HEAD -1");
    /// <summary>
    /// Get the time of the last made commit.
    /// </summary>
    public string? GetLastCommitTime() =>
        Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "log --pretty=format:\"%cd\" HEAD -1");

    public void Fetch()
    {
        ProcessStartInfo startInfo = new(OuterInvokeGlobalConfig.git_path)
        {
            WorkingDirectory = _baseGitDir,
            Arguments = "fetch",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };
        var p = Process.Start(startInfo);
        p?.WaitForExit();
        if (p?.ExitCode != 0)
        {
            if (p?.StandardOutput != null)
                Log.Warn(p.StandardOutput.ReadToEnd(), $"{nameof(GitInvoke)}:stdout");
            if (p?.StandardError != null)
                Log.Warn(p.StandardError.ReadToEnd(), $"{nameof(GitInvoke)}:stderr");
            throw new WebException($"git fetch failed.");
        }
    }

    public List<string> GetLocalBranches()
    {
        var content = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, 
            _baseGitDir, "branch --list --format \"%(refname)\"");
        if (content == null) return new();
        var branches = content.Split("refs/heads/");
        return new(from branchname in branches
                   select branchname.Trim());
    }
    
    public List<string> GetRemoteBranches()
    {
        var content = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, 
            _baseGitDir, "branch --list --remote --format \"%(refname)\"");
        if (content == null) return new();
        var branches = content.Split("refs/remotes/");
        return new(from branchname in branches
                   select branchname.Trim());
    }

    public string? GetRemote()
    {
        var remotes = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "remote")?.Split('\n');
        if (remotes == null) return null;
        if (remotes.Length == 0) return null;
        var remote = remotes[0];
        return Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, $"remote get-url {remote}");
    }

    public bool TrySetRemote(string newurl)
    {
        var remotes = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path, _baseGitDir, "remote")?.Split('\n');
        if (remotes == null) return false;
        if (remotes.Length == 0) return false;
        var remote = remotes[0];
        ProcessStartInfo startInfo = new(OuterInvokeGlobalConfig.git_path)
        {
            WorkingDirectory = _baseGitDir,
            Arguments = $"remote set-url {remote} {newurl}"
        };
        var p = Process.Start(startInfo);
        p?.WaitForExit();
        return p?.ExitCode == 0;
    }

    /// <summary>
    /// Get how many commits local is ahead of remote.
    /// </summary>
    /// <returns></returns>
    public int GetAheadCommits()
    {
        var remote_all_branches = GetRemoteBranches();
        var remote_branch = $"origin/{GetCurrentBranch()}";
        if (!remote_all_branches.Contains(remote_branch))
        {
            throw new EntryPointNotFoundException("The current local branch is not found in remote.");
        }
        var content = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path,
            _baseGitDir, $"rev-list --count {remote_branch}..HEAD");
        if (content == null)
            throw new ApplicationException("git rev-list parse got empty message.");
        return int.Parse(content);
    }
    
    /// <summary>
    /// Get how many commits local is behind of remote.
    /// </summary>
    /// <returns></returns>
    public int GetBehindCommits()
    {
        var remote_all_branches = GetRemoteBranches();
        var remote_branch = $"origin/{GetCurrentBranch()}";
        if (!remote_all_branches.Contains(remote_branch))
        {
            throw new EntryPointNotFoundException("The current local branch is not found in remote.");
        }
        var content = Tools.GetContentFromExecute(OuterInvokeGlobalConfig.git_path,
            _baseGitDir, $"rev-list --count HEAD..{remote_branch}");
        if (content == null)
            throw new ApplicationException("git rev-list parse got empty message.");
        return int.Parse(content);
    }

    #region Changes
    /// <summary>
    /// Check if the local repository has any changes
    /// when compared with remote.
    /// </summary>
    /// <returns></returns>
    public bool DifferentFromRemote()
    {
        if (GetAheadCommits() > 0) return true;
        else if (!string.IsNullOrEmpty(Tools.GetContentFromExecute(
            OuterInvokeGlobalConfig.git_path, _baseGitDir, "diff --staged --shortstat")?.Trim()))
            return true;
        else if (!string.IsNullOrEmpty(Tools.GetContentFromExecute(
            OuterInvokeGlobalConfig.git_path, _baseGitDir,
            "ls-files --deleted --modified --others --unmerged --exclude-standard")?.Trim()))
            return true;
        else if (!string.IsNullOrEmpty(Tools.GetContentFromExecute(
            OuterInvokeGlobalConfig.git_path, _baseGitDir, "stash list")?.Trim()))
            return true;
        else return false;
    }
    #endregion
}