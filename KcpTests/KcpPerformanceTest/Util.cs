using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP.Test
{
    internal class Util
    {
        /// <summary>
        /// 生成指定长度的00-FF循环的字节数组数据包
        /// </summary>
        public static byte[] GeneratePacket(int length)
        {
            byte[] rtn = new byte[length];
            for (int i = 0; i < length; i++) rtn[i] = (byte)i; // % 0xFF
            return rtn;
        }

        public static List<(int startindex, int startbyte, int len)>
            CutPacket(ReadOnlySpan<byte> pkt)
        {
            List<(int startindex, int startbyte, int len)> rtn = new();
            if (pkt.Length == 0) return rtn;

            byte curbyte = pkt[0];
            (int startindex, int startbyte, int len) curseg = (0, curbyte, 0);
            for (int i = 1; i < pkt.Length; i++)
            {
                if (pkt[i] != (byte)(curbyte + 1))
                {
                    curseg.len = i - curseg.startindex;
                    rtn.Add(curseg);
                    curseg = (i, pkt[i], 0);
                }
                curbyte = pkt[i];
            }
            curseg.len = pkt.Length - curseg.startindex;
            rtn.Add(curseg);
            return rtn;
        }
    }
}
