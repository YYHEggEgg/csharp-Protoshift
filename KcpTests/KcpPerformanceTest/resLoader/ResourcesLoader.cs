using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
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
            "        /dispatchKey.bin -- dispatch Ec2b Key";

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
                if (!File.Exists("resources/xor/dispatchKey.bin"))
                {
                    Log.Erro("/resources/xor/dispatchKey.bin not found!");
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
        public static async Task<string> Load()
        {
            Resources.dispatchKey = await File.ReadAllBytesAsync("resources/xor/dispatchKey.bin");
            Resources.dispatchSeed = await File.ReadAllBytesAsync("resources/xor/dispatchSeed.bin");
            return "Resources Loaded.";
        }
    }
}
