using csharp_Protoshift.MhyKCP;
using System.Net;
using YYHEggEgg.Logger;

namespace KcpTestServer
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
                console_Minimum_LogLevel: LogLevel.Verbose
            ));

            KCPServer kcpServer = new(new(IPAddress.Loopback, 21001));
            Log.Info($"KCPServer listening on 127.0.0.1:21001.");

            var accepted = await kcpServer.AcceptAsync();
            var conn = accepted.Connection;
            while (true)
            {
                var pkt = await conn.ReceiveAsync();
                Log.Info($"KcpServer received packet of {pkt.Length} bytes, send back");
                await conn.SendAsync(pkt);
            }
        }
    }
}