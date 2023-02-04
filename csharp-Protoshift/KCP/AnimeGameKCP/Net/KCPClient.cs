using System.Net;
using System.Net.Sockets;
using YSFreedom.Common.Net;

namespace csharp_Protoshift.AnimeGameKCP
{
    public class KCPClient : IDisposable
    {
        public bool Closed { get { return _Closed; } }

        private UdpClient udpSock;
        private bool _Closed = false;
        private KCP server;
        private IPEndPoint remoteAddress;

        public KCPClient(IPEndPoint ipEp)
        {
            udpSock = new UdpClient();
            //udpSock = new();
            udpSock.Connect(ipEp);
            server = new KCP(asClient: true);

            remoteAddress = ipEp;

            server.Timeout = 10000;
            server.Output = 
                data => 
                { 
                    return udpSock.Send(data, data.Length); 
                };

            Task.Run(BackgroundUpdate);
        }

        private async Task BackgroundUpdate()
        {
            IPEndPoint fromip = new(IPAddress.Loopback, 0);
            var packet = udpSock.Receive(ref fromip);
            try
            {
                if (fromip.ToString() == remoteAddress.ToString())
                {
                    Console.WriteLine($"Client packet, buf = {Convert.ToHexString(packet)}");
                    server.Input(packet);
                }
                else
                {
                    Console.WriteLine($"Bad packet sent to client: {fromip}, buf = {Convert.ToHexString(packet)}");
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
            await server.ConnectAsync();
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
    }
}
