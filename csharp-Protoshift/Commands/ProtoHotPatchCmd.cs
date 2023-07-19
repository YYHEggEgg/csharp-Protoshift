using csharp_Protoshift.ProtoHotPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Commands
{
    internal class ProtoHotPatchCmd : ICommandHandler
    {
        public string CommandName => "kskillissue";

        public string Description => "Skill issue fix HotPatch";

        public string Usage => "kskillissue reload - reload the config.";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public Task HandleAsync(string[] args)
        {
            ProtoHotPatchCompiler.CompileFromFile(
                File.ReadAllText("protoshift_hotpatch_config.json"));
            return Task.CompletedTask;
        }
    }
}
