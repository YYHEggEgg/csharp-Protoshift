using Google.Protobuf;

namespace csharp_Protoshift.Protoshift.Ex.Handlers
{
    public abstract class HandlerBase<TNewProtocol, TOldProtocol>
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        public abstract TOldProtocol NewShiftToOld(TNewProtocol newprotocol);
        public abstract TNewProtocol OldShiftToNew(TOldProtocol oldprotocol);
    }
}