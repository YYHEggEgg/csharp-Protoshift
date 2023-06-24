using csharp_Protoshift.MhyKCP.Test.Analysis;
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
            Log.Info($"KCPServer listening on localhost:{Constants.UDP_SERVER_PORT}.", nameof(ServerApp));

            _ = Task.Run(async () =>
            {
                while (true)
                {
                    var accepted = await kcpServer.AcceptAsync();
                    Log.Info($"New connection from {accepted.RemoteEndpoint}.", "ServerListening_AsyncTask");
                    var conn = accepted.Connection;
                    // TODO: Push state to analysis
                    _ = Task.Run(() =>
                    {
                        while (true)
                        {
                            if (conn.State != MhyKcpBase.ConnectionState.CONNECTED)
                                return;
                            byte[]? data = null;
                            try
                            {
                                data = conn.Receive();
                            }
                            catch (Exception ex)
                            {
                                Log.Warn($"服务端收包出现异常：{ex}", "ServerReceiver");
                                continue;
                            }
                            BasePacket? pkt = null;
                            try
                            {
                                pkt = new(data);
                            }
                            catch (Exception ex)
                            {
                                Log.Warn($"服务端分析包出现异常：{ex}", "BasePacket");
                                continue;
                            }
                            ServerDataChannel.PushReceivedPacket(pkt);
                            Log.Verb($"Server received packet: length:{data?.Length}, isStructureValid:{pkt.isStructureValid}, isBodyValid:{pkt.isBodyValid}, ack:{pkt.ack}, bodyLen:{pkt.bodyLen}", "ServerReceiver");
                            if (pkt.isStructureValid)
                            {
                                try
                                {
                                    pkt.ack = pkt.ack + 1;
                                    conn.Send(pkt.GetBytes());
                                    ServerDataChannel.PushSentPacket(pkt);
                                    pkt.Dispose();
                                }
                                catch (Exception ex)
                                {
                                    Log.Warn($"服务端回传包出现异常：{ex}", "ServerSending");
                                    continue;
                                }
                            }
                        }
                    });
                }
            });
        }
    }
}