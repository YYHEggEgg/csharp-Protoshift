using csharp_Protoshift.MhyKCP.Test.Protocol;
using System.Collections.Concurrent;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    /// <summary>
    /// 由于Server数据Push时机不定因此需要线程安全
    /// <para/>由于实例线程安全因此不必锁定Channel来获取数据只读副本
    /// </summary>
    internal static class ServerDataChannel
    {
        public static ConcurrentBag<ReadOnlyBasePacketRecord> sent_pkts = new();
        public static ConcurrentBag<ReadOnlyBasePacketRecord> recved_pkts = new();

        /// <summary>
        /// 服务器收到客户端请求包的回调
        /// </summary>
        /// <param name="recvedPkt"></param>
        public static void PushReceivedPacket(BasePacket recvedPkt)
        {
            recved_pkts.Add(recvedPkt.AsReadOnly());
        }

        /// <summary>
        /// 服务器发出ack回传包后回调
        /// </summary>
        /// <param name="sentPkt"></param>
        public static void PushSentPacket(BasePacket sentPkt)
        {
            sent_pkts.Add(sentPkt.AsReadOnly());
        }
    }
}
