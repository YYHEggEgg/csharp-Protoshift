namespace csharp_Protoshift.Commands.Utils
{
    internal class ConvertCmd : CommandHandlerBase
    {
        public override string CommandName => "convert";

        public override string Description => "Automatically convert data between base64 and HEX format.";

        public override string Usage => $"convert <base64_data/hex_data>{Environment.NewLine}" +
            EasyInput.MultipleInputNotice +
            $"{Environment.NewLine}" +
            $"{Environment.NewLine}" +
            $"Notice: <color=Yellow>If you're using Windows Terminal, press Ctrl+Alt+V to paste data with multiple lines.</color>";

        public override async Task HandleAsync(string argList)
        {
            var args = ParseAsArgs(argList);
            EasyInputResult res = EasyInput.TryPreProcess(args);
            byte[] bytes;
            switch (res.InputType)
            {
                case EasyInputType.Base64:
                    bytes = res.ToByteArray();
                    _logger.LogInfo($"Converted to HEX format, handled {bytes.Length} bytes.");
                    await Tools.SetClipBoardAsync(Convert.ToHexString(bytes));
                    break;
                case EasyInputType.Hex:
                    bytes = res.ToByteArray();
                    _logger.LogInfo($"Converted to Base64 format, handled {bytes.Length} bytes.");
                    await Tools.SetClipBoardAsync(Convert.ToBase64String(bytes));
                    break;
                default:
                    _logger.LogErro($"Input type is not supported!");
                    break;
            }
        }
    }
}
