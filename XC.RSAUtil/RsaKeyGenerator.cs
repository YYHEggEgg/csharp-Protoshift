using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Xml.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace XC.RSAUtil
{
    /// <summary>
    ///  Rsa Key Generator
    /// Author:Zhiqiang Li
    /// </summary>
    public class RsaKeyGenerator
    {
        /// <summary>
        /// Generate XML Format RSA Key.
        /// </summary>
        /// <param name="keySize">Key Size.Unit: bits</param>
        /// <returns></returns>
        public static KeyResult XmlKey(int keySize)
        {
            RSA rsa = RSA.Create();
            rsa.KeySize = keySize;
            var rsap = rsa.ExportParameters(true);
            KeyResult res = new();
            if (rsap.Modulus == null || rsap.Exponent == null || rsap.P == null || rsap.Q == null 
                || rsap.DP == null || rsap.DQ == null || rsap.InverseQ == null || rsap.D == null)
                throw new Exception($"Generate key failed!");

            XElement privatElement = new("RSAKeyValue");
            //Modulus
            XElement primodulus = new("Modulus", Convert.ToBase64String(rsap.Modulus));
            //Exponent
            XElement priexponent = new("Exponent", Convert.ToBase64String(rsap.Exponent));
            //P
            XElement prip = new("P", Convert.ToBase64String(rsap.P));
            //Q
            XElement priq = new("Q", Convert.ToBase64String(rsap.Q));
            //DP
            XElement pridp = new("DP", Convert.ToBase64String(rsap.DP));
            //DQ
            XElement pridq = new("DQ", Convert.ToBase64String(rsap.DQ));
            //InverseQ
            XElement priinverseQ = new("InverseQ", Convert.ToBase64String(rsap.InverseQ));
            //D
            XElement prid = new("D", Convert.ToBase64String(rsap.D));

            privatElement.Add(primodulus);
            privatElement.Add(priexponent);
            privatElement.Add(prip);
            privatElement.Add(priq);
            privatElement.Add(pridp);
            privatElement.Add(pridq);
            privatElement.Add(priinverseQ);
            privatElement.Add(prid);
            
            //添加私钥
            res.privateKey = privatElement.ToString();


            XElement publicElement = new("RSAKeyValue");
            //Modulus
            XElement pubmodulus = new("Modulus", Convert.ToBase64String(rsap.Modulus));
            //Exponent
            XElement pubexponent = new("Exponent", Convert.ToBase64String(rsap.Exponent));

            publicElement.Add(pubmodulus);
            publicElement.Add(pubexponent);

            //添加公钥
            res.publicKey = publicElement.ToString();

            return res;
        }

        /// <summary>
        /// Generate RSA key in Pkcs1 format.
        /// </summary>
        /// <param name="keySize">Key Size.Unit: bits</param>
        /// <param name="format">Whether the return is standard pem file format. If false, the method will return the PEM base64 string.</param>
        /// <returns></returns>
        public static KeyResult Pkcs1Key(int keySize, bool format = true)
        {
            KeyResult res = new();

            IAsymmetricCipherKeyPairGenerator kpGen = GeneratorUtilities.GetKeyPairGenerator("RSA");
            kpGen.Init(new KeyGenerationParameters(new SecureRandom(), keySize));
            var keyPair = kpGen.GenerateKeyPair();

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(keyPair.Private);
            pWrt.Writer.Close();
            var privateKey = sw.ToString();

            if (!format)
            {
                privateKey = privateKey.Replace("-----BEGIN RSA PRIVATE KEY-----", "").Replace("-----END RSA PRIVATE KEY-----", "").Replace(Environment.NewLine, "");
            }

            res.privateKey = privateKey;

            StringWriter swpub = new();
            PemWriter pWrtpub = new(swpub);
            pWrtpub.WriteObject(keyPair.Public);
            pWrtpub.Writer.Close();
            string publicKey = swpub.ToString();
            if (!format)
            {
                publicKey = publicKey.Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "").Replace(Environment.NewLine, "");
            }

            res.publicKey = publicKey;

            return res;
        }

        /// <summary>
        /// Generate Pkcs8 format RSA key.
        /// </summary>
        /// <param name="keySize">Key Size.Unit: bits</param>
        /// <param name="format">Whether the return is standard pem file format. If false, the method will return the PEM base64 string.</param>
        /// <returns></returns>
        public static KeyResult Pkcs8Key(int keySize, bool format = true)
        {
            KeyResult res = new();

            IAsymmetricCipherKeyPairGenerator kpGen = GeneratorUtilities.GetKeyPairGenerator("RSA");
            kpGen.Init(new KeyGenerationParameters(new SecureRandom(), keySize));
            var keyPair = kpGen.GenerateKeyPair();

            StringWriter swpri = new();
            PemWriter pWrtpri = new(swpri);
            Pkcs8Generator pkcs8 = new(keyPair.Private);
            pWrtpri.WriteObject(pkcs8);
            pWrtpri.Writer.Close();
            string privateKey = swpri.ToString();

            if (!format)
            {
                privateKey = privateKey.Replace("-----BEGIN PRIVATE KEY-----", "").Replace("-----END PRIVATE KEY-----", "").Replace(Environment.NewLine, "");
            }

            res.privateKey = privateKey;

            StringWriter swpub = new();
            PemWriter pWrtpub = new(swpub);
            pWrtpub.WriteObject(keyPair.Public);
            pWrtpub.Writer.Close();
            string publicKey = swpub.ToString();
            if (!format)
            {
                publicKey = publicKey.Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "").Replace(Environment.NewLine, "");
            }

            res.publicKey = publicKey;

            return res;
        }

        public struct KeyResult
        {
            public string publicKey;
            public string privateKey;
        }
    }
}