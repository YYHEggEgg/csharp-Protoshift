using CommandLine;

namespace csharp_Protoshift.Commands
{
    internal class TargetCmdOption
    {
        [Value(0, Required = true, HelpText = "The default player UID you want to use in other commands (if needed).")]
        public uint Uid { get; set; }
    }

    internal class TargetCmd : StandardCommandHandler<TargetCmdOption>
    {
        public override string CommandName => "target";

        public override string Description => "Set a default player UID in proxy related commands.";

        public override string Usage => "target <player_uid>";

        public override Task HandleAsync(TargetCmdOption o)
        {
            if (o.Uid == 0)
            {
                _logger.LogErro($"Please provide a valid uid (not zero)!");
            }
            else
            {
                TargetManager.TargetUid = o.Uid;
                _logger.LogInfo($"OK.");
            }
            return Task.CompletedTask;
        }
    }
}