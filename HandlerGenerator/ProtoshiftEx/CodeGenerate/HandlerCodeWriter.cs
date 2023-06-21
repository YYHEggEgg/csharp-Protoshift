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
            ref ProtocStringPoolManager stringPool)
        {
            fi.WriteLine($"public class Handler{messageName} ",
                $": HandlerBase<NewProtos.{messageName}, OldProtos.{messageName}>");
            fi.EnterCodeRegion();

            #region Base Type
            fi.WriteLine("#region Base Type");
            fi.WriteLine($"MessageParser<NewProtos.{messageName}> newproto_parser_base = NewProtos.{messageName}.Parser;");
            fi.WriteLine($"MessageParser<OldProtos.{messageName}> oldproto_parser_base = OldProtos.{messageName}.Parser;");
            fi.WriteLine("#endregion");
            #endregion
            #region Import Types
            var bothimports = new ImportTypesCollection(oldmessage, newmessage);
            fi.WriteLine("#region Import Types");
            foreach (var importLine in bothimports.searchByFriendlyName.Keys)
            {
                fi.WriteLine($"Handler{importLine} handler_{importLine} = new();");
            }
            fi.WriteLine("#endregion");
            #endregion
            fi.WriteLine();
            #region Protocol Shift
            fi.WriteLine("#region Protocol Shift");
            #region NewShiftToOld
            fi.WriteLine($"public override OldProtos.{messageName} NewShiftToOld(NewProtos.{messageName} newprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine($"OldProtos.{messageName} oldprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, true, ref bothimports, ref stringPool);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, true, ref bothimports, ref stringPool);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, true, ref bothimports, ref stringPool);
            fi.WriteLine($"return oldprotocol;");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region OldShiftToNew
            fi.WriteLine($"public override NewProtos.{messageName} OldShiftToNew(OldProtos.{messageName} oldprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine($"NewProtos.{messageName} newprotocol = new();");
            GenerateCommonFieldsHandler(ref fi, oldmessage, newmessage, false, ref bothimports, ref stringPool);
            GenerateMapFieldsHandler(ref fi, oldmessage, newmessage, false, ref bothimports, ref stringPool);
            GenerateOneofFieldsHandler(ref fi, oldmessage, newmessage, false, ref bothimports, ref stringPool);
            fi.WriteLine($"return newprotocol;");
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine("#endregion");
            #endregion
            fi.WriteLine();
            #region Outer bytes invoke
            fi.WriteLine("public override byte[] NewShiftToOld(byte[] arr, int offset, int length)",
                "=> NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();");
            fi.WriteLine("public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)",
                "=> NewShiftToOld(newproto_parser_base.ParseFrom(span)).ToByteArray();");
            fi.WriteLine("public override byte[] OldShiftToNew(byte[] arr, int offset, int length)",
                "=> OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();");
            fi.WriteLine("public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)",
                "=> OldShiftToNew(oldproto_parser_base.ParseFrom(span)).ToByteArray();");
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
            EnumResult oldenum, EnumResult newenum, ref CompiledEnumStringPoolManager stringPool)
        {
            fi.WriteLine($"public class Handler{enumName} ",
                $": HandlerEnumBase<NewProtos.{enumName}, OldProtos.{enumName}>");
            fi.EnterCodeRegion();
            #region Prepare 
            var enumNodes_both = oldenum.enumNodes.Intersect(newenum.enumNodes);
            var enumNodes_oldOnly = oldenum.enumNodes.Except(newenum.enumNodes);
            var enumNodes_newOnly = newenum.enumNodes.Except(oldenum.enumNodes);
            #endregion
            #region NewShiftToOld
            fi.WriteLine($"public override OldProtos.{enumName} NewShiftToOld(NewProtos.{enumName} newprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("switch (newprotocol)");
            fi.EnterCodeRegion();
            foreach (var newOnly in enumNodes_newOnly)
            {
                fi.WriteLine($"// Not found match enum node in old: [ {newOnly} ]");
            }
            foreach (var name in enumNodes_both)
            {
                fi.WriteLine($"case NewProtos.{enumName}.{stringPool.GetCompiledName(name)}:",
                    $"return OldProtos.{enumName}.{stringPool.GetCompiledName(name)};",
                    "break;");
            }
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine();
            #region OldShiftToNew
            fi.WriteLine($"public override NewProtos.{enumName} OldShiftToNew(OldProtos.{enumName} oldprotocol)");
            fi.EnterCodeRegion();
            fi.WriteLine("switch (oldprotocol)");
            fi.EnterCodeRegion();
            foreach (var newOnly in enumNodes_newOnly)
            {
                fi.WriteLine($"// Not found match enum node in new: [ {newOnly} ]");
            }
            foreach (var name in enumNodes_both)
            {
                fi.WriteLine($"case OldProtos.{enumName}.{stringPool.GetCompiledName(name)}:",
                    $"return NewProtos.{enumName}.{stringPool.GetCompiledName(name)};",
                    "break;");
            }
            fi.ExitCodeRegion();
            fi.ExitCodeRegion();
            #endregion
            fi.ExitCodeRegion();
        }
    }
}