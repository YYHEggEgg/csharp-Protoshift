using CommandLine;
using csharp_Protoshift.ProtoHotPatch;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    [Verb("reload", false, new string[] { "load" }, HelpText = "load and compile the config.")]
    internal class ProtoHotPatchLoadConfig
    {
    }

    internal class ProtoHotPatchCmd : CommandHandlerBase
    {
        public override string CommandName => "kskillissue";

        public override string Description => "Skill issue fix HotPatch";

        public override string Usage => "kskillissue load/reload - load and compile the config.";

        public override async Task HandleAsync(string argList)
        {
            var args = ParseAsArgs(argList);
            await Parser.Default.ParseArguments<ProtoHotPatchLoadConfig>(args)
                .MapResult(
                    async (ProtoHotPatchLoadConfig o) => await HandleReloadAsync(o),
                    error =>
                    {
                        Log.Erro("Unrecognized args detected. Please check your input.", nameof(ProtoHotPatchCmd));
                        ShowUsage();
                        return Task.CompletedTask;
                    });
        }

        private Task HandleReloadAsync(ProtoHotPatchLoadConfig _)
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
            return Task.CompletedTask;
        }
    }
}
