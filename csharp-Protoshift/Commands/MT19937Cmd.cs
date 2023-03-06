using csharp_Protoshift.GameSession;
using csharp_Protoshift.resLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YSFreedom.Common.Util;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal class MT19937Cmd : ICommandHandler
    {
        public string CommandName => "MT19937";

        public string Description => "Generate XOR key with clientRandkey and serverRandKey.";

        public string Usage =>
            "MT19937 <RSA_Encrypted_clientRandKey_base64> <RSA_Encrypted_serverRandKey_base64> <key_id>";

        public async Task HandleAsync(string[] args)
        {
            uint key_id = Convert.ToUInt32(args[2]);
            var server_rand_key = Resources.CPri[key_id].RsaDecrypt(
                Convert.FromBase64String(args[1]), RSAEncryptionPadding.Pkcs1);
            var client_rand_key = Resources.SPri[key_id].RsaDecrypt(
                Convert.FromBase64String(args[0]), RSAEncryptionPadding.Pkcs1);
            client_rand_key = client_rand_key.Fill0(8);
            server_rand_key = server_rand_key.Fill0(8);
            ulong seed = client_rand_key.GetUInt64(0) ^ server_rand_key.GetUInt64(0);
            Log.Info($"{Environment.NewLine}-----BEGIN HEX 4096 Xor Key-----{Environment.NewLine}" +
                Convert.ToHexString(HandlerSession.Generate4096KeyByMT19937(seed)) +
                $"{Environment.NewLine}-----END HEX 4096 Xor Key-----", "MT19937Cmd");
        }
    }
}
