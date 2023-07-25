using AssetLib.Formats;
using TextCopy;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class Ec2bCmd : ICommandHandler
    {
        public string CommandName => "ec2b";

        public string Description => "Make operations on dispatch secret_key/secret_seed.";

        public string Usage => $"ec2b get_key <content_bindata(base64/hex)>{Environment.NewLine}" +
            EasyInput.MultipleInputNotice;

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public async Task HandleAsync(string[] args)
        {
            if (args.Length <= 1)
            {
                Log.Erro($"Too few params! Usage: {Usage}", nameof(Ec2bCmd));
                return;
            }
            switch (args[0])
            {
                case "get_key":
                    var read = EasyInput.TryPreProcess(args, 1);
                    if (read.InputType != EasyInputType.Base64 
                        && read.InputType != EasyInputType.Hex)
                    {
                        Log.Erro($"The input type isn't supported!", nameof(Ec2bCmd));
                        return;
                    }
                    var hexkey = Convert.ToHexString(Ec2b.Decrypt(EasyInput.ToByteArray(read)));
                    Log.Info(hexkey, nameof(Ec2bCmd));
                    await ClipboardService.SetTextAsync(hexkey);
                    Log.Info("Result copied to clipboard!", nameof(Ec2bCmd));
                    break;
                default:
                    Log.Erro($"Usage: {Usage}", nameof(Ec2bCmd));
                    break;
            }
        }
    }
}
