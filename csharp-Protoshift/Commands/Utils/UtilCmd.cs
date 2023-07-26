using csharp_Protoshift.Commands.Utils;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class UtilCmd : ICommandHandler
    {
        public List<ICommandHandler> handlers = new();
        public UtilCmd()
        {
            handlers.Add(new DecryptCurrRegionCmd());
            handlers.Add(new GenerateCurrRegionCmd());
            handlers.Add(new Ec2bCmd());
            handlers.Add(new ConvertCmd());
            handlers.Add(new MT19937Cmd());
        }

        public string CommandName => "util";

        public string Description => "Some easy utils for PS workers.";

        public string Usage => $"util [command]{Environment.NewLine}" +
            $"Type 'util help' to get more info.";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public async Task HandleAsync(string[] args)
        {
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
                    ICommandHandler? cmd = (from utilcmd in handlers
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
                    else
                    {
                        string[] innerargs = new string[args.Length - 1];
                        if (args.Length > 1)
                        {
                            Array.Copy(args, 1, innerargs, 0, args.Length - 1);
                        }
                        await cmd.HandleAsync(innerargs);
                    }
                }
            }
        }

        private void ShowUsage()
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
