using Newtonsoft.Json;

#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
namespace csharp_Protoshift.Configuration
{
    public enum OnlineExecWindyMode_v1_0_0
    {
        None,
        OnKcpConnect,
        OnGetPlayerTokenFinish,
        Disabled
    }

    public class RemoteAddress_v1_0_0
    {
        public string? IpAddress { get; set; }
        public string? DomainAddress { get; set; }
        public UInt16 AddressPort { get; set; }
    }

    public class NetConfig_v1_0_0
    {
        public string BindAddress { get; set; }
        public UInt16 BindPort { get; set; }
        public RemoteAddress_v1_0_0 RemoteAddress { get; set; }
    }

    public class WindyConfig_v1_0_0
    {
        public string? WindyLuacPath { get; set; }
        public string? WindyEnvironmentPath { get; set; }
        public string? WindyCompiledTempPath { get; set; }
        public OnlineExecWindyMode_v1_0_0 OnlineExecWindyMode { get; set; }
        public string? OnlineExecWindyLua { get; set; }
    }

    public class Config_v1_0_0
    {
        public const string CORRESPONDING_VERSION = "1.0.0";

        public string ConfigVersion { get; set; }
        public bool EnableFullPacketLog { get; set; }
        public NetConfig_v1_0_0 NetConfig { get; set; }
        public WindyConfig_v1_0_0? WindyConfig { get; set; }

        public static Config_v1_0_0 Deserialize(string json, string configVersion)
        {
            if (configVersion == CORRESPONDING_VERSION)
            {
                return JsonConvert.DeserializeObject<Config_v1_0_0>(json)
                    ?? throw new JsonException("Config serialization failed: " +
                    "please check whether your config matches the json format.");
            }
            else
            {
                return ParseOldVersion(json, configVersion);
            }
        }

        public static Config_v1_0_0 ParseOldVersion(string json, string configVersion)
        {
            // Since 1.0.0 is the earliest version, we can just return the result of Deserialize.
            return Deserialize(json, CORRESPONDING_VERSION);
        }
    }
}
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。