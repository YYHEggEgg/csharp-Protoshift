using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using YSFreedom.Common.Util;

namespace YSFreedom.Common.Net
{
    public class KCPServer : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        private UdpClient udpSock;
        private bool _Closed = false;
        private Dictionary<IPEndPoint, KCP> clients;
        private ConcurrentQueue<IPEndPoint> newConnections;

        public class AcceptAsyncReturn
        {
            public KCP Connection;
            public IPEndPoint RemoteEndpoint;
        }

        public KCPServer(IPEndPoint ipEp)
        {
            udpSock = new UdpClient(ipEp);
            clients = new Dictionary<IPEndPoint, KCP>();
            newConnections = new ConcurrentQueue<IPEndPoint>();

            Task.Run(BackgroundUpdate);
        }

        private async Task BackgroundUpdate()
        {
            var packet = await udpSock.ReceiveAsync();
            if (clients.ContainsKey(packet.RemoteEndPoint))
            {
                try
                {
                    clients[packet.RemoteEndPoint].Input(packet.Buffer);
                }
                catch (Exception)
                {
                    clients.Remove(packet.RemoteEndPoint);
                }
            }
            else
            {
                // Oh boy! A new connection!
                var conn = new KCP();
                conn.Output = (data) => { return udpSock.Send(data, data.Length, packet.RemoteEndPoint); };

                conn.AcceptNonblock();
                try
                {
                    conn.Input(packet.Buffer);

                    clients[packet.RemoteEndPoint] = conn;
                    newConnections.Enqueue(packet.RemoteEndPoint);
                } catch (Exception)
                {
                    conn.Dispose();
                }              
            }

            if (!_Closed) await Task.Run(BackgroundUpdate);
        }

        public async Task<AcceptAsyncReturn> AcceptAsync()
        {
            KCP conn = null;
            IPEndPoint ipEp = null;

            while (conn == null)
            {
                
                if (newConnections.TryDequeue(out ipEp))
                {
                    conn = clients[ipEp];
                }
                if (conn == null) await Task.Delay(10);
            }

            await conn.AcceptAsync();
            return new AcceptAsyncReturn { Connection = conn, RemoteEndpoint = ipEp };
        }

        public void Close()
        {
            _Closed = true;
            udpSock.Close();
        }

        public void Dispose()
        {
            _Closed = true;
            udpSock.Dispose();
        }
    }
}
