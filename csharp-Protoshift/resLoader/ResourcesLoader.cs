using AssetLib.Formats;
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
            "        /newcmdid.csv -- New Protos CmdIds" +
            "        /oldcmdid.csv -- Old Protos CmdIds";

        /// <summary>
        /// Check for resources, if not complete then exit with code 114514.
        /// </summary>
        public static void CheckForRequiredResources()
        {
            bool passcheck = true;
            // Resources
            if (!Directory.Exists("resources"))
            {
                Log.Erro("resources dir missing! Please copy it from \"/resources\"!", "ResourcesCheck");
                Log.Info(StructureDescription, "ResourcesCheck");
                passcheck = false;
            }
            else
            {
                bool resourcesComplete = true;
                if (!File.Exists("resources/protobuf/newcmdid.csv"))
                {
                    Log.Erro("/resources/protobuf/newcmdid.csv not found!", "ResourcesCheck");
                    resourcesComplete = false;
                }
                if (!File.Exists("resources/protobuf/oldcmdid.csv"))
                {
                    Log.Erro("/resources/protobuf/oldcmdid.csv not found!", "ResourcesCheck");
                    resourcesComplete = false;
                }
                if (!File.Exists("resources/xor/dispatchKey.bin"))
                {
                    Log.Erro("/resources/xor/dispatchKey.bin not found!", "ResourcesCheck");
                    resourcesComplete = false;
                }
                if (!Directory.Exists("resources/rsakeys/ClientPri"))
                {
                    Log.Erro("/resources/rsakeys/ClientPri not found!", "ResourcesCheck");
                    resourcesComplete = false;
                }
                if (!Directory.Exists("resources/rsakeys/ServerPri"))
                {
                    Log.Erro("/resources/rsakeys/ServerPri not found!", "ResourcesCheck");
                    DirectoryInfo serverpubdir = new("resources/rsakeys/ServerPub");
                    if (serverpubdir.Exists && serverpubdir.EnumerateFiles().Any())
                    {
                        Log.Warn("Detected /resources/rsakeys/ServerPub keys given. ServerPub keys " +
                            $"are only used for some utils in the program, and ServerPri keys " +
                            $"are REQUIRED for you to run an actual Protoshift server.", "ResourcesCheck");
                    }
                    resourcesComplete = false;
                }
                if (!resourcesComplete)
                {
                    Log.Info(StructureDescription, "ResourcesCheck");
                    passcheck = false;
                }
            }
            if (!passcheck)
            {
                Log.Erro("Resources check didn't pass. Press Enter to exit.", "ResourcesCheck");
                Console.ReadLine();
                Environment.Exit(114514);
            }
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
