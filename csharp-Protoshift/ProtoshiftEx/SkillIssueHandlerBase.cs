using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers
{
    public abstract class SkillIssueHandlerBase<TNewProtocol, TOldProtocol>
        : HandlerBase<TNewProtocol, TOldProtocol>
        where TNewProtocol : IMessage<TNewProtocol>
        where TOldProtocol : IMessage<TOldProtocol>
    {
        public abstract void DetectSkillIssue(
            TNewProtocol newprotocol, TOldProtocol oldprotocol);
    }
}