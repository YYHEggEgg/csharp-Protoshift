using System.Buffers;
using csharp_Protoshift.MhyKCP.Test.App;
using csharp_Protoshift.resLoader;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.MhyKCP.Test.Protocol
{
    /*
    程序统一使用标准
    Magic 以 ushort 为准
    CmdId = 55
    PacketHead 为 uint 的 ack
    Body 为 00-ff 的循环数组
    不保证线程安全
     */
    internal class BasePacket : IDisposable
    {
        public const ushort MagicStart = 0x4567;
        public const ushort MagicEnd = 0x89AB;

        public const ushort ExpectedCmdId = 55;

        private byte[] _baseBuffer;
        private int avalidlength;
        private bool bufferFromPool;
        private SingleThreadAssert _stalock = new(nameof(BasePacket));

        public readonly UInt64 Unique_ID;

        private static object increasing_id_lock = "wtf am I debugging";
        private static UInt64 increasing_id = 0;

        private uint _ack;
        public uint ack 
        {
            get => _ack;
            set
            {
                if (!isStructureValid)
                    throw new InvalidOperationException("Trying to operate on an invalid BasePacket instance.");

                _stalock.Enter();
                _ack = value;

                int offset = 0;
                offset += sizeof(ushort); // Magic Start
                offset += sizeof(ushort); // CmdId
                offset += sizeof(ushort); // HeadLen
                offset += sizeof(uint); // BodyLen

                _baseBuffer.SetUInt32(offset, _ack);
                _stalock.Exit();
            }
        }

        // 包结构是否完整 包括头是否完整、是否虚报长度等
        public bool isStructureValid;
        // 结构体是否完整 是否遵循上传时的生成规则
        public bool isBodyValid;
        public uint bodyLen;
        private bool disposedValue;

        private void InitBuffer(int length, string? invoker_log = null)
        {
            _baseBuffer = ArrayPool<byte>.Shared.Rent(length);
            avalidlength = length;
            Log.Verb($"Assigned {length} bytes from the Shared ArrayPool.", invoker_log);
            bufferFromPool = true;
            // _baseBuffer = new byte[length];
            // bufferFromPool = false;
        }

        #region 发送端 造包相关代码
#pragma warning disable CS8618 // InitBuffer
        private BasePacket(int length)
#pragma warning restore CS8618
        {
            lock (increasing_id_lock) Unique_ID = increasing_id++;
            InitBuffer(length, $"{nameof(BasePacket)}({Unique_ID})_Ctor(len)");
        }

        public static long CalculateLength(uint bodyLen)
            => sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(uint)
            + sizeof(uint) /*uint ack*/ + bodyLen + sizeof(ushort);
    
        public static BasePacket Generate(uint from_ack, uint bodyLen)
        {
            var rtn = new BasePacket((int)CalculateLength(bodyLen));
            rtn._stalock.Enter();
            rtn._ack = from_ack;
            rtn.isBodyValid = true;
            rtn.isStructureValid = true;
            rtn.bodyLen = bodyLen;
            #region 填充数组
            var buf = rtn._baseBuffer;
            int offset = 0;
            buf.SetUInt16(offset, MagicStart); // Magic Start
            offset += sizeof(ushort);
            buf.SetUInt16(offset, ExpectedCmdId); // CmdId
            offset += sizeof(ushort);
            buf.SetUInt16(offset, sizeof(uint)); // HeadLen
            offset += sizeof(ushort);
            buf.SetUInt32(offset, bodyLen); // BodyLen
            offset += sizeof(uint);
            buf.SetUInt32(offset, from_ack); // Head
            offset += sizeof(uint);
            GenerateBody(ref buf, offset, bodyLen); // Body
            offset = (int)(offset + bodyLen);
            buf.SetUInt16(offset, MagicEnd); // Magic Start
            // offset += sizeof(ushort);
            #endregion
            rtn._stalock.Exit();
            return rtn;
        }

        private static void GenerateBody(ref byte[] packet, int offset, uint length)
        {
            for (int i = 0; i < length; i++)
                packet[i + offset] = (byte)i;
        }
        #endregion

        #region 接收端 收包相关代码
#pragma warning disable CS8618 // 在 structure 为 null 时不保证实例有效。
        public BasePacket(byte[]? packet)
#pragma warning restore CS8618
        {
            _stalock.Enter();
            lock (increasing_id_lock) Unique_ID = increasing_id++;
            try
            {
                if (packet == null)
                {
                    isStructureValid = false;
                    return;
                }
                InitBuffer(packet.Length, $"{nameof(BasePacket)}({Unique_ID})_Ctor(arr)");
#pragma warning disable CS8604 // InitBuffer
                Buffer.BlockCopy(packet, 0, _baseBuffer, 0, packet.Length);
#pragma warning restore CS8604
                XorDecrypt(ref _baseBuffer);
#if DEBUG
                Log.Verb($"Created BasePacket from array (decrypted): {Convert.ToHexString(_baseBuffer, 0, Math.Min(_baseBuffer.Length, (int)CalculateLength((uint)Constants.each_packet_size)))}", $"{nameof(BasePacket)}({Unique_ID})_Ctor(arr)");
#endif
                #region 读取数组
                isStructureValid = true;
                int offset = 0;
                var _magicStart = _baseBuffer.GetUInt16(offset); // Magic Start
                if (_magicStart != MagicStart)
                {
                    Log.Verb($"Validate: Magic Start failed: read {_magicStart}, expected {MagicStart}", $"{nameof(BasePacket)}({Unique_ID})_Ctor(arr)");
                    isStructureValid = false;
                }
                offset += sizeof(ushort);
                var _cmd = _baseBuffer.GetUInt16(offset); // CmdId
                if (_cmd != ExpectedCmdId)
                {
                    Log.Verb($"Validate: CmdId failed: read {_cmd}, expected {ExpectedCmdId}", $"{nameof(BasePacket)}({Unique_ID})_Ctor(arr)");
                    isStructureValid = false;
                }
                offset += sizeof(ushort);
                var headLen = _baseBuffer.GetUInt16(offset); // HeadLen
                if (headLen != sizeof(uint))
                {
                    Log.Verb($"Validate: HeadLen failed: read {headLen}, expected {sizeof(uint)}", $"{nameof(BasePacket)}({Unique_ID})_Ctor(arr)");
                    isStructureValid = false;
                }
                offset += sizeof(ushort);
                bodyLen = _baseBuffer.GetUInt32(offset); // bodyLen
                offset += sizeof(uint);
                _ack = _baseBuffer.GetUInt32(offset); // Head
                offset += sizeof(uint);
                isBodyValid = ValidateBody(ref _baseBuffer, offset, bodyLen); // Body
                offset = (int)(offset + bodyLen);
                var _magicEnd = _baseBuffer.GetUInt16(offset); // Magic End
                isStructureValid = isStructureValid && (_magicEnd == MagicEnd);
                // offset += sizeof(ushort);
                #endregion
            }
            finally
            {
                _stalock.Exit();
            }
        }

        private static bool ValidateBody(ref byte[] packet, int offset, uint length)
        {
            for (int i = 0; i < length; i++)
            {
                if (packet[offset + i] != (byte)i) return false;
            }
            return true;
        }
        #endregion

        #region Crypto
        private static void XorDecrypt(ref byte[] encrypted, int offset = 0, int length = -1)
        {
            if (length == -1) length = encrypted.Length;
            else length = Math.Min(length, encrypted.Length - offset);
            for (int i = offset; i < offset + length; i++)
            {
                encrypted[i] = (byte)(encrypted[i] ^ Resources.dispatchKey[i % Resources.dispatchKey.Length]);
            }
        }
        #endregion

        #region 通过释放模式实现接口
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    if (bufferFromPool)
                        ArrayPool<byte>.Shared.Return(_baseBuffer);
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        // // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        // ~BasePacket()
        // {
        //     // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

        public ReadOnlySpan<byte> GetBytes()
        {
            _stalock.Enter();
            if (disposedValue)
                throw new ObjectDisposedException(nameof(BasePacket));
            XorDecrypt(ref _baseBuffer);
            var rtn = new ReadOnlySpan<byte>(_baseBuffer).Slice(0, (int)CalculateLength(bodyLen));
            _stalock.Exit();
            return rtn;
        }

        /// <summary>
        /// 将实例转为记录，不保留原始byte[]
        /// </summary>
        /// <returns></returns>
        public ReadOnlyBasePacketRecord AsReadOnly()
        {
            _stalock.Enter();
            int offset = 0;
            offset += sizeof(ushort); // Magic Start
            offset += sizeof(ushort); // CmdId
            offset += sizeof(ushort); // HeadLen
            offset += sizeof(uint); // BodyLen
            offset += sizeof(uint); // Head (ack)

            ReadOnlyBasePacketRecord rtn;
            if (isStructureValid)
            {
                rtn = new(isStructureValid, ack, bodyLen, isBodyValid,
                    isBodyValid ? null : Util.CutPacket(new ReadOnlySpan<byte>(
                        _baseBuffer, offset, avalidlength - sizeof(ushort))));
            }
            else
            {
                rtn = new(isStructureValid, ack, bodyLen, isBodyValid, null);
            }
            _stalock.Exit();
            return rtn;
        }
    }

    internal struct ReadOnlyBasePacketRecord
    {
        // 结构是否完整 不完整则其他数据均无效
        public readonly bool isStructureValid;
        public readonly uint ack;
        public readonly uint bodyLen;
        // body是否符合规范 不符合则下面分析结果List非null
        public readonly bool isBodyValid;
        // Util.CutPacket分析的结果
        public readonly List<(int startindex, int startbyte, int len)>? bodyResult;
        public readonly DateTime create_time;

        public ReadOnlyBasePacketRecord(bool isStructureValid, uint ack, uint bodyLen, bool isBodyValid, List<(int startindex, int startbyte, int len)>? bodyResult)
        {
            this.isStructureValid = isStructureValid;
            this.ack = ack;
            this.bodyLen = bodyLen;
            this.isBodyValid = isBodyValid;
            this.bodyResult = bodyResult;
            create_time = DateTime.Now;
        }
    }
}