using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System.Collections.Concurrent;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    /// <summary>
    /// 由于Client变为多个因此添加了线程安全
    /// <para/>由于实例线程安全因此不必锁定Channel来获取数据只读副本
    /// </summary>
    internal static class ClientDataChannel
    {
        public static ConcurrentBag<ReadOnlyBasePacketRecord> sent_pkts = new();
        public static ConcurrentBag<ReadOnlyBasePacketRecord> recved_pkts = new();

        /// <summary>
        /// KCP.Send后回调
        /// </summary>
        /// <param name="sentPkt"></param>
        public static void PushSentPacket(BasePacket sentPkt)
        {
            sent_pkts.Add(sentPkt.AsReadOnly());
        }

        /// <summary>
        /// 客户端收到服务器回传包的回调
        /// </summary>
        /// <param name="recvedPkt"></param>
        public static void PushReceivedPacket(BasePacket recvedPkt)
        {
            recved_pkts.Add(recvedPkt.AsReadOnly());
        }
    }
}
