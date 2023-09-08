using csharp_Protoshift.GameSession;
using csharp_Protoshift.Configuration;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class StopServerCmd : CommandHandlerBase
    {
        public override string CommandName => "stop";

        public override string Description => $"Invoke to stop the server and SAVE ENTIRE PACKET RECORDS. {Environment.NewLine}" +
            $"DON'T USE Ctrl+C! Not supported now.";

        public override string Usage => "stop";

        public override void CleanUp() { }

        public override async Task HandleAsync(string argList)
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
            Config.FlushTo("config.json");
            Environment.Exit(0);
        }

        private bool _closingInovked = false;
        private object closing_lck = new object();
        public event Action? ServerClosing;
        public bool CleanUpCompleted { get; set; } = false;
    }
}