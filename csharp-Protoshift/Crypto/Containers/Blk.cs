using AssetLib.Utils;

#pragma warning disable CS8618, CS8625
namespace AssetLib.Containers
{
    public class Blk
    {
        private const int KeySize = 0x1000;
        private const int SeedBlockSize = 0x800;

        private byte[] XORPad = new byte[KeySize];
        private byte[] Buffer;
        private byte[] Key;
        private int SeedSize;
        private int DataSize;
        private bool IsEc2b;

        private byte[] ExpansionKey;
        private byte[] SBox;
        private byte[] ConstKey;
        private ulong Const;

        public Blk(EndianReader reader, byte[] expansionKey, byte[] constKey, ulong key, byte[] sbox = null, bool isEc2b = false)
        {
            var count = reader.ReadInt32();
            Key = reader.ReadBytes(count);
            IsEc2b = isEc2b;
            if (IsEc2b)
            {
                SeedSize = reader.ReadInt32();
            }
            else
            {
                reader.Position += count;
                SeedSize = reader.ReadInt16();
            }
            SeedSize = Math.Min(SeedSize, IsEc2b ? SeedBlockSize : SeedBlockSize * 2);
            ExpansionKey = expansionKey;
            ConstKey = constKey;
            SBox = sbox;
            Const = key;
        }

        public Blk(int dataSize, byte[] expansionKey, byte[] constKey, ulong key, byte[] sbox = null, bool isEc2b = false)
        {
            Key = new byte[0x10];
            IsEc2b = isEc2b;
            DataSize = dataSize;
            SeedSize = Math.Min(DataSize / 8 * 8, SeedBlockSize);
            ExpansionKey = expansionKey;
            ConstKey = constKey;
            SBox = sbox;
            Const = key;
        }

        public byte[] Decrypt(EndianReader reader)
        {
            ReadBlock(reader);
            var keySeed = CalculateSeed();
            var seed = DecryptKey(keySeed);
            GenerateXorpad(seed);

            var writer = new EndianWriter();
            if (IsEc2b)
            {
                writer.Write(XORPad);
            }
            else
            {
                XORBlock();
                writer.Write(Buffer);
            }
            return writer.ToArray();
        }

        public void Encrypt(ulong seed, EndianWriter writer, EndianReader reader = null)
        {
            if (IsEc2b)
            {
                GenerateData();
            }
            else
            {
                ReadBlock(reader);
            }

            GenerateXorpad(seed);

            if (!IsEc2b)
            {
                XORBlock();
            }

            var keySeed = CalculateSeed();
            GenerateKey(seed, keySeed);

            if (IsEc2b)
            {
                writer.WriteString("Ec2b");
                writer.Write(0x10);
                writer.Write(Key);
                writer.Write(SeedSize);
            }
            else
            {
                writer.WriteString("blk", true);
                writer.Write(0x10);
                writer.Write(Key);
                writer.Write(0xFF, 0x10);
                writer.Write((short)SeedSize);
            }
            writer.Write(Buffer);
        }

        public void ReadBlock(EndianReader reader)
        {
            DataSize = (int)reader.Remaining;
            Buffer = reader.ReadBytes(DataSize);
        }

        public ulong CalculateSeed()
        {
            ulong keySeed = ulong.MaxValue;
            var seedReader = new EndianReader(Buffer);
            for (int i = 0; i < SeedSize / 8; i++)
            {
                keySeed ^= seedReader.ReadUInt64();
            }

            return keySeed;
        }

        public ulong DecryptKey(ulong keySeed)
        {
            DecryptKey();
            var keyReader = new EndianReader(Key);
            var keyLow = keyReader.ReadUInt64();
            var keyHigh = keyReader.ReadUInt64();
            var seed = keyLow ^ keyHigh ^ keySeed ^ Const;

            return seed;
        }

        public ulong EncryptKey(ulong keySeed)
        {
            EncryptKey();
            var keyReader = new EndianReader(Key);
            var keyLow = keyReader.ReadUInt64();
            var keyHigh = keyReader.ReadUInt64();
            var seed = keyLow ^ keyHigh ^ keySeed ^ Const;

            return seed;
        }

        public void DecryptKey()
        {
            if (SBox != null)
            {
                for (int i = 0; i < 0x10; i++)
                {
                    Key[i] = SBox[(i % 4 * 0x100) | Key[i]];
                }
            }

            AES.Decrypt(Key, ExpansionKey);

            for (int i = 0; i < 0x10; i++)
            {
                Key[i] ^= ConstKey[i];
            }
        }

        public void EncryptKey()
        {
            for (int i = 0; i < 0x10; i++)
            {
                Key[i] ^= ConstKey[i];
            }

            AES.Encrypt(Key, ExpansionKey);

            if (SBox != null)
            {
                for (int i = 0; i < 0x10; i++)
                {
                    Key[i] = (byte)(Array.IndexOf(SBox, Key[i], i % 4 * 0x100, 0x100) % 0x100);
                }
            }
        }

        public void GenerateData()
        {
            var writer = new EndianWriter();
            for (int i = 0; i < DataSize / 8; i++)
            {
                writer.Write(Random.Shared.NextInt64());
            }
            Buffer = writer.ToArray();
        }

        public void GenerateXorpad(ulong seed)
        {
            var rand = new MT19937_64(seed);
            var xorpadWriter = new EndianWriter(XORPad);
            for (int i = 0; i < KeySize / 8; i++)
            {
                xorpadWriter.Write(rand.Int64());
            }      
        }

        public void GenerateKey(ulong seed, ulong keySeed)
        {
            var keyLow = (ulong)Random.Shared.NextInt64();
            var keyHigh = keyLow ^ seed ^ keySeed ^ Const;

            var keyWriter = new EndianWriter(Key);
            keyWriter.Write(keyLow);
            keyWriter.Write(keyHigh);
            EncryptKey();
        }

        public void XORBlock()
        {
            for (int i = 0; i < DataSize; i++)
            {
                Buffer[i] ^= XORPad[i % KeySize];
            }  
        }
    }
}
#pragma warning restore CS8618, CS8625
