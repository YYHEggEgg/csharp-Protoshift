using csharp_Protoshift.GameSession;
using csharp_Protoshift.Configuration;

namespace csharp_Protoshift.Commands
{
    internal class StopServerCmd : CommandHandlerBase
    {
        public override string CommandName => "stop";

        public override string Description => $"Invoke to stop the server.";

        public override string Usage => "stop";

        public override void CleanUp() { }

        public override async Task HandleAsync(string argList)
        {
            lock (closing_lck)
            {
                if (_closingInovked)
                {
                    _logger.LogErro("Server is closing and can't override cleanup!");
                    return;
                }
                else _closingInovked = true;
            }
            ServerClosing?.Invoke();
            GameSessionDispatch.CloseServer();
            if (!CleanUpCompleted)
            {
                _logger.LogInfo($"Waiting for cmds cleanup...");
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