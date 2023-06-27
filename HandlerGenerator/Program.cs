using csharp_Protoshift.Enhanced.Handlers.Generator;
using csharp_Protoshift.resLoader;
using System.Collections.Concurrent;
using System.Diagnostics;
using YYHEggEgg.Logger;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Protoshift Ex v1");
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

Log.Info("It is recommended to invoke this program with dotnet run.", "HandlerGenerator");
Log.Warn("PLEASE USE THIS PROGRAM ALONG WITH FULL SOURCE CODE!", "HandlerGenerator");
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
string newprotodir = $"{Directory.GetParent(workingdir)}/NewProtoHandlers/Google.Protobuf/Protos";
string oldprotodir = $"{Directory.GetParent(workingdir)}/OldProtoHandlers/Google.Protobuf/Protos";
if (!Directory.Exists(newprotodir))
{
    Log.Erro("Can't find NewProtos dir! Make sure to use this programs along with full source code!");
    passcheck = false;
}
if (!Directory.Exists(oldprotodir))
{
    Log.Erro("Can't find OldProtos dir! Make sure to use this programs along with full source code!");
    passcheck = false;
}
#endregion
if (!passcheck)
{
    Log.Erro("Process terminated for protos/proto2json executable lost. Exit code is 272574.", "ResourcesCheck");
    Console.ReadLine();
    Environment.Exit(272574);
}
ResourcesLoader.CheckForRequiredResources();
Directory.CreateDirectory("./../OldProtoHandlers/Backup");
Directory.CreateDirectory("./../NewProtoHandlers/Backup");
Directory.CreateDirectory("./../ProtoshiftHandlers/ProtoDispatch/Backup");
#region Analyze Past file
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
    Log.Info($"NewProtos.AskCmdId backup successfully created at {backup_asknewcmdid_path}", "AskCmdId_Generate");
}
#endregion
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
    File.Move("./../ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs", backup_shiftCmdId_path);
    Log.Info($"ShiftCmdId backup successfully created at {backup_shiftCmdId_path}", "ShiftCmdId_Generate");
}
#endregion
#endregion
#region Smart Compiling
Stopwatch rebuildWatcher_watch = Stopwatch.StartNew();
bool needRebuild = true;
if (File.Exists("last_build_record.json"))
{
    Log.Info($"Reading last build record from jsonfile, it'll take some time...", nameof(RebuildWatcher));
    RebuildWatcher rebuildWatcher = RebuildWatcher.DeserializeFromJson(await File.ReadAllTextAsync("last_build_record.json"));
    needRebuild = rebuildWatcher.NeedRebuild;
}
rebuildWatcher_watch.Stop();
Log.Info($"Rebuild judge completed (need rebuild: {needRebuild}), costed {rebuildWatcher_watch.Elapsed}.", nameof(RebuildWatcher));
if (needRebuild)
{
    #region Compile Protos (protoc)
    Stopwatch protocWatch = Stopwatch.StartNew();
    Log.Info("Start compiling protos (protoc), it will take some time...");
    Directory.CreateDirectory("./../OldProtoHandlers/Google.Protobuf/Compiled");
    Directory.CreateDirectory("./../NewProtoHandlers/Google.Protobuf/Compiled");
    List<OuterInvokeInfo> protoc_invokes = new();
    #region OldProtos
    var oldproto_files = Directory.EnumerateFiles(
        "./../OldProtoHandlers/Google.Protobuf/Protos",
        "*.proto", SearchOption.AllDirectories);
    foreach (var proto_file in oldproto_files)
    {
        protoc_invokes.Add(new OuterInvokeInfo
        {
            ProcessPath = OuterInvokeConfig.protoc_path,
            WorkingDir = "./..",
            AutoTerminateReason = $"Proto: {Path.GetFileNameWithoutExtension(proto_file)} compiling (protoc) failed.",
            CmdLine = ("--proto_path=\"OldProtoHandlers/Google.Protobuf/Protos\" \"" +
                Path.GetRelativePath("./../OldProtoHandlers/Google.Protobuf/Protos", proto_file) +
                "\" --csharp_out=\"OldProtoHandlers/Google.Protobuf/Compiled\"")
        });
    }
    #endregion
    #region NewProtos
    var newproto_files = Directory.EnumerateFiles(
        "./../NewProtoHandlers/Google.Protobuf/Protos",
        "*.proto", SearchOption.AllDirectories);
    foreach (var proto_file in newproto_files)
    {
        protoc_invokes.Add(new OuterInvokeInfo
        {
            ProcessPath = OuterInvokeConfig.protoc_path,
            WorkingDir = "./..",
            AutoTerminateReason = $"Proto: {Path.GetFileNameWithoutExtension(proto_file)} compiling (protoc) failed.",
            CmdLine = ("--proto_path=\"NewProtoHandlers/Google.Protobuf/Protos\" \"" +
                Path.GetRelativePath("./../NewProtoHandlers/Google.Protobuf/Protos", proto_file) +
                "\" --csharp_out=\"NewProtoHandlers/Google.Protobuf/Compiled\"")
        });
    }
    #endregion
    await OuterInvoke.RunMultiple(protoc_invokes, 20041);
    protocWatch.Stop();
    Log.Info($"Protoc compiling finished, elapsed {protocWatch.Elapsed}.");
    #endregion
    #region Compile Protos (C#)
    await OuterInvoke.RunMultiple(new OuterInvokeInfo
    {
        ProcessPath = OuterInvokeConfig.dotnet_path,
        CmdLine = "build",
        StartingNotice = "Compiling OldProtos (dotnet), please wait...",
        AutoTerminateReason = "OldProtos compiling (invoke dotnet) failed.",
        WorkingDir = "./../OldProtoHandlers"
    }, new OuterInvokeInfo
    {
        ProcessPath = OuterInvokeConfig.dotnet_path,
        CmdLine = "build",
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
        Console.ReadLine();
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
if (!Directory.Exists(newoutputdir) || !Directory.Exists(oldoutputdir))
{
    Log.Erro("Process terminated for proto2json output directories not found. Exit code is 245.", "OuterInvoke");
    Console.ReadLine();
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
#region Generate String Pool
ProtocStringPoolManager compiledStringPool = new();
foreach (var oldProtoMessage in oldmessages) compiledStringPool.PushMessageResult(oldProtoMessage);
foreach (var newProtoMessage in newmessages) compiledStringPool.PushMessageResult(newProtoMessage);
await compiledStringPool.Compile();
#endregion
#region Debug Output (no prod!!!)
// var newProtosOutputNames = newProto_compiledStringPool.GetAllNames();
// Log.Verb($"NewProtos names(verb): {newProtosOutputNames.Count} records.");
// foreach (var record in newProtosOutputNames)
// {
//     Log.Verb($"    [ {record.Key} -> {record.Value} ]; ");
// }
// var oldProtosOutputNames = oldProto_compiledStringPool.GetAllNames();
// Log.Verb($"OldProtos names(verb): {oldProtosOutputNames.Count} records.");
// foreach (var record in oldProtosOutputNames)
// {
//     Log.Verb($"    [ {record.Key} -> {record.Value} ]; ");
// }
#endregion
#region Generate Message Handlers
if (Directory.Exists($"./../ProtoshiftHandlers/Generated"))
{
    Log.Info($"Detected old Protoshift handlers, deleting...");
    Directory.Delete($"./../ProtoshiftHandlers/Generated", true);
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
    fi.WriteLine("#region Designer Generated Code");
    fi.WriteLine("#nullable enable");
    fi.WriteLine("using Google.Protobuf;");
    fi.WriteLine();
    fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
    fi.EnterCodeRegion();
    HandlerCodeWriter.GenerateMessageHandler(ref fi, msgName, shiftpair.LeftItem, shiftpair.RightItem,
        ref compiledStringPool, ref oldenumCollections, ref newenumCollections);
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
CmdIdDataStructure cmdData = new("./resources/protobuf/oldcmdid.csv",
    "./resources/protobuf/newcmdid.csv", messageResults);
#region Generate CmdId related
GenAskCmdId.Run(cmdData, askoldcmdid_filePath, asknewcmdid_filePath,
    cmd_askoldcmdid_specialHandles, cmd_asknewcmdid_specialHandles);
GenShiftCmdId.Run(cmdData, shiftCmdId_filePath,
    cmd_oldshiftnew_specialHandles, cmd_newshiftold_specialHandles);
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
    string backup_protoshift_dispatch_path = $"./../ProtoshiftHandlers/ProtoDispatch/Backup/ProtoshiftDispatch-{DateTime.Now:yyyy_MM_dd-HH_mm_ss}.cs";
    File.Move(protoshiftDispatch_filePath, backup_protoshift_dispatch_path);
    Log.Info($"ProtoshiftDispatch backup successfully created at {backup_protoshift_dispatch_path}", "ProtoshiftDispatch_Generate");
}
else
{
    for (int i = 0; i < 6; i++) mergeChanges.Add(new());
}
#endregion
GenProtoshiftDispatch.Run(cmdData, "./../ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs", mergeChanges);
#endregion
Console.ReadLine();

internal class MergeChange
{
    public string ProtoName = "";
    public List<string> CodeLines = new();
}