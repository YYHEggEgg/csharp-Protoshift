// #define KCP_PROXY_VERBOSE

using System.Collections.Concurrent;
using System.Net;
using YYHEggEgg.Logger;
using csharp_Protoshift.SpecialUdp;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class KcpProxyServer : KCPServer
    {
        public IPEndPoint SendToEndpoint { get; }

        public KcpProxyServer(IPEndPoint bindToAddress, IPEndPoint sendToAddress)
        {
            udpSock = new SocketUdpClient(bindToAddress);
            SendToEndpoint = sendToAddress;

            Task.Run(BackgroundUpdate);
        }

        protected override async Task BackgroundUpdate()
        {
            SocketUdpReceiveResult packet;
            try
            {
                packet = await udpSock.ReceiveFromAsync();
            }
            catch (Exception ex)
            {
                Log.Dbug($"BackgroundUpdate receiving packet meets error and restart: {ex}", nameof(KcpProxyServer));
                await Task.Run(BackgroundUpdate);
                return;
            }
            if (clients.ContainsKey(packet.RemoteEndPoint))
            {
                try
                {
                    ((KcpProxyBase)clients[packet.RemoteEndPoint]).Input(packet.Buffer);
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate:Connected reached exception {ex}", nameof(KcpProxyServer));
                    clients.Remove(packet.RemoteEndPoint);
                }
            }
            else
            {
                KcpProxyBase? conn = null;
                try
                {
                    // Oh boy! A new connection!
                    conn = new KcpProxyBase(sendToAddress: SendToEndpoint);
                    conn.OutputCallback = new SocketUdpKcpCallback(udpSock, packet.RemoteEndPoint);
                    Log.Dbug($"New connection established, remote endpoint={packet.RemoteEndPoint}");
                    conn.AcceptNonblock();
                    conn.Input(packet.Buffer);

                    clients[packet.RemoteEndPoint] = conn;
                    newConnections.Enqueue(packet.RemoteEndPoint);
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate:NewConnection reached exception {ex}", nameof(KcpProxyServer));
                    conn?.Dispose();
                }
            }

            if (!_Closed) await Task.Run(BackgroundUpdate);
        }

        /// <summary>
        /// Start a KCP proxy server.
        /// </summary>
        /// <param name="ServerPacketHandler">Handle packet from server to client as a middleware. byte[] is packet, uint is session id.</param>
        /// <param name="ClientPacketHandler">Handle packet from client to server as a middleware. byte[] is packet, uint is session id.</param>
        public async void StartProxy(ProxyHandlers handlers)
        {
            while (true)
            {
                try
                {
                    var ret = await AcceptAsync();
                    Log.Info($"New connection from {ret.RemoteEndpoint}.", nameof(KcpProxyServer));

                    HandleServer(ret.RemoteEndpoint, handlers);
                    HandleClient(ret.RemoteEndpoint, handlers);
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", "main");
                }
            }
        }

        #region Handle as a client (send to server)
        protected async void HandleClient(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            if (!clients.ContainsKey(remotePoint)) return;
            var conn = (KcpProxyBase)clients[remotePoint];
            var PacketHandler = handlers.OnClientPacketArrival;
            while (conn.State == MhyKcpBase.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.ReceiveAsync();
#if KCP_PROXY_VERBOSE
                    Log.Dbug($"Server Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", $"{nameof(KcpProxyServer)}:ServerHandler");
#endif
                    _ = Task.Run(() =>
                    {
                        try
                        {
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            conn.sendClient.Send(afterpacket);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(urgentPacket)}", $"{nameof(KcpProxyServer)}:ServerSender");
#endif
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerHandler");
                            //conn.Close();
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerHandler");
                    conn.Close();
                    break;
                }
            }
        }
        #endregion

        #region Handle as a server (send to client)
        protected async void HandleServer(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            if (!clients.ContainsKey(remotePoint)) return;
            var conn = (KcpProxyBase)clients[remotePoint];
            var PacketHandler = handlers.OnServerPacketArrival;
            while (conn.sendClient?.State == MhyKcpBase.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.sendClient.ReceiveAsync();
                    if (beforepacket == null) 
                    { 
                        Log.Dbug($"Skipped null? packet (session {conn.Conv})", $"{nameof(KcpProxyServer)}:ClientHandler");
                        continue;
                    }
#if KCP_PROXY_VERBOSE
                    Log.Dbug($"Client Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", $"{nameof(KcpProxyServer)}:ClientHandler");
#endif
                    _ = Task.Run(() =>
                    {
                        try
                        {
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            conn.Send(afterpacket);
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                            //conn.sendClient.Close();
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                    conn.sendClient.Close();
                    break;
                }
            }
        }
        #endregion
    }
}
