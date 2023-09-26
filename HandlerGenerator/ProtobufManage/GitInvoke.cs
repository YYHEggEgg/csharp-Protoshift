using System.Diagnostics;
using System.Net;
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

    public GitInvoke(string path)
    {
        BaseGitDirectory = path;
    }

    /// <summary>
    /// The <c>user.name</c> git config on the current computer.
    /// </summary>
    public string? GetGlobalAuthor() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "config --global --get user.name");
    /// <summary>
    /// The <c>user.email</c> git config on the current computer.
    /// </summary>
    public string? GetGlobalEmail() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "config --global --get user.email");
    /// <summary>
    /// The current branch name working on. 
    /// </summary>
    /// <returns></returns>
    public string? GetCurrentBranch() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "rev-parse --abbrev-ref HEAD");
    /// <summary>
    /// Get the author of the last made commit.
    /// </summary>
    public string? GetLastCommitAuthor() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "log --pretty=format:\"%an\" HEAD -1");
    /// <summary>
    /// Get the email of the last made commit.
    /// </summary>
    public string? GetLastCommitEmail() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "log --pretty=format:\"%ae\" HEAD -1");
    /// <summary>
    /// Get the time of the last made commit.
    /// </summary>
    public string? GetLastCommitTime() =>
        Tools.GetContentFromExecute(OuterInvokeConfig.git_path, _baseGitDir, "log --pretty=format:\"%cd\" HEAD -1");

    public void Fetch()
    {
        ProcessStartInfo startInfo = new(OuterInvokeConfig.git_path)
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
        Fetch();
        var content = Tools.GetContentFromExecute(OuterInvokeConfig.git_path, 
            _baseGitDir, "branch --list --format \"%(refname)\"");
        if (content == null) return new();
        var branches = content.Split("refs/heads/");
        return new(from branchname in branches
                   select branchname.Trim());
    }
    
    public List<string> GetRemoteBranches()
    {
        Fetch();
        var content = Tools.GetContentFromExecute(OuterInvokeConfig.git_path, 
            _baseGitDir, "branch --list --remote --format \"%(refname)\"");
        if (content == null) return new();
        var branches = content.Split("refs/remotes/");
        return new(from branchname in branches
                   select branchname.Trim());
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
        var content = Tools.GetContentFromExecute(OuterInvokeConfig.git_path,
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
        var content = Tools.GetContentFromExecute(OuterInvokeConfig.git_path,
            _baseGitDir, $"rev-list --count HEAD..{remote_branch}");
        if (content == null)
            throw new ApplicationException("git rev-list parse got empty message.");
        return int.Parse(content);
    }
}