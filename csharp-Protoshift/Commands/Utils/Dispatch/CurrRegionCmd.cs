using csharp_Protoshift.Commands.Dispatch;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using TextCopy;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class DecryptCurrRegionCmd : ICommandHandler
    {
        public string CommandName => "dcurr";

        public string Description => "Decrypt curr regions with Client Private keys.";

        public string Usage => $"dcurr <key_id> <curr_json>{Environment.NewLine}" +
            $"Decrypt and verify query_cur_region content, by the key from resources.";

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public async Task HandleAsync(string[] args)
        {
            uint key_id = uint.Parse(args[0]);
            var read = EasyInput.TryPreProcess(args, 1);
            if (read.InputType != EasyInputType.Json)
            {
                Log.Erro($"Input param 2 should be a valid json!", nameof(DecryptCurrRegionCmd));
            }
            var curr = CurrExtend.GetCurrFromJson(read.ProcessedString, 
                Resources.CPri[key_id], Resources.SPri[key_id]);
            var res = JsonFormatter.Default.Format(curr.res);
            if (string.IsNullOrWhiteSpace(res)) res = "<empty content or json/protobuf format failure>";
            Log.Info($"Decrypted json content: \n{res}", nameof(DecryptCurrRegionCmd));
            if (curr.verificationOK == true)
            {
                Log.Info($"Sign Verified OK!", nameof(DecryptCurrRegionCmd));
            }
            else if (curr.verificationOK == false)
            {
                Log.Warn($"RSA Verification failed. " +
                    $"You may check whether a correct RSA key is configured.", nameof(DecryptCurrRegionCmd));
            }
            await ClipboardService.SetTextAsync(res);
            Log.Info("Result copied to clipboard!", nameof(DecryptCurrRegionCmd));
        }
    }
}
