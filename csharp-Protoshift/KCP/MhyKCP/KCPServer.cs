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

        protected ConcurrentUdpClient udpSock;
        protected bool _Closed = false;
        protected Dictionary<IPEndPoint, MhyKcpBase> clients;
        protected ConcurrentQueue<IPEndPoint> newConnections;

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public class AcceptAsyncReturn
        {
            public MhyKcpBase Connection;
            public IPEndPoint RemoteEndpoint;
        }

        protected KCPServer()
        {
            clients = new Dictionary<IPEndPoint, MhyKcpBase>();
            newConnections = new ConcurrentQueue<IPEndPoint>();
        }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

        public KCPServer(IPEndPoint ipEp)
        {
            udpSock = new ConcurrentUdpClient(ipEp);
            clients = new Dictionary<IPEndPoint, MhyKcpBase>();
            newConnections = new ConcurrentQueue<IPEndPoint>();

            Task.Run(BackgroundUpdate);
        }

        protected virtual async Task BackgroundUpdate()
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
                var conn = new MhyKcpBase();
                conn.OutputCallback = new ConcurrentUdpKcpCallback(udpSock, packet.RemoteEndPoint);

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
            MhyKcpBase? conn = null;
            IPEndPoint? ipEp = null;

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
