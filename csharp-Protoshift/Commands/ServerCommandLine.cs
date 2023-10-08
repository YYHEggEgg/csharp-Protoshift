using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal static partial class ServerCommandLine
    {
        static ServerCommandLine()
        {
            // StopServer is now built-in command
            stopServer = new StopServerCmd();
            handlers.Add(stopServer);
            var cmdlist = ConfigureCommands();
            stopServer.ServerClosing += () =>
            {
                foreach (var cmd in cmdlist)
                {
                    try
                    {
                        cmd.CleanUp();
                    }
                    catch (NotImplementedException) { }
                    catch (Exception ex)
                    {
                        LogTrace.ErroTrace(ex, nameof(ServerCommandLine),
                            $"Cleanup of command {cmd.GetType()} failed: {ex}");
                    }
                }
                stopServer.CleanUpCompleted = true;
            };
            handlers.AddRange(cmdlist);
        }

        private static StopServerCmd stopServer;
        public static List<CommandHandlerBase> handlers = new();
        public static void ShowHelps()
        {
            foreach (var handler in handlers)
            {
                handler.ShowDescription();
            }
            Log.Info("Type [command] help to get more detailed usage.", nameof(ServerCommandLine));
        }

        private static void RefuseCommand(string commandName)
        {
            Log.Info($"Invalid command: {commandName}.", nameof(ServerCommandLine));
        }

        public static async Task Start()
        {
            bool running = true;
            ConsoleWrapper.ShutDownRequest += async (_, _) =>
            {
                running = false;
                ConsoleWrapper.InputPrefix = string.Empty;
                await stopServer.HandleAsync(string.Empty);
            };
            var helpstrings = CommandHandlerBase.HelpStrings;
            while (running)
            {
                ConsoleWrapper.InputPrefix = "> ";
                string cmd = await ConsoleWrapper.ReadLineAsync();
                if (cmd == string.Empty) continue;
                int sepindex = cmd.IndexOf(' ');
                if (sepindex == -1) sepindex = cmd.Length;
                string commandName = cmd.Substring(0, sepindex);
                if (helpstrings.Contains(commandName))
                {
                    ShowHelps();
                    continue;
                }

                string argList = cmd.Substring(Math.Min(cmd.Length, sepindex + 1));
                bool handled = false;
                foreach (var cmdhandle in handlers)
                {
                    if (cmdhandle.CommandName != commandName) continue;

                    handled = true;
                    try
                    {
                        if (helpstrings.Contains(argList.Trim().ToLower()))
                        {
                            cmdhandle.ShowUsage();
                        }
                        else
                        {
                            await cmdhandle.HandleAsync(argList);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogTrace.ErroTrace(ex, nameof(ServerCommandLine),
                            $"Encountered error when handling command {commandName}. Please check your input. ");
                    }
                    break;

                }
                if (!handled) RefuseCommand(commandName);

            }
            await Task.Delay(10000);
        }
    }
}