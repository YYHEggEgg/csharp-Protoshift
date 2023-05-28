using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal static class ClientDataChannel
    {
        public static List<ReadOnlyBasePacketRecord> sent_pkts = new(Constants.packet_repeat_time);
        public static List<ReadOnlyBasePacketRecord> recved_pkts = new(Constants.packet_repeat_time);

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
