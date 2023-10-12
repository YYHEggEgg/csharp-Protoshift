using CommandLine;

namespace csharp_Protoshift.Commands
{
    internal abstract class TargetOptionAbstract
    {
        public abstract uint Uid { get; set; }
        public abstract uint Conv { get; set; }
    }

    internal class TargetOptionBase : TargetOptionAbstract
    {
        [Value(0, Required = false, Default = 0u, HelpText = "The target uid of the command.")]
        public override uint Uid { get; set; }
        [Option('c', "conv", Required = false, Default = 0u, HelpText = "The target conv of the command.")]
        public override uint Conv { get; set; }
    }

    internal class StrictTargetOptionBase : TargetOptionAbstract
    {
        [Option('u', "uid", Required = false, Default = 0u, HelpText = "The target uid of the command.")]
        public override uint Uid { get; set; }
        [Option('c', "conv", Required = false, Default = 0u, HelpText = "The target conv of the command.")]
        public override uint Conv { get; set; }
    }
}