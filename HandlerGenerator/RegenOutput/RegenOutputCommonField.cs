namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputCommonField
    {
        public static void OutputCommonField(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, CommonResult commonResult)
        {
            fi.WriteLine($"{(commonResult.IsRepeatedField ? "repeated " : "")}{commonResult.fieldType} {commonResult.fieldName} = {commonResult.fieldNumber};");
            if (commonResult.isImportType) imports.Add(commonResult.fieldType);
        }
    }
}