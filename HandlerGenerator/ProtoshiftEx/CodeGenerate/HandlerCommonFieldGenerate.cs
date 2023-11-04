using System.Diagnostics;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a line of code that shift the Common Field.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="commonFieldName">The commonField name, the original name from the proto file.</param>
        /// <param name="oldcommonField">The analyzed old commonField.</param>
        /// <param name="newcommonField">The analyzed new commonField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateCommonFieldHandler(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult oldcommonField, CommonResult newcommonField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            string? baseMessage_friendlyName = null)
        {
            if (oldcommonField.fieldType != newcommonField.fieldType
                || oldcommonField.IsRepeatedField != newcommonField.IsRepeatedField)
            {
                fi.WriteLine($"// Two field with name equal but don't actual match: old: [ {oldcommonField} ], new: [ {newcommonField} ]");
                return;
            }
            if (oldcommonField.IsRepeatedField)
            {
                GenerateRepeatedCommonFieldHandler(ref fi, commonFieldName,
                    oldcommonField, newcommonField, generateForNewShiftToOld,
                    importInfo, baseMessage_friendlyName);
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            string importPrefix = $"handler_{oldcommonField.fieldType}";
            if (generateForNewShiftToOld)
            {
                fi.WriteLine($"{oldcaller} = {(oldcommonField.isImportType ? $"{importPrefix}.NewShiftToOld({newcaller})" : newcaller)};");
            }
            else
            {
                fi.WriteLine($"{newcaller} = {(oldcommonField.isImportType ? $"{importPrefix}.OldShiftToNew({oldcaller})" : oldcaller)};");
            }
        }

        /// <summary>
        /// Inner method -- should not be invoked out of this code file.
        /// </summary>
        private static void GenerateRepeatedCommonFieldHandler(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult oldcommonField, CommonResult newcommonField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            string? baseMessage_friendlyName = null)
        {
            Debug.Assert(oldcommonField.IsRepeatedField);
            Debug.Assert(newcommonField.IsRepeatedField);
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            if (!oldcommonField.isImportType)
            {
                if (generateForNewShiftToOld) fi.WriteLine($"{oldcaller}.AddRange({newcaller});");
                else fi.WriteLine($"{newcaller}.AddRange({oldcaller});");
            }
            else
            {
                fi.WriteLine($"foreach (var element_{commonFieldName} in {(generateForNewShiftToOld ? newcaller : oldcaller)})");
                fi.EnterCodeRegion();
                string importPrefix = $"handler_{oldcommonField.fieldType}";
                if (generateForNewShiftToOld)
                    fi.WriteLine($"{oldcaller}.Add({importPrefix}.NewShiftToOld(element_{commonFieldName}));");
                else fi.WriteLine($"{newcaller}.Add({importPrefix}.OldShiftToNew(element_{commonFieldName}));");
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
        private static void GenerateCommonFieldsHandler(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            ref SkillIssueCollection skillIssues)
        {
            var commonFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.commonFields, newmessage.commonFields, CommonResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var common_newOnly in commonFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match CommonResult in old: [ {common_newOnly} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.CommonFields.Add(common_newOnly);
                }
            }
            else
            {
                foreach (var common_oldOnly in commonFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match CommonResult in new: [ {common_oldOnly} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.CommonFields.Add(common_oldOnly);
                }
            }
            foreach (var common_pair in commonFieldsCollection.IntersectItems)
            {
                GenerateCommonFieldHandler(ref fi, common_pair.LeftItem.fieldName,
                    common_pair.LeftItem, common_pair.RightItem, generateForNewShiftToOld,
                    importInfo, oldmessage.messageName);
            }
        }

        /// <summary>
        /// Generate a method that shift the skill issued Common Field as <see cref="IEnumerable{T}"/>, but return the object.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="commonFieldName">The commonField name, the original name from the proto file.</param>
        /// <param name="commonField">The analyzed commonField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="messageName">The message compiled name for generating code.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateCommonFieldOnewayAPI(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult commonField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            string messageName, string? baseMessage_friendlyName = null)
        {
            if (commonField.IsRepeatedField)
            {
                GenerateRepeatedCommonFieldOnewayAPI(ref fi, commonFieldName,
                    commonField, generateForNewShiftToOld, importInfo,
                    messageName, baseMessage_friendlyName);
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string caller = $"{(generateForNewShiftToOld ? "new" : "old")}protocol.{fieldName}";
            string importPrefix = $"Handler{commonField.fieldType}.GlobalInstance";
            if (commonField.isImportType && !importInfo.ContainsKey(commonField.fieldType))
            {
                return;
            }
            if (generateForNewShiftToOld)
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetOld{fieldName}(NewProtos.{messageName} newprotocol)",
                    $"=> {(commonField.isImportType ? $"{importPrefix}.NewShiftToOld({caller})" : caller)};");
            }
            else
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object GetNew{fieldName}(OldProtos.{messageName} oldprotocol)",
                    $"=> {(commonField.isImportType ? $"{importPrefix}.OldShiftToNew({caller})" : caller)};");
            }
        }

        /// <summary>
        /// Inner method -- should not be invoked out of this code file.
        /// </summary>
        private static void GenerateRepeatedCommonFieldOnewayAPI(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult commonField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo,
            string messageName, string? baseMessage_friendlyName = null)
        {
            Debug.Assert(commonField.IsRepeatedField);
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string caller = $"{(generateForNewShiftToOld ? "new" : "old")}protocol.{fieldName}";
            if (commonField.isImportType && !importInfo.ContainsKey(commonField.fieldType))
            {
                return;
            }
            if (!commonField.isImportType)
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object Get{(generateForNewShiftToOld ? "Old" : "New")}{fieldName}" +
                    $"({(generateForNewShiftToOld ? "New" : "Old")}Protos.{messageName} " +
                    $"{(generateForNewShiftToOld ? "new" : "old")}protocol)",
                    $"=> {caller};");
            }
            else
            {
                WriteNonUserCodeSign(ref fi);
                fi.WriteLine($"public static object Get{(generateForNewShiftToOld ? "Old" : "New")}{fieldName}" +
                    $"({(generateForNewShiftToOld ? "New" : "Old")}Protos.{messageName} " +
                    $"{(generateForNewShiftToOld ? "new" : "old")}protocol)");
                fi.EnterCodeRegion();
                fi.WriteLine($"List<{(generateForNewShiftToOld ? "Old" : "New")}Protos.{importInfo[commonField.fieldType].compileTypeName}> res = new();");
                fi.WriteLine($"foreach (var element_{commonFieldName} in {caller})");
                fi.EnterCodeRegion();
                string importPrefix = $"Handler{commonField.fieldType}.GlobalInstance";
                fi.WriteLine($"res.Add({importPrefix}." +
                    (generateForNewShiftToOld ? "NewShiftToOld" : "OldShiftToNew") +
                    $"(element_{commonFieldName}));");
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
        private static void GenerateCommonFieldsJitAPI(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage)
        {
            var commonFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.commonFields, newmessage.commonFields, CommonResult.NameComparer);
            foreach (var common_pair in commonFieldsCollection.IntersectItems)
            {
                GenerateCommonFieldJitAPI(ref fi, common_pair.LeftItem.fieldName,
                    common_pair.LeftItem, common_pair.RightItem, 
                    oldmessage.messageName);
            }
        }

        /// <summary>
        /// Generate a line of code that assign a Common Field
        /// for the Protoshift example instance, which is used
        /// to trigger the JIT process.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="commonFieldName">The commonField name, the original name from the proto file.</param>
        /// <param name="oldcommonField">The analyzed old commonField.</param>
        /// <param name="newcommonField">The analyzed new commonField.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateCommonFieldJitAPI(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult oldcommonField, CommonResult newcommonField,
            string? baseMessage_friendlyName = null)
        {
            if (oldcommonField.fieldType != newcommonField.fieldType
                || oldcommonField.IsRepeatedField != newcommonField.IsRepeatedField)
            {
                return;
            }
            if (oldcommonField.IsRepeatedField)
            {
                GenerateRepeatedCommonFieldJitAPI(ref fi, commonFieldName,
                    oldcommonField, newcommonField, 
                    baseMessage_friendlyName);
                return;
            }
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string newcaller = $"newprotocol.{fieldName}";
            fi.WriteLine($"{newcaller} = {GetTypeJitParamter(oldcommonField.fieldType)};");
        }

        /// <summary>
        /// Inner method -- should not be invoked out of this code file.
        /// </summary>
        private static void GenerateRepeatedCommonFieldJitAPI(ref BasicCodeWriter fi, string commonFieldName, 
            CommonResult oldcommonField, CommonResult newcommonField,
            string? baseMessage_friendlyName)
        {
            Debug.Assert(oldcommonField.IsRepeatedField);
            Debug.Assert(newcommonField.IsRepeatedField);
            string fieldName = Tools.GetProtocCompiledName(commonFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string newcaller = $"newprotocol.{fieldName}";
            fi.WriteLine($"{newcaller}.Add({GetTypeJitParamter(oldcommonField.fieldType)});");
        }
        #endregion
    }
}