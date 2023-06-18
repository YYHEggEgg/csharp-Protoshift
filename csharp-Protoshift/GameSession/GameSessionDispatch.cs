using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;
using Force.Crc32;

namespace csharp_Protoshift.GameSession
{
    internal static class GameSessionDispatch
    {
        /// <summary>
        /// Session dictionary. UInt is Conv id.
        /// </summary>
        public static ConcurrentDictionary<uint, HandlerSession> sessions = new();
        public static ConcurrentBag<uint> cancelledSessions = new();
        public static bool Closed { get; private set; }

        #region Packet Handlers
        public static byte[]? HandleServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            try
            {
#if DEBUG
                // uint checksum_before = Crc32Algorithm.Compute(data);
#endif
                var rtn = sessions[conv].HandlePacket(data, false);
#if DEBUG
                // uint checksum_after = Crc32Algorithm.Compute(rtn);
#endif
                return rtn;
            }
#if DEBUG
            catch (Exception ex)
            {
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
                return null;
            }
#else
            catch { return null; }
#endif
        }

        public static byte[]? HandleClientPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            try
            {
#if DEBUG
                // uint checksum_before = Crc32Algorithm.Compute(data);
#endif
                var rtn = sessions[conv].HandlePacket(data, true);
#if DEBUG
                // uint checksum_after = Crc32Algorithm.Compute(rtn);
#endif
                return rtn;
            }
#if DEBUG
            catch (Exception ex)
            {
                Log.Erro($"Exception when handling packets: {ex}; Inner: {ex.InnerException}", "GameSessionDispatch:Server");
                return null;
            }
#else
            catch { return null; }
#endif
        }

        public static bool OrderedServerPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].OrderedPacket(data, true);
        }

        public static bool OrderedClientPacket(byte[] data, uint conv)
        {
            AssertSessionExists(conv);
            return sessions[conv].OrderedPacket(data, false);
        }
        #endregion

        #region Packet Record Saver
        private static StreamWriter packet_logwriter;
        private static object packet_log_lock = "miHomo Save The World";
        static GameSessionDispatch()
        {
            packet_logwriter = new("logs/latest.packet.log", true);
            packet_logwriter.Write(
                "This is a packet log created by csharp-Protoshift.\n" +
                "You're recommended to use Ctrl+F to search for certain key words:\n" +
                "<protoname>, e.g. 'GetPlayerTokenRsp';\n" +
                "'SKILL ISSUE' for packets with skill issue.\n");
        }

        public static async Task DestroySession(uint conv)
        {
            if (!sessions.ContainsKey(conv)) return;
            sessions.TryRemove(conv, out HandlerSession? session);
            cancelledSessions.Add(conv);

            if (session == null)
            {
                Log.Erro($"Session {conv} destroyed but null, probably not recorded!", "GameSessionDispatch");
                return;
            }
            session.ExportXlsxRecord($"logs/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.debug.packetspeed_{conv}.xlsx");

            StringBuilder output = new();

            output.Append($"\n\n\n\n\n----------\n\n\n\n\nRecord of Session ID:{conv}\n");

            #region XorKey
            output.Append("This session was using XOR Key:\n-----BEGIN 4096 HEX Xor key-----\n" +
                $"{Convert.ToHexString(session.XorKey)}\n-----END 4096 HEX Xor key-----\n\n");
            #endregion
            #region Records Analyze
            Dictionary<string, List<PacketRecord>> record_group = new();
            foreach (var record in session.records)
            {
                if (record == null) continue;
                var pktname = record.PacketName;
                if (pktname == null) continue;
                if (!record_group.ContainsKey(pktname))
                    record_group.Add(pktname, new());
                record_group[pktname].Add(record);
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
                    output.Append($"{packet.packetTime:yyyy-MM-dd HH:mm:ss} Packet {packet.Id}{(packet.dataLostSign ? "*" : "")}: " +
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

                ConcurrentDictionary<string, List<string>> innerpackets = new();
                #region Packet Group
                NewProtos.QueryCmdId.TryGetSerializer("UnionCmdNotify", out var unionparser);
                innerpackets.TryAdd("_Unknown", new());
                Parallel.ForEach(unionPackets, packet =>
                {
                    var unioncmds = NewProtos.UnionCmdNotify.Parser.ParseFrom(
                        unionparser.SerializeFromJson(packet.newjsonContent));
                    foreach (var unioncmd in unioncmds.CmdList)
                    {
                        ushort cmdid = (ushort)unioncmd.MessageId;
                        if (NewProtos.QueryCmdId.TryGetSerializer(cmdid, out var serializer))
                        {
                            if (!innerpackets.ContainsKey(serializer.Protoname))
                                innerpackets.TryAdd(serializer.Protoname, new List<string>());
                            innerpackets[serializer.Protoname].Add(
                                serializer.DeserializeToJson(unioncmd.Body.ToByteArray()));
                        }
                        else
                        {
                            innerpackets["_Unknown"].Add($"Unknown packet CmdId:{cmdid}\n{unioncmd.Body.ToByteArray()}");
                        }
                    }
                });
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

            lock (packet_log_lock)
            {
                packet_logwriter.Write(output.ToString());
            }

            await Task.CompletedTask;
        }

        public static void CloseServer()
        {
            Closed = true;
            List<Task> tasks = new();
            foreach (var conv in sessions.Keys)
            {
                tasks.Add(DestroySession(conv));
            }
            Task.WaitAll(tasks.ToArray());
            packet_logwriter.Flush();
            packet_logwriter.Dispose();
        }
        #endregion

        private static void AssertSessionExists(uint conv)
        {
            if (Closed) throw new OperationCanceledException("The server is closing.");
            if (!sessions.ContainsKey(conv))
            {
                if (!cancelledSessions.Contains(conv))
                    sessions.TryAdd(conv, new(conv));
                else throw new OperationCanceledException($"Session {conv} has been destroyed and no longer avaliable.");
            }
        }
    }
}
