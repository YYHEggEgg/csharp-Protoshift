using csharp_Protoshift.MhyKCP.Test.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal static class MainAnalysis
    {
        /// <summary>
        /// 客户端发出全部包后调用，立即锁定<see cref="ClientDataChannel"/>，在10s后停止Proxy与Server的数据收集并创建副本
        /// </summary>
        public static async Task ClientFinished()
        {
            ClientDataChannel.Closed = true;
            Log.Info("客户端完成全部发包，已锁定 ClientDataChannel. 等待 10s...", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            await Task.Delay(10000);
            client_sent = ClientDataChannel.sent_pkts.AsReadOnly();
            Log.Info($"已从Channel获取记录，Client共发出了 {client_sent.Count} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
#if !CONNECT_SERVERONLY
            proxy_client_recved = ProxyDataChannel.proxy_recved_client_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Proxy共收到了来自Client的 {proxy_client_recved.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            proxy_client_sent = ProxyDataChannel.proxy_sent_client_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Proxy共转发了来自Client的 {proxy_client_sent.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
#endif
            server_recved = ServerDataChannel.recved_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Server共收到了 {server_recved.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            server_sent = ServerDataChannel.sent_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Server共回传了 {server_sent.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
#if !CONNECT_SERVERONLY
            proxy_server_recved = ProxyDataChannel.proxy_recved_server_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Proxy共收到了来自Server的 {proxy_server_recved.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            proxy_server_sent = ProxyDataChannel.proxy_sent_server_pkts.ToArray();
            Log.Info($"已从Channel获取记录，Proxy共转发了来自Server的 {proxy_server_sent.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
#endif
            client_recved = ClientDataChannel.recved_pkts.AsReadOnly();
            Log.Info($"已从Channel获取记录，Client共收到了 {client_recved.Count} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");


        }

        static ReadOnlyCollection<ReadOnlyBasePacketRecord>?
            client_sent, client_recved;
        static ReadOnlyBasePacketRecord[]?
#if CONNECT_SERVERONLY
            server_recved, server_sent;
#else
            proxy_client_recved, proxy_client_sent,
            server_recved, server_sent, 
            proxy_server_recved, proxy_server_sent;
#endif
    }
}
