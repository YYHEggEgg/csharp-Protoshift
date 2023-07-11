﻿// Configure commands here.

namespace csharp_Protoshift.Commands
{
    internal static partial class CommandLine
    {
        private static List<ICommandHandler> ConfigureCommands()
        {
            var handlers = new List<ICommandHandler>();
#if DEBUG
            handlers.Add(new MT19937Cmd());
#endif
#if !PROXY_ONLY_SERVER
            handlers.Add(new SetVerboseCmd());
            handlers.Add(new SelectRecordCmd());
            handlers.Add(new ShowRecordCmd());
            handlers.Add(new UnionSelectCmd());
#endif
            handlers.Add(new QueryClientCmd());
            handlers.Add(new WindyCommand());
            return handlers;
        }
    }
}
