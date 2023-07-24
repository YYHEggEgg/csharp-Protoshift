using csharp_Protoshift.SpecialUdp;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets.Kcp;

namespace csharp_Protoshift.MhyKCP
{
    public class KCPServer : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        protected SocketUdpClient udpSock;
        protected bool _Closed = false;
        // string is the ToString() form of IPEndPoint
        protected ConcurrentDictionary<string, MhyKcpBase> connecting_clients;
        protected ConcurrentDictionary<uint, MhyKcpBase> connected_clients;
        protected ConcurrentQueue<AcceptAsyncReturn> newConnections;

        protected SingleThreadAssert _updatelock = new(nameof(KCPServer));

#pragma warning disable CS8618
        public class AcceptAsyncReturn
        {
            public MhyKcpBase Connection;
            public IPEndPoint RemoteEndpoint;
        }

        protected KCPServer()
        {
            connecting_clients = new();
            connected_clients = new();
            newConnections = new();
        }
#pragma warning restore CS8618

        public KCPServer(IPEndPoint ipEp)
        {
            udpSock = new SocketUdpClient(ipEp);
            connecting_clients = new();
            connected_clients = new();
            newConnections = new();

            Task.Run(BackgroundUpdate);
        }

        protected virtual async Task BackgroundUpdate()
        {
            _updatelock.Enter();
            while (!_Closed)
            {
                var packet = await udpSock.ReceiveFromAsync();
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
                            connected_conn.Input(packet.Buffer);
                        }
                        catch
                        {
                            if (connected_conn.State != MhyKcpBase.ConnectionState.CONNECTED)
                                connected_clients.TryRemove(connected_conn.Conv, out _);
                        }
                        continue;
                    }
                    // ip dispatch
                    string remoteIpString = packet.RemoteEndPoint.ToString();
                    MhyKcpBase conn;
                    if (!connecting_clients.TryGetValue(remoteIpString, out var _outconn))
                    {
                        // Oh boy! A new connection!
                        conn = new MhyKcpBase();
                        conn.OutputCallback = new SocketUdpKcpCallback(udpSock, packet.RemoteEndPoint);
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
                    else conn = _outconn;
                    try
                    {
                        conn.Input(packet.Buffer);
                        if (conn.State == MhyKcpBase.ConnectionState.CONNECTED)
                        {
                            newConnections.Enqueue(new AcceptAsyncReturn { Connection = conn, RemoteEndpoint = packet.RemoteEndPoint });
                        }
                    }
                    catch (Exception) { }
                }
                else if (packet.Buffer.Length >= KcpConst.IKCP_OVERHEAD) // conv dispatch
                {
                    var conv = BinaryPrimitives.ReadUInt32LittleEndian(packet.Buffer);
                    if (connected_clients.TryGetValue(conv, out var conn))
                    {
                        try
                        {
                            conn.Input(packet.Buffer);
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

        public AcceptAsyncReturn Accept()
        {
            while (true)
            {
                if (newConnections.TryDequeue(out var res))
                {
                    MhyKcpBase conn = res.Connection;
                    connected_clients.TryAdd(conn.Conv, conn);
                    return res;
                }
                Thread.Sleep(50);
            }
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
