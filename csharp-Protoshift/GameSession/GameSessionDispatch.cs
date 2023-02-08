using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession
{
    internal static class GameSessionDispatch
    {
        /// <summary>
        /// Session dictionary. UInt is Conv id.
        /// </summary>
        public static Dictionary<uint, HandlerSession> sessions = new();

        public static byte[] HandleServerPacket(byte[] data, uint conv)
        {
            if (!sessions.ContainsKey(conv))
                sessions.Add(conv, new(conv));
            try
            {
                return sessions[conv].HandlePacket(data, false);
            }
#if DEBUG
            catch (Exception ex) 
            {
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
                return new byte[0]; 
            }
#else
            catch { return new byte[0]; }
#endif
        }

        public static byte[] HandleClientPacket(byte[] data, uint conv)
        {
            if (!sessions.ContainsKey(conv))
                sessions.Add(conv, new(conv));
            try
            {
                return sessions[conv].HandlePacket(data, true);
            }
#if DEBUG
            catch (Exception ex)
            {
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
                return new byte[0];
            }
#else
            catch { return new byte[0]; }
#endif
        }
    }
}
