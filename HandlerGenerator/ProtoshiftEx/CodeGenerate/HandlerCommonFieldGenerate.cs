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
                fi.WriteLine($"{oldcaller} = {(oldcommonField.isImportType ? $"{importPrefix}.NewShiftToOld({newcaller})" : newcaller)}");
            }
            else
            {
                fi.WriteLine($"{newcaller} = {(oldcommonField.isImportType ? $"{importPrefix}.OldShiftToNew({newcaller})" : oldcaller)}");
            }
        }

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
                    fi.WriteLine($"{oldcaller}.Add({importPrefix}.NewShiftToOld({newcaller}));");
                else fi.WriteLine($"{newcaller}.Add({importPrefix}.OldShiftToNew({oldcaller}));");
                fi.ExitCodeRegion();
            }
        }
    }
}