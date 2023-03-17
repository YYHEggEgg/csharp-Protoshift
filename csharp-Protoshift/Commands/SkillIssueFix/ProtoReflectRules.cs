using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.SkillIssueFix
{
    internal class ProtoReflectRules
    {
        public bool forServer { get; }
        public string protoName { get; }
        public int cmdid { get; }
        public List<(string, string)> Rules { get; set; }
        public bool enabled { get; set; }

        public ProtoReflectRules(bool forServer, string protoName)
        {
            this.forServer = forServer;
            this.protoName = protoName;
            cmdid = forServer
                ? OldProtos.QueryCmdId.GetCmdIdFromProtoname(protoName)
                : NewProtos.QueryCmdId.GetCmdIdFromProtoname(protoName);
            Rules = new();
        }

        /// <summary>
        /// Only used by serializer
        /// </summary>
        public ProtoReflectRules()
        {
            protoName = "Written By YYH3ggEgg#6167";
            cmdid = -1;
            Rules = new();
            forServer = false;
        }

        /// <summary>
        /// Process json by the given rules.
        /// </summary>
        /// <param name="json">The protobuf json.</param>
        /// <returns>The newly generated protobuf json.</returns>
        public string ProcessFromJson(string json)
        {
            JObject jobj = JObject.Parse(json);
            foreach (var rule in Rules)
            {
                try
                {
                    jobj.Add(new JProperty(rule.Item2, jobj[rule.Item1]?.ToObject<object>()));
                }
                catch (Exception)
                {
#if DEBUG
                    Log.Warn($"\"{rule.Item1}\" was not found in a {protoName} instance.");
#endif
                }
            }
            return jobj.ToString();
        }
    }
}
