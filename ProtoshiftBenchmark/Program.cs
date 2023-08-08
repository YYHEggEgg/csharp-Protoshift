using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using csharp_Protoshift.GameSession;
using System.Text;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Benchmark
{
    [Orderer(SummaryOrderPolicy.SlowestToFastest)]
    public class Program
    {
        public const string benchmark_source_file_suffix = "benchmark-source.packet.log";
        public const string benchmark_source_file_shared = $"logs/latest.{benchmark_source_file_suffix}";

        private static void Main(string[] args)
        {
            StartupWorkingDirChanger.ChangeToDotNetRunPath(new LoggerConfig(
                max_Output_Char_Count: 16 * 1024,
                use_Console_Wrapper: false,
                use_Working_Directory: true,
                global_Minimum_LogLevel: LogLevel.Verbose,
                console_Minimum_LogLevel: LogLevel.Information,
                debug_LogWriter_AutoFlush: true
            ));
            if (File.Exists(benchmark_source_file_shared))
            {
                File.Move(benchmark_source_file_shared,
                    $"logs/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.{benchmark_source_file_suffix}");
            }

            Log.Info("Please drag in the latest.packet.log file:");
            var sourcefile = Console.ReadLine();
            SetUpBenchmarkSource(sourcefile);

            BenchmarkRunner.Run<Program>(
                ManualConfig
                .Create(DefaultConfig.Instance)
                .WithSummaryStyle(SummaryStyle.Default
                    .WithMaxParameterColumnWidth(100))
                .WithOption(ConfigOptions.DisableLogFile, true)
                .WithOption(ConfigOptions.JoinSummary, true)
                .WithOption(ConfigOptions.StopOnFirstError, false)
                .WithOption(ConfigOptions.KeepBenchmarkFiles, false)
                .WithArtifactsPath(Path.Combine(Directory.GetCurrentDirectory(), "output_benchmark")));
            Console.ReadLine();
        }

        public static readonly string curdir;
        static Program()
        {
            curdir = Environment.CurrentDirectory;
            while (true)
            {
                if (File.Exists($"{curdir}/ProtoshiftBenchmark.csproj"))
                {
                    break;
                }
                curdir = Directory.GetParent(curdir)?.FullName ?? throw new FileNotFoundException("csproj file not found!");
            }
        }

        public const char separateChar = '|';

        public static void SetUpBenchmarkSource(string sourcefile)
        {
            List<(string protoname, ushort cmdid, bool sentByClient, byte[] body, int line_id)> readres = new();

            var source_lines = File.ReadAllLines(sourcefile);
            for (int i = 0; i < source_lines.Length; i++)
            {
                var line = source_lines[i];
                var values = line.Split(separateChar);
                string protoname = values[1];
                ushort cmdid = ushort.Parse(values[2]);
                bool sentByClient = bool.Parse(values[3]);
                byte[] data = Convert.FromBase64String(values[4]);
                readres.Add((protoname, cmdid, sentByClient, data, i));
            }

            var select_res = from record in readres
                             orderby record.body.Length descending
                             group record by record.protoname into gr
                             select gr;
            StringBuilder sb = new();
            foreach (var proto_gr in select_res)
            {
                int count = 1;
                foreach (var record in proto_gr)
                {
                    if (record.body.Length == 0) break;
                    if (count-- <= 0) break;
                    sb.AppendLine(source_lines[record.line_id]);
                }
            }

            File.WriteAllText($"{curdir}/{benchmark_source_file_shared}", sb.ToString());
        }

        public IEnumerable<ProtoshiftBenchmarkParamters> GetBenchmarkArguments()
        {
            List<(string protoname, ushort cmdid, bool sentByClient, byte[] body, int line_id)> readres = new();

            var source_lines = File.ReadAllLines($"{curdir}/{benchmark_source_file_shared}");
            for (int i = 0; i < source_lines.Length; i++)
            {
                var line = source_lines[i];
                var values = line.Split(separateChar);
                string protoname = values[1];
                ushort cmdid = ushort.Parse(values[2]);
                bool sentByClient = bool.Parse(values[3]);
                byte[] data = Convert.FromBase64String(values[4]);
                readres.Add((protoname, cmdid, sentByClient, data, i));
            }

            var select_res = from record in readres
                             orderby record.body.Length descending
                             group record by record.protoname into gr
                             select gr;
            foreach (var proto_gr in select_res)
            {
                int count = 1;
                foreach (var record in proto_gr)
                {
                    if (record.body.Length == 0) break;
                    if (count-- <= 0) break;
                    yield return new()
                    {
                        protoname = record.protoname,
                        cmdid = record.cmdid,
                        isNewCmdid = record.sentByClient,
                        Packet = record.body,
                        body_offset = 0,
                        body_length = (uint)record.body.Length,
                        line_packet_log = record.line_id
                    };
                }
            }
            yield break;
        }

        public class ProtoshiftBenchmarkParamters
        {
            /// <summary>
            /// the protoname, read from the record file.
            /// </summary>
            public string protoname;
            public ushort cmdid;
            public bool isNewCmdid;
            /// <summary>
            /// the packet, mixed packet head and packet body.
            /// </summary>
            public byte[] Packet;
            public int head_offset;
            public int head_length;
            public int body_offset;
            public uint body_length;

            public int line_packet_log;

            public override string ToString()
            {
                return $"{protoname} ({body_length} bytes, line: {line_packet_log})";
            }
        }

        public static HandlerSession worker = new(1001);

        [Benchmark]
        [ArgumentsSource(nameof(GetBenchmarkArguments))]
        public void ProtoshiftBenchmark(ProtoshiftBenchmarkParamters paramters)
        {
            worker.GetPacketResult(paramters.Packet, paramters.cmdid,
                paramters.isNewCmdid, paramters.body_offset, paramters.body_length);
        }
    }
}