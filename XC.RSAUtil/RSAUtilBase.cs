using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace XC.RSAUtil
{
    public abstract class RSAUtilBase : IDisposable
    {
        public RSA? PrivateRsa;
        public RSA? PublicRsa;

        static readonly Dictionary<RSAEncryptionPadding, int> PaddingLimitDic = new()
        {
            [RSAEncryptionPadding.Pkcs1] = 11,
            [RSAEncryptionPadding.OaepSHA1] = 42,
            [RSAEncryptionPadding.OaepSHA256] = 66,
            [RSAEncryptionPadding.OaepSHA384] = 98,
            [RSAEncryptionPadding.OaepSHA512] = 130,
        };

        /// <summary>
        /// RSA 无长度限制 公钥加密
        /// </summary>
        /// <param name="data">需要加密的数据</param>
        /// <param name="padding">填充算法</param>
        /// <returns></returns>
        public byte[] RsaEncrypt(byte[] data, RSAEncryptionPadding padding)
        {
            AssertPubKeyNotNull();
#pragma warning disable CS8602 // Asserted.
            int bufferSize = (PublicRsa.KeySize / 8) - 11;//单块最大长度
#pragma warning restore CS8602 // 解引用可能出现空引用。
            var buffer = new byte[bufferSize];
            using (MemoryStream inputStream = new(data), outputStream = new())
            {
                while (true)//分段加密
                {
                    int readSize = inputStream.Read(buffer, 0, bufferSize);
                    if (readSize <= 0) break;
                    var temp = new byte[readSize];
                    Array.Copy(buffer, 0, temp, 0, readSize);
                    var encryptedBytes = PublicRsa.Encrypt(temp, padding);
                    outputStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                }
                return outputStream.ToArray();
            }
        }
        
        /// <summary>
        /// RSA 无长度限制 私钥解密
        /// </summary>
        /// <param name="data">需要解密的数据</param>
        /// <param name="padding">填充算法</param>
        /// <returns></returns>
        public byte[] RsaDecrypt(byte[] data, RSAEncryptionPadding padding)
        {
            AssertPriKeyNotNull();
#pragma warning disable CS8602 // Asserted.
            int bufferSize = PrivateRsa.KeySize / 8;
#pragma warning restore CS8602 // 解引用可能出现空引用。
            var buffer = new byte[bufferSize];
            using (MemoryStream inputStream = new(data), outputStream = new())
            {
                while (true)
                {
                    int readSize = inputStream.Read(buffer, 0, bufferSize);
                    if (readSize <= 0) break;
                    var temp = new byte[readSize];
                    Array.Copy(buffer, 0, temp, 0, readSize);
                    var rawBytes = PrivateRsa.Decrypt(temp, padding);
                    outputStream.Write(rawBytes, 0, rawBytes.Length);
                }
                return outputStream.ToArray();
            }
        }
        /// <summary>
        /// Use private key for data signing
        /// </summary>
        /// <param name="data">Need to sign data</param>
        /// <param name="hashAlgorithmName">Signed hash algorithm name</param>
        /// <param name="padding">Signature padding algorithm</param>
        /// <returns></returns>
        public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithmName, RSASignaturePadding padding)
        {
            AssertPriKeyNotNull();
#pragma warning disable CS8602 // Asserted.
            return PrivateRsa.SignData(data, hashAlgorithmName, padding);
#pragma warning restore CS8602 // 解引用可能出现空引用。
        }

        /// <summary>
        /// Use public key to verify data signature
        /// </summary>
        /// <param name="data">Need to verify the signature data</param>
        /// <param name="sign">sign</param>
        /// <param name="hashAlgorithmName">Signed hash algorithm name</param>
        /// <param name="padding">Signature padding algorithm</param>
        /// <returns></returns>
        public bool VerifyData(byte[] data, byte[] sign, HashAlgorithmName hashAlgorithmName, RSASignaturePadding padding)
        {
            AssertPubKeyNotNull();
#pragma warning disable CS8602 // Asserted.
            var res = PublicRsa.VerifyData(data, sign, hashAlgorithmName, padding);
#pragma warning restore CS8602 // 解引用可能出现空引用。
            return res;
        }

        protected abstract RSAParameters CreateRsapFromPrivateKey(string privateKey);
        protected abstract RSAParameters CreateRsapFromPublicKey(string publicKey);

        public void Dispose()
        {
            PrivateRsa?.Dispose();
            PublicRsa?.Dispose();
        }

        protected void AssertPubKeyNotNull()
        {
            if (PublicRsa == null)
            {
                throw new InvalidOperationException("public key can not be null");
            }
        }

        protected void AssertPriKeyNotNull()
        {
            if (PrivateRsa == null)
            {
                throw new InvalidOperationException("private key can not be null");
            }
        }
    }
}