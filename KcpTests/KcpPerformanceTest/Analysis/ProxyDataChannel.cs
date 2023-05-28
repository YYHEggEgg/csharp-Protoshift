using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    /// <summary>
    /// 由于代理不保证顺序调用handler，因此本实例线程安全
    /// </summary>
    internal static class ProxyDataChannel
    {
        // 代理收到的客户端->服务器的包，即客户端->代理
        public static ConcurrentBag<ReadOnlyBasePacketRecord> proxy_recved_client_pkts = new(Constants.packet_repeat_time);
        // 代理发出的客户端->服务器的包，即代理->服务器
        public static ConcurrentBag<ReadOnlyBasePacketRecord> proxy_sent_client_pkts = new(Constants.packet_repeat_time);
        // 代理收到的服务器->客户端的包，即服务器->代理
        public static ConcurrentBag<ReadOnlyBasePacketRecord> proxy_recved_server_pkts = new(Constants.packet_repeat_time);
        // 代理发出的服务器->客户端的包，即代理->客户端
        public static ConcurrentBag<ReadOnlyBasePacketRecord> proxy_sent_server_pkts = new(Constants.packet_repeat_time);

        /// <summary>
        /// 代理收到客户端->服务器包的回调
        /// </summary>
        /// <param name="recvedPkt"></param>
        public static void PushReceivedClientPacket(BasePacket recvedPkt)
        {
            proxy_recved_client_pkts.Add(recvedPkt.AsReadOnly());
        }

        /// <summary>
        /// 代理处理完毕客户端->服务器包的回调
        /// </summary>
        /// <param name="sentPkt"></param>
        public static void PushSentClientPacket(BasePacket sentPkt)
        {
            proxy_sent_client_pkts.Add(sentPkt.AsReadOnly());
        }

        /// <summary>
        /// 代理收到服务器->客户端包的回调
        /// </summary>
        /// <param name="recvedPkt"></param>
        public static void PushReceivedServerPacket(BasePacket recvedPkt)
        {
            proxy_recved_server_pkts.Add(recvedPkt.AsReadOnly());
        }

        /// <summary>
        /// 代理处理完毕服务器->客户端包的回调
        /// </summary>
        /// <param name="sentPkt"></param>
        public static void PushSentServerPacket(BasePacket sentPkt)
        {
            proxy_sent_server_pkts.Add(sentPkt.AsReadOnly());
        }
    }
}
