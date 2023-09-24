namespace csharp_Protoshift.ProtoHotPatch
{
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    internal class ProtoshiftHotPatchConfig
    {
        public string Proto { get; set; }
        public string ApplyTo { get; set; }
        public bool Enabled { get; set; }
        public string[] Rules { get; set; }
    }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
}
