﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextCopy;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Utils
{
    internal class ConvertCmd : ICommandHandler
    {
        public string CommandName => "convert";

        public string Description => "Automatically convert data between base64 and HEX format.";

        public string Usage => $"convert <base64_data/hex_data>{Environment.NewLine}" +
            EasyInput.MultipleInputNotice;

        public void CleanUp()
        {
            throw new NotImplementedException();
        }

        public async Task HandleAsync(string[] args)
        {
            EasyInputResult res = EasyInput.TryPreProcess(args);
            byte[] bytes;
            switch (res.InputType)
            {
                case EasyInputType.Base64:
                    bytes = EasyInput.ToByteArray(res);
                    Log.Info($"Converted to HEX format, handled {bytes.Length} bytes.", nameof(ConvertCmd));
                    await ClipboardService.SetTextAsync(Convert.ToHexString(bytes));
                    Log.Info("Result copied to clipboard!", nameof(ConvertCmd));
                    break;
                case EasyInputType.Hex:
                    bytes = EasyInput.ToByteArray(res);
                    Log.Info($"Converted to Base64 format, handled {bytes.Length} bytes.", nameof(ConvertCmd));
                    await ClipboardService.SetTextAsync(Convert.ToBase64String(bytes));
                    Log.Info("Result copied to clipboard!", nameof(ConvertCmd));
                    break;
                default:
                    Log.Erro($"Input type is not supported!", nameof(ConvertCmd));
                    break;
            }
        }
    }
}