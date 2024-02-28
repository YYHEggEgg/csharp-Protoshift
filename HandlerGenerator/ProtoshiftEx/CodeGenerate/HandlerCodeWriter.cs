using System.Reflection;
using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Generate a Message Handler class. Only handle the class body part, starting with <c>public class</c>.
        /// </summary>
        /// <param name="fi">The BasicCodeWriter (Generated outside).</param>
        /// <param name="MessageName">The message name, can be identified by the c# compiler but without NewProtos/OldProtos prefix.</param>
        /// <param name="oldmessage">The analyzed old message.</param>
        /// <param name="newmessage">The analyzed new message.</param>
        public static void GenerateMessageHandler(ref BasicCodeWriter fi, string MessageName,
            MessageResult oldmessage, MessageResult newmessage, 
            CompiledEnumsStringPoolCollection oldenumPool, CompiledEnumsStringPoolCollection newenumPool)
        {
            string friendly_MessageName = MessageName.Substring(
                MessageName.Contains('.') ? MessageName.LastIndexOf('.') + 1 : 0);
            fi.WriteLine($"public class Handler{friendly_MessageName} ",
                $": HandlerBase<NewProtos.{MessageName}, OldProtos.{MessageName}>");
            fi.EnterCodeRegion();
            var innermessage_collection = CollectionHelper.GetCompareResult(
                oldmessage.MessageFields, newmessage.MessageFields, MessageResult.NameComparer);
            var innerenum_collection = CollectionHelper.GetCompareResult(
                oldmessage.EnumFields, newmessage.EnumFields, EnumResult.NameComparer);

            #region Base Type
            fi.WriteLine("#region Base Type");
            fi.WriteLine($"MessageParser<NewProtos.{MessageName}> newproto_parser_base = NewProtos.{MessageName}.Parser;");
            fi.WriteLine($"MessageParser<OldProtos.{MessageName}> oldproto_parser_base = OldProtos.{MessageName}.Parser;");
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
            fi.WriteLine($"public override OldProtos.{MessageName}? NewShiftToOld(NewProtos.{MessageName}? newprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine($"if (newprotocol == null) return null;");
            fi.WriteLine($"OldProtos.{MessageName} oldprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, true, allimports, ref newskillIssues);
            if (newskillIssues.HasSkillIssue)
            {
                #region Skill issue Middleware
                fi.WriteLine("#if DEBUG");
                fi.WriteLine("var __worker = HotPatchMiddleware.Worker;");
                fi.WriteLine($"if (__worker.HasNewShiftToOldMiddleare(typeof(NewProtos.{MessageName}).Name))");
                fi.EnterCodeRegion();
                fi.WriteLine($"oldprotocol = (OldProtos.{MessageName})__worker.ExecuteNewShiftToOldMiddleware(",
                    $"typeof(NewProtos.{MessageName}).Name, newprotocol, oldprotocol);");
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
            fi.WriteLine($"public override NewProtos.{MessageName}? OldShiftToNew(OldProtos.{MessageName}? oldprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("if (oldprotocol == null) return null;");
            fi.WriteLine($"NewProtos.{MessageName} newprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, false, allimports, ref oldskillIssues);
            if (oldskillIssues.HasSkillIssue)
            {
                #region Skill issue Middleware
                fi.WriteLine("#if DEBUG");
                fi.WriteLine("var __worker = HotPatchMiddleware.Worker;");
                fi.WriteLine($"if (__worker.HasOldShiftToNewMiddleare(typeof(OldProtos.{MessageName}).Name))");
                fi.EnterCodeRegion();
                fi.WriteLine($"newprotocol = (NewProtos.{MessageName})__worker.ExecuteOldShiftToNewMiddleware(",
                    $"typeof(OldProtos.{MessageName}).Name, oldprotocol, newprotocol);");
                fi.ExitCodeRegion();
                fi.WriteLine("#endif");
                #endregion
            }
            fi.WriteLine($"return newprotocol;");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region JIT API
            fi.WriteLine("#region JIT API");
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override NewProtos.{MessageName} GetNewShiftToOldJitInstance()");
            fi.EnterCodeRegion();
            fi.WriteLine($"NewProtos.{MessageName} newprotocol = new();");
            GenerateCommonFieldsJitAPI(ref fi, oldmessage, newmessage);
            GenerateMapFieldsJitAPI(ref fi, oldmessage, newmessage);
            GenerateOneofFieldsJitAPI(ref fi, oldmessage, newmessage);
            fi.WriteLine($"return newprotocol;");
            fi.ExitCodeRegion();

            var subtypes = from name in 
                (from innerMessage in innermessage_collection.IntersectItems
                select innerMessage.LeftItem.MessageName).Concat(
                    from innerEnum in innerenum_collection.IntersectItems
                    select innerEnum.LeftItem.EnumName)
                orderby name
                select name;
            fi.WriteLine();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override void RunJit()");
            fi.EnterCodeRegion();
            fi.WriteLine("var instance = GetNewShiftToOldJitInstance();");
            fi.WriteLine("OldShiftToNew(NewShiftToOld(instance.ToByteArray()));");
            fi.WriteLine("OldShiftToNew(new Span<byte>(NewShiftToOld(new Span<byte>(instance.ToByteArray())).ToByteArray()));");
            fi.WriteLine("OldShiftToNew(NewShiftToOld(instance.ToByteString()));");
            if (subtypes.Any())
            {
                fi.WriteLine();
                foreach (var subname in subtypes)
                {
                    fi.WriteLine($"Handler{subname}.GlobalInstance.RunJit();");
                }
            }
            fi.ExitCodeRegion();
            
            fi.WriteLine("#endregion");
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
                        MessageName, friendly_MessageName);
                }
                if (newskillIssues.HasSkillIssue)
                {
                    GenerateSkillIssueList(ref fi, true, newskillIssues, allimports,
                        MessageName, friendly_MessageName);
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
            fi.WriteLine("public override IMessage? NewShiftToOld(ReadOnlySpan<byte> span)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));");
            fi.WriteLine("return rtn;");
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
            fi.WriteLine("public override IMessage? OldShiftToNew(ReadOnlySpan<byte> span)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));");
            fi.WriteLine("return rtn;");
            fi.ExitCodeRegion();
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine("public override ByteString OldShiftToNew(ByteString bytes)");
            fi.EnterCodeRegion();
            fi.WriteLine("var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));");
            fi.WriteLine("return rtn == null ? ByteString.Empty : rtn.ToByteString();");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            fi.WriteLine($"private static Handler{friendly_MessageName} _globalOnlyInstance = new Handler{friendly_MessageName}();");
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public static Handler{friendly_MessageName} GlobalInstance => _globalOnlyInstance;");
            #region Inner Messages
            fi.WriteLine();
            fi.WriteLine("#region Inner Messages");
            foreach (var inner_message in innermessage_collection.IntersectItems)
            {
                string inner_message_name = inner_message.LeftItem.MessageName;
                GenerateMessageHandler(ref fi, $"{MessageName}.Types.{inner_message_name}",
                    inner_message.LeftItem, inner_message.RightItem, oldenumPool, newenumPool);
            }
            fi.WriteLine("#endregion");
            #endregion
            #region Inner Enums
            fi.WriteLine();
            fi.WriteLine("#region Inner Enums");
            foreach (var inner_enum in innerenum_collection.IntersectItems)
            {
                string inner_enum_name = inner_enum.LeftItem.EnumName;
                string inner_enum_compiled_name = $"{MessageName}.Types.{inner_enum_name}";
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
        /// <param name="EnumName">The enum name, can be identified by the c# compiler but without NewProtos/OldProtos prefix.</param>
        /// <param name="oldenum">The analyzed old enum.</param>
        /// <param name="newenum">The analyzed new enum.</param>
        public static void GenerateEnumHandler(ref BasicCodeWriter fi, string EnumName,
            EnumResult oldenum, EnumResult newenum, 
            CompiledEnumStringPoolManager oldstringPool, CompiledEnumStringPoolManager newstringPool)
        {
            string friendly_EnumName = EnumName.Substring(
                EnumName.Contains('.') ? EnumName.LastIndexOf('.') + 1 : 0);
            fi.WriteLine($"public class Handler{friendly_EnumName} ",
                $": HandlerEnumBase<NewProtos.{EnumName}, OldProtos.{EnumName}>");
            fi.EnterCodeRegion();
            #region Prepare 
            var enumNodes_both = oldenum.EnumNodes.Intersect(newenum.EnumNodes);
            var enumNodes_oldOnly = oldenum.EnumNodes.Except(newenum.EnumNodes);
            var enumNodes_newOnly = newenum.EnumNodes.Except(oldenum.EnumNodes);
            #endregion
            #region NewShiftToOld
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override OldProtos.{EnumName} NewShiftToOld(NewProtos.{EnumName} newprotocol)");
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
                fi.WriteLine($"case NewProtos.{EnumName}.{newstringPool.GetCompiledName(name)}:",
                    $"return OldProtos.{EnumName}.{oldstringPool.GetCompiledName(name)};");
            }
            var name_first = oldenum.EnumNodes.First().name;
            fi.WriteLine("default:",
                $"return (OldProtos.{EnumName})((int)newprotocol);");
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region OldShiftToNew
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public override NewProtos.{EnumName} OldShiftToNew(OldProtos.{EnumName} oldprotocol)");
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
                fi.WriteLine($"case OldProtos.{EnumName}.{oldstringPool.GetCompiledName(name)}:",
                    $"return NewProtos.{EnumName}.{newstringPool.GetCompiledName(name)};");
            }
            name_first = newenum.EnumNodes.First().name;
            fi.WriteLine("default:",
                $"return (NewProtos.{EnumName})((int)oldprotocol);");
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            fi.WriteLine($"private static Handler{friendly_EnumName} _globalOnlyInstance = new Handler{friendly_EnumName}();");
            WriteNonUserCodeSign(ref fi);
            fi.WriteLine($"public static Handler{friendly_EnumName} GlobalInstance => _globalOnlyInstance;");
            fi.ExitCodeRegion();
        }

        private static void GenerateSkillIssueList(ref BasicCodeWriter fi, bool generateForNew, 
            SkillIssueCollection skillIssues, ImportTypesCollection importInfo, 
            string MessageName,
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
                bool isSupportedType = !commonField.IsImportType ? true
                    : importInfo.ContainsKey(commonField.FieldType);
                fi.WriteLine($"(\"{commonField.FieldType}\", \"{commonField.FieldName}\", " +
                    $"\"{Tools.GetProtocCompiledName(commonField.FieldName)}\", {isSupportedType.ToString().ToLower()}),");
            }
            foreach (var mapField in skillIssues.MapFields)
            {
                bool isSupportedType =
                    (mapField.KeyIsImportType ? importInfo.ContainsKey(mapField.KeyType) : true) && 
                    (mapField.ValueIsImportType ? importInfo.ContainsKey(mapField.ValueType) : true);
                fi.WriteLine($"(\"map<{mapField.KeyType}, {mapField.ValueType}>\", " +
                    $"\"{mapField.FieldName}\", \"{Tools.GetProtocCompiledName(mapField.FieldName)}\", " +
                    $"{isSupportedType.ToString().ToLower()}),");
            }
            foreach (var oneofField in skillIssues.OneofFields)
            {
                foreach (var oneofInnerField in oneofField.OneofInnerFields)
                {
                    bool isSupportedType = !oneofInnerField.IsImportType ? true
                        : importInfo.ContainsKey(oneofInnerField.FieldType);
                    fi.WriteLine($"(\"{oneofInnerField.FieldType}\", \"{oneofInnerField.FieldName}\", " +
                        $"\"{Tools.GetProtocCompiledName(oneofInnerField.FieldName)}\", {isSupportedType.ToString().ToLower()}),");
                }
            }
            fi.RemoveIndent();
            fi.WriteLine("};");
            fi.RemoveIndent();
            foreach (var commonField in skillIssues.CommonFields)
            {
                GenerateCommonFieldOnewayAPI(ref fi, commonField.FieldName, commonField,
                    generateForNew, importInfo, MessageName, baseMessage_friendlyName);
            }
            foreach (var mapField in skillIssues.MapFields)
            {
                GenerateMapFieldOnewayAPI(ref fi, mapField.FieldName, mapField,
                    generateForNew, importInfo, MessageName, baseMessage_friendlyName);
            }
            foreach (var oneofField in skillIssues.OneofFields)
            {
                GenerateOneofFieldOnewayAPI(ref fi, MessageName, oneofField,
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