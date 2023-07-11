// #define KCP_PROXY_VERBOSE // not avaliable currently

using System.Collections.Concurrent;
using System.Net;
using YYHEggEgg.Logger;
using csharp_Protoshift.SpecialUdp;
using YSFreedom.Common.Util;
using System.Buffers.Binary;
using System.Net.Sockets.Kcp;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class KcpProxyServer : KCPServer
    {
        public IPEndPoint SendToEndpoint { get; }

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
                try
                {
                    packet = await udpSock.ReceiveFromAsync();
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate receiving packet meets error and restart: {ex}", nameof(KcpProxyServer));
                    continue;
                }
                if (packet.Buffer.Length == Handshake.LEN)
                {
                    Handshake handshake = new();
                    try
                    {
                        handshake.Decode(packet.Buffer);
                    }
                    catch (Exception) { continue; }
                    if (connected_clients.TryGetValue(handshake.Conv, out var connected_conn)) // conv dispatch
                    {
                        try
                        {
                            ((KcpProxyBase)connected_conn).Input(packet.Buffer);
                        }
                        catch (Exception ex)
                        {
                            Log.Dbug($"BackgroundUpdate:Connected reached exception {ex}", nameof(KcpProxyServer));
                            if (connected_conn.State != MhyKcpBase.ConnectionState.CONNECTED)
                                connected_clients.TryRemove(connected_conn.Conv, out _);
                        }
                        continue;
                    }
                    // ip dispatch
                    string remoteIpString = packet.RemoteEndPoint.ToString();
                    KcpProxyBase conn;
                    if (!connecting_clients.TryGetValue(remoteIpString, out var _outconn))
                    {
                        // Oh boy! A new connection!
                        conn = new KcpProxyBase(sendToAddress: SendToEndpoint);
                        conn.OutputCallback = new SocketUdpKcpCallback(udpSock, packet.RemoteEndPoint);
                        Log.Dbug($"New connection established, remote endpoint={remoteIpString}");
                        conn.AcceptNonblock();
                        connecting_clients[remoteIpString] = conn;
                        _ = Task.Run(async () =>
                        {
                            try
                            {
                                await conn.AcceptAsync();
                            }
                            catch
                            {
                                connecting_clients.TryRemove(remoteIpString, out _);
                            }
                        });
                    }
                    else conn = (KcpProxyBase)_outconn;
                    try
                    {
                        conn.Input(packet.Buffer);
                        if (conn.State == MhyKcpBase.ConnectionState.CONNECTED)
                        {
                            newConnections.Enqueue(new AcceptAsyncReturn { Connection = conn, RemoteEndpoint = packet.RemoteEndPoint });
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Dbug($"BackgroundUpdate:NewConnection reached exception {ex}", nameof(KcpProxyServer));
                    }
                }
                else if (packet.Buffer.Length >= KcpConst.IKCP_OVERHEAD) // conv dispatch
                {
                    var conv = BinaryPrimitives.ReadUInt32LittleEndian(packet.Buffer);
                    if (connected_clients.TryGetValue(conv, out var conn))
                    {
                        try
                        {
                            ((KcpProxyBase)conn).Input(packet.Buffer);
                        }
                        catch (Exception)
                        {
                            if (conn.State != MhyKcpBase.ConnectionState.CONNECTED)
                                connected_clients.TryRemove(conv, out _);
                        }
                    }
                }
            }
            _updatelock.Exit();
        }

        /// <summary>
        /// Start a KCP proxy server.
        /// </summary>
        /// <param name="handlers">Middleware packet handlers.</param>
        public void StartProxy(ProxyHandlers handlers)
        {
            while (!_Closed)
            {
                try
                {
                    var ret = Accept();
                    Log.Info($"New connection (conv={ret.Connection.Conv}, token={ret.Connection.Token}) from {ret.RemoteEndpoint}.", nameof(KcpProxyServer));

                    _ = Task.Run(() => HandleServer((KcpProxyBase)ret.Connection, handlers));
                    _ = Task.Run(() => HandleClient((KcpProxyBase)ret.Connection, handlers));
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", nameof(StartProxy));
                }
            }
        }

        #region Handle as a client (send to server)
        protected void HandleClient(KcpProxyBase conn, ProxyHandlers handlers)
        {
            var IsOrderedPacket = handlers.ClientPacketOrdered;
            var PacketHandler = handlers.OnClientPacketArrival;
            while (conn.State == MhyKcpBase.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = conn.Receive();
#if KCP_PROXY_VERBOSE
                    Log.Dbug($"Server Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", $"{nameof(KcpProxyServer)}:ServerHandler");
#endif
                    if (beforepacket == null)
                    {
                        Log.Dbug($"Skipped null? packet (session {conn.Conv})", $"{nameof(KcpProxyServer)}:ServerHandler");
                        continue;
                    }
                    if (IsOrderedPacket(beforepacket, conn.Conv))
                    {
                        HandlerSendClientPacket(conn, beforepacket, PacketHandler);
                    }
                    else
                    {
                        _ = Task.Run(() => HandlerSendClientPacket(conn, beforepacket, PacketHandler));
                    }
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ServerHandler");
                    //conn.Close();
                    break;
                }
            }
        }

        private void HandlerSendClientPacket(KcpProxyBase conn, byte[] beforepacket, 
            Func<byte[], uint, byte[]?> PacketHandler)
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
        #endregion

        #region Handle as a server (send to client)
        protected void HandleServer(KcpProxyBase conn, ProxyHandlers handlers)
        {
            var IsOrderedPacket = handlers.ServerPacketOrdered;
            var PacketHandler = handlers.OnServerPacketArrival;
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
                    if (IsOrderedPacket(beforepacket, conn.Conv))
                    {
                        HandlerSendServerPacket(conn, beforepacket, PacketHandler);
                    }
                    else
                    {
                        _ = Task.Run(() => HandlerSendServerPacket(conn, beforepacket, PacketHandler));
                    }
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), $"{nameof(KcpProxyServer)}:ClientHandler");
                    //conn.sendClient.Close();
                    break;
                }
            }
        }

        private void HandlerSendServerPacket(KcpProxyBase conn, byte[] beforepacket,
            Func<byte[], uint, byte[]?> PacketHandler)
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
        }
        #endregion

        #region Send custom packet
        /// <summary>
        /// Send a certain KCP packet to the connected client. 
        /// </summary>
        /// <param name="conv">The <see cref="MhyKcpBase.Conv"/> of the connection.</param>
        /// <param name="content">The packet content.</param>
        /// <exception cref="KeyNotFoundException">The specified session does not exist.</exception>
        public void SendPacketToClient(uint conv, byte[] content)
        {
            if (!connected_clients.ContainsKey(conv))
            {
                throw new KeyNotFoundException($"The specified session (conv: {conv}) does not exist.");
            }
            var conn = (KcpProxyBase)connected_clients[conv];
            conn.Send(content);
        }

        /// <summary>
        /// Send a certain KCP packet to the server. 
        /// </summary>
        /// <param name="conv">The <see cref="MhyKcpBase.Conv"/> of the connection.</param>
        /// <param name="content">The packet content.</param>
        /// <exception cref="KeyNotFoundException">The specified session does not exist.</exception>
        public void SendPacketToServer(uint conv, byte[] content)
        {
            if (!connected_clients.ContainsKey(conv))
            {
                throw new KeyNotFoundException($"The specified session (conv: {conv}) does not exist.");
            }
            var conn = (KcpProxyBase)connected_clients[conv];
            conn.sendClient.Send(content);
        }
        #endregion
    }
}
