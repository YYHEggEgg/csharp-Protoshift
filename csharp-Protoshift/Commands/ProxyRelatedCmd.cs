using CommandLine;
using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
#if !PROXY_ONLY_SERVER
    internal class SetVerboseOption
    {
        [Option('c', "conv", Required = true, HelpText = "The target conv id.")]
        public uint Conv { get; set; }
        [Option('v', "verbose", Required = true, HelpText = "Whether to show packet info of this session.")]
        public bool Verbose { get; set; }
    }

    internal class SetVerboseCmd : StandardCommandHandler<SetVerboseOption>
    {
        public override string CommandName => "setverbose";

        public override string Description => "Set a specified connection's packet verbose mode.";

        public override string Usage => $"setverbose -c <conv_id> -v <true/false>{Environment.NewLine}" +
            $"If false, then packets working fine will not produce any output in the commandline.{Environment.NewLine}" +
            "You may use this when you have entered the game successfully and want to use some commands.";

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public override async Task HandleAsync(SetVerboseOption opt)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            GameSessionDispatch.sessions[opt.Conv].Verbose = opt.Verbose;
            Log.Info($"Succeed set Conv:{opt.Conv} Verbose Mode to {opt.Verbose}.", nameof(SetVerboseCmd));
        }
    }

    //     internal class SelectRecordCmd : ICommandHandler
    //     {
    //         public string CommandName => "select";

    //         public string Description => "Select specified packet records with a given proto name.";

    //         public string Usage => "select <conv_id> <protoname>";

    // #pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
    //         public async Task HandleAsync(string[] args)
    // #pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
    //         {
    //             uint conv = uint.Parse(args[0]);
    //             string protoname = args[1];
    //             var records = GameSessionDispatch.sessions[conv].QueryPacketRecords(protoname);
    //             Log.Info($"Found {records.Count} records match. Use 'show <conv> <id>' to show more info of a specified packet.", "SelectRecordCmd");
    //             Log.Info($"Notice that packets detected skill issue will be added a star(*).");
    //             string found = "Match Packets: ";
    //             foreach (var record in records)
    //             {
    //                 found += $"{record.Id}{(record.dataLostSign ? "*" : "")}; ";
    //             }
    //             Log.Info(found, "SelectRecordCmd");
    //         }
    //     }

    //     internal class ShowRecordCmd : ICommandHandler
    //     {
    //         public string CommandName => "show";

    //         public string Description => "Show a specified packet record with it's ID.";

    //         public string Usage => $"show <conv_id> <packet_id>{Environment.NewLine}" +
    //             "packet_id can be gained from 'select' command.";

// #pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
//         public async Task HandleAsync(string[] args)
// #pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
//         {
//             uint conv = uint.Parse(args[0]);
//             int packetId = int.Parse(args[1]);
//             var packet = GameSessionDispatch.sessions[conv].QueryPacketRecordById(packetId);
//             Log.Info($"Packet {packetId}, {packet.packetTime:yyyy-MM-dd HH:mm:ss}: " +
//                 $"{packet.PacketName}, CmdId:{packet.CmdId} from " +
//                 $"{(packet.sentByClient ? "Client" : "Server")}", "ShowRecordCmd");
//             Log.Info($"Original body bin data: {Convert.ToHexString(packet.data)}", "ShowRecordCmd");
//             Log.Info($"Shifted body bin data: {Convert.ToHexString(packet.shiftedData)}", "ShowRecordCmd");
//             Log.Info($"Packet with old protocol: {packet.oldjsonContent}", "ShowRecordCmd");
//             Log.Info($"Packet with new protocol: {packet.newjsonContent}", "ShowRecordCmd");
//             if (packet.dataLostSign)
//             {
//                 Log.Warn("IMPORTANT: This packet is marked as having data lost and may caused SKILL ISSUEs.", "ShowRecordCmd");
//             }
//         }
//     }
#endif

    internal class QueryClientOption
    {
        [Option('l', "limit", Required = false, Default = 50, HelpText = "The output limit of query result.")]
        public int Limit { get; set; }
        [Option("range-min", Required = false, Default = uint.MinValue, HelpText = "The minimum value of query range.")]
        public uint MinUid { get; set; }
        [Option("range-max", Required = false, Default = uint.MaxValue, HelpText = "The maximum value of query range.")]
        public uint MaxUid { get; set; }
    }
        
    internal class QueryClientCmd : StandardCommandHandler<QueryClientOption>
    {
        public override string CommandName => "queryclient";

        public override string Description => "Query the online sessions' conv with given UID range. ";

        public override string Usage => $"queryclient [--limit=50] {Environment.NewLine}" +
            $"  [--range-min <uid_min> --range-max <uid_max>]{Environment.NewLine}" +
            $"  Query the online convs with given UID range. Default output limit is 50, so use --range-min/-max when query exceeded limit. ";

        public override Task HandleAsync(QueryClientOption opt)
        {
            int limit = opt.Limit;
            uint uid_min = Math.Max(1, opt.MinUid);
            uint uid_max = opt.MaxUid;
            List<KeyValuePair<uint, HandlerSession>> search_res = new((
                from pair in GameSessionDispatch.sessions
                let uid = pair.Value.Uid
                where uid >= uid_min && uid <= uid_max
                select pair).Concat(
                    from pair in GameSessionDispatch.sessions
                    let uid = pair.Value.Uid
                    where uid == 0 && opt.MinUid == 0
                    select pair));
            if (search_res.Count == 0)
            {
                Log.Info($"No match sessions found.", nameof(QueryClientCmd));
            }
            else for (int i = 0; i < search_res.Count; i++)
                {
                    if (i >= limit)
                    {
                        Log.Warn($"Session counts exceeded limit {limit} (total: {search_res.Count}).", nameof(QueryClientCmd));
                        Log.Warn("You may use --range <uid_min> <uid_max> or change the limit, and run the command again.", nameof(QueryClientCmd));
                        break;
                    }
                    Log.Info($"Found uid: {search_res[i].Value.Uid}, conv: {search_res[i].Key}, IP address: {search_res[i].Value.remoteIp}", nameof(QueryClientCmd));
                }
            return Task.CompletedTask;
        }
    }

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
                Log.Erro($"Please give a correct conv number by \"queryclient\" command!", nameof(ForceInjectPacketCmd));
                return Task.CompletedTask;
            }
            if (!opt.IsClient && !opt.IsServer)
            {
                Log.Erro("Please specify whether to send the packet to client or server!", nameof(ForceInjectPacketCmd));
                return Task.CompletedTask;
            }
            string protoname = opt.Protoname;
            byte[]? head = null;
            byte[]? body = null;
            if (opt.Head != null) head = EasyInput.TryPreProcess(opt.Head).ToByteArray();
            if (opt.Head != null) body = EasyInput.TryPreProcess(opt.Body).ToByteArray();
            if (protoname == null)
            {
                Log.Erro($"Please give at least protoname (--cmd)!", nameof(ForceInjectPacketCmd));

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
            return Task.CompletedTask;
        }
    }

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