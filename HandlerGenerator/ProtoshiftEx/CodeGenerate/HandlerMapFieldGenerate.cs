using YYHEggEgg.ProtoParser;

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
            ImportTypesCollection importInfo, 
            string? baseMessage_friendlyName = null)
        {
            if (oldmapField.KeyType != newmapField.KeyType 
                || oldmapField.ValueType != newmapField.ValueType)
            {
                fi.WriteLine($"// Two field with name equal but don't actual match: old: [ {oldmapField} ], new: [ {newmapField} ]");
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(mapFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            string keyImportPrefix = $"handler_{oldmapField.KeyType}";
            string valueImportPrefix = $"handler_{oldmapField.ValueType}";
            if (generateForNewShiftToOld)
            {
                var enumerate_caller = $"eachmap_newprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {newcaller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"{oldcaller}.Add(" +
                    (newmapField.KeyIsImportType ? $"{keyImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Key{(newmapField.KeyIsImportType ? ")" : "")}, " +
                    (newmapField.ValueIsImportType ? $"{valueImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Value{(newmapField.ValueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
            }
            else
            {
                var enumerate_caller = $"eachmap_oldprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {oldcaller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"{newcaller}.Add(" +
                    (oldmapField.KeyIsImportType ? $"{keyImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Key{(oldmapField.KeyIsImportType ? ")" : "")}, " +
                    (oldmapField.ValueIsImportType ? $"{valueImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Value{(oldmapField.ValueIsImportType ? ")" : "")});");
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
            ImportTypesCollection importInfo, 
            ref SkillIssueCollection skillIssues)
        {
            var mapFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.MapFields, newmessage.MapFields, MapResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var map_newOnly in mapFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match MapResult in old: [ {map_newOnly} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.MapFields.Add(map_newOnly);
                }
            }
            else
            {
                foreach (var map_oldOnly in mapFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match MapResult in new: [ {map_oldOnly} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.MapFields.Add(map_oldOnly);
                }
            }
            foreach (var map_pair in mapFieldsCollection.IntersectItems)
            {
                GenerateMapFieldHandler(ref fi, map_pair.LeftItem.FieldName,
                    map_pair.LeftItem, map_pair.RightItem, generateForNewShiftToOld,
                    importInfo, oldmessage.MessageName);
            }
        }

        /// <summary>
        /// Generate a line of code that shift the skill issued Map Field, but return the object.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="mapFieldName">The mapField name, the original name from the proto file.</param>
        /// <param name="oldmapField">The analyzed old mapField.</param>
        /// <param name="newmapField">The analyzed new mapField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateMapFieldOnewayAPI(ref BasicCodeWriter fi, string mapFieldName,
            MapResult mapField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            string messageName, string? baseMessage_friendlyName = null)
        {
            string fieldName = Tools.GetProtocCompiledName(mapFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string caller = $"{(generateForNewShiftToOld ? "new" : "old")}protocol.{fieldName}";
            string keyImportPrefix = $"Handler{mapField.KeyType}.GlobalInstance";
            string valueImportPrefix = $"Handler{mapField.ValueType}.GlobalInstance";
            if ((mapField.KeyIsImportType && !importInfo.ContainsKey(mapField.KeyType))
                || (mapField.ValueIsImportType && !importInfo.ContainsKey(mapField.ValueType)))
            {
                return;
            }
            if (generateForNewShiftToOld)
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetOld{fieldName}(NewProtos.{messageName} newprotocol)");
                fi.EnterCodeRegion();
                var keyCompiledType = mapField.KeyIsImportType 
                    ? $"OldProtos.{importInfo[mapField.KeyType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.KeyType];
                var valueCompiledType = mapField.ValueIsImportType
                    ? $"OldProtos.{importInfo[mapField.ValueType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.ValueType];
                fi.WriteLine($"Dictionary<{keyCompiledType}, {valueCompiledType}> res = new();");
                var enumerate_caller = $"eachmap_newprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {caller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"res.Add(" +
                    (mapField.KeyIsImportType ? $"{keyImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Key{(mapField.KeyIsImportType ? ")" : "")}, " +
                    (mapField.ValueIsImportType ? $"{valueImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Value{(mapField.ValueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
                fi.WriteLine("return res;");
                fi.ExitCodeRegion();
            }
            else
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetNew{fieldName}(OldProtos.{messageName} oldprotocol)");
                fi.EnterCodeRegion();
                var keyCompiledType = mapField.KeyIsImportType 
                    ? $"NewProtos.{importInfo[mapField.KeyType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.KeyType];
                var valueCompiledType = mapField.ValueIsImportType 
                    ? $"NewProtos.{importInfo[mapField.ValueType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.ValueType];
                fi.WriteLine($"Dictionary<{keyCompiledType}, {valueCompiledType}> res = new();");
                var enumerate_caller = $"eachmap_oldprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {caller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"res.Add(" +
                    (mapField.KeyIsImportType ? $"{keyImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Key{(mapField.KeyIsImportType ? ")" : "")}, " +
                    (mapField.ValueIsImportType ? $"{valueImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Value{(mapField.ValueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
                fi.WriteLine("return res;");
                fi.ExitCodeRegion();
            }
        }

        #region JIT API
        /// <summary>
        /// Generate a series of code that assign an value for
        /// the Protoshift example instance, which is used to
        /// trigger the JIT process.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        private static void GenerateMapFieldsJitAPI(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage)
        {
            var mapFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.MapFields, newmessage.MapFields, MapResult.NameComparer);
            foreach (var map_pair in mapFieldsCollection.IntersectItems)
            {
                GenerateMapFieldJitAPI(ref fi, map_pair.LeftItem.FieldName,
                    map_pair.LeftItem, map_pair.RightItem, 
                    oldmessage.MessageName);
            }
        }

        /// <summary>
        /// Generate a line of code that assign a Map Field
        /// for the Protoshift example instance, which is used
        /// to trigger the JIT process.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="mapFieldName">The mapField name, the original name from the proto file.</param>
        /// <param name="oldmapField">The analyzed old mapField.</param>
        /// <param name="newmapField">The analyzed new mapField.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateMapFieldJitAPI(ref BasicCodeWriter fi, string mapFieldName,
            MapResult oldmapField, MapResult newmapField,
            string? baseMessage_friendlyName = null)
        {
            if (oldmapField.KeyType != newmapField.KeyType
                || oldmapField.ValueType != newmapField.ValueType)
            {
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(mapFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string newcaller = $"newprotocol.{fieldName}";
            fi.WriteLine($"{newcaller}.Add(" +
                $"{GetTypeJitParamter(oldmapField.KeyType)}, " +
                $"{GetTypeJitParamter(oldmapField.ValueType)});");
        }
        #endregion
    }
}