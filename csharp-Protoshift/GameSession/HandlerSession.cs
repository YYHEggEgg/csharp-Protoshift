using csharp_Protoshift.resLoader;
using csharp_Protoshift.RSA;
using Funny.Crypto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Util;

namespace csharp_Protoshift.GameSession
{
    internal class HandlerSession
    {
        /// <summary>
        /// XOR key used to decrypt packet. Usually have a length of 4096.
        /// </summary>
        public byte[] XorKey { get; protected set; }
        protected PacketRecord[] records;
        public uint SessionId { get; private set; }

        /// <summary>
        /// Whether records contain PingReq/PingRsp packets. Only apply to packets received after modified.
        /// </summary>
        public bool RecordPingPackets { get; set; }
        /// <summary>
        /// Whether output packets in the console.
        /// </summary>
        public bool Verbose { get; set; }
        protected int packetCounts = 0;
        public int PacketRecordLimits { get; }

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="packetLimits">The maximum count of packets reserved for analyzing and resending. Default is 5000.</param>
        public HandlerSession(uint sessionId, int packetLimits = 5000)
        {
            XorKey = Resources.dispatchKey;
            Debug.Assert(XorKey.Length == 4096);
            records = new PacketRecord[packetLimits];
            SessionId = sessionId;
            PacketRecordLimits = packetLimits;
            client_seed = server_seed = new byte[0];
        }

        public byte[] HandlePacket(byte[] packet, bool isNewCmdid)
        {
            XorDecrypt(ref packet, 0, 2);
            // Reference: https://sdl.moe/post/magic-sniffer/#%E5%B7%B2%E7%9F%A5%E6%98%8E%E6%96%87%E6%94%BB%E5%87%BB
            var magic_start = packet.GetUInt16(0);
            if (magic_start != 0x4567)
            {
                XorDecrypt(ref packet, 2, packet.Length - 2);
                Log.Erro("Invalid Magic Start: Bad packet received from " +
                    $"{(isNewCmdid ? "Client" : "Server")}:---{Convert.ToHexString(packet)}", 
                    $"PacketHandler({SessionId})");
                XorDecrypt(ref packet, 0, 2);
                Log.Info("Fall back to dispatchKey", $"PacketHandler({SessionId})");
                XorKey = Resources.dispatchKey;
                XorDecrypt(ref packet, 0, 2);
                magic_start = packet.GetUInt16(0);
                if (magic_start != 0x4567)
                {
                    throw new InvalidOperationException();
                }
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
            XorDecrypt(ref rtn);
            return rtn;
        }

        #region Packet Handle
        private byte[] GetPacketResult(byte[] packet, ushort cmdid, bool isNewCmdid, 
            int body_offset, uint body_length)
        {
            var bodyfrom = new byte[body_length];
            Array.Copy(packet, body_offset, bodyfrom, 0, body_length);
            #region Client packet
            if (isNewCmdid)
            {
                #region Receive and read
                if (!NewProtos.QueryCmdId.TryGetSerializer(cmdid, out var newserializer))
                {
                    Log.Erro($"Packet with CmdId:{cmdid} from Client" +
                        $" has no record in newcmdid.csv and dropped:---{Convert.ToHexString(packet)}", 
                        $"PacketHandler({SessionId})");
                    return new byte[0];
                }
                string protoname = newserializer.Protoname;
                string newjson = newserializer.DeserializeToJson(bodyfrom);
                if (Verbose)
                {
                    Log.Info($"Recv packet with CmdId:{cmdid} from " +
                        $"Client:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                }
                #endregion

                #region Protoshift
                if (!OldProtos.QueryCmdId.TryGetSerializer(protoname, out var oldserializer))
                {
                    Log.Erro($"Packet {protoname} from Client" +
                        $" has no record in oldcmdid.csv and dropped:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                    return new byte[0];
                }

                byte[] oldbody = oldserializer.SerializeFromJson(newjson);

                string? oldjson = null; 
                if (Verbose)
                {
                    oldjson = oldserializer.DeserializeToJson(oldbody);
                    Log.Info($"Send packet {protoname} with " +
                        $"CmdId:{OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                        $"to Server:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                }

                bool dataLostSign = false;
                #region DEBUG - Detect information lost in Protoshift
#if DEBUG
                oldjson ??= oldserializer.DeserializeToJson(oldbody);
                var newlines = ConvertJsonString(newjson).Split('\n');
                var oldlines = ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", $"PacketHandler({SessionId})");
                    dataLostSign = true;
                }
#endif
                #endregion
                #endregion

                #region Notify
                if (protoname == "GetPlayerTokenReq")
                {
                    Task.WaitAll(GetPlayerTokenReqNotify(newjson));
                }
                #endregion

                #region Record Packet
                if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                {
                    records[packetCounts % PacketRecordLimits] = new PacketRecord
                    {
                        PacketName = protoname,
                        Id = packetCounts,
                        CmdId = cmdid,
                        sentByClient = true,
                        dataLostSign = dataLostSign,
                        data = packet,
                        newjsonContent = newjson,
                        oldjsonContent = oldjson
                    };
                    packetCounts++;
                }
                #endregion

                #region Build New Packet
                int newpacketLength = body_offset + oldbody.Length;
                byte[] rtn = new byte[newpacketLength];
                Array.Copy(packet, 0, rtn, 0, body_offset);
                rtn.SetUInt32(2 + 2 + 2, (uint)oldbody.Length);
                Array.Copy(oldbody, 0, rtn, body_offset, oldbody.Length);

                return rtn;
                #endregion
            }
            #endregion
            #region Server packet
            else
            {
                #region Receive and read
                if (!OldProtos.QueryCmdId.TryGetSerializer(cmdid, out var oldserializer))
                {
                    Log.Erro($"Packet with CmdId:{cmdid} from Server" +
                        $" has no record in oldcmdid.csv and dropped:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                    return new byte[0];
                }
                string protoname = oldserializer.Protoname;
                string oldjson = oldserializer.DeserializeToJson(bodyfrom);
                if (Verbose)
                {
                    Log.Info($"Recv packet with CmdId:{cmdid} from " +
                        $"Server:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                }
                #endregion

                #region Protoshift
                if (!NewProtos.QueryCmdId.TryGetSerializer(protoname, out var newserializer))
                {
                    Log.Erro($"Packet {protoname} from Server" +
                        $" has no record in newcmdid.csv and dropped:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                    return new byte[0];
                }

                byte[] newbody = newserializer.SerializeFromJson(oldjson);

                string? newjson = null;
                if (Verbose)
                {
                    newjson = oldserializer.DeserializeToJson(newbody);
                    Log.Info($"Send packet {protoname} with " +
                        $"CmdId:{NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                        $"to Client:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                }
                #region DEBUG - Detect information lost in Protoshift
#if DEBUG
                newjson ??= newserializer.DeserializeToJson(newbody);
                var newlines = ConvertJsonString(newjson).Split('\n');
                var oldlines = ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", $"PacketHandler({SessionId})");
                }
#endif
                #endregion
                #endregion

                #region Notify
                if (protoname == "GetPlayerTokenRsp")
                {
                    Task.WaitAll(GetPlayerTokenRspNotify(newjson));
                }
                #endregion

                #region Record Packet
                if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                {
                    records[packetCounts % PacketRecordLimits] = new PacketRecord
                    {
                        PacketName = protoname,
                        Id = packetCounts,
                        CmdId = cmdid,
                        sentByClient = false,
                        data = packet,
                        newjsonContent = newjson,
                        oldjsonContent = oldjson
                    };
                    packetCounts++;
                }
                #endregion

                #region Build New Packet
                int oldpacketLength = body_offset + newbody.Length;
                byte[] rtn = new byte[oldpacketLength];
                Array.Copy(packet, 0, rtn, 0, body_offset);
                rtn.SetUInt32(2 + 2 + 2, (uint)newbody.Length);
                Array.Copy(newbody, 0, rtn, body_offset, newbody.Length);

                return rtn;
                #endregion
            }
            #endregion
        }

        protected byte[] client_seed;
        protected byte[] server_seed;

        private async Task GetPlayerTokenReqNotify(string messageJson)
        {
            uint key_id = uint.Parse(Tools.GetFieldFromJson(messageJson, "key_id"));
            client_seed = await Resources.SPri[key_id].DecryptByPrivateKey(
                Convert.FromBase64String(Tools.GetFieldFromJson(messageJson, "client_rand_key")));
        }

        private async Task GetPlayerTokenRspNotify(string messageJson)
        {
            uint key_id = uint.Parse(Tools.GetFieldFromJson(messageJson, "key_id"));
            server_seed = await Resources.CPri[key_id].DecryptByPrivateKey(
                Convert.FromBase64String(Tools.GetFieldFromJson(messageJson, "server_rand_key")));
            ulong encrypt_seed = server_seed.GetUInt64(0) ^ client_seed.GetUInt64(0);
            XorKey = Generate4096KeyByMT19937(encrypt_seed);
        }
        #endregion

        #region Crypto
        private void XorDecrypt(ref byte[] encrypted, int offset = 0, int length = -1)
        {
            if (length == -1) length = encrypted.Length;
            else length = Math.Min(offset + length, encrypted.Length);
            for (int i = offset; i < offset + length; i++)
            {
                encrypted[i] = (byte)(encrypted[i] ^ XorKey[i % XorKey.Length]);
            }
        }

        static JsonSerializer serializer = new();

        private static string ConvertJsonString(string str)
        {
            //格式化json字符串
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object? obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }

        public static byte[] Generate4096KeyByMT19937(ulong seed) 
        {
            MT19937 mt1 = new(), mt2 = new();
            mt1.Seed(seed);
            ulong mt2seed = mt1.UInt64();
            mt2.Seed(mt2seed);
            mt2.UInt64();
            byte[] key = new byte[4096];
            for (int i = 0; i < key.Length; i += 8)
            {
                ulong newui64 = mt2.UInt64();
                key.SetUInt64(i, newui64);
            }
            return key;
        }
        #endregion

        public List<PacketRecord> QueryPacketRecords(string protoname)
        {
            var query = from record in records
                        where record.PacketName == protoname
                        select record;
            return query.ToList();
        }

        public List<int> QueryPacketRecordIds(string protoname)
        {
            var query = from record in records
                        where record.PacketName == protoname
                        select record.Id;
            return query.ToList();
        }

        public PacketRecord QueryPacketRecordById(int id) => records[id % PacketRecordLimits];
    }
}
