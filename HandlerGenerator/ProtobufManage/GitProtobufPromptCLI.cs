using csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput;
using System.Collections.Concurrent;
using System.Transactions;
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
    /// <summary>
    /// The license for generated protos (from proto2json outputs, only valid in DMCA situations).
    /// </summary>
    public readonly string PreLicense;

    public GitProtobufPromptCLI()
    {
        var branchlist = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/default_protobuf_branches.txt", 2);
        DefaultBranchOld = branchlist[0];
        DefaultBranchNew = branchlist[1];

        SourceRepo = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/protobuf_source_git.txt", 0, 1)[0]
            ?? GitProtosManager.DefaultSource;
        PreLicense = File.ReadAllText($"./Gencode_Configuration/protobuf_general_license.txt");
    }

    public async Task MainAsync(RunUpdateProtobufConfig o)
    {
        Program.AlwaysPassChoices = o.AlwaysPassChoices;
        if (o.ClearWorkspace) File.Delete("last_build_record.json");

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

        if (!GitInvoke.CheckGitInstallation())
        {
            _mainlogger.LogErro($"Git hasn't been installed properly. Exit code is 146.");
            Environment.Exit(146);
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
        #region Set remote
        if (manager.IsValidGitRepository && !manager.EnsureRemote(remoteUrl_git))
        {
            _logger.LogWarn($"Failed to set git remote to '{remoteUrl_git}'.");
            return false;
        }
        #endregion
        if (branch == null)
        {
            if (current_branch == null)
            {
                _logger.LogInfo($"Not specified fetch branch. Using default: {default_fallback_branch}");
                branch = default_fallback_branch;
            }
            else branch = current_branch;
        }
        ProtoStatInfo? protostat;
        try
        {
            protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json", manager.TryGitPullUpdate);
        }
        catch (DMCATakenDownException)
        {
            return await TryRestoreProtos(manager,
                $"{remoteUrl_git.Substring(0, remoteUrl_git.Length - ".git".Length)}_backup.git",
                branch, default_fallback_branch);
        }
        catch (Exception ex)
        {
            _logger.LogErro($"Deserialize local protostat.json failed: {ex}");
            _logger.LogErro($"The local protobuf version is invalid, delete and retry. Exit code is 6726.");
            Environment.Exit(6726);
            throw new NotImplementedException();
        }
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
            if (cloned_recently)
            {
                manager.CreateBackup("Backup_ForDeprecated");
                manager.Destroy();
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
        #region Set remote
        if (manager.IsValidGitRepository && !manager.EnsureRemote(remoteUrl_git))
        {
            _logger.LogWarn($"Failed to set git remote to '{remoteUrl_git}'.");
            return false;
        }
        #endregion
        if (branch == null)
        {
            if (current_branch == null)
            {
                _logger.LogInfo($"Not specified fetch branch. Using default: {branch}");
                branch = default_fallback_branch;
            }
            else branch = current_branch;
        }
        ProtoStatInfo? protostat;
        try
        {
            protostat = await manager.GetProtoStatInfo(remoteUrl_git, branch, "protostat.json", () =>
            {
                if (manager.TryGitPullUpdate())
                {
                    GenerateProtosFromBroken(_logger,
                        Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                        Path.Combine(manager.BaseGitDirectory, "Protos"));
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }
        catch (DMCATakenDownException)
        {
            return await TryRestoreDMCAProofProtos(manager,
                $"{remoteUrl_git.Substring(0, remoteUrl_git.Length - ".git".Length)}_backup.git",
                branch, default_fallback_branch, release_time);
        }
        catch (Exception ex)
        {
            _logger.LogErro($"Deserialize local protostat.json failed: {ex}");
            _logger.LogErro($"The local protobuf version is invalid, delete and retry. Exit code is 6726.");
            Environment.Exit(6726);
            throw new NotImplementedException();
        }
        bool cloned_recently = false;
        if (protostat != null)
        {
            // Notice: pre-build up-to-date check is only avaliable when
            // GitHub raw is avaliable. If not, check would require:
            // clone->read json->recover backup, which is obviously unnecessary.
            //
            // Or ask yourself a question: if you're forced to move out from
            // GitHub, then why bother maintain a json version? Why not raw protos?
            if (protostat.ReleaseTime <= release_time)
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
                if (!manager.IsDMCAProofBranch)
                {
                    if (QueryIfAllowSwitch(_logger))
                    {
                        /*if (!manager.DifferentFromRemote())*/
                        manager.CreateBackup("BackupBeforeDMCA");
                        manager.Destroy();
                    }
                    else
                    {
                        _logger.LogWarn($"User cancelled update channel change.");
                        return true;
                    }

                    // local Git repo does not exist, clone one and get protostat.json
                    if (!manager.TryCloneHere(remoteUrl_git, branch))
                    {
                        _mainlogger.LogErro($"Protobuf clone of branch: {branch} failed.");
                        return false;
                    }
                    else
                    {
                        GenerateProtosFromBroken(_logger,
                            Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                            Path.Combine(manager.BaseGitDirectory, "Protos"));
                    }
                }
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
            if (cloned_recently)
            {
                manager.CreateBackup("Backup_ForDeprecated");
                manager.Destroy();
            }

            if (Tools.DirNonExistsOrEmpty(manager.BaseGitDirectory))
            {
                _logger.LogErro($"Protobuf branch: {branch} has deprecated. " +
                    $"Please select a correct branch and retry.");
                return false;
            }
            else
            {
                if (manager.TryAutoSwitchToBranch(current_branch))
                {
                    GenerateProtosFromBroken(_logger,
                        Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                        Path.Combine(manager.BaseGitDirectory, "Protos"));
                }
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
                GenerateProtosFromBroken(_logger,
                    Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                    Path.Combine(manager.BaseGitDirectory, "Protos"));
            }
            else if (!manager.IsValidGitRepository)
            {
                _logger.LogWarn($"Is not a valid Git repository. Consider as finished so not updated, but building won't interrupt.");
                _logger.LogWarn($"You may delete the directory and use HandlerGenerator's auto cloning to use the update feature.");
                GenerateProtosFromBroken(_logger,
                    Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                    Path.Combine(manager.BaseGitDirectory, "Protos"));
                return true;
            }

            if (manager.TryAutoSwitchToBranch(branch))
            {
                GenerateProtosFromBroken(_logger,
                    Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                    Path.Combine(manager.BaseGitDirectory, "Protos"));
            }

            if (manager.HasUpdateAvaliable())
            {
                if (!manager.TryGitPullUpdate())
                    _logger.LogWarn($"Update of this Protobuf branch probably failed.");
                else
                {
                    GenerateProtosFromBroken(_logger,
                        Path.Combine(manager.BaseGitDirectory, "Proto2json_Output"),
                        Path.Combine(manager.BaseGitDirectory, "Protos"));
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
        if (Program.AlwaysPassChoices)
        {
            logger.LogInfo($"Because your choice in command line arguments, " +
                $"the switch will perform automatically.");
        }
        else
        {
            logger.LogWarn($"You can stop receiving any further updates or continue keeping " +
                $"your protos up-to-date by switching to another update channel.");
            logger.LogWarn($"Do you want to switch to another update channel? Type 'y' to accept.");
        }
        logger.LogInfo($"Your repository data of this version of protobuf will be reserved if " +
            $"you have ever made any changes.");
        if (Program.AlwaysPassChoices) return true;
        var confirm = Console.ReadLine();
        if (confirm?.Trim().ToLower() == "y") return true;
        else return false;
    }

    private void GenerateProtosFromBroken(LoggerChannel logger,
        string jsonPath, string outputPath)
    {
        var protojsons = Directory.EnumerateFiles(jsonPath);
        Directory.CreateDirectory(outputPath);
        ConcurrentDictionary<string, int> cmdidlist = new();
        Parallel.ForEach(protojsons, path =>
        {
            ProtoJsonResult analyzeResult = JsonAnalyzer.AnalyzeProtoJson(File.ReadAllText(path));
            foreach (var message in analyzeResult.messageBodys)
            {
                BasicCodeWriter fi = PreGenerate(outputPath, $"{message.messageName}.proto");
                SortedSet<string> imports = new();
                RegenOutputMessage.OutputMessage(ref fi, ref imports, message);
                var external_imports = from importorigin in imports
                                       let nestedIdentifier = importorigin.IndexOf('.')
                                       let importfile = (nestedIdentifier < 0)
                                           ? importorigin
                                           : importorigin.Substring(0, nestedIdentifier)
                                       where importfile != message.messageName
                                       where !message.messageFields.Any(field => field.messageName == importfile)
                                       where !message.enumFields.Any(field => field.enumName == importfile)
                                       orderby importfile
                                       select importfile;
                if (external_imports.Any()) fi.WriteLine();
                foreach (var importfile in external_imports)
                {
                    fi.WriteLine($"import \"{importfile}.proto\";");
                }
                fi.Dispose();
                var cmdidenum = message.enumFields.Find(enumResult => enumResult.enumName == "CmdId");
                if (cmdidenum != null)
                {
                    var cmdid_tuple = cmdidenum.enumNodes.Find(enumNodeTuple => enumNodeTuple.name == "CMD_ID");
                    if (cmdid_tuple.name == "CMD_ID") cmdidlist.TryAdd(message.messageName, cmdid_tuple.number);
                }
            }
            foreach (var enumResult in analyzeResult.enumBodys)
            {
                BasicCodeWriter fi = PreGenerate(outputPath, $"{enumResult.enumName}.proto");
                RegenOutputEnum.OutputEnum(ref fi, enumResult);
                fi.Dispose();
            }
        });
        logger.LogInfo($"Build from broken jsons succeeded!");

        BasicCodeWriter PreGenerate(string basedir, string fileName)
        {
            BasicCodeWriter fi = new(Path.Combine(basedir, fileName));
            fi.WriteLine(PreLicense);
            fi.WriteLine();
            fi.WriteLine("syntax = \"proto3\";");
            fi.WriteLine();
            fi.WriteLine("package miHomo.Protos;");
            fi.WriteLine();
            return fi;
        }
    }
    #endregion
}
