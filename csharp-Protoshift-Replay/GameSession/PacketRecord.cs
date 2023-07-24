namespace csharp_Protoshift.Debug.Replay
{
    internal class PacketRecord
    {
        /// <summary>
        /// Packet Name (Proto name)
        /// </summary>
        public string PacketName;
        public uint CmdId;
        public bool sentByClient;
        /// <summary>
        /// Original body bin data
        /// </summary>
        public byte[] data;
        /// <summary>
        /// Another version of body bin data (Proto shifted)
        /// </summary>
        public byte[] shiftedData;
        /// <summary>
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime sentTime;

        public PacketRecord(string packetName, uint cmdId, bool sentByClient, byte[] data, byte[] shiftedData, DateTime packetTime)
        {
            PacketName = packetName ?? throw new ArgumentNullException(nameof(packetName));
            CmdId = cmdId;
            this.sentByClient = sentByClient;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.shiftedData = shiftedData ?? throw new ArgumentNullException(nameof(shiftedData));
            this.sentTime = packetTime;
        }
    }
}
