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
                    Log.Erro("/resources/protobuf/newcmdid.csv not found!");
                    resourcesComplete = false;
                }
                if (!File.Exists("resources/protobuf/oldcmdid.csv"))
                {
                    Log.Erro("/resources/protobuf/oldcmdid.csv not found!");
                    resourcesComplete = false;
                }
                if (!File.Exists("resources/xor/dispatchKey.bin"))
                {
                    Log.Erro("/resources/xor/dispatchKey.bin not found!");
                    resourcesComplete = false;
                }
                if (!Directory.Exists("resources/rsakeys/ClientPri"))
                {
                    Log.Erro("/resources/rsakeys/ClientPri not found!");
                    resourcesComplete = false;
                }
                if (!Directory.Exists("resources/rsakeys/ServerPri"))
                {
                    Log.Erro("/resources/rsakeys/ServerPri not found!");
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
            Resources.dispatchKey = await File.ReadAllBytesAsync("resources/xor/dispatchKey.bin");
            Resources.dispatchSeed = await File.ReadAllBytesAsync("resources/xor/dispatchSeed.bin");
            
            #region RSAKeys
            foreach (var file in Directory.GetFiles("resources/rsakeys/ClientPri"))
            {
                FileInfo info = new(file);
                if (info.Extension != ".pem") continue;
                uint id = UInt32.Parse(info.Name[0].ToString());
                string pemKey = await File.ReadAllTextAsync(file);
                Resources.CPri.Add(id, Tools.LoadRSAKey(pemKey));
            }
            if (Directory.Exists("resources/rsakeys/ServerPri"))
            {
                foreach (var file in Directory.GetFiles("resources/rsakeys/ServerPri"))
                {
                    FileInfo info = new(file);
                    if (info.Extension != ".pem") continue;
                    uint id = UInt32.Parse(info.Name[0].ToString());
                    string pemKey = await File.ReadAllTextAsync(file);
                    Resources.SPri.Add(id, Tools.LoadRSAKey(pemKey));
                }
            }
            #endregion
        }
    }
}
