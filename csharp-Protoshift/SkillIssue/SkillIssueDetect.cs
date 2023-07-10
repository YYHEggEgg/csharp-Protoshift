using csharp_Protoshift.GameSession;
using System.Collections.Concurrent;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.SkillIssue
{
    internal static class SkillIssueDetect
    {
        #region Outer Receiver
        /// <summary>
        /// Detect if there's skill issue in a packet from Client.
        /// </summary>
        /// <param name="packetRecord">The <see cref="PacketRecord"/> object reference, and the method will overwrite its <see cref="PacketRecord.oldjsonContent"/> and <see cref="PacketRecord.dataLostSign"/> field. You may make other fields complete before invoking.</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="newjson">The protobuf json content serialized from <paramref name="newbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void StartHandleNewPacket(PacketRecord packetRecord,
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer,
            uint? sessionId = null)
        {
            reqs.Enqueue(new(packetRecord, null, null, true, 
                oldbody, newbody, null, newjson, oldserializer, newserializer));
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Server.
        /// </summary>
        /// <param name="packetRecord">The <see cref="PacketRecord"/> object reference, and the method will overwrite its <see cref="PacketRecord.newjsonContent"/> and <see cref="PacketRecord.dataLostSign"/> field. You may make other fields complete before invoking.</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="oldjson">The protobuf json content serialized from <paramref name="oldbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void StartHandleOldPacket(PacketRecord packetRecord,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer,
            uint? sessionId = null)
        {
            reqs.Enqueue(new(packetRecord, null, null, false,
                oldbody, newbody, oldjson, null, oldserializer, newserializer));
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Client. This is a version without writing info into a <see cref="PacketRecord"/>.
        /// </summary>
        /// <param name="protoname">The protocol name. Only used for logging, so it can contain other signs, e.g. "AbilityInvocationsNotify(Unioned)".</param>
        /// <param name="sender">Where the request is from, used for logging, e.g. "UnionCmdHandler".</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="newjson">The protobuf json content serialized from <paramref name="newbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void StartHandleNewPacketWithoutRecord(string protoname, string sender,
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer)
        {
            reqs.Enqueue(new(null, sender, protoname, true, 
                oldbody, newbody, null, newjson, oldserializer, newserializer));
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Server. This is a version without writing info into a <see cref="PacketRecord"/>.
        /// </summary>
        /// <param name="protoname">The protocol name. Only used for logging, so it can contain other signs, e.g. "AbilityInvocationsNotify(Unioned)".</param>
        /// <param name="sender">Where the request is from, used for logging, e.g. "UnionCmdHandler".</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="oldjson">The protobuf json content serialized from <paramref name="oldbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void StartHandleOldPacketWithoutRecord(string protoname, string sender,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer,
            uint? sessionId = null)
        {
            reqs.Enqueue(new(null, sender, protoname, false,
                oldbody, newbody, oldjson, null, oldserializer, newserializer));
        }
        #endregion

        #region Background Handle
        private static ConcurrentQueue<DelayHandleInfo> reqs;

        static SkillIssueDetect()
        {
            reqs = new ConcurrentQueue<DelayHandleInfo>();
            Task.Run(BackgroundHandle);
        }

        public static string Initialize() => "Skill isuue detector thread started.";

        private static async Task BackgroundHandle()
        {
            while (true)
            {
#if DEBUG
                // DEBUG need more stable infos
                List<DelayHandleInfo> handles = new(reqs.Count);
                while (reqs.TryDequeue(out var handle)) handles.Add(handle);
#else
                // RELEASE uses a not safe implement (possibly drop packets)
                // but improves efficiency
                DelayHandleInfo[] handles;
                handles = reqs.ToArray();
                reqs.Clear();
#endif
                #region Handle
                Parallel.ForEach(handles, handle =>
                {
                    #region Packet With Record (from HandlerSession)
                    if (handle.record != null)
                    {
                        if (handle.isNewCmdid)
                        {
                            if (handle.newjson == null)
                            {
                                Log.Erro($"Packet {handle.record.PacketName} not handled properly " +
                                    $"and dropped: {Convert.ToHexString(handle.newbody)}", "SkillIssueDetect-BackgroundWorker");
                                return;
                            }
                            HandleNewPacket(handle.record,
                                handle.newbody, handle.oldbody, handle.newjson,
                                handle.newserializer, handle.oldserializer);
                        }
                        else
                        {
                            if (handle.oldjson == null)
                            {
                                Log.Erro($"Packet {handle.record.PacketName} not handled properly " +
                                    $"and dropped: {Convert.ToHexString(handle.oldbody)}", "SkillIssueDetect-BackgroundWorker");
                                return;
                            }
                            HandleOldPacket(handle.record,
                                handle.oldbody, handle.newbody, handle.oldjson,
                                handle.oldserializer, handle.newserializer);
                        }
                    }
                    #endregion
                    #region Packet Without Record (from SpecialFixs or UnionCmdFix)
                    else if (handle.protoname != null)
                    {
                        if (handle.isNewCmdid)
                        {
                            if (handle.newjson == null)
                            {
                                Log.Erro($"Packet {handle.protoname} from ExtraFix not handled properly " +
                                    $"and dropped: {Convert.ToHexString(handle.newbody)}", "SkillIssueDetect-BackgroundWorker");
                                return;
                            }
                            HandleNewPacketWithoutRecord(handle.protoname, handle.sender,
                                handle.newbody, handle.oldbody, handle.newjson,
                                handle.newserializer, handle.oldserializer);
                        }
                        else
                        {
                            if (handle.oldjson == null)
                            {
                                Log.Erro($"Packet {handle.protoname} from ExtraFix not handled properly " +
                                    $"and dropped: {Convert.ToHexString(handle.oldbody)}", "SkillIssueDetect-BackgroundWorker");
                                return;
                            }
                            HandleOldPacketWithoutRecord(handle.protoname, handle.sender,
                                handle.oldbody, handle.newbody, handle.oldjson,
                                handle.oldserializer, handle.newserializer);
                        }
                    }
                    #endregion
                    else Log.Erro("Unreachable code????", "SkillIssueDetect-BackgroundWorker");
                });
                #endregion

                await Task.Delay(200);
            }
        }

        #region Inner Handlers
        /// <summary>
        /// Detect if there's skill issue in a packet from Client.
        /// </summary>
        /// <param name="packetRecord">The <see cref="PacketRecord"/> object reference, and the method will overwrite its <see cref="PacketRecord.oldjsonContent"/> and <see cref="PacketRecord.dataLostSign"/> field. You may make other fields complete before invoking.</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="newjson">The protobuf json content serialized from <paramref name="newbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        private static void HandleNewPacket(PacketRecord packetRecord,
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer,
            uint? sessionId = null)
        {
#if !PROXY_ONLY_SERVER
            try
            {
                string oldjson;
                string protoname = packetRecord.PacketName;
                oldjson = oldserializer.DeserializeToJson(oldbody);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "SkillIssue-AsyncDetect"
                        + (sessionId == null ? "" : $"({sessionId})"));
                    packetRecord.dataLostSign = true;
                }
                packetRecord.oldjsonContent = oldjson;
            }
            catch (Exception ex)
            {
                Log.Erro($"<color=Purple>Fatal Error</color> occured in SkillIssueDetect: {ex}", "SkillIssue-AsyncDetect");
            }
#else
            throw new NotImplementedException();
#endif
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Server.
        /// </summary>
        /// <param name="packetRecord">The <see cref="PacketRecord"/> object reference, and the method will overwrite its <see cref="PacketRecord.newjsonContent"/> and <see cref="PacketRecord.dataLostSign"/> field. You may make other fields complete before invoking.</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="oldjson">The protobuf json content serialized from <paramref name="oldbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        private static void HandleOldPacket(PacketRecord packetRecord,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer,
            uint? sessionId = null)
        {
#if !PROXY_ONLY_SERVER
            try
            {
                string newjson;
                string protoname = packetRecord.PacketName;
                newjson = newserializer.DeserializeToJson(newbody);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "SkillIssue-AsyncDetect"
                        + (sessionId == null ? "" : $"({sessionId})"));
                    packetRecord.dataLostSign = true;
                }
                packetRecord.newjsonContent = newjson;
            }
            catch (Exception ex)
            {
                Log.Erro($"<color=Purple>Fatal Error</color> occured in SkillIssueDetect: {ex}", "SkillIssue-AsyncDetect");
            }
#else
            throw new NotImplementedException();
#endif
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Client. This is a version without writing info into a <see cref="PacketRecord"/>.
        /// </summary>
        /// <param name="protoname">The protocol name. Only used for logging, so it can contain other signs, e.g. "AbilityInvocationsNotify(Unioned)".</param>
        /// <param name="sender">Where the request is from, used for logging, e.g. "UnionCmdHandler".</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="newjson">The protobuf json content serialized from <paramref name="newbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void HandleNewPacketWithoutRecord(string protoname, string sender,
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer)
        {
            try
            {
                string oldjson = oldserializer.DeserializeToJson(oldbody);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", $"SkillIssue-AsyncDetect({sender})");
                }
            }
            catch (Exception ex)
            {
                Log.Erro($"<color=Purple>Fatal Error</color> occured in SkillIssueDetect: {ex}", "SkillIssue-AsyncDetect");
            }
        }

        /// <summary>
        /// Detect if there's skill issue in a packet from Server. This is a version without writing info into a <see cref="PacketRecord"/>.
        /// </summary>
        /// <param name="protoname">The protocol name. Only used for logging, so it can contain other signs, e.g. "AbilityInvocationsNotify(Unioned)".</param>
        /// <param name="sender">Where the request is from, used for logging, e.g. "UnionCmdHandler".</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="oldjson">The protobuf json content serialized from <paramref name="oldbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static void HandleOldPacketWithoutRecord(string protoname, string sender,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer,
            uint? sessionId = null)
        {
            try
            {
                string newjson = newserializer.DeserializeToJson(newbody);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", $"SkillIssue-AsyncDetect({sender})");
                }
            }
            catch (Exception ex)
            {
                Log.Erro($"<color=Purple>Fatal Error</color> occured in SkillIssueDetect: {ex}", "SkillIssue-AsyncDetect");
            }
        }
        #endregion
        #endregion

        private class DelayHandleInfo
        {
            public PacketRecord? record;
            public string sender;
            public string? protoname;
            public bool isNewCmdid;
            public byte[] oldbody;
            public byte[] newbody;
            public string? oldjson;
            public string? newjson;
            public OldProtos.ProtoSerialize oldserializer;
            public NewProtos.ProtoSerialize newserializer;

            public DelayHandleInfo(PacketRecord? record, string? sender, 
                string? protoname, bool isNewCmdid, 
                byte[] oldbody, byte[] newbody, string? oldjson, string? newjson, 
                OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer)
            {
                this.record = record;
                this.sender = sender ?? "DefaultSender(SkillIssueDetect)";
                this.protoname = protoname;
                this.isNewCmdid = isNewCmdid;
                this.oldbody = oldbody;
                this.newbody = newbody;
                this.oldjson = oldjson;
                this.newjson = newjson;
                this.oldserializer = oldserializer;
                this.newserializer = newserializer;
            }
        }
    }
}
