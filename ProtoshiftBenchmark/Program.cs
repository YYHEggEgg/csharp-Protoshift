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

        public const char separateChar = PacketRecord.separateChar;
        public const int PACKET_OVERHEAD = PacketRecord.PACKET_OVERHEAD;

        public static void SetUpBenchmarkSource(string sourcefile)
        {
            List<(string protoname, ushort cmdid, bool sentByClient, byte[] body, int line_id)> readres = new();

            var source_lines = File.ReadAllLines(sourcefile);
            for (int i = 0; i < source_lines.Length; i++)
            {
                var line = source_lines[i];
                var values = line.Split(separateChar);
                string protoname = values[3];
                ushort cmdid = ushort.Parse(values[4]);
                bool sentByClient = bool.Parse(values[5]);
                byte[] data = Convert.FromBase64String(values[7]);
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
            List<(PacketRecord record, int line)> readres = new();

            var source_lines = File.ReadAllLines($"{curdir}/{benchmark_source_file_shared}");
            for (int i = 0; i < source_lines.Length; i++)
            {
                var line = source_lines[i];
                readres.Add((PacketRecord.Parse(line), i));
            }

            var select_res = from tuple in readres
                             let record = tuple.record
                             orderby record.body_length descending
                             group tuple by record.PacketName into gr
                             select gr;
            foreach (var proto_gr in select_res)
            {
                foreach ((var record, int line) in proto_gr)
                {
                    if (record.body_length == 0) break;
                    yield return new()
                    {
                        record = record,
                        line_packet_log = line
                    };
                }
            }
            yield break;
        }

        public class ProtoshiftBenchmarkParamters
        {
            public PacketRecord record;

            public int line_packet_log;

            public override string ToString()
            {
                return $"{record.PacketName} ({record.body_length} bytes, line: {line_packet_log})";
            }
        }

        public static HandlerSession worker = new(1001);

        [Benchmark]
        [ArgumentsSource(nameof(GetBenchmarkArguments))]
        public void ProtoshiftBenchmark(ProtoshiftBenchmarkParamters paramters)
        {
            var record = paramters.record;
            worker.GetPacketResult(record.data, (ushort)record.CmdId, record.sentByClient, 
                record.head_offset, record.head_length, record.body_offset, (uint)record.body_length);
        }
    }
}