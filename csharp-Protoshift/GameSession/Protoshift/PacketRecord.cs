#if !PROXY_ONLY_SERVER


using System.Diagnostics;
using YSFreedom.Common.Util;

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
        public int head_offset;
        public int head_length;
        public int body_offset;
        public int body_length;
        /// <summary>
        /// Another version of body bin data (Proto shifted)
        /// </summary>
        public byte[] shiftedData;
        /// <summary>
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime packetTime;

        public PacketRecord(string packetName, int cmdId, bool sentByClient, byte[] data, int head_offset, int head_length, int body_offset, int body_length, byte[] shiftedData, DateTime packetTime)
        {
            PacketName = packetName ?? throw new ArgumentNullException(nameof(packetName));
            CmdId = cmdId;
            this.sentByClient = sentByClient;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.head_offset = head_offset;
            this.head_length = head_length;
            this.body_offset = body_offset;
            this.body_length = body_length;
            this.shiftedData = shiftedData ?? throw new ArgumentNullException(nameof(shiftedData));
            this.packetTime = packetTime;
        }

        public const char separateChar = '|';
        public const int PACKET_OVERHEAD =
            sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(uint);
        public const ushort MagicStart = 0x4567;
        public const ushort MagicEnd = 0x89AB;

        public override string ToString()
        {
            return string.Join(separateChar,
                // packetTime.ToString("yyyy/MM/dd HH:mm:ss.fffffff"),
                PacketName, 
                CmdId,
                sentByClient,
                Convert.ToBase64String(data, head_offset, head_length),
                Convert.ToBase64String(data, body_offset, body_length),
                Convert.ToBase64String(shiftedData));
        }

        // read format:
        // [time]|Info|Packet|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[shiftedData]
        public static PacketRecord Parse(string line)
        {
            var values = line.Split(separateChar);

            // Parse yyyy-MM-dd HH:mm:ss fff ffff
            var specialTime = values[0];
            var minuteTime = specialTime.Substring(0, "yyyy-MM-dd HH:mm:ss".Length);
            DateTime packetTime = DateTime.Parse(minuteTime);
            var millisec = int.Parse(specialTime.Substring(minuteTime.Length + 1, 3));
            var nanosec100 = int.Parse(specialTime.Substring(minuteTime.Length + 5));
            packetTime = packetTime.AddTicks(millisec * 10000 + nanosec100);

            Debug.Assert(values[1] == "Info" && values[2] == "Packet");
            string protoname = values[3];
            int cmdid = int.Parse(values[4]);
            bool sentByClient = bool.Parse(values[5]);
            byte[] head = Convert.FromBase64String(values[6]);
            byte[] body = Convert.FromBase64String(values[7]);
            byte[] shifted_data = Convert.FromBase64String(values[8]);

            int finallen = PACKET_OVERHEAD + head.Length + body.Length + sizeof(ushort);
            byte[] packet = new byte[finallen];
            packet.SetUInt16(0, MagicStart);
            packet.SetUInt16(2, (ushort)cmdid);
            packet.SetUInt16(4, (ushort)head.Length);
            packet.SetUInt32(6, (uint)body.Length);
            var head_offset = 10;
            if (head.Length > 0)
                Buffer.BlockCopy(head, 0, packet, head_offset, head.Length);
            var body_offset = head_offset + head.Length;
            if (body.Length > 0)
                Buffer.BlockCopy(body, 0, packet, body_offset, body.Length);
            packet.SetUInt16(body_offset + body.Length, MagicEnd);

            return new(protoname, cmdid, sentByClient, packet, head_offset, head.Length, 
                body_offset, body.Length, shifted_data, packetTime);
        }
    }
}
#endif