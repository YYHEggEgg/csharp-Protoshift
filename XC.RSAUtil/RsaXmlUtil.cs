using System.Security.Cryptography;
using System.Xml.Linq;

namespace XC.RSAUtil
{
    /// <summary>
    /// .net core xml format The RSA key helper classes are compatible with the xml formatted keys used by the .NET Framework
    /// Author:Zhiqiang Li
    /// CreateDate:2018-1-5
    /// </summary>
    public class RsaXmlUtil : RSAUtilBase
    {
        /// <summary>
        /// The class initializer.
        /// </summary>
        /// <param name="publicKey">The public key can be infered from private key.</param>
        /// <param name="privateKey">If not given, this instance won't support private key features.</param>
        /// <param name="keySize">The key length in bits, e.g. 2048-bits key.</param>
        /// <exception cref="ArgumentException">Neither <paramref name="publicKey"/> nor <paramref name="privateKey"/> has been given.</exception>
        public RsaXmlUtil(string? privateKey = null, string? publicKey = null, int keySize = 2048)
        {
            if (string.IsNullOrEmpty(privateKey) && string.IsNullOrEmpty(publicKey))
            {
                throw new ArgumentException("Public and private keys must not be empty at the same time");
            }
            else
            {
                RSAParameters pubRsap;
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
                        pubRsap = new RSAParameters
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
                    pubRsap = CreateRsapFromPublicKey(publicKey);
                    PublicRsa.KeySize = keySize;
                    PublicRsa.ImportParameters(pubRsap);
                }
            }
        }

        /// <summary>
        /// Create an RSA parameter based on the xml format private key
        /// </summary>
        /// <param name="privateKey"></param>
        /// <returns></returns>
        protected sealed override RSAParameters CreateRsapFromPrivateKey(string privateKey)
        {
            var rsap = new RSAParameters();
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

            rsap.Modulus = Convert.FromBase64String(modulus.Value);
            rsap.Exponent = Convert.FromBase64String(exponent.Value);
            rsap.P = Convert.FromBase64String(p.Value);
            rsap.Q = Convert.FromBase64String(q.Value);
            rsap.DP = Convert.FromBase64String(dp.Value);
            rsap.DQ = Convert.FromBase64String(dq.Value);
            rsap.InverseQ = Convert.FromBase64String(inverseQ.Value);
            rsap.D = Convert.FromBase64String(d.Value);
            return rsap;

        }

        /// <summary>
        /// Create an RSA parameter based on the xml format public key
        /// </summary>
        /// <param name="publicKey"></param>
        /// <returns></returns>
        protected sealed override RSAParameters CreateRsapFromPublicKey(string publicKey)
        {
            var rsap = new RSAParameters();
            XElement root = XElement.Parse(publicKey);
            //Modulus
            var modulus = root.Element("Modulus");
            //Exponent
            var exponent = root.Element("Exponent");

            if (modulus == null || exponent == null)
                throw new ArgumentException("Invalid public key!", nameof(publicKey));

            rsap.Modulus = Convert.FromBase64String(modulus.Value);
            rsap.Exponent = Convert.FromBase64String(exponent.Value);
            return rsap;
        }
    }
}