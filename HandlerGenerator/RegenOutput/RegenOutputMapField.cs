namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputMapField
    {
        public static void OutputMapField(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, MapResult mapResult)
        {
            fi.WriteLine($"map<{mapResult.keyType}, {mapResult.valueType}> {mapResult.fieldName} = {mapResult.fieldNumber};");
            if (mapResult.keyIsImportType) imports.Add(mapResult.keyType);
            if (mapResult.valueIsImportType) imports.Add(mapResult.valueType);
        }
    }
}