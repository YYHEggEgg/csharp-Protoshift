using System;
using System.Threading;

namespace YSFreedom.Common.Util
{
    public class MonotonicTime
    {
        public long Resolution;
        public long Time { get { return _Time; } }

        private long _Time;
        private Thread thread;

        public MonotonicTime(long resolution = 10, long now = 0)
        {
            Resolution = resolution;
            _Time = now;
            thread = new Thread(Tick);
            thread.Start();
        }

        private void Tick()
        {
            while (true)
            {
                _Time += Resolution;
                Thread.Sleep((int)Resolution);
            }
        }

        public static readonly MonotonicTime DefaultClock = new MonotonicTime(10, (long)(Environment.TickCount & 0x7FFFFFFF));
        public static long Now { get { return DefaultClock.Time; } }
    }
}
