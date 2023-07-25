using Google.Protobuf;
using System.Security.Cryptography;
using System.Text.Json;
using XC.RSAUtil;

namespace csharp_Protoshift.Commands.Dispatch
{
    public class CurrExtend
    {
        public static (OldProtos.QueryCurrRegionHttpRsp res, bool? verificationOK)
            GetCurrFromJson(string? json, RSAUtilBase CPri, RSAUtilBase SPub)
        {
            if (json == null) return (new OldProtos.QueryCurrRegionHttpRsp(), null);
            var doc = JsonDocument.Parse(json).RootElement;
            /* Curr Schema:
             * {
             *   "content": <base64string(RSA encrypted)>,
             *   "sign": <Signature-content(Algorithm: SHA256withRSA)>
             * }
             */
            string? content = doc.GetProperty("content").GetString();
            string? sign = doc.GetProperty("sign").GetString();
            if (content == null || sign == null)
                return (new OldProtos.QueryCurrRegionHttpRsp(), null);
            byte[] data = Convert.FromBase64String(content);
            byte[] res = CPri.RsaDecrypt(data, RSAEncryptionPadding.Pkcs1);
            return (OldProtos.QueryCurrRegionHttpRsp.Parser.ParseFrom(res),
                    SPub.VerifyData(res, Convert.FromBase64String(sign),
                        HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
        }
    }

    public static class QueryCurrRegionHttpRspExtensions
    {
        /// <summary>
        /// Get the RSA encrypted format of <see cref="OldProtos.QueryCurrRegionHttpRsp"/>.
        /// </summary>
        /// <param name="rsa_encrypt">RSA instance used for encrypting content, or S1Pub, client_public_key</param>
        /// <param name="mainDispatchhost">RSA instance used for creating signature, or S2Pri, server_private_key</param>
        /// <returns>The json format cur data. Notice that '/' is converted to \u0022. To avoid this, use GetCurrJsonForHttp() instead.</returns>
        public static string GetCurrJson(
            this OldProtos.QueryCurrRegionHttpRsp curr, RSAUtilBase rsa_encrypt, RSAUtilBase rsa_sign)
        {
            var curcontent = curr.ToByteArray();
            return $"{{\"content\":\"{Convert.ToBase64String(rsa_encrypt.RsaEncrypt(curcontent, RSAEncryptionPadding.Pkcs1))}\"," +
                $"\"sign\":\"{Convert.ToBase64String(rsa_sign.SignData(curcontent, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1))}\"}}";
        }
    }
}