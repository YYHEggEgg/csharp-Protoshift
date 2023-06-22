﻿// #define SOCKET_UDP_VERBOSE
// #define SOCKET_UDP_PACKET_CONTENT_VERBOSE
// #define SOCKET_UDP_PACKET_CONTENT_VERBOSE_SYNCRONOUS

// Generated by ChatGPT
using System.Net;
using System.Net.Sockets;
using YYHEggEgg.Logger;
using System.Buffers;
using System.Diagnostics;

namespace csharp_Protoshift.SpecialUdp  
{
    public class SocketUdpClient : IDisposable
    {
        private readonly Socket _socket;
        private IPEndPoint? _defaultEndpoint;
        private string? _defaultEndpointString;

        public const int UDP_MAX_PACKET_SIZE = 65507;

        private readonly ArrayPool<byte> _arrayPool;

        public SocketUdpClient()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(new IPEndPoint(IPAddress.Any, 0));
            _arrayPool = ArrayPool<byte>.Shared;
        }

        public SocketUdpClient(IPEndPoint ipEndPoint)
        {
            if (ipEndPoint.AddressFamily == AddressFamily.InterNetwork)
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            else if (ipEndPoint.AddressFamily == AddressFamily.InterNetworkV6)
                _socket = new Socket(AddressFamily.InterNetworkV6, SocketType.Dgram, ProtocolType.Udp);
            else throw new ArgumentException(
                "IPEndPoint is probably not a valid IP address or used, please check the input", 
                nameof(ipEndPoint));
            _socket.Bind(ipEndPoint);
            _arrayPool = ArrayPool<byte>.Shared;
        }

        public void Connect(IPEndPoint ipEndPoint)
        {
            _defaultEndpoint = ipEndPoint;
            _defaultEndpointString = _defaultEndpoint.ToString();
        }

        #region ReceiveFrom(Async)
        public SocketUdpReceiveResult ReceiveFrom()
        {
            var buffer = _arrayPool.Rent(UDP_MAX_PACKET_SIZE);
            SocketUdpReceiveResult receiveResult = new();

            try
            {
#if SOCKET_UDP_VERBOSE
                var stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
#endif
                EndPoint _tmpendp = new IPEndPoint(IPAddress.Any, 0);
                var avalidlength = _socket.ReceiveFrom(buffer, SocketFlags.None, 
                    ref _tmpendp);

#if SOCKET_UDP_VERBOSE
                Log.Verb($"Received {avalidlength} bytes from {_tmpendp} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif

                if (_defaultEndpointString != null && 
                    _tmpendp.ToString() != _defaultEndpointString)
                {
                    Log.Warn($"Received data from unexpected endpoint {_tmpendp}, dropped", nameof(SocketUdpClient));
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
                    Log.Verb($"Received packet content ({avalidlength} bytes) from {result.RemoteEndPoint}: ---{Convert.ToHexString(rtn)}", nameof(SocketUdpClient)));
#endif
#endif
                _arrayPool.Return(buffer);
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
                    return ReceiveFrom();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Failed to receive packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }
        

        public async Task<SocketUdpReceiveResult> ReceiveFromAsync()
        {
            var buffer = _arrayPool.Rent(UDP_MAX_PACKET_SIZE);
            SocketUdpReceiveResult receiveResult = new();

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
                _arrayPool.Return(buffer);
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
                    return await ReceiveFromAsync();
                }
            }
            catch (Exception ex)
            {
                Log.Warn($"Failed to receive packet: {ex}", nameof(SocketUdpClient));
                throw;
            }
        }
        #endregion

        #region SendTo
        public int SendTo(byte[] buffer, IPEndPoint? ipEndPoint = null)
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
                Log.Erro($"Failed to send packet: {ex.Message}", nameof(SocketUdpClient));
                throw;
            }
        }
        
        public int SendTo(ReadOnlySpan<byte> buffer, IPEndPoint? ipEndPoint = null)
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
                Log.Erro($"Failed to send packet: {ex.Message}", nameof(SocketUdpClient));
                throw;
            }
        }
        #endregion

        #region SendToAsync
        public async Task<int> SendToAsync(ReadOnlyMemory<byte> buffer, IPEndPoint? ipEndPoint = null)
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
                Log.Erro($"Failed to send packet: {ex.Message}", nameof(SocketUdpClient));
                throw;
            }
        }

        public async Task<int> SendToAsync(byte[] buffer, IPEndPoint? ipEndPoint = null)
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
                Log.Erro($"Failed to send packet: {ex.Message}", nameof(SocketUdpClient));
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
        private static IPEndPoint defaultIpEp = new IPEndPoint(IPAddress.Any, 0);

        public byte[] Buffer;
        public int ReceivedBytes;
        public IPEndPoint RemoteEndPoint = defaultIpEp;
    }
}