using System.Diagnostics;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a line of code that shift the Map Field.
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
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool,
            string? baseMessage_friendlyName = null)
        {
            string fieldName = stringPool.GetCompiledName(oneofFieldName) ?? "";
            if (fieldName == baseMessage_friendlyName) fieldName += '_';
            string oldcaller = $"oldprotocol.{fieldName}";
            string newcaller = $"newprotocol.{fieldName}";
            var oneofInnerFieldsCollection = CollectionHelper.GetCompareResult(
                oldoneofField.oneofInnerFields, newoneofField.oneofInnerFields, CommonResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                fi.WriteLine($"switch ({newcaller}Case)");
                fi.EnterCodeRegion();
                var oneofCaseType = $"NewProtos.{belongToMessageCompileName}.{stringPool.GetCompiledName(oneofFieldName)}OneofCase";
                foreach (var oneof_newOnly in oneofInnerFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match oneof case field: [ {oneof_newOnly} ]");
                }
                foreach (var oneof_pair in oneofInnerFieldsCollection.IntersectItems)
                {
                    var commonFieldName = oneof_pair.LeftItem.fieldName;
                    fi.WriteLine($"case {oneofCaseType}.{stringPool.GetCompiledName(commonFieldName)}:");
                    fi.AddIndent();
                    GenerateCommonFieldHandler(ref fi, commonFieldName, oneof_pair.LeftItem, oneof_pair.RightItem,
                        generateForNewShiftToOld, ref importInfo, ref stringPool);
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
                var oneofCaseType = $"OldProtos.{belongToMessageCompileName}.{stringPool.GetCompiledName(oneofFieldName)}OneofCase";
                foreach (var oneof_oldOnly in oneofInnerFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match oneof case field: [ {oneof_oldOnly} ]");
                }
                foreach (var oneof_pair in oneofInnerFieldsCollection.IntersectItems)
                {
                    var commonFieldName = oneof_pair.LeftItem.fieldName;
                    fi.WriteLine($"case {oneofCaseType}.{stringPool.GetCompiledName(commonFieldName)}:");
                    fi.AddIndent();
                    GenerateCommonFieldHandler(ref fi, commonFieldName, oneof_pair.LeftItem, oneof_pair.RightItem,
                        generateForNewShiftToOld, ref importInfo, ref stringPool);
                    fi.WriteLine("break;");
                    fi.RemoveIndent();
                }
                fi.WriteLine("default:", "break;");
                fi.ExitCodeRegion();
            }
        }

        /// <summary>
        /// Generate a line of code that shift the Map Field.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        /// <param name="generateForNewShiftToOld">Whether generate code for NewShiftToOld or OldShiftToNew.</param>
        private static void GenerateOneofFieldsHandler(ref BasicCodeWriter fi,
            MessageResult oldmessage, MessageResult newmessage, bool generateForNewShiftToOld,
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool)
        {
            var oneofFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.oneofFields, newmessage.oneofFields, OneofResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var oneof_newOnly in oneofFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match OneofResult in old: [ {oneof_newOnly.ToString(true)} ]");
                }
            }
            else
            {
                foreach (var oneof_oldOnly in oneofFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match OneofResult in new: [ {oneof_oldOnly.ToString(true)} ]");
                }
            }
            foreach (var oneof_pair in oneofFieldsCollection.IntersectItems)
            {
                GenerateOneofFieldHandler(ref fi, oneof_pair.LeftItem.oneofEntryName, oldmessage.messageName,
                    oneof_pair.LeftItem, oneof_pair.RightItem, generateForNewShiftToOld,
                    ref importInfo, ref stringPool);
            }
        }
    }
}