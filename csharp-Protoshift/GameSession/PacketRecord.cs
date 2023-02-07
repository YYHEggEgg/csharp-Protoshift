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
        public int Id;
        public int CmdId;
        public bool sentByClient;
        public byte[] data;
        public bool dataLostSign;
        public string newjsonContent;
        public string oldjsonContent;
    }
}
