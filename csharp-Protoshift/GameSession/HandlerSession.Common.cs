using csharp_Protoshift.resLoader;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    public partial class HandlerSession
    {
        protected byte[] _xorKey;
        /// <summary>
        /// XOR key used to decrypt packet. Usually have a length of 4096.
        /// </summary>
        public byte[] XorKey { get => _xorKey; }
        private uint _sessionId;
        public uint SessionId { get => _sessionId; }
        protected uint _uid = 0;
        public uint Uid { get => _uid; }
        public IPEndPoint? remoteIp { get; set; }
    
        /// <summary>
        /// Whether records contain PingReq/PingRsp packets. Only apply to packets received after modified.
        /// </summary>
        public bool RecordPingPackets { get; set; }
        /// <summary>
        /// Whether output packets in the console.
        /// </summary>
        public bool Verbose { get; set; }
        public int packetCounts { get; protected set; }

        /// <summary>
        /// Initializer
        /// </summary>
        /// <param name="packetLimits">The maximum count of packets reserved for analyzing and resending. Default is 5000.</param>
        public HandlerSession(uint sessionId)
        {
            _xorKey = Resources.dispatchKey;
            Debug.Assert(_xorKey.Length == 4096);
            _sessionId = sessionId;
            client_seed = server_seed = Array.Empty<byte>();
            // Verbose = true;
            Verbose = false;
#if !PROTOSHIFT_BENCHMARK
            if (GameSessionDispatch.PlayerStatLogger != null)
            {
                _player_statlog = GameSessionDispatch.PlayerStatLogger
                    .GetChannel(sessionId.ToString());
            }
#endif

            ConfigureInitialNotifyList();
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
                    $"PacketHandler({_sessionId})");
                XorDecrypt(ref packet, 0, packet.Length);
                Log.Info("Fall back to dispatchKey", $"PacketHandler({_sessionId})");
                fallback = true;
                XorDecrypt(ref packet, 0, 2, fallback);
                magic_start = packet.GetUInt16(0);
                if (magic_start != 0x4567)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    Log.Info("Success decoded after XOR Key Fallback, continue", $"PacketHandler({_sessionId})");
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
                    $"PacketHandler({_sessionId})");
                throw new InvalidOperationException();
            }

            if (packet.Length >= body_offset + body_length + 2 + 2)
            {
                int next_magic_start = packet.GetUInt16(body_offset + (int)body_length + 2);
                if (next_magic_start == 0x4567)
                    Log.Warn("Multiple packets detected in one request. Program need optimize.",
                        $"PacketHandler({_sessionId})");
            }

            var rtn = GetPacketResult(packet, cmdid, isNewCmdid, 
                head_offset, head_length, body_offset, body_length);
            Debug.Assert(rtn.GetUInt16(rtn.Length - 2) == 0x89AB);

            if (!isNewCmdid && cmdid == OldProtos.AskCmdId.GetCmdIdFromProtoname("GetPlayerTokenRsp"))
                XorDecrypt(ref rtn, fallbackToDispatchKey: true);
            else XorDecrypt(ref rtn, fallbackToDispatchKey: fallback);
            return rtn;
        }

        #region Player Stat log method
        private LoggerChannel? _player_statlog;

        public void PushPlayerStatLog(string category, string? description, string? data,
            LogLevel logLevel = LogLevel.Information)
        {
            if (_player_statlog == null) return;

            _player_statlog.LogPush($"{_uid}|{category}|{description}|{data}", logLevel);
        }
        #endregion

        #region Crypto
        private void XorDecrypt(ref byte[] encrypted, int offset = 0, int length = -1, bool fallbackToDispatchKey = false)
        {
            if (length == -1) length = encrypted.Length;
            else length = Math.Min(length, encrypted.Length - offset);
            for (int i = offset; i < offset + length; i++)
            {
                if (!fallbackToDispatchKey) encrypted[i] = (byte)(encrypted[i] ^ _xorKey[i % _xorKey.Length]);
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
        #endregion
    }
}