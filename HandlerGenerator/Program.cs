using CommandLine;
using csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;
using csharp_Protoshift.resLoader;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator;

internal class Program
{
    public static bool AlwaysPassChoices;
    public static bool PublishFailOnAfterBuildTasksFailure;

    private static async Task Main(string[] args)
    {
        Console.WriteLine($"Protoshift Ex v{Tools.ProgramVersion}");
        StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
            max_Output_Char_Count: -1,
            use_Console_Wrapper: false,
            use_Working_Directory: true,
#if DEBUG
            console_Minimum_LogLevel: LogLevel.Debug,
            global_Minimum_LogLevel: LogLevel.Verbose,
#else
            console_Minimum_LogLevel: LogLevel.Information,
            global_Minimum_LogLevel: LogLevel.Information,
#endif
            debug_LogWriter_AutoFlush: true
        ));

        GitInvoke gitinfos = new("./..");
        Log.Info("It is recommended to invoke this program with dotnet run.", "HandlerGenerator");
        Log.PushLog("PLEASE USE THIS PROGRAM ALONG WITH <color=Yellow>CLONED</color> FULL SOURCE CODE!",
            gitinfos.IsValidGitRepository ? LogLevel.Information : LogLevel.Warning, "HandlerGenerator");
#if DEBUG
        Log.Warn("The server publish won't execute as the Generator is running on DEBUG. If that's not expected, rerun it with -c=Release.");
#endif

        string res_dir = StartupWorkingDirChanger.Required_directory
            ?? throw new InvalidOperationException("Please give a correct res dir in code.");

        string workingdir = Environment.CurrentDirectory;
        DirectoryInfo _workingdirinfo = new(workingdir);
        bool passcheck = true;
        #region Find proto2json
        string proto2jsondir = $"{workingdir}/proto2json";
        if (!File.Exists($"{proto2jsondir}/go-proto2json_win32.exe"))
        {
            Log.Erro("Proto2json not found! Please make sure you're running program with dotnet run and have comiled Executable!", "ResourcesCheck");
            passcheck = false;
        }
        #endregion
        #region Check Protos
        var parser = new Parser(config =>
        {
            // Set custom ConsoleWriter during construction
            config.HelpWriter = TextWriter.Synchronized(new LogTextWriter("CommandLineParser"));
        });
        var updatecli = new GitProtobufPromptCLI();
        await parser.ParseArguments<RunUpdateProtobufConfig>(args)
            .WithNotParsed(errs =>
            {
                Log.Erro("Unrecognized args detected. Please check your input.", nameof(GitProtobufPromptCLI));
                Log.Erro("Exit code is 10085.");
                Environment.Exit(10085);
            })
            .WithParsedAsync(async opt => await updatecli.MainAsync(opt));
        string newprotodir = $"{Directory.GetParent(workingdir)}/NewProtoHandlers/Google.Protobuf/Protos";
        string oldprotodir = $"{Directory.GetParent(workingdir)}/OldProtoHandlers/Google.Protobuf/Protos";
        if (Tools.DirNonExistsOrEmpty(newprotodir))
        {
            Log.Erro("Can't find valid NewProtos dir. Please try to rerun with update script.");
            passcheck = false;
        }
        if (Tools.DirNonExistsOrEmpty(oldprotodir))
        {
            Log.Erro("Can't find valid OldProtos dir. Please try to rerun with update script.");
            passcheck = false;
        }
        Directory.CreateDirectory($"{Directory.GetParent(workingdir)}/csharp-Protoshift/resources/protobuf");
        if (File.Exists($"{Directory.GetParent(workingdir)}/OldProtoHandlers/Google.Protobuf/cmdid.csv"))
            File.Copy($"{Directory.GetParent(workingdir)}/OldProtoHandlers/Google.Protobuf/cmdid.csv",
                $"{Directory.GetParent(workingdir)}/csharp-Protoshift/resources/protobuf/oldcmdid.csv", true);
        if (File.Exists($"{Directory.GetParent(workingdir)}/NewProtoHandlers/Google.Protobuf/cmdid.csv"))
            File.Copy($"{Directory.GetParent(workingdir)}/NewProtoHandlers/Google.Protobuf/cmdid.csv",
                $"{Directory.GetParent(workingdir)}/csharp-Protoshift/resources/protobuf/newcmdid.csv", true);
        #endregion
        if (!passcheck)
        {
            Log.Erro("Process terminated for protos/proto2json executable lost. Exit code is 272574.", "ResourcesCheck");
            Environment.Exit(272574);
        }
        ResourcesLoader.CheckForRequiredResources(res_dir);
        if (!File.Exists("./../csharp-Protoshift/config.json"))
        {
            File.Copy("./../csharp-Protoshift/config_example.json", "./../csharp-Protoshift/config.json");
            Log.Warn($"config.json not found in csharp-Protoshift project path. Created default with config_example.json.");
        }
        Directory.CreateDirectory("./../OldProtoHandlers/Backup");
        Directory.CreateDirectory("./../NewProtoHandlers/Backup");
        Directory.CreateDirectory("./../ProtoshiftHandlers/ProtoDispatch/Backup");
        #region Analyze Past file
        // key is source file (will be compiled), value is backup file
        Dictionary<string, string> recoverbackups = new();
        ConsoleWrapper.ShutDownRequest += RecoverBackupAndExit;
        #region OldProtos.AskCmdId
        string askoldcmdid_filePath = "./../OldProtoHandlers/AskCmdId.cs";
        Dictionary<int, List<string>> cmd_askoldcmdid_specialHandles = new();
        if (File.Exists(askoldcmdid_filePath))
        {
            var lines = File.ReadAllLines(askoldcmdid_filePath);
            int? cur_cmd = null;
            bool isInQueryName = false;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (!isInQueryName)
                {
                    if (line.StartsWith("public static string GetProtonameFromCmdId")) isInQueryName = true;
                    continue;
                }
                if (cur_cmd == null)
                {
                    if (line.StartsWith("case ")
                        && line.EndsWith("DON'T MODIFY THIS LINE - request special handle"))
                    {
                        int startIndex = "case ".Length;
                        int endIndex = line.IndexOf(':');
                        if (int.TryParse(line.Substring(startIndex, endIndex - startIndex), out int cmd_id))
                        {
                            cur_cmd = cmd_id;
                            cmd_askoldcmdid_specialHandles.Add((int)cur_cmd, new());
                        }
                        else
                        {
                            Log.Warn("Read past file failure: OldProtoHandlers/AskCmdId.cs. This file will be overwritten.");
                            cmd_askoldcmdid_specialHandles.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    cmd_askoldcmdid_specialHandles[(int)cur_cmd].Add(line);
                    if (line.StartsWith("// DON'T MODIFY THIS LINE - end special handle"))
                    {
                        cur_cmd = null;
                        continue;
                    }
                }
            }
            string backup_askoldcmdid_path = $"./../OldProtoHandlers/Backup/AskCmdId.cs-{DateTime.Now:yyyy_MM_dd-HH_mm_ss}.cs";
            File.Move(askoldcmdid_filePath, backup_askoldcmdid_path);
            recoverbackups.Add(askoldcmdid_filePath, backup_askoldcmdid_path);
            Log.Info($"OldProtos.AskCmdId backup successfully created at {backup_askoldcmdid_path}", "AskCmdId_Generate");
        }
        #endregion
        #region NewProtos.AskCmdId
        string asknewcmdid_filePath = "./../NewProtoHandlers/AskCmdId.cs";
        Dictionary<int, List<string>> cmd_asknewcmdid_specialHandles = new();
        if (File.Exists(asknewcmdid_filePath))
        {
            var lines = File.ReadAllLines(asknewcmdid_filePath);
            int? cur_cmd = null;
            bool isInQueryName = false;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (!isInQueryName)
                {
                    if (line.StartsWith("public static string GetProtonameFromCmdId")) isInQueryName = true;
                    continue;
                }
                if (cur_cmd == null)
                {
                    if (line.StartsWith("case ")
                        && line.EndsWith("DON'T MODIFY THIS LINE - request special handle"))
                    {
                        int startIndex = "case ".Length;
                        int endIndex = line.IndexOf(':');
                        if (int.TryParse(line.Substring(startIndex, endIndex - startIndex), out int cmd_id))
                        {
                            cur_cmd = cmd_id;
                            cmd_asknewcmdid_specialHandles.Add((int)cur_cmd, new());
                        }
                        else
                        {
                            Log.Warn("Read past file failure: NewProtoHandlers/AskCmdId.cs. This file will be overwritten.");
                            cmd_asknewcmdid_specialHandles.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    cmd_asknewcmdid_specialHandles[(int)cur_cmd].Add(line);
                    if (line.StartsWith("// DON'T MODIFY THIS LINE - end special handle"))
                    {
                        cur_cmd = null;
                        continue;
                    }
                }
            }
            string backup_asknewcmdid_path = $"./../NewProtoHandlers/Backup/AskCmdId.cs-{DateTime.Now:yyyy_MM_dd-HH_mm_ss}.cs";
            File.Move(asknewcmdid_filePath, backup_asknewcmdid_path);
            recoverbackups.Add(asknewcmdid_filePath, backup_asknewcmdid_path);
            Log.Info($"NewProtos.AskCmdId backup successfully created at {backup_asknewcmdid_path}", "AskCmdId_Generate");
        }
        #endregion
        GenTemporaryAskCmdId.Run(askoldcmdid_filePath, asknewcmdid_filePath);
        #region ShiftCmdId
        string shiftCmdId_filePath = "./../ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs";
        Dictionary<int, List<string>> cmd_newshiftold_specialHandles = new();
        Dictionary<int, List<string>> cmd_oldshiftnew_specialHandles = new();
        if (File.Exists(shiftCmdId_filePath))
        {
            var lines = File.ReadAllLines(shiftCmdId_filePath);
            int? cur_cmd = null;
            bool? isInNewShiftToOld = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (isInNewShiftToOld == null)
                {
                    if (line.StartsWith("public static uint NewShiftToOld")) isInNewShiftToOld = true;
                    continue;
                }
                else if (line.StartsWith("public static uint OldShiftToNew")) isInNewShiftToOld = false;
                if (cur_cmd == null)
                {
                    if (line.StartsWith("case ")
                        && line.EndsWith("DON'T MODIFY THIS LINE - request special handle"))
                    {
                        int startIndex = "case ".Length;
                        int endIndex = line.IndexOf(':');
                        if (int.TryParse(line.Substring(startIndex, endIndex - startIndex), out int cmd_id))
                        {
                            cur_cmd = cmd_id;
                            ((bool)isInNewShiftToOld
                                ? cmd_newshiftold_specialHandles
                                : cmd_oldshiftnew_specialHandles).Add((int)cur_cmd, new());
                        }
                        else
                        {
                            Log.Warn("Read past file failure: ShiftCmdId.cs. This file will be overwritten.");
                            cmd_newshiftold_specialHandles.Clear();
                            cmd_oldshiftnew_specialHandles.Clear();
                            break;
                        }
                    }
                }
                else
                {
                    if (line.StartsWith("// DON'T MODIFY THIS LINE - end special handle"))
                    {
                        ((bool)isInNewShiftToOld
                        ? cmd_newshiftold_specialHandles
                        : cmd_oldshiftnew_specialHandles)[(int)cur_cmd].Add(line);
                        cur_cmd = null;
                        continue;
                    }
                    else ((bool)isInNewShiftToOld
                        ? cmd_newshiftold_specialHandles
                        : cmd_oldshiftnew_specialHandles)[(int)cur_cmd].Add(line);
                }
            }
            string backup_shiftCmdId_path = $"./../ProtoshiftHandlers/ProtoDispatch/Backup/ShiftCmdId-{DateTime.Now:yyyy_MM_dd-HH_mm_ss}.cs";
            File.Move(shiftCmdId_filePath, backup_shiftCmdId_path);
            recoverbackups.Add(shiftCmdId_filePath, backup_shiftCmdId_path);
            Log.Info($"ShiftCmdId backup successfully created at {backup_shiftCmdId_path}", "ShiftCmdId_Generate");
        }
        #endregion
        #endregion
        #region Smart Compiling
        Stopwatch rebuildWatcher_watch = Stopwatch.StartNew();
        bool needRebuild = true;
        RebuildWatcher? rebuildWatcher_past = null;
        if (File.Exists("last_build_record.json"))
        {
            Log.Info($"Reading last build record from jsonfile, it'll take some time...", nameof(RebuildWatcher));
            rebuildWatcher_past = RebuildWatcher.DeserializeFromJson(await File.ReadAllTextAsync("last_build_record.json"));
            needRebuild = rebuildWatcher_past.NeedRebuild;
        }
        rebuildWatcher_watch.Stop();
        Log.Info($"Rebuild judge completed (need rebuild: {needRebuild}), costed {rebuildWatcher_watch.Elapsed}.", nameof(RebuildWatcher));
        if (needRebuild)
        {
            #region Compile Protos (protoc)
            Stopwatch protocWatch = Stopwatch.StartNew();
            Log.Info($"Start compiling protos (protoc), it will take some time...");
            Directory.CreateDirectory("./../OldProtoHandlers/Google.Protobuf/Compiled");
            Directory.CreateDirectory("./../NewProtoHandlers/Google.Protobuf/Compiled");
            // The arguments for compiling protos. Used for a buffer. 
            StringBuilder compile_oldprotos = new();
            StringBuilder compile_newprotos = new();
            // This is the actually used argument list (each
            // correspond to a 'protoc' worker process)
            List<string> compile_oldproto_cmds = new List<string>();
            List<string> compile_newproto_cmds = new List<string>();
            // .cs files used for rewrite compiled proto namespace.
            List<string> compiled_csfilenames_old = new();
            List<string> compiled_csfilenames_new = new();
            #region Desync detect
            // when the compiled .cs files desync with the original
            // protos, all protos should be recompiled.
            var targetpath_old = Path.GetFullPath("./../OldProtoHandlers/Google.Protobuf");
            var targetpath_new = Path.GetFullPath("./../NewProtoHandlers/Google.Protobuf");
            if ((Directory.EnumerateFiles($"{targetpath_old}/Compiled").Count() !=
                 Directory.EnumerateFiles($"{targetpath_old}/Protos").Count()) ||
                (Directory.EnumerateFiles($"{targetpath_new}/Compiled").Count() !=
                 Directory.EnumerateFiles($"{targetpath_new}/Protos").Count()))
            {
                Log.Info($"Detect desync for protos and compiled .cs files. " +
                    $"All protos will be recompiled and may take more time than expected.");
                rebuildWatcher_past = null;
            }
            #endregion

            if (rebuildWatcher_past == null || rebuildWatcher_past.NeedRebuild)
            {
                // Removed partly rebuild code (only compile the changed protos),
                // because not only the changed protos need to recompile, but
                // those referring to them also need to be recompiled.
                //
                // Maybe there's a solution:
                // proto2json first -> analyze -> smart compile, but im lazy
                // and don't want to add bricks to code with a maintainability
                // index of zero any more.
                //
                // For code in the past, see pull request: branch='gcg-optimize',
                // name='Optimize GCG proto handling & Building Process'.
                #region OldProtos
                // true = Need Rebuild, false = Not Need Rebuild, null = Brand New
                if (rebuildWatcher_past?.rebuild_files_relative_list[targetpath_old].Any() != false)
                {
                    var oldproto_files = Directory.EnumerateFiles(
                        "./../OldProtoHandlers/Google.Protobuf/Protos",
                        "*.proto", SearchOption.AllDirectories);
                    foreach (var proto_file in oldproto_files)
                    {
                        if (Path.GetExtension(proto_file) == ".proto")
                        {
                            var name_withoutext = Path.GetFileNameWithoutExtension(proto_file);
                            compiled_csfilenames_old.Add(name_withoutext);
                            var appendcmd = $" \"{Path.GetRelativePath("./..", proto_file)}\"";
                            if (compile_oldprotos.Length + appendcmd.Length
                                >= OuterInvokeGlobalConfig.maximum_createproc_length)
                            {
                                compile_oldproto_cmds.Add(compile_oldprotos.ToString());
                                compile_oldprotos = new();
                            }
                            compile_oldprotos.Append(appendcmd);
                        }
                    }
                    if (compile_oldprotos.Length > 0) compile_oldproto_cmds.Add(compile_oldprotos.ToString());
                }
                #endregion
                #region NewProtos
                if (rebuildWatcher_past?.rebuild_files_relative_list[targetpath_new].Any() != false)
                {
                    var newproto_files = Directory.EnumerateFiles(
                    "./../NewProtoHandlers/Google.Protobuf/Protos",
                    "*.proto", SearchOption.AllDirectories);
                    foreach (var proto_file in newproto_files)
                    {
                        if (Path.GetExtension(proto_file) == ".proto")
                        {
                            var name_withoutext = Path.GetFileNameWithoutExtension(proto_file);
                            compiled_csfilenames_new.Add(name_withoutext);
                            var appendcmd = $" \"{Path.GetRelativePath("./..", proto_file)}\"";
                            if (compile_newprotos.Length + appendcmd.Length
                                >= OuterInvokeGlobalConfig.maximum_createproc_length)
                            {
                                compile_newproto_cmds.Add(compile_newprotos.ToString());
                                compile_newprotos = new();
                            }
                            compile_newprotos.Append(appendcmd);
                        }
                    }
                    if (compile_newprotos.Length > 0) compile_newproto_cmds.Add(compile_newprotos.ToString());
                }
                #endregion
            }
            await OuterInvoke.RunMultiple((
                from oldproto_files in compile_oldproto_cmds
                select new OuterInvokeInfo
                {
                    ProcessPath = OuterInvokeGlobalConfig.protoc_path,
                    WorkingDir = "./..",
                    AutoTerminateReason = $"OldProtos compiling (protoc) failed.",
                    CmdLine = $"--proto_path=\"OldProtoHandlers/Google.Protobuf/Protos\" " +
                           $"--csharp_out=\"OldProtoHandlers/Google.Protobuf/Compiled\"{oldproto_files}"
                }
                ).Concat(
                from newproto_files in compile_newproto_cmds
                select new OuterInvokeInfo
                {
                    ProcessPath = OuterInvokeGlobalConfig.protoc_path,
                    WorkingDir = "./..",
                    AutoTerminateReason = $"NewProtos compiling (protoc) failed.",
                    CmdLine = $"--proto_path=\"NewProtoHandlers/Google.Protobuf/Protos\" " +
                           $"--csharp_out=\"NewProtoHandlers/Google.Protobuf/Compiled\"{newproto_files}"
                }).ToList(), 20041);
            protocWatch.Stop();
            Log.Info($"Protoc compiling finished, elapsed {protocWatch.Elapsed}.");
            await Tools.RewriteProtoNamespaceAsync("OldProtos",
                (from compiledfile in compiled_csfilenames_old
                 select Path.Combine("./../OldProtoHandlers/Google.Protobuf/Compiled",
                    $"{compiledfile.Replace("_", "")}.cs")).ToList());
            await Tools.RewriteProtoNamespaceAsync("NewProtos",
                (from compiledfile in compiled_csfilenames_new
                 select Path.Combine("./../NewProtoHandlers/Google.Protobuf/Compiled",
                    $"{compiledfile.Replace("_", "")}.cs")).ToList());
            #endregion
            // The protos compiled here is just for checking,
            // so though there's a switch from Debug to Release,
            // they won't need to be compiled again by the Generator.
            // Just leave the task to dotnet publish.
            #region Compile Protos (C#)
            var runres = await OuterInvoke.RunMultiple(new OuterInvokeInfo
            {
                ProcessPath = OuterInvokeGlobalConfig.dotnet_path,
#if DEBUG
                CmdLine = "build",
#else
                CmdLine = "build --configuration=Release",
#endif
                StartingNotice = "Compiling OldProtos (dotnet), please wait...",
                AutoTerminateReason = "OldProtos compiling (invoke dotnet) failed.",
                WorkingDir = "./../OldProtoHandlers"
            }, new OuterInvokeInfo
            {
                ProcessPath = OuterInvokeGlobalConfig.dotnet_path,
#if DEBUG
                CmdLine = "build",
#else
                CmdLine = "build --configuration=Release",
#endif
                StartingNotice = "Compiling NewProtos (dotnet), please wait...",
                AutoTerminateReason = "NewProtos compiling (invoke dotnet) failed.",
                WorkingDir = "./../NewProtoHandlers"
            }, 60);
            #endregion
            #region Invoke proto2json
            if (Directory.Exists($"{workingdir}/Proto2json_Output"))
            {
                Log.Info("Detected old output directory, deleting...");
                Directory.Delete($"{workingdir}/Proto2json_Output", true);
            }
            Log.Info("Start invoking proto2json.exe. Please wait patiently...", "OuterInvoke");
            Stopwatch pinvokewatch = Stopwatch.StartNew();
            #region Split OS
            // Generated by Cursor
            // Fuck Cursor
            string proto2json_invokestr = "";
            string arch = Environment.Is64BitOperatingSystem ? "64" : "32";
            #region Windows
            if (OperatingSystem.IsWindows())
            {
                Log.Dbug($"Found OS Type: Windows x{arch}.", "OuterInvoke");
                proto2json_invokestr = $"{proto2jsondir}/go-proto2json_win{arch}.exe";
            }
            #endregion
            #region macOS
            else if (OperatingSystem.IsMacOS())
            {
                Log.Dbug($"Found OS Type: macOS x{arch}.", "OuterInvoke");
                Log.Dbug($"Assigning chmod +x...");
                proto2json_invokestr = $"{proto2jsondir}/go-proto2json_mac{arch}";
                await OuterInvoke.Run(new OuterInvokeInfo
                {
                    ProcessPath = "chmod",
                    CmdLine = $"+x {proto2json_invokestr}"
                });
            }
            #endregion
            #region Linux
            else if (OperatingSystem.IsLinux())
            {
                Log.Dbug($"Found OS Type: Linux x{arch}.", "OuterInvoke");
                Log.Dbug($"Assigning chmod +x...");
                proto2json_invokestr = $"{proto2jsondir}/go-proto2json_linux{arch}";
                await OuterInvoke.Run(new OuterInvokeInfo
                {
                    ProcessPath = "chmod",
                    CmdLine = $"+x {proto2json_invokestr}"
                });
            }
            #endregion
            else
            {
                Log.Erro($"Unsupported OS detected! OS: {Environment.OSVersion.Platform} x{arch}. Please report this to Issues of this project.", "OuterInvoke");
                Log.Erro("Process terminated for unsupported OS. Exit code is 100.", "OuterInvoke");
                Environment.Exit(100);
            }
            #endregion
            Log.Dbug($"Using proto2json at path {proto2jsondir}.");
            await OuterInvoke.Run(new OuterInvokeInfo
            {
                ProcessPath = proto2json_invokestr,
                AutoTerminateReason = "Process terminated for proto2json not working properly.",
                WorkingDir = proto2jsondir
            }, 3300);
            pinvokewatch.Stop();
            Log.Info($"proto2json exited. Total execute time is {pinvokewatch.Elapsed}.", "OuterInvoke");
            #endregion
        }
        if (needRebuild)
        {
            Log.Info($"Capturing build status from directories, it'll take some time...", nameof(RebuildWatcher));
            RebuildWatcher rebuildWatcher = new();
            rebuildWatcher.CaptureDirectory($"./../OldProtoHandlers/Google.Protobuf");
            rebuildWatcher.CaptureDirectory($"./../NewProtoHandlers/Google.Protobuf");
            await File.WriteAllTextAsync("last_build_record.json", rebuildWatcher.SerializeToJson());
        }
        string newoutputdir = $"{workingdir}/Proto2json_Output/new";
        string oldoutputdir = $"{workingdir}/Proto2json_Output/old";
        if (Tools.DirNonExistsOrEmpty(newoutputdir) || Tools.DirNonExistsOrEmpty(oldoutputdir))
        {
            Log.Erro("Process terminated for proto2json output directories not found. Exit code is 245.", "OuterInvoke");
            Environment.Exit(245);
        }
        #endregion
        ConcurrentBag<MessageResult> oldmessages = new();
        ConcurrentBag<MessageResult> newmessages = new();
        ConcurrentBag<EnumResult> oldenums = new();
        ConcurrentBag<EnumResult> newenums = new();
        #region Analyze Output
        #region Enumerate Files
        var oldprotojsons = Directory.EnumerateFiles(oldoutputdir);
        var newprotojsons = Directory.EnumerateFiles(newoutputdir);
        var oldenumCollections = new CompiledEnumsStringPoolCollection();
        var newenumCollections = new CompiledEnumsStringPoolCollection();
        Parallel.ForEach(oldprotojsons, path =>
        {
            oldenumCollections.AddCodeFile($"./../OldProtoHandlers/Google.Protobuf/Compiled/" +
                $"{Path.GetFileNameWithoutExtension(path).Replace("_", "")}.cs");
            ProtoJsonResult analyzeResult = JsonAnalyzer.AnalyzeProtoJson(File.ReadAllText(path));
            foreach (var message in analyzeResult.messageBodys)
            {
                oldmessages.Add(message);
            }
            foreach (var enumResult in analyzeResult.enumBodys)
            {
                oldenums.Add(enumResult);
            }
        });
        Log.Info($"OldProtos: read {oldmessages.Count} messages, {oldenums.Count} enums.");
        Parallel.ForEach(newprotojsons, path =>
        {
            newenumCollections.AddCodeFile($"./../NewProtoHandlers/Google.Protobuf/Compiled/" +
                $"{Path.GetFileNameWithoutExtension(path).Replace("_", "")}.cs");
            ProtoJsonResult analyzeResult = JsonAnalyzer.AnalyzeProtoJson(File.ReadAllText(path));
            foreach (var message in analyzeResult.messageBodys)
            {
                newmessages.Add(message);
            }
            foreach (var enumResult in analyzeResult.enumBodys)
            {
                newenums.Add(enumResult);
            }
        });
        Log.Info($"NewProtos: read {newmessages.Count} messages, {newenums.Count} enums.");
        #endregion
        CollectionResult<MessageResult> messageResults =
            CollectionHelper.GetCompareResult(oldmessages, newmessages, MessageResult.NameComparer);
        CollectionResult<EnumResult> enumResults =
            CollectionHelper.GetCompareResult(oldenums, newenums, EnumResult.NameComparer);
        #region Generate Message Handlers
        if (Directory.Exists($"./../ProtoshiftHandlers/Generated"))
        {
            Log.Info($"Detected old Protoshift handlers, deleting...");
            try
            {
                Directory.Delete($"./../ProtoshiftHandlers/Generated", true);
            }
            catch (Exception ex)
            {
                if (Directory.Exists($"./../ProtoshiftHandlers/Generated")
                    && Directory.EnumerateFiles($"./../ProtoshiftHandlers/Generated").Any())
                {
                    Log.Erro($"Deleting past handlers failed: {ex}");
                    if (AlwaysPassChoices)
                    {
                        Log.Info($"Because -y is enabled, building can't continue. Exit code is 1.");
                        Environment.Exit(1);
                    }
                    while (true)
                    {
                        Log.Warn($"Please manually delete the directory {Path.GetFullPath("./../ProtoshiftHandlers/Generated")} " +
                            $"(or all files in it) and press enter to continue.");
                        Console.ReadLine();
                        if (Directory.Exists($"./../ProtoshiftHandlers/Generated")
                            && Directory.EnumerateFiles($"./../ProtoshiftHandlers/Generated").Any())
                        {
                            Log.Erro($"Generator won't continue as the directory persists and it's not empty.");
                        }
                        else break;
                    }
                }
            }
        }
        Directory.CreateDirectory($"./../ProtoshiftHandlers/Generated");
        Directory.CreateDirectory($"./../ProtoshiftHandlers/ProtoDispatch");
        Log.Info("Start generating Protoshift Handlers, please wait patiently...");
        foreach (var shiftpair in messageResults.IntersectItems)
        {
            string msgName = shiftpair.LeftItem.messageName;
            string filePath = $"./../ProtoshiftHandlers/Generated/Handler{msgName}.cs";
            BasicCodeWriter fi = new(filePath);
            fi.WriteLine("// <auto-generated>");
            fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator. ");
            fi.WriteLine("// </auto-generated>");
            fi.WriteLine();
            fi.WriteLine("#nullable enable");
            fi.WriteLine("#region Designer Generated Code");
            fi.WriteLine("using csharp_Protoshift.ProtoHotPatch;");
            fi.WriteLine("using Google.Protobuf;");
            fi.WriteLine("using Google.Protobuf.Collections;");
            fi.WriteLine("using Google.Protobuf.Reflection;");
            fi.WriteLine("using System.Collections.Generic;");
            fi.WriteLine();
            fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
            fi.EnterCodeRegion();
            HandlerCodeWriter.GenerateMessageHandler(ref fi, msgName,
                shiftpair.LeftItem, shiftpair.RightItem,
                oldenumCollections, newenumCollections);
            fi.ExitCodeRegion();
            fi.WriteLine("#nullable disable");
            fi.WriteLine("#endregion Designer generated code");
            fi.Dispose();
        }
        foreach (var shiftpair in enumResults.IntersectItems)
        {
            string enumName = shiftpair.LeftItem.enumName;
            string filePath = $"./../ProtoshiftHandlers/Generated/Handler{enumName}.cs";
            BasicCodeWriter fi = new(filePath);
            fi.WriteLine("// <auto-generated>");
            fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator. ");
            fi.WriteLine("// </auto-generated>");
            fi.WriteLine();
            fi.WriteLine("#region Designer Generated Code");
            fi.WriteLine("using Google.Protobuf;");
            fi.WriteLine();
            fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
            fi.EnterCodeRegion();
            HandlerCodeWriter.GenerateEnumHandler(ref fi, enumName, shiftpair.LeftItem, shiftpair.RightItem,
                oldenumCollections.Query(enumName), newenumCollections.Query(enumName));
            fi.ExitCodeRegion();
            fi.WriteLine("#endregion Designer generated code");
            fi.Dispose();
        }
        #endregion
        #endregion
        #region Special Handlers
        var handlerignores = TxtReader.ReadFrom("./Gencode_Configuration/handlerignore.txt");
        Directory.CreateDirectory("./../ProtoshiftHandlers/SpecialHandlers");
        foreach (var ignore in handlerignores)
        {
            string fromFilePath = $"./../ProtoshiftHandlers/Generated/Handler{ignore}.cs";
            string dstFilePath = $"./../ProtoshiftHandlers/SpecialHandlers/Handler{ignore}.cs";
            if (!File.Exists(fromFilePath))
            {
                Log.Warn($"{ignore} is not a valid proto and will be skipped. Please check ./Gencode_Configuration/handlerignore.txt.", "HandlerIgnore_conf");
                continue;
            }
            if (File.Exists(dstFilePath)) File.Delete(fromFilePath);
            else File.Move(fromFilePath, dstFilePath);
        }
        #endregion
        Log.Info("Conguratulations! Protoshift handlers generated successfully.");
        Log.Info("Now generating CmdId related and ProtoshiftDispatch...");
        CmdIdDataStructure cmdData = new($"{res_dir}/protobuf/oldcmdid.csv",
            $"{res_dir}/protobuf/newcmdid.csv", messageResults);

        #region Generate CmdId related
        GenTemporaryAskCmdId.Clear(askoldcmdid_filePath, asknewcmdid_filePath);
        GenAskCmdId.Run(cmdData, askoldcmdid_filePath, asknewcmdid_filePath,
            cmd_askoldcmdid_specialHandles, cmd_asknewcmdid_specialHandles);
        recoverbackups.Remove(askoldcmdid_filePath);
        recoverbackups.Remove(asknewcmdid_filePath);
        GenShiftCmdId.Run(cmdData, shiftCmdId_filePath,
            cmd_oldshiftnew_specialHandles, cmd_newshiftold_specialHandles);
        recoverbackups.Remove(shiftCmdId_filePath);
        #endregion
        #region Generate Protoshift Dispatch
        #region Analyze Past file
        string protoshiftDispatch_filePath = "./../ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs";
        var mergeChanges = new List<Dictionary<string, MergeChange>>();
        if (File.Exists(protoshiftDispatch_filePath))
        {
            var lines = File.ReadAllLines(protoshiftDispatch_filePath);
            bool inMergableRegion = false;
            int applyToMethod = 0;
            bool pullUp_for_unrecogized_proto = false;
            string? curproto = null;
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Trim();
                if (line.StartsWith("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/"))
                {
                    inMergableRegion = true;
                    mergeChanges.Add(new());
                }
                else if (line.StartsWith("/***********End mergable region --- DO NOT EDIT THIS LINE***********/"))
                {
                    inMergableRegion = false;
                    applyToMethod++;
                }
                else if (inMergableRegion && line.StartsWith("case"))
                {
                    if (line.EndsWith(" - merge - ignore case"))
                    {
                        int startIndex = line.IndexOf("// ") + 3;
                        int endIndex = line.IndexOf(" - merge - ignore case");
                        curproto = line.Substring(startIndex, endIndex - startIndex);
                        if (!cmdData.messages_havecmdid.Contains(curproto))
                        {
                            Log.Warn($"Human modification of Proto: {curproto} can't be applied because it isn't assigned cmd_id and isn't a sendable message. ");
                            pullUp_for_unrecogized_proto = true;
                        }
                    }
                    else if (line.EndsWith("merge - Generated Code"))
                    {
                        curproto = null;
                    }
                }
                else if (inMergableRegion && curproto != null)
                {
                    if (!mergeChanges[applyToMethod].ContainsKey(curproto))
                        mergeChanges[applyToMethod].Add(curproto, new MergeChange { ProtoName = curproto });
                    mergeChanges[applyToMethod][curproto].CodeLines.Add(line);
                }
            }
            if (pullUp_for_unrecogized_proto)
            {
                if (AlwaysPassChoices)
                {
                    Log.Warn($"Detected unmergable changes. Continue because -y option is enabled.");
                }
                else
                {
                    Log.Warn("Detected unmergable changes. If you think it's unexpected, please change ProtoshiftDispatch.cs and restart.", "ProtoshiftDispatch_Generate");
                    Log.Info("If you want to discard these changes, type 'y' to continue.", "ProtoshiftDispatch_Generate");
                    string? confirm = Console.ReadLine();
                    if (confirm?.Trim().ToLower() != "y")
                    {
                        Log.Erro("Process terminated for user request review. Exit Code is 76.", "ProtoshiftDispatch_Generate");
                        Log.Info("Press any key to exit...", "ProtoshiftDispatch_Generate");
                        Console.ReadLine();
                        Environment.Exit(76);
                    }
                }
            }
            string backup_protoshift_dispatch_path = $"./../ProtoshiftHandlers/ProtoDispatch/Backup/ProtoshiftDispatch-{DateTime.Now:yyyy_MM_dd-HH_mm_ss}.cs";
            File.Move(protoshiftDispatch_filePath, backup_protoshift_dispatch_path);
            recoverbackups.Add(protoshiftDispatch_filePath, backup_protoshift_dispatch_path);
            Log.Info($"ProtoshiftDispatch backup successfully created at {backup_protoshift_dispatch_path}", "ProtoshiftDispatch_Generate");
        }
        else
        {
            for (int i = 0; i < 6; i++) mergeChanges.Add(new());
        }
        #endregion
        GenProtoshiftDispatch.Run(cmdData, protoshiftDispatch_filePath, mergeChanges);
        recoverbackups.Remove(protoshiftDispatch_filePath);
        #endregion

        Log.Info("Protoshift enhanced handlers generated! ");
#if DEBUG
        if (!AlwaysPassChoices)
        {
            Log.Info("Press any key to exit.");
            Console.ReadLine();
        }
#else
        Log.Info($"Now publishing...", "Release-Publish");
        string output_path = "./../Builds/";
        string? shavalue = null;
        #region Get output Path
        if (gitinfos.IsValidGitRepository)
        {
            ProcessStartInfo startInfo = new(OuterInvokeGlobalConfig.git_path)
            {
                WorkingDirectory = "./..",
                Arguments = "rev-parse HEAD",
                RedirectStandardOutput = true
            };
            try
            {
                var p = Process.Start(startInfo);
                if (p == null)
                {
                    Log.Warn($"Start git failed, using time to identify build.", "Release-Publish");
                    output_path += $"output_{DateTime.Now:yyyyMMdd_HH-mm-ss}";
                }
                else
                {
                    p.WaitForExit();
                    if (p.ExitCode != 0 || string.IsNullOrEmpty(shavalue = p.StandardOutput.ReadToEnd().Trim()))
                    {
                        Log.Warn($"git rev-parse HEAD exited with code {p.ExitCode}, using time to identify build.", "Release-Publish");
                        output_path += $"output_{DateTime.Now:yyyyMMdd_HH-mm-ss}";
                    }
                    else
                    {
                        output_path += $"output_{DateTime.Today:yyyyMMdd}_{shavalue.Substring(0, 10)}";
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Erro(ex.ToString(), "Release-Publish");
                Log.Warn($"git rev-parse HEAD invoke failed, using time to identify build.", "Release-Publish");
                output_path += $"output_{DateTime.Now:yyyyMMdd_HH-mm-ss}";
            }
        }
        else
        {
            Log.Warn($"Not a git repository. Using time to identify build.", "Release-Publish");
            output_path += $"output_{DateTime.Now:yyyyMMdd_HH-mm-ss}";
        }
        #endregion

        string output_bin_path = $"{output_path}/bin";
        Directory.CreateDirectory(output_bin_path);
        Log.Info($"Build will be generated at {Path.GetFullPath(output_path)}.", "Release-Publish");
        #region Build info
        Log.Info($"Writing build info...", "Release-Publish");
        using (StreamWriter buildinfofile = new($"{output_path}/Build_Info.txt"))
        {
            buildinfofile.WriteLine($"YYHEggEgg/csharp-Protoshift build v{Tools.ProgramVersion}");
            buildinfofile.WriteLine();
            buildinfofile.WriteLine($"Built by YYHEggEgg/csharp-Protoshift.HandlerGenerator.");
            buildinfofile.WriteLine($"Build time: {DateTime.Now}");
            #region Get Infos
            string? author = gitinfos.GetGlobalAuthor();
            string? email = gitinfos.GetGlobalEmail();
            string? curbranch = gitinfos.GetCurrentBranch();
            string? last_commit_author = gitinfos.GetLastCommitAuthor();
            string? last_commit_email = gitinfos.GetLastCommitEmail();
            string? last_commit_time = gitinfos.GetLastCommitTime();
            #endregion
            if (author != null)
            {
                buildinfofile.WriteLine($"Builder: {author ?? "<unknown>"} ({email ?? "<email unknown>"})");
            }
            if (curbranch != null)
            {
                buildinfofile.WriteLine($"Built on branch: {curbranch}");
            }
            buildinfofile.WriteLine();
            if (shavalue != null)
            {
                buildinfofile.WriteLine($"Last commit: {shavalue}");
                buildinfofile.WriteLine($"Created by {last_commit_author ?? "<unknown>"} " +
                    $"({last_commit_email ?? "<email unknown>"}) on: {last_commit_time ?? "<unknown>"}");
            }
        }
        #endregion
        string dotnet_build_cmd = $"build --configuration=Release";
        string dotnet_publish_cmd = $"publish --no-build --configuration=Release -o {output_bin_path}";
        await OuterInvoke.RunMultiple(new OuterInvokeInfo
        {
            ProcessPath = OuterInvokeGlobalConfig.dotnet_path,
            StartingNotice = $"Start building: dotnet {dotnet_build_cmd}",
            CmdLine = dotnet_build_cmd,
            AutoTerminateReason = $"dotnet pre-publish build failed. ",
            WorkingDir = "./../csharp-Protoshift"
        }, new OuterInvokeInfo
        {
            ProcessPath = OuterInvokeGlobalConfig.dotnet_path,
            StartingNotice = $"Start publishing: dotnet {dotnet_publish_cmd}",
            CmdLine = dotnet_publish_cmd,
            AutoTerminateReason = $"dotnet after-build publish failed. ",
            WorkingDir = "./../csharp-Protoshift"
        }, 2910);
        #region After-builds tasks
        Log.Info($"dotnet build & publish succeeded. Now copying resources...");
        File.Copy($"./../csharp-Protoshift/config.json", $"{output_path}/config.json");
        string output_res_dir = $"{output_path}/resources";
        Tools.CopyDir("./../csharp-Protoshift/resources", output_res_dir);

        Log.Info($"Create launch file...");
        await File.WriteAllTextAsync($"{output_path}/run", 
            "#!/bin/bash\ndotnet ./bin/csharp-Protoshift.dll $*");
        await File.WriteAllTextAsync($"{output_path}/run.bat", "dotnet ./bin/csharp-Protoshift.dll %*");
        if (!OperatingSystem.IsWindows())
        {
            await OuterInvoke.Run(new OuterInvokeInfo
            {
                ProcessPath = "chmod",
                CmdLine = $"+x {output_path}/run",
            });

            // After-build tasks
            var afterbuild_shell = Path.GetFullPath("Gencode_Configuration/afterbuild_task_unix.sh");
            if (File.Exists(afterbuild_shell))
            {
                #region Read running target
                string run_program = "/bin/bash"; // default
                var readres = File.ReadLines(afterbuild_shell).First();
                if (readres != null && readres.StartsWith("#!")) 
                    run_program = readres["#!".Length..].Trim();
                #endregion
                await OuterInvoke.Run(new OuterInvokeInfo
                {
                    ProcessPath = run_program,
                    StartingNotice = $"The custom after-build task ({run_program}) is starting...",
                    CmdLine = $"\"{afterbuild_shell}\" \"{Path.GetFullPath(output_path)}\"",
                    AutoTerminateReason = PublishFailOnAfterBuildTasksFailure
                        ? "The custom after-build task (Unix) failed. " : null,
                }, 3400);
                }
        }
        else 
        {
            // After-build tasks
            var afterbuild_shell = Path.GetFullPath("Gencode_Configuration/afterbuild_task_win.ps1");
            if (File.Exists(afterbuild_shell))
            {
                await OuterInvoke.Run(new OuterInvokeInfo
                {
                    ProcessPath = OuterInvokeGlobalConfig.windows_powershell_path,
                    StartingNotice = $"The custom after-build task (powershell.exe) is starting...",
                    CmdLine = $"\"{afterbuild_shell}\" \"{Path.GetFullPath(output_path)}\"",
                    AutoTerminateReason = PublishFailOnAfterBuildTasksFailure
                        ? "The custom after-build task (Windows) failed. " : null,
                }, 3400);
            }
        }

        #endregion
        Log.Info($"Publish completed! Process will terminate in 3s.");
        await Task.Delay(3000);
#endif

        /// <summary>
        /// A recovery method used by <see cref="AppDomain.ProcessExit"/>.
        /// </summary>
        void RecoverBackupAndExit(object? sender, EventArgs? args)
        {
            foreach (var recovery in recoverbackups)
            {
                try
                {
                    File.Move(recovery.Value, recovery.Key, true);
                }
                catch { }
            }
            Environment.Exit(0);
        }
    }
}

internal class MergeChange
{
    public string ProtoName = "";
    public List<string> CodeLines = new();
}