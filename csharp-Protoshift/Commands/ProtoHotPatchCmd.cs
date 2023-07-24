using csharp_Protoshift.ProtoHotPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class ProtoHotPatchCmd : ICommandHandler
    {
        public string CommandName => "kskillissue";

        public string Description => "Skill issue fix HotPatch";

        public string Usage => "kskillissue load/reload - load and compile the config.";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public Task HandleAsync(string[] args)
        {
            if (args.Length == 0)
            {
                Log.Erro(Usage, nameof(ProtoHotPatchCmd));
                return Task.CompletedTask;
            }
            if (args[0] == "load" || args[0] == "reload")
            {
                string content;
                try
                {
                    content = File.ReadAllText("protoshift_hotpatch_config.json");
                }
                catch (Exception ex)
                {
                    Log.Info($"Reading file: {Path.GetFullPath("protoshift_hotpatch_config.json")} meets {ex}", nameof(ProtoHotPatchCmd));
                    Log.Erro(ProtoHotPatchCompiler.PSHP016, nameof(ProtoHotPatchCmd));
                    return Task.CompletedTask;
                }
                ProtoHotPatchCompiler.CompileFromFile(content);
            }
            return Task.CompletedTask;
        }
    }
}
