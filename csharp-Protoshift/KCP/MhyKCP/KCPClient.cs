using System.Net;
using YYHEggEgg.Logger;
using csharp_Protoshift.SpecialUdp;

namespace csharp_Protoshift.MhyKCP
{
    public class KCPClient : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        protected SocketUdpClient udpSock;
        private bool _Closed = false;
        protected MhyKcpBase server;
        protected IPEndPoint remoteAddress;

        protected SingleThreadAssert _recvlock = new($"{nameof(KCPClient)}_{nameof(Receive)}"), 
            _updatelock = new($"{nameof(KCPClient)}_{nameof(BackgroundUpdate)}");

        public KCPClient(IPEndPoint ipEp)
        {
            udpSock = new SocketUdpClient();
            //udpSock = new();
            udpSock.Connect(ipEp);
            server = new MhyKcpBase();

            remoteAddress = ipEp;

            server.Timeout = 10000;
            server.OutputCallback = new SocketUdpKcpCallback(udpSock);

            Task.Run(BackgroundUpdate);
        }

        /// <summary>
        /// Invoke when server requested disconnect. uints are Conv/Token.
        /// </summary>
        public event Action<uint, uint, uint>? StartDisconnected;

        public MhyKcpBase.ConnectionState State { get => server.State; }

        protected virtual async Task BackgroundUpdate()
        {
            _updatelock.Enter();
            while (!_Closed)
            {
                var packet = await udpSock.ReceiveFromAsync();
                try
                {
                    if (packet.RemoteEndPoint.ToString() == remoteAddress.ToString())
                    {
                        // Log.Dbug($"Client packet (ip {remoteAddress}), buf = {Convert.ToHexString(packet)}", nameof(KCPClient));
                        server.Input(packet.Buffer);
                    }
                    else
                    {
                        // Log.Warn($"Bad packet sent to client: {fromip}, buf = {Convert.ToHexString(packet)}");
                    }
                    if (server.State == MhyKcpBase.ConnectionState.CLOSED)
                    {
                        if (packet.Buffer.Length == 20)
                        {
                            try
                            {
                                Handshake disconnpkt = new();
                                disconnpkt.Decode(packet.Buffer);
                                StartDisconnected?.Invoke(disconnpkt.Conv, disconnpkt.Token, disconnpkt.Data);
                            }
                            catch {  }
                        }
                    }
                    if (server.State != MhyKcpBase.ConnectionState.CONNECTED)
                    {
                        _Closed = true;
                        server.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Log.Erro($"Update fail: {ex}", nameof(KCPClient));
                    _Closed = true;
                    server.Dispose();
                }
            }
            _updatelock.Exit();
        }

        public async Task ConnectAsync()
        {
            server.AcceptNonblock();
            await server.ConnectAsync();
        }

        public async Task SendAsync(byte[] data)
        {
            await server.SendAsync(data);
        }

        public void Send(ReadOnlySpan<byte> data)
        {
            server.Send(data);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>null if disconnected</returns>
        public async Task<byte[]?> ReceiveAsync()
        {
            _recvlock.Enter();
            try
            {
                return await server.ReceiveAsync();
            }
            catch
            {
                if (server.State == MhyKcpBase.ConnectionState.CONNECTED) throw;
                else return null;
            }
            finally
            {
                _recvlock.Exit();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>null if disconnected</returns>
        public byte[]? Receive()
        {
            _recvlock.Enter();
            try
            {
                return server.Receive();
            }
            catch
            {
                if (server.State == MhyKcpBase.ConnectionState.CONNECTED) throw;
                else return null;
            }
            finally
            {
                _recvlock.Exit();
            }
        }

        public void Disconnect(uint conv = 0, uint token = 0, uint data = 1)
        {
            server.Disconnect(conv, token, data);
        }
    }
}
