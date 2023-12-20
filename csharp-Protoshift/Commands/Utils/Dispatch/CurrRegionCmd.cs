using csharp_Protoshift.Commands.Dispatch;
using csharp_Protoshift.resLoader;
using Google.Protobuf;
using Newtonsoft.Json;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class DecryptCurrRegionCmd : CommandHandlerBase
    {
        public override string CommandName => "dcurr";

        public override string Description => "Decrypt query_cur_region content and verify it (to ensure it avaliable in anime game).";

        public override string Usage => $"dcurr <key_id> <curr_json>{Environment.NewLine}" +
            $"Decrypt and verify query_cur_region content, by the key from resources. {Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"Notice: <color=Yellow>If you're using Windows Terminal, press Ctrl+Alt+V to paste data with multiple lines (especially json data).</color>";

        public override async Task HandleAsync(string argList)
        {
            var args = argList.Split(' ');
            uint key_id = uint.Parse(args[0]);
            var read = EasyInput.TryPreProcess(args, 1);
            if (read.InputType != EasyInputType.Json)
            {
                _logger.LogErro($"Input param 2 should be a valid json!");
            }
            (OldProtos.QueryCurrRegionHttpRsp currres, bool? verificationOK) = (new(), null);
            try
            {
                (currres, verificationOK) = CurrExtend.GetCurrFromJson(read.ProcessedString,
                    Resources.CPri[key_id], Resources.SPub[key_id]);
            }
            catch (JsonReaderException jex)
            {
                _logger.LogErro($"Decryption failed: {jex}");
                _logger.LogWarn($"It may because you provided false query_cur_region json.");
                return;
            }
            catch (KeyNotFoundException kex)
            {
                _logger.LogErro($"Decryption failed: {kex}");
                _logger.LogWarn($"It may because you provided false query_cur_region json.");
                return;
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex, $"Decryption failed. ");
                _logger.LogWarn($"It may because the RSA key doesn't match " +
                    $"or you provided false query_cur_region json.");
                return;
            }
            var res = JsonFormatter.Default.Format(currres);
            if (string.IsNullOrWhiteSpace(res)) res = "<empty content or json/protobuf format failure>";
            _logger.LogInfo($"Decrypted json content: \n{res}");
            if (verificationOK == true)
            {
                _logger.LogInfo($"Sign Verified OK!");
            }
            else if (verificationOK == false)
            {
                _logger.LogWarn($"RSA Verification failed. " +
                    $"You may check whether a correct RSA key is configured.");
            }
            await Tools.SetClipBoardAsync(res);
            var unksize = Tools.GetUnknownFieldsSize(currres, typeof(OldProtos.QueryCurrRegionHttpRsp));
            if (unksize != 0)
            {
                _logger.LogWarn($"Message has unknown fields that aren't defined in your proto: {unksize}/{currres.CalculateSize()} bytes. Please go to protobuf decode-raw tools for more information.");
            }
        }
    }

    internal class GenerateCurrRegionCmd : CommandHandlerBase
    {
        public override string CommandName => "gencur";

        public override string Description => "Generate query_cur_region content and signature.";

        public override string Usage => $"gencur <key_id> <protobuf_content>{Environment.NewLine}" +
            $"Encrypt and sign query_cur_region content, by the key from resources.";

        public override async Task HandleAsync(string argList)
        {
            var args = argList.Split(' ');
            uint key_id = uint.Parse(args[0]);
            var read = EasyInput.TryPreProcess(args, 1);
            if (read.InputType != EasyInputType.Json)
            {
                _logger.LogErro($"Input param 2 should be a valid json!");
            }
            OldProtos.QueryCurrRegionHttpRsp curr = new();
            try
            {
                curr = OldProtos.QueryCurrRegionHttpRsp.Parser.ParseJson(read.ProcessedString);
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex,
                    $"Protobuf serialization failed. ");
                _logger.LogWarn($"It may because the json isn't valid." +
                    $"It's recommended to modify based on the result" +
                    $"from json protobuf from 'util dcurr' command.");
                return;
            }
            try
            {
                var res = curr.GetCurrJson(Resources.CPri[key_id], Resources.SPri[key_id]);
                _logger.LogInfo($"Result: \n{res}");
                await Tools.SetClipBoardAsync(res);
            }
            catch (Exception ex)
            {
                LogTrace.ErroTrace(ex,
                    $"RSA encryption failed. ");
                _logger.LogWarn($"It may because you don't provide match key" +
                    $"in resources/ClientPri and resources/ServerPri.");
                return;
            }
        }
    }
}
