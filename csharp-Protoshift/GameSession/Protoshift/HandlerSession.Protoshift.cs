#if !PROXY_ONLY_SERVER

using csharp_Protoshift.Configuration;
using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.SkillIssue;
using System.Collections.ObjectModel;
using System.Diagnostics;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        public const int Recommended_Protoshift_maximum_time_ms = 5;

        #region Record Packet Protoshift time cost
        private static readonly Int64 nanosecPerTick = (1000L * 1000L * 1000L) / Stopwatch.Frequency;

        private static readonly ReadOnlyCollection<string>? excludeLogPackets = null;
        private static readonly bool _globalEnableFullPacketLog;
        private Int64 CalcNanosecFromStopwatchTicks(Int64 handleTicks)
        {
            return handleTicks * nanosecPerTick;
        }
        static HandlerSession()
        {
            #region Unordered cmds
            try
            {
                List<ushort> _unordered_cmds_new = new();
                List<ushort> _unordered_cmds_old = new();
                foreach (var protoname in unordered_messages)
                {
                    _unordered_cmds_new.Add((ushort)NewProtos.AskCmdId.GetCmdIdFromProtoname(protoname));
                    _unordered_cmds_old.Add((ushort)OldProtos.AskCmdId.GetCmdIdFromProtoname(protoname));
                }
                unordered_cmds_new = new(_unordered_cmds_new);
                unordered_cmds_old = new(_unordered_cmds_old);
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, nameof(HandlerSession), $"HandlerSession cmdid init failed. ");
                unordered_cmds_new = new(new List<ushort>());
                unordered_cmds_old = new(new List<ushort>());
            }
            #endregion
            if (Config.Global.PacketLogExcluding != null)
                excludeLogPackets = new(Config.Global.PacketLogExcluding);
            _globalEnableFullPacketLog = Config.Global.EnableFullPacketLog;
        }
        #endregion

        // use whitelist now
        #region Ordered Packet List
        // this is disabled now
        /*private static ReadOnlyCollection<string> ordered_cmds = new(new List<string>
        {
            "WorldPlayerRTTNotify", "SceneTransToPointReq", "PlayerEnterSceneNotify",
            "EnterSceneReadyReq", "SceneInitFinishReq", "EnterSceneDoneReq",
            "EnterScenePeerNotify", "SceneEntityDisappearNotify", "SceneTransToPointRsp",
            "EnterSceneReadyRsp", "SceneInitFinishRsp", "EnterSceneDoneRsp",
            "GetPlayerTokenReq", "GetPlayerTokenRsp", "PlayerLoginReq", "PlayerLoginRsp",
            "ScenePlayerLocationNotify"
        });*/

        // this is in use
        private static List<string> unordered_messages = new List<string>
        {
            // "GetPlayerTokenReq", "GetPlayerTokenRsp", "PingReq", "PingRsp", 
            "GetActivityInfoRsp", "AchievementUpdateNotify", "PlayerLoginRsp",
            "BattlePassMissionUpdateNotify", "CombatInvocationsNotify", "ActivityInfoNotify",
            "BattlePassMissionUpdateNotify", "PlayerStoreNotify", "AvatarDataNotify",
            "BattlePassAllDataNotify", "AvatarExpeditionDataNotify", 
            // "UnionCmdNotify", "CombatInvocationsNotify", 
            // "AbilityInvocationFailNotify", "AbilityInvocationsNotify",
            // "ClientAbilitiesInitFinishCombineNotify", "ClientAbilityChangeNotify",
            // "ClientAbilityInitFinishNotify"
        };

        private static ReadOnlyCollection<ushort> unordered_cmds_new, unordered_cmds_old;
        #endregion

        public bool OrderedPacket(byte[] packet, bool isNewCmdid)
        {
            if (packet == null) throw new ArgumentNullException(nameof(packet));
            bool fallback = false; // Whether use dispatchKey
            XorDecrypt(ref packet, 0, 2);
            // Reference: https://sdl.moe/post/magic-sniffer/#%E5%B7%B2%E7%9F%A5%E6%98%8E%E6%96%87%E6%94%BB%E5%87%BB
            var magic_start = packet.GetUInt16(0);
            if (magic_start != 0x4567)
            {
                XorDecrypt(ref packet, 0, 2); // recover original encrypted
                fallback = true;
                XorDecrypt(ref packet, 0, 2, fallback); // fallback to dispatchKey
                magic_start = packet.GetUInt16(0);
                if (magic_start != 0x4567)
                {
                    XorDecrypt(ref packet, 0, 2, fallback); // recover original encrypted
                    return false;
                }
            }

            XorDecrypt(ref packet, 2, 2, fallback);
            var cmdid = packet.GetUInt16(2);
            XorDecrypt(ref packet, 0, 4, fallback); // recover original packet

            return !(isNewCmdid ? unordered_cmds_new : unordered_cmds_old).Contains(cmdid);
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

            byte[] shifted_body;
            string protoname = isNewCmdid
                    ? NewProtos.AskCmdId.GetProtonameFromCmdId(cmdid)
                    : OldProtos.AskCmdId.GetProtonameFromCmdId(cmdid);
            if (Verbose)
            {
                Log.Info($"Received packet {protoname} ({packet.Length} bytes) with CmdId: {cmdid} from" +
                    (isNewCmdid ? "Client." : "Server."), $"PacketHandler({_sessionId})");
            }
            ushort shifted_cmdid = (ushort)(isNewCmdid ? ShiftCmdId.NewShiftToOld(cmdid) : ShiftCmdId.OldShiftToNew(cmdid));

            if (isNewCmdid) shifted_body = ProtoshiftDispatch.NewShiftToOld(cmdid, 
                packet, head_offset, head_length, packet, body_offset, (int)body_length);
            else shifted_body = ProtoshiftDispatch.OldShiftToNew(cmdid, 
                packet, head_offset, head_length, packet, body_offset, (int)body_length);

            InvokeNotifyMiddleware(packet, protoname, cmdid, isNewCmdid, body_offset, body_length);
            
            #region Push to Skill issue detect
#if !PROTOSHIFT_BENCHMARK
            if (isNewCmdid)
                SkillIssueDetect.StartHandlePacket(protoname,
                    shifted_body, 0, shifted_body.Length,
                    packet, body_offset, (int)body_length);
            else
                SkillIssueDetect.StartHandlePacket(protoname,
                    packet, body_offset, (int)body_length,
                    shifted_body, 0, shifted_body.Length);
#endif
            #endregion

            #region Build New Packet
            int rtnpacketLength = body_offset + shifted_body.Length + 2;
            byte[] rtn = new byte[rtnpacketLength];
            if (body_offset > 0) Array.Copy(packet, 0, rtn, 0, body_offset);
            rtn.SetUInt16(2, shifted_cmdid);
            rtn.SetUInt32(2 + 2 + 2, (uint)shifted_body.Length);
            Array.Copy(shifted_body, 0, rtn, body_offset, shifted_body.Length);
            rtn.SetUInt16(rtnpacketLength - 2, 0x89AB);
            #endregion

#if !PROTOSHIFT_BENCHMARK
            ProtoshiftWatch.Stop();
            if (ProtoshiftWatch.ElapsedMilliseconds >= Recommended_Protoshift_maximum_time_ms && !unordered_cmds_old.Contains(cmdid))
            {
                PushPlayerStatLog($"handler", "too_long_timecost", $"{protoname}|{ProtoshiftWatch.ElapsedMilliseconds}ms");
            }
            if (_globalEnableFullPacketLog && excludeLogPackets?.Contains(protoname) != true)
            {
                Debug.Assert(GameSessionDispatch.PacketLogger != null);
                GameSessionDispatch.PacketLogger.Info(() =>
                    new PacketRecord(Uid, protoname, cmdid, isNewCmdid,
                    packet, head_offset, head_length, body_offset, (int)body_length,
                    CalcNanosecFromStopwatchTicks(ProtoshiftWatch.ElapsedTicks),
                    shifted_body, DateTime.MinValue).ToString(), Uid.ToString());
            }
#endif
            return rtn;
        }
        #endregion

        #region Packet Create
        public byte[] ConstructPacket(bool isNewCmdid, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            var cmdid = isNewCmdid 
                ? NewProtos.AskCmdId.GetCmdIdFromProtoname(protoname)
                : OldProtos.AskCmdId.GetCmdIdFromProtoname(protoname);
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