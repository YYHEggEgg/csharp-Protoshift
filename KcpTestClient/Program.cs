using csharp_Protoshift.MhyKCP;
using System.Net;
using YYHEggEgg.Logger;

namespace KcpTestClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Log.Initialize(new LoggerConfig(
                max_Output_Char_Count: -1,
                use_Console_Wrapper: false,
                use_Working_Directory: true,
                global_Minimum_LogLevel: LogLevel.Verbose,
                console_Minimum_LogLevel: LogLevel.Debug
            ));

            KCPClient kcpClient = new(new(IPAddress.Loopback, 21001));
            await kcpClient.ConnectAsync();
            Log.Info($"KCPClient connected to 127.0.0.1:21001.");

            byte[] rawPacket = Util.GeneratePacket(Constants.each_packet_size);

            // 1. Normal packets
            int sum_wait_ms = 0;
            for (int i = 0; i < Constants.packet_repeat_time; i++)
            {
                // await kcpClient.SendAsync(rawPacket);
                await kcpClient.server.SendAsync(rawPacket);
                sum_wait_ms += Constants.packet_interval_ms;
                if (sum_wait_ms >= 15)
                {
                    Thread.Sleep(sum_wait_ms);
                    sum_wait_ms = 0;
                }
            }
        }
    }
}