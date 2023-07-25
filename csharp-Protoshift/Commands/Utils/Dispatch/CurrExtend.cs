using System.Security.Cryptography;
using System.Text.Json;
using XC.RSAUtil;

namespace csharp_Protoshift.Commands.Dispatch
{
    public class CurrExtend
    {
        public static OldProtos.QueryCurrRegionHttpRsp GetCurrFromJson(
            string json, RSAUtilBase op)
        {
            var doc = JsonDocument.Parse(json).RootElement;
            /* Curr Schema:
             * {
             *   "content": <base64string(RSA encrypted)>,
             *   "sign": <Signature-content(Algorithm: SHA256withRSA)>
             * }
             */
            string? content = doc.GetProperty("content").GetString();
            if (content == null) return new OldProtos.QueryCurrRegionHttpRsp();
            return OldProtos.QueryCurrRegionHttpRsp.Parser.ParseFrom(
                op.RsaDecrypt(Convert.FromBase64String(content), RSAEncryptionPadding.Pkcs1));
        }
    }
}