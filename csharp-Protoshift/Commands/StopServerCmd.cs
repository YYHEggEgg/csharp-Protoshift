using csharp_Protoshift.GameSession;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.Commands
{
    internal class StopServerCmd : ICommandHandler
    {
        public string CommandName => "stop";

        public string Description => $"Invoke to stop the server and SAVE ENTIRE PACKET RECORDS. {Environment.NewLine}" +
            $"DON'T USE Ctrl+C! Not supported now.";

        public string Usage => "stop";

        public async Task HandleAsync(string[] args)
        {
            GameSessionDispatch.CloseServer();
            // File.Move("logs/latest.packet.log", $"logs/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.packet.log");
            Environment.Exit(0);

            await Task.CompletedTask;
        }
    }
}
