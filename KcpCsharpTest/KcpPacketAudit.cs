using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets.Kcp;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;
namespace KcpCsharpTest
{
    internal static class KcpPacketAudit
    {
        static KcpPacketAudit()
        {
            Task.Run(BackgroundUpdate);
        }

        static ConcurrentQueue<(DateTime sentTime, IMemoryOwner<byte> packet, int avalidLength)> kcpPackets = new();
        static MemoryPool<byte> memoryPool = MemoryPool<byte>.Shared;

        /// <summary>
        /// Push a KCP packet to audit. <paramref name="packet"/> will be deep cloned and can be disposed by its owner after invoke.
        /// </summary>
        /// <param name="sentTime"></param>
        /// <param name="packet"></param>
        public static void PushPacket(DateTime sentTime, Memory<byte> packet, int avalidLength)
        {
            var buf = memoryPool.Rent(avalidLength);
            packet.Slice(0, avalidLength).TryCopyTo(buf.Memory);
            kcpPackets.Enqueue((sentTime, buf, avalidLength));
        }

        private static void BackgroundUpdate()
        {
            while (true)
            {
                try
                {
                    if (!kcpPackets.TryDequeue(out var res))
                    {
                        Thread.Sleep(15);
                        continue;
                    }

                    Span<byte> pktContent = res.packet.Memory.Slice(0, res.avalidLength).Span;
                    List<string> exceptions = new();
                    #region 获取conv和token（以第一个kcp包为准）
                    uint conv = BinaryPrimitives.ReadUInt32LittleEndian(pktContent);
#if MIHOMO_KCP
                    uint token = BinaryPrimitives.ReadUInt32LittleEndian(pktContent.Slice(sizeof(uint)));
#endif
                    if (conv != Constants.global_kcp_conv
#if MIHOMO_KCP
                        && token != Constants.global_kcp_token
#endif
                    )
                    {
#if MIHOMO_KCP
                        exceptions.Add($"Kcp conv/token mismatch. Read conv: {conv}, token: {token}");
#else
                        exceptions.Add($"Kcp conv mismatch. Read conv: {conv}");
#endif
                    }
                    #endregion
                    #region 使用conv和token对包切片
#if MIHOMO_KCP
                    Span<byte> kcpSegStart = new Span<byte>(new byte[sizeof(uint) * 2]);
#else
                    Span<byte> kcpSegStart = new Span<byte>(new byte[sizeof(uint)]);
#endif
                    BinaryPrimitives.WriteUInt32LittleEndian(kcpSegStart, conv);
#if MIHOMO_KCP
                    BinaryPrimitives.WriteUInt32LittleEndian(kcpSegStart.Slice(sizeof(uint)), token);
#endif
                    #endregion

                    var starts = FindInSpan(pktContent, kcpSegStart);

                    if (starts.Count == 0) exceptions.Add("Packet don't contain any KCP headers.");
                    else
                    {
                        if (starts[0] != 0) exceptions.Add("Packet don't start with a valid KCP header.");
                        for (int i = 0; i < starts.Count; i++)
                        {
                            int segLen = (i == starts.Count - 1) ? (pktContent.Length - starts[i])
                                : (starts[i + 1] - starts[i]);
                            Span<byte> segment = pktContent.Slice(starts[i], segLen);
                            #region KCP Header check
                            if (segLen < KcpConst.IKCP_OVERHEAD)
                            {
                                exceptions.Add($"Segment {i} is shorter than a valid kcp packet, data: {Convert.ToHexString(segment)}");
                                continue;
                            }
                            int offset = 0;
#if MIHOMO_KCP
                            offset += sizeof(uint) * 2;
#else
                            offset += sizeof(uint);
#endif
                            byte cmd = segment[offset];
                            offset += sizeof(byte);
                            if (cmd != KcpConst.IKCP_CMD_PUSH && cmd != KcpConst.IKCP_CMD_ACK
                                && cmd != KcpConst.IKCP_CMD_WASK && cmd != KcpConst.IKCP_CMD_WINS)
                            {
                                exceptions.Add($"Segment {i} is not a valid cmd, cmd: {cmd}");
                            }
                            offset += sizeof(byte) + sizeof(ushort) + sizeof(uint) * 3;
                            uint len = BinaryPrimitives.ReadUInt32LittleEndian(segment.Slice(offset));
                            offset += sizeof(uint);
                            Debug.Assert(offset == KcpConst.IKCP_OVERHEAD);
                            #endregion
                            #region Content Length Check
                            int contentLen = segLen - offset;
                            if (contentLen < len)
                            {
                                exceptions.Add($"Segment {i}'s content length is shorter that reported: {len} bytes.");
                                var analyzeResult = Util.CutPacket(segment.Slice(offset));
                                if (analyzeResult.Count == 1)
                                {
                                    var singleseg = analyzeResult[0];
                                    exceptions.Add($"Content: {contentLen} bytes, Range: " +
                                        $"{singleseg.startbyte}-{(byte)(singleseg.startbyte + singleseg.len - 1)}");
                                    if (singleseg.startbyte != 0) 
                                        exceptions.Add("Range not start with 0.");
                                }
                                else if (analyzeResult.Count == 0)
                                {
                                    Debug.Assert(contentLen == 0);
                                    if (contentLen == 0) exceptions.Add("Content: Empty");
                                    else exceptions.Add("Util.CutPacket worked unexpectedly, " +
                                        $"content: {Convert.ToHexString(segment.Slice(offset))}");
                                }
                                else exceptions.Add($"Content: {contentLen} bytes, bad packet");
                            }
                            else if (contentLen > len)
                            {
                                exceptions.Add($"Segment {i}'s content length is longer that reported.");
                                var analyzeResult = Util.CutPacket(segment.Slice(offset));
                                if (analyzeResult.Count == 1)
                                {
                                    var singleseg = analyzeResult[0];
                                    exceptions.Add($"Content: {contentLen} bytes, Range: " +
                                        $"{singleseg.startbyte}-{singleseg.startbyte + singleseg.len - 1}");
                                    if (singleseg.startbyte != 0) 
                                        exceptions.Add("Range not start with 0.");
                                }
                                else if (analyzeResult.Count == 0)
                                {
                                    Debug.Assert(contentLen == 0);
                                    if (contentLen == 0) exceptions.Add("Content: Empty");
                                    else exceptions.Add("Util.CutPacket worked unexpectedly, " +
                                        $"content: {Convert.ToHexString(segment.Slice(offset))}");
                                }
                                else if (analyzeResult[0].len == (int)len)
                                {
                                    var singleseg = analyzeResult[0];
                                    exceptions.Add($"Content: {contentLen} bytes, Range[0]: " +
                                        $"{singleseg.startbyte}-{(byte)(singleseg.startbyte + singleseg.len - 1)}");
                                    if (singleseg.startbyte != 0) 
                                        exceptions.Add("Range[0] not start with 0.");
                                    else exceptions.Add("Range[0] is correct.");
                                }
                                else exceptions.Add($"Content: {contentLen} bytes, bad packet");
                            }
                            #endregion
                        }
                    }
                    if (exceptions.Count == 0) 
                    {
#if MIHOMO_KCP
                        Log.Verb($"Packet with length {pktContent.Length} is OK and passed check, conv: {conv}, token: {token}", nameof(KcpPacketAudit));
#else
                        Log.Verb($"Packet with length {pktContent.Length} is OK and passed check, conv: {conv}", nameof(KcpPacketAudit));
#endif
                        continue;
                    }

                    #region Generate output
                    StringBuilder sb = new StringBuilder("\n----------KcpPacketAudit report----------\n");
                    sb.Append("Detected following exceptions:\n");
                    foreach (var exception in exceptions) sb.Append($"  {exception}\n");
                    sb.Append('\n');
#if MIHOMO_KCP
                    sb.Append($"Raw packet (conv={conv}, token={token}): {Convert.ToHexString(pktContent)}\n");
#else
                    sb.Append($"Raw packet (conv={conv}): {Convert.ToHexString(pktContent)}\n");
#endif
                    for (int i = 0; i < starts.Count; i++)
                    {
                        int segLen = (i == starts.Count - 1) ? (pktContent.Length - starts[i])
                            : (starts[i + 1] - starts[i]);
                        Span<byte> segment = pktContent.Slice(starts[i], segLen);
                        sb.Append($"\nSegment {i}: Range {starts[i]} +{segLen}bytes\n");

                        #region KCP Header check
                        if (segLen < KcpConst.IKCP_OVERHEAD)
                        {
                            sb.Append($"Broken segment, skipped. data: {Convert.ToHexString(segment)}\n");
                            continue;
                        }
                        #endregion
                        #region Header read
                        int offset = 0;
#if MIHOMO_KCP
                        offset += sizeof(uint) * 2;
#else
                        offset += sizeof(uint);
#endif
                        byte cmd = segment[offset];
                        offset += sizeof(byte);
                        byte frg = segment[offset];
                        offset += sizeof(byte);
                        ushort wnd = BinaryPrimitives.ReadUInt16LittleEndian(segment.Slice(offset));
                        offset += sizeof(ushort);
                        uint ts = BinaryPrimitives.ReadUInt32LittleEndian(segment.Slice(offset));
                        offset += sizeof(uint);
                        uint sn = BinaryPrimitives.ReadUInt32LittleEndian(segment.Slice(offset));
                        offset += sizeof(uint);
                        uint una = BinaryPrimitives.ReadUInt32LittleEndian(segment.Slice(offset));
                        offset += sizeof(uint);
                        uint len = BinaryPrimitives.ReadUInt32LittleEndian(segment.Slice(offset));
                        offset += sizeof(uint);
                        Debug.Assert(offset == KcpConst.IKCP_OVERHEAD);
                        #endregion
                        #region Output segment
                        sb.Append($"  cmd={cmd}, frg={frg}, wnd={wnd}, ts={ts}, sn={sn}, una={una}\n");
                        sb.Append($"  Content (reported: {len}bytes, actual: {segLen - offset}bytes): \n");
                        var analyzeResult = Util.CutPacket(segment.Slice(offset));
                        for (int j = 0; j < analyzeResult.Count; j++)
                        {
                            var singleseg = analyzeResult[j];
                            sb.Append($"    part {j}: " +
                                $"{singleseg.startbyte}-{(byte)(singleseg.startbyte + singleseg.len - 1)}\n");
                        }
                        #endregion
                    }

                    sb.Append("\n-----------------------------------------\n");
                    #endregion
                    Log.Warn($"Detected <color=Red>invalid kcp packet</color> sent at {res.sentTime}, bytes_sent={pktContent.Length}", nameof(KcpPacketAudit));
                    Log.Dbug(sb.ToString(), nameof(KcpPacketAudit));
                }
                catch (Exception ex)
                {
                    Log.Erro($"Error occured when handling audit kcp packet: {ex}", nameof(KcpPacketAudit));
                }
            }
        }

        public static string Initialize() => "KcpPacketAudit background thread running.";

        #region Util
        /// <summary>
        /// Find all appear locations [content] have in the HexObject. Based on KMP Algorithm.
        /// <para/>from https://github.com/YYHEggEgg/HexAPI/blob/main/HexAPI/HexObjects/HexObject.cs
        /// </summary>
        /// <param name="contentToFind"></param>
        /// <returns></returns>
        private static List<int> FindInSpan(Span<byte> baseContent, Span<byte> contentToFind)
        {
            int content_len = contentToFind.Length;
            int obj_len = baseContent.Length;

            #region nxt array init
            int[] nxt = new int[contentToFind.Length + 1];
            int i = 0, j = -1;
            nxt[0] = -1;

            while (i < content_len)
            {
                if (j == -1 || contentToFind[i] == contentToFind[j]) nxt[++i] = ++j;
                else j = nxt[j];
            }
            #endregion

            List<int> indexes = new();

            #region KMP
            int k = 0, m = 0;
            while (k < obj_len)
            {
                if (m == -1 || baseContent[k] == contentToFind[m])
                {
                    k++; m++;
                }
                else m = nxt[m];

                if (m == content_len)
                {
                    indexes.Add(k - content_len);
                    m = nxt[m];
                }
            }
            #endregion

            return indexes;
        }
    }
    #endregion
}