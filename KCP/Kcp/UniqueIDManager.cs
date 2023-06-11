using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuterCode
{
    public class UniqueIDManager
    {
        private static Dictionary<string, UInt64> idAssigner = new();
        public readonly UInt64 ID;

        public UniqueIDManager(string friendlyName)
        {
            lock (idAssigner)
            {
                if (!idAssigner.ContainsKey(friendlyName))
                    idAssigner.Add(friendlyName, 0);
                ID = ++idAssigner[friendlyName];
            }
        }
    }
}
