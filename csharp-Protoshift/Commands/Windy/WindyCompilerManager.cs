using System.Collections.ObjectModel;
using YYHEggEgg.Logger;
using csharp_Protoshift.Configuration;

namespace csharp_Protoshift.Commands.Windy
{
    public enum OSType
    {
        Unsupported,
        win32,
        win64,
        mac32,
        mac64,
        linux32,
        linux64,
    }

    internal static class WindyCompilerManager
    {
        /// <summary>
        /// Get OS Suffix in combination of "win", "mac", "linux" and "32", "64".
        /// </summary>
        /// <returns>null if unsupported</returns>
        public static OSType GetOSSuffix()
        {
            string arch = Environment.Is64BitOperatingSystem ? "64" : "32";
            if (OperatingSystem.IsWindows()) return Enum.Parse<OSType>($"win{arch}");
            else if (OperatingSystem.IsMacOS()) return Enum.Parse<OSType>($"mac{arch}");
            else if (OperatingSystem.IsLinux()) return Enum.Parse<OSType>($"linux{arch}");
            else return OSType.Unsupported;
        }

        public static readonly ReadOnlyDictionary<OSType, string> LuaCompilersDefault = new(new Dictionary<OSType, string>
        {
            { OSType.win32, "resources/luac_bins/luac_win32.exe" },
            { OSType.win64, "resources/luac_bins/luac_win64.exe" },
            // { OSType.mac32, "resources/luac_bins/luac_mac32" },
            { OSType.mac64, "resources/luac_bins/luac_mac64" },
            { OSType.linux32, "resources/luac_bins/luac_linux32" },
            { OSType.linux64, "resources/luac_bins/luac_linux64" },
        });

        private static Dictionary<OSType, string> _lua_compilers_path = new(LuaCompilersDefault);

        static WindyCompilerManager()
        {
            var paths = Config.Global.WindyConfig.WindyLuacOverridePaths;
            if (paths?.Path_win32 != null) _lua_compilers_path[OSType.win32] = paths.Path_win32;
            if (paths?.Path_win64 != null) _lua_compilers_path[OSType.win64] = paths.Path_win64;
            if (paths?.Path_mac64 != null) _lua_compilers_path[OSType.mac64] = paths.Path_mac64;
            if (paths?.Path_linux32 != null) _lua_compilers_path[OSType.linux32] = paths.Path_linux32;
            if (paths?.Path_linux64 != null) _lua_compilers_path[OSType.linux64] = paths.Path_linux64;
        }

        private static LoggerChannel _logger = Log.GetChannel(nameof(WindyCompilerManager));

        public static async Task<bool> TryModifyLuacExecutablePath(
            string luacFullPath, OSType targetOS, bool slient = false)
        {
            if (targetOS == OSType.Unsupported)
            {
                if (!slient)
                {
                    _logger.LogWarn($"OS is not supported to run windy currently.");
                }
                return false;
            }
            if (!slient) _logger.LogInfo($"Verifying luac_{targetOS} at: {luacFullPath}");
            if (CanRuntimeValidate(targetOS))
            {
                try
                {
                    var versionInfo = await new WindyOuterInvoke(luacFullPath, "-v").RunAsync();
                    if (!slient) _logger.LogInfo($"Got luac version: {versionInfo}");
                    _lua_compilers_path[targetOS] = luacFullPath;
                    return true;
                }
                catch (Exception ex)
                {
                    if (!slient) _logger.LogErro($"verify luac_{targetOS} failed: {ex}");
                    return false;
                }
            }
            else
            {
                if (!slient)
                {
                    _logger.LogInfo($"Can't validate luac_{targetOS} currently, pass the check.");
                }
                _lua_compilers_path[targetOS] = luacFullPath;
                return true;
            }
        }

        private static bool CanRuntimeValidate(OSType targetOS)
        {
            switch (GetOSSuffix()) 
            {
                case OSType.Unsupported: return false;
                case OSType.win32: return targetOS == OSType.win32;
                case OSType.win64: return targetOS == OSType.win64 || targetOS == OSType.win32;
                case OSType.mac32: return targetOS == OSType.mac32;
                // You're right, but "macOS 10.15" is a macOS release version
                // independently developed by Apple. The kernel is running in
                // a mystrial world called 'Darwin'. You will act as a mysterious
                // character named as 'macOS Catalina', experience failing to run
                // any x86 apps with various usage and unique abilities, install
                // Parallel Desktop and find the lost Windows features -- and
                // gradually discover the truth about 'M1 Mac'.
                case OSType.mac64: return targetOS == OSType.mac64;
                case OSType.linux32: return targetOS == OSType.linux32;
                case OSType.linux64: return targetOS == OSType.linux64 || targetOS == OSType.linux32;
                default: return false;
            }
         }

        public static string GetExecutable() => GetExecutable(GetOSSuffix());
        public static string GetExecutable(OSType targetOS) => _lua_compilers_path[targetOS];
    }
}
