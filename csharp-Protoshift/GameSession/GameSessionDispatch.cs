using csharp_Protoshift.Commands.Windy;
using csharp_Protoshift.Configuration;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession
{
    internal static class GameSessionDispatch
    {
        /// <summary>
        /// Session dictionary. UInt is Conv id.
        /// </summary>
        public static ConcurrentDictionary<uint, HandlerSession> sessions = new();
        public static ConcurrentBag<uint> cancelledSessions = new();
        public static bool Closed { get; private set; }

        #region Packet Handlers
        public static void SessionCreated(uint conv, IPEndPoint ipEp)
        {
            if (!cancelledSessions.Contains(conv))
            {
                HandlerSession session = new(conv);
                if (sessions.TryAdd(conv, session))
                {
                    session.remoteIp = ipEp;
                }
                else sessions[conv].remoteIp = ipEp;
            }
            BackgroundInjectOnlineExecuteWindys(conv,
                OnlineExecWindyMode_v1_0_0.OnKcpConnect, "windyOnKcpConnect");
        }

        public static byte[]? HandleServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            try
            {
#if DEBUG
                // uint checksum_before = Crc32Algorithm.Compute(data);
#endif
                var rtn = sessions[conv].HandlePacket(data, false);
#if DEBUG
                // uint checksum_after = Crc32Algorithm.Compute(rtn);
#endif
                return rtn;
            }
#if DEBUG
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, "GameSessionDispatch:Server",
                    $"Exception happened when handling packets. ");
                return null;
            }
#else
            catch { return null; }
#endif
        }

        public static byte[]? HandleClientPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            try
            {
#if DEBUG
                // uint checksum_before = Crc32Algorithm.Compute(data);
#endif
                var rtn = sessions[conv].HandlePacket(data, true);
#if DEBUG
                // uint checksum_after = Crc32Algorithm.Compute(rtn);
#endif
                return rtn;
            }
#if DEBUG
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, "GameSessionDispatch:Server",
                    $"Exception happened when handling packets. ");
                return null;
            }
#else
            catch { return null; }
#endif
        }

        public static bool OrderedServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].OrderedPacket(data, true);
        }

        public static bool OrderedClientPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].OrderedPacket(data, false);
        }
        #endregion

        #region Inject Packet utils
        public static byte[] ConstructPacketSendToServer(uint conv, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            AssertSessionExists(conv);
            return sessions[conv].ConstructPacket(false, protoname, packetHead, packetBody);
        }

        public static byte[] ConstructPacketSendToClient(uint conv, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            AssertSessionExists(conv);
            return sessions[conv].ConstructPacket(true, protoname, packetHead, packetBody);
        }

        public static void InjectPacketToClient(uint conv, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            var content = ConstructPacketSendToClient(conv, protoname, packetHead, packetBody);
            Program.ProxyServer.SendPacketToClient(conv, content);
        }

        public static void InjectPacketToServer(uint conv, string protoname, byte[]? packetHead, byte[] packetBody)
        {
            var content = ConstructPacketSendToServer(conv, protoname, packetHead, packetBody);
            Program.ProxyServer.SendPacketToServer(conv, content);
        }
        #endregion

        #region Windy Execute
        internal static ReadOnlyDictionary<OnlineExecWindyMode_v1_0_0, ReadOnlyCollection<OnlineExecWindyInfo_v1_0_1>>?
            ExecuteWindyMap;

        public static async Task InjectOnlineExecuteWindys(uint conv, OnlineExecWindyMode_v1_0_0 condition, string? sender)
        {
            if (ExecuteWindyMap == null) return;
            if (!ExecuteWindyMap.TryGetValue(condition, out var list)) return;
            foreach (var item in list)
            {
                try
                {
                    InjectPacketToClient(conv, nameof(OldProtos.WindSeedClientNotify), null,
                        await WindyLuacManager.CompileSendableWindyProtobuf(item.LuaFileName));
                }
                catch (Exception ex)
                {
                    LogTrace.WarnTrace(ex, sender, $"Windy auto-execute failed. ({item.LuaFileName})");
                }
            }
        }

        public static void BackgroundInjectOnlineExecuteWindys(uint conv, OnlineExecWindyMode_v1_0_0 condition, string? sender)
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(1500);
                await InjectOnlineExecuteWindys(conv, condition, $"{sender}_AsyncTask");
            });
        }
        #endregion

        #region Packet Record Saver
#if !PROTOSHIFT_BENCHMARK
        internal static BaseLogger? PlayerStatLogger;
        internal static BaseLogger? PacketLogger;
#endif

        private static object clearup_running_lck = "miHomo Save The World";
        public static void DestroySession(uint conv)
        {
            lock (clearup_running_lck)
            {
                if (!sessions.ContainsKey(conv)) return;
                sessions.TryRemove(conv, out HandlerSession? session);
                cancelledSessions.Add(conv);

                if (session == null)
                {
                    Log.Erro($"Session {conv} destroyed but null, probably not recorded!", "GameSessionDispatch");
                    return;
                }
            }
        }

        public static void CloseServer()
        {
            Closed = true;
            var _logger = Log.GetChannel(nameof(GameSessionDispatch));
            _logger.LogInfo($"Closing server...");
            foreach (var session in sessions)
            {
                var conv = session.Key;
                var remote_ip = session.Value.remoteIp;
                DestroySession(conv);
                try
                {
                    Program.ProxyServer.KickSession(conv, 6);
                    _logger.LogInfo($"Gracefully kicked online session {conv} on {remote_ip}.");
                }
                catch (Exception) { }
            }
        }
        #endregion

#if !PROTOSHIFT_BENCHMARK
        static GameSessionDispatch()
        {
            if (Config.Global.EnableFullPacketLog)
            {
                var customconf = Log.GlobalConfig;
                customconf.Global_Minimum_LogLevel = LogLevel.Information;
                customconf.Console_Minimum_LogLevel = LogLevel.None;
                customconf.Enable_Detailed_Time = true;
                PacketLogger = new BaseLogger(customconf, new LogFileConfig
                {
                    AutoFlushWriter = true,
                    IsPipeSeparatedFile = true,
                    MaximumLogLevel = LogLevel.Information,
                    MinimumLogLevel = LogLevel.Information,
                    FileIdentifier = "packet",
                    AllowAutoFallback = true,
                });
            }
            if (Config.Global.EnablePlayerStatLog)
            {
                var customconf = Log.GlobalConfig;
#if DEBUG
                customconf.Global_Minimum_LogLevel = LogLevel.Debug;
#else
                customconf.Global_Minimum_LogLevel = LogLevel.Information;
#endif
                customconf.Console_Minimum_LogLevel = LogLevel.None;
                customconf.Enable_Detailed_Time = true;
                PlayerStatLogger = new BaseLogger(customconf, new LogFileConfig
                {
                    AutoFlushWriter = true,
                    IsPipeSeparatedFile = true,
                    MaximumLogLevel = LogLevel.Error,
#if DEBUG
                    MinimumLogLevel = LogLevel.Debug,
#else
                    MinimumLogLevel = LogLevel.Information,
#endif
                    FileIdentifier = "player.stat",
                    AllowAutoFallback = true,
                });
                PlayerStatLogger.Info($"UID|Status category|Description|--[Any other Data]--", "Conv ID");
            }

            if (Config.Global.WindyConfig.OnlineExecWindys != null)
            {
                Dictionary<OnlineExecWindyMode_v1_0_0, ReadOnlyCollection<OnlineExecWindyInfo_v1_0_1>> res = new();
                foreach (var mode in Enum.GetValues<OnlineExecWindyMode_v1_0_0>())
                {
                    if (mode == OnlineExecWindyMode_v1_0_0.None) continue;
                    res.Add(mode, new(new List<OnlineExecWindyInfo_v1_0_1>(
                        from info in Config.Global.WindyConfig.OnlineExecWindys
                        where info.OnlineExecMode == mode
                        select info)));
                }
                ExecuteWindyMap = new(res);
            }
        }
#endif

        /// <summary>
        /// Invoke the static initializer and create latest.packet.log and latest.player.stat.log.
        /// </summary>
        public static void InitializeLogFiles() { }

        private static void AssertSessionExists(uint conv)
        {
            if (Closed) throw new OperationCanceledException("The server is closing.");
            if (!sessions.ContainsKey(conv))
            {
                if (!cancelledSessions.Contains(conv))
                    sessions.TryAdd(conv, new(conv));
                else throw new OperationCanceledException($"Session {conv} has been destroyed and no longer avaliable.");
            }
        }

        public static async Task ValidateWindyAutoExecute()
        {
            if (ExecuteWindyMap?.Any() != true)
                return;
            foreach (var windyfile in from list in ExecuteWindyMap.Values
                                      from item in list
                                      where item.OnlineExecMode != OnlineExecWindyMode_v1_0_0.Disabled
                                        && item.OnlineExecMode != OnlineExecWindyMode_v1_0_0.None
                                      select item.LuaFileName)
            {
                try
                {
                    await WindyLuacManager.CompileSendableWindyProtobuf(windyfile);
                }
                catch (Exception ex)
                {
                    LogTrace.WarnTrace(ex, nameof(ValidateWindyAutoExecute),
                        $"Windy auto-execute pre-validation failed. ({windyfile})");
                    Log.Warn($"Please check whether your configuration of WindyConfig is valid " +
                        $"and your windy script obeys BASIC lua grammar.", nameof(ValidateWindyAutoExecute));
                }
            }
        }
    }
}
