using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.resLoader;
using OfficeOpenXml;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Debug.Replay
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
                max_Output_Char_Count: 16 * 1024,
                use_Console_Wrapper: false,
                use_Working_Directory: true,
                global_Minimum_LogLevel: LogLevel.Verbose,
                console_Minimum_LogLevel: LogLevel.Information,
                debug_LogWriter_AutoFlush: true
                ));

            ResourcesLoader.CheckForRequiredResources();
            await ResourcesLoader.Load();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            Log.Info("Start loading all protos, it will take some time...", "Entry");
            Log.Info(OldProtos.QueryJsonSerializer.Initialize(), "OldProtos");
            Log.Info(NewProtos.QueryJsonSerializer.Initialize(), "NewProtos");
            Log.Info(ProtoshiftDispatch.Initialize(), "Entry");

            PacketRecordCollection replays = new("./../csharp-Protoshift/logs/latest.packet.log");
            await replays.Replay();
            Log.Info("Replay completed.");
            Console.ReadLine();
        }
    }
}