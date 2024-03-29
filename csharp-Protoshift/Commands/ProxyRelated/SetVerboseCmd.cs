#if !PROXY_ONLY_SERVER

using CommandLine;
using csharp_Protoshift.GameSession;

namespace csharp_Protoshift.Commands
{
    internal class SetVerboseOption : TargetOptionBase
    {
        [Value(0, Required = true, HelpText = "Whether to show packet info of this session.")]
        public bool Verbose { get; set; }
    }

    internal class SetVerboseCmd : StandardCommandHandler<SetVerboseOption>
    {
        public override string CommandName => "setverbose";

        public override string Description => "Set a specified connection verbose mode.";

        public override string Usage => $"setverbose -c <conv_id> <true/false>{Environment.NewLine}" +
            $"If true, then a summary will be output to the console when every packet passing by.";

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public override async Task HandleAsync(SetVerboseOption opt)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            var session = opt.GetSession(_logger);
            if (session == null) return;
            session.Verbose = opt.Verbose;
            _logger.LogInfo($"Succeed set Conv:{opt.Conv} Verbose Mode to {opt.Verbose}.");
        }
    }
}
#endif
