using System.Buffers.Binary;
using System.Text;

namespace AssetLib.Utils
{
    public class EndianWriter : BinaryWriter
    {
        private byte[] temp;
        private EndianType Endian;
        private bool IsBigEndian => Endian == EndianType.BigEndian;

        public long Length => BaseStream.Length;
        public long Position
        {
            get => BaseStream.Position;
            set
            {
                BaseStream.Position = value;
            }
        }

        public EndianWriter(byte[] buffer, int position = 0, EndianType endian = EndianType.LittleEndian) : this(new MemoryStream(buffer), position, endian) { }
        public EndianWriter(int position = 0, EndianType endian = EndianType.LittleEndian) : this(new MemoryStream(), position, endian) { }
        public EndianWriter(Stream stream, int position = 0, EndianType endian = EndianType.LittleEndian) : base(stream)
        {
            Endian = endian;
            Position = position;
            temp = new byte[8];
        }

        public byte[] ToArray()
        {
            Position = 0;
            using var ms = new MemoryStream();
            BaseStream.CopyTo(ms);
            return ms.ToArray();
        }

        public override void Write(short value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteInt16BigEndian(temp, value); 
            }
            else
            {
                BinaryPrimitives.WriteInt16LittleEndian(temp, value);
            }
            Write(temp, 0, 2);
        }
        public override void Write(ushort value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteUInt16BigEndian(temp, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt16LittleEndian(temp, value);
            }
            Write(temp, 0, 2);
        }

        public override void Write(int value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteInt32BigEndian(temp, value);
            }
            else
            {
                BinaryPrimitives.WriteInt32LittleEndian(temp, value);
            }
            Write(temp, 0, 4);
        }

        public override void Write(uint value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteUInt32BigEndian(temp, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt32LittleEndian(temp, value);
            }
            Write(temp, 0, 4);
        }

        public override void Write(long value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteInt64BigEndian(temp, value);
            }
            else
            {
                BinaryPrimitives.WriteInt64LittleEndian(temp, value);
            }
            Write(temp, 0, 8);
        }

        public override void Write(ulong value)
        {
            if (IsBigEndian)
            {
                BinaryPrimitives.WriteUInt64BigEndian(temp, value);
            }
            else
            {
                BinaryPrimitives.WriteUInt64LittleEndian(temp, value);
            }
            Write(temp, 0, 8);
        }

        public void WriteString(string str, bool hasTirmenator = false)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            Write(bytes);
            if (hasTirmenator)
            {
                Write((byte)0);
            } 
        }

        public void WriteUInt8Array(byte[] data)
        {
            Write(data.Length);
            Write(data);
        }

        public void Write(byte value, int count)
        {
            var bytes = new byte[count];
            for (int i = 0; i < count; i++)
            {
                bytes[i] = value;
            }

            Write(bytes);
        }
        public void WriteMhy0Int1(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            temp[0] = (byte)(bytes[0] + 0);
            temp[1] = bytes[0];
            temp[2] = bytes[3];
            temp[3] = bytes[2];
            temp[4] = (byte)(bytes[0] + 4);
            temp[5] = (byte)(bytes[0] + 5);
            temp[6] = bytes[1];

            Write(temp, 0, 7);
        }

        public void WriteMhy0Int2(int value)
        {
            var bytes = BitConverter.GetBytes(value);
            temp[0] = bytes[2];
            temp[1] = (byte)(bytes[0] + 1);
            temp[2] = bytes[0];
            temp[3] = (byte)(bytes[0] + 3);
            temp[4] = bytes[1];
            temp[5] = bytes[3];

            Write(temp, 0, 6);
        }

        public void WriteMhy0String(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            Array.Resize(ref bytes, 0x105);
            Write(bytes);
        }
    }
}
