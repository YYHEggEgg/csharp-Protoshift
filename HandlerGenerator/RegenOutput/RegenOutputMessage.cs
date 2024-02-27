using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator.RegenOutput
{
    static class RegenOutputMessage
    {
        public static void OutputMessage(ref BasicCodeWriter fi, 
            ref SortedSet<string> imports, MessageResult messageResult)
        {
            fi.WriteLine($"message {messageResult.MessageName}");
            fi.EnterCodeRegion();
            bool qiangpozhen_fix_firstline = false;
            var commonFields = from commonField in messageResult.CommonFields
                               orderby commonField.FieldName
                               select commonField;
            if (commonFields.Any()) qiangpozhen_fix_firstline = true;
            foreach (var commonField in commonFields)
            {
                RegenOutputCommonField.OutputCommonField(ref fi, ref imports, commonField);
            }
            
            var mapFields = from mapField in messageResult.MapFields
                            orderby mapField.FieldName
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
            
            var oneofFields = from oneofField in messageResult.OneofFields
                              orderby oneofField.OneofEntryName
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
            
            var enumFields = from enumField in messageResult.EnumFields
#if FORBID_ENUM_CMDID
                             where enumField.enumName.ToLower() != "cmdid"
#endif
                             orderby enumField.EnumName
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
            
            var messageFields = from messageField in messageResult.MessageFields
                              orderby messageField.MessageName
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