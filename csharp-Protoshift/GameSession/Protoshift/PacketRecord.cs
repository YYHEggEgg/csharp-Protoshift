#if !PROXY_ONLY_SERVER

using System.Diagnostics;
using YSFreedom.Common.Util;

namespace csharp_Protoshift.GameSession
{
    public enum PacketSpecialOp
    {
        None,
        /// <summary>
        /// This packet has been fully managed by an external middleware
        /// and the shifting of itself is totally cancelled.
        /// </summary>
        Cancelled,
        /// <summary>
        /// This packet is injected by the proxy instead of being captured
        /// from the network.
        /// </summary>
        Injected,
    }

    public class PacketRecord
    {
        public uint Uid;
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
        public PacketSpecialOp ShiftOp;
        /// <summary>
        /// Another version of body bin data (Proto shifted)
        /// </summary>
        public byte[] shiftedData;
        /// <summary>
        /// The time of packet creation. Uses <c>DateTime.Now</c>.
        /// </summary>
        public DateTime packetTime;
        public long handleIntervalNanoseconds;

        private const string CancellationNotice = "[shifting_cancelled]";
        private const string InjectionNotice = "[injected]";

        public PacketRecord(uint uid, string packetName, int cmdId, bool sentByClient, 
            byte[] data, int head_offset, int head_length, int body_offset, int body_length, 
            long handleIntervalNanoseconds,
            PacketSpecialOp shiftOp, byte[]? shiftedData, DateTime packetTime)
        {
            Uid = uid;
            PacketName = packetName ?? throw new ArgumentNullException(nameof(packetName));
            CmdId = cmdId;
            this.sentByClient = sentByClient;
            this.data = data ?? throw new ArgumentNullException(nameof(data));
            this.head_offset = head_offset;
            this.head_length = head_length;
            this.body_offset = body_offset;
            this.body_length = body_length;
            this.handleIntervalNanoseconds = handleIntervalNanoseconds;
            ShiftOp = shiftOp;
            this.shiftedData = shiftedData ?? Array.Empty<byte>();
            this.packetTime = packetTime;
        }

        public const char separateChar = '|';
        public const int PACKET_OVERHEAD =
            sizeof(ushort) + sizeof(ushort) + sizeof(ushort) + sizeof(uint);
        public const ushort MagicStart = 0x4567;
        public const ushort MagicEnd = 0x89AB;

        public override string ToString()
        {
            string shiftedString = ShiftOp switch
            {
                PacketSpecialOp.Cancelled => CancellationNotice,
                PacketSpecialOp.Injected => InjectionNotice,
                _ => Convert.ToBase64String(shiftedData),
            };
            return string.Join(separateChar,
                // packetTime.ToString("yyyy/MM/dd HH:mm:ss.fffffff"),
                PacketName,
                CmdId,
                sentByClient,
                Convert.ToBase64String(data, head_offset, head_length),
                Convert.ToBase64String(data, body_offset, body_length),
                handleIntervalNanoseconds,
                shiftedString);
        }

        // old read format:
        // [time]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]
        // new read format:
        // [time]|Info|[uid]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[handleNanoseconds]|[shiftedData]
        public static PacketRecord Parse(string line)
        {
            var values = line.Split(separateChar);
            DateTime packetTime;
            UInt32 uid = 0;
            string protoname;
            int cmdid;
            bool sentByClient;
            byte[] head;
            byte[] body;
            Int64 handle_interval_nanoseconds;
            PacketSpecialOp shiftOp = PacketSpecialOp.None;
            byte[] shifted_data = Array.Empty<byte>();

            if (DateTime.TryParse(values[0], out packetTime)) // support old packet.log protocol
            {
                protoname = values[1];
                cmdid = int.Parse(values[2]);
                sentByClient = bool.Parse(values[3]);
                head = Convert.FromBase64String(values[4]);
                body = Convert.FromBase64String(values[5]);
                if (values.Length >= 7)
                {
                    switch (values[6])
                    {
                        case CancellationNotice:
                            shiftOp = PacketSpecialOp.Cancelled;
                            break;
                        case InjectionNotice:
                            shiftOp = PacketSpecialOp.Injected;
                            break;
                        default:
                            shifted_data = Convert.FromBase64String(values[6]);
                            break;
                    }
                }
                handle_interval_nanoseconds = -1;
            }
            else // new protocol with EggEgg.CSharp-Logger v4.0.0
            {
                // Parse yyyy-MM-dd HH:mm:ss fff ffff
                var specialTime = values[0];
                var minuteTime = specialTime.Substring(0, "yyyy-MM-dd HH:mm:ss".Length);
                packetTime = DateTime.Parse(minuteTime);
                var millisec = int.Parse(specialTime.Substring(minuteTime.Length + 1, 3));
                var nanosec100 = int.Parse(specialTime.Substring(minuteTime.Length + 5));
                packetTime = packetTime.AddTicks(millisec * 10000 + nanosec100);

                Debug.Assert(values[1] == "Info");
                if (values[2] != "Packet") uid = UInt32.Parse(values[2]);
                protoname = values[3];
                cmdid = int.Parse(values[4]);
                sentByClient = bool.Parse(values[5]);
                head = Convert.FromBase64String(values[6]);
                body = Convert.FromBase64String(values[7]);
                if (values.Length >= 10) 
                {
                    handle_interval_nanoseconds = int.Parse(values[8]);
                    switch (values[9])
                    {
                        case CancellationNotice:
                            shiftOp = PacketSpecialOp.Cancelled;
                            break;
                        case InjectionNotice:
                            shiftOp = PacketSpecialOp.Injected;
                            break;
                        default:
                            shifted_data = Convert.FromBase64String(values[9]);
                            break;
                    }
                }
                else
                {
                    handle_interval_nanoseconds = -1;
                }
            }

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

            return new(uid, protoname, cmdid, sentByClient, packet, head_offset, head.Length,
                body_offset, body.Length, handle_interval_nanoseconds, shiftOp, shifted_data, packetTime);
        }
    }
}
#endif
