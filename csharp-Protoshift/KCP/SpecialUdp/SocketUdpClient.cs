﻿// #define SOCKET_UDP_VERBOSE
// #define SOCKET_UDP_PACKET_CONTENT_VERBOSE
// #define SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS

// Generated by ChatGPT
using System.Net;
using System.Net.Sockets;
using YYHEggEgg.Logger;
using System.Buffers;

namespace csharp_Protoshift.SpecialUdp
{
    public class SocketUdpClient : IDisposable
    {
        private readonly Socket _socket;
        private EndPoint? _defaultEndpoint;
        private string? _defaultEndpointString;

        public const int UDP_MAX_PACKET_SIZE = 65507;

        private readonly ArrayPool<byte> _arrayPool;
        private readonly bool _isSTABuffer;
        private byte[]? STABuffer;
        private SingleThreadAssert? _rcvSTAAssert;

        private readonly bool isIpv6Socket;

        /// <summary>
        /// Initializer.
        /// </summary>
        /// <param name="singlethread_receiving"><see cref="true"/> means you confirm that you're invoking the <see cref="ReceiveFrom"/> in only one thread. If you give it true but not ensure that, terrible thing will happen.</param>
        public SocketUdpClient(bool singlethread_receiving = false, bool isIpv6Socket = false)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.isIpv6Socket = isIpv6Socket;
            _socket.Bind(DefaultEndPoint);
            _arrayPool = ArrayPool<byte>.Shared;
            _isSTABuffer = singlethread_receiving;
            if (_isSTABuffer)
            {
                STABuffer = new byte[UDP_MAX_PACKET_SIZE];
                _rcvSTAAssert = new($"{nameof(SocketUdpClient)}_{ReceiveFrom}");
            }

        }

        public SocketUdpClient(IPEndPoint ipEndPoint, bool singlethread_receiving = false)
        {
            if (ipEndPoint.AddressFamily == AddressFamily.InterNetwork)
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                isIpv6Socket = false;
            }
            else if (ipEndPoint.AddressFamily == AddressFamily.InterNetworkV6)
            {
                _socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
                isIpv6Socket = true;
            }
            else throw new ArgumentException(
                "IPEndPoint is probably not a valid IP address or used, please check the input",
                nameof(ipEndPoint));
            _socket.Bind(ipEndPoint);
            _arrayPool = ArrayPool<byte>.Shared;
            _isSTABuffer = singlethread_receiving;
            if (_isSTABuffer)
            {
                STABuffer = new byte[UDP_MAX_PACKET_SIZE];
                _rcvSTAAssert = new($"{nameof(SocketUdpClient)}_{ReceiveFrom}");
            }
        }

        private IPEndPoint DefaultEndPoint => new IPEndPoint(isIpv6Socket ? IPAddress.IPv6Any : IPAddress.Any, 0);

        public void Connect(EndPoint endPoint)
        {
            _defaultEndpoint = endPoint;
            _defaultEndpointString = _defaultEndpoint.ToString();
        }

        #region ReceiveFrom(Async)
        public SocketUdpReceiveResult ReceiveFrom()
        {
            byte[] buffer;
            if (_isSTABuffer)
            {
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                _rcvSTAAssert.Enter();
                buffer = STABuffer ?? throw new InvalidOperationException("Won't appear, unless a bug.");
#pragma warning restore CS8600, CS8602
            }
            else buffer = _arrayPool.Rent(UDP_MAX_PACKET_SIZE);
            SocketUdpReceiveResult receiveResult = new();

            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                EndPoint _tmpendp = DefaultEndPoint;
                var avalidlength = _socket.ReceiveFrom(buffer, SocketFlags.None, 
                    ref _tmpendp);

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Received {avalidlength} bytes from {_tmpendp} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif

                if (_defaultEndpointString != null && 
                    _tmpendp.ToString() != _defaultEndpointString)
                {
                    Log.Warn($"Received data from unexpected endpoint {_tmpendp}, dropped", nameof(SocketUdpClient));
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                    if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                    return ReceiveFrom();
                    // throw new SocketException((int)SocketError.HostUnreachable);
                }

                byte[] rtn = new byte[avalidlength];
                Buffer.BlockCopy(buffer, 0, rtn, 0, avalidlength);
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Received packet content ({avalidlength} bytes) from {result.RemoteEndPoint}: ---{Convert.ToHexString(rtn)}", nameof(SocketUdpClient));
#else
                _ = Task.Run(() => 
                    Log.Verb($"Received packet content ({avalidlength} bytes) from {_tmpendp}: ---{Convert.ToHexString(rtn)}", nameof(SocketUdpClient)));
#endif
#endif
                receiveResult.Buffer = rtn;
                receiveResult.ReceivedBytes = avalidlength;
                if (_tmpendp is IPEndPoint)
                {
                    receiveResult.RemoteEndPoint = (IPEndPoint)_tmpendp;
                    return receiveResult;
                }
                else
                {
                    Log.Warn($"Received data from non-ip endpoint {_tmpendp}, dropped", nameof(SocketUdpClient));
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                    if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                    return ReceiveFrom();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Failed to receive packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
            finally
            {
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                else _arrayPool.Return(buffer);
            }
        }
        
        public async Task<SocketUdpReceiveResult> ReceiveFromAsync()
        {
            byte[] buffer;
            if (_isSTABuffer)
            {
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                _rcvSTAAssert.Enter();
                buffer = STABuffer ?? throw new InvalidOperationException("Won't appear, unless a bug.");
#pragma warning restore CS8600, CS8602
            }
            else buffer = _arrayPool.Rent(UDP_MAX_PACKET_SIZE);
            SocketUdpReceiveResult receiveResult = new() { RemoteEndPoint = DefaultEndPoint };

            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                
                var result = await _socket.ReceiveFromAsync(buffer, SocketFlags.None, 
                    receiveResult.RemoteEndPoint);

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Received {result.ReceivedBytes} bytes from {result.RemoteEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif

                if (_defaultEndpointString != null && 
                    result.RemoteEndPoint.ToString() != _defaultEndpointString)
                {
                    Log.Warn($"Received data from unexpected endpoint {result.RemoteEndPoint}, dropped", nameof(SocketUdpClient));
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                    if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                    return await ReceiveFromAsync();
                    // throw new SocketException((int)SocketError.HostUnreachable);
                }

                byte[] rtn = new byte[result.ReceivedBytes];
                Buffer.BlockCopy(buffer, 0, rtn, 0, result.ReceivedBytes);
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Received packet content ({result.ReceivedBytes} bytes) from {result.RemoteEndPoint}: ---{Convert.ToHexString(rtn)}", nameof(SocketUdpClient));
#else
                _ = Task.Run(() => 
                    Log.Verb($"Received packet content ({result.ReceivedBytes} bytes) from {result.RemoteEndPoint}: ---{Convert.ToHexString(rtn)}", nameof(SocketUdpClient)));
#endif
#endif
                receiveResult.Buffer = rtn;
                receiveResult.ReceivedBytes = result.ReceivedBytes;
                if (result.RemoteEndPoint is IPEndPoint)
                {
                    receiveResult.RemoteEndPoint = (IPEndPoint)result.RemoteEndPoint;
                    return receiveResult;
                }
                else
                {
                    Log.Warn($"Received data from non-ip endpoint {result.RemoteEndPoint}, dropped", nameof(SocketUdpClient));
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                    if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                    return await ReceiveFromAsync();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Failed to receive packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
            finally
            {
#pragma warning disable CS8600, CS8602 // Initialized when _isSTABuffer.
                if (_isSTABuffer) _rcvSTAAssert.Exit();
#pragma warning restore CS8600, CS8602
                else _arrayPool.Return(buffer);
            }
        }
        #endregion

        #region SendTo
        public int SendTo(byte[] buffer, EndPoint? ipEndPoint = null)
        {
            if (ipEndPoint == null && _defaultEndpoint == null)
            {
                throw new SocketException((int)SocketError.NotConnected);
            }

            ipEndPoint ??= _defaultEndpoint;
            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                // The compiler's logic is not good enough.
                // If ipEndPoint == null && _defaultEndpoint == null -> Exception thrown
                // If ipEndPoint == null && _defaultEndpoint != null -> ipEndPoint ??= _defaultEndpoint
                // If ipEndPoint != null && _defaultEndpoint == null -> ipEndPoint avaliable
                // If ipEndPoint != null && _defaultEndpoint != null -> ipEndPoint avaliable
                // In conclusion, ipEndPoint is guaranteed not null.
#pragma warning disable CS8604 // 引用类型参数不可能为 null！
                var result = _socket.SendTo(buffer, SocketFlags.None, ipEndPoint);
#pragma warning restore CS8604 // 引用类型参数不可能为 null！

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Sent {result} bytes to {ipEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer)}", nameof(SocketUdpClient));
#else
                _ = Task.Run(() =>
                    Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer)}", nameof(SocketUdpClient)));
#endif
#endif

                return result;
            }
            catch (Exception ex)
            {
                Log.Erro($"Failed to send packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }
        
        public int SendTo(ReadOnlySpan<byte> buffer, EndPoint? ipEndPoint = null)
        {
            if (ipEndPoint == null && _defaultEndpoint == null)
            {
                throw new SocketException((int)SocketError.NotConnected);
            }

            ipEndPoint ??= _defaultEndpoint;
            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                // The compiler's logic is not good enough.
                // If ipEndPoint == null && _defaultEndpoint == null -> Exception thrown
                // If ipEndPoint == null && _defaultEndpoint != null -> ipEndPoint ??= _defaultEndpoint
                // If ipEndPoint != null && _defaultEndpoint == null -> ipEndPoint avaliable
                // If ipEndPoint != null && _defaultEndpoint != null -> ipEndPoint avaliable
                // In conclusion, ipEndPoint is guaranteed not null.
#pragma warning disable CS8604 // 引用类型参数不可能为 null！
                var result = _socket.SendTo(buffer, SocketFlags.None, ipEndPoint);
#pragma warning restore CS8604 // 引用类型参数不可能为 null！

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Sent {result} bytes to {ipEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE || SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer)}", nameof(SocketUdpClient));
#endif

                return result;
            }
            catch (Exception ex)
            {
                Log.Erro($"Failed to send packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }
        #endregion

        #region SendToAsync
        public async Task<int> SendToAsync(ReadOnlyMemory<byte> buffer, EndPoint? ipEndPoint = null)
        {
            if (ipEndPoint == null && _defaultEndpoint == null)
            {
                throw new SocketException((int)SocketError.NotConnected);
            }

            ipEndPoint ??= _defaultEndpoint;
            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                // The compiler's logic is not good enough.
                // If ipEndPoint == null && _defaultEndpoint == null -> Exception thrown
                // If ipEndPoint == null && _defaultEndpoint != null -> ipEndPoint ??= _defaultEndpoint
                // If ipEndPoint != null && _defaultEndpoint == null -> ipEndPoint avaliable
                // If ipEndPoint != null && _defaultEndpoint != null -> ipEndPoint avaliable
                // In conclusion, ipEndPoint is guaranteed not null.
#pragma warning disable CS8604 // 引用类型参数不可能为 null！
                var result = await _socket.SendToAsync(buffer, SocketFlags.None, ipEndPoint);
#pragma warning restore CS8604 // 引用类型参数不可能为 null！

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Sent {result} bytes to {ipEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer.Span)}", nameof(SocketUdpClient));
#else
                _ = Task.Run(() =>
                    Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer.Span)}", nameof(SocketUdpClient)));
#endif
#endif

                return result;
            }
            catch (Exception ex)
            {
                Log.Erro($"Failed to send packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }

        public async Task<int> SendToAsync(byte[] buffer, EndPoint? ipEndPoint = null)
        {
            if (ipEndPoint == null && _defaultEndpoint == null)
            {
                throw new SocketException((int)SocketError.NotConnected);
            }

            ipEndPoint ??= _defaultEndpoint;
            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                // The compiler's logic is not good enough.
                // If ipEndPoint == null && _defaultEndpoint == null -> Exception thrown
                // If ipEndPoint == null && _defaultEndpoint != null -> ipEndPoint ??= _defaultEndpoint
                // If ipEndPoint != null && _defaultEndpoint == null -> ipEndPoint avaliable
                // If ipEndPoint != null && _defaultEndpoint != null -> ipEndPoint avaliable
                // In conclusion, ipEndPoint is guaranteed not null.
#pragma warning disable CS8604 // 引用类型参数不可能为 null！
                var result = await _socket.SendToAsync(buffer, SocketFlags.None, ipEndPoint);
#pragma warning restore CS8604 // 引用类型参数不可能为 null！

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Sent {result} bytes to {ipEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE
#if SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS
                Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer)}", nameof(SocketUdpClient));
#else
                _ = Task.Run(() =>
                    Log.Verb($"Sent packet content ({buffer.Length} bytes) to {ipEndPoint}: ---{Convert.ToHexString(buffer)}", nameof(SocketUdpClient)));
#endif
#endif

                return result;
            }
            catch (Exception ex)
            {
                Log.Erro($"Failed to send packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }
        #endregion

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _socket.Dispose();
            }
        }

        public void Close()
        {
            Dispose(true);
        }

        ~SocketUdpClient()
        {
            Dispose(false);
        }
    }

    public class SocketUdpReceiveResult
    {

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public byte[] Buffer;
        public int ReceivedBytes;
        public IPEndPoint RemoteEndPoint;
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    }
}