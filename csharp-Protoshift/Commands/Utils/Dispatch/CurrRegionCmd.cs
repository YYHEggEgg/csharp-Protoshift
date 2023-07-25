using csharp_Protoshift.Commands.Dispatch;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using TextCopy;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class CurrRegionCmd : ICommandHandler
    {
        public string CommandName => "dcurr";

        public string Description => "Decrypt curr regions with Client Private keys.";

        public string Usage => $"dcurr <key_id> <curr_file>{Environment.NewLine}" +
            $"Due to some reasons, you should place the curr json into a file and give the file path here.";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public async Task HandleAsync(string[] args)
        {
            uint key_id = uint.Parse(args[0]);
            var curr = CurrExtend.GetCurrFromJson(
                await File.ReadAllTextAsync(args[1]), Resources.CPri[key_id]);
            var res = JsonFormatter.Default.Format(curr);
            Log.Info($"Decrypted json content: \n{res}", nameof(CurrRegionCmd));
            await ClipboardService.SetTextAsync(res);
            Log.Info("Result copied to clipboard!", nameof(CurrRegionCmd));
        }
    }
}
