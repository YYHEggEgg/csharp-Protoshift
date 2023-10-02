namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputOneofField
    {
        public static void OutputOneofField(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, OneofResult oneofResult)
        {
            fi.WriteLine($"oneof {oneofResult.oneofEntryName}");
            fi.EnterCodeRegion();
            var commonFields = from commonField in oneofResult.oneofInnerFields
                               orderby commonField.fieldName
                               select commonField;
            foreach (var commonField in commonFields)
            {
                RegenOutputCommonField.OutputCommonField(ref fi, ref imports, commonField);
            }
            fi.ExitCodeRegion();
        }
    }
}