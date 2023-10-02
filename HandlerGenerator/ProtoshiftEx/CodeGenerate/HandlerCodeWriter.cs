using System.Reflection;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a Message Handler class. Only handle the class body part, starting with <c>public class</c>.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="messageName">The message name, can be identified by the c# compiler but without NewProtos/OldProtos prefix.</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        public static void GenerateMessageHandler(ref BasicCodeWriter fi, string messageName,
            MessageResult oldmessage, MessageResult newmessage, 
            CompiledEnumsStringPoolCollection oldenumPool, CompiledEnumsStringPoolCollection newenumPool)
        {
            string friendly_messageName = messageName.Substring(
                messageName.Contains('.') ? messageName.LastIndexOf('.') + 1 : 0);
            fi.WriteLine($"public class Handler{friendly_messageName} ",
                $": HandlerBase<NewProtos.{messageName}, OldProtos.{messageName}>");
            fi.EnterCodeRegion();

            #region Base Type
            fi.WriteLine("#region Base Type");
            fi.WriteLine($"MessageParser<NewProtos.{messageName}> newproto_parser_base = NewProtos.{messageName}.Parser;");
            fi.WriteLine($"MessageParser<OldProtos.{messageName}> oldproto_parser_base = OldProtos.{messageName}.Parser;");
            fi.WriteLine("#endregion");
            #endregion
            #region Import Types
            var allimports = new ImportTypesCollection(oldmessage, newmessage);
            fi.WriteLine("#region Import Types");
            foreach (var importLine in allimports.searchByFriendlyName.Keys)
            {
                fi.WriteLine($"Handler{importLine} handler_{importLine} = Handler{importLine}.GlobalInstance;");
            }
            WriteGeneratedCodeAttribute(ref fi);
            fi.WriteLine($"public static string[] ImportedHandlers = new string[] {{");
            fi.AddIndent();
            foreach (var importLine in allimports.searchByFriendlyName.Keys)
            {
                fi.WriteLine($"\"{importLine}\",");
            }
            fi.RemoveIndent();
            fi.WriteLine($"}};");
            fi.WriteLine("#endregion");
            #endregion
            fi.WriteLine();
            #region Protocol Shift
            fi.WriteLine("#region Protocol Shift");
            #region NewShiftToOld
            SkillIssueCollection newskillIssues = new();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override OldProtos.{messageName}? NewShiftToOld(NewProtos.{messageName}? newprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine($"if (newprotocol == null) return null;");
            fi.WriteLine($"OldProtos.{messageName} oldprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            if (newskillIssues.HasSkillIssue)
            {
                #region Skill issue Middleware
                fi.WriteLine("#if DEBUG");
                fi.WriteLine("var __worker = HotPatchMiddleware.Worker;");
                fi.WriteLine($"if (__worker.HasNewShiftToOldMiddleare(typeof(NewProtos.{messageName}).Name))");
                fi.EnterCodeRegion();
                fi.WriteLine($"oldprotocol = (OldProtos.{messageName})__worker.ExecuteNewShiftToOldMiddleware(",
                    $"typeof(NewProtos.{messageName}).Name, newprotocol, oldprotocol);");
                fi.ExitCodeRegion();
                fi.WriteLine("#endif");
                #endregion
            }
            fi.WriteLine($"return oldprotocol;");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region OldShiftToNew
            SkillIssueCollection oldskillIssues = new();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override NewProtos.{messageName}? OldShiftToNew(OldProtos.{messageName}? oldprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("if (oldprotocol == null) return null;");
            fi.WriteLine($"NewProtos.{messageName} newprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            if (oldskillIssues.HasSkillIssue)
            {
                #region Skill issue Middleware
                fi.WriteLine("#if DEBUG");
                fi.WriteLine("var __worker = HotPatchMiddleware.Worker;");
                fi.WriteLine($"if (__worker.HasOldShiftToNewMiddleare(typeof(OldProtos.{messageName}).Name))");
                fi.EnterCodeRegion();
                fi.WriteLine($"newprotocol = (NewProtos.{messageName})__worker.ExecuteOldShiftToNewMiddleware(",
                    $"typeof(OldProtos.{messageName}).Name, oldprotocol, newprotocol);");
                fi.ExitCodeRegion();
                fi.WriteLine("#endif");
                #endregion
            }
            fi.WriteLine($"return newprotocol;");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine("#endregion");
            #endregion
            fi.WriteLine();
            #region Skill issue APIs
            if (oldskillIssues.HasSkillIssue || newskillIssues.HasSkillIssue)
            {
                fi.WriteLine("#pragma warning disable CS8603");
                fi.WriteLine("#pragma warning disable CS8604");
                fi.WriteLine("#region Skill issue APIs");
                if (oldskillIssues.HasSkillIssue)
                {
                    GenerateSkillIssueList(ref fi, false, oldskillIssues, allimports,
                        messageName, friendly_messageName);
                }
                if (newskillIssues.HasSkillIssue)
                {
                    GenerateSkillIssueList(ref fi, true, newskillIssues, allimports,
                        messageName, friendly_messageName);
                }
                fi.WriteLine("#endregion");
                fi.WriteLine("#pragma warning restore CS8603");
                fi.WriteLine("#pragma warning restore CS8604");
                fi.WriteLine();
            }
            #endregion
            #region Outer bytes invoke
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override byte[] NewShiftToOld(byte[] arr, int offset, int length)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length));");
            fi.WriteLine("return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));");
            fi.WriteLine("return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override ByteString NewShiftToOld(ByteString bytes)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(bytes));");
            fi.WriteLine("return rtn == null ? ByteString.Empty : rtn.ToByteString();");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override byte[] OldShiftToNew(byte[] arr, int offset, int length)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length));");
            fi.WriteLine("return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));");
            fi.WriteLine("return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override ByteString OldShiftToNew(ByteString bytes)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));");
            fi.WriteLine("return rtn == null ? ByteString.Empty : rtn.ToByteString();");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            fi.WriteLine($"private static Handler{friendly_messageName} _globalOnlyInstance = new Handler{friendly_messageName}();");
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public static Handler{friendly_messageName} GlobalInstance => _globalOnlyInstance;");
            #region Inner Messages
            fi.WriteLine();
            fi.WriteLine("#region Inner Messages");
            var innermessage_collection = CollectionHelper.GetCompareResult(
                oldmessage.messageFields, newmessage.messageFields, MessageResult.NameComparer);
            foreach (var inner_message in innermessage_collection.IntersectItems)
            {
                string inner_message_name = inner_message.LeftItem.messageName;
                GenerateMessageHandler(ref fi, $"{messageName}.Types.{inner_message_name}",
                    inner_message.LeftItem, inner_message.RightItem, oldenumPool, newenumPool);
            }
            fi.WriteLine("#endregion");
            #endregion
            #region Inner Enums
            fi.WriteLine();
            fi.WriteLine("#region Inner Enums");
            var innerenum_collection = CollectionHelper.GetCompareResult(
                oldmessage.enumFields, newmessage.enumFields, EnumResult.NameComparer);
            foreach (var inner_enum in innerenum_collection.IntersectItems)
            {
                string inner_enum_name = inner_enum.LeftItem.enumName;
                string inner_enum_compiled_name = $"{messageName}.Types.{inner_enum_name}";
                GenerateEnumHandler(ref fi, inner_enum_compiled_name, 
                    inner_enum.LeftItem, inner_enum.RightItem, 
                    oldenumPool.Query(inner_enum_compiled_name), newenumPool.Query(inner_enum_compiled_name));
            }
            fi.WriteLine("#endregion");
            #endregion
            fi.ExitCodeRegion();
        }

        /// <summary>
        /// Generate a Enum Handler class. Only handle the class body part, starting with <c>public class</c>.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="enumName">The enum name, can be identified by the c# compiler but without NewProtos/OldProtos prefix.</param>
        /// <param name="oldenum">The analyzed old enum.</param>
        /// <param name="newenum">The analyzed new enum.</param>
        public static void GenerateEnumHandler(ref BasicCodeWriter fi, string enumName,
            EnumResult oldenum, EnumResult newenum, 
            CompiledEnumStringPoolManager oldstringPool, CompiledEnumStringPoolManager newstringPool)
        {
            string friendly_enumName = enumName.Substring(
                enumName.Contains('.') ? enumName.LastIndexOf('.') + 1 : 0);
            fi.WriteLine($"public class Handler{friendly_enumName} ",
                $": HandlerEnumBase<NewProtos.{enumName}, OldProtos.{enumName}>");
            fi.EnterCodeRegion();
            #region Prepare 
            var enumNodes_both = oldenum.enumNodes.Intersect(newenum.enumNodes);
            var enumNodes_oldOnly = oldenum.enumNodes.Except(newenum.enumNodes);
            var enumNodes_newOnly = newenum.enumNodes.Except(oldenum.enumNodes);
            #endregion
            #region NewShiftToOld
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override OldProtos.{enumName} NewShiftToOld(NewProtos.{enumName} newprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("switch (newprotocol)");
            fi.EnterCodeRegion();
            foreach (var newOnly in enumNodes_newOnly)
            {
                fi.WriteLine($"// Not found match enum node in old (only in new): [ {newOnly} ]");
            }
            foreach (var tuple in enumNodes_both)
            {
                var name = tuple.name;
                fi.WriteLine($"case NewProtos.{enumName}.{newstringPool.GetCompiledName(name)}:",
                    $"return OldProtos.{enumName}.{oldstringPool.GetCompiledName(name)};");
            }
            var name_first = oldenum.enumNodes.First().name;
            fi.WriteLine("default:",
                $"return OldProtos.{enumName}.{oldstringPool.GetCompiledName(name_first)};");
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region OldShiftToNew
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override NewProtos.{enumName} OldShiftToNew(OldProtos.{enumName} oldprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("switch (oldprotocol)");
            fi.EnterCodeRegion();
            foreach (var oldOnly in enumNodes_oldOnly)
            {
                fi.WriteLine($"// Not found match enum node in new (only in old): [ {oldOnly} ]");
            }
            foreach (var tuple in enumNodes_both)
            {
                var name = tuple.name;
                fi.WriteLine($"case OldProtos.{enumName}.{oldstringPool.GetCompiledName(name)}:",
                    $"return NewProtos.{enumName}.{newstringPool.GetCompiledName(name)};");
            }
            name_first = newenum.enumNodes.First().name;
            fi.WriteLine("default:",
                $"return NewProtos.{enumName}.{newstringPool.GetCompiledName(name_first)};");
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            fi.WriteLine($"private static Handler{friendly_enumName} _globalOnlyInstance = new Handler{friendly_enumName}();");
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public static Handler{friendly_enumName} GlobalInstance => _globalOnlyInstance;");
            fi.ExitCodeRegion();
        }

        private static void GenerateSkillIssueList(ref BasicCodeWriter fi, bool generateForNew, 
            SkillIssueCollection skillIssues, ImportTypesCollection importInfo, 
            string messageName,
            string? baseMessage_friendlyName = null)
        {
            WriteGeneratedCodeAttribute(ref fi);
            fi.WriteLine("public static List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)>");
            fi.AddIndent();
            fi.WriteLine($"{(generateForNew ? "new" : "old")}SkillIssueList = new List<(string, string, string, bool)>");
            fi.WriteLine("{");
            fi.AddIndent();
            foreach (var commonField in skillIssues.CommonFields)
            {
                bool isSupportedType = !commonField.isImportType ? true
                    : importInfo.ContainsKey(commonField.fieldType);
                fi.WriteLine($"(\"{commonField.fieldType}\", \"{commonField.fieldName}\", " +
                    $"\"{Tools.GetProtocCompiledName(commonField.fieldName)}\", {isSupportedType.ToString().ToLower()}),");
            }
            foreach (var mapField in skillIssues.MapFields)
            {
                bool isSupportedType =
                    (mapField.keyIsImportType ? importInfo.ContainsKey(mapField.keyType) : true) && 
                    (mapField.valueIsImportType ? importInfo.ContainsKey(mapField.valueType) : true);
                fi.WriteLine($"(\"map<{mapField.keyType}, {mapField.valueType}>\", " +
                    $"\"{mapField.fieldName}\", \"{Tools.GetProtocCompiledName(mapField.fieldName)}\", " +
                    $"{isSupportedType.ToString().ToLower()}),");
            }
            foreach (var oneofField in skillIssues.OneofFields)
            {
                foreach (var oneofInnerField in oneofField.oneofInnerFields)
                {
                    bool isSupportedType = !oneofInnerField.isImportType ? true
                        : importInfo.ContainsKey(oneofInnerField.fieldType);
                    fi.WriteLine($"(\"{oneofInnerField.fieldType}\", \"{oneofInnerField.fieldName}\", " +
                        $"\"{Tools.GetProtocCompiledName(oneofInnerField.fieldName)}\", {isSupportedType.ToString().ToLower()}),");
                }
            }
            fi.RemoveIndent();
            fi.WriteLine("};");
            fi.RemoveIndent();
            foreach (var commonField in skillIssues.CommonFields)
            {
                GenerateCommonFieldOnewayAPI(ref fi, commonField.fieldName, commonField,
                    generateForNew, importInfo, messageName, baseMessage_friendlyName);
            }
            foreach (var mapField in skillIssues.MapFields)
            {
                GenerateMapFieldOnewayAPI(ref fi, mapField.fieldName, mapField,
                    generateForNew, importInfo, messageName, baseMessage_friendlyName);
            }
            foreach (var oneofField in skillIssues.OneofFields)
            {
                GenerateOneofFieldOnewayAPI(ref fi, messageName, oneofField,
                    generateForNew, importInfo, baseMessage_friendlyName);
            }
        }

        private static void WriteGeneratedCodeAttribute(ref BasicCodeWriter fi)
            => fi.WriteLine($"[System.CodeDom.Compiler.GeneratedCode(" +
                $"\"YYHEggEgg/csharp_Protoshift.HandlerGenerator\", \"{Tools.ProgramVersion}\")]");

        private static void WriteNonUserCodeSign(ref BasicCodeWriter fi)
        {
            fi.WriteLine("[System.Diagnostics.DebuggerNonUserCode]");
            WriteGeneratedCodeAttribute(ref fi);
        }
    }
}