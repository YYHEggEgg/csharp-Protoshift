using csharp_Protoshift.Enhanced.Handlers.Generator;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.resLoader
{
    public static class ResourcesLoader
    {
        public const string StructureDescription =
            "Resources Description\n" +
            "/resources\n" +
            "    /xor\n" +
            "        /dispatchSeed.bin -- dispatch Ec2b Seed\n" +
            "        /dispatchKey.bin -- dispatch Ec2b Key\n" +
            "    /rsakeys\n" +
            "        /ClientPri -- Client Private Keys, CPri\n" +
            "            /2.pem, ..., 5.pem -- PEM format RSA keys with key_id\n" +
            "        /ServerPri -- Server Private Keys, SPri\n" +
            "            /2-pri.pem, ..., 5-pri.pem -- PEM format RSA keys with key_id\n" +
            "    /config-schemas\n" +
            "        /config_schema_{version}.json -- schema json, DO NOT delete\n" +
            "    /luac_bins -- windy compilers, DO NOT delete";

        private static LoggerChannel? _checklogger = null;

        #region Check
        /// <summary>
        /// Check for resources, if not complete then exit with code 114514.
        /// </summary>
        public static void CheckForRequiredResources(string resPath = "./resources")
        {
            _checklogger = Log.GetChannel("ResourcesCheck");
            bool passcheck = true;
            // Resources
            if (Tools.DirNonExistsOrEmpty(resPath))
            {
                _checklogger.LogErro("resources dir missing or empty! ");
                _checklogger.LogInfo(StructureDescription);
                passcheck = false;
            }
            else
            {
                bool resourcesComplete = true;
                // Will be provided from remote
                // CheckFileResource("protobuf/newcmdid.csv", resPath, ref resourcesComplete);
                // CheckFileResource("protobuf/oldcmdid.csv", resPath, ref resourcesComplete);
                CheckFileResource("xor/dispatchKey.bin", resPath, ref resourcesComplete);
                CheckDirectoryResource("rsakeys/ClientPri", resPath, ref resourcesComplete);
                CheckDirectoryResource("rsakeys/ServerPri", resPath, ref resourcesComplete, 
                    continueOnFailure: () =>
                {
                    DirectoryInfo serverpubdir = new("rsakeys/ServerPub");
                    if (serverpubdir.Exists && serverpubdir.EnumerateFiles().Any())
                    {
                        Log.Warn("Detected /resources/rsakeys/ServerPub keys given. ServerPub keys " +
                            $"are only used for some utils in the program, and ServerPri keys " +
                            $"are REQUIRED for you to run an actual Protoshift server.", "ResourcesCheck");
                    }
                    resourcesComplete = false;
                });
                CheckFileResource("luac_bins/luac_win32.exe", resPath, ref resourcesComplete);
                CheckFileResource("luac_bins/luac_win64.exe", resPath, ref resourcesComplete);
                CheckFileResource("luac_bins/luac_unix64", resPath, ref resourcesComplete);
                if (!resourcesComplete)
                {
                    _checklogger.LogInfo(StructureDescription);
                    passcheck = false;
                }
            }
            if (!passcheck)
            {
                _checklogger.LogErro("Resources check didn't pass. Check them and run again. Exit code is 114514.");
                Environment.Exit(114514);
            }
        }

        private static void CheckFileResource(string path, string resBasePath, ref bool isResComplete)
        {
            var filePath = Path.Combine(resBasePath, path);
            if (!File.Exists(filePath))
            {
                _checklogger?.LogErro($"{filePath} not found!");
                isResComplete = false;
            }
        }

        private static void CheckDirectoryResource(string path, string resBasePath, 
            ref bool isResComplete, Action? continueOnSuccess = null, Action? continueOnFailure = null)
        {
            var dirPath = Path.Combine(resBasePath, path);
            if (Tools.DirNonExistsOrEmpty(dirPath))
            {
                _checklogger?.LogErro($"{dirPath} not found or empty!");
                isResComplete = false;
                continueOnFailure?.Invoke();
            }
            else continueOnSuccess?.Invoke();
        }
        #endregion
    }
}
