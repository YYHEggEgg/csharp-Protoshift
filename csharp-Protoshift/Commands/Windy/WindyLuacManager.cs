using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class WindyLuacManager : IJsonOnDeserialized, IJsonOnSerializing
    {
        /// <summary>
        /// Get the luac executable path. Notice that don't use the setter because it's used for <see cref="JsonSerializer"/>.
        /// </summary>
        public string? LuacExecutablePath { get; set; }
        public async Task<bool> TryModifyLuacExecutablePath(string luacFullPath, bool slient = false)
        {
            if (!slient) Log.Info($"Verifying luac at: {luacFullPath}", nameof(WindyLuacManager));
            try
            {
                var versionInfo = await new WindyOuterInvoke(luacFullPath, "-v").RunAsync();
                if (!slient) Log.Info($"Got luac version: {versionInfo}", nameof(WindyLuacManager));
                LuacExecutablePath = luacFullPath;
                return true;
            }
            catch (Exception ex)
            {
                if (!slient) Log.Erro($"verify luac failed: {ex}", nameof(WindyLuacManager));
                return false;
            }
        }

        [JsonIgnore]
        private Dictionary<string, (string luaHash, byte[] luacContent, string outputHash)> compiled_luacs = new();

        public async Task<byte[]> CompileLua(string luaPath)
        {
            if (LuacExecutablePath == null)
            {
                throw new InvalidOperationException("The luac path has not been set.");
            }
            FileInfo luaFile = new(luaPath);
            if (!luaFile.Exists)
            {
                throw new FileNotFoundException("The specified file does not exist.", luaFile.FullName);
            }
            var luaFileHash = GetFileHash(luaFile);
            lock (lua_dict_lck)
            {
                if (compiled_luacs.TryGetValue(luaFile.FullName, out var tuple) && tuple.luaHash == luaFileHash)
                {
                    return tuple.luacContent;
                }
            }
            Log.Info($"Start compiling lua file: {luaFile.FullName} (size: {luaFile.Length})", nameof(WindyLuacManager));
            Stopwatch compileWatch = Stopwatch.StartNew();
            string outputPath = $"{CompiledPath}/{Path.GetFileNameWithoutExtension(luaFile.Name)}.luac";
            await WindyOuterInvoke.CompileAsync(LuacExecutablePath, luaFile, outputPath, EnvPath);
            var res = await File.ReadAllBytesAsync(outputPath);
            lock (lua_dict_lck) compiled_luacs[luaFile.FullName] = (luaFileHash, res, GetFileHash(new(outputPath)));
            return res;
        }

        /// <summary>
        /// Get the windy env path. Notice that don't use the setter because it's used for <see cref="JsonSerializer"/>.
        /// </summary>
        public string EnvPath { get; set; } = Environment.CurrentDirectory;
        [JsonIgnore]
        public string CompiledPath => $"{EnvPath}/windy_compiled"; // also Hardcoded at SetEnvPath method
        public bool SetEnvPath(string newenvPath)
        {
            if (!Directory.Exists(newenvPath))
            {
                Log.Erro($"Path not exist: {newenvPath}. SetEnvPath failed. ", nameof(WindyLuacManager));
                return false;
            }
            List<string> deprecated_files = new();
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
                            var dstFile = $"{newenvPath}/windy_compiled/{fileName}";
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
            EnvPath = newenvPath;
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

        private class WindyOuterInvoke
        {
            public readonly string ProgramPath;
            public readonly string CommandLine;
            public readonly string WorkingDirectory;

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
                Process? p = Process.Start(startInfo);
                if (p == null) throw new IOException("The process is not started properly.");

                await p.WaitForExitAsync();
                if (p.ExitCode != 0) throw new IOException($"The process exited with code {p.ExitCode}.");

                return await p.StandardOutput.ReadToEndAsync();
            }

            public static async Task<byte[]> CompileAsync(string luacPath, FileInfo luaFile,
                string outputPath, string? workingDir = null)
            {
                workingDir ??= Environment.CurrentDirectory;
                if (!luaFile.Exists)
                {
                    throw new FileNotFoundException("The specified file does not exist.", luaFile.FullName);
                }
                await new WindyOuterInvoke(luacPath, $"-o {outputPath} {luaFile.FullName}", workingDir).RunAsync();
                return await File.ReadAllBytesAsync(outputPath);
            }
        }

        #region Json serialization
        public void OnDeserialized()
        {
            if (LuacExecutablePath != null &&
                !TryModifyLuacExecutablePath(LuacExecutablePath, true).Result)
            {
                LuacExecutablePath = null;
            }
            if (!SetEnvPath(EnvPath))
            {
                Log.Warn($"The past env path is deprecated. Use working directory instead now.", nameof(WindyLuacManager));
            }
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
        }

        public void OnSerializing()
        {
            lock (lua_dict_lck)
            {
                list_compiled_luacs = new();
                foreach (var pair in compiled_luacs)
                {
                    list_compiled_luacs.Add(new(pair.Key, (pair.Value.luaHash, pair.Value.outputHash)));
                }
            }
        }

        public List<KeyValuePair<string, (string luaHash, string outputHash)>>? list_compiled_luacs { get; set; }
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
}
