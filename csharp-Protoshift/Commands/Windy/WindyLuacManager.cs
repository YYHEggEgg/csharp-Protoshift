using csharp_Protoshift.Configuration;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Windy
{
    internal static partial class WindyLuacManager
    {
        private static Dictionary<string, (string luaHash, byte[] luacContent, string outputHash)> compiled_luacs = new();

        #region Compile lua
        public static async Task<byte[]> CompileLua(string luaPathInput)
        {
            if (!Tools.TryGetFullFilePath(luaPathInput, EnvFullPath, "lua", "luac", out var luaFullPath))
                throw new FileNotFoundException("The specified file does not exist.", 
                    Path.GetFullPath($"./{luaPathInput}", EnvFullPath));
            if (luaFullPath.EndsWith(".luac"))
                return await File.ReadAllBytesAsync(luaFullPath);
            else return await CompileLuaCore(luaFullPath);
        }

        private static async Task<byte[]> CompileLuaCore(string luaFullPath)
        {
            FileInfo luaFile = new(luaFullPath);
            var luaFileHash = GetFileHash(luaFile);
            lock (lua_dict_lck)
            {
                if (compiled_luacs.TryGetValue(luaFullPath, out var tuple))
                {
                    if (tuple.luaHash == luaFileHash) return tuple.luacContent;
                    else File.Delete($"{CompiledPath}/" +
                        tuple.outputHash.Substring(0, tuple.outputHash.IndexOf('|')));
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
        private static byte[] ConstructSendableWindyProtobufFrom(
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

        public static async Task<byte[]> CompileSendableWindyProtobuf(string luaPath)
        {
            return ConstructSendableWindyProtobufFrom(await CompileLua(luaPath));
        }

        public static async Task<byte[]> GetSendableWindyProtobufFromFile(string filePath)
        {
            return ConstructSendableWindyProtobufFrom(
                await File.ReadAllBytesAsync(filePath));
        }
        #endregion

        #region EnvPath
        private static string _envPath = Path.Combine(Resources.BasePath, "windy_scripts");
        /// <summary>
        /// Get the windy env path. 
        /// </summary>
        public static string EnvPath
        {
            get { return _envPath; }
            set
            {
                _envPath = value;
                _envPathChanged = true;
            }
        }

        private static string? _envFullPath;
        private static bool _envPathChanged = true;
        public static string EnvFullPath
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
        public static string? CompiledPath { get; set; } = null;
        public static bool SetCompiledTempPath(string? newTempPath)
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
                                LogTrace.WarnTrace(ex, nameof(WindyLuacManager), 
                                    $"Moving luac: {fileName} to new env folder failed. " +
                                    $"It'll be compiled again next time.");
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

        #region README content
        private const string WINDY_COMPILED_README =
@"This directory is created by csharp-Protoshift, storing .luac compiled results.

It's essential for the windy command. 

Don't modify/delete the files here when Protoshift server is running; 
and don't place your files here as they will probably be lost.";

        #endregion

        #region Locks
        private static object lua_dict_lck = "kinda windy today";
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
            res += $"-o \"{outputPath}\" ";
            res += $"\"{fileSource.FullName}\"";
            return res;
        }
    }
}
