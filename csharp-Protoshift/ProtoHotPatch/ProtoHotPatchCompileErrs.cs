namespace csharp_Protoshift.ProtoHotPatch
{
    internal static partial class ProtoHotPatchCompiler
    {
        /// <summary>
        /// Error PSHP001: 尝试在 Release 环境下配置 HotPatch。
        /// </summary>
        public const string PSHP001 = "<color=Red>Error</color> PSHP001: Try to configure HotPatch in the Release environment.";
        /// <summary>
        /// Error PSHP002: json 格式解析失败，已卸载当前的 HotPatch 配置。
        /// </summary>
        public const string PSHP002 = "<color=Red>Error</color> PSHP002: json format parsing failed, and the current HotPatch configuration has been unloaded.";
        /// <summary>
        /// Error PSHP003: 未找到对应的 Proto。[弃用，与 PSHP004 合并]
        /// </summary>
        [Obsolete] public const string PSHP003 = "<color=Red>Error</color> PSHP003: The corresponding Proto was not found. [Obsoleted, merged to PSHP004]";
        /// <summary>
        /// Error PSHP004: Proto 未定义，或其不是两套 protocol 共有的。
        /// </summary>
        public const string PSHP004 = "<color=Red>Error</color> PSHP004: Proto is undefined, or not common to the two protocols.";
        /// <summary>
        /// Error PSHP005: ApplyTo 字段不为 "client" 或 "server" 中的任何一个。
        /// </summary>
        public const string PSHP005 = "<color=Red>Error</color> PSHP005: The ApplyTo field is not any of \"client\" or \"server\".";
        /// <summary>
        /// Warning PSHP006: Config 已启用，但是 Rules 为空。
        /// </summary>
        public const string PSHP006 = "<color=Yellow>Warning</color> PSHP006: Config is enabled, but Rules is empty.";
        /// <summary>
        /// Error PSHP007: rule 不包含标识符 `->`。
        /// </summary>
        public const string PSHP007 = "<color=Red>Error</color> PSHP007: rule does not contain the identifier `->`.";
        /// <summary>
        /// Error PSHP008: rule 有一方的字段名为空。
        /// </summary>
        public const string PSHP008 = "<color=Red>Error</color> PSHP008: One side of the rule has an empty field name.";
        /// <summary>
        /// Error PSHP009: rule 至少有一方的字段名未定义，或其为一个可以正常被 Protoshift 的字段。
        /// </summary>
        public const string PSHP009 = "<color=Red>Error</color> PSHP009: At least one side of the rule field name is undefined, or can be already Protoshifted normally.";
        /// <summary>
        /// Error PSHP010: 定义的 Proto 不存在无法正常 Protoshift 的字段。
        /// </summary>
        public const string PSHP010 = "<color=Red>Error</color> PSHP010: The defined Proto does not exist and cannot be Protoshifted correctly.";
        /// <summary>
        /// Warning PSHP011: 可能应翻转 rule 左右字段名。
        /// </summary>
        public const string PSHP011 = "<color=Yellow>Warning</color> PSHP011: The left and right field names of the rule may need to be reversed.";
        /// <summary>
        /// Warning PSHP012: rule 至少有一方可能应改为驼峰式命名。
        /// </summary>
        public const string PSHP012 = "<color=Yellow>Warning</color> PSHP012: At least one side of the rule may need to be changed to camel case.";
        /// <summary>
        /// Error PSHP013: rule 两方类型不匹配。
        /// </summary>
        public const string PSHP013 = "<color=Red>Error</color> PSHP013: The types of the two sides of the rule do not match.";
        /// <summary>
        /// Error PSHP014: rule 中至少有一个字段不可以进行 Protoshift（因为其类型并不在两套 protocol 中共有）。
        /// </summary>
        public const string PSHP014 = "<color=Red>Error</color> PSHP014: At least one field in the rule cannot be Protoshifted (because its type is not common in the two protocols).";
        /// <summary>
        /// Error PSHP015: rule 涉及到暂不支持的消息内定义的类型。[暂时弃用]
        /// </summary>
        [Obsolete] public const string PSHP015 = "<color=Red>Error</color> PSHP015: The rule involves types defined in messages that are not currently supported. [Obsoleted temporarily]";
        /// <summary>
        /// Error PSHP016: 程序无法或无权读取文件，或文件被删除。
        /// </summary>
        public const string PSHP016 = "<color=Red>Error</color> PSHP016: The program cannot or has no right to read the file, or the file has been deleted.";
        /// <summary>
        /// Error PSHP017: 定义的 Proto 是一个枚举类型。
        /// </summary>
        public const string PSHP017 = "<color=Red>Error</color> PSHP017: The defined Proto is an protobuf enum.";
        /// <summary>
        /// Warning PSHP018: 字段名与消息名称相同，因此您可能需要在字段名后尾随下划线。请参考相应 Proto 编译后生成的代码。
        /// </summary>
        public const string PSHP018 = "<color=Yellow>Warning</color> PSHP018: The field name is the same as the message name, so you may need to follow an underscore after the field name. Please refer to the code generated after the corresponding Proto is compiled.";
        /// <summary>
        /// Error PSHP019: 所选的字段为一个 oneof 类型的入口点。应为 oneof 内的每个字段分别创建映射 rule。
        /// </summary>
        public const string PSHP019 = "<color=Red>Error</color> PSHP019: The selected field is an entry point of a oneof field. Mapping rules should be created for each field within oneof.";
        /// <summary>
        /// Error PSHP020: rule 包含多个标识符 `->`。
        /// </summary>
        public const string PSHP020 = "<color=Red>Error</color> PSHP021: rule contains multiple `->` identifiers.";
    }
}
