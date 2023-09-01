using Newtonsoft.Json;
using YYHEggEgg.Logger;

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
namespace csharp_Protoshift.Configuration
{
    public class WindyLuacOverridePaths_v1_0_1
    {
        public string? Path_win32 { get; set; }
        public string? Path_win64 { get; set; }
        public string? Path_mac64 { get; set; }
        public string? Path_linux32 { get; set; }
        public string? Path_linux64 { get; set; }
    }

    public class WindyConfig_v1_0_1
    {
        public WindyLuacOverridePaths_v1_0_1? WindyLuacOverridePaths { get; set; }
        public string WindyEnvironmentPath { get; set; }
        public string WindyCompiledTempPath { get; set; }
        public OnlineExecWindyMode_v1_0_0 OnlineExecWindyMode { get; set; }
        public string? OnlineExecWindyLua { get; set; }
        public bool? StripDebugInformation { get; set; }
    }

    public class Config_v1_0_1
    {
        public const string CORRESPONDING_VERSION = "1.0.1";

        public string ConfigVersion { get; set; }
        public bool EnableFullPacketLog { get; set; }
        public string[]? PacketLogExcluding { get; set; }
        public NetConfig_v1_0_0 NetConfig { get; set; }
        public WindyConfig_v1_0_1 WindyConfig { get; set; }

        public static Config_v1_0_1 Deserialize(string json, string configVersion)
        {
            if (configVersion == CORRESPONDING_VERSION)
            {
                return JsonConvert.DeserializeObject<Config_v1_0_1>(json)
                    ?? throw new JsonException("Config serialization failed: " +
                    "please check whether your config matches the json format.");
            }
            else
            {
                return ParseOldVersion(json, configVersion);
            }
        }

        public static Config_v1_0_1 ParseOldVersion(string json, string configVersion)
        {
            if (configVersion == CORRESPONDING_VERSION)
                return Deserialize(json, configVersion);

            var olderconfig = Config_v1_0_0.ParseOldVersion(json, configVersion);
            if (olderconfig.WindyConfig?.WindyLuacPath != null)
            {
                Log.Warn($"Field '#/WindyConfig/WindyLuacPath' is " +
                    $"deprecated in current version and its value " +
                    $"will not take effect. Update your config " +
                    $"to version 1.0.1 and Use '#/WindyConfig" +
                    $"/WindyLuacOverridePaths' instead.", nameof(Config_v1_0_1));
            }

            var rtn = new Config_v1_0_1
            {
                ConfigVersion = configVersion,
                NetConfig = olderconfig.NetConfig,
                EnableFullPacketLog = olderconfig.EnableFullPacketLog,
                PacketLogExcluding = null
            };

            if (olderconfig.WindyConfig != null)
            {
                var olderwindyconf = olderconfig.WindyConfig;
                rtn.WindyConfig = new WindyConfig_v1_0_1
                {
                    OnlineExecWindyMode = olderwindyconf.OnlineExecWindyMode,
                    OnlineExecWindyLua = olderwindyconf.OnlineExecWindyLua,
                    WindyCompiledTempPath = olderwindyconf.WindyCompiledTempPath ?? "windy_temp",
                    WindyEnvironmentPath = olderwindyconf.WindyEnvironmentPath ?? "resources/windy_scripts",
                };
            }

            return rtn;
        }
    }
}
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。