using csharp_Protoshift.resLoader;
using YYHEggEgg.Logger;

// See https://aka.ms/new-console-template for more information
Log.Initialize(new LoggerConfig(
    max_Output_Char_Count: 16 * 1024, 
    use_Console_Wrapper: true,
    use_Working_Directory: false,
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
