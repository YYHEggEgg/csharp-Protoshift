// #define KCP_PROXY_VERBOSE

using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Sockets;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Proxy
{
    /// <summary>
    /// <see cref="KcpProxyBase"/> is not a client
    /// </summary>
    public class KcpProxyBase : MhyKcpBase
    {
        public KcpProxyClient? sendClient;
        public EndPoint sendToAddress;
        protected static LoggerChannel? _kcpstatlogchan = KcpProxyServer._kcpstatlogger?.GetChannel(null);

        private object handshake_lock = "Tighnari beloved";

        public KcpProxyBase(EndPoint sendToAddress, uint conv = 0, uint token = 0,
            Func<byte[], byte[]>? PacketHandler = null)
            : base(conv, token)
        {
            this.sendToAddress = sendToAddress;
            this.PacketHandler = PacketHandler ?? (data => data);
            _recvlock = new($"{nameof(KcpProxyBase)}_{nameof(Receive)}");
            _updatelock = new($"{nameof(KcpProxyBase)}_{nameof(BackgroundUpdate)}");
        }

        public override int Input(byte[] buffer)
        {
            if (_State != ConnectionState.CONNECTED)
            {
                lock (handshake_lock) return InnerInput(buffer);
            }
            else
            {
                return InnerInput(buffer);
            }
        }

        private int InnerInput(byte[] buffer)
        {
            switch (_State)
            {
                case ConnectionState.DISCONNECTED:
                case ConnectionState.CLOSED:
                    throw new SocketException(10057); // Not connected
                case ConnectionState.CONNECTED:
                    {
#if KCP_PROXY_VERBOSE
                        Log.Dbug($"ConnectedNotify, buf = {Convert.ToHexString(buffer)}", nameof(KcpProxyBase));
#endif
                        if (buffer.Length == 20) // Possibly a "disconnect" packet
                        {
                            var disconn = new Handshake();
                            var possiblemagic = buffer.GetUInt32(0);
                            try
                            {
                                if (possiblemagic == Handshake.MAGIC_DISCONNECT[0])
                                {
                                    disconn.Decode(buffer, Handshake.MAGIC_DISCONNECT);
                                    _State = ConnectionState.CLOSED;
                                    Log.Info($"Client (conv: {_Conv}) requested disconnect (reason: {disconn.Data}), so send disconnect to server", nameof(KcpProxyBase));
                                    _kcpstatlogchan?.LogInfo($"0|kcp|disconnect|from_client|token={disconn.Token}|reason={disconn.Data}");

                                    sendClient?.Disconnect(disconn.Conv, disconn.Token, disconn.Data);
                                    return 0;
                                }
                                else if (possiblemagic == Handshake.MAGIC_CONNECT[0])
                                {
                                    // Reconnect
                                    disconn.Decode(buffer, Handshake.MAGIC_CONNECT);
                                    Log.Dbug("Client requested reconnect, set to WAIT", nameof(KcpProxyBase));

                                    goto case ConnectionState.HANDSHAKE_WAIT;
                                }
                            }
                            catch (ArgumentException)
                            {
                                Log.Dbug($"ConnectedNotify: Packet length=20, content={Convert.ToHexString(buffer)}", nameof(KcpProxyBase));
                            }
                        }

                        // int status = 0;
                        // lock (ikcpLock) status = IKCP.ikcp_input(ikcpHandle, buffer, buffer.Length);
#pragma warning disable CS8602 // 解引用可能出现空引用。
                        int status = cskcpHandle.Input(buffer);
#pragma warning restore CS8602 // 解引用可能出现空引用。
                        if (status != 0)
                            Log.Dbug($"ikcp_input failed, return {status}, received {buffer.Length} bytes", nameof(KcpProxyBase));
                        // if (status == -1)
                        // {
                        //     _State = ConnectionState.CLOSED;
                        //     throw new SocketException(10053); // Connection aborted
                        // }
                        return status;
                    }
                case ConnectionState.HANDSHAKE_WAIT:
                    {
                        var handshake = new Handshake();
                        try
                        {
                            handshake.Decode(buffer, Handshake.MAGIC_CONNECT);
#if KCP_PROXY_VERBOSE
                            Log.Dbug($"HandShakeWaitNotify, buf = {Convert.ToHexString(buffer.Span)}", nameof(KcpProxyBase));
#endif
                            //_Conv = (uint)(MonotonicTime.Now & 0xFFFFFFFF);
                            //_Token = 0xFFCCEEBB ^ (uint)((MonotonicTime.Now >> 32) & 0xFFFFFFFF);

                            // Debug.Assert(sendClient == null);
                            sendClient = new(sendToAddress, handshake.Conv, handshake.Token, handshake.Data);
                            sendClient.ConnectAsync().Wait(); 

                            var sendBackConv = sendClient.GetSendbackHandshake();
                            if (_kcpstatlogchan != null)
                                _kcpstatlogchan.LogSender = sendBackConv.Conv.ToString();
                            sendClient.StartDisconnected += (conv, token, data) =>
                            {
                                Log.Info($"Server (conv: {_Conv}) requested to disconnect (reason: {data}), so send disconnect to client", nameof(KcpProxyBase));
                                _kcpstatlogchan?.LogInfo($"0|kcp|disconnect|from_server|token={token}|reason={data}");
                                Disconnect(conv, token, data);
                            };
                            
                            var sendBackData = sendBackConv.AsBytes();
                            OutputCallback?.Output(new KcpInnerBuffer(sendBackData), sendBackData.Length, false);
                            _Conv = sendBackConv.Conv;
                            _Token = sendBackConv.Token;
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            Log.Dbug($"HandShakeWaitNotify: handshake fail, content={Convert.ToHexString(buffer)}", nameof(KcpProxyBase));
                            throw new SocketException(10053);
                        }
                    }
                case ConnectionState.HANDSHAKE_CONNECT:
                    {
                        Log.Dbug("KcpProxy is not a client but reached HANDSHAKE_CONNECT", nameof(KcpProxyBase));
                        break;
                        /*var handshake = new Handshake();
                        try
                        {
                            Log.Dbug($"HandShakeConnectNotify, buf = {Convert.ToHexString(buffer)}", nameof(KcpProxy));
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
