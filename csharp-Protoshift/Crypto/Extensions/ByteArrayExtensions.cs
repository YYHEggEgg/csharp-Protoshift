using System.Text;

namespace AssetLib.Extensions
{
    public static class ByteArrayExtensions
    {
        public static int Search(this byte[] src, string value)
        {
            var pattern = Encoding.UTF8.GetBytes(value);
            int maxFirstCharSlot = src.Length - pattern.Length + 1;
            for (int i = 0; i < maxFirstCharSlot; i++)
            {
                if (src[i] != pattern[0])
                    continue;

                for (int j = pattern.Length - 1; j >= 1; j--)
                {
                    if (src[i + j] != pattern[j]) break;
                    if (j == 1) return i;
                }
            }
            return int.MaxValue;
        }
    }
}
