using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XC.RSAUtil;

namespace csharp_Protoshift
{
    internal static class Tools
    {
        public static string ProgramPath => AppDomain.CurrentDomain.BaseDirectory;

        static Random ran = new Random();

        /// <summary>
        /// Generate a random string with length of [len]. 
        /// </summary>
        public static string RandomStr(int len)
        {
            string charset = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            string res = "";
            while (len-- > 0)
            {
                res += charset[ran.Next(0, 61)];
            }
            return res;
        }

        public async static Task ExecuteProcess(string path, string args)
        {
            var p = Process.Start(path, args);
            await p.WaitForExitAsync();
        }

        public static JsonElement GetFieldFromJson(string json, string fieldName)
        {
            var doc = JsonDocument.Parse(json);
#pragma warning disable CS8603 // 可能返回 null 引用。
            return doc.RootElement.GetProperty(fieldName);
#pragma warning restore CS8603 // 可能返回 null 引用。
        }

        /// <summary>
        /// Load the rsa key as <see cref="RSAUtilBase"/>.
        /// </summary>
        /// <param name="rsaKey">The string rsa key, support public/private, PKCS1/PKCS8/Xml all.</param>
        /// <param name="keySize">The bits key size, e.g. 2048-bit</param>
        /// <returns></returns>
        public static RSAUtilBase LoadRSAKey(string rsaKey, int keySize = 2048)
        {
            // PKCS8 Padding
            if (rsaKey.StartsWith("-----BEGIN PUBLIC KEY-----"))
                return new RsaPkcs8Util(publicKey: rsaKey, keySize: keySize);
            else if (rsaKey.StartsWith("-----BEGIN PRIVATE KEY-----"))
                return new RsaPkcs8Util(privateKey: rsaKey, keySize: keySize);
            // PKCS1 Padding
            else if (rsaKey.StartsWith("-----BEGIN RSA PUBLIC KEY-----"))
                return new RsaPkcs1Util(publicKey: rsaKey, keySize: keySize);
            else if (rsaKey.StartsWith("-----BEGIN RSA PRIVATE KEY-----"))
                return new RsaPkcs1Util(privateKey: rsaKey, keySize: keySize);
            // .NET XML Format
            else if (rsaKey.StartsWith("<RSAKeyValue>"))
            {
                if (rsaKey.Contains("<InverseQ>"))
                    return new RsaXmlUtil(privateKey: rsaKey, keySize: keySize);
                else return new RsaXmlUtil(publicKey: rsaKey, keySize: keySize);
            }
            else throw new ArgumentException("Invalid RSA Key!", nameof(rsaKey));
        }
    }
}
