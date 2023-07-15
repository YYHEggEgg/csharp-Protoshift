using csharp_Protoshift.GameSession;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class SetVerboseCmd : ICommandHandler
    {
        public string CommandName => "setverbose";

        public string Description => "Set a specified connection verbose mode.";

        public string Usage => $"setverbose <conv_id> <true/false>{Environment.NewLine}" +
            $"If false, then packets working fine will not produce any output in the commandline.{Environment.NewLine}" +
            "You may use this when you have entered the game successfully and want to use some commands.";

        public void CleanUp() { }

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public async Task HandleAsync(string[] args)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            uint conv = uint.Parse(args[0]);
            bool toMode = bool.Parse(args[1]);
            GameSessionDispatch.sessions[conv].Verbose = toMode;
            Log.Info($"Succeed set Conv:{conv} Verbose Mode to {toMode}.", "SetVerboseCmd");
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

    internal class QueryClientCmd : ICommandHandler
    {
        public string CommandName => "queryclient";

        public string Description => "Query the online convs of the instance. ";

        public string Usage => $"queryclient [limit=20] [--range <conv_id_min> <conv_id_max>]{Environment.NewLine}" +
            "  Query the online conv ids. Default output limit is 50, so use --range when query exceeded limit. ";

        public void CleanUp() { }

        public Task HandleAsync(string[] args)
        {
            int limit = 50;
            uint conv_min = uint.MinValue;
            uint conv_max = uint.MaxValue;
            if (args.Length > 0)
            {
                int offset = 0;
                if (int.TryParse(args[offset++], out int _readlimit))
                    limit = _readlimit;
                if (args.Length > offset)
                {
                    if (args[offset++] == "--range")
                    {
                        conv_min = uint.Parse(args[offset++]);
                        conv_max = uint.Parse(args[offset++]);
                    }
                }
            }
            List<KeyValuePair<uint, HandlerSession>> search_res = new(
                from pair in GameSessionDispatch.sessions
                let conv_id = pair.Key
                where conv_id >= conv_min && conv_id <= conv_max
                select pair);
            if (search_res.Count == 0)
            {
                Log.Info($"No match sessions found.", nameof(QueryClientCmd));
            }
            else for (int i = 0; i < search_res.Count; i++)
                {
                    if (i >= limit)
                    {
                        Log.Warn($"Session counts exceeded limit {limit} (total: {search_res.Count}).", nameof(QueryClientCmd));
                        Log.Warn("You may use --range <conv_id_min> <conv_id_max> or change the limit, and run the command again.");
                        break;
                    }
                    Log.Info($"Found conv: {search_res[i].Key}, IP address: {search_res[i].Value.remoteIp}");
                }
            return Task.CompletedTask;
        }
    }

    internal class ForceInjectPacketCmd : ICommandHandler
    {
        public string CommandName => "injectpkt";

        public string Description => "Send a packet to the specified connection's client/server.";

        public string Usage => $"injectpkt <conv> <\"client\"|\"server\"> {Environment.NewLine}" +
            $"   --cmd <protoname> {Environment.NewLine}" +
            $"   [--head <packet_head_hex>] {Environment.NewLine}" +
            $"   [--body <protobuf_body_hex>]";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public Task HandleAsync(string[] args)
        {
            #region REad param
            bool isNewCmdid;
            if (args.Length < 4)
            {
                Log.Erro($"Please give correct params!", nameof(ForceInjectPacketCmd));
                return Task.CompletedTask;
            }
            if (!uint.TryParse(args[0], out uint conv) || !GameSessionDispatch.sessions.ContainsKey(conv))
            {
                Log.Erro($"Please give a correct conv number by \"queryclient\" command!", nameof(ForceInjectPacketCmd));
            }
            if (args[1].Replace("\"", "") == "client") isNewCmdid = true;
            else if (args[1].Replace("\"", "") == "server") isNewCmdid = false;
            else
            {
                Log.Erro($"Please specify send to whether client or server!", nameof(ForceInjectPacketCmd));

                return Task.CompletedTask;
            }
            int offset = 2;
            string? protoname = null;
            byte[]? head = null;
            byte[]? body = null;
            for (; offset < args.Length; offset++)
            {
                if (args[offset] == "--cmd") protoname = args[++offset];
                else if (args[offset] == "--head") head = Convert.FromHexString(args[++offset]);
                else if (args[offset] == "--body") body = Convert.FromHexString(args[++offset]);
                else
                {
                    Log.Erro($"Please give correct params!", nameof(ForceInjectPacketCmd));

                    return Task.CompletedTask;
                }
            }
            if (protoname == null)
            {
                Log.Erro($"Please give at least protoname (--cmd)!", nameof(ForceInjectPacketCmd));

                return Task.CompletedTask;
            }
            body ??= Array.Empty<byte>();
            #endregion
            if (isNewCmdid)
            {
                var content = GameSessionDispatch.ConstructPacketSendToClient(
                    conv, protoname, head, body);
                Program.ProxyServer.SendPacketToClient(conv, content);
            }
            else
            {
                var content = GameSessionDispatch.ConstructPacketSendToServer(
                    conv, protoname, head, body);
                Program.ProxyServer.SendPacketToServer(conv, content);
            }
            return Task.CompletedTask;
        }
    }
}
