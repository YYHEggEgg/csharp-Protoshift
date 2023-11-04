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
            if (oldmapField.keyType != newmapField.keyType 
                || oldmapField.valueType != newmapField.valueType)
            {
                fi.WriteLine($"// Two field with name equal but don't actual match: old: [ {oldmapField} ], new: [ {newmapField} ]");
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(mapFieldName) ?? "";
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
            ImportTypesCollection importInfo, 
            ref SkillIssueCollection skillIssues)
        {
            var mapFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.mapFields, newmessage.mapFields, MapResult.NameComparer);
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
                GenerateMapFieldHandler(ref fi, map_pair.LeftItem.fieldName,
                    map_pair.LeftItem, map_pair.RightItem, generateForNewShiftToOld,
                    importInfo, oldmessage.messageName);
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
            string keyImportPrefix = $"Handler{mapField.keyType}.GlobalInstance";
            string valueImportPrefix = $"Handler{mapField.valueType}.GlobalInstance";
            if ((mapField.keyIsImportType && !importInfo.ContainsKey(mapField.keyType))
                || (mapField.valueIsImportType && !importInfo.ContainsKey(mapField.valueType)))
            {
                return;
            }
            if (generateForNewShiftToOld)
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetOld{fieldName}(NewProtos.{messageName} newprotocol)");
                fi.EnterCodeRegion();
                var keyCompiledType = mapField.keyIsImportType 
                    ? $"OldProtos.{importInfo[mapField.keyType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.keyType];
                var valueCompiledType = mapField.valueIsImportType
                    ? $"OldProtos.{importInfo[mapField.valueType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.valueType];
                fi.WriteLine($"Dictionary<{keyCompiledType}, {valueCompiledType}> res = new();");
                var enumerate_caller = $"eachmap_newprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {caller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"res.Add(" +
                    (mapField.keyIsImportType ? $"{keyImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Key{(mapField.keyIsImportType ? ")" : "")}, " +
                    (mapField.valueIsImportType ? $"{valueImportPrefix}.NewShiftToOld(" : "") +
                    $"{enumerate_caller}.Value{(mapField.valueIsImportType ? ")" : "")});");
                fi.ExitCodeRegion();
                fi.WriteLine("return res;");
                fi.ExitCodeRegion();
            }
            else
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetNew{fieldName}(OldProtos.{messageName} oldprotocol)");
                fi.EnterCodeRegion();
                var keyCompiledType = mapField.keyIsImportType 
                    ? $"NewProtos.{importInfo[mapField.keyType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.keyType];
                var valueCompiledType = mapField.valueIsImportType 
                    ? $"NewProtos.{importInfo[mapField.valueType].compileTypeName}"
                    : ImportTypesCollection.QueryProtobufNativeTypes[mapField.valueType];
                fi.WriteLine($"Dictionary<{keyCompiledType}, {valueCompiledType}> res = new();");
                var enumerate_caller = $"eachmap_oldprotocol_{mapFieldName}";
                fi.WriteLine($"foreach (var {enumerate_caller} in {caller})");
                fi.EnterCodeRegion();
                fi.WriteLine($"res.Add(" +
                    (mapField.keyIsImportType ? $"{keyImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Key{(mapField.keyIsImportType ? ")" : "")}, " +
                    (mapField.valueIsImportType ? $"{valueImportPrefix}.OldShiftToNew(" : "") +
                    $"{enumerate_caller}.Value{(mapField.valueIsImportType ? ")" : "")});");
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
                oldmessage.mapFields, newmessage.mapFields, MapResult.NameComparer);
            foreach (var map_pair in mapFieldsCollection.IntersectItems)
            {
                GenerateMapFieldJitAPI(ref fi, map_pair.LeftItem.fieldName,
                    map_pair.LeftItem, map_pair.RightItem, 
                    oldmessage.messageName);
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
            if (oldmapField.keyType != newmapField.keyType
                || oldmapField.valueType != newmapField.valueType)
            {
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(mapFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string newcaller = $"newprotocol.{fieldName}";
            fi.WriteLine($"{newcaller}.Add(" +
                $"{GetTypeJitParamter(oldmapField.keyType)}, " +
                $"{GetTypeJitParamter(oldmapField.valueType)});");
        }
        #endregion
    }
}