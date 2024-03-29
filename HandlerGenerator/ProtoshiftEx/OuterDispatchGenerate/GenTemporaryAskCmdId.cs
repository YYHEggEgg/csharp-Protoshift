﻿namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    internal static class GenTemporaryAskCmdId
    {
        public static void Run(string oldAskCmdIdPath, string newAskCmdIdPath)
        {
            InnerGen(oldAskCmdIdPath, false);
            InnerGen(newAskCmdIdPath, true);
        }

        private static void InnerGen(string genFilePath, bool isGenForNewProtos)
        {
            string identifier = isGenForNewProtos ? "New" : "Old";

            using (BasicCodeWriter fi = new(genFilePath))
            {
                fi.WriteLine("// <auto-generated>");
                fi.WriteLine("//     Generated by csharp-Protoshift.HandlerGenerator.");
                fi.WriteLine("// </auto-generated>");
                fi.WriteLine();
                fi.WriteLine("#nullable enable");
                fi.WriteLine("#region Designer Generated Code");
                fi.WriteLine();
                fi.WriteLine($"namespace {identifier}Protos");
                fi.EnterCodeRegion();
                fi.WriteLine("public static class AskCmdId");
                fi.EnterCodeRegion();
                fi.WriteLine("public static uint GetCmdIdFromProtoname(string protoname)");
                fi.EnterCodeRegion();
                fi.WriteLine($"throw new NotSupportedException(\"SHOULD NOT APPEAR: PLEASE TOTALLY REBUILD WITH HandlerGenerator.\");");
                fi.ExitCodeRegion();
                fi.WriteLine();
                fi.WriteLine("public static string GetProtonameFromCmdId(uint cmdid)");
                fi.EnterCodeRegion();
                fi.WriteLine($"throw new NotSupportedException(\"SHOULD NOT APPEAR: PLEASE TOTALLY REBUILD WITH HandlerGenerator.\");");
                fi.ExitCodeRegion();
                fi.WriteLine();
                fi.WriteLine("public static bool TryGetCmdIdFromProtoname(string protoname, out uint? cmdid)");
                fi.EnterCodeRegion();
                fi.WriteLine($"throw new NotSupportedException(\"SHOULD NOT APPEAR: PLEASE TOTALLY REBUILD WITH HandlerGenerator.\");");
                fi.ExitCodeRegion();
                fi.WriteLine();
                fi.WriteLine("public static bool TryGetProtonameFromCmdId(uint cmdid, out string? protoname)");
                fi.EnterCodeRegion();
                fi.WriteLine($"throw new NotSupportedException(\"SHOULD NOT APPEAR: PLEASE TOTALLY REBUILD WITH HandlerGenerator.\");");
                fi.ExitCodeRegion();

                fi.ExitCodeRegion();
                fi.ExitCodeRegion();
                fi.WriteLine("#nullable disable");
                fi.WriteLine("#endregion Designer generated code");
            }
        }

        public static void Clear(string oldAskCmdIdPath, string newAskCmdIdPath)
        {
            File.Delete(oldAskCmdIdPath);
            File.Delete(newAskCmdIdPath);
        }
    }
}
