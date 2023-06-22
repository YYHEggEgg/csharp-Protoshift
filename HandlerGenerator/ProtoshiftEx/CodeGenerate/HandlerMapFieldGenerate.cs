using System.Diagnostics;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a line of code that shift the Map Field.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="mapFieldName">The mapField name, the original name from the proto file.</param>
        /// <param name="oldmapField">The analyzed old mapField.</param>
        /// <param name="newmapField">The analyzed new mapField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateMapFieldHandler(ref BasicCodeWriter fi, string mapFieldName,
            MapResult oldmapField, MapResult newmapField, bool generateForNewShiftToOld,
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool, 
            string? baseMessage_friendlyName = null)
        {
            if (oldmapField.keyType != newmapField.keyType 
                || oldmapField.valueType != newmapField.valueType)
            {
                fi.WriteLine($"// Two field with name equal but don't actual match: old: [ {oldmapField} ], new: [ {newmapField} ]");
                return;
            }
            string fieldName = stringPool.GetCompiledName(mapFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            string keyImportPrefix = $"handler_{oldmapField.keyType}";
            string valueImportPrefix = $"handler_{oldmapField.valueType}";
            if (generateForNewShiftToOld)
            {
                var enumerate_caller = $"eachmap_newprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {newcaller})");
                fi.EnterCodeRegion();
                if (newmapField.keyIsImportType)
                fi.WriteLine($"{oldcaller}.Add(" +
                    (newmapField.keyIsImportType ? $"{keyImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Key{(newmapField.keyIsImportType ? ")" : "")}, " +
                    (newmapField.valueIsImportType ? $"{valueImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Value{(newmapField.valueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
            }
            else
            {
                var enumerate_caller = $"eachmap_oldprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {oldcaller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"{newcaller}.Add(" +
                    (oldmapField.keyIsImportType ? $"{keyImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Key{(oldmapField.keyIsImportType ? ")" : "")}, " +
                    (oldmapField.valueIsImportType ? $"{valueImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Value{(oldmapField.valueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
            }
        }

        /// <summary>
        /// Generate a series of code that shift the Common Fields in the old/new messages.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        private static void GenerateMapFieldsHandler(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage, bool generateForNewShiftToOld,
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool)
        {
            var mapFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.mapFields, newmessage.mapFields, MapResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var map_newOnly in mapFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match MapResult in old: [ {map_newOnly} ]");
                }
            }
            else
            {
                foreach (var map_oldOnly in mapFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match MapResult in new: [ {map_oldOnly} ]");
                }
            }
            foreach (var map_pair in mapFieldsCollection.IntersectItems)
            {
                GenerateMapFieldHandler(ref fi, map_pair.LeftItem.fieldName,
                    map_pair.LeftItem, map_pair.RightItem, generateForNewShiftToOld,
                    ref importInfo, ref stringPool, oldmessage.messageName);
            }
        }
    }
}