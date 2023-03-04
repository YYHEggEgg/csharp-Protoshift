using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XC.RSAUtil;

namespace csharp_Protoshift.resLoader
{
    public static class Resources
    {
        public static byte[] dispatchKey = new byte[] { };
        public static byte[] dispatchSeed = new byte[] { };
        public static Dictionary<uint, RSAUtilBase> CPri = new();
        public static Dictionary<uint, RSAUtilBase> SPri = new();
    }
}
