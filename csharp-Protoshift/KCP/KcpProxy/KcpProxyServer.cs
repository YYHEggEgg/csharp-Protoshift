#define KCP_PROXY_VERBOSE

using csharp_Protoshift.GameSession;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Net;
using YYHEggEgg.Logger;
using csharp_Protoshift.SpecialUdp;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class KcpProxyServer : KCPServer
    {
        public IPEndPoint SendToEndpoint { get; }

        public KcpProxyServer(IPEndPoint bindToAddress, IPEndPoint sendToAddress)
        {
            udpSock = new ConcurrentUdpClient(bindToAddress);
            SendToEndpoint = sendToAddress;

            Task.Run(BackgroundUpdate);
        }

        protected override async Task BackgroundUpdate()
        {
            UdpReceiveResult packet;
            try
            {
                packet = await udpSock.ReceiveAsync();
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
                // Oh boy! A new connection!
                var conn = new KcpProxyBase(sendToAddress: SendToEndpoint);
                conn.OutputCallback = new ConcurrentUdpKcpCallback(udpSock, packet.RemoteEndPoint);
                try
                {
                    Log.Dbug($"New connection established, remote endpoint={packet.RemoteEndPoint}");
                    conn.AcceptNonblock();
                    conn.Input(packet.Buffer);

                    clients[packet.RemoteEndPoint] = conn;
                    newConnections.Enqueue(packet.RemoteEndPoint);
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate:NewConnection reached exception {ex}", nameof(KcpProxyServer));
                    conn.Dispose();
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
            var IsUrgentPacket = handlers.IsUrgentClientPacket;
            _ = ClientPacketSender(conn);
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
                            // This part is probably running on bug and don't delete isUrgent variable!
                            var isUrgent = IsUrgentPacket(beforepacket, conn.Conv);
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            (isUrgent ? client_urgentPackets : client_normalPackets)
                                .Enqueue(afterpacket);
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
                    await GameSessionDispatch.DestroySession(conn.Conv);
                    break;
                }
            }
        }

        #region Send Packet
        private ConcurrentQueue<byte[]?> client_urgentPackets = new();
        private ConcurrentQueue<byte[]?> client_normalPackets = new();
        private async Task ClientPacketSender(KcpProxyBase sendConn)
        {
            while (true)
            {
                if (sendConn.sendClient == null)
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(5);
                }
                else if (client_urgentPackets.TryDequeue(out byte[]? urgentPacket))
                {
                    try
                    {
                        if (urgentPacket != null)
                        {
                            /*await */_ = sendConn.sendClient.SendAsync(urgentPacket);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(urgentPacket)}", $"{nameof(KcpProxyServer)}:ServerSender");
#endif
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerSender");
                        //conn.Close();
                    }
                }
                else if (client_normalPackets.TryDequeue(out byte[]? normalPacket))
                {
                    try
                    {
                        if (normalPacket != null)
                        {
                            /*await */
                            _ = sendConn.sendClient.SendAsync(normalPacket);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(normalPacket)}", $"{nameof(KcpProxyServer)}:ServerSender");
#endif
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerSender");
                        //conn.Close();
                    }
                }
                else
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(5);
                }
            }
        }
        #endregion
        #endregion

        #region Handle as a server (send to client)
        protected async void HandleServer(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            if (!clients.ContainsKey(remotePoint)) return;
            var conn = (KcpProxyBase)clients[remotePoint];
            var PacketHandler = handlers.OnServerPacketArrival;
            var IsUrgentPacket = handlers.IsUrgentServerPacket;
            _ = ServerPacketSender(conn);
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
                            // This part is probably running on bug and don't delete isUrgent variable!
                            var isUrgent = IsUrgentPacket(beforepacket, conn.Conv);
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            (isUrgent ? server_urgentPackets : server_normalPackets)
                                .Enqueue(afterpacket);
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
                    await GameSessionDispatch.DestroySession(conn.Conv);
                    break;
                }
            }
        }

        #region Send Packet
        private ConcurrentQueue<byte[]?> server_urgentPackets = new();
        private ConcurrentQueue<byte[]?> server_normalPackets = new();
        private async Task ServerPacketSender(KcpProxyBase sendConn)
        {
            while (true)
            {
                if (server_urgentPackets.TryDequeue(out byte[]? urgentPacket))
                {
                    try
                    {
                        if (urgentPacket != null)
                        {
                            /*await */
                            _ = sendConn.SendAsync(urgentPacket);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Server Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(urgentPacket)}", $"{nameof(KcpProxyServer)}:ClientSender");
#endif
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientSender");
                        //conn.sendClient.Close();
                    }
                    continue;
                }
                else if (server_normalPackets.TryDequeue(out byte[]? normalPacket))
                {
                    try
                    {
                        if (normalPacket != null)
                        {
                            /*await */
                            _ = sendConn.SendAsync(normalPacket);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Server Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(normalPacket)}", $"{nameof(KcpProxyServer)}:ClientSender");
#endif
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientSender");
                        //conn.sendClient.Close();
                    }
                }
                else
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(5);
                }
            }
        }
        #endregion
        #endregion
    }
}
