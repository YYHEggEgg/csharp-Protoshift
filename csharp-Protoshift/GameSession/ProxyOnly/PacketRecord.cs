﻿#if PROXY_ONLY_SERVER

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
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime packetTime;

        public PacketRecord(string packetName, int cmdId, bool sentByClient, byte[] data, int head_offset, int head_length, int body_offset, int body_length, DateTime packetTime)
        {
            PacketName = packetName ?? throw new ArgumentNullException(nameof(packetName));
            CmdId = cmdId;
            this.sentByClient = sentByClient;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.head_offset = head_offset;
            this.head_length = head_length;
            this.body_offset = body_offset;
            this.body_length = body_length;
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
                packetTime.ToString("yyyy/MM/dd HH:mm:ss.fffffff"),
                PacketName,
                CmdId,
                sentByClient,
                Convert.ToBase64String(data, head_offset, head_length),
                Convert.ToBase64String(data, body_offset, body_length));
        }

        public static PacketRecord Parse(string line)
        {
            var values = line.Split(separateChar);
            DateTime packetTime = DateTime.Parse(values[0]);
            string protoname = values[1];
            int cmdid = int.Parse(values[2]);
            bool sentByClient = bool.Parse(values[3]);
            byte[] head = Convert.FromBase64String(values[4]);
            byte[] body = Convert.FromBase64String(values[5]);

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
                body_offset, body.Length, packetTime);
        }
    }
}
#endif