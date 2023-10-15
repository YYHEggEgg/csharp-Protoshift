using csharp_Protoshift.Commands.Windy;
using csharp_Protoshift.Configuration;
using System.Collections.Concurrent;
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

        internal static OnlineExecWindyMode_v1_0_0 OnlineExecWindyMode = Config.Global.WindyConfig.OnlineExecWindyMode;
        private static string? onlineExecWindyLua = Config.Global.WindyConfig.OnlineExecWindyLua;

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
            if (OnlineExecWindyMode == OnlineExecWindyMode_v1_0_0.OnKcpConnect
                && onlineExecWindyLua != null)
            {
                _ = Task.Run(async () =>
                {
                    try
                    {
                        await InjectOnlineExecuteWindy(conv);
                        Log.Info($"Successfully sent windy lua: {Path.GetFileNameWithoutExtension(onlineExecWindyLua)}" +
                            $"to session id: {conv}, IP: {ipEp}.", "windyOnKcpConnect_AsyncTask");
                    }
                    catch (Exception ex)
                    {
                        LogTrace.WarnTrace(ex, "windyOnKcpConnect_AsyncTask", 
                            $"Windy auto-execute failed. ");
                    }
                });
            }
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

        public static async Task InjectOnlineExecuteWindy(uint conv)
        {
            if (onlineExecWindyLua == null) return;
            InjectPacketToClient(conv, nameof(OldProtos.WindSeedClientNotify), null,
                await WindyLuacManager.Instance.CompileSendableWindyProtobuf(onlineExecWindyLua));
        }
        #endregion

        #region Packet Record Saver
#if !PROTOSHIFT_BENCHMARK
        internal static BaseLogger? PlayerStatLogger;
        internal static BaseLogger? PacketLogger;
        static GameSessionDispatch()
        {
            if (Config.Global.EnableFullPacketLog)
            {
                PacketLogger = new BaseLogger(new LoggerConfig(
                    max_Output_Char_Count: 16 * 1024,
                    use_Console_Wrapper: true,
                    use_Working_Directory: true,
                    global_Minimum_LogLevel: LogLevel.Information,
                    console_Minimum_LogLevel: LogLevel.None,
                    debug_LogWriter_AutoFlush: false,
                    enable_Detailed_Time: true), new LogFileConfig
                    {
                        AutoFlushWriter = true,
                        IsPipeSeparatedFile = true,
                        MaximumLogLevel = LogLevel.Information,
                        MinimumLogLevel = LogLevel.Information,
                        FileIdentifier = "packet"
                    });
            }
            if (Config.Global.EnablePlayerStatLog)
            {
                PlayerStatLogger = new BaseLogger(new LoggerConfig(
                    max_Output_Char_Count: 16 * 1024,
                    use_Console_Wrapper: true,
                    use_Working_Directory: true,
#if DEBUG
                    global_Minimum_LogLevel: LogLevel.Debug,
#else
                    global_Minimum_LogLevel: LogLevel.Information,
#endif
                    console_Minimum_LogLevel: LogLevel.None,
                    debug_LogWriter_AutoFlush: false,
                    enable_Detailed_Time: true), new LogFileConfig
                    {
                        AutoFlushWriter = true,
                        IsPipeSeparatedFile = true,
                        MaximumLogLevel = LogLevel.Error,
#if DEBUG
                        MinimumLogLevel = LogLevel.Debug,
#else
                        MinimumLogLevel = LogLevel.Information,
#endif
                        FileIdentifier = "player.stat"
                    });
                PlayerStatLogger.Info($"UID|Status category|Description|--[Any other Data]--", "Conv ID");
            }
        }
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
            if (OnlineExecWindyMode == OnlineExecWindyMode_v1_0_0.None || onlineExecWindyLua == null
                || OnlineExecWindyMode == OnlineExecWindyMode_v1_0_0.Disabled)
                return;
            try
            {
                await WindyLuacManager.Instance.CompileSendableWindyProtobuf(onlineExecWindyLua);
            }
            catch (Exception ex)
            {
                LogTrace.WarnTrace(ex, nameof(ValidateWindyAutoExecute),
                    $"Windy auto-execute pre-validation failed.");
                Log.Warn($"Please check whether your configuration of WindyConfig is valid " +
                    $"and your windy script obeys BASIC lua grammar.", nameof(ValidateWindyAutoExecute));
            }
        }
    }
}
