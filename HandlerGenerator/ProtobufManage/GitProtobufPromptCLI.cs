using System.Linq.Expressions;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitProtobufPromptCLI
{
    private readonly GitProtosManager _oldprotos = new("./../OldProtoHandlers/Google.Protobuf", "OldProtos");
    private readonly GitProtosManager _newprotos = new("./../NewProtoHandlers/Google.Protobuf", "NewProtos");
    public readonly string DefaultBranchOld;
    public readonly string DefaultBranchNew;
    public readonly string? OverrideSourceRepo;
    private readonly LoggerChannel _mainlogger = Log.GetChannel(nameof(GitProtobufPromptCLI));

    public GitProtobufPromptCLI()
    {
        var branchlist = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/default_protobuf_branches.txt", 2);
        DefaultBranchOld = branchlist[0];
        DefaultBranchNew = branchlist[1];

        OverrideSourceRepo = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/protobuf_source_git.txt", 0, 1)[0];
    }

    public async Task CheckAndInitAsync()
    {
        await _oldprotos.CheckAndInitAsync(DefaultBranchOld, OverrideSourceRepo);
        await _newprotos.CheckAndInitAsync(DefaultBranchNew, OverrideSourceRepo);
    }

    public async Task MainAsync(RunUpdateProtobufConfig o)
    {

    }

    private async Task<bool> TryRestoreProtos(GitProtosManager manager,
        string remoteUrl_git, string branch)
    {
        var _logger = manager.Logger;
        var protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json");
        bool cloned_recently = false;
        string? current_branch = manager.GetCurrentBranch();
        if (protostat == null)
        {
            var protostat_path = Path.Combine(manager.BaseGitDirectory, "protostat.json");
            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                if (!manager.TryCloneHere(remoteUrl_git, branch))
                {
                    _mainlogger.LogErro($"Protobuf clone of branch: {branch} failed.");
                    return false;
                }
                cloned_recently = true;
            }

            manager.TryAutoSwitchToBranch(branch);
            if (!File.Exists(protostat_path))
            {
                _mainlogger.LogErro($"Invalid protobuf version: protostat.json not found. (Path: {manager.BaseGitDirectory})");
                return false;
            }
            protostat = await Tools.DeserializeFileAsync<ProtoStatInfo>(protostat_path);
            if (protostat == null)
            {
                _mainlogger.LogErro($"Invalid protobuf version: protostat.json deserialize failure. (File: {protostat_path})");
                return false;
            }
        }

        if (protostat.CurrentStat == ProtoStat.Deprecated)
        {
            if (cloned_recently && !manager.DifferentFromRemote())
            {
                Directory.Delete(manager.BaseGitDirectory, true);
            }

            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"Please select a correct branch and retry.");
                return false;
            }
            else
            {
                manager.TryAutoSwitchToBranch(current_branch);
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"You won't receive any newer updates until you switch to a valid branch.");
                return true;
            }
        }
        else if (protostat.CurrentStat == ProtoStat.Valid)
        {
            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                if (!manager.TryCloneHere(remoteUrl_git, branch)) return false;
            }
            else if (!manager.IsValidGitRepository)
            {
                _logger.LogWarn($"Is not a valid Git repository. Consider as finished so not updated, but building won't interrupt.");
                _logger.LogWarn($"You may delete the directory and use HandlerGenerator's auto cloning to use the update feature.");
                return true;
            }

            if (manager.HasUpdateAvaliable())
                if (!manager.TryGitPullUpdate())
                    _logger.LogWarn($"Update of this Protobuf branch probably failed.");
                else _logger.LogInfo($"This protobuf is already the latest version!");
            return true;
        }

        // else (protostat.CurrentStat == ProtoStat.DMCATakenDown)
        var redirect_url = protostat.RedirectToRepo;
        if (redirect_url != null)
        {
            _logger.LogInfo($"Protos have been DMCA taken down, redirect to backup channel handler.");
            return await TryRestoreDMCAProofProtos(manager, redirect_url, branch);
        }
        else
        {
            _logger.LogErro($"Protobuf restore failed because of DMCA taken down.");
            return false;
        }
    }

    #region "Be grateful, Trailblazer. I've prepared everything for you."
    private async Task<bool> TryRestoreDMCAProofProtos(GitProtosManager manager,
        string remoteUrl_git, string branch)
    {
        var _logger = Log.GetChannel($"{manager.Logger.LogSender}:DMCA");
        var protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json");
        string? current_branch = manager.GetCurrentBranch();
        bool cloned_recently = false;
        if (protostat == null)
        {
            var protostat_path = Path.Combine(manager.BaseGitDirectory, "protostat.json");
            if (!Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                if (QueryIfAllowSwitch(_logger))
                {
                    if (!manager.DifferentFromRemote()) manager.CreateBackup("BackupBeforeDMCA");
                    manager.Destroy();
                }
                else
                {
                    _logger.LogWarn($"User cancelled update channel change.");
                    return true;
                }
            }

            if (!manager.TryCloneHere(remoteUrl_git, branch))
            {
                _mainlogger.LogErro($"Protobuf clone of branch: {branch} failed.");
                return false;
            }
            cloned_recently = true;
            protostat = await Tools.DeserializeFileAsync<ProtoStatInfo>(protostat_path);
            if (protostat == null)
            {
                _mainlogger.LogErro($"Invalid protobuf version: protostat.json deserialize failure. (File: {protostat_path})");
                return false;
            }
        }

        if (protostat.CurrentStat == ProtoStat.Deprecated)
        {
            if (cloned_recently && !manager.DifferentFromRemote())
            {
                Directory.Delete(manager.BaseGitDirectory, true);
            }

            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"Please select a correct branch and retry.");
                return false;
            }
            else
            {
                manager.TryAutoSwitchToBranch(current_branch);
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"You won't receive any newer updates until you switch to a valid branch.");
                return true;
            }
        }
        else if (protostat.CurrentStat == ProtoStat.Valid)
        {
            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                if (!manager.TryCloneHere(remoteUrl_git, branch)) return false;
            }
            else if (!manager.IsValidGitRepository)
            {
                _logger.LogWarn($"Is not a valid Git repository. Consider as finished so not updated, but building won't interrupt.");
                _logger.LogWarn($"You may delete the directory and use HandlerGenerator's auto cloning to use the update feature.");
                return true;
            }

            if (manager.HasUpdateAvaliable())
                if (!manager.TryGitPullUpdate())
                    _logger.LogWarn($"Update of this Protobuf branch probably failed.");
                else _logger.LogInfo($"This protobuf is already the latest version!");
            return true;
        }
        // else (protostat.CurrentStat == ProtoStat.DMCATakenDown)
        var redirect_url = protostat.RedirectToRepo;
        if (redirect_url != null)
        {
            _logger.LogInfo($"Protos have been DMCA taken down, redirect to backup channel handler.");
            return await TryRestoreDMCAProofProtos(manager, redirect_url, branch);
        }
        else
        {
            _logger.LogErro($"Protobuf restore failed because of DMCA taken down.");
            return false;
        }
    }

    private static bool QueryIfAllowSwitch(LoggerChannel logger)
    {
        logger.LogWarn($"The target protobuf version is taken down by a DMCA request.");
        logger.LogWarn($"You can stop receiving any further updates or continue keeping " +
            $"your protos up-to-date by switching to another update channel.");
        logger.LogWarn($"Do you want to switch to another update channel? Type 'y' to accept.");
        logger.LogInfo($"Your repository data of this version of protobuf will be reserved if " +
            $"you have ever made any changes.");
        var confirm = Console.ReadLine();
        if (confirm?.Trim().ToLower() == "y") return true;
        else return false;
    }
    #endregion
}
