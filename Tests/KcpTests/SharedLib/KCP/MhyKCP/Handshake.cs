using System.Buffers.Binary;
using YSFreedom.Common.Util;

namespace csharp_Protoshift.MhyKCP
{
    public class Handshake
    {
        public static readonly uint[] MAGIC_CONNECT = { 0xFF, 0xFFFFFFFF };
        public static readonly uint[] MAGIC_SEND_BACK_CONV = { 0x145, 0x14514545 };
        public static readonly uint[] MAGIC_DISCONNECT = { 0x194, 0x19419494 };
        public const int LEN = 20;

        public uint Magic1;
        public uint Conv;
        public uint Token;
        public uint Data;
        public uint Magic2;

        public Handshake() { }
        public Handshake(uint[] magic, uint conv = 0, uint token = 0, uint data = 0)
        {
            Magic1 = magic[0];
            Conv = conv;
            Token = token;
            Data = data;
            Magic2 = magic[1];
        }

        public void Encode(byte[] buffer)
        {
            buffer.SetUInt32(0, Magic1);
            buffer.SetUInt32(4, Conv);
            buffer.SetUInt32(8, Token);
            buffer.SetUInt32(12, Data);
            buffer.SetUInt32(16, Magic2);
        }

        public static Handshake Parse(byte[] buffer)
        {
            var rtn = new Handshake();
            rtn.Encode(buffer);
            return rtn;
        }

        public void Decode(byte[] buffer, uint[]? verifyMagic = null)
        {
            if (buffer.Length < LEN)
                throw new ArgumentException("Handshake packet too small", nameof(buffer));

            Magic1 = buffer.GetUInt32(0);
            Conv = buffer.GetUInt32(4);
            Token = buffer.GetUInt32(8);
            Data = buffer.GetUInt32(12);
            Magic2 = buffer.GetUInt32(16);

            if (verifyMagic != null)
            {
                if (Magic1 != verifyMagic[0] || Magic2 != verifyMagic[1])
                    throw new ArgumentException("Invalid handshake packet", nameof(buffer));
            }
        }
        public void Decode(Memory<byte> buffer, uint[]? verifyMagic = null)
        {
            if (buffer.Length < LEN)
                throw new ArgumentException("Handshake packet too small", nameof(buffer));

            Magic1 = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(0, 4).Span);
            Conv = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(4, 4).Span);
            Token = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(8, 4).Span);
            Data = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(12, 4).Span);
            Magic2 = BinaryPrimitives.ReadUInt32BigEndian(buffer.Slice(16, 4).Span);

            if (verifyMagic != null)
            {
                if (Magic1 != verifyMagic[0] || Magic2 != verifyMagic[1])
                    throw new ArgumentException("Invalid handshake packet", nameof(buffer));
            }
        }

        public byte[] AsBytes()
        {
            var ret = new byte[20];
            Encode(ret);
            return ret;
        }
    }
}