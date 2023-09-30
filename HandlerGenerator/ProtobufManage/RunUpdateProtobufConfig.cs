using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage
{
    internal class RunUpdateProtobufConfig
    {
        [Option('u', "update", Required = false, Default = false)]
        public bool RequestUpdate { get; set; }
        [Option("branch-oldprotos", Required = false, Default = null)]
        public string? OldProtosBranch { get; set; }
        [Option("branch-newprotos", Required = false, Default = null)]
        public string? NewProtosBranch { get; set; }

        [Usage(ApplicationAlias = "csharp-Protoshift.HandlerGenerator")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example("Update with default/existing protobuf branches.",
                    new RunUpdateProtobufConfig { RequestUpdate = true });
                yield return new Example("Update with given protobuf branches.",
                    new RunUpdateProtobufConfig { RequestUpdate = true, OldProtosBranch = "3.4_gio", NewProtosBranch = "3.4_live" });
                yield break;
            }
        }
    }
}
