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
        public static void GenerateMessageHandler(BasicCodeWriter fi, string messageName,
            MessageResult oldmessage, MessageResult newmessage)
        {
            fi.WriteLine($"public class Handler{messageName} ",
                $": HandlerBase<NewProtos.{messageName}, OldProtos.{messageName}>");
            fi.EnterCodeRegion();

            fi.ExitCodeRegion();
        }
    }
}