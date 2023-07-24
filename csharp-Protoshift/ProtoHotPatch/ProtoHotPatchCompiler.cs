using System.Reflection;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.ProtoHotPatch
{
    internal static partial class ProtoHotPatchCompiler
    {
        public const string identifier_connect = "->";
        public static readonly JsonSerializerOptions deserializeConfig = new JsonSerializerOptions
        {
            ReadCommentHandling = JsonCommentHandling.Skip,
            AllowTrailingCommas = true,
        };
        public static readonly string? OldProtosAssembly = 
            Assembly.GetAssembly(typeof(OldProtos.AskCmdId))?.FullName;
        public static readonly string? NewProtosAssembly = 
            Assembly.GetAssembly(typeof(NewProtos.AskCmdId))?.FullName;
        public static readonly string? ProtoshiftHandlersAssembly = 
            Assembly.GetAssembly(typeof(csharp_Protoshift.Enhanced.Handlers.HandlerBase))?.FullName;

        public static void CompileFromFile(string json)
        {
            HotPatchMiddleware.Clear();
            ProtoshiftHotPatchConfig[]? res;
            try
            {
                res = JsonSerializer.Deserialize<ProtoshiftHotPatchConfig[]>(json, deserializeConfig);
            }
            catch (Exception ex)
            {
                Log.Erro(PSHP002, nameof(ProtoHotPatchCompiler));
                Log.Info($"Detail: deserializing meets {ex}", nameof(ProtoHotPatchCompiler));
                return;
            }
            if (!Check(res) || res == null)
            {
                return;
            }
            bool full_compile_succ = true;
            foreach (var config in res)
            {
                bool config_compile_succ = true;
                if (!config.Enabled) continue;
                if (config.ApplyTo == "client")
                {
                    Type? type_proto = Type.GetType($"OldProtos.{config.Proto}, {OldProtosAssembly}");
                    Type? handler_proto = Type.GetType($"csharp_Protoshift.Enhanced.Handlers" +
                        $".GeneratedCode.Handler{config.Proto}, {ProtoshiftHandlersAssembly}");
                    if (type_proto == null || handler_proto == null)
                    {
                        Log.Erro(PSHP004, nameof(ProtoHotPatchCompiler));
                        full_compile_succ = false;
                        continue;
                    }
                    List<(MethodInfo source, PropertyInfo target)> reflection = new();
                    for (int j = 0; j < config.Rules.Length; j++)
                    {
                        string? rule = config.Rules[j];
                        string frmField = rule.Substring(0, rule.IndexOf(identifier_connect));
                        string toField = rule.Substring(rule.IndexOf(identifier_connect) + identifier_connect.Length);
                        MethodInfo? method = handler_proto.GetMethod($"GetOld{frmField}");
                        PropertyInfo? target = type_proto.GetProperty($"{toField}");
                        // TODO: PSHP010
                        if (method == null)
                        {
                            Log.Erro($"In Proto: {config.Proto}, Rule #{j}: {PSHP020}", nameof(ProtoHotPatchCompiler));
                            config_compile_succ = false;
                        }
                        if (target == null)
                        {
                            Log.Erro($"In Proto: {config.Proto}, Rule #{j}: {PSHP009}", nameof(ProtoHotPatchCompiler));
                            config_compile_succ = false;
                        }
                        if (!config_compile_succ)
                        {
                            full_compile_succ = false;
                            continue;
                        }
#pragma warning disable CS8620 // 由于引用类型的可为 null 性差异，实参不能用于形参。
                        else reflection.Add((method, target));
#pragma warning restore CS8620 // 由于引用类型的可为 null 性差异，实参不能用于形参。
                    }
                    HotPatchMiddleware.AssignNewShiftToOldMiddleware(config.Proto,
                        ((object newprotocol, object oldprotocol_return) pair) =>
                        {
                            foreach (var work in reflection)
                            {
                                try
                                {
                                    work.target.SetValue(pair.oldprotocol_return,
                                        work.source.Invoke(pair.newprotocol, null));
                                }
                                catch (Exception ex)
                                {
                                    Log.Warn($"ProtoHotPatch worker meets exception: {ex}", nameof(HotPatchMiddleware));
                                }
                            }
                            return pair.oldprotocol_return;
                        });
                }
                else if (config.ApplyTo == "server")
                {
                    Type? type_proto = Type.GetType($"NewProtos.{config.Proto}, {NewProtosAssembly}");
                    Type? handler_proto = Type.GetType($"csharp_Protoshift.Enhanced.Handlers." +
                        $"GeneratedCode.Handler{config.Proto}, {ProtoshiftHandlersAssembly}");
                    if (type_proto == null || handler_proto == null)
                    {
                        Log.Erro($"PSHP003: The corresponding Proto was not found.", nameof(ProtoHotPatchCompiler));
                        throw new Exception();
                    }
                    List<(MethodInfo source, PropertyInfo target)> reflection = new();
                    foreach (var rule in config.Rules)
                    {
                        string frmField = rule.Substring(0, rule.IndexOf(identifier_connect));
                        string toField = rule.Substring(rule.IndexOf(identifier_connect) + identifier_connect.Length);
                        MethodInfo? method = handler_proto.GetMethod($"GetNew{frmField}");
                        PropertyInfo? target = type_proto.GetProperty($"{toField}");
                        // TODO: PSHP010
                        if (method == null)
                        {
                            Log.Erro($"PSHP020: The left field of the field does not exist," +
                                $"or can be already Protoshifted normally.");
                            throw new Exception();
                        }
                        if (target == null)
                        {
                            Log.Erro($"PSHP009: At least one side of the rule field name is undefined.");
                            throw new Exception();
                        }
                        reflection.Add((method, target));
                    }
                    HotPatchMiddleware.AssignOldShiftToNewMiddleware(config.Proto,
                        ((object oldprotocol, object newprotocol_return) pair) =>
                        {
                            object res = pair.newprotocol_return;
                            foreach (var work in reflection)
                            {
                                try
                                {
                                    work.target.SetValue(res,
                                        work.source.Invoke(null, new object[] { pair.oldprotocol }));
                                }
                                catch (Exception ex)
                                {
                                    Log.Warn($"ProtoHotPatch worker meets exception: {ex}", nameof(HotPatchMiddleware));
                                }
                            }
                            return res;
                        });
                }
                else
                {
                    Log.Erro($"In Proto: {config.Proto} {PSHP005}", nameof(ProtoHotPatchCompiler));
                    full_compile_succ = false;
                }
            }
            if (full_compile_succ)
            {
                HotPatchMiddleware.Apply();
                Log.Info($"Applied Proto HotPatch successfully.", nameof(ProtoHotPatchCompiler));
            }
            else Log.Erro($"Compile failure. Please fix the issues and reload.", nameof(ProtoHotPatchCompiler));
        }
    }
}
