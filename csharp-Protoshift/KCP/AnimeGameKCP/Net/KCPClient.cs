using System.Net;
using System.Net.Sockets;
using YSFreedom.Common.Net;

namespace csharp_Protoshift.AnimeGameKCP
{
    public class KCPClient : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        protected UdpClient udpSock;
        private bool _Closed = false;
        protected KCP server;
        protected IPEndPoint remoteAddress;

        public KCPClient(IPEndPoint ipEp)
        {
            udpSock = new UdpClient();
            //udpSock = new();
            udpSock.Connect(ipEp);
            server = new KCP();

            remoteAddress = ipEp;

            server.Timeout = 10000;
            server.Output = 
                data => 
                { 
                    return udpSock.Send(data, data.Length); 
                };

            Task.Run(BackgroundUpdate);
        }

        protected async Task BackgroundUpdate()
        {
            IPEndPoint fromip = new(IPAddress.Loopback, 0);
            var packet = udpSock.Receive(ref fromip);
            try
            {
                if (fromip.ToString() == remoteAddress.ToString())
                {
                    Log.Dbug($"Client packet (ip {remoteAddress}), buf = {Convert.ToHexString(packet)}", "KCPClient");
                    server.Input(packet);
                }
                else
                {
                    Log.Warn($"Bad packet sent to client: {fromip}, buf = {Convert.ToHexString(packet)}");
                }
            }
            catch (Exception ex)
            {
                Log.Erro($"Update fail: {ex}");
                _Closed = true;
                server.Dispose();
            }

            if (!_Closed) await Task.Run(BackgroundUpdate);
        }

        public async Task ConnectAsync()
        {
            server.AcceptNonblock();
            await server.ConnectAsync();
#pragma warning disable CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
            Task.Run(server.BackgroundUpdate);
#pragma warning restore CS4014 // 由于此调用不会等待，因此在调用完成前将继续执行当前方法
        }

        public async Task SendAsync(byte[] data)
        {
            await server.SendAsync(data);
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

        public async Task<byte[]> ReceiveAsync()
        {
            return await server.ReceiveAsync();
        }
    }
}
