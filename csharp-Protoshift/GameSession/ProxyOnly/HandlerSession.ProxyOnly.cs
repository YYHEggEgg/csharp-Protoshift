#if PROXY_ONLY_SERVER

using csharp_Protoshift.Configuration;
using System.Diagnostics;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        public const int Recommended_Protoshift_maximum_time_ms = 15;
        #region Record Packet Protoshift time cost
        private static readonly Int64 nanosecPerTick = (1000L * 1000L * 1000L) / Stopwatch.Frequency;
        private Int64 CalcNanosecFromStopwatchTicks(Int64 handleTicks)
        {
            return handleTicks * nanosecPerTick;
        }
        #endregion

        public bool OrderedPacket(byte[] packet, bool isNewCmdid)
        {
            return true;
        }

        #region Packet Handle
#if DEBUG || PROTOSHIFT_BENCHMARK
        public byte[] GetPacketResult(byte[] packet, ushort cmdid, bool isNewCmdid,
            int head_offset, int head_length, int body_offset, uint body_length)
#else
        private byte[] GetPacketResult(byte[] packet, ushort cmdid, bool isNewCmdid,
            int head_offset, int head_length, int body_offset, uint body_length)
#endif
        {
#if !PROTOSHIFT_BENCHMARK
            Stopwatch ProtoshiftWatch = new();
            ProtoshiftWatch.Start();
#endif
            // var head_offset = sizeof(ushort) * 3 + sizeof(uint);
            // OldProtos.PacketHead packetHead = OldProtos.PacketHead.Parser.ParseFrom(packet, head_offset, packet.GetUInt16(sizeof(ushort) * 2));
            // if (Verbose)
            //     Log.Dbug($"Received packet head from {(isNewCmdid ? "Client" : "Server")} ({packet.GetUInt16(sizeof(ushort) * 2)} bytes) --- {packetHead}");

            // packetHead.SentMs = 0;
            // packetHead.ClientSequenceId = 0;
            // var newhead = packetHead.ToByteArray();

            #region Receive and read
            if (!OldProtos.QueryJsonSerializer.TryGetJsonSerializer(cmdid, out var oldserializer))
            {
                Log.Erro($"Packet with CmdId:{cmdid} from Server" +
                    $" has no record in oldcmdid.csv and skipped.",
                    $"PacketHandler({_sessionId})");
#if !PROTOSHIFT_BENCHMARK                
                ProtoshiftWatch.Stop();
                if (Config.Global.EnableFullPacketLog)
                {
                    Debug.Assert(GameSessionDispatch.PacketLogger != null);
                    GameSessionDispatch.PacketLogger.Info(() => new PacketRecord(_uid,
                        $"UnkCMD_{cmdid}", cmdid, isNewCmdid, packet, head_offset, head_length, 
                        body_offset, (int)body_length, DateTime.Now).ToString(), _uid.ToString());
                }
#endif
                // return Array.Empty<byte>();
                return packet;
            }
            string protoname = oldserializer.Protoname;
            InvokeNotifyMiddleware(packet, protoname, cmdid, isNewCmdid, body_offset, body_length);
            #endregion

#if !PROTOSHIFT_BENCHMARK
            ProtoshiftWatch.Stop();
            if (ProtoshiftWatch.ElapsedMilliseconds >= Recommended_Protoshift_maximum_time_ms)
            {
                PushPlayerStatLog($"handler", "too_long_timecost", $"{protoname}|{ProtoshiftWatch.ElapsedMilliseconds}ms");
            }
            if (Config.Global.EnableFullPacketLog)
            {
                Debug.Assert(GameSessionDispatch.PacketLogger != null);
                GameSessionDispatch.PacketLogger.Info(() => new PacketRecord(_uid, protoname, 
                    cmdid, isNewCmdid, packet,head_offset, head_length, 
                    body_offset, (int)body_length, DateTime.Now).ToString(), _uid.ToString());
            }
#endif
            return packet;
        }
        #endregion

        #region Packet Create
        public byte[] ConstructPacket(bool isNewCmdid, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            var cmdid = OldProtos.AskCmdId.GetCmdIdFromProtoname(protoname);
            var head_length = packetHead?.Length ?? 0;
            var body_length = packetBody.Length;
            int head_offset = 2 + 2 + 2 + 4;
            int body_offset = head_offset + head_length;
            int magic_end_offset = body_offset + body_length;
            int rtnpacketLength = magic_end_offset + 2;

            byte[] rtn = new byte[rtnpacketLength];
            rtn.SetUInt16(0, 0x4567);
            rtn.SetUInt16(2, (ushort)cmdid);
            rtn.SetUInt16(4, (ushort)head_length);
            rtn.SetUInt32(6, (uint)body_length);

            if (packetHead != null) Buffer.BlockCopy(packetHead, 0, rtn, head_offset, packetHead.Length);
            Buffer.BlockCopy(packetBody, 0, rtn, body_offset, body_length);
            rtn.SetUInt16(rtnpacketLength - 2, 0x89AB);

            if (Verbose)
            {
                Log.Info($"Create packet {protoname} with " +
                    $"CmdId:{NewProtos.AskCmdId.GetCmdIdFromProtoname(protoname)} " +
                    $"for {(isNewCmdid ? "Client" : "Server")}:---{Convert.ToHexString(rtn)}",
                $"PacketConstructor({_sessionId})");
            }

            XorDecrypt(ref rtn);
            return rtn;
        }
        #endregion
    }
}
#endif