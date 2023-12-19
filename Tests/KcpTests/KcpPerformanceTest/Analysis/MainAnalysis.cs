using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using OfficeOpenXml;
using System.Collections.ObjectModel;
using System.Text;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal static class MainAnalysis
    {
        public static bool TestsFinished { get; private set; } = false;
        public static int ProgramExitCode { get; private set; } = 0;

        /// <summary>
        /// 客户端发出全部包后调用，在10s后锁定<see cref="ClientDataChannel"/>，并停止Proxy与Server的数据收集并创建副本
        /// </summary>
        public static async Task ClientFinished()
        {
            Log.Info("客户端完成全部发包. 等待 10s...", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            await Task.Delay(10000);
            #region 获取记录 
            try
            {
                client_sent = ClientDataChannel.sent_pkts.ToArray();
                Log.Info($"已从Channel获取记录，Client共发出了 {client_sent.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
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
                client_recved = ClientDataChannel.recved_pkts.ToArray();
                Log.Info($"已从Channel获取记录，Client共收到了 {client_recved.Length} 个包", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
            }
            catch (Exception ex)
            {
                Log.Erro($"从Channel获取发包记录失败：{ex}", $"{nameof(MainAnalysis)}_{nameof(ClientFinished)}");
                return;
            }
            #endregion
            await HandleData();
            TestsFinished = true;
        }

        static ReadOnlyBasePacketRecord[]?
            client_sent, client_recved,
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
            PacketRecordCollection client_send_collection, proxy_client_recv_collection,
                proxy_client_send_collection, server_recv_collection, server_send_collection,
                proxy_server_recv_collection, proxy_server_send_collection, client_recv_collection;
            try
            {
#pragma warning disable CS8604 // 引用类型参数可能为 null。
                client_send_collection = new(client_sent);
#if !CONNECT_SERVERONLY
                proxy_client_recv_collection = new(proxy_client_recved);
                proxy_client_send_collection = new(proxy_client_sent);
#endif
                server_recv_collection = new(server_recved);
                server_send_collection = new(server_sent);
#if !CONNECT_SERVERONLY
                proxy_server_recv_collection = new(proxy_server_recved);
                proxy_server_send_collection = new(proxy_server_sent);
#endif
                client_recv_collection = new(client_recved);
            }
            catch (Exception ex)
            {
                Log.Erro($"数据处理失败：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                return;
            }
#pragma warning restore CS8604 // 引用类型参数可能为 null。
            Log.Info("成功加载了全部数据。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #endregion
            #region 算法处理 - 丢包数据
            PacketLossResult
                CsLoss, ScLoss
#if !CONNECT_SERVERONLY
                , CpLoss, PsLoss, SpLoss, PcLoss, Cs_proxy_failed, Sc_proxy_failed
#endif
                ;
            try
            {
                CsLoss = PacketRecordCollection.PacketLoss(client_send_collection, server_recv_collection);
                ScLoss = PacketRecordCollection.PacketLoss(server_send_collection, client_recv_collection);
#if !CONNECT_SERVERONLY
                CpLoss = PacketRecordCollection.PacketLoss(client_send_collection, proxy_client_recv_collection);
                PsLoss = PacketRecordCollection.PacketLoss(proxy_client_send_collection, server_recv_collection);
                SpLoss = PacketRecordCollection.PacketLoss(server_send_collection, proxy_server_recv_collection);
                PcLoss = PacketRecordCollection.PacketLoss(proxy_server_send_collection, client_recv_collection);

                Cs_proxy_failed = PacketRecordCollection.PacketLoss(proxy_client_recv_collection, proxy_client_send_collection);
                Sc_proxy_failed = PacketRecordCollection.PacketLoss(proxy_server_recv_collection, proxy_server_send_collection);
#endif
            }
            catch (Exception ex)
            {
                Log.Erro($"丢包数据分析失败：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                return;
            }
            #endregion
            Log.Info("丢包信息处理完毕。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #region 算法处理 - 延迟数据
            PacketDelayResult
                CsDelay, ScDelay
#if !CONNECT_SERVERONLY
                , CpDelay, PsDelay, SpDelay, PcDelay, Cs_proxy_delay, Sc_proxy_delay
#endif
                ;
            try
            {
                CsDelay = PacketRecordCollection.PacketDelay(client_send_collection, server_recv_collection);
                ScDelay = PacketRecordCollection.PacketDelay(server_send_collection, client_recv_collection);
#if !CONNECT_SERVERONLY
                CpDelay = PacketRecordCollection.PacketDelay(client_send_collection, proxy_client_recv_collection);
                PsDelay = PacketRecordCollection.PacketDelay(proxy_client_send_collection, server_recv_collection);
                SpDelay = PacketRecordCollection.PacketDelay(server_send_collection, proxy_server_recv_collection);
                PcDelay = PacketRecordCollection.PacketDelay(proxy_server_send_collection, client_recv_collection);

                Cs_proxy_delay = PacketRecordCollection.PacketDelay(proxy_client_recv_collection, proxy_client_send_collection);
                Sc_proxy_delay = PacketRecordCollection.PacketDelay(proxy_server_recv_collection, proxy_server_send_collection);
#endif
            }
            catch (Exception ex)
            {
                Log.Erro($"延迟信息处理失败：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                return;
            }
            #endregion
            Log.Info("延迟信息处理完毕。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            #region 生成报告
            Log.Info("正在生成分析报告...", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            StringBuilder stringRes = new();
            Output(stringRes, $"---------- KCP / mihomonet 性能测试报告 ----------");
            Output(stringRes);
            Output(stringRes, $"测试基本信息：");
#if CONNECT_SERVERONLY
            Output(stringRes, $"- 启用代理：否");
#else
            Output(stringRes, $"- 启用代理：是");
#endif
            Output(stringRes, $"- 发包数：{Constants.packet_repeat_time}");
            Output(stringRes, $"- 最大发包大小：{Constants.each_packet_size} bytes");
            // Output(stringRes, $"- 是否随机包大小：{Constants.random_packet_size}");
            Output(stringRes);
            #region 网络汇总分析
            Output(stringRes, $"网络汇总分析：");
            OutputCompare(stringRes, CsDelay, CsLoss, "Client", "Server");
            OutputCompare(stringRes, ScDelay, ScLoss, "Server", "Client");
#if !CONNECT_SERVERONLY
            Output(stringRes);
            OutputCompare(stringRes, CpDelay, CpLoss, "Client", "Proxy");
            OutputCompare(stringRes, PsDelay, PsLoss, "Proxy", "Server");
            OutputCompare(stringRes, SpDelay, SpLoss, "Server", "Proxy");
            OutputCompare(stringRes, PcDelay, PcLoss, "Proxy", "Client");
            Output(stringRes);
            Output(stringRes, $"Proxy_OnClientPacket: 平均处理时间:{Cs_proxy_delay.average_packetDelay.Milliseconds}ms ({Cs_proxy_delay.average_packetDelay}), 异常率:{Cs_proxy_failed.packetLoss}");
            Output(stringRes, $"Proxy_OnServerPacket: 平均处理时间:{Sc_proxy_delay.average_packetDelay.Milliseconds}ms ({Sc_proxy_delay.average_packetDelay}), 异常率:{Sc_proxy_failed.packetLoss}");
#endif
            #endregion
            Output(stringRes);
            Output(stringRes);
            #region 丢包情况
            OutputLossAck(stringRes, CsLoss, "Client", "Server");
            Output(stringRes);
            OutputLossAck(stringRes, ScLoss, "Server", "Client");
            Output(stringRes);
#if !CONNECT_SERVERONLY
            OutputLossAck(stringRes, CpLoss, "Client", "Proxy");
            Output(stringRes);
            OutputLossAck(stringRes, PsLoss, "Proxy", "Server");
            Output(stringRes);
            OutputLossAck(stringRes, SpLoss, "Server", "Proxy");
            Output(stringRes);
            OutputLossAck(stringRes, PcLoss, "Proxy", "Client");
            Output(stringRes);
            #region Proxy Handlers
            Output(stringRes, $"Proxy_OnClientHandler 异常情况：");
            Output(stringRes, $"  在处理 {Cs_proxy_failed.lost_ack.Length} 个包时可能发生了异常导致丢包。ack 列表：");
            #region Lost packet
            string acklist = "  [ ";
            foreach (var loss in Cs_proxy_failed.lost_ack)
            {
                acklist += $"{loss}; ";
            }
            acklist += "]";
            if (Cs_proxy_failed.lost_ack.Any())
                ProgramExitCode = 114514;
            Output(stringRes, acklist);
            #endregion
            Output(stringRes);
            Output(stringRes, $"Proxy_OnServerHandler 异常情况：");
            Output(stringRes, $"  在处理 {Sc_proxy_failed.lost_ack.Length} 个包时可能发生了异常导致丢包。ack 列表：");
            #region Lost packet
            acklist = "  [ ";
            foreach (var loss in Sc_proxy_failed.lost_ack)
            {
                acklist += $"{loss}; ";
            }
            acklist += "]";
            if (Sc_proxy_failed.lost_ack.Any())
                ProgramExitCode = 114514;
            Output(stringRes, acklist);
            #endregion
            Output(stringRes);
            #endregion
#endif
            #endregion
            #region 失序包情况
            OutputInvertedPacket(stringRes, CsDelay, "Client", "Server");
            Output(stringRes);
            OutputInvertedPacket(stringRes, ScDelay, "Server", "Client");
            Output(stringRes);
#if !CONNECT_SERVERONLY
            OutputInvertedPacket(stringRes, CpDelay, "Client", "Proxy");
            Output(stringRes);
            OutputInvertedPacket(stringRes, PsDelay, "Proxy", "Server");
            Output(stringRes);
            OutputInvertedPacket(stringRes, SpDelay, "Server", "Proxy");
            Output(stringRes);
            OutputInvertedPacket(stringRes, PcDelay, "Proxy", "Client");
            Output(stringRes);
#endif
            #endregion

            #region 外部文件操作
            string logPath = "logs/latest.packet.log";
            var packetLog = new FileInfo("logs/latest.packet.log");
            if (packetLog.Exists)
            {
                try
                {
                    packetLog.MoveTo($"logs/{packetLog.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.packet.log");
                }
                catch (Exception ex)
                {
                    Log.Warn($"日志重命名操作出现异常：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                    logPath = Util.AddNumberedSuffixToPath(logPath);
                }
            }
            try
            {
                await File.Create(logPath).DisposeAsync();
                await File.WriteAllTextAsync(logPath, stringRes.ToString());
            }
            catch (Exception ex)
            {
                Log.Erro($"对测试日志 {logPath} 的文件操作出现异常：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                return;
            }
            #endregion
            #endregion
            Log.Info($"日志已输出到路径 {logPath}。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            if (Constants.output_packet_delaylog)
            {
                #region 生成包延迟统计表格
                Log.Info("正在生成发包延迟统计表格...", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                IEnumerable<PacketDelayOutputLine>? excel_outputs = null;
                GenerateExportLines(ref excel_outputs, CsDelay, "Client", "Server");
                GenerateExportLines(ref excel_outputs, ScDelay, "Server", "Client");
#if !CONNECT_SERVERONLY
                GenerateExportLines(ref excel_outputs, CpDelay, "Client", "Proxy.HandleClient");
                GenerateExportLines(ref excel_outputs, PsDelay, "Proxy.HandleClient", "Server");
                GenerateExportLines(ref excel_outputs, SpDelay, "Server", "Proxy.HandleServer");
                GenerateExportLines(ref excel_outputs, PcDelay, "Proxy.HandleServer", "Client");
#endif

                string delayPath = "logs/latest.packet.delaylog.xlsx";
                var packetDelay = new FileInfo("logs/latest.packet.delaylog.xlsx");
                if (packetDelay.Exists)
                {
                    try
                    {
                        packetDelay.MoveTo($"logs/{packetDelay.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.packet.delaylog.xlsx");
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"包延迟统计表格重命名操作出现异常：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                        delayPath = Util.AddNumberedSuffixToPath(delayPath);
                    }
                }
                try
                {
                    excel_outputs?.ExportXlsxRecord(delayPath);
                }
                catch (Exception ex)
                {
                    Log.Erro($"对包延迟统计表格 {logPath} 的文件操作出现异常：{ex}", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
                    return;
                }
                #endregion
                Log.Info($"统计信息已输出到 {delayPath}。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            }
            else Log.Info($"由于配置，包延迟统计信息并未输出。", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            if (Constants.running_on_github_actions)
            {
                Log.Info("程序约会在 10s 后退出...", $"{nameof(MainAnalysis)}_{nameof(HandleData)}");
            }
        }

        #region Generate & Output
        private static void OutputCompare(StringBuilder target, PacketDelayResult delay, PacketLossResult loss, string from_friendlyName, string to_friendlyName)
        {
            // Output(stringRes, $"Client        -> Proxy            : 平均延迟:{CpDelay.average_packetDelay.Milliseconds}ms ({CpDelay.average_packetDelay}), 总丢包:{CpLoss.packetLoss}");
            Output(target, $"{from_friendlyName} -> {to_friendlyName}: " +
                $"平均延迟:{delay.average_packetDelay.TotalMilliseconds}ms " +
                $"({delay.average_packetDelay}), 总丢包:{loss.packetLoss}, " +
                $"网络抖动:{(delay.maximum_packetDelay - delay.minimum_packetDelay).TotalMilliseconds}ms " +
                $"({delay.minimum_packetDelay} - {delay.maximum_packetDelay})");
        }

        private static void OutputLossAck(StringBuilder target, PacketLossResult lossResult, string from_friendlyName, string to_friendlyName)
        {
            if (lossResult.lost_ack.Length == 0)
            {
                Output(target, $"{from_friendlyName} -> {to_friendlyName} 无丢包。");
            }
            else
            {
                ProgramExitCode = 114514;
                Output(target, $"{from_friendlyName} -> {to_friendlyName} 丢包情况：");
                Output(target, $"  出现了 {lossResult.lost_ack.Length} 个包丢失。ack 列表：");
                #region Lost packet
                string acklist = "  [ ";
                foreach (var loss in lossResult.lost_ack)
                {
                    acklist += $"{loss}; ";
                }
                acklist += "]";
                Output(target, acklist);
                #endregion
            }
            if (lossResult.extra_ack.Length != 0)
            {
                Output(target);
                Output(target, $"  有 {lossResult.extra_ack.Length} 个包收到了响应但没有找到发出过的请求。ack 列表：");
                #region Extra Packet
                string acklist = "  [ ";
                foreach (var ext in lossResult.extra_ack)
                {
                    acklist += $"{ext}; ";
                }
                acklist += "]";
                Output(target, acklist);
                #endregion
            }
        }

        private static void OutputInvertedPacket(StringBuilder target, PacketDelayResult delay, string from_friendlyName, string to_friendlyName)
        {
            if (delay.inverted_ack_list.Length != 0)
            {
                ProgramExitCode = 114514;
                Output(target, $"{from_friendlyName} -> {to_friendlyName}: 出现了 {delay.inverted_ack_list.Length} 次乱序现象。");
                foreach (var inverted_pkt in delay.inverted_ack_list)
                {
                    Output(target, $"  [ 失序 ack: {inverted_pkt.Item1}, 收到时间: {inverted_pkt.Item2:HH:mm:ss.fff.ffff} ]");
                }
            }
        }
        #endregion

        #region Inner Output
        private static void Output(StringBuilder target)
        {
            // Log.Info("", $"{nameof(MainAnalysis)}_GenerateReport");
            target.AppendLine();
        }

        private static void Output(StringBuilder target, string content)
        {
            if (Constants.running_on_github_actions) Log.Info(content, $"{nameof(MainAnalysis)}_GenerateReport");
            target.AppendLine(content);
        }
        #endregion

        #region Generate Excel Packet Loss Details
        private class PacketDelayOutputLine
        {
            public uint ack { get; set; }
            public string? packet_from { get; set; }
            public string? packet_to { get; set; }
            public string? packet_delay { get; set; }
            public double packet_delay_milliseconds { get; set; }
        }

        private static void GenerateExportLines(
            ref IEnumerable<PacketDelayOutputLine>? result_collection_all_in_one,
            PacketDelayResult delayResult, string packet_from, string packet_to)
        {
            var current_analyzed = 
                from tuple in delayResult.ack_list
                let odd_ack = tuple.Item1 - ((tuple.Item1 & 1) ^ 1)
                select new PacketDelayOutputLine
                {
                    ack = odd_ack,
                    packet_from = packet_from,
                    packet_to = packet_to,
                    packet_delay = tuple.Item2.ToString(),
                    packet_delay_milliseconds = tuple.Item2.TotalMilliseconds
                };
            if (result_collection_all_in_one == null)
                result_collection_all_in_one = current_analyzed;
            else result_collection_all_in_one = result_collection_all_in_one.Concat(current_analyzed);
        }

        // Generated by ChatGPT, not tested
        // Need EPPlus nuget reference
        public static void ExportXlsxRecord<T>(this IEnumerable<T> collection, string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Records");
                worksheet.Cells.LoadFromCollection(collection, true);
                package.SaveAs(new FileInfo(filePath));
            }
        }
        #endregion
    }
}
