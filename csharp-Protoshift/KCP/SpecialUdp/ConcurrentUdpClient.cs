// Generated by ChatGPT

using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

public class ConcurrentUdpClient
{
    // 内部结构体
    private struct UdpSendPacket
    {
        public byte[] data;
        public IPEndPoint endpoint;

        public UdpSendPacket(byte[] data, IPEndPoint endpoint)
        {
            this.data = data;
            this.endpoint = endpoint;
        }
    }

    // 构造函数
    public ConcurrentUdpClient()
    {
        // 初始化UdpClient实例
        baseClient = new UdpClient();
        // 启动后台更新任务
        Task.Run(BackgroundUpdate);
    }

    // 发送队列
    private ConcurrentQueue<UdpSendPacket> qSend = new ConcurrentQueue<UdpSendPacket>();
    // 接收队列
    private ConcurrentQueue<(UdpReceiveResult, Exception?)> qRecv = new ConcurrentQueue<(UdpReceiveResult, Exception?)>();
    // 内部使用的UdpClient实例
    private UdpClient baseClient;

    // 发送方法
    public void Send(byte[] data, IPEndPoint endpoint)
    {
        // 将待发送数据加入发送队列
        UdpSendPacket packet = new UdpSendPacket(data, endpoint);
        qSend.Enqueue(packet);
    }

    // 接收方法
    public async Task<UdpReceiveResult> ReceiveAsync()
    {
        while (true)
        {
            // 尝试从接收队列取出数据
            if (qRecv.TryDequeue(out var result))
            {
                if (result.Item2 != null)
                {
                    // 如果有异常则抛出
                    throw result.Item2;
                }
                // 否则返回接收到的数据
                return result.Item1;
            }
            // 接收队列为空，等待0.1s
            await Task.Delay(100);
        }
    }

    // 后台更新任务
    private async Task BackgroundUpdate()
    {
        while (true)
        {
            if (qSend.TryDequeue(out var packet))
            {
                try
                {
                    // 发送数据
                    await baseClient.SendAsync(packet.data, packet.endpoint);
                }
                catch (Exception ex)
                {
                    // 发生异常，将数据重新加入发送队列
                    qSend.Enqueue(packet);
                }
            }
            else if (baseClient.Available > 0)
            {
                try
                {
                    // 接收数据
                    UdpReceiveResult result = await baseClient.ReceiveAsync();
                    qRecv.Enqueue((result, null));
                }
                catch (Exception ex)
                {
                    qRecv.Enqueue((default(UdpReceiveResult), ex));
                }
            }
            else
            {
                // 等待一段时间，降低CPU占用
                await Task.Delay(10);
            }
        }
    }
}