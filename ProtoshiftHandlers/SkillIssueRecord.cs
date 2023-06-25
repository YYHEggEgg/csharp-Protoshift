using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.SkillIssue
{
    public struct SkillIssuePacket
    {
        /// <summary>
        /// The cmd_id of the packet. 
        /// </summary>
        public uint CmdId;
        /// <summary>
        /// Whether the packet is New Protos. Packets with this protocol is sent by client.
        /// </summary>
        public bool IsNewCmdid;
        /// <summary>
        /// The size of Unknown fields, calculated from <see cref="UnknownFieldSet"/>.
        /// </summary>
        public int UnknownFieldsSize;
        /// <summary>
        /// The full size of this protobuf. 
        /// </summary>
        public int FullSize;
    }

    public static class RecordSkillIssue
    {
        private static ConcurrentBag<SkillIssuePacket> skillIssue_records = new();

        /// <summary>
        /// Push a packet that was already detected skill issue. 
        /// </summary>
        public static void PushSkillIssuePacket(SkillIssuePacket pkt) 
            => skillIssue_records.Add(pkt);

        /// <summary>
        /// Export the records with .csv format. 
        /// </summary>
        /// <returns>The exported content with .csv format</returns>
        public static string ExportAsCsv()
        {
            StringBuilder sb = new(
                "protoname,isNewCmdid,unknown_fields_size,full_size,lost_content_rate");
            foreach (var pkt in sb)
            {
                string protoname = GetProtonameFromCmdId(pkt.IsNewCmdid, pkt.CmdId); 
                sb.AppendLine($"{protoname},{pkt.IsNewCmdid},{pkt.UnknownFieldsSize},{pkt.FullSize},{(double)pkt.UnknownFieldsSize/pkt.FullSize}");
            }
            return sb.ToString();
        }

        private static string GetProtonameFromCmdId(bool isNewCmdid, uint cmdid)
        {
            string? rtn;
            if (isNewCmdid)
                NewProtos.AskCmdId.TryGetProtonameFromCmdId(cmdid, out rtn);
            else OldProtos.AskCmdId.TryGetProtonameFromCmdId(cmdid, out rtn);
            return rtn ?? "---Unknown---";
        }
    }
}