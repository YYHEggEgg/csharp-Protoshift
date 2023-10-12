// Configure commands here.

namespace csharp_Protoshift.Commands
{
    internal static partial class ServerCommandLine
    {
        private static List<CommandHandlerBase> ConfigureCommands()
        {
            var handlers = new List<CommandHandlerBase>();
            handlers.Add(new UtilCmd());
#if !PROXY_ONLY_SERVER
            handlers.Add(new SetVerboseCmd());
            // handlers.Add(new SelectRecordCmd());
            // handlers.Add(new ShowRecordCmd());
            handlers.Add(new ProtoHotPatchCmd());
#endif
            handlers.Add(new QueryClientCmd());
            handlers.Add(new WindyCommand());
            handlers.Add(new ForceInjectPacketCmd());
            handlers.Add(new KickPlayerCmd());
            handlers.Add(new TargetCmd());
            return handlers;
        }
    }
}
