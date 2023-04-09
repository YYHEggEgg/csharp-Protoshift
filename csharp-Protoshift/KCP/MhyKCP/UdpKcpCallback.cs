using csharp_Protoshift.Obsoleted.SpecialUdp;
using csharp_Protoshift.SpecialUdp;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.Sockets.Kcp;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP
{
    public class UdpKcpCallback : IKcpCallback
    {
        private readonly UdpClient udpSock;
        private readonly IPEndPoint? ipEp;

        public UdpKcpCallback(UdpClient udpSock, IPEndPoint? ipEp)
        {
            this.udpSock = udpSock;
            this.ipEp = ipEp;
        }

        public void Output(IMemoryOwner<byte> buffer, int avalidLength)
        {
            if (ipEp != null) udpSock.Send(buffer.Memory.Span, ipEp);
            else udpSock.Send(buffer.Memory.Span);
        }
    }

    public class ConcurrentUdpKcpCallback : IKcpCallback
    {
        private readonly ConcurrentUdpClient udpSock;
        private readonly IPEndPoint? ipEp;

        public ConcurrentUdpKcpCallback(ConcurrentUdpClient udpSock, IPEndPoint? ipEp = null)
        {
            this.udpSock = udpSock;
            this.ipEp = ipEp;
        }

        public async void Output(IMemoryOwner<byte> buffer, int avalidLength)
        {
            await udpSock.SendAsync(buffer.Memory, ipEp);
        }
    }

    public class SocketUdpKcpCallback : IKcpCallback
    {
        private readonly SocketUdpClient udpSock;
        private readonly IPEndPoint? ipEp;

        public SocketUdpKcpCallback(SocketUdpClient udpSock, IPEndPoint? ipEp = null)
        {
            this.udpSock = udpSock;
            this.ipEp = ipEp;
        }

        public async void Output(IMemoryOwner<byte> buffer, int avalidLength)
        {
            await udpSock.SendToAsync(buffer.Memory, ipEp);
        }
    }
}
