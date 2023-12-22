using csharp_Protoshift.MhyKCP.Test.Analysis;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using Force.Crc32;
using System.Collections.Concurrent;
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
        public static byte[]? HandleServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
#if DEBUG
            uint checksum_before = Crc32Algorithm.Compute(data);
#endif
            BasePacket basePacket = new(data);
            ProxyDataChannel.PushReceivedServerPacket(basePacket);
            try
            {
                var res = sessions[conv].HandlePacket(data, false);
#if DEBUG
                uint checksum_after = Crc32Algorithm.Compute(res);
                if (checksum_before != checksum_after)
                {
                    _ = Task.Run(() => Log.Warn($"Checksum test failed for readonly proxy! \nbefore: (CRC32: {checksum_before}) {Convert.ToHexString(data)}\nafter: (CRC32: {checksum_after}) {Convert.ToHexString(res)}", nameof(HandleServerPacket)));
                }
#endif
                ProxyDataChannel.PushSentServerPacket(basePacket);
                basePacket.Dispose();
                return res;
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
#if DEBUG
            uint checksum_before = Crc32Algorithm.Compute(data);
#endif
            BasePacket basePacket = new(data);
            ProxyDataChannel.PushReceivedClientPacket(basePacket);
            try
            {
                var res = sessions[conv].HandlePacket(data, true);
#if DEBUG
                uint checksum_after = Crc32Algorithm.Compute(res);
                if (checksum_before != checksum_after)
                {
                    _ = Task.Run(() => Log.Warn($"Checksum test failed for readonly proxy! \nbefore: (CRC32: {checksum_before}) {Convert.ToHexString(data)}\nafter: (CRC32: {checksum_after}) {Convert.ToHexString(res)}", nameof(HandleServerPacket)));
                }
#endif
                ProxyDataChannel.PushSentClientPacket(basePacket);
                basePacket.Dispose();
                return res;
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

        public static bool ServerPacketOrdered(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].PacketOrdered(data, true);
        }

        public static bool ClientPacketOrdered(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].PacketOrdered(data, false);
        }
        #endregion
    
        #region Packet Record Saver
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
            foreach (var conv in sessions.Keys)
            {
                DestroySession(conv);
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
    }
}
