using CommandLine;
using CommandLine.Text;
using csharp_Protoshift.MhyKCP.Test.Analysis;
using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.resLoader;
using Google.Protobuf.WellKnownTypes;
using OfficeOpenXml;
using YYHEggEgg.Logger;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Log.Initialize(new LoggerConfig(
            max_Output_Char_Count: 16 * 1024,
            use_Console_Wrapper: false,
            use_Working_Directory: true,
#if DEBUG
            global_Minimum_LogLevel: LogLevel.Verbose,
            console_Minimum_LogLevel: LogLevel.Information,
#else
            global_Minimum_LogLevel: LogLevel.Information,
            console_Minimum_LogLevel: LogLevel.Information,
#endif
            debug_LogWriter_AutoFlush: true
        ));
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        Log.Info("Kcp-Csharp Performance TESTER");
        Log.Info(await ResourcesLoader.Load());

        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(o =>
            {
                Constants.each_packet_size = o.PacketSize;
                Constants.packet_repeat_time = o.PacketRepeatTime;
                Constants.packet_interval_ms = o.PacketInterval;
                Constants.running_on_github_actions = o.GithubActions;
                Constants.running_clients_count = o.ClientsCount;
                Constants.output_packet_delaylog = o.PacketDelayLog;
            })
            .WithNotParsed(errs =>
            {
                Log.Erro($"Unrecognized args detected. Please use \"--help\" to get usage.");
                Environment.Exit(1);
            });

        await ServerApp.Start();
#if !CONNECT_SERVERONLY
        ProxyApp.Start();
#endif
        for (uint i = 0; i < Constants.running_clients_count; i++)
        {
            await new ClientApp(i).Start();
        }
        _ = Task.Run(ClientApp.WaitForAllClients);

        if (Constants.running_on_github_actions)
        {
            while (true)
            {
                if (!MainAnalysis.TestsFinished) await Task.Delay(10000);
                else Environment.Exit(MainAnalysis.ProgramExitCode);
            }
        }
        else
        {
            Console.ReadLine();
            Environment.Exit(MainAnalysis.ProgramExitCode);
        }
    }

    class Options
    {
        [Option('s', "packet-size", Required = false, HelpText = "The size of each packet.", Default = 3500)]
        public int PacketSize { get; set; }

        [Option('t', "packet-repeat-time", Required = false, HelpText = "The total number of packets to send.", Default = 5000)]
        public int PacketRepeatTime { get; set; }

        [Option('i', "packet-interval", Required = false, HelpText = "The interval between packets in milliseconds.", Default = 50)]
        public int PacketInterval { get; set; }

        [Option('g', "github-actions", Required = false, HelpText = "Whether the program is running on GitHub Actions.", Default = true)]
        public bool GithubActions { get; set; }

        [Option('c', "clients-count", Required = false, HelpText = "The number of concurrent clients.", Default = 1)]
        public int ClientsCount { get; set; }

        [Option('d', "packet-delay-log", Required = false, HelpText = "Whether to generate a packet delay log.", Default = true)]
        public bool PacketDelayLog { get; set; }

        [Usage(ApplicationAlias = "KcpPerformanceTest")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example("Normal usage", new Options { PacketSize = 3500, PacketRepeatTime = 5000, PacketInterval = 50, ClientsCount = 1 });
            }
        }
    }
}
