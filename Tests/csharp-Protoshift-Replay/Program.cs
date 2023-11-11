using csharp_Protoshift.Configuration;
using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.resLoader;
using OfficeOpenXml;
using YYHEggEgg.Logger;
using CommandLine;
using CommandLine.Text;

namespace csharp_Protoshift.Debug.Replay
{
    internal class Program
    {
        public static bool FullyReplayPacketTime;

        static async Task Main(string[] args)
        {
            string? path = null;
            Parser.Default.ParseArguments<ReplayOptions>(args)
                .WithNotParsed(errs =>
                {
                    Environment.Exit(1);
                })
                .WithParsed(o => 
                {
                    path = o.ReplaySourceFile;
                    FullyReplayPacketTime = o.FullyReplayPacketTime;
                });

            StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
                max_Output_Char_Count: 16 * 1024,
                use_Console_Wrapper: true,
                use_Working_Directory: true,
#if DEBUG
                global_Minimum_LogLevel: LogLevel.Verbose,
                console_Minimum_LogLevel: LogLevel.Information,
#else
                global_Minimum_LogLevel: LogLevel.Information,
                console_Minimum_LogLevel: LogLevel.Information,
#endif
                debug_LogWriter_AutoFlush: false,
                is_PipeSeparated_Format: false,
                enable_Detailed_Time: true
            ));
            ConsoleWrapper.ShutDownRequest += (_, _) => Environment.Exit(0x3fffffff);

            var resPath = "./../../csharp-Protoshift/resources";
            ResourcesLoader.CheckForRequiredResources(resPath);
            await ResourcesLoader.Load(resPath);

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

            Log.Info($"Start running initiated Protoshift Handlers JIT, please wait..", "RunHandlersJit");
            try
            {
                ProtoshiftDispatch.RunHandlersJit();
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, "RunHandlersJit", "Protoshift Handlers JIT failed. " +
                    "Please check your custom Handlers (ProtoshiftHandlers/SpecialHandlers) " +
                    "or open an issue related to this in our repository.");
                Environment.Exit(1);
            }

            Log.Info($"Please drag in the packet.log for replaying (default is latest.packet.log):");
            path = ConsoleWrapper.ReadLine();
            if (string.IsNullOrEmpty(path)) path = "./../csharp-Protoshift/logs/latest.packet.log";
            PacketRecordCollection replays = new(path);
            await replays.Replay();
            Log.Info("Replay completed.");
            Console.ReadLine();
        }
    }

    public class ReplayOptions
    {
        [Option('f', "source-file", Default = null, Required = false, HelpText = "The source packet.log for replaying.")]
        public string? ReplaySourceFile { get; set; }
        [Option('t', "fully-repeat-packet-time", Default = false, Required = false, HelpText = "If Enabled, the replay process will fully replay the packet arrival time (and their interval) when they're captured. By default, they are just handled one after another without delay.")]
        public bool FullyReplayPacketTime { get; set; }
    }
}