using System.Net;
using System.Net.Sockets;
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
        public event Action<uint, uint>? StartDisconnected;

        public MhyKcpBase.ConnectionState State { get => server.State; }

        protected virtual async Task BackgroundUpdate()
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
                if (server.State != MhyKcpBase.ConnectionState.CONNECTED)
                {
                    StartDisconnected?.Invoke(server.Conv, server.Token);
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

            if (!_Closed) await Task.Run(BackgroundUpdate);
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
            try
            {
                return await server.ReceiveAsync();
            }
            catch
            {
                if (server.State != MhyKcpBase.ConnectionState.CONNECTED)
                {
                    StartDisconnected?.Invoke(server.Conv, server.Token);
                    return null;
                }
                else throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>null if disconnected</returns>
        public byte[]? Receive()
        {
            try
            {
                return server.Receive();
            }
            catch
            {
                if (server.State != MhyKcpBase.ConnectionState.CONNECTED)
                {
                    StartDisconnected?.Invoke(server.Conv, server.Token);
                    return null;
                }
                else throw;
            }
        }

        public void Disconnect(uint conv = 0, uint token = 0, uint data = 1)
        {
            server.Disconnect(conv, token, data);
        }
    }
}
