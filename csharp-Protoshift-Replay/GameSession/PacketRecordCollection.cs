using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Debug.Replay
{
    internal class PacketRecordCollection
    {
        private class ReplayAttack
        {
            public PacketRecord record;
            public TimeSpan offset;
        }

        public const ushort MagicStart = 0x4567;
        public const ushort MagicEnd = 0x89AB;
        public const char separateChar = '|';

        private Queue<ReplayAttack> readonly_replays;

        public PacketRecordCollection(string filePath)
        {
            readonly_replays = new();

            var recordList = ReadFromCsv(filePath);
            // 1. Sort by time
            recordList.Sort((l, r) => l.packetTime.CompareTo(r.packetTime));
            // 2. Set comparison standard
            readonly_replays.Enqueue(new ReplayAttack { record = recordList[0], offset = TimeSpan.Zero });
            DateTime lastTime = recordList[0].packetTime;
            // 3. Set send packet offset
            for (int i = 1; i < recordList.Count; i++)
            {
                TimeSpan waitSpan = recordList[i].packetTime - lastTime;
                readonly_replays.Enqueue(new ReplayAttack { record = recordList[i], offset = waitSpan });
                lastTime = recordList[i].packetTime;
            }
        }

        private static List<PacketRecord> ReadFromCsv(string filePath)
        {
            int skip = 0;
            List<PacketRecord> rtn = new();
            foreach (var line in File.ReadLines(filePath))
            {
                try
                {
                    PacketRecord record = PacketRecord.Parse(line);
                    rtn.Add(record);
                }
                catch { skip++; continue; }
            }
            if (skip > 0)
            {
                Log.Warn($"PacketRecordCollection skipped {skip} lines of file: {filePath} for wrong format.", nameof(PacketRecordCollection));
            }
            return rtn;
        }

        public async Task Replay(CancellationToken? cancellationToken = null)
        {
            Queue<ReplayAttack> replays = new(readonly_replays);
            HandlerSession session = new(1000);
            Log.Info($"Started replay, {replays.Count} requests.", nameof(PacketRecordCollection));
            while (replays.TryDequeue(out ReplayAttack? replay))
            {
                if (cancellationToken?.IsCancellationRequested ?? false)
                {
                    Log.Warn("Invoker requested to cancel replay requests.", nameof(PacketRecordCollection));
                }
                // See Remarks of
                // https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay?view=net-7.0#system-threading-tasks-task-delay(system-timespan)
                if (replay.offset > TimeSpan.FromMilliseconds(15))
                    await Task.Delay(replay.offset);
                try
                {
                    var record = replay.record;
                    session.GetPacketResult(record.data, (ushort)record.CmdId, record.sentByClient, 
                        record.head_offset, record.head_length, record.body_offset, (uint)record.body_length);
                    Log.Info($"Successfully output packet CmdId: {replay.record.CmdId} with body: {record.body_length} bytes.", nameof(PacketRecordCollection));
                }
                catch (Exception ex)
                {
                    Log.Erro($"Exception happened so skipped replayable packet: {ex}", nameof(PacketRecordCollection));
                }
            }
            await Task.CompletedTask;
        }
    }
}
