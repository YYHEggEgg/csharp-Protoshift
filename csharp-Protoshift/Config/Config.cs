using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.Validation;
using System.Diagnostics;

namespace csharp_Protoshift.Configuration
{
    public static class Config
    {
        public static readonly HashSet<string> SupportedVersions = new(new string[]
            { "1.0.0" });
        public const string LATEST_CONFIG_VERSION = "1.0.0";

        private static Config_v1_0_0? _globalConfig;
        public static Config_v1_0_0 Global =>
            _globalConfig ?? throw new InvalidOperationException("config.json not loaded.");
        private static JObject? _baseConfigJson;
        public static JObject BaseConfigJson =>
            _baseConfigJson ?? throw new InvalidOperationException("config.json not loaded.");

        public static async Task InitializeAsync(string configFilePath)
        {
            string json = await File.ReadAllTextAsync(configFilePath);
            _baseConfigJson = JObject.Parse(json);
            string? configVersion = (string?)_baseConfigJson["ConfigVersion"];

            if (configVersion == null || !SupportedVersions.Contains(configVersion))
            {
                throw new NotSupportedException($"Unsupported config version: {configVersion ?? "<not provided ConfigVersion field>"}");
            }

            if (configVersion == LATEST_CONFIG_VERSION)
            {
                _globalConfig = Config_v1_0_0.Deserialize(json, configVersion);
            }
            else
            {
                _globalConfig = Config_v1_0_0.ParseOldVersion(json, configVersion);
            }
        }

        public static async Task<ICollection<ValidationError>?> ValidateAsync()
        {
            if (_baseConfigJson == null) return null;

            string? configVersion = (string?)_baseConfigJson["ConfigVersion"];
            if (configVersion == null || !SupportedVersions.Contains(configVersion))
            {
                return null;
            }
            var schema_cur_version = await JsonSchema.FromJsonAsync(
                await File.ReadAllTextAsync($"resources/config-schemas/config_schema_v{configVersion}.json"));
            Debug.Assert(schema_cur_version != null);
            schema_cur_version.AllowAdditionalItems = true;
            schema_cur_version.AllowAdditionalProperties = true;
            var validate_res = schema_cur_version.Validate(_baseConfigJson);
            return validate_res;
        }
    }
}
