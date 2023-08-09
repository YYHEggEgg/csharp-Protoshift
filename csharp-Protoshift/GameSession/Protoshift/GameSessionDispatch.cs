#if !PROXY_ONLY_SERVER
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
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
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
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
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
        #endregion

        #region Packet Record Saver
#if RECORD_ALL_PKTS_FOR_REPLAY
        private static StreamWriter packet_logwriter;
        static GameSessionDispatch()
        {
            FileInfo pastPacketLog = new("logs/latest.packet.log");
            if (pastPacketLog.Exists)
            {
                pastPacketLog.MoveTo($"logs/{pastPacketLog.CreationTime:yyyy-MM-dd_HH-mm-ss}.packet.log");
            }
            packet_logwriter = new("logs/latest.packet.log", true);
            packet_logwriter.AutoFlush = false;
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
                session.ExportXlsxRecord($"logs/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.debug.packetspeed_{conv}.xlsx");

#if RECORD_ALL_PKTS_FOR_REPLAY
                foreach (var pkt in session.PacketRecords)
                {
                    packet_logwriter.WriteLine(pkt.ToString());
                }
#endif
            }
        }

        public static void CloseServer()
        {
            Closed = true;
            foreach (var conv in sessions.Keys)
            {
                DestroySession(conv);
            }
#if RECORD_ALL_PKTS_FOR_REPLAY
            packet_logwriter.Flush();
            packet_logwriter.Dispose();
#endif
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
    }
}
#endif