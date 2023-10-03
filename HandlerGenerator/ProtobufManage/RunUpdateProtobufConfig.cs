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
        [Option('c', "clear", Required = false, Default = false, HelpText = "Clear the smart build record to get rid of related issues.")]
        public bool ClearWorkspace { get; set; }
        [Option('u', "update", Required = false, Default = false, HelpText = "Fetch the newest protobuf.")]
        public bool RequestUpdate { get; set; }
        [Option("branch-oldprotos", Required = false, Default = null, HelpText = "The branch you would like to choose.")]
        public string? OldProtosBranch { get; set; }
        [Option("branch-newprotos", Required = false, Default = null, HelpText = "The branch you would like to choose.")]
        public string? NewProtosBranch { get; set; }
        [Option('y', Required = false, Default = false, HelpText = "Automatically passes every queries in building. Not recommend to enable this because some nasty situations needs human help.")]
        public bool AlwaysPassChoices { get; set; }
        [Option("--fail-on-afterbuild-failure", Required = false, Default = true, HelpText = "Whether the builder should exit with non-zero code when the custom after-build task script failed. Default is Yes.")]
        public bool PublishFailOnAfterBuildTasksFailure { get; set; }

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
