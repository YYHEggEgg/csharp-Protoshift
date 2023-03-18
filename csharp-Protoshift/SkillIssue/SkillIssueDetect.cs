using csharp_Protoshift.GameSession;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.SkillIssue
{
    internal static class SkillIssueDetect
    {
        /// <summary>
        /// Detect if there's skill issue in a packet from Client.
        /// </summary>
        /// <param name="packetRecord">The <see cref="PacketRecord"/> object reference, and the method will overwrite its <see cref="PacketRecord.oldjsonContent"/> and <see cref="PacketRecord.dataLostSign"/> field. You may make other fields complete before invoking.</param>
        /// <param name="newbody">The protobuf content with Newer Protocol from Client.</param>
        /// <param name="oldbody">The protobuf content with Older Protocol from Server.</param>
        /// <param name="newjson">The protobuf json content serialized from <paramref name="newbody"/> with <paramref name="newserializer"/>.</param>
        /// <param name="newserializer">The protobuf serializer for Newer Protocol from Client.</param>
        /// <param name="oldserializer">The protobuf serializer for Older Protocol from Server.</param>
        public static async void StartHandleNewPacket(PacketRecord packetRecord,
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer,
            uint? sessionId = null)
        {
            string oldjson;
            string protoname = packetRecord.PacketName;
            oldjson = oldserializer.DeserializeToJson(oldbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", "SkillIssueDetect"
                    + sessionId == null ? "" : $"({sessionId})");
                packetRecord.dataLostSign = true;
            }
            packetRecord.oldjsonContent = oldjson;

            await Task.CompletedTask;
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
        public static async void StartHandleOldPacket(PacketRecord packetRecord,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer, 
            uint? sessionId = null)
        {
            string newjson;
            string protoname = packetRecord.PacketName;
            newjson = newserializer.DeserializeToJson(newbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", "SkillIssueDetect"
                    + sessionId == null ? "" : $"({sessionId})");
                packetRecord.dataLostSign = true;
            }
            packetRecord.newjsonContent = newjson;

            await Task.CompletedTask;
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
        public static async void StartHandleNewPacketWithoutRecord(string protoname, string sender, 
            byte[] newbody, byte[] oldbody, string newjson,
            NewProtos.ProtoSerialize newserializer, OldProtos.ProtoSerialize oldserializer)
        {
            string oldjson = oldserializer.DeserializeToJson(oldbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", $"SkillIssueDetect({sender})");
            }

            await Task.CompletedTask;
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
        public static async void StartHandleOldPacketWithoutRecord(string protoname, string sender,
            byte[] oldbody, byte[] newbody, string oldjson,
            OldProtos.ProtoSerialize oldserializer, NewProtos.ProtoSerialize newserializer,
            uint? sessionId = null)
        {
            string newjson = newserializer.DeserializeToJson(newbody);
            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

            if (newlines.Length != oldlines.Length)
            {
                Log.Warn($"Packet {protoname} has an information lost in Protoshift:\n" +
                    $"new: {newjson}\nold: {oldjson}", $"SkillIssueDetect({sender})");
            }

            await Task.CompletedTask;
        }
    }
}
