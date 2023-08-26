using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using System.Diagnostics;

namespace csharp_Protoshift.Configuration
{
    public static class Config
    {
        private static readonly HashSet<string> SupportedVersions = new(new string[]
            { "1.0.0" });
        public const string LATEST_CONFIG_VERSION = "1.0.0";

        public const string JSON_SCHEMA_VALIDATOR_EXDATA_ENTRY = "JsonSchemaValidatorErrors";

        private static Config_v1_0_0? _globalConfig;
        public static Config_v1_0_0 Global =>
            _globalConfig ?? throw new InvalidOperationException("config.json not loaded.");

        public static async Task Initialize(string configFilePath)
        {
            string json = File.ReadAllText(configFilePath);
            JObject configObject = JObject.Parse(json);
            string? configVersion = (string?)configObject["ConfigVersion"];

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

            var schema_cur_version = await JsonSchema.FromJsonAsync(
                await File.ReadAllTextAsync($"Config/config_schema_v{configVersion}.json"));
            Debug.Assert(schema_cur_version != null);
            schema_cur_version.AllowAdditionalItems = true;
            schema_cur_version.AllowAdditionalProperties = true;
            var validate_res = schema_cur_version.Validate(configObject);
            Debug.Assert(!validate_res.IsReadOnly);
            if (validate_res.Count != 0)
            {
                var jsonex = new JsonException($"Config serialization failed: " +
                    $"please check the schema rules.");
                jsonex.Data[JSON_SCHEMA_VALIDATOR_EXDATA_ENTRY] = validate_res;
            }
        }
    }
}
