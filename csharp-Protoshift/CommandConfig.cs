// Configure commands here.

namespace csharp_Protoshift.Commands
{
    internal static partial class CommandLine
    {
        private static List<ICommandHandler> ConfigureCommands()
        {
            var handlers = new List<ICommandHandler>();
            handlers.Add(new UtilCmd());
#if DEBUG
            handlers.Add(new MT19937Cmd());
            // handlers.Add(new CurrRegionCmd());
#endif
#if !PROXY_ONLY_SERVER
            handlers.Add(new SetVerboseCmd());
            // handlers.Add(new SelectRecordCmd());
            // handlers.Add(new ShowRecordCmd());
#endif
            handlers.Add(new QueryClientCmd());
            handlers.Add(new WindyCommand());
            handlers.Add(new ForceInjectPacketCmd());
            handlers.Add(new ProtoHotPatchCmd());
            return handlers;
        }
    }
}
