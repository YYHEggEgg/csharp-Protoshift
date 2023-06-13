using csharp_Protoshift.MhyKCP.Test.App;
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

#if PROXY_FIX_DISORDER_SPECIAL_TEST
        Random sleep_rnd = new();
            
#endif

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

#if PROXY_FIX_DISORDER_SPECIAL_TEST
            int sleep_max = 2 * Constants.packet_interval_ms;
            lock (sleep_rnd) Thread.Sleep(sleep_rnd.Next(sleep_max));
#endif

            return rtn;
        }

        public bool IsUrgentPacket(byte[] packet, bool isNewCmdid)
        {
            /* Due to current researches, after the urgent packet split was added, 
             * nothing about network but the Ping value shown in the game has improved, 
             * and the worst thing is that Protoshift became no longer stable, 
             * including the same bug as YuFanXing/Protoshift randomly appear at 60% of time. 
             * That's unbearable but exchanged not much efficiency increase, 
             * as the base KCP implement is synchronous -- by bussy locks. 
             * It makes UrgentPacket implement nearly unnecessary at all 
             *   -- as nearly most of packets are sent syncronous actually. 
             * But the disadvantages are preserved. Some important packets are sent asyncronously, 
             * but because UdpClient isn't thread-safe, they are possibly dropped or cracked. 
             * So, considered all the factors, I decided to give up the UrgentPacket implement.
             * 
             * For actual performance improve solutions, some of following ways should be considered: 
             * - KcpProxy sub clients. 
             *   Though the KcpProxy and KCPServer are designed for multiple clients, 
             *   the KCP base and UdpClient base aren't. Therefore, the most ideal conditions are that 
             *   there's one KcpServer instance for each client.
             * - Approach the Java Protoshift implement.
             *   The most important Protoshift means in this project is deserialize the message
             *   from one protocol to a general inner json content, and serialize it to another protocol. 
             *   Compared to this, YuFanXing/Protoshift directly transfers variables from protocols
             *   by generated codes, so it was surely more efficient. 
             *   According to tests, handling a 224KB PlayerLoginRsp packet costs (in HandlerSession only)
             *   about 68ms in total.
             * - Change the base UDP and KCP implements. 
             *   The reason has been mentioned repeatedly above, but notice that
             *   it works only when UDP and KCP implements are both thread-safe. 
             */
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
            //     return true;
            // else 
                return true;
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
