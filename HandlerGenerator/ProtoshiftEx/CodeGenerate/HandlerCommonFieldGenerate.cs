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
        private static void GenerateCommonFieldHandler(ref BasicCodeWriter fi, string commonFieldName,
            CommonResult oldcommonField, CommonResult newcommonField, bool generateForNewShiftToOld,
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool)
        {
            if (oldcommonField.fieldType != newcommonField.fieldType
                || oldcommonField.IsRepeatedField != newcommonField.IsRepeatedField)
            {
                fi.WriteLine($"// Two field with name equal but don't actual match: old: [ {oldcommonField} ], new: [ {newcommonField} ]");
                return;
            }
            if (oldcommonField.IsRepeatedField)
            {
                GenerateRepeatedCommonFieldHandler(ref fi, commonFieldName, oldcommonField, newcommonField, generateForNewShiftToOld, ref importInfo, ref stringPool);
                return;
            }
            string oldcaller = $"oldprotocol.{stringPool.GetCompiledName(commonFieldName)}";
            string newcaller = $"newprotocol.{stringPool.GetCompiledName(commonFieldName)}";
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
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool)
        {
            Debug.Assert(oldcommonField.IsRepeatedField);
            Debug.Assert(newcommonField.IsRepeatedField);
            string oldcaller = $"oldprotocol.{stringPool.GetCompiledName(commonFieldName)}";
            string newcaller = $"newprotocol.{stringPool.GetCompiledName(commonFieldName)}";
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
            ref ImportTypesCollection importInfo, ref ProtocStringPoolManager stringPool)
        {
            var commonFieldsCollection = CollectionHelper.GetCompareResult(
                oldmessage.commonFields, newmessage.commonFields, CommonResult.NameComparer);
            if (generateForNewShiftToOld)
            {
                foreach (var common_newOnly in commonFieldsCollection.RightOnlys)
                {
                    fi.WriteLine($"// Not found match CommonResult in old: [ {common_newOnly} ]");
                }
            }
            else
            {
                foreach (var common_oldOnly in commonFieldsCollection.LeftOnlys)
                {
                    fi.WriteLine($"// Not found match CommonResult in new: [ {common_oldOnly} ]");
                }
            }
            foreach (var common_pair in commonFieldsCollection.IntersectItems)
            {
                GenerateCommonFieldHandler(ref fi, common_pair.LeftItem.fieldName,
                    common_pair.LeftItem, common_pair.RightItem, generateForNewShiftToOld,
                    ref importInfo, ref stringPool);
            }
        }
    }
}