using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers
{
    public abstract class HandlerBase<TNewProtocol, TOldProtocol> : HandlerBase
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        public abstract TOldProtocol? NewShiftToOld(TNewProtocol? newprotocol);
        public abstract TNewProtocol? OldShiftToNew(TOldProtocol? oldprotocol);

        public abstract TNewProtocol GetNewShiftToOldJitInstance();
        public virtual void RunJit()
        {
            var instance = NewShiftToOld(GetNewShiftToOldJitInstance());
            OldShiftToNew(instance);
            
            var byteArray = Array.Empty<byte>();
            var span = ReadOnlySpan<byte>.Empty;
            var byteString = ByteString.Empty;
            
            NewShiftToOld(byteArray);
            OldShiftToNew(byteArray);
            NewShiftToOld(span);
            OldShiftToNew(span);
            NewShiftToOld(byteString);
            OldShiftToNew(byteString);
        }
    }

    public abstract class HandlerBase
    {
        public virtual byte[] NewShiftToOld(byte[] arr)
            => NewShiftToOld(arr, 0, arr.Length);
        public abstract byte[] NewShiftToOld(byte[] arr, int offset, int length);
        public abstract IMessage? NewShiftToOld(ReadOnlySpan<byte> span);
        public abstract ByteString NewShiftToOld(ByteString bytes);
        public virtual byte[] OldShiftToNew(byte[] arr)
            => OldShiftToNew(arr, 0, arr.Length);
        public abstract byte[] OldShiftToNew(byte[] arr, int offset, int length);
        public abstract IMessage? OldShiftToNew(ReadOnlySpan<byte> span);
        public abstract ByteString OldShiftToNew(ByteString bytes);
    }

    public abstract class HandlerEnumBase<TNewProtocol, TOldProtocol>
        where TNewProtocol : struct, System.Enum
        where TOldProtocol : struct, System.Enum
    {
        public abstract TOldProtocol NewShiftToOld(TNewProtocol newprotocol);
        public abstract TNewProtocol OldShiftToNew(TOldProtocol oldprotocol);

        public virtual TNewProtocol GetNewShiftToOldJitInstance() => Enum.GetValues<TNewProtocol>()[0];
        public virtual void RunJit()
        {
            var instance = NewShiftToOld(GetNewShiftToOldJitInstance());
            OldShiftToNew(instance);
        }
    }
}