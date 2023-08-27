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
            "        /config_schema_{version}.json -- schema json, do not delete";

        private static LoggerChannel? _checklogger = null;

        /// <summary>
        /// Check for resources, if not complete then exit with code 114514.
        /// </summary>
        public static void CheckForRequiredResources()
        {
            _checklogger = Log.GetChannel("ResourcesCheck");
            bool passcheck = true;
            // Resources
            if (!Directory.Exists("resources"))
            {
                _checklogger.LogErro("resources dir missing! Please copy it from \"/resources\"!");
                _checklogger.LogInfo(StructureDescription);
                passcheck = false;
            }
            else
            {
                bool resourcesComplete = true;
                CheckFileResource("resources/protobuf/newcmdid.csv", ref resourcesComplete);
                CheckFileResource("resources/protobuf/oldcmdid.csv", ref resourcesComplete);
                CheckFileResource("resources/xor/dispatchKey.bin", ref resourcesComplete);
                CheckDirectoryResource("resources/rsakeys/ClientPri", ref resourcesComplete);
                CheckDirectoryResource("resources/rsakeys/ServerPri", ref resourcesComplete, 
                    continueOnFailure: () =>
                {
                    DirectoryInfo serverpubdir = new("resources/rsakeys/ServerPub");
                    if (serverpubdir.Exists && serverpubdir.EnumerateFiles().Any())
                    {
                        Log.Warn("Detected /resources/rsakeys/ServerPub keys given. ServerPub keys " +
                            $"are only used for some utils in the program, and ServerPri keys " +
                            $"are REQUIRED for you to run an actual Protoshift server.", "ResourcesCheck");
                    }
                    resourcesComplete = false;
                });
                CheckDirectoryResource("resources/config-schemas", ref resourcesComplete,
                    continueOnSuccess: () =>
                    {
                        foreach (var supportedVer in Config.SupportedVersions)
                        {
                            CheckFileResource($"resources/config-schemas/config_schema_" +
                                $"v{supportedVer}.json", ref resourcesComplete);
                        }
                    });
                if (!resourcesComplete)
                {
                    _checklogger.LogInfo(StructureDescription);
                    passcheck = false;
                }
            }
            if (!passcheck)
            {
                _checklogger.LogErro("Resources check didn't pass. Press Enter to exit.");
                Console.ReadLine();
                Environment.Exit(114514);
            }
        }

        private static void CheckFileResource(string path, ref bool isResComplete)
        {
            if (!File.Exists(path))
            {
                _checklogger?.LogErro($"{path} not found!");
                isResComplete = false;
            }
        }

        private static void CheckDirectoryResource(string path, ref bool isResComplete,
            Action? continueOnSuccess = null, Action? continueOnFailure = null)
        {
            if (!Directory.Exists(path))
            {
                _checklogger?.LogErro($"{path} not found!");
                isResComplete = false;
                continueOnFailure?.Invoke();
            }
            else continueOnSuccess?.Invoke();
        }

        /// <summary>
        /// Load resources to Resources Class.
        /// </summary>
        public static async Task Load()
        {
            #region Ec2b key & seed
            Resources.dispatchKey = await File.ReadAllBytesAsync("resources/xor/dispatchKey.bin");

            if (File.Exists("resources/xor/dispatchSeed.bin"))
            {
                Resources.dispatchSeed = await File.ReadAllBytesAsync("resources/xor/dispatchSeed.bin");

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
            if (Directory.Exists("resources/rsakeys/ClientPri"))
            {
                foreach (var file in Directory.GetFiles("resources/rsakeys/ClientPri"))
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
            if (Directory.Exists("resources/rsakeys/ServerPub"))
            {
                foreach (var file in Directory.GetFiles("resources/rsakeys/ServerPub"))
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
            if (Directory.Exists("resources/rsakeys/ServerPri"))
            {
                foreach (var file in Directory.GetFiles("resources/rsakeys/ServerPri"))
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
