using csharp_Protoshift.GameSession;
using csharp_Protoshift.resLoader;
using System.Buffers.Binary;
using System.Security.Cryptography;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class MT19937Cmd : CommandHandlerBase
    {
        public override string CommandName => "mt19937";

        public override string Description => "Generate 4096-byte XOR key with a certain UInt64 seed, " +
            "or with RSA param clientRandkey and serverRandKey.";

        public override string Usage => $"mt19937 [options] [params]{Environment.NewLine}" +
            $"mt19937 <ulong_seed>{Environment.NewLine}" +
            $"mt19937 --hex <ulong_seed_hex>{Environment.NewLine}" +
            $"mt19937 --rsa <RSA_Encrypted_clientRandKey_base64/hex> <RSA_Encrypted_serverRandKey_base64/hex> <key_id>";

        public override async Task HandleAsync(string argList)
        {
            ulong seed;
            var args = ParseAsArgs(argList);
            if (args.Count == 0)
            {
                Log.Erro($"Too few arguments! Usage: {Usage}", nameof(MT19937Cmd));
                return;
            }
            else if (!ulong.TryParse(args[0], out seed))
            {
                if (args[0] == "--rsa")
                {
                    uint key_id = Convert.ToUInt32(args[3]);
                    var server_rand_key = Resources.CPri[key_id].RsaDecrypt(
                        EasyInput.ToByteArray(EasyInput.TryPreProcess(args[2])), RSAEncryptionPadding.Pkcs1);
                    var client_rand_key = Resources.SPri[key_id].RsaDecrypt(
                        EasyInput.ToByteArray(EasyInput.TryPreProcess(args[1])), RSAEncryptionPadding.Pkcs1);
                    client_rand_key = client_rand_key.Fill0(8);
                    server_rand_key = server_rand_key.Fill0(8);
                    seed = client_rand_key.GetUInt64(0) ^ server_rand_key.GetUInt64(0);
                }
                else if (args[0] == "--hex")
                {
                    seed = BinaryPrimitives.ReadUInt64BigEndian(Convert.FromHexString(
                        string.Concat(args).AsSpan(args[0].Length)));
                }
                else
                {
                    Log.Erro($"Unknown option {args[0]}! Usage: {Usage}", nameof(MT19937Cmd));
                    return;
                }
            }
            Log.Info($"MT64 result:{Environment.NewLine}-----BEGIN HEX 4096 Xor Key-----{Environment.NewLine}" +
                Convert.ToHexString(HandlerSession.Generate4096KeyByMT19937(seed)) +
                $"{Environment.NewLine}-----END HEX 4096 Xor Key-----", nameof(MT19937Cmd));
            await Task.CompletedTask;
        }
    }
}