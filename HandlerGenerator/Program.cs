using csharp_Protoshift.Enhanced.Handlers.Generator;
using csharp_Protoshift.resLoader;
using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using YYHEggEgg.Logger;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Protoshift Ex v1");
Log.Initialize(new LoggerConfig(
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
Log.Warn("Build is currently only supported on Windows!", "HandlerGenerator");
Log.Warn("PLEASE USE THIS PROGRAM ALONG WITH FULL SOURCE CODE!", "HandlerGenerator");
string workingdir = Environment.CurrentDirectory;
DirectoryInfo _workingdirinfo = new(workingdir);
Log.Dbug($"Startup Current directory is: {workingdir}.");
bool passcheck = true;
#region Find proto2json
if (_workingdirinfo.Name == "csharp-Protoshift"
    && Directory.Exists($"{workingdir}/HandlerGenerator/proto2json"))
{
    workingdir = $"{workingdir}/HandlerGenerator";
}
else if (_workingdirinfo.Name.StartsWith("net"))
{
    try
    {
        string? dbug = Directory.GetParent(workingdir)?.FullName;
        if (dbug != null)
        {
            workingdir = Directory.GetParent(Directory.GetParent(dbug).FullName).FullName ?? "";
        }
    }
    catch { }
}
#region Change working directory
if (!File.Exists($"{workingdir}/HandlerGenerator.csproj"))
{
    Log.Erro("Can't find source code path! Make sure you have cloned full code!", "ResourcesCheck");
    Log.Erro("Process terminated for false launch. Exit code is 4206.", "ResourcesCheck");
    Console.ReadLine();
    Environment.Exit(4206);
}
Environment.CurrentDirectory = workingdir;
Log.Dbug($"Changed Current directory to: {workingdir}.");
#endregion
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
RebuildWatcher rebuildWatcher;
if (File.Exists("last_build_record.json"))
{
    Log.Info($"Reading last build record from jsonfile, it'll take some time...", nameof(RebuildWatcher));
    rebuildWatcher = RebuildWatcher.DeserializeFromJson(await File.ReadAllTextAsync("last_build_record.json"));
}
else
{
    Log.Info($"Capturing build status from directories, it'll take some time...", nameof(RebuildWatcher));
    rebuildWatcher = new();
    rebuildWatcher.CaptureDirectory($"./../OldProtoHandlers/Google.Protobuf");
    rebuildWatcher.CaptureDirectory($"./../NewProtoHandlers/Google.Protobuf");
}
rebuildWatcher_watch.Stop();
Log.Info($"Rebuild judge completed (need rebuild: {rebuildWatcher.NeedRebuild}), costed {rebuildWatcher_watch.Elapsed}.", nameof(RebuildWatcher));
if (rebuildWatcher.NeedRebuild)
{
    #region Compile Protos (protoc)
    Stopwatch protocWatch = Stopwatch.StartNew();
    Log.Info("Start compiling protos (protoc), it will take some time...");
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
                Path.GetRelativePath("./../OldProtoHandlers/Google.Protobuf/Protos", proto_file)  +
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
                Path.GetRelativePath("./../NewProtoHandlers/Google.Protobuf/Protos", proto_file)  +
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
    PlatformID os = Environment.OSVersion.Platform;
    string arch = Environment.Is64BitOperatingSystem ? "64" : "32";
    #region Windows
    if (os == PlatformID.Win32NT)
    {
        Log.Dbug($"Found OS Type: Windows x{arch}.", "OuterInvoke");
        proto2json_invokestr = $"{proto2jsondir}/go-proto2json_win{arch}.exe";
    }
    #endregion
    #region macOS
    /*else if (os.StartsWith("Darwin"))
    {
        Log.Dbug($"Found OS Type: macOS x{arch}.", "OuterInvoke");
        proto2json_invokestr = $"{proto2jsondir}/go-proto2json_mac{arch}";
    }*/
    #endregion
    #region Linux
    else if (os == PlatformID.Unix)
    {
        Log.Dbug($"Found OS Type: Unix x{arch}.", "OuterInvoke");
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
        Log.Erro("Unsupported OS detected! Please report this to Issues of this project.", "OuterInvoke");
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
await File.WriteAllTextAsync("last_build_record.json", rebuildWatcher.SerializeToJson());
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
    fi.WriteLine("using Google.Protobuf;");
    fi.WriteLine();
    fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
    fi.EnterCodeRegion();
    HandlerCodeWriter.GenerateMessageHandler(ref fi, msgName, shiftpair.LeftItem, shiftpair.RightItem,
        ref compiledStringPool, ref oldenumCollections, ref newenumCollections);
    fi.ExitCodeRegion();
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
List<(string messageName, int cmdId)> oldcmdids = new();
List<(string messageName, int cmdId)> newcmdids = new();
SortedSet<string> messages_havecmdid = new();
#region Read oldcmdid.csv
try
{
    using (StreamReader sr = new StreamReader("./resources/protobuf/oldcmdid.csv"))
    {
        string? line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] values = line.Split(',');
            if (values.Length == 2 && int.TryParse(values[1], out int cmdId))
            {
                oldcmdids.Add((values[0], cmdId));
                messages_havecmdid.Add(values[0]);
            }
        }
    }
}
catch (IOException e)
{
    Log.Erro($"The file could not be read: {e}", "AskCmdIdGenerate");
}
#endregion
#region Read newcmdid.csv
try
{
    using (StreamReader sr = new StreamReader("./resources/protobuf/newcmdid.csv"))
    {
        string? line;
        while ((line = sr.ReadLine()) != null)
        {
            string[] values = line.Split(',');
            if (values.Length == 2 && int.TryParse(values[1], out int cmdId))
            {
                newcmdids.Add((values[0], cmdId));
                messages_havecmdid.Add(values[0]);
            }
        }
    }
}
catch (IOException e)
{
    Log.Erro($"The file could not be read: {e}", "AskCmdIdGenerate");
}
#endregion
ReadOnlyCollection<string> supportedMessages = new(new List<string>(
    from pair in messageResults.IntersectItems
    select pair.LeftItem.messageName));
IEnumerable<(string messageName, int oldcmdid, int newcmdid)> supportedCmdIds =
    from old in oldcmdids
    join @new in newcmdids
    on old.messageName equals @new.messageName
    select (old.messageName, old.cmdId, @new.cmdId);
#region Generate CmdId related
var cmdlist_order_new = from tuple in supportedCmdIds
                        group tuple by tuple.newcmdid into gr
                        orderby gr.Key
                        select gr;
var cmdlist_order_old = from tuple in supportedCmdIds
                        group tuple by tuple.oldcmdid into gr
                        orderby gr.Key
                        select gr;
#region Generate AskCmdId
#region OldProtos
using (BasicCodeWriter fi = new(askoldcmdid_filePath))
{
    fi.WriteLine("// <auto-generated>");
    fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator.");
    fi.WriteLine("// </auto-generated>");
    fi.WriteLine();
    fi.WriteLine("#region Designer Generated Code");
    fi.WriteLine();
    fi.WriteLine("namespace OldProtos");
    fi.EnterCodeRegion();
    fi.WriteLine("public static class AskCmdId");
    fi.EnterCodeRegion();
    fi.WriteLine("public static uint GetCmdIdFromProtoname(string protoname)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (protoname)");
    fi.EnterCodeRegion();
    oldcmdids.Sort((l, r) => l.messageName.CompareTo(r.messageName));
    foreach (var cmdPair in oldcmdids)
    {
        fi.WriteLine($"case \"{cmdPair.messageName}\": return {cmdPair.cmdId};");
    }
    fi.WriteLine($"default: throw new NotSupportedException(\"Unknown message name or it doesn't have cmd_id.\")");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("// DON'T INSERT ANY CODE HERE");
    fi.WriteLine("public static string GetProtonameFromCmdId(uint cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    foreach (var grp in cmdlist_order_old)
    {
        if (grp.Count() == 1)
        {
            #region 1. No conflict
            var tuple = grp.First();
            fi.WriteLine($"case {tuple.oldcmdid}: return \"{tuple.messageName}\";");
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("2. FUCK (this line never shows)", "AskCmdId_Generate");
        }
        else
        {
            #region 3. Have conflict, but solved before
            if (cmd_askoldcmdid_specialHandles.ContainsKey(grp.Key))
            {
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    cmd_askoldcmdid_specialHandles[grp.Key]);
                Log.Dbug($"Successfully merged past special handle of Cmd: {grp.Key} to OldProtos.GetProtonameFromCmdId.", "AskCmdId_Generate");
            }
            #endregion
            #region 4. Have conflict, never solved
            else
            {
                var writing_list = new List<string>
                {
                    "// Q: Why I'm seeing this? ",
                    "// A: There's a cmdid conflict in the provided cmdid.csv file.",
                    "//    More simply, there're two proto sharing the same cmdid.",
                    "//    That may be a mistake, but if you think the file is correct,",
                    "//    that's because the two message have a difference in Channel id.",
                    "// ",
                    "//    e.g. all protos use ENET_CHANNEL_ID = 0, ",
                    "//         but DebugNotify use ENET_CHANNEL_ID = 2. ",
                    "//    In this case, you should write a code handling the packet head, ",
                    "//    or just uncomment the line not specifing 'DebugNotify'. ",
                    "// ",
                    "//    Please REMEMBER COMMENT/DELETE the line throwing exception! ",
                    "//    And don't delete 'request special handle' line, ",
                    "//    or your changes will be overwritten during the next build!"
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return \"{tuple.messageName}\";");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict haven't been solved. Search for 'request special handle' in OldProtoHandlers/AskCmdId.cs for more information.\");");
                writing_list.Add("// DON'T MODIFY THIS LINE - end special handle");
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    writing_list);
                Log.Warn($"(OldProtos) AskCmdId.GetProtonameFromCmdId has cmd_id conflict to be solved (affected oldCmd: {grp.Key}). Search for 'request special handle' in OldProtoHandlers/AskCmdId.cs for more information.", "AskCmdId_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("default: throw new NotSupportedException(\"The input old CmdId is unknown.\");");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();

    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("#endregion Designer generated code");
}
#endregion
#region NewProtos
using (BasicCodeWriter fi = new(asknewcmdid_filePath))
{
    fi.WriteLine("// <auto-generated>");
    fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator.");
    fi.WriteLine("// </auto-generated>");
    fi.WriteLine();
    fi.WriteLine("#region Designer Generated Code");
    fi.WriteLine();
    fi.WriteLine("namespace NewProtos");
    fi.EnterCodeRegion();
    fi.WriteLine("public static class AskCmdId");
    fi.EnterCodeRegion();
    fi.WriteLine("public static uint GetCmdIdFromProtoname(string protoname)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (protoname)");
    fi.EnterCodeRegion();
    newcmdids.Sort((l, r) => l.messageName.CompareTo(r.messageName));
    foreach (var cmdPair in newcmdids)
    {
        fi.WriteLine($"case \"{cmdPair.messageName}\": return {cmdPair.cmdId};");
    }
    fi.WriteLine($"default: throw new NotSupportedException(\"Unknown message name or it doesn't have cmd_id.\")");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("// DON'T INSERT ANY CODE HERE");
    fi.WriteLine("public static string GetProtonameFromCmdId(uint cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    foreach (var grp in cmdlist_order_new)
    {
        if (grp.Count() == 1)
        {
            #region 1. No conflict
            var tuple = grp.First();
            fi.WriteLine($"case {tuple.newcmdid}: return \"{tuple.messageName}\";");
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("2. FUCK (this line never shows)", "AskCmdId_Generate");
        }
        else
        {
            #region 3. Have conflict, but solved before
            if (cmd_asknewcmdid_specialHandles.ContainsKey(grp.Key))
            {
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    cmd_asknewcmdid_specialHandles[grp.Key]);
                Log.Dbug($"Successfully merged past special handle of Cmd: {grp.Key} to NewProtos.GetProtonameFromCmdId.", "AskCmdId_Generate");
            }
            #endregion
            #region 4. Have conflict, never solved
            else
            {
                var writing_list = new List<string>
                {
                    "// Q: Why I'm seeing this? ",
                    "// A: There's a cmdid conflict in the provided cmdid.csv file.",
                    "//    More simply, there're two proto sharing the same cmdid.",
                    "//    That may be a mistake, but if you think the file is correct,",
                    "//    that's because the two message have a difference in Channel id.",
                    "// ",
                    "//    e.g. all protos use ENET_CHANNEL_ID = 0, ",
                    "//         but DebugNotify use ENET_CHANNEL_ID = 2. ",
                    "//    In this case, you should write a code handling the packet head, ",
                    "//    or just uncomment the line not specifing 'DebugNotify'. ",
                    "// ",
                    "//    Please REMEMBER COMMENT/DELETE the line throwing exception! ",
                    "//    And don't delete 'request special handle' line, ",
                    "//    or your changes will be overwritten during the next build!"
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return \"{tuple.messageName}\";");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict haven't been solved. Search for 'request special handle' in NewProtoHandlers/AskCmdId.cs for more information.\");");
                writing_list.Add("// DON'T MODIFY THIS LINE - end special handle");
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    writing_list);
                Log.Warn($"(NewProtos) AskCmdId.GetProtonameFromCmdId has cmd_id conflict to be solved (affected oldCmd: {grp.Key}). Search for 'request special handle' in NewProtoHandlers/AskCmdId.cs for more information.", "AskCmdId_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("default: throw new NotSupportedException(\"The input old CmdId is unknown.\");");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();

    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("#endregion Designer generated code");
}
#endregion
#endregion
#region Generate ShiftCmdId
using (BasicCodeWriter fi = new(shiftCmdId_filePath))
{
    fi.WriteLine("// <auto-generated>");
    fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator.");
    fi.WriteLine("// </auto-generated>");
    fi.WriteLine();
    fi.WriteLine("#region Designer Generated Code");
    fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
    fi.EnterCodeRegion();
    fi.WriteLine("public static class ShiftCmdId");
    fi.EnterCodeRegion();
    fi.WriteLine("public static uint NewShiftToOld(uint newcmdid, ReadOnlySpan<byte> head)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (newcmdid)");
    fi.EnterCodeRegion();
    foreach (var grp in cmdlist_order_new)
    {
        if (grp.Count() == 1)
        {
            #region 1. No conflict
            var tuple = grp.First();
            fi.WriteLine($"case {tuple.newcmdid}: return {tuple.oldcmdid}; // {tuple.messageName}");
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("2. FUCK (this line never shows)", "ShiftCmdId_Generate");
        }
        else
        {
            #region 3. Have conflict, but solved before
            if (cmd_newshiftold_specialHandles.ContainsKey(grp.Key))
            {
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    cmd_newshiftold_specialHandles[grp.Key]);
                Log.Dbug($"Successfully merged past special handle of Cmd: {grp.Key} to NewShiftToOld.", "ShiftCmdId_Generate");
            }
            #endregion
            #region 4. Have conflict, never solved
            else
            {
                var writing_list = new List<string>
                {
                    "// Q: Why I'm seeing this? ",
                    "// A: There's a cmdid conflict in the provided cmdid.csv file.",
                    "//    More simply, there're two proto sharing the same cmdid.",
                    "//    That may be a mistake, but if you think the file is correct,",
                    "//    that's because the two message have a difference in Channel id.",
                    "// ",
                    "//    e.g. all protos use ENET_CHANNEL_ID = 0, ",
                    "//         but DebugNotify use ENET_CHANNEL_ID = 2. ",
                    "//    In this case, you should write a code handling the packet head, ",
                    "//    or just uncomment the line not specifing 'DebugNotify'. ",
                    "// ",
                    "//    Please REMEMBER COMMENT/DELETE the line throwing exception! ",
                    "//    And don't delete 'request special handle' line, ",
                    "//    or your changes will be overwritten during the next build!"
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return {tuple.oldcmdid}; // {tuple.messageName}");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict haven't been solved. Search for 'request special handle' in ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs for more information.\");");
                writing_list.Add("// DON'T MODIFY THIS LINE - end special handle");
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    writing_list);
                Log.Warn($"ShiftCmdId.NewShiftToOld has cmd_id conflict to be solved (affected newCmd: {grp.Key}). Search for 'request special handle' in ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs for more information.");
            }
            #endregion
        }
    }
    fi.WriteLine("default: throw new NotSupportedException(\"The input new CmdId is unknown.\");");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("// DON'T INSERT ANY CODE HERE");
    fi.WriteLine("public static uint OldShiftToNew(uint oldcmdid, ReadOnlySpan<byte> head)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (oldcmdid)");
    fi.EnterCodeRegion();
    foreach (var grp in cmdlist_order_old)
    {
        if (grp.Count() == 1)
        {
            #region 1. No conflict
            var tuple = grp.First();
            fi.WriteLine($"case {tuple.oldcmdid}: return {tuple.newcmdid}; // {tuple.messageName}");
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("2. FUCK (this line never shows)", "ShiftCmdId_Generate");
        }
        else
        {
            #region 3. Have conflict, but solved before
            if (cmd_oldshiftnew_specialHandles.ContainsKey(grp.Key))
            {
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    cmd_oldshiftnew_specialHandles[grp.Key]);
                Log.Dbug($"Successfully merged past special handle of Cmd: {grp.Key} to OldShiftToNew.", "ShiftCmdId_Generate");
            }
            #endregion
            #region 4. Have conflict, never solved
            else
            {
                var writing_list = new List<string>
                {
                    "// Q: Why I'm seeing this? ",
                    "// A: There's a cmdid conflict in the provided cmdid.csv file.",
                    "//    More simply, there're two proto sharing the same cmdid.",
                    "//    That may be a mistake, but if you think the file is correct,",
                    "//    that's because the two message have a difference in Channel id.",
                    "// ",
                    "//    e.g. all protos use ENET_CHANNEL_ID = 0, ",
                    "//         but DebugNotify use ENET_CHANNEL_ID = 2. ",
                    "//    In this case, you should write a code handling the packet head, ",
                    "//    or just uncomment the line not specifing 'DebugNotify'. ",
                    "// ",
                    "//    Please REMEMBER COMMENT/DELETE the line throwing exception! ",
                    "//    And don't delete 'request special handle' line, ",
                    "//    or your changes will be overwritten during the next build!"
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return {tuple.newcmdid}; // {tuple.messageName}");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict haven't been solved. Search for 'request special handle' in ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs for more information.\");");
                writing_list.Add("// DON'T MODIFY THIS LINE - end special handle");
                fi.WriteLine($"case {grp.Key}: // DON'T MODIFY THIS LINE - request special handle",
                    writing_list);
                Log.Warn($"ShiftCmdId.OldShiftToNew has cmd_id conflict to be solved (affected oldCmd: {grp.Key}). Search for 'request special handle' in ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs for more information.", "ShiftCmdId_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("default: throw new NotSupportedException(\"The input old CmdId is unknown.\");");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine();
    fi.WriteLine("public static uint NewShiftToOld(uint newCmdId)",
        "=> NewShiftToOld(newCmdId, ReadOnlySpan<byte>.Empty);");
    fi.WriteLine();
    fi.WriteLine("public static uint OldShiftToNew(uint oldCmdId)",
        "=> OldShiftToNew(oldCmdId, ReadOnlySpan<byte>.Empty);");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("#endregion Designer generated code");
}
#endregion
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
                if (!messages_havecmdid.Contains(curproto))
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
using (BasicCodeWriter fi = new("./../ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs"))
{
    int curMethodNum = 0;
    #region Other Code (New -> Old, reload: byte[])
    fi.WriteLine("// <auto-generated>");
    fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator. ");
    fi.WriteLine("// </auto-generated>");
    fi.WriteLine();
    fi.WriteLine("#nullable enable");
    fi.WriteLine("#region Designer Generated Code");
    fi.WriteLine("using Google.Protobuf;");
    fi.WriteLine();
    fi.WriteLine("namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode");
    fi.EnterCodeRegion();
    fi.WriteLine("public static class ProtoshiftDispatch");
    fi.EnterCodeRegion();
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from client.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"head_offset\">The offset of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"head_length\">The valid length of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <param name=\"body_offset\">The offset of the <paramref name=\"body\"/>.</param>");
    fi.WriteLine("/// <param name=\"body_length\">The valid length of the <paramref name=\"body\"/>.</param>");
    fi.WriteLine("/// <returns>The protobuf with OldProtos, can be sent to server.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static byte[] NewShiftToOld(uint cmdid, ",
        "byte[]? head, int? head_offset, int? head_length, ",
        "byte[] body, int body_offset, int body_length)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_new)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {tuple.newcmdid}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().NewShiftToOld(body, body_offset, body_length);");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {tuple.newcmdid}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar."
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().NewShiftToOld(body, body_offset, body_length); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.NewShiftToOld has cmd_id conflict to be solved " +
                    $"(affected newCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of NewShiftToOld method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (New -> Old, reload: byte[])
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    curMethodNum++;
    fi.WriteLine();
    #region Other Code (New -> Old, reload: Span)
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from client.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set empty. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <returns>The protobuf with OldProtos, can be sent to server.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static byte[] NewShiftToOld(uint cmdid, ReadOnlySpan<byte> head, ReadOnlySpan<byte> body)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_new)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {tuple.newcmdid}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().NewShiftToOld(body); ");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {tuple.newcmdid}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar. "
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().NewShiftToOld(body); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.NewShiftToOld has cmd_id conflict to be solved " +
                    $"(affected newCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of NewShiftToOld method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (New -> Old, reload: Span)
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    curMethodNum++;
    fi.WriteLine();
    #region Other Code (New -> Old, reload: ByteString)
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from client.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set empty. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <returns>The protobuf with OldProtos, can be sent to server.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static ByteString NewShiftToOld(uint cmdid, ByteString? head, ByteString body)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_new)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {tuple.newcmdid}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().NewShiftToOld(body); ");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {tuple.newcmdid}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar. "
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().NewShiftToOld(body); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.NewShiftToOld has cmd_id conflict to be solved " +
                    $"(affected newCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of NewShiftToOld method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (New -> Old, reload: ByteString)
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    curMethodNum++;
    fi.WriteLine();
    #region Other Code (Old -> New, reload: byte[])
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from server.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"head_offset\">The offset of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"head_length\">The valid length of the <paramref name=\"head\"/>. If not providing head, it may be set null. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <param name=\"body_offset\">The offset of the <paramref name=\"body\"/>.</param>");
    fi.WriteLine("/// <param name=\"body_length\">The valid length of the <paramref name=\"body\"/>.</param>");
    fi.WriteLine("/// <returns>The protobuf with NewProtos, can be sent to client.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static byte[] OldShiftToNew(uint cmdid, ",
        "byte[]? head, int? head_offset, int? head_length, ",
        "byte[] body, int body_offset, int body_length)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_old)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().OldShiftToNew(body, body_offset, body_length); ");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar. "
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().OldShiftToNew(body, body_offset, body_length); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.OldShiftToNew has cmd_id conflict to be solved " +
                    $"(affected oldCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of OldShiftToNew method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (Old -> New, reload: byte[])
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    curMethodNum++;
    fi.WriteLine();
    #region Other Code (Old -> New, reload: Span)
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from server.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set empty. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <returns>The protobuf with NewProtos, can be sent to client.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static byte[] OldShiftToNew(uint cmdid, ReadOnlySpan<byte> head, ReadOnlySpan<byte> body)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_old)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().OldShiftToNew(body); ");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar. "
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().OldShiftToNew(body); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.OldShiftToNew has cmd_id conflict to be solved " +
                    $"(affected oldCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of OldShiftToNew method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (Old -> New, reload: Span)
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    curMethodNum++;
    fi.WriteLine();
    #region Other Code (Old -> New, reload: ByteString)
    fi.WriteLine("/// <summary>");
    fi.WriteLine("/// Protoshift a base packet from server.");
    fi.WriteLine("/// </summary>");
    fi.WriteLine("/// <param name=\"cmdid\">The cmd_id to dispatch the packet.</param>");
    fi.WriteLine("/// <param name=\"head\">The head (for dispatching packet). If not providing head, it may be set empty. </param>");
    fi.WriteLine("/// <param name=\"body\">The main body (protobuf).</param>");
    fi.WriteLine("/// <returns>The protobuf with NewProtos, can be sent to client.</returns>");
    fi.WriteLine("/// <exception cref=\"ArgumentNullException\">The <paramref name=\"head\"/> is not null, but provided null for <paramref name=\"head_length\"/> or <paramref name=\"head_offset\"/>.</exception>");
    fi.WriteLine("/// <exception cref=\"ArgumentException\">Provided offset & length exceeded the readable length.</exception>");
    fi.WriteLine("/// <exception cref=\"NotSupportedException\">The input <paramref name=\"cmdid\"/> is not supported to be Protoshifted.</exception>");
    fi.WriteLine("public static ByteString OldShiftToNew(uint cmdid, ByteString? head, ByteString body)");
    fi.EnterCodeRegion();
    fi.WriteLine("switch (cmdid)");
    fi.EnterCodeRegion();
    fi.WriteLine("// For convience, the following code is marked as 'merge - Generated Code'.");
    fi.WriteLine("// In the 'merge code region', if you want to modify some code:");
    fi.WriteLine("// First, find the proto name & cmdid you want to modify;");
    fi.WriteLine("// Second, write the proto name at the comment;");
    fi.WriteLine("// Third, write '- merge - ignore case';");
    fi.WriteLine("// Finally, remove all 'merge - Generated Code' mark in this case and do essential modifications.");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE: If you modified the code here, you may also do the same change");
    fi.WriteLine("//         in the implement below in different reloads. ");
    fi.WriteLine("// ");
    fi.WriteLine("// NOTICE 2: Change code here is very unconvenient. ");
    fi.WriteLine("//           It's suggested to change in the Handler. ");
    fi.WriteLine("//");
    fi.WriteLine("// Below is mergable region");
    #endregion
    fi.WriteLine("/**********Start mergable region --- DO NOT EDIT THIS LINE**********/");
    foreach (var grp in cmdlist_order_old)
    {
        if (grp.Count() == 1)
        {
            var tuple = grp.First();
            #region 1. No conflict, auto generate
            if (!mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
            {
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    $"return new Handler{tuple.messageName}().OldShiftToNew(body); ");
            }
            #endregion
            #region 2. No conflict, but ignore the case for human written before
            else
            {
                fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                    mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
        else if (grp.Count() == 0)
        {
            Log.Erro("3. FUCK (this line never shows)", "ProtoshiftDispatch_Generate");
        }
        else
        {
            #region 4. Have conflict, but solved before
            bool merged_haveConflict = false;
            foreach (var tuple in grp)
            {
                if (mergeChanges[curMethodNum].ContainsKey(tuple.messageName))
                {
                    fi.WriteLine($"case {grp.Key}: // {tuple.messageName} - merge - ignore case",
                        mergeChanges[curMethodNum][tuple.messageName].CodeLines);
                    Log.Info($"Successfully merged ignore case of message {tuple.messageName}.", "ProtoshiftDispatch_Generate");
                    merged_haveConflict = true;
                    break;
                }
            }
            #endregion
            #region 5. Have conflict, never solved
            if (!merged_haveConflict)
            {
                var writing_list = new List<string>
                {
                    "// Please solve the proto conflict here. You may refer to ShiftCmdId.cs " +
                    "to get info about the exception and the beginning of this method " +
                    "to get modification grammar. "
                };
                foreach (var tuple in grp)
                {
                    writing_list.Add($"// return new Handler{tuple.messageName}().OldShiftToNew(body); ");
                }
                writing_list.Add("throw new NotSupportedException(\"The cmdid conflict " +
                    "haven't been solved. Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of this method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.\"); ");
                fi.WriteLine($"case {grp.Key}: // merge - Generated Code",
                    writing_list);
                Log.Warn($"ProtoshiftDispatch.OldShiftToNew has cmd_id conflict to be solved " +
                    $"(affected oldCmd: {grp.Key}). Search for 'request special handle' in " +
                    "ProtoshiftHandlers/ProtoDispatch/ShiftCmdId.cs to get info about " +
                    "the exception, look at the beginning of OldShiftToNew method in " +
                    "ProtoshiftHandlers/ProtoDispatch/ProtoshiftDispatch.cs " +
                    "to get modification grammar, and search for 'solve the proto conflict here'.",
                    "ProtoshiftDispatch_Generate");
            }
            #endregion
        }
    }
    fi.WriteLine("/***********End mergable region --- DO NOT EDIT THIS LINE***********/");
    #region Other Code (Old -> New, reload: ByteString)
    fi.WriteLine("default: ",
        "throw new NotSupportedException(\"The input cmdid is not supported to be Protoshifted.\"); ");
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    #endregion
    fi.ExitCodeRegion();
    fi.ExitCodeRegion();
    fi.WriteLine("#nullable disable");
    fi.WriteLine("#endregion Designer generated code");
}
#endregion
Console.ReadLine();

internal class MergeChange
{
    public string ProtoName = "";
    public List<string> CodeLines = new();
}