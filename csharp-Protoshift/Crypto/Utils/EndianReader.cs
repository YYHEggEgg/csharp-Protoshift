using System.Buffers.Binary;
using System.Text;

namespace AssetLib.Utils
{
    public class EndianReader : BinaryReader
    {
        private EndianType Endian;
        private bool IsBigEndian => Endian == EndianType.BigEndian;

        public long Length => BaseStream.Length;
        public long Remaining => BaseStream.Length - Position;
        public long Position
        {
            get => BaseStream.Position;
            set
            {
                BaseStream.Position = value;
            }
        }

        public EndianReader(string path, int position = 0, EndianType endian = EndianType.LittleEndian) : this(File.OpenRead(path), position, endian) { }
        public EndianReader(byte[] buffer, int position = 0, EndianType endian = EndianType.LittleEndian) : this(new MemoryStream(buffer), position, endian) { }
        public EndianReader(Stream stream, int position = 0, EndianType endian = EndianType.LittleEndian) : base(stream)
        {
            Position = position;
            Endian = endian;
        }
        public void Align(int alignment)
        {
            var mod = Position % alignment;
            if (mod != 0)
            {
                Position += alignment - mod;
            }
        }
        public override short ReadInt16() => IsBigEndian ? BinaryPrimitives.ReadInt16BigEndian(ReadBytes(sizeof(short))) : BinaryPrimitives.ReadInt16LittleEndian(ReadBytes(sizeof(short)));
        public override ushort ReadUInt16() => IsBigEndian ? BinaryPrimitives.ReadUInt16BigEndian(ReadBytes(sizeof(ushort))) : BinaryPrimitives.ReadUInt16LittleEndian(ReadBytes(sizeof(ushort)));
        public override int ReadInt32() => IsBigEndian ? BinaryPrimitives.ReadInt32BigEndian(ReadBytes(sizeof(int))) : BinaryPrimitives.ReadInt32LittleEndian(ReadBytes(sizeof(int)));
        public override uint ReadUInt32() => IsBigEndian ? BinaryPrimitives.ReadUInt32BigEndian(ReadBytes(sizeof(uint))) : BinaryPrimitives.ReadUInt32LittleEndian(ReadBytes(sizeof(uint)));
        public override long ReadInt64() => IsBigEndian ? BinaryPrimitives.ReadInt64BigEndian(ReadBytes(sizeof(long))) : BinaryPrimitives.ReadInt64LittleEndian(ReadBytes(sizeof(long)));
        public override ulong ReadUInt64() => IsBigEndian ? BinaryPrimitives.ReadUInt64BigEndian(ReadBytes(sizeof(ulong))) : BinaryPrimitives.ReadUInt64LittleEndian(ReadBytes(sizeof(ulong)));
        public byte[] ReadAll() => ReadBytes((int)Length);
        public byte[] ReadRemaining() => ReadBytes((int)Remaining);

        public string ReadStringToNull(int maxLength = 0x7FFF)
        {
            var bytes = new List<byte>();
            int count = 0;
            while (Remaining > 0 && count < maxLength)
            {
                var b = ReadByte();
                if (b == 0)
                {
                    break;
                }
                bytes.Add(b);
                count++;
            }
            return Encoding.UTF8.GetString(bytes.ToArray());
        }
        public int ReadMhy0Int1()
        {
            var buffer = ReadBytes(7);
            return buffer[1] | (buffer[6] << 8) | (buffer[3] << 0x10) | (buffer[2] << 0x18);
        }

        public int ReadMhy0Int2()
        {
            var buffer = ReadBytes(6);
            return buffer[2] | (buffer[4] << 8) | (buffer[0] << 0x10) | (buffer[5] << 0x18);
        }

        public string ReadMhy0String()
        {
            var bytes = ReadBytes(0x105);
            return Encoding.UTF8.GetString(bytes.TakeWhile(b => !b.Equals(0)).ToArray());
        }
        
        public byte[] ReadUInt8Array()
        {
            var count = ReadInt32();
            var bytes = ReadBytes(count);
            return bytes;
        }
    }
}
