using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession
{
    internal struct PacketRecord
    {
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
        /// Original protobuf bin data
        /// </summary>
        public byte[] data;
        /// <summary>
        /// Another version of protobuf bin data (Proto shifted)
        /// </summary>
        public byte[] shiftedData;
        /// <summary>
        /// Whether this packet is detected having data lost when Protoshifting (only valid in DEBUG)
        /// </summary>
        public bool dataLostSign;
        /// <summary>
        /// Json format data with new protocol
        /// </summary>
        public string newjsonContent;
        /// <summary>
        /// Json format data with old protocol
        /// </summary>
        public string oldjsonContent;
    }
}
