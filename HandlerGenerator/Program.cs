using YYHEggEgg.Logger;
using System.Diagnostics;

// See https://aka.ms/new-console-template for more information
Log.Info("Protoshift Ex v1", "HandlerGenerator");
Log.Info("It is recommended to invoke this program with dotnet run.", "HandlerGenerator");
Log.Warn("Build is currently only supported on Windows!", "HandlerGenerator");
Log.Warn("PLEASE USE THIS PROGRAM ALONG WITH FULL SOURCE CODE!", "HandlerGenerator");
string workingdir = Environment.CurrentDirectory;
bool passcheck = true;
#region Find proto2json
if (workingdir == "csharp-Protoshift" 
    && Directory.Exists($"{workingdir}\\HandlerGenerator\\proto2json"))
{
    workingdir = $"{workingdir}\\HandlerGenerator";
}
else if (workingdir.StartsWith("net"))
{
    string? dbug = Directory.GetParent(workingdir)?.FullName;
    if (dbug == null)
    {
        Log.Warn("Can't find source code path! Make sure you have cloned full code or placed proto2json in current path!", "ResourcesCheck");
    }
    else
    {
        workingdir = Directory.GetParent(dbug).FullName ?? "";
    }
}
else
{
    Log.Warn("Can't find source code path! Make sure you have cloned full code or placed proto2json in current path!", "ResourcesCheck");
}
string proto2jsondir = $"{workingdir}\\proto2json";
if (!File.Exists($"{proto2jsondir}\\proto2json.exe"))
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
    Environment.Exit(272574);
}
#region Invoke proto2json
Log.Info("Start invoking proto2json.exe. Please wait patiently...", "OuterInvoke");
Stopwatch pinvokewatch = Stopwatch.StartNew();
Process p = Process.Start($"{proto2jsondir}\\proto2json.exe");
p.WaitForExit();
pinvokewatch.Stop();
Log.Info($"proto2json exited. Total execute time is {pinvokewatch.Elapsed}.", "OuterInvoke");
if (p.ExitCode != 0)
{
    Log.Erro($"proto2json exited with error code {p.ExitCode}. ", "OuterInvoke");
    Log.Erro("Process terminated for proto2json not working properly. Exit code is 3300.", "OuterInvoke");
    Environment.Exit(3300);
}
string newoutputdir = $"{workingdir}\\Proto2json_Output\\new";
string oldoutputdir = $"{workingdir}\\Proto2json_Output\\old";
if (!Directory.Exists(newoutputdir) || !Directory.Exists(oldoutputdir))
{
    Log.Erro("Process terminated for proto2json output directories not found. Exit code is 245.", "OuterInvoke");
    Environment.Exit(245);
}
#endregion
