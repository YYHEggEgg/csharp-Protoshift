using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    public class KcpProxyClient : KCPClient
    {
        public KcpProxyClient(IPEndPoint ipEp, uint conv = 0, uint token = 0, uint connectData = 0x499602D2)
            : base(ipEp)
        {
            server = new(conv, token, connectData);
            server.Timeout = 10000;
            server.OutputCallback = new SocketUdpKcpCallback(udpSock);
            _updatelock = new($"{nameof(KcpProxyClient)}_{nameof(BackgroundUpdate)}");
            _recvlock = new($"{nameof(KcpProxyClient)}_{nameof(Receive)}");
        }

        public Handshake GetSendbackHandshake()
        {
            Debug.Assert(server.State == MhyKcpBase.ConnectionState.CONNECTED);
            return new Handshake(Handshake.MAGIC_SEND_BACK_CONV, 
                server.Conv, server.Token, server.ConnectData);
        }
    }
}
