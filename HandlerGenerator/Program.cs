using YYHEggEgg.Logger;
using System.Diagnostics;
using csharp_Protoshift.Enhanced.Handlers.Generator;
using System.Collections.Concurrent;
using System.IO;

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
    && Directory.Exists($"{workingdir}\\HandlerGenerator\\proto2json"))
{
    workingdir = $"{workingdir}\\HandlerGenerator";
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
if (!File.Exists($"{workingdir}\\HandlerGenerator.csproj"))
{
    Log.Erro("Can't find source code path! Make sure you have cloned full code!", "ResourcesCheck");
    Log.Erro("Process terminated for false launch. Exit code is 4206.", "ResourcesCheck");
    Console.ReadLine();
    Environment.Exit(4206);
}
Environment.CurrentDirectory = workingdir;
Log.Dbug($"Changed Current directory to: {workingdir}.");
#endregion
string proto2jsondir = $"{workingdir}\\proto2json";
if (!File.Exists($"{proto2jsondir}\\go-proto2json_win32.exe"))
{
    Log.Erro("Proto2json not found! Please make sure you're running program with dotnet run and have comiled Executable!", "ResourcesCheck");
    passcheck = false;
}
#endregion
#region Check Protos
string newprotodir = $"{Directory.GetParent(workingdir)}\\NewProtoHandlers\\Google.Protobuf\\Protos";
string oldprotodir = $"{Directory.GetParent(workingdir)}\\OldProtoHandlers\\Google.Protobuf\\Protos";
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
    Log.Erro("Process terminated for resources lost. Exit code is 272574.", "ResourcesCheck");
    Console.ReadLine();
    Environment.Exit(272574);
}
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
    #region Compile Protos
    ProcessStartInfo oldprotos_compile = new ProcessStartInfo(OuterInvokeConfig.dotnet_path, "build")
    {
        WorkingDirectory = "./../OldProtoHandlers"
    };
    ProcessStartInfo newprotos_compile = new ProcessStartInfo(OuterInvokeConfig.dotnet_path, "build")
    {
        WorkingDirectory = "./../NewProtoHandlers"
    };
    Log.Info($"Compiling OldProtos, please wait...", "OuterInvoke");
    await (Process.Start(oldprotos_compile)?.WaitForExitAsync() ?? Task.CompletedTask);
    Log.Info($"Compiling NewProtos, please wait...", "OuterInvoke");
    await (Process.Start(newprotos_compile)?.WaitForExitAsync() ?? Task.CompletedTask);
    #endregion
    #region Invoke proto2json
    if (Directory.Exists($"{workingdir}\\Proto2json_Output"))
    {
        Log.Info("Detected old output directory, deleting...");
        Directory.Delete($"{workingdir}\\Proto2json_Output", true);
    }
    Log.Info("Start invoking proto2json.exe. Please wait patiently...", "OuterInvoke");
    Stopwatch pinvokewatch = Stopwatch.StartNew();
    #region Split OS
    // Generated by Cursor
    string proto2json_invokestr = "";
    string os = Environment.OSVersion.Platform.ToString();
    string arch = Environment.Is64BitOperatingSystem ? "64" : "32";
    #region Windows
    if (os.StartsWith("Win"))
    {
        Log.Dbug($"Found OS Type: Windows x{arch}.", "OuterInvoke");
        proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_win{arch}.exe";
    }
    #endregion
    #region macOS
    else if (os.StartsWith("Darwin"))
    {
        Log.Dbug($"Found OS Type: macOS x{arch}.", "OuterInvoke");
        proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_mac{arch}";
    }
    #endregion
    #region Linux
    else if (os.StartsWith("Linux"))
    {
        Log.Dbug($"Found OS Type: Linux x{arch}.", "OuterInvoke");
        proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_linux{arch}";
    }
    #endregion
    else
    {
        Log.Erro("Unsupported OS detected! Please report this to Issues of this project.", "OuterInvoke");
        Log.Erro("Process terminated for unsupported OS. Exit code is 100.", "OuterInvoke");
        Environment.Exit(100);
    }
    #endregion
    Log.Dbug($"Using proto2json at path {proto2jsondir}.");
    ProcessStartInfo startInfo = new ProcessStartInfo(proto2json_invokestr)
    {
        // Not setting this will cause runtime error: invalid memory address or nil pointer dereference
        WorkingDirectory = proto2jsondir
    };
    Process p = Process.Start(startInfo);
    p.WaitForExit();
    pinvokewatch.Stop();
    Log.Info($"proto2json exited. Total execute time is {pinvokewatch.Elapsed}.", "OuterInvoke");
    #region Fatal exit handle
    if (p.ExitCode != 0)
    {
        Log.Erro($"proto2json exited with error code {p.ExitCode}. ", "OuterInvoke");
        Log.Erro("Process terminated for proto2json not working properly. Exit code is 3300.", "OuterInvoke");
        Console.ReadLine();
        Environment.Exit(3300);
    }
    #endregion
    #endregion
}
await File.WriteAllTextAsync("last_build_record.json", rebuildWatcher.SerializeToJson());
string newoutputdir = $"{workingdir}\\Proto2json_Output\\new";
string oldoutputdir = $"{workingdir}\\Proto2json_Output\\old";
if (!Directory.Exists(newoutputdir) || !Directory.Exists(oldoutputdir))
{
    Log.Erro("Process terminated for proto2json output directories not found. Exit code is 245.", "OuterInvoke");
    Console.ReadLine();
    Environment.Exit(245);
}
#endregion
ConcurrentBag<MessageResult> newmessages = new();
ConcurrentBag<MessageResult> oldmessages = new();
ConcurrentBag<EnumResult> newenums = new();
ConcurrentBag<EnumResult> oldenums = new();
#region Analyze Output
#region Enumerate Files
var newprotojsons = Directory.EnumerateFiles(newoutputdir);
var oldprotojsons = Directory.EnumerateFiles(newoutputdir);
Parallel.ForEach(newprotojsons, path =>
{
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
Parallel.ForEach(oldprotojsons, path =>
{
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
#endregion
CollectionResult<MessageResult> messageResults = 
    CollectionHelper.GetCompareResult(newmessages, oldmessages, MessageResult.NameComparer);
CollectionResult<EnumResult> enumResults = 
    CollectionHelper.GetCompareResult(newenums, oldenums, EnumResult.NameComparer);
#region Generate String Pool
ProtocStringPoolManager newProto_compiledStringPool = new();
foreach (var newProtoMessage in newmessages) newProto_compiledStringPool.PushMessageResult(newProtoMessage);
await newProto_compiledStringPool.Compile();
ProtocStringPoolManager oldProto_compiledStringPool = new();
foreach (var oldProtoMessage in oldmessages) oldProto_compiledStringPool.PushMessageResult(oldProtoMessage);
await oldProto_compiledStringPool.Compile();
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
foreach (var shiftpair in messageResults.IntersectItems)
{
    
}
#endregion
#endregion
Console.ReadLine();             