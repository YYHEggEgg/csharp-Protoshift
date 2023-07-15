#if PROXY_ONLY_SERVER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession
{
    public class PacketRecord
    {
        /// <summary>
        /// Packet Name (Proto name)
        /// </summary>
        public string PacketName;
        public int CmdId;
        public bool sentByClient;
        /// <summary>
        /// Original body bin data
        /// </summary>
        public byte[] data;
        public int data_offset;
        public int data_length;
        /// <summary>
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime packetTime;

        public PacketRecord(string? packetName, int cmdId, bool sentByClient, byte[]? data, int data_offset, int data_length)
        {
            PacketName = packetName ?? throw new ArgumentNullException(nameof(packetName));
            CmdId = cmdId;
            this.sentByClient = sentByClient;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.data_offset = data_offset;
            this.data_length = data_length;
            this.packetTime = DateTime.Now;
        }
    }
}
#endif