﻿using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

#if NETSTANDARD2_0_OR_GREATER || NET5_0_OR_GREATER

namespace System.Net.Sockets.Kcp.Simple
{
    /// <summary>
    /// 简单例子
    /// </summary>
    public class SimpleKcpClient : IKcpCallback
    {
        UdpClient client;

        public SimpleKcpClient()
            : this(null)
        {

        }

        public SimpleKcpClient(IPEndPoint endPoint)
        {
            client = new UdpClient();
            client.Connect(endPoint);
#if !MIHOMO_KCP
            kcp = new SimpleSegManager.Kcp(2001, this);
#else
            kcp = new SimpleSegManager.Kcp(2001, 10000, this);
#endif
            this.EndPoint = endPoint;
            BeginRecv();
        }

        public SimpleSegManager.Kcp kcp { get; }
        public IPEndPoint EndPoint { get; set; }

        public void Output(IMemoryOwner<byte> buffer, int avalidLength, bool isKcpPacket = true)
        {
            var s = buffer.Memory.Span.Slice(0, avalidLength).ToArray();
            client.SendAsync(s, s.Length);
            buffer.Dispose();
        }

        public async void SendAsync(byte[] datagram, int bytes)
        {
            kcp.Send(datagram.AsSpan().Slice(0, bytes));
        }

        public async ValueTask<byte[]> ReceiveAsync()
        {
            var (buffer, avalidLength) = kcp.TryRecv();
            while (buffer == null)
            {
                await Task.Delay(10);
                (buffer, avalidLength) = kcp.TryRecv();
            }

            var s = buffer.Memory.Span.Slice(0, avalidLength).ToArray();
            return s;
        }

        private async void BeginRecv()
        {
            var res = await client.ReceiveAsync();
            EndPoint = res.RemoteEndPoint;
            kcp.Input(res.Buffer);
            BeginRecv();
        }
    }
}

#endif


