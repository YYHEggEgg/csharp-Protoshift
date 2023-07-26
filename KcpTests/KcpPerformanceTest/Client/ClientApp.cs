using csharp_Protoshift.MhyKCP.Test.Analysis;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.App
{
    public class ClientApp
    {
        public readonly uint clientId;

        public ClientApp(uint clientId)
        {
            this.clientId = clientId;
        }

        public async Task Start()
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
                uint ack = Constants.packet_repeat_time * 2 * clientId + 1;
                for (int i = 0; i < Constants.packet_repeat_time; i++)
                {
                    /*
                    if (Constants.random_packet_size)
                    {
#pragma warning disable CS0162
                        Log.Erro("random_packet_size not implemented!", "ClientSender");
#pragma warning restore CS0162
                        throw new NotImplementedException();
                    }
                    else
                    {
                        */
                        try
                        {
                            BasePacket pkt = BasePacket.Generate(ack, Constants.each_packet_size);
                            kcpClient.Send(pkt.GetBytes());
                            Log.Verb($"Client sent ack: {ack}", "ClientSender");
                            ClientDataChannel.PushSentPacket(pkt);
                            pkt.Dispose();
                            sum_wait_ms += Constants.packet_interval_ms;
                            if (sum_wait_ms >= 15)
                            {
                                await Task.Delay(sum_wait_ms);
                                sum_wait_ms = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Erro($"Client sending packet ack:{ack} meets exception: {ex}", "ClientSender");
                        }
                    // }
                    ack += 2;
                }
                await MainAnalysis.ClientFinished();
            });

            _ = Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        var data = kcpClient.Receive();
                        var packet = new BasePacket(data);
                        ClientDataChannel.PushReceivedPacket(packet);
                        Log.Verb($"Client recved packet: isStructureValid:{packet.isStructureValid}, isBodyValid:{packet.isBodyValid}, ack:{packet.ack}, bodyLen:{packet.bodyLen}");
                        packet.Dispose();
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"Client receiving packet meets exception: {ex}", "ClientReceiver_AsyncTask");
                    }
                }
            });
        }
    }
}