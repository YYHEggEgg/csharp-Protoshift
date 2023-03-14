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

namespace csharp_Protoshift.KcpProxy
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

        protected new async Task BackgroundUpdate()
        {
            UdpReceiveResult packet;
            try
            {
                packet = await udpSock.ReceiveAsync();
            }
            catch (Exception ex)
            {
                Log.Dbug($"BackgroundUpdate receiving packet meets error and restart: {ex}", "KcpProxyServer");
                await Task.Run(BackgroundUpdate);
                return;
            }
            if (clients.ContainsKey(packet.RemoteEndPoint))
            {
                try
                {
                    ((KcpProxy)clients[packet.RemoteEndPoint]).Input(packet.Buffer);
                }
                catch (Exception ex)
                {
                    Log.Dbug($"BackgroundUpdate:Connected reached exception {ex}", "KcpProxyServer");
                    clients.Remove(packet.RemoteEndPoint);
                }
            }
            else
            {
                // Oh boy! A new connection!
                var conn = new KcpProxy(sendToAddress: SendToEndpoint);
                conn.Output = async (data) 
                    => return await udpSock.SendAsync(data, data.Length, packet.RemoteEndPoint);
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
                    Log.Dbug($"BackgroundUpdate:NewConnection reached exception {ex}", "KcpProxyServer");
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
            handlers.OnServerPacketArrival ??= ((data, conv) => data);
            handlers.OnClientPacketArrival ??= ((data, conv) => data);
            handlers.IsUrgentServerPacket ??= ((data, conv) => false);
            handlers.IsUrgentClientPacket ??= ((data, conv) => false);

            while (true)
            {
                try
                {
                    var ret = await AcceptAsync();
                    Log.Info($"New connection from {ret.RemoteEndpoint}.", "KcpProxyServer");

                    HandleServer(ret.RemoteEndpoint, handlers);
                    HandleClient(ret.RemoteEndpoint, handlers);
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", "main");
                }
            }
        }

        protected async void HandleClient(IPEndPoint remotePoint, ProxyHandlers handlers)
        {
            var conn = (KcpProxy)clients[remotePoint];
            var PacketHandler = handlers.OnClientPacketArrival;
            var IsUrgentPacket = handlers.IsUrgentClientPacket;
            while (conn.State == KCP.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.ReceiveAsync();
                    // Log.Dbug($"Server Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", "KcpProxyServer:ServerHandler");
                    if (IsUrgentPacket(beforepacket, conn.Conv))
                    {
                        var afterpacket = PacketHandler(beforepacket, conn.Conv);
                        if (afterpacket != null)
                            await conn.sendClient.SendAsync(afterpacket);
                        // Log.Dbug($"Client Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ServerHandler");
                    }
                    else Task.Run(() =>
                    {
                        try
                        {
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            if (afterpacket != null)
                                await conn.sendClient.SendAsync(afterpacket);
                            // Log.Dbug($"Client Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ServerHandler");
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), "KcpProxyServer:ServerHandler");
                            //conn.Close();
                            break;
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), "KcpProxyServer:ServerHandler");
                    conn.Close();
                    break;
                }
            }
        }

        protected async void HandleServer(IPEndPoint remotePoint,
            Func<byte[], uint, byte[]> PacketHandler)
        {
            var conn = (KcpProxy)clients[remotePoint];
            var PacketHandler = handlers.OnServerPacketArrival;
            var IsUrgentPacket = handlers.IsUrgentServerPacket;
            while (conn.sendClient.State == KCP.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.sendClient.ReceiveAsync();
                    // Log.Dbug($"Client Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", "KcpProxyServer:ClientHandler");
                    if (IsUrgentPacket(beforepacket, conn.Conv))
                    {
                        var afterpacket = PacketHandler(beforepacket, conn.Conv);
                        if (afterpacket != null)
                            await conn.SendAsync(afterpacket);
                        // Log.Dbug($"Server Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ClientHandler");
                    }
                    else Task.Run(() =>
                    {
                        try
                        {
                            var afterpacket = PacketHandler(beforepacket, conn.Conv);
                            if (afterpacket != null)
                                await conn.SendAsync(afterpacket);
                            // Log.Dbug($"Server Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ClientHandler");
                        }
                        catch (Exception e)
                        {
                            Log.Dbug(e.ToString(), "KcpProxyClient:ClientHandler");
                            //conn.sendClient.Close();
                            break;
                        }
                    });
                }
                catch (Exception e)
                {
                    Log.Dbug(e.ToString(), "KcpProxyServer:ClientHandler");
                    conn.sendClient.Close();
                    break;
                }
            }
        }
    }
}
