namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputMessage
    {
        public static void OutputMessage(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, MessageResult messageResult)
        {
            fi.WriteLine($"message {messageResult.messageName}");
            fi.EnterCodeRegion();
            bool qiangpozhen_fix_firstline = false;
            var commonFields = from commonField in messageResult.commonFields
                               orderby commonField.fieldName
                               select commonField;
            if (commonFields.Any()) qiangpozhen_fix_firstline = true;
            foreach (var commonField in commonFields)
            {
                RegenOutputCommonField.OutputCommonField(ref fi, ref imports, commonField);
            }
            
            var mapFields = from mapField in messageResult.mapFields
                            orderby mapField.fieldName
                            select mapField;
            if (mapFields.Any()) 
            {
                if (qiangpozhen_fix_firstline) fi.WriteLine();
                else qiangpozhen_fix_firstline = true;
            }
            foreach (var mapField in mapFields)
            {
                RegenOutputMapField.OutputMapField(ref fi, ref imports, mapField);
            }
            
            var oneofFields = from oneofField in messageResult.oneofFields
                              orderby oneofField.oneofEntryName
                              select oneofField;
            if (oneofFields.Any()) 
            {
                if (qiangpozhen_fix_firstline) fi.WriteLine();
                else qiangpozhen_fix_firstline = true;
            }
            foreach (var oneofField in oneofFields)
            {
                RegenOutputOneofField.OutputOneofField(ref fi, ref imports, oneofField);
            }
            
            var enumFields = from enumField in messageResult.enumFields
#if FORBID_ENUM_CMDID
                             where enumField.enumName.ToLower() != "cmdid"
#endif
                             orderby enumField.enumName
                             select enumField;
            if (enumFields.Any())
            {
                if (qiangpozhen_fix_firstline) fi.WriteLine();
                else qiangpozhen_fix_firstline = true;
            }
            foreach (var enumField in enumFields)
            {
                RegenOutputEnum.OutputEnum(ref fi, enumField);
            }
            
            var messageFields = from messageField in messageResult.messageFields
                              orderby messageField.messageName
                              select messageField;
            if (messageFields.Any())
            {
                if (qiangpozhen_fix_firstline) fi.WriteLine();
                else qiangpozhen_fix_firstline = true;
            }
            foreach (var messageField in messageFields)
            {
                OutputMessage(ref fi, ref imports, messageField);
            }

            fi.ExitCodeRegion();
        }
    }
}