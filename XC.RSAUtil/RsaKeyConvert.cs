using System;
using System.IO;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;

namespace XC.RSAUtil
{
    /// <summary>
    /// RSA Key Convert Class
    /// Author:Zhiqiang Li
    /// </summary>
    public class RsaKeyConvert
    {
        /// <summary>
        /// Public Key Convert pem->xml
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string PublicKeyPemToXml(string publicKey)
        {
            publicKey = RsaPemFormatHelper.PublicKeyFormat(publicKey);

            PemReader pr = new(new StringReader(publicKey));
            var obj = pr.ReadObject();
            if (obj is not RsaKeyParameters rsaKey)
            {
                throw new ArgumentException("Public key format is incorrect", nameof(publicKey));
            }

            XElement publicElement = new("RSAKeyValue");
            //Modulus
            XElement pubmodulus = new("Modulus", Convert.ToBase64String(rsaKey.Modulus.ToByteArrayUnsigned()));
            //Exponent
            XElement pubexponent = new("Exponent", Convert.ToBase64String(rsaKey.Exponent.ToByteArrayUnsigned()));

            publicElement.Add(pubmodulus);
            publicElement.Add(pubexponent);
            return publicElement.ToString();
        }

        /// <summary>
        /// Public Key Convert xml->pem
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        public static string PublicKeyXmlToPem(string publicKey)
        {
            XElement root = XElement.Parse(publicKey);
            //Modulus
            var modulus = root.Element("Modulus");
            //Exponent
            var exponent = root.Element("Exponent");

            if (modulus == null || exponent == null)
                throw new ArgumentException("Invalid public key!", nameof(publicKey));

            RsaKeyParameters rsaKeyParameters = new(false, new BigInteger(1, Convert.FromBase64String(modulus.Value)), new BigInteger(1, Convert.FromBase64String(exponent.Value)));

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(rsaKeyParameters);
            pWrt.Writer.Close();
            return sw.ToString();
        }

        /// <summary>
        /// Private Key Convert Pkcs1->xml
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs1ToXml(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs1PrivateKeyFormat(privateKey);

            PemReader pr = new(new StringReader(privateKey));
            if (pr.ReadObject() is not AsymmetricCipherKeyPair asymmetricCipherKeyPair)
            {
                throw new ArgumentException("Private key format is incorrect", nameof(privateKey));
            }
            RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters =
                (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(
                    PrivateKeyInfoFactory.CreatePrivateKeyInfo(asymmetricCipherKeyPair.Private));

            XElement privatElement = new("RSAKeyValue");
            //Modulus
            XElement primodulus = new("Modulus", Convert.ToBase64String(rsaPrivateCrtKeyParameters.Modulus.ToByteArrayUnsigned()));
            //Exponent
            XElement priexponent = new("Exponent", Convert.ToBase64String(rsaPrivateCrtKeyParameters.PublicExponent.ToByteArrayUnsigned()));
            //P
            XElement prip = new("P", Convert.ToBase64String(rsaPrivateCrtKeyParameters.P.ToByteArrayUnsigned()));
            //Q
            XElement priq = new("Q", Convert.ToBase64String(rsaPrivateCrtKeyParameters.Q.ToByteArrayUnsigned()));
            //DP
            XElement pridp = new("DP", Convert.ToBase64String(rsaPrivateCrtKeyParameters.DP.ToByteArrayUnsigned()));
            //DQ
            XElement pridq = new("DQ", Convert.ToBase64String(rsaPrivateCrtKeyParameters.DQ.ToByteArrayUnsigned()));
            //InverseQ
            XElement priinverseQ = new("InverseQ", Convert.ToBase64String(rsaPrivateCrtKeyParameters.QInv.ToByteArrayUnsigned()));
            //D
            XElement prid = new("D", Convert.ToBase64String(rsaPrivateCrtKeyParameters.Exponent.ToByteArrayUnsigned()));

            privatElement.Add(primodulus);
            privatElement.Add(priexponent);
            privatElement.Add(prip);
            privatElement.Add(priq);
            privatElement.Add(pridp);
            privatElement.Add(pridq);
            privatElement.Add(priinverseQ);
            privatElement.Add(prid);

            return privatElement.ToString();
        }

        /// <summary>
        /// Private Key Convert xml->Pkcs1
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyXmlToPkcs1(string privateKey)
        {
            XElement root = XElement.Parse(privateKey);
            //Modulus
            var modulus = root.Element("Modulus");
            //Exponent
            var exponent = root.Element("Exponent");
            //P
            var p = root.Element("P");
            //Q
            var q = root.Element("Q");
            //DP
            var dp = root.Element("DP");
            //DQ
            var dq = root.Element("DQ");
            //InverseQ
            var inverseQ = root.Element("InverseQ");
            //D
            var d = root.Element("D");

            if (modulus == null || exponent == null || p == null || q == null || dp == null || dq == null 
                || inverseQ == null || d == null)
                throw new ArgumentException("Invalid private key!", nameof(privateKey));

            RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters=new(
                new BigInteger(1,Convert.FromBase64String(modulus.Value)),
                new BigInteger(1, Convert.FromBase64String(exponent.Value)),
                new BigInteger(1, Convert.FromBase64String(d.Value)),
                new BigInteger(1, Convert.FromBase64String(p.Value)),
                new BigInteger(1, Convert.FromBase64String(q.Value)),
                new BigInteger(1, Convert.FromBase64String(dp.Value)), 
                new BigInteger(1, Convert.FromBase64String(dq.Value)), 
                new BigInteger(1, Convert.FromBase64String(inverseQ.Value)));

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(rsaPrivateCrtKeyParameters);
            pWrt.Writer.Close();
            return sw.ToString();

        }


        /// <summary>
        /// Private Key Convert Pkcs8->xml
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs8ToXml(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs8PrivateKeyFormatRemove(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam =
                (RsaPrivateCrtKeyParameters) PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));

            XElement privatElement = new("RSAKeyValue");
            //Modulus
            XElement primodulus = new("Modulus", Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()));
            //Exponent
            XElement priexponent = new("Exponent", Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()));
            //P
            XElement prip = new("P", Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()));
            //Q
            XElement priq = new("Q", Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()));
            //DP
            XElement pridp = new("DP", Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()));
            //DQ
            XElement pridq = new("DQ", Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()));
            //InverseQ
            XElement priinverseQ = new("InverseQ", Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()));
            //D
            XElement prid = new("D", Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));

            privatElement.Add(primodulus);
            privatElement.Add(priexponent);
            privatElement.Add(prip);
            privatElement.Add(priq);
            privatElement.Add(pridp);
            privatElement.Add(pridq);
            privatElement.Add(priinverseQ);
            privatElement.Add(prid);

            return privatElement.ToString();
        }

        /// <summary>
        /// Private Key Convert xml->Pkcs8
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyXmlToPkcs8(string privateKey)
        {
            XElement root = XElement.Parse(privateKey);
            //Modulus
            var modulus = root.Element("Modulus");
            //Exponent
            var exponent = root.Element("Exponent");
            //P
            var p = root.Element("P");
            //Q
            var q = root.Element("Q");
            //DP
            var dp = root.Element("DP");
            //DQ
            var dq = root.Element("DQ");
            //InverseQ
            var inverseQ = root.Element("InverseQ");
            //D
            var d = root.Element("D");

            if (modulus == null || exponent == null || p == null || q == null || dp == null || dq == null
                || inverseQ == null || d == null)
                throw new ArgumentException("Invalid private key!", nameof(privateKey));

            RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters = new(
                new BigInteger(1, Convert.FromBase64String(modulus.Value)),
                new BigInteger(1, Convert.FromBase64String(exponent.Value)),
                new BigInteger(1, Convert.FromBase64String(d.Value)),
                new BigInteger(1, Convert.FromBase64String(p.Value)),
                new BigInteger(1, Convert.FromBase64String(q.Value)),
                new BigInteger(1, Convert.FromBase64String(dp.Value)),
                new BigInteger(1, Convert.FromBase64String(dq.Value)),
                new BigInteger(1, Convert.FromBase64String(inverseQ.Value)));

            StringWriter swpri = new();
            PemWriter pWrtpri = new(swpri);
            Pkcs8Generator pkcs8 = new(rsaPrivateCrtKeyParameters);
            pWrtpri.WriteObject(pkcs8);
            pWrtpri.Writer.Close();
            return swpri.ToString();

        }

        /// <summary>
        /// Private Key Convert Pkcs1->Pkcs8
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs1ToPkcs8(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs1PrivateKeyFormat(privateKey);
            PemReader pr = new(new StringReader(privateKey));

            if (pr.ReadObject() is not AsymmetricCipherKeyPair kp)
                throw new ArgumentException("Invalid private key!", nameof(privateKey));
            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            Pkcs8Generator pkcs8 = new(kp.Private);
            pWrt.WriteObject(pkcs8);
            pWrt.Writer.Close();
            string result = sw.ToString();
            return result;
        }

        /// <summary>
        /// Private Key Convert Pkcs8->Pkcs1
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs8ToPkcs1(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs8PrivateKeyFormat(privateKey);
            PemReader pr = new(new StringReader(privateKey));

            if (pr.ReadObject() is not RsaPrivateCrtKeyParameters kp)
                throw new ArgumentException("Invalid private key!", nameof(privateKey));

            var keyParameter = PrivateKeyFactory.CreateKey(PrivateKeyInfoFactory.CreatePrivateKeyInfo(kp));

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(keyParameter);
            pWrt.Writer.Close();
            string result = sw.ToString();
            return result;
        }
    }
}
