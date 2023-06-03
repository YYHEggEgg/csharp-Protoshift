using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.resLoader;
using YYHEggEgg.Logger;

// See https://aka.ms/new-console-template for more information
Log.Initialize(new LoggerConfig(
    max_Output_Char_Count: 16 * 1024, 
    use_Console_Wrapper: false,
    use_Working_Directory: true,
#if DEBUG
    global_Minimum_LogLevel: LogLevel.Verbose,
    console_Minimum_LogLevel: LogLevel.Information
#else
    global_Minimum_LogLevel: LogLevel.Information,
    console_Minimum_LogLevel: LogLevel.Information
#endif
));

Log.Info("Kcp-Csharp Performance TESTER");
Log.Info(await ResourcesLoader.Load());

await ServerApp.Start();
#if !CONNECT_SERVERONLY
ProxyApp.Start();
#endif
await ClientApp.Start();

while (true)
{
    if (!MainAnalysis.TestsFinished) await Task.Delay(10000);
    else Environment.Exit(0);
}
