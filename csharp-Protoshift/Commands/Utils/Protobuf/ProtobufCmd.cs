using CommandLine;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands.Protobuf
{
#pragma warning disable CS8618
    [Verb("start", true, HelpText = "start the protobuf command with certain options.")]
    internal class ProtobufStartConfig
    {
        [Option("old", Required = false, Default = false, HelpText = "Whether to use the Old Protocol.")]
        public bool IsOldProtos { get; set; }
        [Option("new", Required = false, Default = false, HelpText = "Whether to use the new Protocol.")]
        public bool IsNewProtos { get; set; }
        [Value(0, Required = true, HelpText = "The target proto name.")]
        public string Protoname { get; set; }
    }

    [Verb("target", false, HelpText = "set the default protocol command start using.")]
    internal class ProtobufTargetConfig
    {
        [Value(0, Required = true)]
        public string OldOrNew { get; set; }
    }
#pragma warning restore CS8618

    internal class ProtobufCmd : CommandHandlerBase
    {
        public override string CommandName => "protobuf";

        public override string Description => "Do some protobuf operations.";

        public override string Usage => $"protobuf [command] <options> {Environment.NewLine}" +
            $"  command start (default): start the protobuf command with certain options. {Environment.NewLine}" +
            $"    protobuf [--old/--new] <proto_name> {Environment.NewLine}" +
            $" {Environment.NewLine}" +
            $"  command target: set the default protocol command start using. {Environment.NewLine}" +
            $"    protobuf target [old/new]{Environment.NewLine}" +
            $" {Environment.NewLine}" +
            $"The old protos refer to the protocol server is using, {Environment.NewLine}" +
            $"and the new protos refer to the one client is using, {Environment.NewLine}" +
            $"so usually the client uses the newer one on release time.";

        /// <summary>
        /// null = no target, true = new, false = old
        /// </summary>
        private bool? targetingoldornew = null;

        public override void CleanUp() { }

        public override async Task HandleAsync(string argList)
        {
            var args = ParseAsArgs(argList);
            await DefaultCommandsParser.ParseArguments<ProtobufStartConfig, ProtobufTargetConfig>(args)
                .MapResult(
                    async (ProtobufStartConfig o) => await HandleStartAsync(o),
                    async (ProtobufTargetConfig o) => await HandleTargetAsync(o),
                    error =>
                    {
                        OutputInvalidUsage(error);
                        ShowUsage();
                        return Task.CompletedTask;
                    });
        }

        private Task HandleTargetAsync(ProtobufTargetConfig opt)
        {
            if (opt.OldOrNew.ToLower() == "old")
            {
                targetingoldornew = false;
                _logger.LogInfo("Successfully set the default target protocol to OldProtos.");
            }
            else if (opt.OldOrNew.ToLower() == "new")
            {
                targetingoldornew = true;
                _logger.LogInfo("Successfully set the default target protocol to NewProtos.");
            }
            else
            {
                _logger.LogErro("Unrecognized target protocol! Please give either 'old' or 'new'.");
            }
            return Task.CompletedTask;
        }

        private async Task<EasyInputResult> GetUserInput()
        {
            _logger.LogInfo("Well done! The proto exists.\n");

            _logger.LogInfo("Please type base64 encoded, HEX or JSON protobuf bin data (auto detect):");
            _logger.LogInfo("You can also paste json data to get its serialized data.");
            _logger.LogInfo(EasyInput.MultipleInputNotice);

            _logger.LogInfo("\nIf you're using Windows Terminal, press <color=Yellow>Ctrl+Alt+V</color> " +
                $"to paste any text (especially formatted json data).");

            var raw_text = await ConsoleWrapper.ReadLineAsync(false);
            var res = EasyInput.TryPreProcess(raw_text);
            if (res.InputType == EasyInputType.IdentifyFailure)
            {
                throw new InvalidOperationException("Input type undetected. " +
                    $"Please check your data or try to strictly define the input type. ");
            }
            return res;
        }

        private async Task HandleStartAsync(ProtobufStartConfig opt)
        {
            bool? targetprotocol_tmp = null;
            #region Assert target protocol
            if (opt.IsOldProtos && opt.IsNewProtos)
            {
                _logger.LogErro("Please select only one target protocol!");
                return;
            }
            else if (!opt.IsOldProtos && !opt.IsNewProtos)
            {
                if (targetingoldornew != null) targetprotocol_tmp = targetingoldornew;
                else
                {
                    _logger.LogErro("Please select a target protocol or set a default " +
                        "one by command 'util protobuf target <old|new>'!");
                    return;
                }
            }
            else targetprotocol_tmp = opt.IsNewProtos;
            #endregion
            bool targetprotocolIsNew = (bool)targetprotocol_tmp;
            string target_namespace = $"{(targetprotocolIsNew ? "New" : "Old")}Protos";
            _logger.LogInfo($"Got target protocol: {target_namespace}");

            string? res = null;

            if (targetprotocolIsNew)
            {
                if (!NewProtos.QueryJsonSerializer.TryGetJsonSerializer(opt.Protoname, out var serializer))
                {
                    _logger.LogErro("Proto type not found!");
                    return;
                }
                var identify_res = await GetUserInput();
                if (identify_res.InputType == EasyInputType.Json)
                {
                    res = Convert.ToBase64String(serializer.SerializeFromJson(identify_res.ProcessedString ?? string.Empty));
                    _logger.LogInfo($"Serialized Base64:{Environment.NewLine}{res}");
                }
                else
                {
                    var bytes_protobuf = identify_res.ToByteArray();
                    res = Tools.SortJsonSingleLine(serializer.DeserializeToJson(bytes_protobuf));
                    _logger.LogInfo($"Converted JSON:{Environment.NewLine}{res}");
                }
            }
            else
            {
                if (!OldProtos.QueryJsonSerializer.TryGetJsonSerializer(opt.Protoname, out var serializer))
                {
                    _logger.LogErro("Proto type not found!");
                    return;
                }
                var identify_res = await GetUserInput();
                if (identify_res.InputType == EasyInputType.Json)
                {
                    res = Convert.ToBase64String(serializer.SerializeFromJson(identify_res.ProcessedString ?? string.Empty));
                    _logger.LogInfo($"Serialized Base64:{Environment.NewLine}{res}");
                }
                else
                {
                    var bytes_protobuf = identify_res.ToByteArray();
                    res = Tools.SortJsonSingleLine(serializer.DeserializeToJson(bytes_protobuf));
                    _logger.LogInfo($"Converted JSON:{Environment.NewLine}{res}");
                }
            }

            if (res == null)
            {
                _logger.LogWarn("Serialization/Deserialization probably failed!");
            }
            else
            {
                await Tools.SetClipBoardAsync(res);
            }
        }
    }
}