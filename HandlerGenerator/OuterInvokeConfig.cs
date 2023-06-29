using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    /// <summary>
    /// This class is used for configuring the invoke path of some apps. 
    /// It's useful if you don't add them to the environment PATH. 
    /// </summary>
    internal class OuterInvokeConfig
    {
        /// <summary>
        /// The protobuf compiler from https://github.com/protocolbuffers/protobuf/releases. 
        /// If protoc isn't in the PATH, you can change it to a definitive path.
        /// Not recommend a relative path because the working directory will be changed by the program at the startup. 
        /// </summary>
        public const string protoc_path = "protoc";
        /// <summary>
        /// The dotnet runtime CLI from Microsoft. 
        /// If dotnet isn't in the PATH, you can change it to a definitive path.
        /// Not recommend a relative path because the working directory will be changed by the program at the startup. 
        /// </summary>
        public const string dotnet_path = "dotnet";
    }
}
