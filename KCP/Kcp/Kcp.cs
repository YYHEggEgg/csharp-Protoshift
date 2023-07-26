using System.Buffers;
using System.Diagnostics;
using static System.Net.Sockets.Kcp.PoolSegManager;
using BufferOwner = System.Buffers.IMemoryOwner<byte>;

namespace System.Net.Sockets.Kcp
{
    public class Kcp<Segment> : KcpCore<Segment>
        where Segment : IKcpSegment
    {
        /// <summary>
        /// create a new kcp control object, 'conv' must equal in two endpoint
        /// from the same connection.
        /// </summary>
        /// <param name="conv_"></param>
#if MIHOMO_KCP
        /// <param name="token_">
        /// miHoMo KCP modify: +IUINT32 token, +
        /// <para/>Change line(s) in file compare: ikcp.h, -346 +347; ikcp.c, -234 +234
        /// </param>
#endif
        /// <param name="callback"></param>
        /// <param name="rentable">可租用内存的回调</param>
#if !MIHOMO_KCP
        public Kcp(uint conv_, IKcpCallback callback, IRentable rentable = null)
            : base(conv_)
#else
        public Kcp(uint conv_, uint token_, IKcpCallback callback, IRentable rentable = null)
            : base(conv_, token_)
#endif
        {
            callbackHandle = callback;
            this.rentable = rentable;
#if ASSERT_STAINVOKE
#if !MIHOMO_KCP
            _recvassert = new($"{nameof(Kcp)}_{nameof(UncheckRecv)}(conv:{conv})");
#else
            _recvassert = new($"{nameof(Kcp)}_{nameof(UncheckRecv)}(conv:{conv}, token:{token})");
#endif
#endif
        }

#if ASSERT_STAINVOKE
        OuterCode.SingleThreadAssert _recvassert;
#endif

        //extension 重构和新增加的部分============================================

        IRentable rentable;
        /// <summary>
        /// 如果外部能够提供缓冲区则使用外部缓冲区，否则new byte[]
        /// </summary>
        /// <param name="needSize"></param>
        /// <returns></returns>
        internal protected override BufferOwner CreateBuffer(int needSize)
        {
            var res = rentable?.RentBuffer(needSize);
            if (res == null)
            {
                return base.CreateBuffer(needSize);
            }
            else
            {
                if (res.Memory.Length < needSize)
                {
                    throw new ArgumentException($"{nameof(rentable.RentBuffer)} 指定的委托不符合标准，返回的" +
                        $"BufferOwner.Memory.Length 小于 {nameof(needSize)}");
                }
            }

            return res;
        }

        /// <summary>
        /// TryRecv Recv设计上同一时刻只允许一个线程调用。
        /// <para/>因为要保证数据顺序，多个线程同时调用Recv也没有意义。
        /// <para/>所以只需要部分加锁即可。
        /// </summary>
        /// <returns></returns>
        public (BufferOwner buffer, int avalidLength) TryRecv()
        {
            var peekSize = -1;
            lock (rcv_queueLock)
            {
                if (rcv_queue.Count == 0)
                {
                    ///没有可用包
                    return (null, -1);
                }

                var seq = rcv_queue[0];

                if (seq.frg == 0)
                {
                    peekSize = (int)seq.len;
                }

                if (rcv_queue.Count < seq.frg + 1)
                {
                    ///没有足够的包
                    return (null, -1);
                }

                uint length = 0;

                foreach (var item in rcv_queue)
                {
                    length += item.len;
                    if (item.frg == 0)
                    {
                        break;
                    }
                }

                peekSize = (int)length;

                if (peekSize < 0)
                {
                    return (null, -2);
                }
            }

            var buffer = CreateBuffer(peekSize);
            var recvlength = UncheckRecv(buffer.Memory.Span);
            return (buffer, recvlength);
        }

        /// <summary>
        /// TryRecv Recv设计上同一时刻只允许一个线程调用。
        /// <para/>因为要保证数据顺序，多个线程同时调用Recv也没有意义。
        /// <para/>所以只需要部分加锁即可。
        /// </summary>
        /// <param name="writer"></param>
        /// <returns></returns>
        public int TryRecv(IBufferWriter<byte> writer)
        {
            var peekSize = -1;
            lock (rcv_queueLock)
            {
                if (rcv_queue.Count == 0)
                {
                    ///没有可用包
                    return -1;
                }

                var seq = rcv_queue[0];

                if (seq.frg == 0)
                {
                    peekSize = (int)seq.len;
                }

                if (rcv_queue.Count < seq.frg + 1)
                {
                    ///没有足够的包
                    return -1;
                }

                uint length = 0;

                foreach (var item in rcv_queue)
                {
                    length += item.len;
                    if (item.frg == 0)
                    {
                        break;
                    }
                }

                peekSize = (int)length;

                if (peekSize < 0)
                {
                    return -2;
                }
            }

            return UncheckRecv(writer);
        }

        /// <summary>
        /// user/upper level recv: returns size, returns below zero for EAGAIN
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public int Recv(Span<byte> buffer)
        {
            if (0 == rcv_queue.Count)
            {
                return -1;
            }

            var peekSize = PeekSize();
            if (peekSize < 0)
            {
                return -2;
            }

            if (peekSize > buffer.Length)
            {
                return -3;
            }

            /// 拆分函数
            var recvLength = UncheckRecv(buffer);

            return recvLength;
        }

        /// <summary>
        /// user/upper level recv: returns size, returns below zero for EAGAIN
        /// </summary>
        /// <param name="writer"></param>
        /// <returns></returns>
        public int Recv(IBufferWriter<byte> writer)
        {
            if (0 == rcv_queue.Count)
            {
                return -1;
            }

            var peekSize = PeekSize();
            if (peekSize < 0)
            {
                return -2;
            }

            //if (peekSize > buffer.Length)
            //{
            //    return -3;
            //}

            /// 拆分函数
            var recvLength = UncheckRecv(writer);

            return recvLength;
        }

        /// <summary>
        /// 这个函数不检查任何参数
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        int UncheckRecv(Span<byte> buffer)
        {
#if ASSERT_STAINVOKE
            _recvassert.Enter();
#endif
#if TRIAL_BUGFIX
            var recvLength = 0;
            lock (rcv_queueLock)
            {
#endif
                var recover = false;
                if (rcv_queue.Count >= rcv_wnd)
                {
                    recover = true;
                }

                #region merge fragment.
                /// merge fragment.

#if !TRIAL_BUGFIX
                var recvLength = 0;
            lock (rcv_queueLock)
            {
#endif
                var count = 0;
                foreach (var seg in rcv_queue)
                {
                    seg.data.CopyTo(buffer.Slice(recvLength));
                    recvLength += (int)seg.len;

                    count++;
                    int frg = seg.frg;

                    LogWriteLine($"Kcp.UncheckRecv dequeued segment: {seg.ToLogString(false)}", KcpLogMask.IKCP_LOG_RECV.ToString());
                    SegmentManager.Free(seg);
                    if (frg == 0)
                    {
                        break;
                    }
                }

                if (count > 0)
                {
#if KCP_PERFORMANCE_TEST
                    for (int i = 0; i < count; i++)
                    {
                        Debug.Assert(rcv_queue.Count != 0);
                        LogWriteLine($"Kcp.UncheckRecv removed segment: {rcv_queue[0].ToLogString(false)}", KcpLogMask.IKCP_LOG_RECV.ToString());
                        rcv_queue.RemoveAt(0);
                    }
#else
                    rcv_queue.RemoveRange(0, count);
#endif
                }
#if !TRIAL_BUGFIX
            }
#endif

            #endregion

#if BUGFIX_TRIAL_20230610_001
            lock (rcv_bufLock)
            { 
#endif
                Move_Rcv_buf_2_Rcv_queue();
#if BUGFIX_TRIAL_20230610_001
            }
#endif

            #region fast recover
            /// fast recover
            if (rcv_queue.Count < rcv_wnd && recover)
            {
                // ready to send back IKCP_CMD_WINS in ikcp_flush
                // tell remote my window size
                probe |= IKCP_ASK_TELL;
            }
#if TRIAL_BUGFIX
            }
#endif
            #endregion
#if ASSERT_STAINVOKE
            _recvassert.Exit();
#endif
            return recvLength;
        }

        /// <summary>
        /// 这个函数不检查任何参数
        /// </summary>
        /// <param name="writer"></param>
        /// <returns></returns>
        int UncheckRecv(IBufferWriter<byte> writer)
        {
#if ASSERT_STAINVOKE
            _recvassert.Enter();
#endif
            var recover = false;
            if (rcv_queue.Count >= rcv_wnd)
            {
                recover = true;
            }

            #region merge fragment.
            /// merge fragment.

            var recvLength = 0;
            lock (rcv_queueLock)
            {
                var count = 0;
                foreach (var seg in rcv_queue)
                {
                    var len = (int)seg.len;
                    var destination = writer.GetSpan(len);

                    seg.data.CopyTo(destination);
                    writer.Advance(len);

                    recvLength += len;

                    count++;
                    int frg = seg.frg;

                    SegmentManager.Free(seg);
                    if (frg == 0)
                    {
                        break;
                    }
                }

                if (count > 0)
                {
                    rcv_queue.RemoveRange(0, count);
                }
            }

            #endregion

#if BUGFIX_TRIAL_20230610_001
            lock (rcv_bufLock)
            {
#endif
                Move_Rcv_buf_2_Rcv_queue();
#if BUGFIX_TRIAL_20230610_001
            }
#endif

            #region fast recover
            /// fast recover
            if (rcv_queue.Count < rcv_wnd && recover)
            {
                // ready to send back IKCP_CMD_WINS in ikcp_flush
                // tell remote my window size
                probe |= IKCP_ASK_TELL;
            }
            #endregion
#if ASSERT_STAINVOKE
            _recvassert.Exit();
#endif
            return recvLength;
        }

        /// <summary>
        /// check the size of next message in the recv queue
        /// </summary>
        /// <returns></returns>
        public int PeekSize()
        {
            lock (rcv_queueLock)
            {
                if (rcv_queue.Count == 0)
                {
                    ///没有可用包
                    return -1;
                }

                var seq = rcv_queue[0];

                if (seq.frg == 0)
                {
#if KCP_PERFORMANCE_TEST
                    Debug.Assert((int)seq.len == 3500 + 16);
#endif
                    return (int)seq.len;
                }

                if (rcv_queue.Count < seq.frg + 1)
                {
                    ///没有足够的包
                    return -1;
                }

                uint length = 0;

                foreach (var seg in rcv_queue)
                {
                    length += seg.len;
                    if (seg.frg == 0)
                    {
                        break;
                    }
                }

#if KCP_PERFORMANCE_TEST
                Debug.Assert((int)length == 3500 + 16);
#endif
                return (int)length;
            }
        }
    }
}










