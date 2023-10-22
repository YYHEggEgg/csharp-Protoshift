using csharp_Protoshift.GameSession;
using Newtonsoft.Json;
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
        public static void StartHandlePacket(string protoname,
            byte[] oldbody, int oldbody_offset, int oldbody_length, 
            byte[] newbody, int newbody_offset, int newbody_length,
            LoggerChannel? reportTarget)
        {
            if (!_initialized || reportTarget == null) return;
            reqs.Enqueue(new(protoname, oldbody, oldbody_offset, oldbody_length, newbody, newbody_offset, newbody_length, reportTarget));
        }
        #endregion

        #region Background Handle
        private static ConcurrentQueue<DelayHandleInfo> reqs = new();
        private static bool _initialized = false;

        public static string Initialize()
        {
            _initialized = true;
            reqs = new ConcurrentQueue<DelayHandleInfo>();
            _ = Task.Run(BackgroundHandle);
            return "Skill isuue detector thread started.";
        }

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
                Parallel.ForEach(handles, handle => HandlePacket(handle));
                #endregion

                await Task.Delay(2000);
            }
        }

        #region Inner Handlers
        /// <summary>
        /// Detect if there's skill issue in a packet.
        /// </summary>
        private static void HandlePacket(DelayHandleInfo handle)
        {
#if !PROXY_ONLY_SERVER
            try
            {
                var logger = handle.reportTarget;
                string protoname = handle.protoname;
                if (!NewProtos.QueryJsonSerializer.TryGetJsonSerializer(protoname, out var newserializer)
                    || !OldProtos.QueryJsonSerializer.TryGetJsonSerializer(protoname, out var oldserializer))
                {
                    return;
                }
                string oldjson = oldserializer.DeserializeToJson(handle.oldbody, handle.oldbody_offset, handle.oldbody_length);
                string newjson = newserializer.DeserializeToJson(handle.newbody, handle.newbody_offset, handle.newbody_length);
                var oldlines = ConvertJsonString(oldjson).Split(Environment.NewLine);
                var newlines = ConvertJsonString(newjson).Split(Environment.NewLine);

                if (newlines.Length != oldlines.Length)
                {
                    var output_oldjson = Tools.SortJsonUnindented(oldjson);
                    var output_newjson = Tools.SortJsonUnindented(newjson);
                    logger.LogWarn($"skill_issue_detect(async)|{protoname}|old|{output_oldjson}");
                    logger.LogWarn($"skill_issue_detect(async)|{protoname}|new|{output_newjson}");
                }
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, "SkillIssue-AsyncDetect", 
                    $"<color=Purple>Fatal Error</color> occured in SkillIssueDetect. ");
            }
#else
            throw new NotImplementedException();
#endif
        }
        #endregion
        
        static readonly JsonSerializer serializer = new();

        public static string ConvertJsonString(string str)
        {
            //格式化json字符串
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new(tr);
            object? obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new();
                JsonTextWriter jsonWriter = new(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 0,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }
        }
        #endregion

        private class DelayHandleInfo
        {
            public readonly string protoname;
            public readonly byte[] oldbody;
            public readonly int oldbody_offset;
            public readonly int oldbody_length;
            public readonly byte[] newbody;
            public readonly int newbody_offset;
            public readonly int newbody_length;
            public readonly LoggerChannel reportTarget;

            public DelayHandleInfo(string protoname, byte[] oldbody, int oldbody_offset, int oldbody_length, byte[] newbody, int newbody_offset, int newbody_length, LoggerChannel reportTarget)
            {
                this.protoname = protoname;
                this.oldbody = oldbody;
                this.oldbody_offset = oldbody_offset;
                this.oldbody_length = oldbody_length;
                this.newbody = newbody;
                this.newbody_offset = newbody_offset;
                this.newbody_length = newbody_length;
                this.reportTarget = reportTarget;
            }
        }
    }
}