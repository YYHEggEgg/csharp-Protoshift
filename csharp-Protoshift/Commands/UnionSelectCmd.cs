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
    internal class UnionSelectCmd : ICommandHandler
    {
        public string CommandName => "union";

        public string Description => "A command specially used for UnionCmdNotify packets.";

        public string Usage => $"union show <conv_id> <protoname> [number:10]{Environment.NewLine}" +
            $"This can select all packets of a certain proto wrapped in UnionCmdNotify.{Environment.NewLine}" +
            "You may define [number] to limit how many packets to show. Default is 10.";

        public void CleanUp() { }

        public async Task HandleAsync(string[] args)
        {
            #region Parse Input
            if (args[0] != "show") 
            { 
                Log.Info("Invalid usage!", "UnionSelectCmd");
                return;
            }
            string protoname = args[2];
            if (!NewProtos.QueryCmdId.ProtoExists(protoname))
            {
                Log.Info("Protoname not found in NewProtos!", "UnionSelectCmd");
                return;
            }
            uint conv = uint.Parse(args[1]);
            if (args.Length >= 4 && !int.TryParse(args[3], out int limit))
            {
                Log.Info("Invalid showing limit number!", "UnionSelectCmd");
                return;
            }
            else if (args.Length <= 3) limit = 10;
            #endregion
            var unionpackets = GameSessionDispatch.sessions[conv].QueryPacketRecords("UnionCmdNotify");
            List<string> innerpackets = new();
            foreach (var packet in unionpackets)
            {
                var unioncmds = NewProtos.UnionCmdNotify.Parser.ParseFrom(packet.data);
                foreach (var unioncmd in unioncmds.CmdList)
                {
                    ushort cmdid = (ushort)unioncmd.MessageId;
                    if (NewProtos.QueryCmdId.TryGetSerializer(cmdid, out var serializer))
                    {
                        if (serializer.Protoname == protoname)
                            innerpackets.Add(serializer.DeserializeToJson(unioncmd.Body.ToByteArray()));
                    }
                }
            }
            Log.Info($"Packet {protoname}: found {innerpackets.Count} records:", "UnionSelectCmd");
            foreach (var rec in innerpackets)
                Log.Info(rec, "UnionSelectCmd");

            await Task.CompletedTask;
        }
    }
}
#endif