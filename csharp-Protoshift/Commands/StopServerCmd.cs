using csharp_Protoshift.GameSession;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Commands
{
    internal class StopServerCmd : ICommandHandler
    {
        public string CommandName => "stop";

        public string Description => $"Invoke to stop the server and SAVE ENTIRE PACKET RECORDS. {Environment.NewLine}" +
            $"DON'T USE Ctrl+C! Not supported now.";

        public string Usage => "stop";

        public async Task HandleAsync(string[] args)
        {
            ConcurrentDictionary<uint, StringBuilder> logs = new();
            Parallel.ForEach(GameSessionDispatch.sessions, pair =>
            {
                uint conv = pair.Key;
                HandlerSession session = pair.Value;
                StringBuilder output = new($"Record of Session ID:{conv}\n");

                #region XorKey
                output.Append("This session was using XOR Key:\n-----BEGIN 4096 HEX Xor key-----\n" +
                    $"{session.XorKey}\n-----END 4096 HEX Xor key-----\n\n");
                #endregion
                #region Records Analyze
                Dictionary<string, List<PacketRecord>> record_group = new();
                foreach (var record in session.records)
                {
                    if (record_group.ContainsKey(record.PacketName))
                        record_group.Add(record.PacketName, new());
                    record_group[record.PacketName].Add(record);
                }
                #endregion

                #region Output Packet Records
                output.Append($"In all, this session has handled {session.packetCounts} packets.\n" +
                    $"Packet ID:{session.packetCounts - session.PacketRecordLimits + 1} -> " +
                    $"{session.packetCounts} are preseved and shown below.\n\n\n");
                foreach (var group in record_group)
                {
                    output.Append($"Proto:{group.Key} has {group.Value.Count} packet(s) recorded.\n\n");
                    group.Value.Sort((p1, p2) => p1.Id - p2.Id);
                    foreach (var packet in group.Value)
                    {
                        output.Append($"Packet {packet.Id}{(packet.dataLostSign ? "*" : "")}: " +
                            $"{packet.PacketName} from {(packet.sentByClient ? "Client" : "Server")} " +
                            $"with CmdId:{packet.CmdId}\n");
                        if (packet.dataLostSign) 
                            output.Append("!Notice that this packet was marked as SKILL ISSUE DETECTED.");
                        output.Append($"Original body bin data: {Convert.ToHexString(packet.data)}\n");
                        output.Append($"Shifted body bin data: {Convert.ToHexString(packet.shiftedData)}\n");
                        output.Append($"Packet with old protocol: {packet.oldjsonContent}\n");
                        output.Append($"Packet with new protocol: {packet.newjsonContent}\n");
                        output.Append('\n');
                    }
                }
                output.Append("\n\n\n");
                #endregion

                #region UnionCmdNotify
                if (record_group.ContainsKey("UnionCmdNotify"))
                {
                    output.Append("The following lines are record of packets inner UnionCmdNotify.\n" +
                        "UnionCmdNotify is a way that anime game send several packets in a single KCP packet, which should also be Protoshifted.\n\n");
                    var unionPackets = record_group["UnionCmdNotify"];

                    Dictionary<string, List<string>> innerpackets = new();
                    #region Packet Group
                    innerpackets.Add("_Unknown", new());
                    foreach (var packet in unionPackets)
                    {
                        var unioncmds = NewProtos.UnionCmdNotify.Parser.ParseFrom(packet.data);
                        foreach (var unioncmd in unioncmds.CmdList)
                        {
                            ushort cmdid = (ushort)unioncmd.MessageId;
                            if (NewProtos.QueryCmdId.TryGetSerializer(cmdid, out var serializer))
                            {
                                if (!innerpackets.ContainsKey(serializer.Protoname))
                                    innerpackets.Add(serializer.Protoname, new List<string>());
                                innerpackets[serializer.Protoname].Add(
                                    serializer.DeserializeToJson(unioncmd.Body.ToByteArray()));
                            }
                            else
                            {
                                innerpackets["_Unknown"].Add($"Unknown packet CmdId:{cmdid}\n{unioncmd.Body.ToByteArray()}");
                            }
                        }
                    }
                    #endregion

                    foreach (var innerpair in innerpackets)
                    {
                        output.Append($"Packet {innerpair.Key}: {innerpair.Value.Count} records:\n");
                        foreach (var rec in innerpair.Value)
                            output.Append($"{rec}\n");
                        output.Append('\n');
                    }
                }
                #endregion

                logs.TryAdd(conv, output);
            });
            string output = "This is a packet log created by csharp-Protoshift.\n" +
                "You're recommended to use Ctrl+F to search for certain key words:\n" +
                "<protoname>, e.g. 'GetPlayerTokenRsp';\n" +
                "'SKILL ISSUE' for packets with skill issue;\n";
            foreach (var res in logs)
                output += $"\n\n\n\n\n----------\n\n\n\n\n{res.Value}";

            File.WriteAllText($"{Tools.ProgramPath}\\logs\\{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.packet.log", output);

            Environment.Exit(0);
        }
    }
}
