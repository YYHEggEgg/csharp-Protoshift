using csharp_Protoshift.MhyKCP.Test.Analysis;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class ClientApp
    {
        public static async Task Start()
        {
#if CONNECT_SERVERONLY
            KCPClient kcpClient = new(new(IPAddress.Loopback, Constants.UDP_SERVER_PORT));
#else
            KCPClient kcpClient = new(new(IPAddress.Loopback, Constants.UDP_PROXY_PORT));
#endif
            await kcpClient.ConnectAsync();
#if CONNECT_SERVERONLY
            Log.Info($"KCPClient connected to localhost:{Constants.UDP_SERVER_PORT}.", nameof(ClientApp));
#else
            Log.Info($"KCPClient connected to localhost:{Constants.UDP_PROXY_PORT}.", nameof(ClientApp));
#endif
            _ = Task.Run(async () =>
            {
                int sum_wait_ms = 0;
                uint ack = 1;
                for (int i = 0; i < Constants.packet_repeat_time; i++)
                {
                    if (Constants.random_packet_size)
                        throw new NotImplementedException();
                    else
                    {
                        BasePacket pkt = BasePacket.Generate(ack, Constants.each_packet_size);
                        kcpClient.Send(pkt.GetBytes());
                        ClientDataChannel.PushSentPacket(pkt);
                        pkt.Dispose();
                        sum_wait_ms += Constants.packet_interval_ms;
                        if (sum_wait_ms >= 15)
                        {
                            await Task.Delay(sum_wait_ms);
                            sum_wait_ms = 0;
                        }
                    }
                }
            });

            _ = Task.Run(async () =>
            {
                while (true)
                {
                    var data = await kcpClient.ReceiveAsync();
                    // 由于BasePacket的buffer不来自ArrayPool分配，此处不释放不会影响程序逻辑
                    ClientDataChannel.PushReceivedPacket(new BasePacket(data));
                }
            });
        }
    }
}