using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a line of code that shift the Oneof Field.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oneofFieldName">The oneof Entry name, the original name from the proto file.</param>
        /// <param name="belongToMessageCompileName">The compiled name of the message whom the oneof field belongs to, which can be identified with the compiler.</param>
        /// <param name="oldoneofField">The analyzed old oneofField.</param>
        /// <param name="newoneofField">The analyzed new oneofField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateOneofFieldHandler(ref BasicCodeWriter fi, string oneofFieldName, string belongToMessageCompileName,
            OneofResult oldoneofField, OneofResult newoneofField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo, 
            string? baseMessage_friendlyName = null)
        {
            string fieldName = Tools.GetProtocCompiledName(oneofFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            var oneofInnerFieldsCollection = CollectionHelper.GetCompareResult(
                oldoneofField.OneofInnerFields, newoneofField.OneofInnerFields, CommonResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                fi.WriteLine($"switch ({newcaller}Case)");
                fi.EnterCodeRegion();
                var oneofCaseType = $"NewProtos.{belongToMessageCompileName}.{Tools.GetProtocCompiledName(oneofFieldName)}OneofCase";
                foreach (var oneof_newOnly in oneofInnerFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match oneof case field: [ {oneof_newOnly} ]");
                }
                foreach (var oneof_pair in oneofInnerFieldsCollection.IntersectItems)
                {
                    var commonFieldName = oneof_pair.LeftItem.FieldName;
                    fi.WriteLine($"case {oneofCaseType}.{Tools.GetProtocCompiledName(commonFieldName)}:");
                    fi.AddIndent();
                    GenerateCommonFieldHandler(ref fi, commonFieldName, oneof_pair.LeftItem, oneof_pair.RightItem,
                        generateForNewShiftToOld, importInfo);
                    fi.WriteLine("break;");
                    fi.RemoveIndent();
                }
                fi.WriteLine("default:", "break;");
                fi.ExitCodeRegion();
            }
            else
            {
                fi.WriteLine($"switch ({oldcaller}Case)");
                fi.EnterCodeRegion();
                var oneofCaseType = $"OldProtos.{belongToMessageCompileName}.{Tools.GetProtocCompiledName(oneofFieldName)}OneofCase";
                foreach (var oneof_oldOnly in oneofInnerFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match oneof case field: [ {oneof_oldOnly} ]");
                }
                foreach (var oneof_pair in oneofInnerFieldsCollection.IntersectItems)
                {
                    var commonFieldName = oneof_pair.LeftItem.FieldName;
                    fi.WriteLine($"case {oneofCaseType}.{Tools.GetProtocCompiledName(commonFieldName)}:");
                    fi.AddIndent();
                    GenerateCommonFieldHandler(ref fi, commonFieldName, oneof_pair.LeftItem, oneof_pair.RightItem,
                        generateForNewShiftToOld, importInfo);
                    fi.WriteLine("break;");
                    fi.RemoveIndent();
                }
                fi.WriteLine("default:", "break;");
                fi.ExitCodeRegion();
            }
        }

        /// <summary>
        /// Generate a series of code that shift the Oneof Fields.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        private static void GenerateOneofFieldsHandler(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo, 
            ref SkillIssueCollection skillIssues)
        {
            var oneofFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.OneofFields, newmessage.OneofFields, OneofResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var oneof_newOnly in oneofFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match OneofResult in old: [ {oneof_newOnly.ToString(true)} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.OneofFields.Add(oneof_newOnly);
                }
            }
            else
            {
                foreach (var oneof_oldOnly in oneofFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match OneofResult in new: [ {oneof_oldOnly.ToString(true)} ]");
                    skillIssues.HasSkillIssue = true;
                    skillIssues.OneofFields.Add(oneof_oldOnly);
                }
            }
            foreach (var oneof_pair in oneofFieldsCollection.IntersectItems)
            {
                GenerateOneofFieldHandler(ref fi, oneof_pair.LeftItem.OneofEntryName, oldmessage.MessageName,
                    oneof_pair.LeftItem, oneof_pair.RightItem, generateForNewShiftToOld,
                    importInfo, oldmessage.MessageName);
            }
        }

        /// <summary>
        /// Generate a line of code that shift the skill issued Oneof Field, but return the object.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oneofFieldName">The oneof Entry name, the original name from the proto file.</param>
        /// <param name="belongToMessageCompileName">The compiled name of the message whom the oneof field belongs to, which can be identified with the compiler.</param>
        /// <param name="oneofField">The analyzed oneofField.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateOneofFieldOnewayAPI(ref BasicCodeWriter fi,
            string belongToMessageCompileName, OneofResult oneofField, bool generateForNewShiftToOld,
            ImportTypesCollection importInfo, 
            string? baseMessage_friendlyName = null)
        {
            foreach (var oneof_single in oneofField.OneofInnerFields)
            {
                var commonFieldName = oneof_single.FieldName;
                GenerateCommonFieldOnewayAPI(ref fi, commonFieldName, oneof_single,
                    generateForNewShiftToOld, importInfo,
                    belongToMessageCompileName, baseMessage_friendlyName);
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
        private static void GenerateOneofFieldsJitAPI(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage)
        {
            var oneofFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.OneofFields, newmessage.OneofFields, OneofResult.NameComparer);
            foreach (var oneof_pair in oneofFieldsCollection.IntersectItems)
            {
                GenerateOneofFieldJitAPI(ref fi, oneof_pair.LeftItem.OneofEntryName, oldmessage.MessageName,
                    oneof_pair.LeftItem, oneof_pair.RightItem,
                    oldmessage.MessageName);
            }
        }

        /// <summary>
        /// Generate a line of code that assign a Oneof Field
        /// for the Protoshift example instance, which is used
        /// to trigger the JIT process.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oneofFieldName">The oneof Entry name, the original name from the proto file.</param>
        /// <param name="belongToMessageCompileName">The compiled name of the message whom the oneof field belongs to, which can be identified with the compiler.</param>
        /// <param name="oldoneofField">The analyzed old oneofField.</param>
        /// <param name="newoneofField">The analyzed new oneofField.</param>
        /// <param name="baseMessage_friendlyName">Give the param can let the code cope with the case that the message name == field name (compiled field name will add _)</param>
        private static void GenerateOneofFieldJitAPI(ref BasicCodeWriter fi, string oneofFieldName, string belongToMessageCompileName,
            OneofResult oldoneofField, OneofResult newoneofField, 
            string? baseMessage_friendlyName = null)
        {
            string fieldName = Tools.GetProtocCompiledName(oneofFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            var oneofInnerFieldsCollection = CollectionHelper.GetCompareResult(
                oldoneofField.OneofInnerFields, newoneofField.OneofInnerFields, CommonResult.NameComparer);
            var oneof_pair = oneofInnerFieldsCollection.IntersectItems.First();
                    var commonFieldName = oneof_pair.LeftItem.FieldName;
            GenerateCommonFieldJitAPI(ref fi, commonFieldName,
                oneof_pair.LeftItem, oneof_pair.RightItem,
                baseMessage_friendlyName);
        }
        #endregion
    }
}