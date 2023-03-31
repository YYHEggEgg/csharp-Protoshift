using YYHEggEgg.Logger;
using System.Diagnostics;
using csharp_Protoshift.Enhanced.Handlers.Generator;
using System.Collections.Concurrent;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Protoshift Ex v1");
Log.Info("It is recommended to invoke this program with dotnet run.", "HandlerGenerator");
Log.Warn("Build is currently only supported on Windows!", "HandlerGenerator");
Log.Warn("PLEASE USE THIS PROGRAM ALONG WITH FULL SOURCE CODE!", "HandlerGenerator");
string workingdir = Environment.CurrentDirectory;
DirectoryInfo _workingdirinfo = new(workingdir);
Log.Info($"Current directory is: {workingdir}.");
bool passcheck = true;
#region Find proto2json
if (_workingdirinfo.Name == "csharp-Protoshift" 
    && Directory.Exists($"{workingdir}\\HandlerGenerator\\proto2json"))
{
    workingdir = $"{workingdir}\\HandlerGenerator";
}
else if (_workingdirinfo.Name.StartsWith("net"))
{
    string? dbug = Directory.GetParent(workingdir)?.FullName;
    if (dbug != null)
    {
        workingdir = Directory.GetParent(dbug).FullName ?? "";
    }
}
#region Change working directory
if (!File.Exists($"{workingdir}\\HandlerGenerator.csproj"))
{
    Log.Erro("Can't find source code path! Make sure you have cloned full code!", "ResourcesCheck");
    Log.Erro("Process terminated for false launch. Exit code is 4206.", "ResourcesCheck");
    Environment.Exit(4206);
}
Environment.CurrentDirectory = workingdir;
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
    proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_win{arch}.exe";
}
#endregion
#region macOS
else if (os.StartsWith("Darwin"))
{
    proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_mac{arch}";
}
#endregion
#region Linux
else if (os.StartsWith("Linux"))
{
    proto2json_invokestr = $"{proto2jsondir}\\go-proto2json_linux{arch}";
}
#endregion
else
{
    Log.Erro("Unsupported OS detected! Please use Windows, macOS or Linux.", "OuterInvoke");
    Log.Erro("Process terminated for unsupported OS. Exit code is 100.", "OuterInvoke");
    Environment.Exit(100);
}
#endregion

Process p = Process.Start(proto2json_invokestr);
p.WaitForExit();
pinvokewatch.Stop();
Log.Info($"proto2json exited. Total execute time is {pinvokewatch.Elapsed}.", "OuterInvoke");
if (p.ExitCode != 0)
{
    Log.Erro($"proto2json exited with error code {p.ExitCode}. ", "OuterInvoke");
    Log.Erro("Process terminated for proto2json not working properly. Exit code is 3300.", "OuterInvoke");
    Console.ReadLine();
    Environment.Exit(3300);
}
string newoutputdir = $"{workingdir}\\Proto2json_Output\\new";
string oldoutputdir = $"{workingdir}\\Proto2json_Output\\old";
if (!Directory.Exists(newoutputdir) || !Directory.Exists(oldoutputdir))
{
    Log.Erro("Process terminated for proto2json output directories not found. Exit code is 245.", "OuterInvoke");
    Console.ReadLine();
    Environment.Exit(245);
}
#endregion
ConcurrentDictionary<string, 
    (MessageResult newresult, MessageResult oldresult)> messageResults;
ConcurrentDictionary<string, 
    (EnumResult newresult, EnumResult oldresult)> enumResults;
#region Analyze Output

#endregion
Console.ReadLine();