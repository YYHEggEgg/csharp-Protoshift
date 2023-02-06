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
            udpSock = new UdpClient(bindToAddress);
            SendToEndpoint = sendToAddress;

            Task.Run(BackgroundUpdate);
        }

        protected new async Task BackgroundUpdate()
        {
            var packet = await udpSock.ReceiveAsync();
            if (clients.ContainsKey(packet.RemoteEndPoint))
            {
                try
                {
                    ((KcpProxy)clients[packet.RemoteEndPoint]).Input(packet.Buffer);
                }
                catch (Exception)
                {
                    clients.Remove(packet.RemoteEndPoint);
                }
            }
            else
            {
                // Oh boy! A new connection!
                var conn = new KcpProxy(sendToAddress: SendToEndpoint);
                conn.Output = (data) => { return udpSock.Send(data, data.Length, packet.RemoteEndPoint); };

                conn.AcceptNonblock();
                try
                {
                    conn.Input(packet.Buffer);

                    clients[packet.RemoteEndPoint] = conn;
                    newConnections.Enqueue(packet.RemoteEndPoint);
                }
                catch (Exception)
                {
                    conn.Dispose();
                }
            }

            if (!_Closed) await Task.Run(BackgroundUpdate);
        }

        /// <summary>
        /// Start a KCP proxy server.
        /// </summary>
        /// <param name="ServerPacketHandler">Handle packet from server to client as a middleware.</param>
        /// <param name="ClientPacketHandler">Handle packet from client to server as a middleware.</param>
        public async void StartProxy(Func<byte[], byte[]>? ServerPacketHandler = null,
            Func<byte[], byte[]>? ClientPacketHandler = null)
        {
            ServerPacketHandler ??= (data => data);
            ClientPacketHandler ??= (data => data);

            while (true)
            {
                try
                {
                    var ret = await AcceptAsync();
                    Log.Info($"New connection from {ret.RemoteEndpoint}.", "KcpProxyServer");

                    HandleServer(ret.RemoteEndpoint, ServerPacketHandler);
                    HandleClient(ret.RemoteEndpoint, ClientPacketHandler);
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", "main");
                }
            }
        }

#pragma warning disable CS8602 // 解引用可能出现空引用。
        protected async void HandleClient(IPEndPoint remotePoint, 
            Func<byte[], byte[]> PacketHandler)
        {
            var conn = (KcpProxy)clients[remotePoint];
            Debug.Assert(conn.State == KCP.ConnectionState.CONNECTED);
            while (conn.State == KCP.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.ReceiveAsync();
                    Log.Dbug($"Server Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", "KcpProxyServer:ServerHandler");
                    var afterpacket = PacketHandler(beforepacket);
                    await conn.sendClient.SendAsync(afterpacket);
                    Log.Dbug($"Client Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ServerHandler");
                }
                catch (Exception e)
                {
                    Log.Erro(e.ToString(), "KcpProxyServer:ServerHandler");
                    conn.Close();
                    break;
                }
            }
        }

        protected async void HandleServer(IPEndPoint remotePoint,
            Func<byte[], byte[]> PacketHandler)
        {
            var conn = (KcpProxy)clients[remotePoint];
            Debug.Assert(conn.sendClient.State == KCP.ConnectionState.CONNECTED);
            while (conn.sendClient.State == KCP.ConnectionState.CONNECTED)
            {
                try
                {
                    var beforepacket = await conn.sendClient.ReceiveAsync();
                    Log.Dbug($"Client Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", "KcpProxyServer:ClientHandler");
                    var afterpacket = PacketHandler(beforepacket);
                    await conn.SendAsync(afterpacket);
                    Log.Dbug($"Server Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer:ClientHandler");
                }
                catch (Exception e)
                {
                    Log.Erro(e.ToString(), "KcpProxyServer:ClientHandler");
                    conn.sendClient.Close();
                    break;
                }
            }
        }
#pragma warning restore CS8602 // 解引用可能出现空引用。
    }
}
