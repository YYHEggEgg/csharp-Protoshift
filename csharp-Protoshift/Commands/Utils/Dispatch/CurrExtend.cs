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
            return (OldProtos.QueryCurrRegionHttpRsp.Parser.ParseFrom(
                        CPri.RsaDecrypt(data, RSAEncryptionPadding.Pkcs1)),
                    SPub.VerifyData(data, Convert.FromBase64String(sign),
                        HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
        }
    }
}