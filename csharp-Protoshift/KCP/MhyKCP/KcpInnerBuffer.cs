using System.Buffers;

namespace csharp_Protoshift.MhyKCP
{
    internal class KcpInnerBuffer : IMemoryOwner<byte>
    {
        private readonly Memory<byte> _memory;

        public Memory<byte> Memory
        {
            get
            {
                if (alreadyDisposed)
                {
                    throw new ObjectDisposedException(nameof(KcpInnerBuffer));
                }
                return _memory;
            }
        }

        public KcpInnerBuffer(int size)
        {
            _memory = new Memory<byte>(new byte[size]);
        }

        public KcpInnerBuffer(byte[]? data)
        {
            _memory = new Memory<byte>(data);
        }

        bool alreadyDisposed = false;
        public void Dispose()
        {
            alreadyDisposed = true;
        }
    }
}
