using csharp_Protoshift.Commands.Windy;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NJsonSchema;
using NJsonSchema.Validation;
using System.Diagnostics;

namespace csharp_Protoshift.Configuration
{
    public static class Config
    {
        public static readonly HashSet<string> SupportedVersions = new(new string[]
            { "1.0.0", "1.0.1" });
        public const string LATEST_CONFIG_VERSION = "1.0.1";

        private static Config_v1_0_1? _globalConfig;
        public static Config_v1_0_1 Global =>
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
                _globalConfig = Config_v1_0_1.Deserialize(json, configVersion);
            }
            else
            {
                _globalConfig = Config_v1_0_1.ParseOldVersion(json, configVersion);
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

        public static void FlushTo(string configFilePath)
        {
            var json = File.ReadAllText(configFilePath);
            var nowconfjson = JObject.Parse(json);
            if (_baseConfigJson == null && nowconfjson == null) return;
            nowconfjson ??= _baseConfigJson;
#pragma warning disable CS8602 // 解引用可能出现空引用。
            string? configVersion = (string?)nowconfjson["ConfigVersion"];
#pragma warning restore CS8602 // 解引用可能出现空引用。
            var merge_windy_jtoken = nowconfjson["WindyConfig"];

            if (configVersion == null || merge_windy_jtoken == null
                || !SupportedVersions.Contains(configVersion))
            {
                return;
            }

            var runtime_windy_conf = _globalConfig?.WindyConfig;
            if (runtime_windy_conf != null)
            {
                merge_windy_jtoken[nameof(WindyConfig_v1_0_1.WindyEnvironmentPath)] = runtime_windy_conf.WindyEnvironmentPath;
                merge_windy_jtoken[nameof(WindyConfig_v1_0_1.WindyCompiledTempPath)] = runtime_windy_conf.WindyCompiledTempPath;
            }

            #region Merge #/WindyConfig/WindyLuacOverridePaths
            var override_luacs = merge_windy_jtoken[nameof(WindyConfig_v1_0_1.WindyLuacOverridePaths)];
            bool luac_hasvalue_any = false;
            if (override_luacs == null)
            {
                override_luacs = new JObject();
            }
            if (WindyLuacManager.TryGetExecutable(OSType.win32, out var win32path)
                && win32path != WindyLuacManager.LuaCompilersDefault[OSType.win32])
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_win32)] = win32path;
                luac_hasvalue_any = true;
            }
            if (WindyLuacManager.TryGetExecutable(OSType.win64, out var win64path)
                && win64path != WindyLuacManager.LuaCompilersDefault[OSType.win64])
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_win64)] = win64path;
                luac_hasvalue_any = true;
            }
            if (WindyLuacManager.TryGetExecutable(OSType.mac32, out var mac32path))
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_mac32)] = mac32path;
                luac_hasvalue_any = true;
            }
            if (WindyLuacManager.TryGetExecutable(OSType.mac64, out var mac64path)
                && mac64path != WindyLuacManager.LuaCompilersDefault[OSType.mac64])
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_mac64)] = mac64path;
                luac_hasvalue_any = true;
            }
            if (WindyLuacManager.TryGetExecutable(OSType.linux32, out var linux32path))
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_linux32)] = linux32path;
                luac_hasvalue_any = true;
            }
            if (WindyLuacManager.TryGetExecutable(OSType.linux64, out var linux64path)
                && linux64path != WindyLuacManager.LuaCompilersDefault[OSType.linux64])
            {
                override_luacs[nameof(WindyLuacOverridePaths_v1_0_1.Path_linux64)] = linux64path;
                luac_hasvalue_any = true;
            }

            if (luac_hasvalue_any)
            {
                merge_windy_jtoken[nameof(WindyConfig_v1_0_1.WindyLuacOverridePaths)] = override_luacs;
            }
            #endregion // Merge #/WindyConfig/WindyLuacOverridePaths

            string outputJson = nowconfjson.ToString(Formatting.Indented);
            File.WriteAllText(configFilePath, outputJson);
        }
    }
}
