using CommandLine;
using TextCopy;
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
        private LoggerChannel log = Log.GetChannel(nameof(ProtobufCmd));

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
                        log.LogErro("Unrecognized command or args detected. Please check your input.");
                        ShowUsage();
                        return Task.CompletedTask;
                    });
        }

        private Task HandleTargetAsync(ProtobufTargetConfig opt)
        {
            if (opt.OldOrNew.ToLower() == "old")
            {
                targetingoldornew = false;
                log.LogInfo("Successfully set the default target protocol to OldProtos.");
            }
            else if (opt.OldOrNew.ToLower() == "new")
            {
                targetingoldornew = true;
                log.LogInfo("Successfully set the default target protocol to NewProtos.");
            }
            else
            {
                log.LogErro("Unrecognized target protocol! Please give either 'old' or 'new'.");
            }
            return Task.CompletedTask;
        }

        private async Task<EasyInputResult> GetUserInput()
        {
            log.LogInfo("Well done! The proto exists.\n");

            log.LogInfo("Please type base64 encoded, HEX or JSON protobuf bin data (auto detect):");
            log.LogInfo("You can also paste json data to get its serialized data.");
            log.LogInfo(EasyInput.MultipleInputNotice);

            log.LogInfo("\nIf you're using Windows Terminal, press <color=Yellow>Ctrl+Alt+V</color> " +
                $"to paste any text (especially formatted json data).");

            var raw_text = await ConsoleWrapper.ReadLineAsync();
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
                log.LogErro("Please select only one target protocol!");
                return;
            }
            else if (!opt.IsOldProtos && !opt.IsNewProtos)
            {
                if (targetingoldornew != null) targetprotocol_tmp = targetingoldornew;
                else
                {
                    log.LogErro("Please select a target protocol or set a default " +
                        "one by command 'util protobuf target <old|new>'!");
                    return;
                }
            }
            else targetprotocol_tmp = opt.IsNewProtos;
            #endregion
            bool targetprotocolIsNew = (bool)targetprotocol_tmp;
            string target_namespace = $"{(targetprotocolIsNew ? "New" : "Old")}Protos";
            log.LogInfo($"Got target protocol: {target_namespace}");

            string? res = null;

            if (targetprotocolIsNew)
            {
                if (!NewProtos.QueryJsonSerializer.TryGetJsonSerializer(opt.Protoname, out var serializer))
                {
                    log.LogErro("Proto type not found!");
                    return;
                }
                var identify_res = await GetUserInput();
                if (identify_res.InputType == EasyInputType.Json)
                {
                    res = Convert.ToBase64String(serializer.SerializeFromJson(identify_res.ProcessedString ?? string.Empty));
                    log.LogInfo($"Serialized Base64:{Environment.NewLine}{res}");
                }
                else
                {
                    var bytes_protobuf = identify_res.ToByteArray();
                    res = serializer.DeserializeToJson(bytes_protobuf);
                    log.LogInfo($"Converted JSON:{Environment.NewLine}{res}");
                }
            }
            else
            {
                if (!OldProtos.QueryJsonSerializer.TryGetJsonSerializer(opt.Protoname, out var serializer))
                {
                    log.LogErro("Proto type not found!");
                    return;
                }
                var identify_res = await GetUserInput();
                if (identify_res.InputType == EasyInputType.Json)
                {
                    res = Convert.ToBase64String(serializer.SerializeFromJson(identify_res.ProcessedString ?? string.Empty));
                    log.LogInfo($"Serialized Base64:{Environment.NewLine}{res}");
                }
                else
                {
                    var bytes_protobuf = identify_res.ToByteArray();
                    res = serializer.DeserializeToJson(bytes_protobuf);
                    log.LogInfo($"Converted JSON:{Environment.NewLine}{res}");
                }
            }

            if (res == null)
            {
                log.LogWarn("Serialization/Deserialization probably failed!");
            }
            else
            {
                await Tools.SetClipBoardAsync(res);
            }
        }
    }
}