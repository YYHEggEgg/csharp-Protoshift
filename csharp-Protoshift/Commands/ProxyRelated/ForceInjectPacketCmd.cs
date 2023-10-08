using CommandLine;
using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
#pragma warning disable CS8618
    internal class ForceInjectPacketOption
    {
        [Option('c', "conv", Required = true, HelpText = "The target client session id.")]
        public uint Conv { get; set; }
        [Option("client", Required = false, Default = false, HelpText = "Whether to sent the packet to client.")]
        public bool IsClient { get; set; }
        [Option("server", Required = false, Default = false, HelpText = "Whether to sent the packet to server.")]
        public bool IsServer { get; set; }
        [Option('p', "proto", Required = true, HelpText = "The protocol the packet body using. ")]
        public string Protoname { get; set; }
        [Option("head", Required = false, Default = null, HelpText = "The packet head protobuf content, using PacketHead.proto. ")]
        public string? Head { get; set; }
        [Option("body", Required = false, Default = null, HelpText = "The packet body protobuf content, using protocol specified in --proto. ")]
        public string? Body { get; set; }
    }
#pragma warning restore CS8618

    internal class ForceInjectPacketCmd : StandardCommandHandler<ForceInjectPacketOption>
    {
        public override string CommandName => "injectpkt";

        public override string Description => "Send a packet to the specified connection's client/server.";

        public override string Usage => $"injectpkt [options] {Environment.NewLine}" +
            $"   -c, --conv <conv_id>         The target client session id. {Environment.NewLine}" +
            $"   [--client]                   Whether to sent the packet to client. {Environment.NewLine}" +
            $"   [--server]                   Whether to sent the packet to server. {Environment.NewLine}" +
            $"   -p, --proto <protoname>    The protocol the packet body using. {Environment.NewLine}" +
            $"   [--head <packet_head_hex>]   The packet head protobuf content, using PacketHead.proto. {Environment.NewLine}" +
            $"   [--body <protobuf_body_hex>] The packet body protobuf content, using protocol specified in --proto. {Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"Notice: <color=Yellow>If you're using Windows Terminal, press Ctrl+Alt+V to paste data with multiple lines.</color>";

        public override Task HandleAsync(ForceInjectPacketOption opt)
        {
            #region REad param
            uint conv = opt.Conv;
            if (!GameSessionDispatch.sessions.ContainsKey(conv))
            {
                _logger.LogErro($"Please give a correct conv number by \"queryclient\" command!");
                return Task.CompletedTask;
            }
            if (!opt.IsClient && !opt.IsServer)
            {
                _logger.LogErro("Please specify whether to send the packet to client or server!");
                return Task.CompletedTask;
            }
            string protoname = opt.Protoname;
            byte[]? head = null;
            byte[]? body = null;
            if (opt.Head != null) head = EasyInput.TryPreProcess(opt.Head).ToByteArray();
            if (opt.Head != null) body = EasyInput.TryPreProcess(opt.Body).ToByteArray();
            if (protoname == null)
            {
                _logger.LogErro($"Please give at least protoname (--cmd)!");

                return Task.CompletedTask;
            }
            body ??= Array.Empty<byte>();
            #endregion
            if (opt.IsClient)
            {
                GameSessionDispatch.InjectPacketToClient(conv, protoname, head, body);
            }
            if (opt.IsServer)
            {
                GameSessionDispatch.InjectPacketToServer(conv, protoname, head, body);
            }
            _logger.LogInfo("ok.");
            return Task.CompletedTask;
        }
    }
}