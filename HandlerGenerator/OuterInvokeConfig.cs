namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    /// <summary>
    /// This class is used for configuring the invoke path of some apps. 
    /// It's useful if you don't add them to the environment PATH. 
    /// </summary>
    internal class OuterInvokeGlobalConfig
    {
        /// <summary>
        /// The protobuf compiler from https://github.com/protocolbuffers/protobuf/releases. 
        /// If protoc isn't in the PATH, you can change it to a definitive path.
        /// Not recommend a relative path because the working directory will be changed by the program at the startup. 
        /// </summary>
        public const string protoc_path = "E:\\Program Files\\Google.Protobuf\\protoc\\bin\\protoc.exe";
        /// <summary>
        /// The dotnet runtime CLI from Microsoft. 
        /// If dotnet isn't in the PATH, you can change it to a definitive path.
        /// Not recommend a relative path because the working directory will be changed by the program at the startup. 
        /// </summary>
        public const string dotnet_path = "dotnet";
        /// <summary>
        /// The git path. In most cases you should make git into PATH instead of changing here. 
        /// If git isn't in the PATH, you can change it to a definitive path.
        /// Not recommend a relative path because the working directory will be changed by the program at the startup. 
        /// </summary>
        public const string git_path = "git";
        /// <summary>
        /// The powershell path in Windows. This constant is here just because it can be here.
        /// </summary>
        public const string windows_powershell_path = "powershell.exe";
        /// <summary>
        /// The maximum length of creating a process's command line
        /// string. The minimum value ever searched is Windows
        /// cmd.exe's 8191, but here use 7 * 1024.
        /// </summary>
        public static int maximum_createproc_length => 7 * 1024;
    }
}
