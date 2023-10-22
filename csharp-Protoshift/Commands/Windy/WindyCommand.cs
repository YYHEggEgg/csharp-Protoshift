using CommandLine;
using csharp_Protoshift.Commands.Windy;
using csharp_Protoshift.GameSession;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
#pragma warning disable CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。
    [Verb("send", true, HelpText = "execute a lua/luac file.")]
    internal class WindySendConfig : StrictTargetOptionBase
    {
        [Option("everyone", Default = false, Required = false, HelpText = "Whether to send the windy to everyone online.")]
        public bool IsEveryone { get; set; }
        [Value(0, Required = false, Default = null, HelpText = "The .lua file name/path.")]
        public string? LuaFile { get; set; }
        [Option("compiled", Default = null, Required = false, HelpText = "The compiled .luac file path.")]
        public string? ForceCompiled { get; set; }
    }

    [Verb("set-env", false, HelpText = "Set a directory as a default location that stores .lua files and a source for relative paths.")]
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
        [Option('t', "targetOS", Required = true, HelpText = "The luac (lua compiler) path for a specified OS.")]
        public OSType TargetOS { get; set; }
    }

    [Verb("set-temp-path", false, HelpText = "Set the temp folder where compiled .luac files are stored.")]
    internal class WindySetTempPathConfig
    {
        [Value(0, Required = true, HelpText = "The temp folder path.")]
        public string TempPath { get; set; }
    }
#pragma warning restore CS8618 // 在退出构造函数时，不可为 null 的字段必须包含非 null 值。请考虑声明为可以为 null。

    internal class WindyCommand : CommandHandlerBase
    {
        public override string CommandName => "windy";

        public override string Description => "Send a lua script to the specified client(s).";

        public override string Usage => $"windy [command] <args>{Environment.NewLine}" +
            $"  command send (default): execute a lua/luac file. {Environment.NewLine}" +
            $"    windy -u <player_uid> | -c <conv_id> | --everyone {Environment.NewLine}" +
            $"          <lua_file_path> | --compiled <compiled_luac_path>{Environment.NewLine}" +
            $"      In most cases, you just need to give the path of .lua and windy command will compile it for you. {Environment.NewLine}" +
            $"      If use --compiled, the program will treat it as compiled lua, {Environment.NewLine}" +
            $"      or the behaviour depends on the extension is either .lua or .luac.{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command set-env: Set a directory as a default location that stores .lua files and a source for relative paths. {Environment.NewLine}" +
            $"    windy set-env <dir-full-path>{Environment.NewLine}" +
            $"      After this you may invoke windy without path and extension, e.g. windy HideUI{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command set-luac: Set the luac (lua compiler) executable path. {Environment.NewLine}" +
            $"    windy set-luac {Environment.NewLine}" +
            $"      [-t, --targetOS <OSType>] The luac (lua compiler) path for a specified OS. {Environment.NewLine}" +
            $"                                Supported: win32, win64, mac32, mac64, linux32, linux64{Environment.NewLine}" +
            $"      <luac-path>               The path of the executable. {Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"  command set-temp-path: Set the temp folder where compiled .luac files are stored.{Environment.NewLine}" +
            $"    windy set-temp-path <temp-path>";

        public WindyCommand()
        {
            _ = Task.Run(GameSessionDispatch.ValidateWindyAutoExecute);
        }

        public override async Task HandleAsync(string argList)
        {
            var args = ParseAsArgs(argList);
            await DefaultCommandsParser.ParseArguments<WindySendConfig, WindySetEnvConfig, WindySetLuacConfig>(args)
                .MapResult(
                    async (WindySendConfig o) => await HandleSendAsync(o),
                    async (WindySetEnvConfig o) => await HandleSetEnvAsync(o),
                    async (WindySetLuacConfig o) => await HandleSetLuacAsync(o),
                    async (WindySetTempPathConfig o) => await HandleSetTempPathAsync(o),
                    error =>
                    {
                        OutputInvalidUsage(error);
                        ShowUsage();
                        return Task.CompletedTask;
                    });
        }

        #region Commands
        private async Task HandleSendAsync(WindySendConfig opt)
        {
            #region Read param
            uint specifiedconv = 0;
            bool everyonewindy = opt.IsEveryone;
            if (!everyonewindy)
            {
                specifiedconv = opt.GetConv(_logger);
                if (specifiedconv == 0)
                {
                    _logger.LogErro($"Please use a correct windy command!");
                    return;
                }
            }

            if (opt.LuaFile == null && opt.ForceCompiled == null)
            {
                _logger.LogErro($"Please provide a .lua or .luac file to send windy!");
                return;
            }
            if (opt.LuaFile != null && opt.ForceCompiled != null)
            {
                _logger.LogErro($"Please provide either .lua or .luac file to send windy! Providing both is not supported.");
                return;
            }
            string? filePath = opt.LuaFile ?? opt.ForceCompiled;
            bool compiled = opt.ForceCompiled != null;
            if (!Tools.TryGetFullFilePath(filePath, WindyLuacManager.EnvFullPath, "lua", "luac", out filePath))
            {
                _logger.LogErro($"File: {filePath} found in neither windy env path nor working directory!");
                return;
            }
            #endregion
            byte[] sendres = compiled
                ? await WindyLuacManager.GetSendableWindyProtobufFromFile(filePath)
                : await WindyLuacManager.CompileSendableWindyProtobuf(filePath);
            #region Confirm
            bool permitted = false;
            FileInfo luafileInfo = new(filePath);
            if (!everyonewindy) permitted = true;
            else if (GameSessionDispatch.sessions.Count <= 1) permitted = true;
            else if (GameSessionDispatch.sessions.Count <= 5)
            {
                _logger.LogWarn($"You are sending WindSeed to every online session " +
                    $"({GameSessionDispatch.sessions.Count} sessions) connected to this server.");
                _logger.LogInfo($"Running lua info: {WindyLuacManager.GetFileHash(luafileInfo)}");
                _logger.LogWarn($"Please carefully check the lua info. " +
                    $"To confirm the execution, type 'y' and press Enter.");
                ConsoleWrapper.InputPrefix = "Confirm or cancel> ";
                var res = await ConsoleWrapper.ReadLineAsync(false);
                permitted = res.Trim().ToLower() == "y";
            }
            else
            {
                _logger.LogWarn($"You are sending WindSeed to every online session " +
                    $"({GameSessionDispatch.sessions.Count} sessions) connected to this server.");
                _logger.LogInfo($"Running lua info: {WindyLuacManager.GetFileHash(luafileInfo)}");
                _logger.LogWarn($"Please carefully check the lua info. To confirm the execution, " +
                    $"type the file name \"{luafileInfo.Name}\" and press Enter.");
                ConsoleWrapper.InputPrefix = "Confirm or cancel> ";
                var res = await ConsoleWrapper.ReadLineAsync(false);
                permitted = res.Trim() == luafileInfo.Name;
            }

            if (!permitted)
            {
                _logger.LogErro($"User cancelled the windy execute.");
                return;
            }
            #endregion
            if (!everyonewindy)
            {
                Program.ProxyServer.SendPacketToClient(specifiedconv,
                    GameSessionDispatch.ConstructPacketSendToClient(
                        specifiedconv, nameof(NewProtos.WindSeedClientNotify), null, sendres));
                _logger.LogInfo($"Successfully sent WindSeed: {luafileInfo.Name} to session {specifiedconv}.");
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
                                conv, nameof(NewProtos.WindSeedClientNotify), null, sendres));
                        success++;
                    }
                    catch { }
                }
                _logger.LogInfo($"Successfully sent WindSeed: {luafileInfo.Name} to {success}/{total} online session(s).");
            }
        }

        private Task HandleSetEnvAsync(WindySetEnvConfig opt)
        {
            WindyLuacManager.EnvPath = opt.DirectoryPath;
            _logger.LogInfo($"OK, " +
                Directory.EnumerateFiles(opt.DirectoryPath, "*.lua",
                SearchOption.TopDirectoryOnly).Count() +
                " lua files detected in the directory. This will be sync to config.json on exit.");
            return Task.CompletedTask;
        }

        private async Task HandleSetLuacAsync(WindySetLuacConfig opt)
        {
            if (await WindyLuacManager.TryModifyLuacExecutablePath(opt.FilePath, opt.TargetOS))
            {
                _logger.LogInfo($"Successfully modified lua compiler path for {opt.TargetOS}. This will be sync to config.json on exit.");
            }
            else
            {
                _logger.LogWarn($"lua compiler change failed. Please check the errors and try again.");
            }
        }

        private Task HandleSetTempPathAsync(WindySetTempPathConfig opt)
        {
            if (WindyLuacManager.SetCompiledTempPath(opt.TempPath))
            {
                _logger.LogInfo($"Successfully modified luac temp path, temp files are moved successfully. This will be sync to config.json on exit.");
            }
            else
            {
                _logger.LogWarn($"lua temp path modification failed. Please check the errors and try again.");
            }
            return Task.CompletedTask;
        }
        #endregion
    }
}
