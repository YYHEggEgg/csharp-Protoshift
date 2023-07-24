#if PROXY_ONLY_SERVER

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;
using Force.Crc32;
using System.Net;

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

        public static void SessionDestroyed(uint conv)
        {
            cancelledSessions.Add(conv);
            sessions.Remove(conv, out _);
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
        private static StreamWriter packet_logwriter;
        private static object packet_log_lock = "miHomo Save The World";
        static GameSessionDispatch()
        {
            FileInfo pastPacketLog = new($"logs/latest.packet.log");
            if (pastPacketLog.Exists)
            {
                pastPacketLog.MoveTo($"logs/{pastPacketLog.CreationTime:yyyy-MM-dd_HH-mm-ss}.packet.log");
            }
            packet_logwriter = new($"logs/latest.packet.log", true);
            packet_logwriter.AutoFlush = false;
        }

        public static async Task DestroySession(uint conv)
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

            lock (packet_log_lock)
            {
                foreach (var pkt in session.PacketRecords)
                {
                    packet_logwriter.WriteLine($"{pkt.packetTime:yyyy/MM/dd HH:mm:ss.fffffff}|{pkt.PacketName}|{pkt.CmdId}|{pkt.sentByClient}|{Convert.ToBase64String(pkt.data, pkt.data_offset, pkt.data_length)}");
                }
            }

            await Task.CompletedTask;
        }

        public static void CloseServer()
        {
            Closed = true;
            List<Task> tasks = new();
            foreach (var conv in sessions.Keys)
            {
                tasks.Add(DestroySession(conv));
            }
            Task.WaitAll(tasks.ToArray());
            packet_logwriter.Flush();
            packet_logwriter.Dispose();
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