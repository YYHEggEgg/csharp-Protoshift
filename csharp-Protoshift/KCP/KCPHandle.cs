using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets.Kcp.Simple;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace csharp_Protoshift
{
    public class KCPHandle
    {
        SimpleKcpClient client;

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="port">The port binding KCP to.</param>
        /// <param name="ReceiveKCPPacketNotify">The action to invoke when receiving packet. If you don't want to receive packets from this instance, use null.</param>
        /// <param name="refreshdelay"></param>
        /// <param name="endPoint">IP endpoint, will be 0.0.0.0 if not provided.</param>
        public KCPHandle(int port, Action<byte[]>? ReceiveKCPPacketNotify,
            int refreshdelay = 10, IPEndPoint endPoint = null)
        {
            if (endPoint == null) endPoint = new(IPAddress.Parse("0.0.0.0"), port);

            client = new(port, endPoint);
            client.kcp.TraceListener = new ConsoleTraceListener();
            client.kcp.NoDelay(1, 10, 2, 1);//fast
            Task.Run(async () =>
            {
                while (true)
                {
                    client.kcp.Update(DateTimeOffset.UtcNow);
                    await Task.Delay(refreshdelay);
                }
            });

            if (ReceiveKCPPacketNotify != null) StartRecv(ReceiveKCPPacketNotify);
        }
        
        async void StartRecv(Action<byte[]> ReceiveKCPPacketNotify)
        {
            while (true)
            {
                var res = await client.ReceiveAsync();
                ReceiveKCPPacketNotify(res);
            }
        }

        public void SendPacket(byte[] message)
        {
            client.SendAsync(message, message.Length);
        }
    }
}
