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
                        Log.Erro($"Cleanup of command {cmd.GetType()} failed: {ex}", nameof(ServerCommandLine));
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
                handler.ShowUsage();
                Log.Info("", nameof(ServerCommandLine));
            }
        }

        private static void RefuseCommand(string commandName)
        {
            Log.Info($"Invalid command: {commandName}.", nameof(ServerCommandLine));
        }

        public static async Task Start()
        {
            ConsoleWrapper.ShutDownRequest += (_, _) => Environment.Exit(0);
            while (true)
            {
                ConsoleWrapper.InputPrefix = "> ";
                string cmd = await ConsoleWrapper.ReadLineAsync();
                if (cmd == string.Empty) continue;
                int sepindex = cmd.IndexOf(' ');
                if (sepindex == -1) sepindex = cmd.Length;
                string commandName = cmd.Substring(0, sepindex);
                if (commandName.ToLower() == "help" || commandName == "?")
                {
                    ShowHelps();
                    continue;
                }
                else
                {
                    string argList = cmd.Substring(Math.Min(cmd.Length, sepindex + 1));
                    bool handled = false;
                    foreach (var cmdhandle in handlers)
                    {
                        if (cmdhandle.CommandName == commandName)
                        {
                            handled = true;
                            try
                            {
                                await cmdhandle.HandleAsync(argList);
                            }
                            catch (Exception ex)
                            {
                                Log.Erro(ex.ToString(), nameof(ServerCommandLine));
                                Log.Info($"Encountered error when handling command {commandName}. Please check your input.", nameof(ServerCommandLine));
                            }
                            break;
                        }
                    }
                    if (!handled) RefuseCommand(commandName);
                }
            }
        }
    }
}