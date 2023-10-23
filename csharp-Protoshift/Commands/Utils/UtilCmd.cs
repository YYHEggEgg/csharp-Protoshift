using csharp_Protoshift.Commands.Utils;
using csharp_Protoshift.Commands.Protobuf;
using System.Text;

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
            handlers.Add(new ProtobufCmd());
        }

        public override string CommandName => "util";

        public override string Description => "Some easy utils for PS workers. Type 'util help' to get more info.";

        public override string Usage
        {
            get
            {
                StringBuilder sb = new();
                sb.Append($"Util commands: use by util [command] [args]. {Environment.NewLine}");
                sb.Append($"Run util [command] [help] for more detailed info.{Environment.NewLine}");
                sb.Append($"{Environment.NewLine}");
                foreach (var utilcmd in handlers)
                {
                    sb.Append($"util {utilcmd.CommandName}: {utilcmd.Description}{Environment.NewLine}");
                }
                return sb.ToString();
            }
        }

        public override async Task HandleAsync(string argList)
        {
            argList = argList.Trim();
            var args = argList.Split(' ');
            if (args.Length == 0) ShowUsage();
            else
            {
                if (HelpStrings.Contains(argList.Trim().ToLower())) ShowUsage();
                else
                {
                    var subargList = args.Length == 1 ? string.Empty 
                        : argList.Substring(args[0].Length + 1);
                    CommandHandlerBase? cmd = (from utilcmd in handlers
                                            where utilcmd.CommandName == args[0]
                                            select utilcmd).FirstOrDefault();
                    if (cmd == null) ShowUsage();
                    else if (HelpStrings.Contains(args[1].ToLower())) 
                    {
                        _logger.LogInfo($"Command 'util {cmd.CommandName}': {cmd.Description}");
                        string[] help = cmd.Usage.Split(Environment.NewLine);
                        foreach (var line in help) _logger.LogInfo(line);
                        _logger.LogInfo("");
                    }
                    else await cmd.HandleAsync(subargList); 
                }
            }
        }
    }
}
