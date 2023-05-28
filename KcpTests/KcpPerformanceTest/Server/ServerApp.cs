using csharp_Protoshift.MhyKCP.Test.Protocol;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.App
{
    public static class ServerApp
    {
        public static async Task Start()
        {
            KCPServer kcpServer = new(new(IPAddress.Loopback, Constants.UDP_SERVER_PORT));
            Log.Info($"KCPServer listening on 127.0.0.1:{Constants.UDP_SERVER_PORT}.", nameof(ServerApp));

            _ = Task.Run(async () =>
            {
                while (true)
                {
                    var accepted = await kcpServer.AcceptAsync();
                    var conn = accepted.Connection;
                    // TODO: Push state to analysis
                    _ = Task.Run(async () =>
                    {
                        while (true)
                        {
                            if (conn.State != MhyKcpBase.ConnectionState.CONNECTED)
                                return;
                            var data = await conn.ReceiveAsync();
                            BasePacket pkt = new(data);
                            if (pkt.isStructureValid)
                            {
                                pkt.ack = pkt.ack + 1;
                                // TODO: Push state to analysis
                                conn.Send(pkt.GetBytes());
                            }
                        }
                    });
                }
            }
        }
    }
}