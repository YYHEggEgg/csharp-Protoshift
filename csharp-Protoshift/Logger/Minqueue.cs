using System.Collections.Generic;

namespace YYHEggEgg.Logger
{
    /// <summary>
    /// A queue that always keep the count of elements in a certain number. Newer values will replace older values.
    /// </summary>
    public class Minqueue<T>
    {
        public int MaxCount { get; set; }
        private LinkedList<T> deque;

        public Minqueue<T>(int maxCount)
        {
            MaxCount = maxCount;
            deque = new(maxCount);
        }

        public void Add(T item)
        {
            int _maxcount = MaxCount; // Make persistent copy
            lock (deque)
            {
                deque.AddAfter(item);
                while (deque.Count > _maxcount)
                {
                    deque.RemoveFirst();
                }
            }
        }

        public T[] GetCurrent()
        {
            lock (deque)
            {
                var curcount = deque.Count;
                var res = new T[curcount];
                deque.CopyTo(res, 0);
                return res;
            }
        }

        public T GetLast()
        {
            lock (deque) return deque.Last.Value;
        }
    }
}