﻿using csharp_Protoshift.GameSession.SpecialFixs;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
using Funny.Crypto;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Security.Cryptography;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    internal class HandlerSession
    {
        /// <summary>
        /// XOR key used to decrypt packet. Usually have a length of 4096.
        /// </summary>
        public byte[] XorKey { get; protected set; }
        public PacketRecord[] records;
        public uint SessionId { get; private set; }

        /// <summary>
        /// Whether records contain PingReq/PingRsp packets. Only apply to packets received after modified.
        /// </summary>
        public bool RecordPingPackets { get; set; }
        /// <summary>
        /// Whether output packets in the console.
        /// </summary>
        public bool Verbose { get; set; }
        public int packetCounts { get; protected set; }
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
            client_seed = server_seed = Array.Empty<byte>();
            // Verbose = true;
            Verbose = false;
        }

        public byte[] HandlePacket(byte[] packet, bool isNewCmdid)
        {
            if (packet == null) throw new ArgumentNullException(nameof(packet));
            bool fallback = false; // Whether use dispatchKey
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
                Log.Info("Fall back to dispatchKey", $"PacketHandler({SessionId})");
                fallback = true;
                XorDecrypt(ref packet, 0, 2, fallback);
                magic_start = packet.GetUInt16(0);
                if (magic_start != 0x4567)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    Log.Info("Success decoded after XOR Key Fallback, continue", $"PacketHandler({SessionId})");
                }
            }

            XorDecrypt(ref packet, 2, 2 + 2 + 4, fallback);
            var cmdid = packet.GetUInt16(2);
            var head_length = packet.GetUInt16(4);
            var body_length = packet.GetUInt32(6);
            int head_offset = 2 + 2 + 2 + 4;
            if (body_length > int.MaxValue)
                throw new InvalidOperationException("Are you downloading anime game through KCP? How in teyvat can you get a 2GB packet?");
            XorDecrypt(ref packet, head_offset, head_length + (int)body_length + 2 + 2, fallback); // read magic start of the next if possible
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

            if (!isNewCmdid && cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenRsp"))
                XorDecrypt(ref rtn, fallbackToDispatchKey: true);
            else XorDecrypt(ref rtn, fallbackToDispatchKey: fallback);
            return rtn;
        }

        public bool IsUrgentPacket(byte[] packet, bool isNewCmdid)
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
            if (isNewCmdid)
            {
                if (cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenReq") ||
                    cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("PlayerLoginReq") ||
                    cmdid == NewProtos.QueryCmdId.GetCmdIdFromProtoname("PingReq"))
                    return true;
                else return false;
            }
            else
            {
                if (cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenRsp") ||
                    cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("PlayerLoginRsp") ||
                    cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("PingRsp"))
                    return true;
                else return false;
            }
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
                    return Array.Empty<byte>();
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

                #region Special Fix
                if (ExtraFix.NeedSpecialHandle(cmdid, isNewCmdid))
                {
                    var genbody = ExtraFix.SpecialHandle(cmdid, isNewCmdid, bodyfrom);
                    #region Record Packet
                    if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                    {
                        lock (records)
                        {
                            records[packetCounts % PacketRecordLimits] = new PacketRecord
                                (protoname, packetCounts, cmdid, true, packet, genbody)
                                {
                                    dataLostSign = false,
                                    newjsonContent = newjson,
                                    oldjsonContent = "ExtraFix Applied - Not Enabled"
                                };
                            packetCounts++;
                        }
                    }
                    #endregion
                    #region Build New Packet
                    int rtn_packetLength = body_offset + genbody.Length + 2;
                    byte[] rtn_packet = new byte[rtn_packetLength];
                    Array.Copy(packet, 0, rtn_packet, 0, body_offset);
                    rtn_packet.SetUInt16(2, (ushort)OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname));
                    rtn_packet.SetUInt32(2 + 2 + 2, (uint)genbody.Length);
                    Array.Copy(genbody, 0, rtn_packet, body_offset, genbody.Length);
                    rtn_packet.SetUInt16(rtn_packetLength - 2, 0x89AB);

                    if (Verbose)
                    {
                        Log.Info($"Send packet {protoname} with " +
                            $"CmdId:{OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                            $"to Server:---{Convert.ToHexString(rtn_packet)}",
                            $"PacketHandler({SessionId})");
                    }

                    return rtn_packet;
                    #endregion
                }
                #endregion

                #region Protoshift
                byte[] oldbody;
                OldProtos.ProtoSerialize? oldserializer = null;

                if (protoname != "UnionCmdNotify")
                {
                    if (!OldProtos.QueryCmdId.TryGetSerializer(protoname, out oldserializer))
                    {
                        Log.Erro($"Packet {protoname} from Client" +
                            $" has no record in oldcmdid.csv and dropped:---{Convert.ToHexString(packet)}",
                            $"PacketHandler({SessionId})");
                        return Array.Empty<byte>();
                    }

                    // KillSkillIssue fix
                    newjson = Program.skillcmd.ProcessWithRule(cmdid, false, newjson);

                    oldbody = oldserializer.SerializeFromJson(newjson);
                }
                else oldbody = UnionCmds.Shift(newjson);
                #endregion

                #region Notify
                if (protoname == "GetPlayerTokenReq")
                {
                    GetPlayerTokenReqNotify(newjson);
                }
                #endregion

                #region Record Packet
                if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                {
                    PacketRecord record = new PacketRecord(protoname, packetCounts, cmdid, true, 
                        packet, oldbody) { newjsonContent = newjson };
                    if (oldserializer != null)
                        // Protoshift not handled here but in other Fixs
                        SkillIssueDetect.StartHandleNewPacket(record, newbody: bodyfrom, oldbody: oldbody,
                            newjson, newserializer, oldserializer, SessionId);
                    lock (records)
                    {
                        records[packetCounts % PacketRecordLimits] = record;
                        packetCounts++;
                    }
                }
                #endregion

                #region Build New Packet
                int rtnpacketLength = body_offset + oldbody.Length + 2;
                byte[] rtn = new byte[rtnpacketLength];
                Array.Copy(packet, 0, rtn, 0, body_offset);
                rtn.SetUInt16(2, (ushort)OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname));
                rtn.SetUInt32(2 + 2 + 2, (uint)oldbody.Length);
                Array.Copy(oldbody, 0, rtn, body_offset, oldbody.Length);
                rtn.SetUInt16(rtnpacketLength - 2, 0x89AB);

                if (Verbose)
                {
                    Log.Info($"Send packet {protoname} with " +
                        $"CmdId:{OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                        $"to Server:---{Convert.ToHexString(rtn)}",
                        $"PacketHandler({SessionId})");
                }

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
                    return Array.Empty<byte>();
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

                #region Special Fix
                if (ExtraFix.NeedSpecialHandle(cmdid, isNewCmdid))
                {
                    var genbody = ExtraFix.SpecialHandle(cmdid, isNewCmdid, bodyfrom);
                    #region Record Packet
                    if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                    {
                        lock (records)
                        {
                            records[packetCounts % PacketRecordLimits] = new PacketRecord
                                (protoname, packetCounts, cmdid, false, packet, genbody)
                            {
                                dataLostSign = false,
                                oldjsonContent = oldjson,
                                newjsonContent = "ExtraFix Applied - Not Enabled"
                            };
                            packetCounts++;
                        }
                    }
                    #endregion
                    #region Build New Packet
                    int rtn_packetLength = body_offset + genbody.Length + 2;
                    byte[] rtn_packet = new byte[rtn_packetLength];
                    Array.Copy(packet, 0, rtn_packet, 0, body_offset);
                    rtn_packet.SetUInt16(2, (ushort)NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname));
                    rtn_packet.SetUInt32(2 + 2 + 2, (uint)genbody.Length);
                    Array.Copy(genbody, 0, rtn_packet, body_offset, genbody.Length);
                    rtn_packet.SetUInt16(rtn_packetLength - 2, 0x89AB);

                    if (Verbose)
                    {
                        Log.Info($"Send packet {protoname} with " +
                            $"CmdId:{NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                            $"to Client:---{Convert.ToHexString(rtn_packet)}",
                            $"PacketHandler({SessionId})");
                    }

                    return rtn_packet;
                    #endregion
                }
                #endregion

                #region Protoshift
                if (!NewProtos.QueryCmdId.TryGetSerializer(protoname, out var newserializer))
                {
                    Log.Erro($"Packet {protoname} from Server" +
                        $" has no record in newcmdid.csv and dropped:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                    return Array.Empty<byte>();
                }

                // KillSkillIssue fix
                oldjson = Program.skillcmd.ProcessWithRule(cmdid, true, oldjson);

                byte[] newbody = newserializer.SerializeFromJson(oldjson);
                string newjson = newserializer.DeserializeToJson(newbody);
                #endregion

                #region Notify
                if (protoname == "GetPlayerTokenRsp")
                {
                    GetPlayerTokenRspNotify(oldjson);
                }
                #endregion

                #region Record Packet
                if ((protoname != "PingReq" && protoname != "PingRsp") || RecordPingPackets)
                {
                    PacketRecord record = new PacketRecord(protoname, packetCounts, cmdid, true,
                        packet, newbody)
                    { oldjsonContent = oldjson };
                    if (oldserializer != null)
                        // Protoshift not handled here but in other Fixs
                        SkillIssueDetect.StartHandleOldPacket(record, oldbody: bodyfrom, newbody: newbody, 
                            oldjson, oldserializer, newserializer, SessionId);
                    lock (records)
                    {
                        records[packetCounts % PacketRecordLimits] = record;
                        packetCounts++;
                    }
                }
                #endregion

                #region Build New Packet
                int rtnpacketLength = body_offset + newbody.Length + 2;
                byte[] rtn = new byte[rtnpacketLength];
                Array.Copy(packet, 0, rtn, 0, body_offset);
                rtn.SetUInt16(2, (ushort)NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname));
                rtn.SetUInt32(2 + 2 + 2, (uint)newbody.Length);
                Array.Copy(newbody, 0, rtn, body_offset, newbody.Length);
                rtn.SetUInt16(rtnpacketLength - 2, 0x89AB);
                if (Verbose)
                {
                    Log.Info($"Send packet {protoname} with " +
                        $"CmdId:{NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                        $"to Client:---{Convert.ToHexString(rtn)}",
                        $"PacketHandler({SessionId})");
                }

                return rtn;
                #endregion
            }
            #endregion
        }

        protected byte[] client_seed;
        protected byte[] server_seed;

#pragma warning disable CS8604 // 引用类型参数可能为 null。
        private void GetPlayerTokenReqNotify(string messageJson)
        {
            uint key_id = (uint)Tools.GetFieldFromJson(messageJson, "keyId").GetInt32();
            client_seed = Resources.SPri[key_id].RsaDecrypt(
                Convert.FromBase64String(Tools.GetFieldFromJson(messageJson, "clientRandKey").GetString()),
                RSAEncryptionPadding.Pkcs1)
                .Fill0(8);
        }

        private void GetPlayerTokenRspNotify(string messageJson)
        {
            uint key_id = (uint)Tools.GetFieldFromJson(messageJson, "keyId").GetInt32();
            server_seed = Resources.CPri[key_id].RsaDecrypt(
                Convert.FromBase64String(Tools.GetFieldFromJson(messageJson, "serverRandKey").GetString()),
                RSAEncryptionPadding.Pkcs1)
                .Fill0(8);
            ulong encrypt_seed = server_seed.GetUInt64(0) ^ client_seed.GetUInt64(0);
            XorKey = Generate4096KeyByMT19937(encrypt_seed);
            Log.Info($"IMPORTANT: New XOR Key built{Environment.NewLine}" +
                $"-----BEGIN HEX New 4096 XOR Key-----{Environment.NewLine}" +
                Convert.ToHexString(XorKey) +
                $"{Environment.NewLine}-----END HEX New 4096 XOR Key-----", $"HandlerSession({SessionId})");
        }
#pragma warning restore CS8604 // 引用类型参数可能为 null。

        /// <summary>
        /// Used for special UnionCmdNotify shifting.
        /// </summary>
        /// <param name="newjson"></param>
        /// <returns></returns>
        #endregion

        #region Crypto
        private void XorDecrypt(ref byte[] encrypted, int offset = 0, int length = -1, bool fallbackToDispatchKey = false)
        {
            if (length == -1) length = encrypted.Length;
            else length = Math.Min(length, encrypted.Length - offset);
            for (int i = offset; i < offset + length; i++)
            {
                if (!fallbackToDispatchKey) encrypted[i] = (byte)(encrypted[i] ^ XorKey[i % XorKey.Length]);
                else encrypted[i] = (byte)(encrypted[i] ^ Resources.dispatchKey[i % Resources.dispatchKey.Length]);
            }
        }

        static readonly JsonSerializer serializer = new();

        public static string ConvertJsonString(string str)
        {
            //格式化json字符串
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new(tr);
            object? obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new();
                JsonTextWriter jsonWriter = new(textWriter)
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
                        orderby record.Id
                        select record;
            return query.ToList();
        }

        public List<int> QueryPacketRecordIds(string protoname)
        {
            var query = from record in records
                        where record.PacketName == protoname
                        orderby record.Id
                        select record.Id;
            return query.ToList();
        }

        public PacketRecord QueryPacketRecordById(int id) => records[id % PacketRecordLimits];
    }
}
