#if !PROXY_ONLY_SERVER

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

    internal class SelectRecordCmd : ICommandHandler
    {
        public string CommandName => "select";

        public string Description => "Select specified packet records with a given proto name.";

        public string Usage => "select <conv_id> <protoname>";

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public async Task HandleAsync(string[] args)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            uint conv = uint.Parse(args[0]);
            string protoname = args[1];
            var records = GameSessionDispatch.sessions[conv].QueryPacketRecords(protoname);
            Log.Info($"Found {records.Count} records match. Use 'show <conv> <id>' to show more info of a specified packet.", "SelectRecordCmd");
            Log.Info($"Notice that packets detected skill issue will be added a star(*).");
            string found = "Match Packets: ";
            foreach (var record in records)
            {
                found += $"{record.Id}{(record.dataLostSign ? "*" : "")}; ";
            }
            Log.Info(found, "SelectRecordCmd");
        }
    }

    internal class ShowRecordCmd : ICommandHandler
    {
        public string CommandName => "show";

        public string Description => "Show a specified packet record with it's ID.";

        public string Usage => $"show <conv_id> <packet_id>{Environment.NewLine}" +
            "packet_id can be gained from 'select' command.";

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public async Task HandleAsync(string[] args)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            uint conv = uint.Parse(args[0]);
            int packetId = int.Parse(args[1]);
            var packet = GameSessionDispatch.sessions[conv].QueryPacketRecordById(packetId);
            Log.Info($"Packet {packetId}, {packet.packetTime:yyyy-MM-dd HH:mm:ss}: " +
                $"{packet.PacketName}, CmdId:{packet.CmdId} from " +
                $"{(packet.sentByClient ? "Client" : "Server")}", "ShowRecordCmd");
            Log.Info($"Original body bin data: {Convert.ToHexString(packet.data)}", "ShowRecordCmd");
            Log.Info($"Shifted body bin data: {Convert.ToHexString(packet.shiftedData)}", "ShowRecordCmd");
            Log.Info($"Packet with old protocol: {packet.oldjsonContent}", "ShowRecordCmd");
            Log.Info($"Packet with new protocol: {packet.newjsonContent}", "ShowRecordCmd");
            if (packet.dataLostSign)
            {
                Log.Warn("IMPORTANT: This packet is marked as having data lost and may caused SKILL ISSUEs.", "ShowRecordCmd");
            }
        }
    }
}
#endif