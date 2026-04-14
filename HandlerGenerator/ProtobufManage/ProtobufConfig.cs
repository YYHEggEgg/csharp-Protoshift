using Tomlyn;
using Tomlyn.Model;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

/// <summary>
/// Parsed contents of Gencode_Configuration/protobuf_config.toml.
/// </summary>
internal class ProtobufConfig
{
    /// <summary>
    /// Git remote URL (must end with ".git").
    /// Falls back to <see cref="GitProtosManager.DefaultSource"/> when not set.
    /// </summary>
    public string GitSource { get; init; } = GitProtosManager.DefaultSource;

    /// <summary>
    /// Default branch for OldProtos when none is specified on the command line.
    /// </summary>
    public string DefaultBranchOldProtos { get; init; } = "";

    /// <summary>
    /// Default branch for NewProtos when none is specified on the command line.
    /// </summary>
    public string DefaultBranchNewProtos { get; init; } = "";

    /// <summary>
    /// When <see langword="true"/>, all git operations are skipped. Proto files
    /// must already be present in the hardcoded build directories.
    /// </summary>
    public bool SkipGitUpdate { get; init; }

    /// <summary>
    /// If your OldProtos files have a different 'package' declaration
    /// (from <c>package miHomo.Protos</c>), you need to set the value
    /// to the PascalCase version of that declaration.
    /// Protos without any 'package' declaration or a shared 'package'
    /// definition are NOT accepted.
    /// </summary>
    public string OldProtosCSharpNamespace { get; init; } = "";
    /// <summary>
    /// If your NewProtos files have a different 'package' declaration
    /// (from <c>package miHomo.Protos</c>), you need to set the value
    /// to the PascalCase version of that declaration.
    /// Protos without any 'package' declaration or a shared 'package'
    /// definition are NOT accepted.
    /// </summary>
    public string NewProtosCSharpNamespace { get; init; } = "";

    private const string ConfigPath = "./Gencode_Configuration/protobuf_config.toml";

    /// <summary>
    /// Load and parse <c>protobuf_config.toml</c>.
    /// </summary>
    public static ProtobufConfig Load()
    {
        var model = Toml.ToModel(File.ReadAllText(ConfigPath));

        // git_source — optional; falls back to built-in default
        model.TryGetValue("git_source", out var gitSourceRaw);
        var gitSource = gitSourceRaw as string;
        if (string.IsNullOrWhiteSpace(gitSource))
            gitSource = GitProtosManager.DefaultSource;

        // default_branch_* — required
        if (!model.TryGetValue("default_branch_oldprotos", out var branchOldRaw)
            || branchOldRaw is not string branchOld
            || string.IsNullOrWhiteSpace(branchOld))
            throw new InvalidOperationException(
                $"{ConfigPath}: 'default_branch_oldprotos' is required but not set.");

        if (!model.TryGetValue("default_branch_newprotos", out var branchNewRaw)
            || branchNewRaw is not string branchNew
            || string.IsNullOrWhiteSpace(branchNew))
            throw new InvalidOperationException(
                $"{ConfigPath}: 'default_branch_newprotos' is required but not set.");

        // skip_git_update — optional boolean, default false
        var skipGit = model.TryGetValue("skip_git_update", out var skipRaw)
                   && skipRaw is bool skipBool && skipBool;

        // *protos_csharp_namespace — optional; falls back to MiHomo.Protos
        model.TryGetValue("oldprotos_csharp_namespace", out var oldNsRaw);
        var oldNs = oldNsRaw as string;
        if (string.IsNullOrWhiteSpace(oldNs))
            oldNs = "MiHomo.Protos";
        model.TryGetValue("newprotos_csharp_namespace", out var newNsRaw);
        var newNs = newNsRaw as string;
        if (string.IsNullOrWhiteSpace(newNs))
            newNs = "MiHomo.Protos";

        return new ProtobufConfig
        {
            GitSource = gitSource,
            DefaultBranchOldProtos = branchOld,
            DefaultBranchNewProtos = branchNew,
            SkipGitUpdate = skipGit,
            OldProtosCSharpNamespace = oldNs,
            NewProtosCSharpNamespace = newNs,
        };
    }
}
