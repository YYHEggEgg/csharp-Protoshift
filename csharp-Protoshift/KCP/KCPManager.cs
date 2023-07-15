using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net.Sockets.Kcp;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_Protoshift
{
    internal class KCPManager
    {
        static string ShowThread
        {
            get
            {
                return $"  ThreadID[{Thread.CurrentThread.ManagedThreadId}]";
            }
        }

        public class TL : ConsoleTraceListener
        {
            public override void WriteLine(string message, string category)
            {
                base.WriteLine(message, $"[{Name}]  {category}");
            }
        }

        public class Handle : IKcpCallback
        {
            //public void Output(ReadOnlySpan<byte> buffer)
            //{
            //    var frag = new byte[buffer.Length];
            //    buffer.CopyTo(frag);
            //    Out(frag);
            //}

            public Action<Memory<byte>> Out;
            public Action<byte[]> Recv;
            public void Receive(byte[] buffer)
            {
                Recv(buffer);
            }

            public IMemoryOwner<byte> RentBuffer(int lenght)
            {
                return null;
            }

            public void Output(IMemoryOwner<byte> buffer, int avalidLength)
            {
                using (buffer)
                {
                    Out(buffer.Memory.Slice(0, avalidLength));
                }
            }
        }

        public void Test(byte[] data)
        {
            Console.WriteLine(ShowThread);

            var handle1 = new Handle();
            var handle2 = new Handle();

            const int conv = 123;
            //var kcp1 = new UnSafeSegManager.Kcp(conv, handle1);
            //var kcp2 = new UnSafeSegManager.Kcp(conv, handle2);

            var kcp1 = new PoolSegManager.Kcp(conv, handle1);
            var kcp2 = new PoolSegManager.Kcp(conv, handle2);
            kcp1.TraceListener = new TL() { Name = "Kcp1" };
            kcp2.TraceListener = new TL() { Name = "Kcp2" };
            kcp1.NoDelay(1, 10, 2, 1);//fast
            kcp1.WndSize(128, 128);
            //kcp1.SetMtu(512);

            kcp2.NoDelay(1, 10, 2, 1);//fast
            kcp2.WndSize(128, 128);
            //kcp2.SetMtu(512);

            var sendbyte = data;

            handle1.Out += packet =>
            {
                Console.WriteLine($"OK, out \"{Convert.ToHexString(packet.ToArray())}\"");
            };

            handle2.Out += packet =>
            {
                Console.WriteLine($"OK, out \"{Convert.ToHexString(packet.ToArray())}\"");
            };
            int count = 0;

            handle1.Recv += packet =>
            {
                Console.WriteLine($"OK, received \"{Convert.ToHexString(packet)}\"");
            };

            int recvCount = 0;
            handle2.Recv += packet =>
            {
                Console.WriteLine($"OK, received \"{Convert.ToHexString(packet)}\"");
            };

            Task.Run(async () =>
            {
                try
                {
                    int updateCount = 0;
                    while (true)
                    {
                        kcp1.Update(DateTimeOffset.UtcNow);

                        int len;
                        while ((len = kcp1.PeekSize()) > 0)
                        {
                            var buffer = new byte[len];
                            if (kcp1.Recv(buffer) >= 0)
                            {
                                handle1.Receive(buffer);
                            }
                        }

                        await Task.Delay(5);
                        updateCount++;
                        if (updateCount % 1000 == 0)
                        {
                            Console.WriteLine($"KCP1 ALIVE {updateCount}----{ShowThread}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            });

            Task.Run(async () =>
            {
                try
                {
                    int updateCount = 0;
                    while (true)
                    {
                        kcp2.Update(DateTimeOffset.UtcNow);

                        //var utcNow = DateTime.UtcNow;
                        //var res = kcp2.Check(utcNow);

                        int len;
                        do
                        {
                            var (buffer, avalidSzie) = kcp2.TryRecv();
                            len = avalidSzie;
                            if (buffer != null)
                            {
                                var temp = new byte[len];
                                buffer.Memory.Span.Slice(0, len).CopyTo(temp);
                                handle2.Receive(temp);
                            }
                        } while (len > 0);

                        await Task.Delay(5);
                        updateCount++;
                        if (updateCount % 1000 == 0)
                        {
                            Console.WriteLine($"KCP2 ALIVE {updateCount}----{ShowThread}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            });

            kcp1.Send(sendbyte);

            while (true)
            {
                Thread.Sleep(1000);
                GC.Collect();
            }

            Console.ReadLine();
        }
    }
}