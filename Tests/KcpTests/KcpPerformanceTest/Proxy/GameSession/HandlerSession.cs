using csharp_Protoshift.resLoader;
using Newtonsoft.Json;
using System.Diagnostics;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    internal class HandlerSession
    {
        public uint SessionId { get; private set; }

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="packetLimits">The maximum count of packets reserved for analyzing and resending. Default is 5000.</param>
        public HandlerSession(uint sessionId, int packetLimits = 5000)
        {
            SessionId = sessionId;
        }

        public byte[] HandlePacket(byte[] packet, bool isNewCmdid)
        {
            if (packet == null) throw new ArgumentNullException(nameof(packet));
            XorDecrypt(ref packet, 0, 2);
            // Reference: https://sdl.moe/post/magic-sniffer/#%E5%B7%B2%E7%9F%A5%E6%98%8E%E6%96%87%E6%94%BB%E5%87%BB
            var magic_start = packet.GetUInt16(0);
            if (magic_start != 0x4567)
            {
                XorDecrypt(ref packet, 2, packet.Length - 2);
                Log.Erro("Invalid Magic Start: Bad packet received from " +
                    $"{(isNewCmdid ? "Client" : "Server")}:---{Convert.ToHexString(packet)}",
                    $"PacketHandler({SessionId})");
                XorDecrypt(ref packet, 0, packet.Length);
            }

            XorDecrypt(ref packet, 2, 2 + 2 + 4);
            var cmdid = packet.GetUInt16(2);
            var head_length = packet.GetUInt16(4);
            var body_length = packet.GetUInt32(6);
            int head_offset = 2 + 2 + 2 + 4;
            if (body_length > int.MaxValue)
                throw new InvalidOperationException("Are you downloading anime game through KCP? How in teyvat can you get a 2GB packet?");
            XorDecrypt(ref packet, head_offset, head_length + (int)body_length + 2 + 2); // read magic start of the next if possible
            int body_offset = head_offset + head_length;
            int magic_end_offset = body_offset + (int)body_length;
            var magic_end = packet.GetUInt16(magic_end_offset);
            if (magic_end != 0x89AB)
            {
                Log.Erro("Invalid Magic End: Bad packet received from " +
                    $"{(isNewCmdid ? "Client" : "Server")}:---{Convert.ToHexString(packet)}",
                    $"PacketHandler({SessionId})");
                throw new InvalidOperationException();
            }

            if (packet.Length >= body_offset + body_length + 2 + 2)
            {
                int next_magic_start = packet.GetUInt16(body_offset + (int)body_length + 2);
                if (next_magic_start == 0x4567)
                    Log.Warn("Multiple packets detected in one request. Program need optimize.",
                        $"PacketHandler({SessionId})");
            }

            var rtn = GetPacketResult(packet, cmdid, isNewCmdid, body_offset, body_length);
            Debug.Assert(rtn.GetUInt16(rtn.Length - 2) == 0x89AB);

            XorDecrypt(ref rtn);
            return rtn;
        }

        public bool PacketOrdered(byte[] packet, bool isNewCmdid)
        {
            // return true;
            if (packet == null) throw new ArgumentNullException(nameof(packet));
            XorDecrypt(ref packet, 0, 2);
            // Reference: https://sdl.moe/post/magic-sniffer/#%E5%B7%B2%E7%9F%A5%E6%98%8E%E6%96%87%E6%94%BB%E5%87%BB
            var magic_start = packet.GetUInt16(0);
            if (magic_start != 0x4567)
            {
                XorDecrypt(ref packet, 0, 2); // recover original encrypted
                return false;
            }

            XorDecrypt(ref packet, 2, 2);
            var cmdid = packet.GetUInt16(2);
            XorDecrypt(ref packet, 0, 4); // recover original packet

            /*if (isNewCmdid)
            {
                if (cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenReq") ||
                    cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("PlayerLoginReq") || 
                    cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("PingReq"))
                    return true;
                else return false;
            }
            else
            {*/
            // if (cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenRsp") ||
            //     cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("PlayerLoginRsp") ||
            //     cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("PingRsp"))
                return true;
            // else 
            //     return false;
            //}
        }

        #region Packet Handle
#if DEBUG
        public byte[] GetPacketResult(byte[] packet, ushort cmdid, bool isNewCmdid,
            int body_offset, uint body_length)
#else
        private byte[] GetPacketResult(byte[] packet, ushort cmdid, bool isNewCmdid,
            int body_offset, uint body_length)
#endif
        {
            Stopwatch ProtoshiftWatch = new();
            ProtoshiftWatch.Start();
            var bodyfrom = new byte[body_length];
            Array.Copy(packet, body_offset, bodyfrom, 0, body_length);

            ProtoshiftWatch.Stop();
            // SubmitTimeRecord(protoname, false, ProtoshiftWatch.ElapsedMilliseconds, packet.Length);
            return packet;
        }
        #endregion

        #region Crypto
        private void XorDecrypt(ref byte[] encrypted, int offset = 0, int length = -1)
        {
            if (length == -1) length = encrypted.Length;
            else length = Math.Min(length, encrypted.Length - offset);
            for (int i = offset; i < offset + length; i++)
            {
                encrypted[i] = (byte)(encrypted[i] ^ Resources.dispatchKey[i % Resources.dispatchKey.Length]);
            }
        }

        static readonly JsonSerializer serializer = new();
        #endregion
    }
}
