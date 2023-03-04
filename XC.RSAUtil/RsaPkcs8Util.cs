using System;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace XC.RSAUtil
{
    /// <summary>
    /// RSA pkcs8 format key helper class
    /// Author:Zhiqiang Li
    /// </summary>
    public class RsaPkcs8Util:RSAUtilBase
    {
        public RsaPkcs8Util(string? privateKey = null, string? publicKey = null, int keySize = 2048)
        {
            if (string.IsNullOrEmpty(privateKey) && string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentException("Public and private keys must not be empty at the same time");
            }

            if (!string.IsNullOrEmpty(privateKey))
            {
                PrivateRsa = RSA.Create();
                PrivateRsa.KeySize = keySize;
                var priRsap = CreateRsapFromPrivateKey(privateKey);
                PrivateRsa.ImportParameters(priRsap);

                if (string.IsNullOrEmpty(publicKey))
                {
                    PublicRsa = RSA.Create();
                    PublicRsa.KeySize = keySize;
                    var pubRsap = new RSAParameters
                    {
                        Modulus = priRsap.Modulus,
                        Exponent = priRsap.Exponent
                    };
                    PublicRsa.ImportParameters(pubRsap);
                }
            }

            if (!string.IsNullOrEmpty(publicKey))
            {
                PublicRsa = RSA.Create();
                PublicRsa.KeySize = keySize;
                var pubRsap = CreateRsapFromPublicKey(publicKey);
                PublicRsa.ImportParameters(pubRsap);
            }
        }

		/// <summary>
		/// Create an RSA parameter based on the xml format public key
		/// </summary>
		/// <param name="publicKey"></param>
		/// <returns></returns>
		protected sealed override RSAParameters CreateRsapFromPublicKey(string publicKey)
        {
            publicKey = RsaPemFormatHelper.PublicKeyFormatRemove(publicKey);
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicKey));
            var rsap = new RSAParameters
            {
                Modulus = publicKeyParam.Modulus.ToByteArrayUnsigned(),
                Exponent = publicKeyParam.Exponent.ToByteArrayUnsigned()
            };
            return rsap;
        }

		/// <summary>
		/// Create an RSA parameter based on the xml format private key
		/// </summary>
		/// <param name="privateKey"></param>
		/// <returns></returns>
		protected sealed override RSAParameters CreateRsapFromPrivateKey(string privateKey)
        {
            privateKey = RsaPemFormatHelper.Pkcs8PrivateKeyFormatRemove(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(Convert.FromBase64String(privateKey));

            var rsap = new RSAParameters
            {
                Modulus = privateKeyParam.Modulus.ToByteArrayUnsigned(),
                Exponent = privateKeyParam.PublicExponent.ToByteArrayUnsigned(),
                P = privateKeyParam.P.ToByteArrayUnsigned(),
                Q = privateKeyParam.Q.ToByteArrayUnsigned(),
                DP = privateKeyParam.DP.ToByteArrayUnsigned(),
                DQ = privateKeyParam.DQ.ToByteArrayUnsigned(),
                InverseQ = privateKeyParam.QInv.ToByteArrayUnsigned(),
                D = privateKeyParam.Exponent.ToByteArrayUnsigned()
            };

            return rsap;
        }
    }
}