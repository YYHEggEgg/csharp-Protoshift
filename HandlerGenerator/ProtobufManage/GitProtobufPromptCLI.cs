
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal class GitProtobufPromptCLI
{
    private readonly GitProtosManager _oldprotos = new("./../OldProtoHandlers/Google.Protobuf", "OldProtos");
    private readonly GitProtosManager _newprotos = new("./../NewProtoHandlers/Google.Protobuf", "NewProtos");
    public readonly string DefaultBranchOld;
    public readonly string DefaultBranchNew;
    public readonly string? OverrideSourceRepo;
    private readonly LoggerChannel _logger = Log.GetChannel(nameof(GitProtobufPromptCLI));

    public GitProtobufPromptCLI()
    {
        var branchlist = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/default_protobuf_branches.txt", 2);
        DefaultBranchOld = branchlist[0];
        DefaultBranchNew = branchlist[1];

        OverrideSourceRepo = TxtReader.ReadSpecifiedCount($"./Gencode_Configuration/protobuf_source_git.txt", 0, 1)[0];
    }

    public async Task CheckAndInitAsync()
    {
        await _oldprotos.CheckAndInitAsync(DefaultBranchOld, OverrideSourceRepo);
        await _newprotos.CheckAndInitAsync(DefaultBranchNew, OverrideSourceRepo);
    }


}
