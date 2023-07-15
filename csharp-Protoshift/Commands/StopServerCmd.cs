using csharp_Protoshift.GameSession;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class StopServerCmd : ICommandHandler
    {
        public string CommandName => "stop";

        public string Description => $"Invoke to stop the server and SAVE ENTIRE PACKET RECORDS. {Environment.NewLine}" +
            $"DON'T USE Ctrl+C! Not supported now.";

        public string Usage => "stop";

        public void CleanUp() { }

        public async Task HandleAsync(string[] args)
        {
            lock (closing_lck)
            {
                if (_closingInovked)
                {
                    Log.Erro("Server is closing and can't override cleanup!", nameof(StopServerCmd));
                    return;
                }
                else _closingInovked = true;
            }
            ServerClosing?.Invoke();
            GameSessionDispatch.CloseServer();
            if (!CleanUpCompleted)
            {
                Log.Info($"Waiting for cmds cleanup...", nameof(StopServerCmd));
                while (!CleanUpCompleted) await Task.Delay(1000);
            }
            Environment.Exit(0);
        }

        private bool _closingInovked = false;
        private object closing_lck = new object();
        public event Action? ServerClosing;
        public bool CleanUpCompleted { get; set; } = false;
    }
}
