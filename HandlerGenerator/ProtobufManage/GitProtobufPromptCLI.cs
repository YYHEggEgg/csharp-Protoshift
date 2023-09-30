using System.Linq.Expressions;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitProtobufPromptCLI
{
    private readonly GitProtosManager _oldprotos = new("./../OldProtoHandlers/Google.Protobuf", "OldProtos");
    private readonly GitProtosManager _newprotos = new("./../NewProtoHandlers/Google.Protobuf", "NewProtos");
    public readonly string DefaultBranchOld;
    public readonly string DefaultBranchNew;
    public readonly string SourceRepo;
    private readonly LoggerChannel _mainlogger = Log.GetChannel(nameof(GitProtobufPromptCLI));

    public GitProtobufPromptCLI()
    {
        var branchlist = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/default_protobuf_branches.txt", 2);
        DefaultBranchOld = branchlist[0];
        DefaultBranchNew = branchlist[1];

        SourceRepo = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/protobuf_source_git.txt", 0, 1)[0]
            ?? GitProtosManager.DefaultSource;
    }

    public async Task MainAsync(RunUpdateProtobufConfig o)
    {
        if (!o.RequestUpdate)
        {
            _ = Task.Run(() =>
            {
                if (_oldprotos.HasUpdateAvaliable() || _newprotos.HasUpdateAvaliable())
                {
                    _mainlogger.LogWarn($"At least one of the protobufs has update avaliable. " +
                        $"Run 'update' or 'update.bat' to get protobuf version up-to-date!");
                }
            });
            return;
        }

        bool res = true;
        res &= _oldprotos.IsDMCAProofBranch 
            ? await TryRestoreDMCAProofProtos(_oldprotos, SourceRepo, 
                o.OldProtosBranch, DefaultBranchOld, DateTime.MinValue)
            : await TryRestoreProtos(_oldprotos, SourceRepo, 
                o.OldProtosBranch, DefaultBranchOld);
        res &= _newprotos.IsDMCAProofBranch
            ? await TryRestoreDMCAProofProtos(_newprotos, SourceRepo,
                o.NewProtosBranch, DefaultBranchNew, DateTime.MinValue)
            : await TryRestoreProtos(_newprotos, SourceRepo,
                o.NewProtosBranch, DefaultBranchNew);
        if (res == false)
        {
            _mainlogger.LogErro($"Process terminated because protobuf restore (update) failed. " +
                $"Exit code is 1753.");
            Environment.Exit(1753);
        }
    }

    private async Task<bool> TryRestoreProtos(GitProtosManager manager,
        string remoteUrl_git, string? branch, string default_fallback_branch)
    {
        var _logger = manager.Logger;
        string? current_branch = manager.GetCurrentBranch();
        if (branch == null)
        {
            if (current_branch == null)
            {
                _logger.LogInfo($"Not specified fetch branch. Using default: {branch}");
                branch = default_fallback_branch;
            }
            else branch = current_branch;
        }
        var protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json", manager.TryGitPullUpdate);
        bool cloned_recently = false;
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

            manager.TryAutoSwitchToBranch(branch);

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
            return await TryRestoreDMCAProofProtos(manager, redirect_url, 
                branch, default_fallback_branch, protostat.ReleaseTime);
        }
        else
        {
            _logger.LogErro($"Protobuf restore failed because of DMCA taken down.");
            return false;
        }
    }

    #region "Be grateful, Trailblazer. I've prepared everything for you."
    private async Task<bool> TryRestoreDMCAProofProtos(GitProtosManager manager,
        string remoteUrl_git, string? branch, string default_fallback_branch,
        DateTime release_time)
    {
        var _logger = Log.GetChannel($"{manager.Logger.LogSender}:DMCA");
        string? current_branch = manager.GetCurrentBranch();
        if (branch == null)
        {
            if (current_branch == null)
            {
                _logger.LogInfo($"Not specified fetch branch. Using default: {branch}");
                branch = default_fallback_branch;
            }
            else branch = current_branch;
        }
        var protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json", () =>
        {
            if (manager.TryGitPullUpdate())
            {
                // TODO: generate protos
                return true;
            }
            else
            {
                return false;
            }
        });
        bool cloned_recently = false;
        if (protostat != null)
        {
            // Notice: pre-build up-to-date check is only avaliable when
            // GitHub raw is avaliable. If not, check would require:
            // clone->read json->recover backup, which is obviously unnecessary.
            //
            // Or ask yourself a question: if you're forced to move out from
            // GitHub, then why bother maintain a json version? Why not raw protos?
            if (protostat.ReleaseTime == release_time)
            {
                _logger.LogInfo($"Local version is up-to-date with remote backup channel.");
                return true;
            }
        }

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
            // local Git repo does not exist, clone one and get protostat.json
            else if (!manager.TryCloneHere(remoteUrl_git, branch))
            {
                _mainlogger.LogErro($"Protobuf clone of branch: {branch} failed.");
                return false;
            }
            // else
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
                if (manager.TryAutoSwitchToBranch(current_branch)) ;// TODO: generate protos
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"You won't receive any newer updates until you switch to a valid branch.");
                // TODO: generate protos
                return true;
            }
        }
        else if (protostat.CurrentStat == ProtoStat.Valid)
        {
            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                if (!manager.TryCloneHere(remoteUrl_git, branch)) return false;
                // TODO: generate protos
            }
            else if (!manager.IsValidGitRepository)
            {
                _logger.LogWarn($"Is not a valid Git repository. Consider as finished so not updated, but building won't interrupt.");
                _logger.LogWarn($"You may delete the directory and use HandlerGenerator's auto cloning to use the update feature.");
                // TODO: generate protos
                return true;
            }

            if (manager.TryAutoSwitchToBranch(branch)) ;// TODO: generate protos

            if (manager.HasUpdateAvaliable())
            {
                if (!manager.TryGitPullUpdate())
                    _logger.LogWarn($"Update of this Protobuf branch probably failed.");
                else
                {
                    // TODO: generate protos
                }
            }
            else _logger.LogInfo($"This protobuf is already the latest version!");
            return true;
        }
        // else (protostat.CurrentStat == ProtoStat.DMCATakenDown)
        var redirect_url = protostat.RedirectToRepo;
        if (redirect_url != null)
        {
            _logger.LogInfo($"Protos have been DMCA taken down, redirect to another channel handler.");
            return await TryRestoreDMCAProofProtos(manager, redirect_url, branch, 
                default_fallback_branch, protostat.ReleaseTime);
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
