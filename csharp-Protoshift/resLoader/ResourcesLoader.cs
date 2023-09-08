using AssetLib.Formats;
using csharp_Protoshift.Configuration;
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
            "    /protobuf\n" +
            "        /newcmdid.csv -- New Protos CmdIds\n" +
            "        /oldcmdid.csv -- Old Protos CmdIds\n" +
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
            if (!Directory.Exists(resPath))
            {
                _checklogger.LogErro("resources dir missing! Please copy it from \"/resources\"!");
                _checklogger.LogInfo(StructureDescription);
                passcheck = false;
            }
            else
            {
                bool resourcesComplete = true;
                CheckFileResource("protobuf/newcmdid.csv", resPath, ref resourcesComplete);
                CheckFileResource("protobuf/oldcmdid.csv", resPath, ref resourcesComplete);
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
                CheckDirectoryResource("config-schemas", resPath, ref resourcesComplete,
                    continueOnSuccess: () =>
                    {
                        foreach (var supportedVer in Config.SupportedVersions)
                        {
                            CheckFileResource($"config-schemas/config_schema_" +
                                $"v{supportedVer}.json", resPath, ref resourcesComplete);
                        }
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
                _checklogger.LogErro("Resources check didn't pass. Press Enter to exit.");
                if (Log.GlobalConfig.Use_Console_Wrapper) ConsoleWrapper.ReadLine();
                else Console.ReadLine();
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
            if (!Directory.Exists(dirPath))
            {
                _checklogger?.LogErro($"{dirPath} not found!");
                isResComplete = false;
                continueOnFailure?.Invoke();
            }
            else continueOnSuccess?.Invoke();
        }
        #endregion

        #region Load
        /// <summary>
        /// Load resources to Resources Class.
        /// </summary>
        public static async Task Load(string resPath = "./resources")
        {
            #region Ec2b key & seed
            Resources.dispatchKey = await File.ReadAllBytesAsync($"{resPath}/xor/dispatchKey.bin");

            if (File.Exists($"{resPath}/xor/dispatchSeed.bin"))
            {
                Resources.dispatchSeed = await File.ReadAllBytesAsync($"{resPath}/xor/dispatchSeed.bin");

                try
                {
                    var calckey = Ec2b.Decrypt(Resources.dispatchSeed);
                    if (!IsBytesEqual(calckey, Resources.dispatchKey))
                    {
                        Log.Warn($"The Ec2b calculate result of dispatchSeed.bin doesn't" +
                            $"equal to the content of dispatchKey.bin. " +
                            $"The server will continue using the content of " +
                            $"dispatchKey.bin.", nameof(ResourcesLoader));
                    }
                }
                catch (Exception ex)
                {
                    Log.Warn($"Ec2b calculate of dispatchSeed.bin failed. {ex}", nameof(ResourcesLoader));
                    Log.Warn($"The server will continue using the content of " +
                        $"dispatchKey.bin.", nameof(ResourcesLoader));
                }
            }
            #endregion

            #region RSAKeys
            if (Directory.Exists($"{resPath}/rsakeys/ClientPri"))
            {
                foreach (var file in Directory.GetFiles($"{resPath}/rsakeys/ClientPri"))
                {
                    FileInfo info = new(file);
                    if (info.Extension != ".pem") continue;
                    uint id = UInt32.Parse(info.Name[0].ToString());
                    try
                    {
                        string pemKey = await File.ReadAllTextAsync(file);
                        Resources.CPri.Add(id, Tools.LoadRSAKey(pemKey));
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Load ClientPri key id: {id} failed, skipped file: {file}. {ex}", nameof(ResourcesLoader));
                    }
                }
            }
            if (Directory.Exists($"{resPath}/rsakeys/ServerPub"))
            {
                foreach (var file in Directory.GetFiles($"{resPath}/rsakeys/ServerPub"))
                {
                    FileInfo info = new(file);
                    if (info.Extension != ".pem") continue;
                    uint id = UInt32.Parse(info.Name[0].ToString());
                    try
                    {
                        string pemKey = await File.ReadAllTextAsync(file);
                        Resources.SPub.Add(id, Tools.LoadRSAKey(pemKey));
                        Log.Warn($"Loaded Server public key (id: {id}). ServerPub keys " +
                            $"are only used for some utils in the program, and ServerPri keys " +
                            $"are REQUIRED for you to run an actual Protoshift server.",
                            nameof(ResourcesLoader));
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Load ServerPub key id: {id} failed, skipped file: {file}. {ex}", nameof(ResourcesLoader));
                    }
                }
            }
            if (Directory.Exists($"{resPath}/rsakeys/ServerPri"))
            {
                foreach (var file in Directory.GetFiles($"{resPath}/rsakeys/ServerPri"))
                {
                    FileInfo info = new(file);
                    if (info.Extension != ".pem") continue;
                    uint id = UInt32.Parse(info.Name[0].ToString());
                    try
                    {
                        string pemKey = await File.ReadAllTextAsync(file);
                        Resources.SPri.Add(id, Tools.LoadRSAKey(pemKey));
                        Resources.SPub.TryAdd(id, Tools.LoadRSAKey(pemKey));
                    }
                    catch (Exception ex)
                    {
                        Log.Warn($"Load ServerPri key id: {id} failed, skipped file: {file}. {ex}", nameof(ResourcesLoader));
                    }
                }
            }
            #endregion
        }
        
        
        #endregion

        private static bool IsBytesEqual(byte[]? l, byte[]? r)
        {
            if (l == null && r == null) return true;
            else if (l == null || r == null) return false;

            if (l.Length != r.Length) return false;
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] != r[i]) return false;
            }
            return true;
        }
    }
}
