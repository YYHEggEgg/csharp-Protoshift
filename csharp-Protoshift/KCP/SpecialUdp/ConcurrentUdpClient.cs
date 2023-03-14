// Generated by ChatGPT

using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_Protoshift.KCP.SpecialUdp
{
    public class ConcurrentUdpClient : IDisposeable
    {
        private class UdpSendPacket
        {
            public byte[] data;
            public IPEndPoint? endpoint;
            public Exception? ex;
            public int? rtn;
            public bool dropResult;

            public UdpSendPacket(byte[] data, IPEndPoint endpoint, bool dropResult)
            {
                this.data = data;
                this.endpoint = endpoint;
                this.dropResult = dropResult;
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

        public ConcurrentUdpClient(IPEndPoint bindAddress)
        {
            BindedAddress = bindAddress;
            baseClient = new UdpClient(bindAddress);
            Task.Run(BackgroundUpdate);
        }

        // 发送队列
        private ConcurrentQueue<UdpSendPacket> qSend = new();
        // 接收队列
        private ConcurrentQueue<(UdpReceiveResult, Exception?)> qRecv = new();
        // 内部使用的UdpClient实例
        private UdpClient baseClient;
        public IPEndPoint BindedAddress { get; set; }

        #region Send Packet
        // 发送方法
        public async Task<int> SendAsync(byte[] data, IPEndPoint? endpoint == null)
        {
            // 将待发送数据加入发送队列
            UdpSendPacket packet = new UdpSendPacket(data, endpoint, false);
            qSend.Enqueue(packet);
            while (true)
            {
                if (packet.rtn != null)
                {
                    if (packet.ex != null)
                    {
                        // 如果有异常则抛出
                        throw packet.ex;
                    }
                    return rtn;
                }
                await Task.Delay(10);
            }
        }

        public void SendAsync(byte[] data, IPEndPoint? endpoint == null)
        {
            // 将待发送数据加入发送队列
            UdpSendPacket packet = new UdpSendPacket(data, endpoint, true);
            qSend.Enqueue(packet);
        }
        #endregion

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
                // 接收队列为空，等待10ms
                await Task.Delay(10);
            }
        }

        public void Connect(IPEndPoint ipEp)
        {
            BindedAddress = ipEp;
            baseClient.Connect(ipEp);
        }

        // 后台更新任务
        private async Task BackgroundUpdate()
        {
            if (qSend.TryDequeue(out var packet))
            {
                try
                {
                    // 发送数据
                    if (packet.endpoint != null)
                        packet.rtn = await baseClient.SendAsync(packet.data, packet.endpoint);
                    else packet.rtn = await baseClient.SendAsync(packet.data);
                }
                catch (Exception ex)
                {
                    if (packet.dropResult)
                    {
                        Log.Dbug($"BackgroundUpdate Send packet meets error and restart: {ex}", "ConcurrentUdpClient");
                        // 发生异常，将数据重新加入发送队列
                        qSend.Enqueue(packet);
                    }
                    else
                    {
                        packet.ex = ex;
                        packet.rtn = -1;
                    }
                }
            }
            else if (baseClient.Available > 0)
            {
                try
                {
                    // 接收数据
                    UdpReceiveResult result = await baseClient.ReceiveAsync();

                    // AI 似乎并未实现该部分，单独拿出了一个问题提问
                    var cancellationTokenSource = new CancellationTokenSource();
                    var receiveTask = udpClient.ReceiveAsync(cancellationTokenSource.Token);

                    if (await Task.WhenAny(receiveTask, Task.Delay(50)) == receiveTask)
                    {
                        cancellationTokenSource.Cancel();
                        result = await receiveTask;
                        qRecv.Enqueue((result, null));
                    }
                    else
                    {
                        cancellationTokenSource.Cancel();
                    }
                }
                catch (Exception ex)
                {
                    qRecv.Enqueue((default(UdpReceiveResult), ex));
                }
            }
            else
            {
                // 等待一段时间，降低CPU占用
                await Task.Delay(5);
            }
            await Task.Run(BackgroundUpdate);
        }

        #region IDisposeable
        /* Generated by ChatGPT
         * 在上面的代码中，我们实现了Close()、Dispose()和Protected Dispose(bool)方法，并且实现了IDisposeable接口。
         * 它们的作用如下：

         * - Close()方法：关闭基础UDP客户端。
         * - Dispose()方法：释放托管资源和非托管资源。
         *   这个方法由垃圾回收器调用，也可以由开发人员主动调用。
         *   在这里，我们在调用Dispose()方法时通过调用Dispose(true)方法释放托管资源，
         *   并抑制GC.SuppressFinalize(this)来防止使用Finalizer。
         * - Protected Dispose(bool)方法：释放非托管资源。
         *   如果disposing为true，则还会释放托管资源。

         * 需要注意的是，我们在类定义中还定义了一个Finalizer（也就是析构函数）。
         * 这个Finalizer中调用了Dispose(false)方法，以释放非托管资源。
         * 这样做是为了确保即使开发人员没有调用Dispose()方法，也能在对象被垃圾回收前释放非托管资源。
         */
        public void Close()
        {
            baseClient.Close();
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
                if (baseClient != null)
                {
                    baseClient.Dispose();
                    baseClient = null;
                }
            }
        }

        ~ConcurrentUdpClient()
        {
            Dispose(false);
        }
        #endregion
    }
}