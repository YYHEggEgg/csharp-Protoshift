using csharp_Protoshift.RSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

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
            "        /ServerPub -- Server Public Keys, SPub\n" +
            "            /2-pub.pem, ..., 5-pub.pem -- PEM format RSA keys with key_id";

        /// <summary>
        /// Check for resources, if not complete then exit with code 114514.
        /// </summary>
        public static void CheckForRequiredResources()
        {
            bool passcheck = true;
            // KCP
            if (!File.Exists("ikcp.dll"))
            {
                Log.Erro("ikcp.dll missing! Please copy it from \"/KCP/AnimeGameKCP/Native/KCP\"!", "ResourcesCheck");
                passcheck = false;
            }
            // Resources
            if (!Directory.Exists("resources"))
            {
                Log.Erro("resources dir missing! Please copy it from \"/resources\"!", "ResourcesCheck");
                Log.Info(ResourcesLoader.StructureDescription, "ResourcesCheck");
                passcheck = false;
            }
            // Openssl
            try
            {
                Task.WaitAll(Tools.ExecuteProcess("openssl", "version"));
            }
            catch
            {
                Log.Erro("Openssl is probably not installed. You may install it and add it to the system PATH.", "ResourcesCheck");
                Log.Info("Custom openssl path will supported in the future. Maybe... But if you want it please create an issue.");
                passcheck = false;
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
            Resources.dispatchKey = await File.ReadAllBytesAsync("/resources/xor/dispatchKey.bin");
            Resources.dispatchSeed = await File.ReadAllBytesAsync("/resources/xor/dispatchSeed.bin");

            foreach (var file in Directory.GetFiles("/resources/rsakeys/ClientPri"))
            {
                FileInfo info = new(file);
                uint id = UInt32.Parse(info.Name[0].ToString());
                string pemKey = await File.ReadAllTextAsync(file);
                Resources.CPri.Add(id, new Openssl(pemKey, false));
            }
            foreach (var file in Directory.GetFiles("/resources/rsakeys/ServerPub"))
            {
                FileInfo info = new(file);
                uint id = UInt32.Parse(info.Name[0].ToString());
                string pemKey = await File.ReadAllTextAsync(file);
                Resources.SPub.Add(id, new Openssl(pemKey, true));
            }
        }
    }
}
