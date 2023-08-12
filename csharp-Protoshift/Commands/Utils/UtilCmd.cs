using csharp_Protoshift.Commands.Utils;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class UtilCmd : CommandHandlerBase
    {
        public List<CommandHandlerBase> handlers = new();
        public UtilCmd()
        {
            handlers.Add(new DecryptCurrRegionCmd());
            handlers.Add(new GenerateCurrRegionCmd());
            handlers.Add(new Ec2bCmd());
            handlers.Add(new ConvertCmd());
            handlers.Add(new MT19937Cmd());
        }

        public override string CommandName => "util";

        public override string Description => "Some easy utils for PS workers.";

        public override string Usage => $"util [command]{Environment.NewLine}" +
            $"Type 'util help' to get more info.";

        public override async Task HandleAsync(string argList)
        {
            argList = argList.Trim();
            var args = argList.Split(' ');
            if (args.Length == 0) ShowUsage();
            else
            {
                var helpstrings = new HashSet<string>
                {
                    "help", "?", "--help", "-h", "-?"
                };
                if (helpstrings.Contains(args[0].ToLower())) ShowUsage();
                else
                {
                    var subargList = args.Length == 1 ? string.Empty 
                        : argList.Substring(args[0].Length + 1);
                    CommandHandlerBase? cmd = (from utilcmd in handlers
                                            where utilcmd.CommandName == args[0]
                                            select utilcmd).FirstOrDefault();
                    if (cmd == null) ShowUsage();
                    else if (helpstrings.Contains(args[1].ToLower())) 
                    {
                        Log.Info($"Command 'util {cmd.CommandName}': {cmd.Description}", nameof(UtilCmd));
                        string[] help = cmd.Usage.Split(Environment.NewLine);
                        foreach (var line in help) Log.Info(line, nameof(UtilCmd));
                        Log.Info("", nameof(UtilCmd));
                    }
                    else await cmd.HandleAsync(subargList); 
                }
            }
        }

        private new void ShowUsage()
        {
            Log.Info($"Util commands: use by util [command] [args]. ", nameof(UtilCmd));
            Log.Info($"Run util [command] [help] for more detailed info.", nameof(UtilCmd));
            Log.Info("", nameof(UtilCmd));
            foreach (var utilcmd in handlers)
            {
                Log.Info($"util {utilcmd.CommandName}: {utilcmd.Description}", nameof(UtilCmd));
            }
        }
    }
}
