using System.Collections.ObjectModel;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    internal class CmdIdDataStructure
    {
        /// <summary>
        /// The list of OldProtos cmdids.
        /// </summary>
        public readonly List<(string messageName, int cmdId)> oldcmdids;
        /// <summary>
        /// The list of NewProtos cmdids.
        /// </summary>
        public readonly List<(string messageName, int cmdId)> newcmdids;
        /// <summary>
        /// The list of messages that have cmdid. Include all matching messages from OldProtos and NewProtos. 
        /// </summary>
        public readonly SortedSet<string> messages_havecmdid = new();
        /// <summary>
        /// The list of messages that have cmdid, and supported in both OldProtos and NewProtos. 
        /// </summary>
        public readonly ReadOnlyCollection<string> supportedMessages;
        /// <summary>
        /// The tuple list of messages that have cmdid, and supported in both OldProtos and NewProtos. 
        /// </summary>
        public readonly IEnumerable<(string messageName, int oldcmdid, int newcmdid)> supportedCmdIds;
        /// <summary>
        /// The tuple list of messages that have cmdid, but: <para/>
        /// grouped by their oldcmdid, and ordered by their oldcmdid.
        /// </summary>
        public readonly IOrderedEnumerable<IGrouping<int, (string messageName, int oldcmdid, int newcmdid)>> cmdlist_order_old;
        /// <summary>
        /// The tuple list of messages that have cmdid, but: <para/>
        /// grouped by their newcmdid, and ordered by their newcmdid.
        /// </summary>
        public readonly IOrderedEnumerable<IGrouping<int, (string messageName, int oldcmdid, int newcmdid)>> cmdlist_order_new;

        /// <summary>
        /// The data structure ctor.
        /// </summary>
        /// <param name="oldcmdid_path">The path of oldcmdid.csv.</param>
        /// <param name="newcmdid_path">The path of newcmdid.csv.</param>
        /// <param name="messageResults">The analyzed comparison result of old <see cref="MessageResults"/> and new <see cref="MessageResults"/>.</param>
        public CmdIdDataStructure(string oldcmdid_path, string newcmdid_path,
            CollectionResult<MessageResult> messageResults)
        {
            oldcmdids = ReadCmdIdFromCsv(oldcmdid_path, ref messages_havecmdid);
            newcmdids = ReadCmdIdFromCsv(newcmdid_path, ref messages_havecmdid);
            supportedMessages = new(new List<string>(
                from pair in messageResults.IntersectItems
                select pair.LeftItem.messageName));
            supportedCmdIds = from old in oldcmdids
                              join @new in newcmdids
                              on old.messageName equals @new.messageName
                              select (old.messageName, old.cmdId, @new.cmdId);
            cmdlist_order_new = from tuple in supportedCmdIds
                                group tuple by tuple.newcmdid into gr
                                orderby gr.Key
                                select gr;
            cmdlist_order_old = from tuple in supportedCmdIds
                                group tuple by tuple.oldcmdid into gr
                                orderby gr.Key
                                select gr;
        }

        #region Read Cmdid from .csv file
        private List<(string messageName, int cmdId)> ReadCmdIdFromCsv(string csvPath,
            ref SortedSet<string> message_havecmdid)
        {
            List<(string messageName, int cmdId)> cmdid_list = new();
            try
            {
                using (StreamReader sr = new StreamReader(csvPath))
                {
                    string? line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        if (values.Length == 2 && int.TryParse(values[1], out int cmdId))
                        {
                            cmdid_list.Add((values[0], cmdId));
                            messages_havecmdid.Add(values[0]);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Log.Erro($"The file could not be read: {e}", $"{nameof(CmdIdDataStructure)}_{nameof(ReadCmdIdFromCsv)}");
                Log.Erro("Process will terminate with code 6. Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(6);
            }
            return cmdid_list;
        }
        #endregion
    }
}