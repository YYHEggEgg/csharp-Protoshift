using csharp_Protoshift.Configuration;
using Google.Protobuf;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Windy
{
    internal partial class WindyLuacManager : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// This constructor is used for <see cref="JsonSerializer"/>. Use <see cref="Instance"/> instead.
        /// </summary>
        public WindyLuacManager()
        {
            var settmpPathRes = SetCompiledTempPath("windy_temp");
            Debug.Assert(settmpPathRes);
        }
        public readonly static WindyLuacManager Instance = new();

        [JsonIgnore]
        private Dictionary<string, (string luaHash, byte[] luacContent, string outputHash)> compiled_luacs = new();

        #region Compile lua
        public async Task<byte[]> CompileLua(string luaPathInput)
        {
            if (!Tools.TryGetFullFilePath(luaPathInput, EnvFullPath, "lua", "luac", out var luaFullPath))
                throw new FileNotFoundException("The specified file does not exist.", 
                    Path.GetFullPath($"./{luaPathInput}", EnvFullPath));
            if (luaFullPath.EndsWith(".luac"))
                return await File.ReadAllBytesAsync(luaFullPath);
            else return await CompileLuaCore(luaFullPath);
        }

        private async Task<byte[]> CompileLuaCore(string luaFullPath)
        {
            FileInfo luaFile = new(luaFullPath);
            var luaFileHash = GetFileHash(luaFile);
            lock (lua_dict_lck)
            {
                if (compiled_luacs.TryGetValue(luaFullPath, out var tuple) && tuple.luaHash == luaFileHash)
                {
                    return tuple.luacContent;
                }
            }
            Log.Info($"Start compiling lua file: {luaFullPath} (size: {luaFile.Length})", nameof(WindyLuacManager));
            Stopwatch compileWatch = Stopwatch.StartNew();
            string outputPath = $"{CompiledPath}/{Path.GetFileNameWithoutExtension(luaFile.Name)}-{Guid.NewGuid()}.luac";
            await WindyOuterInvoke.CompileAsync(GetExecutable(), luaFile, outputPath);
            var res = await File.ReadAllBytesAsync(outputPath);
            lock (lua_dict_lck) compiled_luacs[luaFullPath] = (luaFileHash, res, GetFileHash(new(outputPath)));
            return res;
        }
        #endregion

        #region Windseed Construct
        private byte[] ConstructSendableWindyProtobufFrom(
            byte[] lua_compiled)
        {
#if !PROXY_ONLY_SERVER
            NewProtos.WindSeedClientNotify rce_warning = new();
#else
            OldProtos.WindSeedClientNotify rce_warning = new();
#endif
            rce_warning.AreaNotify = new()
            {
                AreaId = 1,
                AreaType = 1,
                AreaCode = ByteString.CopyFrom(lua_compiled, 0, lua_compiled.Length)
            };
            return rce_warning.ToByteArray();
        }

        public async Task<byte[]> CompileSendableWindyProtobuf(string luaPath)
        {
            return ConstructSendableWindyProtobufFrom(await CompileLua(luaPath));
        }

        public async Task<byte[]> GetSendableWindyProtobufFromFile(string filePath)
        {
            return ConstructSendableWindyProtobufFrom(
                await File.ReadAllBytesAsync(filePath));
        }
        #endregion

        #region EnvPath
        private string _envPath = "resources/windy_scripts";
        /// <summary>
        /// Get the windy env path. 
        /// </summary>
        [JsonIgnore]
        public string EnvPath
        {
            get { return _envPath; }
            set
            {
                _envPath = value;
                _envPathChanged = true;
            }
        }

        private string? _envFullPath;
        private bool _envPathChanged = true;
        [JsonIgnore]
        public string EnvFullPath
        {
            get
            {
                _envFullPath ??= Path.GetFullPath(_envPath);
                if (_envPathChanged) _envFullPath = Path.GetFullPath(_envPath);
                return _envFullPath;
            }
        }
        #endregion

        /// <summary>
        /// Get the compiled .luac temp path. Notice that don't use the setter, it's only used for <see cref="JsonSerializer"/>.
        /// </summary>
        [JsonIgnore]
        public string? CompiledPath { get; set; } = null;
        public bool SetCompiledTempPath(string? newTempPath)
        {
            if (newTempPath == null) return false;
            Directory.CreateDirectory(newTempPath);
            List<string> deprecated_files = new();
            if (CompiledPath != null)
            {
                lock (lua_dict_lck)
                {
                    foreach (var pair in compiled_luacs)
                    {
                        var (luaHash, luacContent, outputHash) = pair.Value;
                        string fileName = outputHash.Substring(0, outputHash.IndexOf('|'));
                        if (!File.Exists($"{CompiledPath}/{fileName}"))
                        {
                            Log.Warn($"Compiled luac: {fileName} not found in windy env path. " +
                                $"It'll be compiled again next time.", nameof(WindyLuacManager));
                            deprecated_files.Add(pair.Key);
                        }
                        else if (GetFileHash(new($"{CompiledPath}/{fileName}")) != outputHash)
                        {
                            Log.Warn($"Compiled luac: {fileName} has changed since the last compile. " +
                                $"It'll be compiled again next time.", nameof(WindyLuacManager));
                            deprecated_files.Add(pair.Key);
                        }
                        else try
                            {
                                var frmFile = $"{CompiledPath}/{fileName}";
                                var dstFile = $"{newTempPath}/{fileName}";
                                if (new FileInfo(frmFile).FullName != new FileInfo(dstFile).FullName)
                                {
                                    File.Move(frmFile, dstFile);
                                }
                            }
                            catch (Exception ex)
                            {
                                Log.Warn($"Moving luac: {fileName} to new env folder failed. " +
                                    $"It'll be compiled again next time.", nameof(WindyLuacManager));
                                Log.Warn(ex.ToString(), nameof(WindyLuacManager));
                                deprecated_files.Add(pair.Key);
                            }
                    }
                    foreach (var luaFile in deprecated_files)
                        compiled_luacs.Remove(luaFile);
                }
                try
                {
                    File.Delete($"{CompiledPath}/README.txt");
                    Directory.Delete(CompiledPath, false);
                }
                catch { }
            }
            CompiledPath = newTempPath;
            Directory.CreateDirectory(CompiledPath);
            File.WriteAllText($"{CompiledPath}/README.txt", WINDY_COMPILED_README);
            return true;
        }

        public static string GetFileHash(FileInfo info)
        {
            try
            {
                return $"{info.Name}|Size={info.Length}|WriteTime={info.LastWriteTime}|MD5={Tools.GetFileHash(info.FullName)}";
            }
            catch
            {
                return $"{info.Name}|EREADFAILURE|QueryTime={DateTime.Now:yyyy/MM/dd-HH:mm:ss.fffffff}|Random={Random.Shared.NextInt64()}";
            }
        }

        #region Json serialization
        public void OnDeserialized()
        {
            if (Config.Global.WindyConfig?.WindyCompiledTempPath != null && 
                !SetCompiledTempPath(Config.Global.WindyConfig?.WindyCompiledTempPath))
            {
                Log.Warn($"The past temp path is deprecated. Use default (./windy_temp) instead now.", nameof(WindyLuacManager));
            }
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            if (Config.Global.WindyConfig?.WindyEnvironmentPath != null)
            {
                EnvPath = Config.Global.WindyConfig?.WindyEnvironmentPath;
            }
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
            else if (list_compiled_luacs != null)
            {
                foreach (var pair in list_compiled_luacs)
                {
                    var (luaHash, outputHash) = pair.Value;
                    string fileName = outputHash.Substring(0, outputHash.IndexOf('|'));
                    string outputPath = $"{CompiledPath}/{fileName}";
                    if (File.Exists(pair.Key) && luaHash == GetFileHash(new(pair.Key)) &&
                        File.Exists(outputPath) && outputHash == GetFileHash(new(outputPath)))
                    {
                        compiled_luacs.Add(pair.Key, (luaHash, File.ReadAllBytes(outputPath), outputHash));
                    }
                }
            }

            if (list_lua_compilers_path != null)
            {
                _lua_compilers_path = new(list_lua_compilers_path);
                InitCompilerFromConfig();
            }
        }

        public void OnSerializing()
        {
            lock (lua_dict_lck)
            {
                list_compiled_luacs = new();
                foreach (var pair in compiled_luacs)
                {
                    list_compiled_luacs.Add(new(pair.Key, new(pair.Value.luaHash, pair.Value.outputHash)));
                }
            }
            list_lua_compilers_path = new(_lua_compilers_path);
            Config.Global.WindyConfig ??= new();
            Config.Global.WindyConfig.WindyEnvironmentPath = EnvPath;
#pragma warning disable CS8601 // 引用类型赋值可能为 null。
            Config.Global.WindyConfig.WindyCompiledTempPath = CompiledPath;
#pragma warning restore CS8601 // 引用类型赋值可能为 null。
        }

        public List<KeyValuePair<string, Tuple<string, string>>>? list_compiled_luacs { get; set; }
        public List<KeyValuePair<OSType, string>>? list_lua_compilers_path { get; set; }
        #endregion

        #region README content
        private const string WINDY_COMPILED_README =
@"This directory is created by csharp-Protoshift, storing .luac compiled results.

It's essential for the windy command. 

Don't modify/delete the files here when Protoshift server is running; 
and don't place your files here as they will probably be lost.";

        #endregion

        #region Save locks
        private object luac_exe_lck = "kinda"; // Unused
        private object env_path_lck = "windy"; // Unused
        private object lua_dict_lck = "today";
        #endregion
    }

    internal class WindyOuterInvoke
    {
        public readonly string ProgramPath;
        public readonly string CommandLine;
        public readonly string WorkingDirectory;

        private static readonly LogTextWriter errwriter = new(nameof(WindyOuterInvoke), LogLevel.Warning);

        public WindyOuterInvoke(string programPath, string commandLine, string? workingDirectory = null)
        {
            ProgramPath = programPath ?? throw new ArgumentNullException(nameof(programPath));
            CommandLine = commandLine ?? throw new ArgumentNullException(nameof(commandLine));
            WorkingDirectory = workingDirectory ?? Environment.CurrentDirectory;
        }

        /// <summary>
        /// Run the program with given params.
        /// </summary>
        /// <returns>The standard output content of running process.</returns>
        /// <exception cref="IOException">Running failed.</exception>
        internal async Task<string?> RunAsync()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(ProgramPath)
            {
                Arguments = CommandLine,
                WorkingDirectory = WorkingDirectory,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            Process? p = Process.Start(startInfo)
                ?? throw new IOException("The process is not started properly.");

            await p.WaitForExitAsync();
            var prod = await p.StandardOutput.ReadToEndAsync();
            if (p.ExitCode != 0)
            {
                errwriter.WriteLine(prod);
                throw new IOException($"The process exited with code {p.ExitCode}.");
            }

            return prod;
        }

        public static async Task<byte[]> CompileAsync(string luacPath, FileInfo luaFile,
            string outputPath, string? workingDir = null)
        {
            workingDir ??= Environment.CurrentDirectory;
            if (!luaFile.Exists)
            {
                throw new FileNotFoundException("The specified file does not exist.", luaFile.FullName);
            }
            await new WindyOuterInvoke(luacPath, GetCompileInvokeArgs(luaFile, outputPath), workingDir).RunAsync();
            return await File.ReadAllBytesAsync(outputPath);
        }

        private static string GetCompileInvokeArgs(FileInfo fileSource, string outputPath)
        {
            string res = string.Empty;
            if (Config.Global.WindyConfig.StripDebugInformation == true)
                res += "-s ";
            res += $"-o {outputPath} ";
            res += fileSource.FullName;
            return res;
        }
    }
}
