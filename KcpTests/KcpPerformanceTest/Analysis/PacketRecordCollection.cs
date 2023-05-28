using csharp_Protoshift.MhyKCP.Test.Protocol;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal class PacketRecordCollection
    {
        // 由 ack 作为索引的数组
        public ReadOnlyDictionary<uint, ReadOnlyBasePacketRecord> records;
        public ReadOnlyCollection<ReadOnlyBasePacketRecord> records_invalid;
        // ack 格式，client 使用奇数 ack，server 使用偶数 ack
        public readonly bool isClientAck;

        public PacketRecordCollection(IEnumerable<ReadOnlyBasePacketRecord> packetRecords)
        {
            Dictionary<uint, ReadOnlyBasePacketRecord> records_clientAck = new();
            Dictionary<uint, ReadOnlyBasePacketRecord> records_serverAck = new();
            List<ReadOnlyBasePacketRecord> _records_invalid = new();
            foreach (var packetRecord in packetRecords)
            {
                if (!packetRecord.isStructureValid)
                {
                    _records_invalid.Add(packetRecord);
                }
                else
                {
                    bool _isClientAck = packetRecord.ack % 2 == 1;
                    var targetDict = _isClientAck ? records_clientAck : records_serverAck;
                    if (targetDict.ContainsKey(packetRecord.ack))
                    {
                        _records_invalid.Add(packetRecord);
                    }
                    else
                    {
                        targetDict.Add(packetRecord.ack, packetRecord);
                    }
                }
            }
            isClientAck = records_clientAck.Count > records_serverAck.Count;
            if (isClientAck)
            {
                records = new(records_clientAck);
                _records_invalid.AddRange(records_serverAck.Values);
                records_invalid = new(_records_invalid);
            }
            else
            {
                records = new(records_serverAck);
                _records_invalid.AddRange(records_clientAck.Values);
                records_invalid = new(_records_invalid);
            }
        }

        public static void PacketLoss(PacketRecordCollection send, PacketRecordCollection recv)
        {

        }

        public static void PacketInterval(PacketRecordCollection send, PacketRecordCollection recv)
        {

        }
    }
}
