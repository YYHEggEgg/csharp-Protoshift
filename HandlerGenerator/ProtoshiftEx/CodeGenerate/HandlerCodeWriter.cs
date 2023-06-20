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
            MessageResult oldmessage, MessageResult newmessage)
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
            fi.ExitCodeRegion();
            #endregion
            fi.WriteLine("#endregion");
            #endregion
            fi.ExitCodeRegion();
        }
    }
}