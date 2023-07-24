namespace csharp_Protoshift.MhyKCP.Test.Analysis
{
    internal struct PacketLossResult
    {
        public readonly PacketRecordCollection baseSend, baseRecv;
        public readonly double packetLoss;
        // 丢掉的包、一边没有发另一边却收到了的包（后者不应出现）
        // 前者 ack 以 send 方为准，后者 ack 以 recv 方为准
        public readonly uint[] lost_ack, extra_ack;
        public readonly bool send_isClientAck, recv_isClientAck;

        public PacketLossResult(PacketRecordCollection baseSend, PacketRecordCollection baseRecv, double packetLoss, uint[] lost_ack, uint[] extra_ack, bool send_isClientAck, bool recv_isClientAck)
        {
            this.baseSend = baseSend;
            this.baseRecv = baseRecv;
            this.packetLoss = packetLoss;
            this.lost_ack = lost_ack;
            this.extra_ack = extra_ack;
            this.send_isClientAck = send_isClientAck;
            this.recv_isClientAck = recv_isClientAck;
        }
    }

    internal struct PacketDelayResult
    {
        public readonly PacketRecordCollection baseSend, baseRecv;
        public readonly TimeSpan average_packetDelay;
        public readonly TimeSpan minimum_packetDelay;
        public readonly TimeSpan maximum_packetDelay;
        /// <summary>
        /// 使用的包 ack 列表，为 send 与 recv 的交集，以 send 为标准。<see cref="TimeSpan"/> 为包的处理延迟
        /// </summary>
        public readonly (uint, TimeSpan)[] ack_list;
        /// <summary>
        /// 乱序的包 ack 列表，ack 是奇是偶以 send 为标准。<see cref="TimeSpan"/> 为包的处理延迟
        /// </summary>
        public readonly (uint, DateTime)[] inverted_ack_list;

        public PacketDelayResult(PacketRecordCollection baseSend, PacketRecordCollection baseRecv, TimeSpan average_packetDelay, TimeSpan minimum_packetDelay, TimeSpan maximum_packetDelay, (uint, TimeSpan)[] ack_list, (uint, DateTime)[] inverted_ack_list)
        {
            this.baseSend = baseSend;
            this.baseRecv = baseRecv;
            this.average_packetDelay = average_packetDelay;
            this.minimum_packetDelay = minimum_packetDelay;
            this.maximum_packetDelay = maximum_packetDelay;
            this.ack_list = ack_list;
            this.inverted_ack_list = inverted_ack_list;
        }
    }
}
