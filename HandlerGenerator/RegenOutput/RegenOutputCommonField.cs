using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputCommonField
    {
        public static void OutputCommonField(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, CommonResult commonResult)
        {
            fi.WriteLine($"{(commonResult.IsRepeatedField ? "repeated " : "")}{commonResult.FieldType} {commonResult.FieldName} = {commonResult.FieldNumber};");
            if (commonResult.IsImportType) imports.Add(commonResult.FieldType);
        }
    }
}