using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using YSFreedom.Common.Native;
using YSFreedom.Common.Util;

namespace YSFreedom.Common.Net
{
    public class KCP : IDisposable
    {
        public enum ConnectionState
        {
            CLOSED, DISCONNECTED, HANDSHAKE_CONNECT, HANDSHAKE_WAIT, CONNECTED
        }
        public delegate int OutputDelegate(byte[] buffer);

        public OutputDelegate Output;
        public bool Disposed { get { return _Disposed; } }
        public ConnectionState State { get { return _State; } }
        public uint Conv { get { return _Conv; } }
        // Default connection timeout is 30 seconds
        public int Timeout = 30000;
        public readonly bool AsClient;

        private bool _Disposed = false;
        private uint _Conv;
        private uint _Token;
        private ConnectionState _State = ConnectionState.DISCONNECTED;
        private UIntPtr ikcpHandle;
        private object ikcpLock = new object();
        private long startTime;
        private IKCP.OutputCallback outputCbThunk;

        public KCP(uint conv = 0, uint token = 0, bool asClient = false)
        {
            _Conv = conv;
            _Token = token;
            startTime = MonotonicTime.Now - 1000;
            outputCbThunk = new IKCP.OutputCallback(thunk_Output);
            AsClient = asClient;
        }

        public void Initialize()
        {
            lock (ikcpLock)
            {
                if (ikcpHandle != UIntPtr.Zero)
                    throw new Exception("Bug! Initialize called twice!");

                ikcpHandle = IKCP.ikcp_create(_Conv, _Token, UIntPtr.Zero);
                IKCP.ikcp_setoutput(ikcpHandle, outputCbThunk);
                _State = ConnectionState.CONNECTED;

                // Added
                IKCP.ikcp_nodelay(ikcpHandle, 1, 10, 2, 1);
                IKCP.ikcp_wndsize(ikcpHandle, 256, 256);               

                Task.Run(BackgroundUpdate);
            }
        }

        public void ConnectNonblock()
        {
            _State = ConnectionState.HANDSHAKE_CONNECT;

            Handshake h = new Handshake(Handshake.MAGIC_CONNECT, _Conv, _Token, 0x499602D2);
            Output(h.AsBytes());
        }

        public async Task ConnectAsync()
        {
            // TODO: actually timeout
            ConnectNonblock();

            var begin = MonotonicTime.Now;
            while (_State != ConnectionState.CONNECTED)
            {
                await Task.Delay(10);
                if (MonotonicTime.Now - begin == Timeout)
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
                await Task.Delay(10);
                if (MonotonicTime.Now - begin == Timeout)
                    throw new SocketException(10060); // WSAETIMEDOUT
            }
        }

        private int thunk_Output(byte[] buffer, int len, UIntPtr kcp, UIntPtr userdata)
        {
            if (Output == null) return 0;
            return Output(buffer);
        }

        public int Input(byte[] buffer)
        {
            switch (_State)
            {
                case ConnectionState.DISCONNECTED:
                case ConnectionState.CLOSED:
                    throw new SocketException(10057); // Not connected
                case ConnectionState.CONNECTED:
                    {
                        Console.WriteLine($"ConnectedNotify, buf = {Convert.ToHexString(buffer)}");
                        if (buffer.Length == 20) // Possibly a "disconnect" packet
                        {
                            var disconn = new Handshake();
                            try
                            {
                                disconn.Decode(buffer, Handshake.MAGIC_DISCONNECT);
                                _State = ConnectionState.CLOSED;
                                Console.WriteLine($"DisconnectedNotify");
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
                            Console.WriteLine($"HandShakeWaitNotify, buf = {Convert.ToHexString(buffer)}");
                            handshake.Decode(buffer, Handshake.MAGIC_CONNECT);
                            _Conv = (uint)(MonotonicTime.Now & 0xFFFFFFFF);
                            _Token = 0xFFCCEEBB ^ (uint)((MonotonicTime.Now >> 32) & 0xFFFFFFFF);

                            var sendBackConv = new Handshake(Handshake.MAGIC_SEND_BACK_CONV, _Conv, _Token);
                            Output(sendBackConv.AsBytes());
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
                        var handshake = new Handshake();
                        try
                        {
                            Console.WriteLine($"HandShakeConnectNotify, buf = {Convert.ToHexString(buffer)}");
                            handshake.Decode(buffer, Handshake.MAGIC_SEND_BACK_CONV);
                            _Conv = handshake.Conv;
                            _Token = handshake.Token;
                            Initialize();

                            return 0;
                        }
                        catch (ArgumentException)
                        {
                            throw new SocketException(10053);
                        }
                    }
            }

            // ??? unreachable ???
            throw new Exception("Reached unreachable code.");
        }

        public int SendNonblock(byte[] buffer)
        {
            if (_State != ConnectionState.CONNECTED)
                throw new SocketException(10057);

            lock (ikcpLock) {
                int ret = IKCP.ikcp_send(ikcpHandle, buffer, buffer.Length);
                Flush();
                return ret;
            }
        }

        public async Task<int> SendAsync(byte[] buffer)
        {
            await Task.Yield();
            return SendNonblock(buffer);
        }

        private byte[] ReceiveNonblock()
        {
            lock (ikcpLock)
            {
                if (_State != ConnectionState.CONNECTED)
                    throw new SocketException(10057);

                int size = IKCP.ikcp_peeksize(ikcpHandle);
                if (size < 0) return null;


                var buffer = new byte[size];
                int trueSize = IKCP.ikcp_recv(ikcpHandle, buffer, buffer.Length);
                if (trueSize != size) throw new Exception("Unexpected state");

                return buffer;
            }
        }

        public byte[] Receive(bool nonblock = false)
        {
            if (nonblock) return ReceiveNonblock();

            byte[] ret = null;
            while (ret == null)
            {
                ret = ReceiveNonblock();
                if (ret == null) Thread.Yield();
            }
            return ret;
        }

        public async Task<byte[]> ReceiveAsync()
        {
            byte[] ret = null;
            while (ret == null)
            {
                ret = ReceiveNonblock();
                if (ret == null) await Task.Delay(10); //(int)(IKCP.ikcp_check(ikcpHandle, (uint)(MonotonicTime.Now - startTime)) & 0xFFFF));
            }
            return ret;
        }

        public void Update()
        {
            IKCP.ikcp_update(ikcpHandle, (uint)(startTime - MonotonicTime.Now));
        }

        public async Task BackgroundUpdate()
        {
            if (_Disposed || _State != ConnectionState.CONNECTED) return;

            int dur;
            lock (ikcpLock) dur = (int)(IKCP.ikcp_check(ikcpHandle, (uint)(MonotonicTime.Now - startTime)) & 0xFFFF);
            await Task.Delay(10);
            Update();

            await Task.Run(BackgroundUpdate);
        }

        public void Flush()
        {
            lock (ikcpLock) IKCP.ikcp_flush(ikcpHandle);
        }

        public void Close()
        {
            if (_State == ConnectionState.CONNECTED)
            {
                _State = ConnectionState.CLOSED;

                var disconn = new Handshake(Handshake.MAGIC_DISCONNECT, _Conv, _Token);
                Output(disconn.AsBytes());

                return;
            }

            _State = ConnectionState.CLOSED;
        }

        public void Dispose()
        {
            _State = ConnectionState.CLOSED;

            if (ikcpHandle != UIntPtr.Zero)
                lock (ikcpLock) IKCP.ikcp_release(ikcpHandle);

            _Disposed = true;
        }

        ~KCP()
        {
            if (!_Disposed)
                Dispose();
        }

        internal class Handshake
        {
            public static readonly uint[] MAGIC_CONNECT = { 0xFF, 0xFFFFFFFF };
            public static readonly uint[] MAGIC_SEND_BACK_CONV = { 0x145, 0x14514545 };
            public static readonly uint[] MAGIC_DISCONNECT = { 0x194, 0x19419494 };
            public const int LEN = 20;

            public uint Magic1;
            public uint Conv;
            public uint Token;
            public uint Data;
            public uint Magic2;

            public Handshake() { }
            public Handshake(uint[] magic, uint conv = 0, uint token = 0, uint data = 0)
            {
                Magic1 = magic[0];
                Conv = conv;
                Token = token;
                Data = data;
                Magic2 = magic[1];
            }

            public void Encode(byte[] buffer)
            {
                buffer.SetUInt32(0, Magic1, true);
                buffer.SetUInt32(4, Conv, true);
                buffer.SetUInt32(8, Token, true);
                buffer.SetUInt32(12, Data, true);
                buffer.SetUInt32(16, Magic2, true);
            }

            public void Decode(byte[] buffer, uint[] verifyMagic = null)
            {
                if (buffer.Length < LEN)
                    throw new ArgumentException("Handshake packet too small", "buffer");

                Magic1 = buffer.GetUInt32(0, true);
                Conv = buffer.GetUInt32(4, true);
                Token = buffer.GetUInt32(8, true);
                Data = buffer.GetUInt32(12, true);
                Magic2 = buffer.GetUInt32(16, true);

                if (verifyMagic != null)
                {
                    if (Magic1 != verifyMagic[0] || Magic2 != verifyMagic[1])
                        throw new ArgumentException("Invalid handshake packet", "buffer");
                }
            }

            public byte[] AsBytes()
            {
                var ret = new byte[20];
                Encode(ret);
                return ret;
            }
        }
    }
}
