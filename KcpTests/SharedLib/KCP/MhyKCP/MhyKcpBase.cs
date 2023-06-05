// #define KCP_INNER_LOG

using System.Buffers;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Net.Sockets.Kcp;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP
{
    public class MhyKcpBase : IDisposable
    {
        public const int KCP_RefreshMilliseconds = 2;

        public enum ConnectionState
        {
            CLOSED, DISCONNECTED, HANDSHAKE_CONNECT, HANDSHAKE_WAIT, CONNECTED
        }

        public IKcpCallback? OutputCallback;
        public bool Disposed { get { return _Disposed; } }
        public ConnectionState State { get { return _State; } }
        public uint Conv { get { return _Conv; } }
        public uint Token { get { return _Token; } }
        // Default connection timeout is turned to 15 seconds
        public int Timeout = 15000;

        protected bool _Disposed = false;
        protected uint _Conv;
        protected uint _Token;
        protected ConnectionState _State = ConnectionState.DISCONNECTED;
        // protected UIntPtr ikcpHandle;
        protected Kcp<KcpSegment>? cskcpHandle;
        // protected object ikcpLock = new object();
        protected object cskcp_recvLock = "R.I.P YSFreedom";
        protected long startTime;

        public uint ConnectData { get; protected set; }

        public MhyKcpBase(uint conv = 0, uint token = 0, uint connectData = 0x499602D2)
        {
            _Conv = conv;
            _Token = token;
            startTime = MonotonicTime.Now - 1000;
            ConnectData = connectData;
        }

        public void Initialize()
        {
            if (cskcpHandle != null)
                throw new Exception("Bug! Initialize called twice!");

            // ikcpHandle = IKCP.ikcp_create(_Conv, _Token, UIntPtr.Zero);
            cskcpHandle = new(_Conv, _Token, OutputCallback);
            _State = ConnectionState.CONNECTED;

            // Added
            // IKCP.ikcp_nodelay(ikcpHandle, 1, 10, 2, 1);
            // modified because mhy is using far more aggressive code, or 力大砖飞 mode
            cskcpHandle.NoDelay(1, KCP_RefreshMilliseconds, 1, 1);
            // IKCP.ikcp_wndsize(ikcpHandle, 256, 256);
            cskcpHandle.WndSize(256, 256);

#if KCP_INNER_LOG
            cskcpHandle.TraceListener = new LogTraceListener(nameof(MhyKcpBase));
            // cskcpHandle.TraceListener = new ConsoleTraceListener();
#endif

            cskcpHandle.SegmentManager = new UnSafeSegManager();

            checkTime_refresh = true;
            Task.Run(BackgroundUpdate);
        }

        public void ConnectNonblock()
        {
            _State = ConnectionState.HANDSHAKE_CONNECT;

            byte[] h = new Handshake(Handshake.MAGIC_CONNECT, _Conv, _Token, ConnectData).AsBytes();
            var buf = new KcpInnerBuffer(h);
            OutputCallback.Output(buf, h.Length, false);
        }

        public async Task ConnectAsync()
        {
            ConnectNonblock();

            var begin = MonotonicTime.Now;
            while (_State != ConnectionState.CONNECTED)
            {
                await Task.Delay(KCP_RefreshMilliseconds);
                if (MonotonicTime.Now - begin >= Timeout)
                    throw new SocketException(10060); // WSAETIMEDOUT
            }
        }

        public void AcceptNonblock()
        {
            _State = ConnectionState.HANDSHAKE_WAIT;
        }

        public async Task AcceptAsync()
        {
            if (_State == ConnectionState.DISCONNECTED) AcceptNonblock();

            var begin = MonotonicTime.Now;
            while (_State != ConnectionState.CONNECTED)
            {
                await Task.Delay(KCP_RefreshMilliseconds);
                if (MonotonicTime.Now - begin >= Timeout)
                    throw new SocketException(10060); // WSAETIMEDOUT
            }
        }

        // The time offset from ikcp_check has been not longer valid for ikcp_send or ikcp_input called
        protected bool checkTime_refresh = false;
        public virtual int Input(byte[] buffer)
        {
            switch (_State)
            {
                case ConnectionState.DISCONNECTED:
                case ConnectionState.CLOSED:
                    throw new SocketException(10057); // Not connected
                case ConnectionState.CONNECTED:
                    {
                        // Log.Dbug($"ConnectedNotify, handle = {ikcpHandle}, buf = {Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                        if (buffer.Length == 20) // Possibly a "disconnect" packet
                        {
                            var disconn = new Handshake();
                            try
                            {
                                disconn.Decode(buffer, Handshake.MAGIC_DISCONNECT);
                                _State = ConnectionState.CLOSED;
                                Log.Dbug($"DisconnectedNotify, Conv={disconn.Conv}, Token={disconn.Token}, Data={disconn.Data}", nameof(MhyKcpBase));
                                return 0;
                            }
                            catch (ArgumentException)
                            {
                                // Do nothing
                                Log.Dbug($"ConnectedNotify: Packet length=20, content={Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                            }
                        }

                        // int status = 0
                        // lock (ikcpLock) status = IKCP.ikcp_input(ikcpHandle, buffer, buffer.Length);
#pragma warning disable CS8602 // 解引用可能出现空引用。
                        int status = cskcpHandle.Input(buffer);
                        checkTime_refresh = true;
#pragma warning restore CS8602 // 解引用可能出现空引用。
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
                            // Log.Dbug($"HandShakeWaitNotify, buf = {Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                            handshake.Decode(buffer, Handshake.MAGIC_CONNECT);
                            _Conv = (uint)(MonotonicTime.Now & 0xFFFFFFFF);
                            _Token = 0xFFCCEEBB ^ (uint)((MonotonicTime.Now >> 32) & 0xFFFFFFFF);

                            var sendBackConv = new Handshake(Handshake.MAGIC_SEND_BACK_CONV, _Conv, _Token).AsBytes();
                            OutputCallback.Output(new KcpInnerBuffer(sendBackConv), sendBackConv.Length, false);
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            Log.Dbug($"HandShakeWaitNotify: handshake fail, content={Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                            throw new SocketException(10053);
                        }
                    }
                case ConnectionState.HANDSHAKE_CONNECT:
                    {
                        var handshake = new Handshake();
                        try
                        {
                            // Log.Dbug($"HandShakeConnectNotify, buf = {Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                            handshake.Decode(buffer, Handshake.MAGIC_SEND_BACK_CONV);
                            _Conv = handshake.Conv;
                            _Token = handshake.Token;
                            // Debug.Assert(ConnectData == handshake.Data);
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            Log.Dbug($"HandShakeConnectNotify: handshake fail, content={Convert.ToHexString(buffer)}", nameof(MhyKcpBase));
                            throw new SocketException(10053);
                        }
                    }
            }

            // ??? unreachable ???
            throw new Exception("Reached unreachable code.");
        }

        // Changed name as it's not nonblock.
        // public int SendNonblock(ReadOnlySpan<byte> buffer)
        public int Send(ReadOnlySpan<byte> buffer)
        {
            if (_State != ConnectionState.CONNECTED)
                throw new SocketException(10057);

            // int ret = IKCP.ikcp_send(ikcpHandle, buffer, buffer.Length);
#pragma warning disable CS8602 // 解引用可能出现空引用。
            int ret = cskcpHandle.Send(buffer);
            checkTime_refresh = true;
#pragma warning restore CS8602 // 解引用可能出现空引用。
            // Flush();
            return ret;
        }

        public async Task<int> SendAsync(byte[] buffer)
        {
            await Task.Yield();
            return Send(buffer);
        }

        private byte[]? ReceiveNonblock()
        {
            if (_State != ConnectionState.CONNECTED)
                throw new SocketException(10057);

            lock (cskcp_recvLock)
            {
                // int size = IKCP.ikcp_peeksize(ikcpHandle);
#pragma warning disable CS8602 // 解引用可能出现空引用。
                int size = cskcpHandle.PeekSize();
#pragma warning restore CS8602 // 解引用可能出现空引用。
                if (size < 0) return null;

                var buffer = new byte[size];
                // int trueSize = IKCP.ikcp_recv(ikcpHandle, buffer, buffer.Length);
                int trueSize;
                trueSize = cskcpHandle.Recv(buffer);
                if (trueSize != size) throw new Exception("Unexpected state");

                return buffer;
            }
        }

        public byte[]? Receive(bool nonblock = false)
        {
            if (nonblock) return ReceiveNonblock();

            byte[]? ret = null;
            while (ret == null)
            {
                ret = ReceiveNonblock();
                if (ret == null) Thread.Yield();
            }
            return ret;
        }

        public async Task<byte[]> ReceiveAsync()
        {
            byte[]? ret = null;
            while (ret == null)
            {
                ret = ReceiveNonblock();
                if (ret == null) await Task.Yield(); //(int)(IKCP.ikcp_check(ikcpHandle, (uint)(MonotonicTime.Now - startTime)) & 0xFFFF));
            }
            return ret;
        }

        // The time ikcp_update should be called get from ikcp_check
        protected DateTimeOffset update_next_time = DateTimeOffset.MinValue;
        public async Task BackgroundUpdate()
        {
            if (_Disposed || _State != ConnectionState.CONNECTED || cskcpHandle == null) return;

            // int dur;
            // lock (ikcpLock) dur = (int)(IKCP.ikcp_check(ikcpHandle, (uint)(MonotonicTime.Now - startTime)) & 0xFFFF);
            // DateTimeOffset dur = cskcpHandle.Check(DateTime.UtcNow);
            
            // From author:
            // 如果你不需要管理1000个以上的 kcp对象的话，还是不要用check比较好，这部分代码写起来比较烦。
            // await Task.Delay(KCP_RefreshMilliseconds);
            // lock (ikcpLock) IKCP.ikcp_update(ikcpHandle, (uint)(startTime - MonotonicTime.Now));
            // cskcpHandle.Update(DateTimeOffset.UtcNow);

            // Below is new code with ikcp_check
            if (checkTime_refresh || DateTimeOffset.UtcNow >= update_next_time)
            {
                checkTime_refresh = false;
                var nowtime = DateTimeOffset.UtcNow;
                // lock (ikcpLock) IKCP.ikcp_update(ikcpHandle, (uint)(startTime - MonotonicTime.Now));
                cskcpHandle.Update(nowtime);
                update_next_time = cskcpHandle.Check(nowtime);
            }

            if (!checkTime_refresh) await Task.Delay(KCP_RefreshMilliseconds);
            else if (KCP_RefreshMilliseconds >= 15) await Task.Delay(KCP_RefreshMilliseconds);

            await Task.Run(BackgroundUpdate);
        }

        // public void Flush()
        // {
            // lock (ikcpLock) IKCP.ikcp_flush(ikcpHandle);
            // Flush in Kcp<Segment> not found. We suppose that it automatically did it.
        // }

        public void Close()
        {
            if (_State == ConnectionState.CONNECTED)
            {
                _State = ConnectionState.CLOSED;

                var disconn = new Handshake(Handshake.MAGIC_DISCONNECT, _Conv, _Token).AsBytes();
                OutputCallback.Output(new KcpInnerBuffer(disconn), disconn.Length, false);

                return;
            }

            _State = ConnectionState.CLOSED;
        }

        public void Dispose()
        {
            _State = ConnectionState.CLOSED;

            if (cskcpHandle != null)
                cskcpHandle.Dispose();

            _Disposed = true;
        }

        public void Disconnect(uint conv = 0, uint token = 0, uint data = 1)
        {
            conv = conv == 0 ? _Conv : conv;
            token = token == 0 ? _Token : token;

            byte[] disconnect = new Handshake(Handshake.MAGIC_DISCONNECT, conv, token, data).AsBytes();
            OutputCallback.Output(new KcpInnerBuffer(disconnect), disconnect.Length, false);
            _State = ConnectionState.DISCONNECTED;
        }

        ~MhyKcpBase()
        {
            if (!_Disposed)
                Dispose();
        }
    }
}
