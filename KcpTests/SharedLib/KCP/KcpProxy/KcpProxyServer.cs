// #define KCP_PROXY_VERBOSE

using System.Collections.Concurrent;
using System.Net;
using YYHEggEgg.Logger;
using csharp_Protoshift.SpecialUdp;
using System.Diagnostics;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class KcpProxyServer : KCPServer
    {
        public IPEndPoint SendToEndpoint { get; }
        // The timeout of PacketHandler, move to delay-send list if exceeded
        // This timeout is used forcontrol packet order
#if PROXY_FIX_DISORDER_SPECIAL_TEST
        public const int handle_wait_time_ms = 150;
#else
        public const int handle_wait_time_ms = 50;
#endif
        // If PacketHandler is given more time than this, it will be dropped. 
        public const int permanently_drop_time_ms = int.MaxValue;
        public const int high_frequent_monitor_packet_finished_duration_ms = 5;

        public readonly TimeSpan handle_wait_time = TimeSpan.FromMilliseconds(handle_wait_time_ms);
        public readonly TimeSpan permanently_drop_time = TimeSpan.FromMilliseconds(permanently_drop_time_ms);        
        public readonly TimeSpan high_frequent_monitor_packet_finished_duration = TimeSpan.FromMilliseconds(high_frequent_monitor_packet_finished_duration_ms);

        public KcpProxyServer(IPEndPoint bindToAddress, IPEndPoint sendToAddress)
        {
            udpSock = new SocketUdpClient(bindToAddress);
            SendToEndpoint = sendToAddress;

            _updatelock = new(nameof(KcpProxyServer));
            Task.Run(BackgroundUpdate);
        }

        protected override async Task BackgroundUpdate()
        {
            _updatelock.Enter();
            while (!_Closed)
            {
                SocketUdpReceiveResult packet;
                string remoteIpString;
                try
                {
                    packet = await udpSock.ReceiveFromAsync();
                    remoteIpString = packet.RemoteEndPoint.ToString();
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate receiving packet meets error and restart: {ex}", nameof(KcpProxyServer));
                    continue;
                }
                if (clients.ContainsKey(remoteIpString))
                {
                    try
                    {
                        ((KcpProxyBase)clients[remoteIpString]).Input(packet.Buffer);
                    }
                    catch (Exception ex)
                    {
                        Log.Dbug($"BackgroundUpdate:Connected reached exception {ex}", nameof(KcpProxyServer));
                        clients.Remove(remoteIpString);
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
                        Log.Dbug($"New connection established, remote endpoint={remoteIpString}");
                        conn.AcceptNonblock();
                        conn.Input(packet.Buffer);

                        clients[remoteIpString] = conn;
                        newConnections.Enqueue(packet.RemoteEndPoint);
                    }
                    catch (Exception ex)
                    {
                        Log.Dbug($"BackgroundUpdate:NewConnection reached exception {ex}", nameof(KcpProxyServer));
                        conn?.Dispose();
                    }
                }
            }
            _updatelock.Exit();
        }

        /// <summary>
        /// Start a KCP proxy server.
        /// </summary>
        /// <param name="ServerPacketHandler">Handle packet from server to client as a middleware. byte[] is packet, uint is session id.</param>
        /// <param name="ClientPacketHandler">Handle packet from client to server as a middleware. byte[] is packet, uint is session id.</param>
        public async void StartProxy(ProxyHandlers handlers)
        {
            while (!_Closed)
            {
                try
                {
                    var ret = await AcceptAsync();
                    Log.Info($"New connection from {ret.RemoteEndpoint}.", nameof(KcpProxyServer));

                    _ = Task.Run(() => HandleServer(ret.RemoteEndpoint, handlers));
                    _ = Task.Run(() => HandleClient(ret.RemoteEndpoint, handlers));
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", "main");
                }
            }
        }

        #region Handle as a client (send to server)
        protected void HandleClient(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            string remoteIpString = remotePoint.ToString();
            if (!clients.ContainsKey(remoteIpString)) return;
            var conn = (KcpProxyBase)clients[remoteIpString];
            var PacketHandler = handlers.OnClientPacketArrival;
            var IsOrderedPacket = handlers.ClientPacketOrdered;
            _ = ClientPacketSender(conn);
            _ = ClientTimeoutPacketSender(conn);
            while (conn?.State == MhyKcpBase.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = conn.Receive();
                    if (beforepacket == null)
                    {
                        Log.Dbug($"Skipped null? packet (session {conn.Conv})", $"{nameof(KcpProxyServer)}:ServerHandler");
                        continue;
                    }
#if KCP_PROXY_VERBOSE
                    Log.Dbug($"Server Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", $"{nameof(KcpProxyServer)}:ServerHandler");
#endif
                    _ = Task.Run(() =>
                    {
                        if (IsOrderedPacket(beforepacket, conn.Conv))
                        {
                            ProxyPacket push_pkt = new ProxyPacket
                            {
                                create_time = DateTime.Now,
                                handled = false,
                                send_res = null
                            };
                            client_normalPackets.Enqueue(push_pkt);
                            try
                            {
                                var afterpacket = PacketHandler(beforepacket, conn.Conv);
                                push_pkt.send_res = afterpacket;
                            }
                            catch (Exception e)
                            {
                                Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerHandler");
                                //conn.Close();
                            }
                            finally
                            {
                                push_pkt.handled = true;
                            }
                        }
                        else
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
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerHandler");
                    // conn.Close();
                    // GameSessionDispatch.DestroySession(conn.Conv);
                    break;
                }
            }
        }

        #region Send Packet
        private ConcurrentQueue<ProxyPacket> client_normalPackets = new();
        // packets timeout of handle time
        private ConcurrentQueue<ProxyPacket> client_timeoutPackets = new();
        private async Task ClientPacketSender(KcpProxyBase sendConn)
        {
            while (true)
            {
                if (sendConn.sendClient == null)
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(15);
                }
                else if (client_normalPackets.TryPeek(out ProxyPacket? normalPacket))
                {
                    if (normalPacket == null)
                    {                        
                        client_normalPackets.TryDequeue(out _);
                        continue;
                    }
                    normalPacket.positive_time_start ??= DateTime.Now;
                    if (normalPacket.handled)
                    {
                        try
                        {
                            if (normalPacket.send_res != null)
                            {
                                sendConn.sendClient.Send(normalPacket.send_res);
#if KCP_PROXY_VERBOSE
                                Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(normalPacket)}", $"{nameof(KcpProxyServer)}:ServerSender");
#endif
                            }
                            client_normalPackets.TryDequeue(out ProxyPacket? _deqpkt);
                            Debug.Assert(Object.ReferenceEquals(normalPacket, _deqpkt));
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerSender");
                            //conn.Close();
                        }
                    }
                    else if (DateTime.Now - normalPacket.create_time > handle_wait_time)
                    {
                        client_timeoutPackets.Enqueue(normalPacket);
                        client_normalPackets.TryDequeue(out ProxyPacket? _deqpkt);
                        Debug.Assert(Object.ReferenceEquals(normalPacket, _deqpkt));
                    }
                    else if (DateTime.Now - normalPacket.positive_time_start 
                        > high_frequent_monitor_packet_finished_duration)
                    {
                        if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                        await Task.Delay(15);
                    }
                    else
                    {
                        if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                        await Task.Yield();
                    }
                }
                else
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(15);
                }
            }
        }

        private async Task ClientTimeoutPacketSender(KcpProxyBase sendConn)
        {
            Queue<ProxyPacket> tmp_pktqueue = new();
            while (true)
            {
                if (sendConn.sendClient == null)
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(15);
                }
                else
                {
                    while (client_timeoutPackets.TryDequeue(out ProxyPacket? pkt))
                    {
                        if (pkt == null) continue;
                        if (pkt.handled)
                        {
                            sendConn.sendClient.Send(pkt.send_res);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(pkt.send_res)}", $"{nameof(KcpProxyServer)}:ServerTimeoutPacketSender");
#endif
                        }
                        else if (DateTime.Now - pkt.create_time <= permanently_drop_time)
                        {
                            tmp_pktqueue.Enqueue(pkt);
                        }
                    }
                    while (tmp_pktqueue.TryDequeue(out ProxyPacket? in_pkt))
                    {
                        if (in_pkt == null) continue;
                        client_timeoutPackets.Enqueue(in_pkt);
                    }
                }
                await Task.Delay(15);
            }
        }
        #endregion
        #endregion

        #region Handle as a server (send to client)
        protected void HandleServer(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            string remoteIpString = remotePoint.ToString();
            if (!clients.ContainsKey(remoteIpString)) return;
            var conn = (KcpProxyBase)clients[remoteIpString];
            var PacketHandler = handlers.OnServerPacketArrival;
            var IsOrderedPacket = handlers.ServerPacketOrdered;
            _ = ServerPacketSender(conn);
            _ = ServerTimeoutPacketSender(conn);
            while (conn.sendClient?.State == MhyKcpBase.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = conn.sendClient.Receive();
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
                        if (IsOrderedPacket(beforepacket, conn.Conv))
                        {
                            ProxyPacket push_pkt = new ProxyPacket
                            {
                                create_time = DateTime.Now,
                                handled = false,
                                send_res = null
                            };
                            server_normalPackets.Enqueue(push_pkt);
                            try
                            {
                                var afterpacket = PacketHandler(beforepacket, conn.Conv);
                                push_pkt.send_res = afterpacket;
                            }
                            catch (Exception e)
                            {
                                Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                                //conn.Close();
                            }
                            finally
                            {
                                push_pkt.handled = true;
                            }
                        }
                        else
                        {
                            try
                            {
                                var afterpacket = PacketHandler(beforepacket, conn.Conv);
                                conn.Send(afterpacket);
#if KCP_PROXY_VERBOSE
                                Log.Dbug($"Client Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(urgentPacket)}", $"{nameof(KcpProxyServer)}:ClientSender");
#endif
                            }
                            catch (Exception e)
                            {
                                Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                                //conn.Close();
                            }
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                    // conn.sendClient.Close();
                    // await GameSessionDispatch.DestroySession(conn.Conv);
                    break;
                }
            }
        }

        #region Send Packet
        private ConcurrentQueue<ProxyPacket> server_normalPackets = new();
        private ConcurrentQueue<ProxyPacket> server_timeoutPackets = new();
        private async Task ServerPacketSender(KcpProxyBase sendConn)
        {
            while (true)
            {
                if (server_normalPackets.TryPeek(out ProxyPacket? normalPacket))
                {
                    if (normalPacket == null)
                    {
                        server_normalPackets.TryDequeue(out _);
                        continue;
                    }
                    normalPacket.positive_time_start ??= DateTime.Now;
                    if (normalPacket.handled)
                    {
                        try
                        {
                            if (normalPacket.send_res != null)
                            {
                                sendConn.Send(normalPacket.send_res);
#if KCP_PROXY_VERBOSE
                                Log.Dbug($"Server Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(normalPacket)}", $"{nameof(KcpProxyServer)}:ClientSender");
#endif
                            }
                            server_normalPackets.TryDequeue(out ProxyPacket? _deqpkt);
                            Debug.Assert(Object.ReferenceEquals(normalPacket, _deqpkt));
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientSender");
                            //conn.Close();
                        }
                    }
                    else if (DateTime.Now - normalPacket.create_time > handle_wait_time)
                    {
                        server_timeoutPackets.Enqueue(normalPacket);
                        server_normalPackets.TryDequeue(out ProxyPacket? _deqpkt);
                        Debug.Assert(Object.ReferenceEquals(normalPacket, _deqpkt));
                    }
                    else if (DateTime.Now - normalPacket.positive_time_start 
                        > high_frequent_monitor_packet_finished_duration)
                    {
                        if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                        await Task.Delay(15);
                    }
                    else
                    {
                        if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                        await Task.Yield();
                    }
                }
                else
                {
                    if (sendConn.State != MhyKcpBase.ConnectionState.CONNECTED) return;
                    await Task.Delay(15);
                }
            }
        }

        private async Task ServerTimeoutPacketSender(KcpProxyBase sendConn)
        {
            Queue<ProxyPacket> tmp_pktqueue = new();
            while (true)
            {
                while (server_timeoutPackets.TryDequeue(out ProxyPacket? pkt))
                {
                    if (pkt == null) continue;
                    if (pkt.handled)
                    {
                        sendConn.Send(pkt.send_res);
#if KCP_PROXY_VERBOSE
                        Log.Dbug($"Server Sent Packet (session {sendConn.Conv})---{Convert.ToHexString(pkt.send_res)}", $"{nameof(KcpProxyServer)}:ClientTimeoutPacketSender");
#endif
                    }
                    else if (DateTime.Now - pkt.create_time <= permanently_drop_time)
                    {
                        tmp_pktqueue.Enqueue(pkt);
                    }
                }
                while (tmp_pktqueue.TryDequeue(out ProxyPacket? in_pkt))
                {
                    if (in_pkt == null) continue;
                    server_timeoutPackets.Enqueue(in_pkt);
                }
                await Task.Delay(15);
            }
        }
        #endregion
        #endregion
    }
}
