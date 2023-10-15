using csharp_Protoshift.Configuration;
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

            #region Config
            bool configLoadSucc = true;
            var _conflog = Log.GetChannel("Configuration");
            try
            {
                _conflog.LogInfo($"Loading config...");
                await Config.InitializeAsync("./../../csharp-Protoshift/config.json");
            }
            catch (Exception ex)
            {
                _conflog.LogWarnTrace(ex, $"config.json initialize failed.");
                configLoadSucc = false;
            }

            var conf_validate_errs = await Config.ValidateAsync();
            if (conf_validate_errs != null && conf_validate_errs.Count > 0)
            {
                configLoadSucc = false;
                _conflog.LogWarn($"ValidateAsync config.json by schema failed. Detected errors below:");
                foreach (var err in conf_validate_errs)
                {
                    _conflog.LogWarn(err.ToString());
                }
            }

            if (!configLoadSucc)
            {
                _conflog.LogErro("Config load failed. Please check the errors and fix them.");
                Environment.Exit(50);
            }
            #endregion

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