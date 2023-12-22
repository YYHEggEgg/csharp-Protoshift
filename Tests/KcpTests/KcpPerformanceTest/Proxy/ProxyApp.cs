using csharp_Protoshift.GameSession;
using csharp_Protoshift.MhyKCP.Proxy;
using System.Net;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.App
{
    public class ProxyApp
    {
        public static void Start()
        {
#if CONNECT_SERVERONLY
            throw new NotImplementedException("Proxy should not be launched in CONNECT_SERVERONLY mode.");
#else
            KcpProxyServer proxy = new(new IPEndPoint(IPAddress.Loopback, Constants.UDP_PROXY_PORT),
                new IPEndPoint(IPAddress.Loopback, Constants.UDP_SERVER_PORT));
            ProxyHandlers handlers = new ProxyHandlers
            {
                OnServerPacketArrival = GameSessionDispatch.HandleServerPacket,
                OnClientPacketArrival = GameSessionDispatch.HandleClientPacket,
                ServerPacketOrdered = GameSessionDispatch.ServerPacketOrdered,
                ClientPacketOrdered = GameSessionDispatch.ClientPacketOrdered
            };
            Util.RunBackground(() => proxy.StartProxy(handlers), "ProxyApp has met a fatal error. ", nameof(ProxyApp));
            Log.Info($"KcpProxyServer started on 127.0.0.1:{Constants.UDP_PROXY_PORT}", nameof(ProxyApp));
#endif
        }
    }
}
