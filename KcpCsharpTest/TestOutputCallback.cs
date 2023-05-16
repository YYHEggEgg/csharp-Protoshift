using System.Buffers;
using System.Net.Sockets.Kcp;

namespace KcpCsharpTest
{
    internal class TestOutputCallback : IKcpCallback
    {
        // 跳过网络层直接回调指定 Kcp.Input
        public Kcp<KcpSegment>? sendToKcpInstance;
        private static Random ran = new();

        public void Output(IMemoryOwner<byte> buffer, int avalidLength, bool isKcpPacket = true)
        {
            if (isKcpPacket)
                KcpPacketAudit.PushPacket(DateTime.Now, buffer.Memory, avalidLength);
            if (ran.Next(0, 99) >= Constants.packet_loss_percent)
                sendToKcpInstance?.Input(buffer.Memory.Slice(0, avalidLength).Span);
            // buffer.Dispose();
        }
    }
}