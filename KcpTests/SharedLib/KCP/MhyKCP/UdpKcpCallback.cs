#define KCP_PACKET_AUDIT

using csharp_Protoshift.MhyKCP;
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
    [Obsolete]
    public class UdpKcpCallback : IKcpCallback
    {
        private readonly UdpClient udpSock;
        private readonly IPEndPoint? ipEp;

        public UdpKcpCallback(UdpClient udpSock, IPEndPoint? ipEp)
        {
            this.udpSock = udpSock;
            this.ipEp = ipEp;
        }

        public void Output(IMemoryOwner<byte> buffer, int avalidLength, bool isKcpPacket = true)
        {
            if (ipEp != null) udpSock.Send(buffer.Memory.Slice(0, avalidLength).Span, ipEp);
            else udpSock.Send(buffer.Memory.Slice(0, avalidLength).Span);
            buffer.Dispose();
        }
    }

    [Obsolete]
    public class ConcurrentUdpKcpCallback : IKcpCallback
    {
        private readonly ConcurrentUdpClient udpSock;
        private readonly IPEndPoint? ipEp;

        public ConcurrentUdpKcpCallback(ConcurrentUdpClient udpSock, IPEndPoint? ipEp = null)
        {
            this.udpSock = udpSock;
            this.ipEp = ipEp;
        }

        public async void Output(IMemoryOwner<byte> buffer, int avalidLength, bool isKcpPacket = true)
        {
            await udpSock.SendAsync(buffer.Memory.Slice(0, avalidLength), ipEp);
            buffer.Dispose();
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

        public void Output(IMemoryOwner<byte> buffer, int avalidLength, bool isKcpPacket = true)
        {
            DateTime req_SendTime = DateTime.Now;
            udpSock.SendToAsync(buffer.Memory.Slice(0, avalidLength), ipEp).Wait();
            if (isKcpPacket) 
                KcpPacketAudit.PushPacket(req_SendTime, buffer.Memory, avalidLength);
            // buffer.Dispose();
        }
    }
}
