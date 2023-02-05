﻿using System;
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

        public async void StartProxy(Func<byte[], byte[]>? PacketHandler = null)
        {
            PacketHandler ??= (data => data);

            while (true)
            {
                try
                {
                    var ret = await AcceptAsync();
                    Log.Info($"New connection from {ret.RemoteEndpoint}.", "KcpProxyServer");

                    HandleClient(ret.RemoteEndpoint, PacketHandler);
                }
                catch (Exception ex)
                {
                    Log.Erro($"Internal error: {ex}", "main");
                }
            }
        }

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
                    Log.Dbug($"Received Packet (session {conn.Conv})---{Convert.ToHexString(beforepacket)}", "KcpProxyServer");
                    var afterpacket = PacketHandler(beforepacket);
                    await conn.sendClient.SendAsync(afterpacket);
                    Log.Dbug($"Sent Packet (session {conn.Conv})---{Convert.ToHexString(afterpacket)}", "KcpProxyServer");
                }
                catch (Exception e)
                {
                    Log.Erro(e.ToString(), "KcpProxyServer");
                    conn.Close();
                    break;
                }
            }
        }
    }
}