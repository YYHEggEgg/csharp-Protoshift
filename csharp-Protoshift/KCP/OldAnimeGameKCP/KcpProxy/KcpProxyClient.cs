using csharp_Protoshift.Obsoleted.AnimeGameKCP;
using System.Diagnostics;
using System.Net;
using YSFreedom.Common.Net.Obsoleted;

namespace csharp_Protoshift.Obsoleted.KcpProxy
{
    public class KcpProxyClient : KCPClient
    {
        public KcpProxyClient(IPEndPoint ipEp, uint conv = 0, uint token = 0, uint connectData = 0x499602D2)
            : base(ipEp)
        {
            server = new(conv, token, connectData);
            server.Timeout = 10000;
            server.Output = data =>
            {
                return udpSock.Send(data, data.Length);
            };
        }

        public KCP.Handshake GetSendbackHandshake()
        {
            Debug.Assert(server.State == KCP.ConnectionState.CONNECTED);
            return new KCP.Handshake(KCP.Handshake.MAGIC_SEND_BACK_CONV, 
                server.Conv, server.Token, server.ConnectData);
        }
    }
}
