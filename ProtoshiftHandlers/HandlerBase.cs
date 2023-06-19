using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers
{
    public abstract class HandlerBase<TNewProtocol, TOldProtocol> : HandlerBase
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        public abstract TOldProtocol NewShiftToOld(TNewProtocol newprotocol);
        public abstract TNewProtocol OldShiftToNew(TOldProtocol oldprotocol);
    }

    public abstract class HandlerBase
    {
        public virtual byte[] NewShiftToOld(byte[] arr)
            => NewShiftToOld(arr, 0, arr.Length);
        public abstract byte[] NewShiftToOld(byte[] arr, int offset, int length);
        public abstract byte[] NewShiftToOld(ReadOnlySpan<byte> span);
        public virtual byte[] OldShiftToNew(byte[] arr)
            => OldShiftToNew(arr, 0, arr.Length);
        public abstract byte[] OldShiftToNew(byte[] arr, int offset, int length);
        public abstract byte[] OldShiftToNew(ReadOnlySpan<byte> span);
    }

    public abstract class HandlerEnumBase<TNewProtocol, TOldProtocol>
        where TNewProtocol : System.Enum
        where TOldProtocol : System.Enum
    {
        public abstract TOldProtocol NewShiftToOld(TNewProtocol newprotocol);
        public abstract TNewProtocol OldShiftToNew(TOldProtocol oldprotocol);
    }
}