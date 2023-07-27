﻿using csharp_Protoshift.Commands.Dispatch;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using Newtonsoft.Json;
using Org.BouncyCastle.Utilities.Encoders;
using TextCopy;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class DecryptCurrRegionCmd : ICommandHandler
    {
        public string CommandName => "dcurr";

        public string Description => "Decrypt query_cur_region content and verify it (to ensure it avaliable in anime game).";

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
            (OldProtos.QueryCurrRegionHttpRsp currres, bool? verificationOK) = (new(), null);
            try
            {
                (currres, verificationOK) = CurrExtend.GetCurrFromJson(read.ProcessedString,
                    Resources.CPri[key_id], Resources.SPri[key_id]);
            }
            catch (JsonReaderException jex)
            {
                Log.Erro($"Decryption failed: {jex}", nameof(DecryptCurrRegionCmd));
                Log.Warn($"It may because you provided false query_cur_region json.", nameof(DecryptCurrRegionCmd));
                return;
            }
            catch (KeyNotFoundException kex)
            {
                Log.Erro($"Decryption failed: {kex}", nameof(DecryptCurrRegionCmd));
                Log.Warn($"It may because you provided false query_cur_region json.", nameof(DecryptCurrRegionCmd));
                return;
            }
            catch (Exception ex)
            {
                Log.Erro($"Decryption failed: {ex}", nameof(DecryptCurrRegionCmd));
                Log.Warn($"It may because the RSA key doesn't match " +
                    $"or you provided false query_cur_region json.", nameof(DecryptCurrRegionCmd));
                return;
            }
            var res = JsonFormatter.Default.Format(currres);
            if (string.IsNullOrWhiteSpace(res)) res = "<empty content or json/protobuf format failure>";
            Log.Info($"Decrypted json content: \n{res}", nameof(DecryptCurrRegionCmd));
            if (verificationOK == true)
            {
                Log.Info($"Sign Verified OK!", nameof(DecryptCurrRegionCmd));
            }
            else if (verificationOK == false)
            {
                Log.Warn($"RSA Verification failed. " +
                    $"You may check whether a correct RSA key is configured.", nameof(DecryptCurrRegionCmd));
            }
            await ClipboardService.SetTextAsync(res);
            Log.Info("Result copied to clipboard!", nameof(DecryptCurrRegionCmd));
        }
    }

    internal class GenerateCurrRegionCmd : ICommandHandler
    {
        public string CommandName => "gencur";

        public string Description => "Generate query_cur_region content and signature.";

        public string Usage => $"gencur <key_id> <protobuf_content>{Environment.NewLine}" +
            $"Encrypt and sign query_cur_region content, by the key from resources.";

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
                Log.Erro($"Input param 2 should be a valid json!", nameof(GenerateCurrRegionCmd));
            }
            OldProtos.QueryCurrRegionHttpRsp curr = new();
            try
            {
                curr = OldProtos.QueryCurrRegionHttpRsp.Parser.ParseJson(read.ProcessedString);
            }
            catch (Exception ex)
            {
                Log.Erro($"Protobuf serialization failed: {ex}", nameof(GenerateCurrRegionCmd));
                Log.Warn($"It may because the json isn't valid." +
                    $"It's recommended to modify based on the result" +
                    $"from json protobuf from 'util dcurr' command.", nameof(GenerateCurrRegionCmd));
                return;
            }
            try
            {
                var res = curr.GetCurrJson(Resources.CPri[key_id], Resources.SPri[key_id]);
                Log.Info($"Result: \n{res}", nameof(GenerateCurrRegionCmd));
                await ClipboardService.SetTextAsync(res);
                Log.Info("Result copied to clipboard!", nameof(GenerateCurrRegionCmd));
            }
            catch (Exception ex)
            {
                Log.Erro($"RSA encryption failed: {ex}", nameof(GenerateCurrRegionCmd));
                Log.Warn($"It may because you don't provide match key" +
                    $"in resources/ClientPri and resources/ServerPri.", nameof(GenerateCurrRegionCmd));
                return;
            }
        }
    }
}