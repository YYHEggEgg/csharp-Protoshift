using Microsoft.IO;

namespace YSFreedom.Common.Util
{
    public class RecyclableMemoryStream
    {
        private const Int32 BlockSize = 4096;
        private const Int32 LargeBufferMultiple = 1048576;
        private const Int32 MaxBufferSize = 536870912;

        public static MemoryStream Create() { return Manager.GetStream(); }
        public static MemoryStream Create(Int32 size, String tag = "") { return Manager.GetStream(tag, size); }
        public static MemoryStream Create(byte[] buffer, String tag = "") { return Manager.GetStream(tag, buffer, 0, buffer.Length); }
        public static MemoryStream Create(byte[] buffer, Int32 offset, Int32 length, String tag = "") { return Manager.GetStream(tag, buffer, offset, length); }

        public static RecyclableMemoryStreamManager Manager = new RecyclableMemoryStreamManager(BlockSize, LargeBufferMultiple, MaxBufferSize);
    }
}
