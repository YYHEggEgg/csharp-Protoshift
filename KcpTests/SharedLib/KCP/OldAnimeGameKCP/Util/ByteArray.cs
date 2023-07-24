using System.Text;

namespace YSFreedom.Common.Util
{
    public static class ByteArray
    {
        public static void SetUInt16(this byte[] arr, int offset, ushort value)
        {
            arr[offset + 1] = (byte)(value & 0xFF);
            arr[offset + 0] = (byte)((value & 0xFF00) >> 8);
        }

        public static void SetUInt32(this byte[] arr, int offset, uint value)
        {
            arr[offset + 3] = (byte)(value & 0xFF);
            arr[offset + 2] = (byte)((value & 0xFF00) >> 8);
            arr[offset + 1] = (byte)((value & 0xFF0000) >> 16);
            arr[offset + 0] = (byte)((value & 0xFF000000) >> 24);
        }

        public static void SetUInt64(this byte[] arr, int offset, ulong value)
        {
            arr[offset + 7] = (byte)(value & 0xFF);
            arr[offset + 6] = (byte)((value & 0xFF00) >> 8);
            arr[offset + 5] = (byte)((value & 0xFF0000) >> 16);
            arr[offset + 4] = (byte)((value & 0xFF000000) >> 24);
            arr[offset + 3] = (byte)((value & 0xFF00000000) >> 32);
            arr[offset + 2] = (byte)((value & 0xFF0000000000) >> 40);
            arr[offset + 1] = (byte)((value & 0xFF000000000000) >> 48);
            arr[offset + 0] = (byte)((value & 0xFF00000000000000) >> 56);
        }

        public static ushort GetUInt16(this byte[] arr, int offset)
        {
            ushort ret = (ushort)((ushort)arr[offset + 1] | ((ushort)arr[offset + 0] << 8));
            return ret;
        }

        public static uint GetUInt32(this byte[] arr, int offset)
        {
            uint ret = ((uint)arr[offset + 3] | ((uint)arr[offset + 2] << 8) |
                         ((uint)arr[offset + 1] << 16) | ((uint)arr[offset + 0] << 24));
            return ret;
        }

        public static ulong GetUInt64(this byte[] arr, int offset)
        {
            ulong ret = ((ulong)arr[offset + 7]) | ((ulong)arr[offset + 6] << 8) |
                         ((ulong)arr[offset + 5] << 16) | ((ulong)arr[offset + 4] << 24) |
                         ((ulong)arr[offset + 3] << 32) | ((ulong)arr[offset + 2] << 40) |
                         ((ulong)arr[offset + 1] << 48) | ((ulong)arr[offset + 0] << 56);
            return ret;
        }

        public static byte[] Fill0(this byte[] arr, int toLength)
        {
            if (arr.Length < toLength)
            {
                var rtn = new byte[toLength];
                Array.Copy(arr, 0, rtn, 0, arr.Length);
                for(int i = arr.Length; i < toLength; i++)
                {
                    rtn[i] = 0;
                }
                return rtn;
            }
            return arr;
        }

        public static string HexDump(this byte[] bytes, int bytesPerLine = 16)
        {
            if (bytes == null) return "<null>";
            Int32 bytesLength = bytes.Length;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            Int32 firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            Int32 firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            Int32 lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - Environment.NewLine.Length) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            result.Append($"HexDump - Length : {bytes.Length}\n");

            for (Int32 i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                Int32 hexColumn = firstHexColumn;
                Int32 charColumn = firstCharColumn;

                for (Int32 j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '�' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
            return result.ToString();
        }
    }
}
