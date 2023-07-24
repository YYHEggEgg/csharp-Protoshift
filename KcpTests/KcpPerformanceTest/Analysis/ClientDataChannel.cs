using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.MhyKCP.Test.Protocol;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal static class ClientDataChannel
    {
        public static List<ReadOnlyBasePacketRecord> sent_pkts = new(Constants.packet_repeat_time);
        public static List<ReadOnlyBasePacketRecord> recved_pkts = new(Constants.packet_repeat_time);
        // Channel是否已关闭 在Analysis要获取数据的时候要先关闭数据采集
        public static bool Closed;

        /// <summary>
        /// KCP.Send后回调
        /// </summary>
        /// <param name="sentPkt"></param>
        public static void PushSentPacket(BasePacket sentPkt)
        {
            if (!Closed) sent_pkts.Add(sentPkt.AsReadOnly());
        }

        /// <summary>
        /// 客户端收到服务器回传包的回调
        /// </summary>
        /// <param name="recvedPkt"></param>
        public static void PushReceivedPacket(BasePacket recvedPkt)
        {
            if (!Closed) recved_pkts.Add(recvedPkt.AsReadOnly());
        }
    }
}
