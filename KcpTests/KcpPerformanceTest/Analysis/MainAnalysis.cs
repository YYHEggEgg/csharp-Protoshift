using csharp_Protoshift.MhyKCP.Test.App;
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
        /// 客户端发出全部包后调用，在10s后锁定<see cref="ClientDataChannel"/>，并停止Proxy与Server的数据收集并创建副本
        /// </summary>
        public static async Task ClientFinished()
        {
            Log.Info("客户端完成全部发包. 等待 10s...", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            await Task.Delay(10000);
            ClientDataChannel.Closed = true;
            Log.Info("等待完毕。已锁定ClientDataChannel.", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            #region 获取记录
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
            #endregion
            await HandleData();
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

        private static async Task HandleData()
        {
            #region 处理数据
#pragma warning disable CS8604 // 引用类型参数可能为 null。
            PacketRecordCollection client_send_collection = new(client_sent);
#if !CONNECT_SERVERONLY
            PacketRecordCollection proxy_client_recv_collection = new(proxy_client_recved);
            PacketRecordCollection proxy_client_send_collection = new(proxy_client_sent);
#endif
            PacketRecordCollection server_recv_collection = new(server_recved);
            PacketRecordCollection server_send_collection = new(server_sent);
#if !CONNECT_SERVERONLY
            PacketRecordCollection proxy_server_recv_collection = new(proxy_server_recved);
            PacketRecordCollection proxy_server_send_collection = new(proxy_server_sent);
#endif
            PacketRecordCollection client_recv_collection = new(client_recved);
#pragma warning restore CS8604 // 引用类型参数可能为 null。
            Log.Info("成功加载了全部数据。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #endregion
            #region 算法处理 - 丢包数据
            PacketLossResult
                CsLoss = PacketRecordCollection.PacketLoss(client_send_collection, server_recv_collection),
                ScLoss = PacketRecordCollection.PacketLoss(server_send_collection, client_recv_collection)
#if !CONNECT_SERVERONLY
                , CpLoss = PacketRecordCollection.PacketLoss(client_send_collection, proxy_client_recv_collection),
                PsLoss = PacketRecordCollection.PacketLoss(proxy_client_send_collection, server_recv_collection),
                SpLoss = PacketRecordCollection.PacketLoss(server_send_collection, proxy_server_recv_collection),
                PcLoss = PacketRecordCollection.PacketLoss(proxy_server_send_collection, client_recv_collection),

                Cs_proxy_failed = PacketRecordCollection.PacketLoss(proxy_client_recv_collection, proxy_client_send_collection),
                Sc_proxy_failed = PacketRecordCollection.PacketLoss(proxy_server_recv_collection, proxy_server_send_collection)
#endif
                ;
            #endregion
            Log.Info("丢包信息处理完毕。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #region 算法处理 - 延迟数据
            PacketDelayResult
                CsDelay = PacketRecordCollection.PacketDelay(client_send_collection, server_recv_collection),
                ScDelay = PacketRecordCollection.PacketDelay(server_send_collection, client_recv_collection)
#if !CONNECT_SERVERONLY
                , CpDelay = PacketRecordCollection.PacketDelay(client_send_collection, proxy_client_recv_collection),
                PsDelay = PacketRecordCollection.PacketDelay(proxy_client_send_collection, server_recv_collection),
                SpDelay = PacketRecordCollection.PacketDelay(server_send_collection, proxy_server_recv_collection),
                PcDelay = PacketRecordCollection.PacketDelay(proxy_server_send_collection, client_recv_collection),

                Cs_proxy_delay = PacketRecordCollection.PacketDelay(proxy_client_recv_collection, proxy_client_send_collection),
                Sc_proxy_delay = PacketRecordCollection.PacketDelay(proxy_server_recv_collection, proxy_server_send_collection)
#endif
                ;
            #endregion
            Log.Info("延迟信息处理完毕。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #region 生成报告
            Log.Info("正在生成分析报告...", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            StringBuilder result = new();
            result.AppendLine($"---------- KCP / mihomonet 性能测试报告 ----------");
            result.AppendLine();
            result.AppendLine($"测试基本信息：");
#if CONNECT_SERVERONLY
            result.AppendLine($"- 启用代理：否");
#else
            result.AppendLine($"- 启用代理：是");
#endif
            result.AppendLine($"- 发包数：{Constants.packet_repeat_time}");
            result.AppendLine($"- 最大发包大小：{Constants.each_packet_size} bytes");
            result.AppendLine($"- 是否随机包大小：{Constants.random_packet_size}");
            result.AppendLine();
            result.AppendLine($"网络汇总分析：");
            result.AppendLine($"Client -> Server: 平均延迟:{CsDelay.average_packetDelay}, 总丢包:{CsLoss.packetLoss}");
            result.AppendLine($"Server -> Client: 平均延迟:{ScDelay.average_packetDelay}, 总丢包:{ScLoss.packetLoss}");
#if !CONNECT_SERVERONLY
            result.AppendLine();
            result.AppendLine($"Client -> Proxy: 平均延迟:{CpDelay.average_packetDelay}, 总丢包:{CpLoss.packetLoss}");
            result.AppendLine($"Proxy -> Server: 平均延迟:{PsDelay.average_packetDelay}, 总丢包:{PsLoss.packetLoss}");
            result.AppendLine($"Server -> Proxy: 平均延迟:{SpDelay.average_packetDelay}, 总丢包:{SpLoss.packetLoss}");
            result.AppendLine($"Proxy -> Client: 平均延迟:{PcDelay.average_packetDelay}, 总丢包:{PcLoss.packetLoss}");
            result.AppendLine();
            result.AppendLine($"Proxy_OnClientPacket: 平均处理时间:{Cs_proxy_delay.average_packetDelay}, 异常率:{Cs_proxy_failed.packetLoss}");
            result.AppendLine($"Proxy_OnServerPacket: 平均处理时间:{Sc_proxy_delay.average_packetDelay}, 异常率:{Sc_proxy_failed.packetLoss}");
#endif
            result.AppendLine();
            result.AppendLine();
            result.AppendLine($"TODO: 输出异常的 ack list");

            string logPath = $"{Environment.CurrentDirectory}/logs/{DateTime.Now:yyyy-MM-dd_HH:mm:ss}.packet.log";
            await File.WriteAllTextAsync(logPath, result.ToString());
            Log.Info($"日志已输出到路径 {logPath}.", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #endregion
        }
    }
}
