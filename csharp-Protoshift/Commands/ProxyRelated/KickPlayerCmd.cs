using CommandLine;
using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class KickPlayerOption
    {
        [Value(0, Required = true, HelpText = "The target conv to be kicked.")]
        public uint Conv { get; set; }
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
            $"kick <conv_id>                         The target conv to be kicked. {Environment.NewLine}" +
            $"     [--client-reason <ENetReason_id>] The disconnect reason that will be sent to client. Default is ENET_SERVER_KICK (The connection to the server has been lost). {Environment.NewLine}" +
            $"     [--server-reason <ENetReason_id>] The disconnect reason that will be sent to server. Default is ENET_CLIENT_CLOSE.";

        private LoggerChannel _logger = Log.GetChannel(nameof(KickPlayerCmd));

        public override Task HandleAsync(KickPlayerOption o)
        {
            if (!GameSessionDispatch.sessions.ContainsKey(o.Conv))
            {
                _logger.LogErro($"Unknown session id. Use command 'queryclient' to get a valid one.");
            }
            else
            {
                Program.ProxyServer.KickSession(o.Conv, o.ClientReason, o.ServerReason);
                _logger.LogInfo("Session kick succeeded.");
            }
            return Task.CompletedTask;
        }
    }
}