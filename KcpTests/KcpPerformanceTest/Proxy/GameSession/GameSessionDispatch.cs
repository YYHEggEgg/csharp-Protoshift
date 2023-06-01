﻿using csharp_Protoshift.MhyKCP.Test.Analysis;
using csharp_Protoshift.MhyKCP.Test.Protocol;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            BasePacket basePacket = new(data);
            ProxyDataChannel.PushReceivedServerPacket(basePacket);
            try
            {
                var res = sessions[conv].HandlePacket(data, false);
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
            BasePacket basePacket = new(data);
            ProxyDataChannel.PushReceivedClientPacket(basePacket);
            try
            {
                var res = sessions[conv].HandlePacket(data, true);
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

        public static bool IsUrgentServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].IsUrgentPacket(data, true);
        }

        public static bool IsUrgentClientPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].IsUrgentPacket(data, false);
        }
        #endregion
    
        #region Packet Record Saver
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
