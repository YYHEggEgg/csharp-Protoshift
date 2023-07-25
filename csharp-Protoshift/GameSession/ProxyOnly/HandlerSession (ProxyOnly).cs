﻿#if PROXY_ONLY_SERVER

using AssetLib.Utils;
using csharp_Protoshift.GameSession.SpecialFixs;
using csharp_Protoshift.resLoader;
using csharp_Protoshift.SkillIssue;
using Google.Protobuf;
using Newtonsoft.Json;
using OfficeOpenXml;
using OfficeOpenXml.ExternalReferences;
using Org.BouncyCastle.Crypto.Prng;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net;
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
        public ConcurrentBag<PacketRecord> PacketRecords { get; private set; } = new();
        public uint SessionId { get; private set; }
        public IPEndPoint remoteIp { get; set; }

        /// <summary>
        /// Whether records contain PingReq/PingRsp packets. Only apply to packets received after modified.
        /// </summary>
        public bool RecordPingPackets { get; set; }
        /// <summary>
        /// Whether output packets in the console.
        /// </summary>
        public bool Verbose { get; set; }
        public int packetCounts { get; protected set; }

        #region Record Packet Protoshift time cost
        public ConcurrentBag<TimeRecord> TimeRecords { get; } = new();

        public struct TimeRecord
        {
            public string protoname { get; set; }
            public bool fromClient { get; set; }
            public long handleMilliseconds { get; set; }
            public int packetSize { get; set; }
        }

        private void SubmitTimeRecord(string protoname, bool isNewCmdid, long handleMilliseconds, int packetSize)
        {
            TimeRecords.Add(new TimeRecord
            {
                protoname = protoname,
                fromClient = isNewCmdid,
                handleMilliseconds = handleMilliseconds,
                packetSize = packetSize
            });
        }

        // Generated by ChatGPT, not tested
        // Need EPPlus nuget reference
        public void ExportXlsxRecord(string filePath)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Records");
                worksheet.Cells.LoadFromCollection(TimeRecords, true);
                package.SaveAs(new FileInfo(filePath));
            }
        }
        #endregion 

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="packetLimits">The maximum count of packets reserved for analyzing and resending. Default is 5000.</param>
        public HandlerSession(uint sessionId, int packetLimits = 5000)
        {
            XorKey = Resources.dispatchKey;
            Debug.Assert(XorKey.Length == 4096);
            SessionId = sessionId;
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
            Debug.Assert(rtn.GetUInt16(rtn.Length - 2) == 0x89AB);

            if (!isNewCmdid && cmdid == OldProtos.QueryCmdId.GetCmdIdFromProtoname("GetPlayerTokenRsp"))
                XorDecrypt(ref rtn, fallbackToDispatchKey: true);
            else XorDecrypt(ref rtn, fallbackToDispatchKey: fallback);
            return rtn;
        }

        public bool OrderedPacket(byte[] packet, bool isNewCmdid)
        {
            return true;
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
            // var head_offset = sizeof(ushort) * 3 + sizeof(uint);
            // OldProtos.PacketHead packetHead = OldProtos.PacketHead.Parser.ParseFrom(packet, head_offset, packet.GetUInt16(sizeof(ushort) * 2));
            // if (Verbose)
            //     Log.Dbug($"Received packet head from {(isNewCmdid ? "Client" : "Server")} ({packet.GetUInt16(sizeof(ushort) * 2)} bytes) --- {packetHead}");

            // packetHead.SentMs = 0;
            // packetHead.ClientSequenceId = 0;
            // var newhead = packetHead.ToByteArray();

            #region Receive and read
            if (!OldProtos.QueryCmdId.TryGetSerializer(cmdid, out var oldserializer))
            {
                Log.Erro($"Packet with CmdId:{cmdid} from Server" +
                    $" has no record in oldcmdid.csv and skipped.",
                    $"PacketHandler({SessionId})");
                ProtoshiftWatch.Stop();
                PacketRecords.Add(new($"UnkCMD_{cmdid}", cmdid, isNewCmdid, packet, body_offset, (int)body_length));
                SubmitTimeRecord($"UnkCMD_{cmdid}", false, ProtoshiftWatch.ElapsedMilliseconds, packet.Length);
                // return Array.Empty<byte>();
                return packet;
            }
            string protoname = oldserializer.Protoname;

            if (protoname == "GetPlayerTokenReq" || protoname == "GetPlayerTokenRsp")
            {
                string oldjson;
                try
                {
                    oldjson = oldserializer.DeserializeToJson(packet, body_offset, (int)body_length);
                }
                catch
                {
                    Log.Warn($"Invalid protocol packet: proto={protoname}, cmd={cmdid}, len={(int)body_length}, pkt={Convert.ToHexString(packet)}");
                    throw;
                }
                if (Verbose)
                {
                    Log.Info($"Recv packet with CmdId:{cmdid} from " +
                        $"Server:---{Convert.ToHexString(packet)}",
                        $"PacketHandler({SessionId})");
                }
                if (protoname == "GetPlayerTokenReq")
                {
                    try
                    {
                        // string oldjson = oldserializer.DeserializeToJson(bodyfrom);
                        GetPlayerTokenReqNotify(oldjson);
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"GetPlayerTokenReqNotify failed, cmd={cmdid}, json_content={oldjson}, body={Convert.ToBase64String(packet, body_offset, (int)body_length)}");
                        throw;
                    }
                }
                if (protoname == "GetPlayerTokenRsp")
                {
                    try
                    {
                        // string oldjson = oldserializer.DeserializeToJson(bodyfrom);
                        GetPlayerTokenRspNotify(oldjson);
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"GetPlayerTokenRspNotify failed, cmd={cmdid}, json_content={oldjson}, body={Convert.ToBase64String(packet, body_offset, (int)body_length)}");
                        throw;
                    }
                }
            }
            #endregion

            ProtoshiftWatch.Stop();

            var body_arr = new byte[body_length];
            Buffer.BlockCopy(packet, body_offset, body_arr, 0, (int)body_length);
            PacketRecords.Add(new(protoname, cmdid, isNewCmdid, body_arr, 0, (int)body_length));
            SubmitTimeRecord(protoname, false, ProtoshiftWatch.ElapsedMilliseconds, packet.Length);
#if DEBUG
            if (ProtoshiftWatch.ElapsedMilliseconds > 15)
            {
                Log.Warn($"Handling packet: {protoname} ({packet.Length} bytes) exceeded ordered packet required time ({ProtoshiftWatch.ElapsedMilliseconds}ms > 15ms)", $"PacketHandler({SessionId})");
            }
#endif
            return packet;
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

        #region Packet Create
        public byte[] ConstructPacket(bool isNewCmdid, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            var cmdid = OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoname);
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
                    $"CmdId:{NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoname)} " +
                    $"for {(isNewCmdid ? "Client" : "Server")}:---{Convert.ToHexString(rtn)}",
                $"PacketConstructor({SessionId})");
            }
            return rtn;
        }
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
#if !PROXY_ONLY_SERVER
        public List<PacketRecord> QueryPacketRecords(string protoname)
        {
            var query = from record in records
                        where record?.PacketName == protoname
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
#endif
    }
}
#endif