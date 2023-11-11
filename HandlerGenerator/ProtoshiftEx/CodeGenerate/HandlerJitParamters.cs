using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        /// <summary>
        /// Get (code of) a value of <paramref name="fieldType"/>
        /// to provide for GetNewShiftToOldJitInstance().
        /// </summary>
        /// <param name="fieldType"></param>
        /// <returns></returns>
        private static string GetTypeJitParamter(string fieldType)
        {
            return fieldType switch
            {
                "double" => "4.25",
                "float" => "3.4F",
                "int32" => "20231024",
                "int64" => "202411041200",
                "uint32" => "20231024",
                "uint64" => "202411041200",
                "sint32" => "20231024",
                "sint64" => "202411041200",
                "fixed32" => "20231024",
                "fixed64" => "202411041200",
                "sfixed32" => "20231024",
                "sfixed64" => "202411041200",
                "bool" => "true",
                "string" => "\"miHomo Technology Presents\"",
                "bytes" => "ByteString.CopyFrom(\"Masquerade of the GIO\", System.Text.Encoding.Default)",
                _ => $"handler_{fieldType}.GetNewShiftToOldJitInstance()"
            };
        }
    }
}
