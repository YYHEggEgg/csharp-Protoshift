using System.Globalization;

namespace PacketLogInspector.Models;

public enum PacketSpecialOp
{
    None,
    Cancelled,
    Injected,
}

/// <summary>
/// A simplified, self-contained version of PacketRecord from csharp-Protoshift.
/// Stores body and shifted data as raw byte arrays instead of constructing overhead packets.
/// </summary>
public class PacketRecord
{
    public int Id { get; set; }
    public uint Uid { get; set; }
    public string PacketName { get; set; } = "";
    public int CmdId { get; set; }
    public bool SentByClient { get; set; }
    public byte[] HeadBytes { get; set; } = Array.Empty<byte>();
    public byte[] BodyBytes { get; set; } = Array.Empty<byte>();
    public PacketSpecialOp ShiftOp { get; set; } = PacketSpecialOp.None;
    public byte[] ShiftedDataBytes { get; set; } = Array.Empty<byte>();
    public DateTime PacketTime { get; set; }
    public long HandleIntervalNanoseconds { get; set; }

    private const string CancellationNotice = "[shifting_cancelled]";
    private const string InjectionNotice = "[injected]";

    public static PacketRecord? TryParse(string line, int id)
    {
        try { return Parse(line, id); }
        catch { return null; }
    }

    /// <summary>
    /// Parses a line from latest.packet.log.
    /// Supports both old format (no uid) and new format (with EggEgg logger timestamp).
    /// </summary>
    public static PacketRecord Parse(string line, int id)
    {
        var values = line.Split('|');
        DateTime packetTime;
        uint uid = 0;
        string protoname;
        int cmdId;
        bool sentByClient;
        byte[] head;
        byte[] body;
        long handleNanoseconds;
        PacketSpecialOp shiftOp = PacketSpecialOp.None;
        byte[] shiftedData = Array.Empty<byte>();

        // Old format: [time]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]
        // New format: [time]|Info|[uid]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[handleNanoseconds]|[shiftedData]
        // New time format: "yyyy-MM-dd HH:mm:ss fff tttt" (extra parts prevent TryParse success)
        if (DateTime.TryParse(values[0], null, DateTimeStyles.AllowWhiteSpaces, out packetTime))
        {
            // Old format
            protoname = values[1];
            cmdId = int.Parse(values[2]);
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
                        shiftedData = Convert.FromBase64String(values[6]);
                        break;
                }
            }
            handleNanoseconds = -1;
        }
        else
        {
            // New format - parse "yyyy-MM-dd HH:mm:ss fff tttt"
            var specialTime = values[0];
            var minutePart = specialTime[..19]; // "yyyy-MM-dd HH:mm:ss"
            packetTime = DateTime.Parse(minutePart, null, DateTimeStyles.None);
            var millisec = int.Parse(specialTime.Substring(20, 3));
            var nanosec100 = int.Parse(specialTime[24..]);
            packetTime = packetTime.AddTicks(millisec * 10000L + nanosec100);

            // values[1] == "Info"
            uid = values[2] == "Packet" ? 0 : uint.Parse(values[2]);
            protoname = values[3];
            cmdId = int.Parse(values[4]);
            sentByClient = bool.Parse(values[5]);
            head = Convert.FromBase64String(values[6]);
            body = Convert.FromBase64String(values[7]);
            if (values.Length >= 10)
            {
                handleNanoseconds = long.Parse(values[8]);
                switch (values[9])
                {
                    case CancellationNotice:
                        shiftOp = PacketSpecialOp.Cancelled;
                        break;
                    case InjectionNotice:
                        shiftOp = PacketSpecialOp.Injected;
                        break;
                    default:
                        shiftedData = Convert.FromBase64String(values[9]);
                        break;
                }
            }
            else
            {
                handleNanoseconds = -1;
                shiftedData = Array.Empty<byte>();
            }
        }

        return new PacketRecord
        {
            Id = id,
            Uid = uid,
            PacketName = protoname,
            CmdId = cmdId,
            SentByClient = sentByClient,
            HeadBytes = head,
            BodyBytes = body,
            ShiftOp = shiftOp,
            ShiftedDataBytes = shiftedData,
            PacketTime = packetTime,
            HandleIntervalNanoseconds = handleNanoseconds
        };
    }
}
