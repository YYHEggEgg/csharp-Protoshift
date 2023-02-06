using csharp_Protoshift.AnimeGameKCP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Net;

namespace csharp_Protoshift.KcpProxy
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
