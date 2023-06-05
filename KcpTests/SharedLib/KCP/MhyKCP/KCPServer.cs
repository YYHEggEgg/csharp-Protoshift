using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;
using YSFreedom.Common.Util;
using csharp_Protoshift.SpecialUdp;

namespace csharp_Protoshift.MhyKCP
{
    public class KCPServer : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        protected SocketUdpClient udpSock;
        protected bool _Closed = false;
        // string is the ToString() form of IPEndPoint
        protected Dictionary<string, MhyKcpBase> clients;
        protected ConcurrentQueue<IPEndPoint> newConnections;

#pragma warning disable CS8618 // ??????????????????? null ????��???????? null ????????????????? null??
        public class AcceptAsyncReturn
        {
            public MhyKcpBase Connection;
            public IPEndPoint RemoteEndpoint;
        }

        protected KCPServer()
        {
            clients = new Dictionary<string, MhyKcpBase>();
            newConnections = new ConcurrentQueue<IPEndPoint>();
        }
#pragma warning restore CS8618 // ??????????????????? null ????��???????? null ????????????????? null??

        public KCPServer(IPEndPoint ipEp)
        {
            udpSock = new SocketUdpClient(ipEp);
            clients = new Dictionary<string, MhyKcpBase>();
            newConnections = new ConcurrentQueue<IPEndPoint>();

            Task.Run(BackgroundUpdate);
        }

        protected virtual async Task BackgroundUpdate()
        {
            var packet = await udpSock.ReceiveFromAsync();
            string remoteIpString = packet.RemoteEndPoint.ToString();
            if (clients.ContainsKey(remoteIpString))
            {
                try
                {
                    clients[remoteIpString].Input(packet.Buffer);
                }
                catch (Exception)
                {
                    clients.Remove(remoteIpString);
                }
            }
            else
            {
                // Oh boy! A new connection!
                var conn = new MhyKcpBase();
                conn.OutputCallback = new SocketUdpKcpCallback(udpSock, packet.RemoteEndPoint);

                conn.AcceptNonblock();
                try
                {
                    conn.Input(packet.Buffer);

                    clients[remoteIpString] = conn;
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
            MhyKcpBase? conn = null;
            IPEndPoint? ipEp = null;

            while (conn == null)
            {
                
                if (newConnections.TryDequeue(out ipEp))
                {
                    conn = clients[ipEp.ToString()];
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
