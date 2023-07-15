using csharp_Protoshift.GameSession;
using csharp_Protoshift.resLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using YSFreedom.Common.Net;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal static partial class CommandLine
    {
        static CommandLine()
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
                        Log.Erro($"Cleanup of command {cmd.GetType()} failed: ex", nameof(CommandLine));
                    }
                }
                stopServer.CleanUpCompleted = true;
            };
            handlers.AddRange(cmdlist);
        }

        private static StopServerCmd stopServer;
        public static List<ICommandHandler> handlers = new();
        public static void ShowHelps()
        {
            foreach (var handler in handlers)
            {
                Log.Info($"Command '{handler.CommandName}': {handler.Description}", nameof(CommandLine));
                string[] help = handler.Usage.Split(Environment.NewLine);
                foreach (var line in help) Log.Info(line, nameof(CommandLine));
                Log.Info("", nameof(CommandLine));
            }
        }

        private static void RefuseCommand(string commandName)
        {
            Log.Info($"Invalid command: {commandName}.");
        }

        public static async Task Start()
        {
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
                    string[] args = cmd.Substring(Math.Min(cmd.Length, sepindex + 1)).Split(' ');
                    bool handled = false;
                    foreach (var cmdhandle in handlers)
                    {
                        if (cmdhandle.CommandName == commandName)
                        {
                            handled = true;
                            try
                            {
                                await cmdhandle.HandleAsync(args);
                            }
                            catch (Exception ex)
                            {
                                Log.Erro(ex.ToString(), nameof(CommandLine));
                                Log.Info($"Encountered error when handling command {commandName}. Please check your input.", nameof(CommandLine));
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