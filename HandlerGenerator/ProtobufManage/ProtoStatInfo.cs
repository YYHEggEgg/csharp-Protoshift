namespace csharp_Protoshift.Enhanced.Handlers.Generator.ProtobufManage;

internal enum ProtoStat
{
    Undefined,
    Valid,
    Deprecated,
    DMCATakenDown
}

internal class ProtoStatInfo
{
    /// <summary>
    /// The protobuf version's current accessibility.
    /// </summary>
    public ProtoStat CurrentStat { get; set; }
    /// <summary>
    /// The repository that contains proto2json outputs.
    /// Only valid when 'CurrentStat' = 'DMCATakenDown'.
    /// </summary>
    public string? RedirectToRepo { get; set; }
    /// <summary>
    /// The release/updated UTC time of this branch.
    /// </summary>
    public DateTime ReleaseTime { get; set; }
}
