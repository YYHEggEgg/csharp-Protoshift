using System.Diagnostics;

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

        public static string GetInvoker()
        {
            StackTrace stackTrace = new StackTrace();
            StackFrame? frame = stackTrace.GetFrame(2);
            return frame.ToString();
        }

        /// <summary>
        /// Can be applied to both file and directory. Generate suffix like (1), (2) for the <paramref name="path"/> when the file/directory already exists.
        /// </summary>
        public static string AddNumberedSuffixToPath(string filePath)
        {
            /* 该方法首先检查给定路径是否已存在。
             * 如果是文件路径，则将文件名分离为文件名和扩展名，并在文件名后添加一个括号附加编号，直到找到可用的文件名。
             * 如果是目录路径，则附加数字后缀到目录名直到找到可用的目录名。
             * 例如，如果传入的参数是"C:\Users\Example\Desktop\test.txt"，
             * 如果该路径已经存在，则返回"C:\Users\Example\Desktop\test (1).txt"。 
             * 
             * 如果参数是"C:\Users\Example\Desktop\test"，
             * 如果该路径已经存在，则返回"C:\Users\Example\Desktop\test (1)"。 
             * 如果路径不存在，则返回原始路径。
             */
            if (File.Exists(filePath))
            {
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                string newFilePath = filePath;
                int suffix = 1;

                while (File.Exists(newFilePath))
                {
                    newFilePath = Path.Combine(directory, string.Format("{0} ({1}){2}", fileName, suffix, extension));
                    suffix++;
                }

                return newFilePath;
            }
            else if (Directory.Exists(filePath))
            {
                string directoryName = Path.GetDirectoryName(filePath);
                string directory = Path.Combine(directoryName, Path.GetFileName(filePath));
                string newDirectory = directory;
                int suffix = 1;

                while (Directory.Exists(newDirectory))
                {
                    newDirectory = Path.Combine(directoryName, string.Format("{0} ({1})", Path.GetFileName(filePath), suffix));
                    suffix++;
                }

                return newDirectory;
            }
            else
            {
                return filePath;
            }
        }
    }
}
