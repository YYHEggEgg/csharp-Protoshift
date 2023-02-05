using csharp_Protoshift.AnimeGameKCP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Native;
using YSFreedom.Common.Net;
using YSFreedom.Common.Util;

namespace csharp_Protoshift.KcpProxy
{
    /// <summary>
    /// KcpProxy is not a client
    /// </summary>
    public class KcpProxy : KCP
    {
        public KcpProxyClient? sendClient;
        public IPEndPoint sendToAddress;

        public KcpProxy(IPEndPoint sendToAddress, uint conv = 0, uint token = 0,
            Func<byte[], byte[]>? PacketHandler = null)
            : base(conv, token)
        {
            this.sendToAddress = sendToAddress;
            this.PacketHandler = PacketHandler ?? (data => data);
        }

        public new int Input(byte[] buffer)
        {
            switch (_State)
            {
                case ConnectionState.DISCONNECTED:
                case ConnectionState.CLOSED:
                    throw new SocketException(10057); // Not connected
                case ConnectionState.CONNECTED:
                    {
                        Log.Dbug($"ConnectedNotify, buf = {Convert.ToHexString(buffer)}", "KcpProxy");
                        if (buffer.Length == 20) // Possibly a "disconnect" packet
                        {
                            var disconn = new Handshake();
                            try
                            {
                                disconn.Decode(buffer, Handshake.MAGIC_DISCONNECT);
                                _State = ConnectionState.CLOSED;
                                Log.Warn($"DisconnectedNotify", "KcpProxy");
                                return 0;
                            }
                            catch (ArgumentException)
                            {
                                // Do nothing
                            }
                        }

                        int status = 0;
                        lock (ikcpLock) status = IKCP.ikcp_input(ikcpHandle, buffer, buffer.Length);
                        if (status == -1)
                        {
                            _State = ConnectionState.CLOSED;
                            throw new SocketException(10053); // Connection aborted
                        }
                        return status;
                    }
                case ConnectionState.HANDSHAKE_WAIT:
                    {
                        var handshake = new Handshake();
                        try
                        {
                            Log.Dbug($"HandShakeWaitNotify, buf = {Convert.ToHexString(buffer)}", "KcpProxy");
                            handshake.Decode(buffer, Handshake.MAGIC_CONNECT);
                            //_Conv = (uint)(MonotonicTime.Now & 0xFFFFFFFF);
                            //_Token = 0xFFCCEEBB ^ (uint)((MonotonicTime.Now >> 32) & 0xFFFFFFFF);

                            Debug.Assert(sendClient == null);
                            sendClient = new(sendToAddress, handshake.Conv, handshake.Token, handshake.Data);
                            Task.WaitAll(sendClient.ConnectAsync());

                            var sendBackConv = sendClient.GetSendbackHandshake();
                            Output(sendBackConv.AsBytes());
                            _Conv = sendBackConv.Conv;
                            _Token = sendBackConv.Token;
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            throw new SocketException(10053);
                        }
                    }
                case ConnectionState.HANDSHAKE_CONNECT:
                    {
                        Log.Erro("KcpProxy is not a client but received HANDSHAKE_CONNECT", "KcpProxy");
                        break;
                        /*var handshake = new Handshake();
                        try
                        {
                            Log.Dbug($"HandShakeConnectNotify, buf = {Convert.ToHexString(buffer)}", "KcpProxy");
                            handshake.Decode(buffer, Handshake.MAGIC_SEND_BACK_CONV);
                            _Conv = handshake.Conv;
                            _Token = handshake.Token;
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            throw new SocketException(10053);
                        }*/
                    }
            }

            // ??? unreachable ???
            throw new Exception("Reached unreachable code.");
        }

        protected Func<byte[], byte[]> PacketHandler;
    }
}
