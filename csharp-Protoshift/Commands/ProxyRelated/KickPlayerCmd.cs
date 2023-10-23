using CommandLine;

namespace csharp_Protoshift.Commands
{
    internal class KickPlayerOption : TargetOptionBase
    {
        [Option("client-reason", Required = false, Default = 5u, HelpText = "The disconnect reason that will be sent to client. Default is ENET_SERVER_KICK (The connection to the server has been lost).")]
        public uint ClientReason { get; set; }
        [Option("server-reason", Required = false, Default = 1u, HelpText = "The disconnect reason that will be sent to server. Default is ENET_CLIENT_CLOSE.")]
        public uint ServerReason { get; set; }
    }

    internal class KickPlayerCmd : StandardCommandHandler<KickPlayerOption>
    {
        public override string CommandName => "kick";

        public override string Description => $"kick a specified session.";

        public override string Usage => 
            $"kick <player_uid> | -c <conv_id>       The target conv to be kicked. {Environment.NewLine}" +
            $"     [--client-reason <ENetReason_id>] The disconnect reason that will be sent to client. Default is ENET_SERVER_KICK (The connection to the server has been lost). {Environment.NewLine}" +
            $"     [--server-reason <ENetReason_id>] The disconnect reason that will be sent to server. Default is ENET_CLIENT_CLOSE.";

        public override Task HandleAsync(KickPlayerOption o)
        {
            var conv = o.GetConv(_logger);
            if (conv != 0)
            {
                Program.ProxyServer.KickSession(conv, o.ClientReason, o.ServerReason);
                _logger.LogInfo("Session kick succeeded.");
            }
            return Task.CompletedTask;
        }
    }
}