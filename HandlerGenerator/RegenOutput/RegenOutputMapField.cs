using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputMapField
    {
        public static void OutputMapField(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, MapResult mapResult)
        {
            fi.WriteLine($"map<{mapResult.KeyType}, {mapResult.ValueType}> {mapResult.FieldName} = {mapResult.FieldNumber};");
            if (mapResult.KeyIsImportType) imports.Add(mapResult.KeyType);
            if (mapResult.ValueIsImportType) imports.Add(mapResult.ValueType);
        }
    }
}