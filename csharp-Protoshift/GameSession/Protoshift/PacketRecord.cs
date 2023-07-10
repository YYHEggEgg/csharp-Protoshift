#if !PROXY_ONLY_SERVER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession
{
    internal class PacketRecord
    {
        public PacketRecord(string protoname, int packet_id, int cmd_id, bool isNewCmdid, 
            byte[] received_data, byte[] shifted_data)
        {
            PacketName = protoname;
            Id = packet_id;
            CmdId = cmd_id;
            sentByClient = isNewCmdid;
            data = received_data;
            shiftedData = shifted_data;
            packetTime = DateTime.Now;
        }

        /// <summary>
        /// Packet Name (Proto name)
        /// </summary>
        public string PacketName;
        /// <summary>
        /// Packet Id (In HandlerSession)
        /// </summary>
        public int Id;
        public int CmdId;
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
        /// Whether this packet is detected having data lost when Protoshifting (only valid in DEBUG)
        /// </summary>
        public bool dataLostSign;
        /// <summary>
        /// Json format data with new protocol
        /// </summary>
        public string? newjsonContent;
        /// <summary>
        /// Json format data with old protocol
        /// </summary>
        public string? oldjsonContent;
        /// <summary>
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime packetTime;
    }
}
#endif