﻿// #define SOCKET_UDP_VERBOSE

// Generated by ChatGPT
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using OfficeOpenXml.FormulaParsing.Logging;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.SpecialUdp
{
    public class SocketUdpClient : IDisposable
    {
        private readonly Socket _socket;
        private IPEndPoint? _defaultEndpoint;
        private string? _defaultEndpointString;

        public SocketUdpClient()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.Bind(new IPEndPoint(IPAddress.Any, 0));
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
        }

        public void Connect(IPEndPoint ipEndPoint)
        {
            _defaultEndpoint = ipEndPoint;
            _defaultEndpointString = _defaultEndpoint.ToString();
        }

        public async Task<SocketUdpReceiveResult> ReceiveFromAsync()
        {
            Memory<byte> buffer = new byte[65507];
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
                Log.Info($"Received {result.ReceivedBytes} bytes from {result.RemoteEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif

                if (_defaultEndpointString != null && 
                    result.RemoteEndPoint.ToString() != _defaultEndpointString)
                {
                    Log.Warn($"Received data from unexpected endpoint {result.RemoteEndPoint}, dropped", nameof(SocketUdpClient));
                    return await ReceiveFromAsync();
                    // throw new SocketException((int)SocketError.HostUnreachable);
                }

                receiveResult.Buffer = buffer.Slice(0, result.ReceivedBytes);
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
                Log.Info($"Sent {result} bytes to {ipEndPoint} in {stopwatch.ElapsedMilliseconds}ms", nameof(SocketUdpClient));
#endif

                return result;
            }
            catch (Exception ex)
            {
                Log.Erro($"Failed to send packet: {ex.Message}", nameof(SocketUdpClient));
                throw;
            }
        }

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

        public Memory<byte> Buffer { get; set; }
        public int ReceivedBytes { get; set; }
        public IPEndPoint RemoteEndPoint { get; set; } = defaultIpEp;
    }
}