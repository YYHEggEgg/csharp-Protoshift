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
    public partial class RsaKeyConvert
    {
        /// <summary>
        /// Pkcs1 Key Private->Public
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs1ToPublic(string privateKey)
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

            RsaKeyParameters rsaPublicKeyParameters = new(false,
                rsaPrivateCrtKeyParameters.Modulus, rsaPrivateCrtKeyParameters.PublicExponent);

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(rsaPublicKeyParameters);
            pWrt.Writer.Close();
            return sw.ToString();
        }

        /// <summary>
        /// Pkcs8 Key Private->Public
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyPkcs8ToPublic(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs8PrivateKeyFormatRemove(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam =
                (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));

            RsaKeyParameters rsaPublicKeyParameters = new(false,
                privateKeyParam.Modulus, privateKeyParam.PublicExponent);

            StringWriter sw = new();
            PemWriter pWrt = new(sw);
            pWrt.WriteObject(rsaPublicKeyParameters);
            pWrt.Writer.Close();
            return sw.ToString();
        }

        /// <summary>
        /// Xml Key Private->Public
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        public static string PrivateKeyXmlToPublic(string privateKey)
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

            XElement publicElement = new("RSAKeyValue");
            //Modulus
            XElement pubmodulus = new("Modulus", Convert.ToBase64String(
                new BigInteger(1, Convert.FromBase64String(modulus.Value)).ToByteArrayUnsigned()));
            //Exponent
            XElement pubexponent = new("Exponent", Convert.ToBase64String(
                new BigInteger(1, Convert.FromBase64String(exponent.Value)).ToByteArrayUnsigned()));

            publicElement.Add(pubmodulus);
            publicElement.Add(pubexponent);
            return publicElement.ToString();
        }
    }
}
