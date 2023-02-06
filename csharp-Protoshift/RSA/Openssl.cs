using System.IO;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace csharp_Protoshift.RSA
{
    /// <summary>
    /// Using OpenSSL to finish some RSA operations. Designed for PKCS1 padding. 
    /// </summary>
    public class Openssl : IDisposable
    {
        // Files to storage at
        public static readonly string WorkingPath;

        static Openssl()
        {
            WorkingPath = $"{Tools.ProgramPath}/Temp/Temp-Openssl-{Tools.RandomStr(16)}";
            Directory.CreateDirectory(WorkingPath);
        }

        // RSA key
        public readonly string pubkeyPath;
        public readonly string prikeyPath;
        public readonly bool pubin;
        /// <summary>
        /// The length of the key, e.g. 2048-bit/1024-bit
        /// </summary>
        public readonly int keylen;
        /// <summary>
        /// The part length when encrypting/decrypting. Always equals to keylen / 8 bytes.
        /// </summary>
        public readonly int partlen; 

        /// <summary>
        /// Normal Initializer
        /// </summary>
        /// <param name="PEMkey">PEM Format RSA Key</param>
        /// <param name="pubin">Whether the key is public. If a private key is given, then the public key can be automatically generated.</param>
        public Openssl(string PEMkey, bool pubin)
        {
            this.pubin = pubin;
            pubkeyPath = $"{WorkingPath}\\Public-{Tools.RandomStr(16)}.pem";
            prikeyPath = "Not Initialized private key";
            keylen = 2048; // Will be able to detect in the future
            partlen = keylen / 8;

            if (pubin)
            {
                File.WriteAllText(pubkeyPath, PEMkey);
            }
            else
            {
                prikeyPath = $"{WorkingPath}\\Private-{Tools.RandomStr(16)}.pem";
                File.WriteAllText(prikeyPath, PEMkey);

                Tools.ExecuteProcess("openssl", 
                    $"rsa -in \"{prikeyPath}\" -pubout -out \"{pubkeyPath}\"").Wait();
            }
        }

        #region Pub encrypt / Pri decrypt
        public async Task<byte[]> EncryptByPublicKey(byte[] data)
        {
            AssertIfDisposed();

            int pub_partlen = partlen - 11; // For PKCS1Padding
            int partCount = CeilDiv(data.Length, pub_partlen); 
            byte[][] separated = new byte[partCount][];
            for (int i = 0; i < data.Length; i += pub_partlen)
            {
                separated[i / pub_partlen] = new byte
                    [Math.Min(pub_partlen, data.Length - i)];
                Buffer.BlockCopy(data, i, separated[i / pub_partlen], 0, Math.Min(pub_partlen, data.Length - i));
            }

            #region Invoke Openssl
            ConcurrentDictionary<int, byte[]> results = new();
            for (int j = 0; j < partCount; j++)
            {
                string binPath = $"{WorkingPath}\\Ori-{Tools.RandomStr(8)}-{j}.bin";
                string encPath = $"{WorkingPath}\\Enc-{Tools.RandomStr(8)}-{j}.bin";
                File.WriteAllBytes(binPath, separated[j]);

                await Tools.ExecuteProcess("openssl", "rsautl -encrypt " +
                    $"-in \"{binPath}\" " +
                    $"-inkey \"{pubkeyPath}\" -pubin " +
                    $"-out \"{encPath}\"");

                byte[] encout = File.ReadAllBytes(encPath);
                Debug.Assert(encout.Length == partlen);
                results.TryAdd(j, encout);

                File.Delete(binPath);
                File.Delete(encPath);
            }

            //Console.WriteLine($"Parallel Finished: {parres.IsCompleted}");
            #endregion

            int partCount_dec = results.Count;

            byte[] rtn = new byte[partCount_dec * partlen];
            for (int i = 0; i < partCount_dec; i++)
            {
                Buffer.BlockCopy(results[i], 0, rtn, i * partlen, partlen);
            }

            return rtn;
        }

        public async Task<byte[]> DecryptByPrivateKey(byte[] data)
        {
            if (data.Length % partlen != 0)
                throw new ArgumentException("Invaild data (length assert).");
            AssertPrivateInstance();
            AssertIfDisposed();
            
            int partCount = data.Length / partlen; 
            byte[][] separated = new byte[partCount][];
            for (int i = 0; i < data.Length; i += partlen)
            {
                separated[i / partlen] = new byte[partlen];
                Buffer.BlockCopy(data, i, separated[i / partlen], 0, partlen);
            }

            #region Invoke Openssl
            ConcurrentDictionary<int, byte[]> results = new();
            /*var parres = Parallel.For(0, partCount, async (j, _) => 
            {
                string binPath = $"{WorkingPath}\\Ori-{Tools.RandomStr(8)}-{j}.bin";
                string decPath = $"{WorkingPath}\\Dec-{Tools.RandomStr(8)}-{j}.bin";
                File.WriteAllBytes(binPath, separated[j]);

                await Tools.ExecuteProcess("openssl", "rsautl -decrypt " +
                    $"-in \"{binPath}\" " +
                    $"-inkey \"{prikeyPath}\" " +
                    $"-out \"{decPath}\"");

                byte[] decout = File.ReadAllBytes(decPath);
                results.TryAdd(j, decout);

                File.Delete(binPath);
                File.Delete(decPath);
            });*/
            for (int j = 0; j < partCount; j++)
            {
                string binPath = $"{WorkingPath}\\Ori-{Tools.RandomStr(8)}-{j}.bin";
                string decPath = $"{WorkingPath}\\Dec-{Tools.RandomStr(8)}-{j}.bin";
                File.WriteAllBytes(binPath, separated[j]);

                await Tools.ExecuteProcess("openssl", "rsautl -decrypt " +
                    $"-in \"{binPath}\" " +
                    $"-inkey \"{prikeyPath}\" " +
                    $"-out \"{decPath}\"");

                byte[] decout = File.ReadAllBytes(decPath);
                results.TryAdd(j, decout);

                File.Delete(binPath);
                File.Delete(decPath);
            }

            //Console.WriteLine($"Parallel Finished: {parres.IsCompleted}");
            #endregion

            int partCount_dec = results.Count;

            byte[] res = new byte[partCount_dec * (partlen - 11)];
            for (int i = 0; i < partCount_dec; i++)
            {
                Buffer.BlockCopy(results[i], 0, res, i * (partlen - 11), results[i].Length);
            }

            #region Remove extended zero
            int reallen = res.Length;
            for (; reallen >= 0; reallen--)
            {
                if (res[reallen - 1] != 0) break;
            }

            byte[] rtn = new byte[reallen];
            Buffer.BlockCopy(res, 0, rtn, 0, reallen);
            #endregion

            return rtn;
        }
        #endregion

        #region Pri sign / Pub verify
        public async Task<byte[]> SignByPrivateKey(byte[] data)
        {
            AssertPrivateInstance();
            AssertIfDisposed();
            string binPath = $"{WorkingPath}\\Ori-{Tools.RandomStr(16)}.bin";
            string sigPath = $"{WorkingPath}\\Sig-{Tools.RandomStr(16)}.bin";
            File.WriteAllBytes(binPath, data);

            await Tools.ExecuteProcess("openssl", "dgst -sha256 " +
                $"-out \"{sigPath}\" " +
                $"-sign \"{prikeyPath}\" -keyform PEM \"{binPath}\"");

            byte[] rtn = File.ReadAllBytes(sigPath);
            Debug.Assert(rtn.Length == partlen);
            return rtn;
        }

        public async Task<bool> VerifyByPublicKey(byte[] data, byte[] signature)
        {
            AssertIfDisposed();
            if (signature.Length != partlen)
                throw new ArgumentException("Invaild signature (length assert).");
            string binPath = $"{WorkingPath}\\Ori-{Tools.RandomStr(16)}.bin";
            string sigPath = $"{WorkingPath}\\Sig-{Tools.RandomStr(16)}.bin";
            File.WriteAllBytes(binPath, data);
            File.WriteAllBytes(sigPath, signature);

            #region Start Openssl
            ProcessStartInfo stinfo = new("openssl");
            stinfo.Arguments = "dgst -sha256 -keyform PEM " +
                $"-verify \"{pubkeyPath}\" " +
                $"-signature \"{sigPath}\" \"{binPath}\"";
            stinfo.RedirectStandardOutput = true;

            var pro = Process.Start(stinfo);
            await pro.WaitForExitAsync();
            #endregion

            #region Read Verification Result
            var reader = pro.StandardOutput;
            string res = await reader.ReadToEndAsync();
            reader.Dispose();
            #endregion

            Debug.Assert(res.StartsWith("Verified OK")
                || res.StartsWith("Verification Failure"));
            return res.StartsWith("Verified OK");
        }
        #endregion
        
        public void AssertPrivateInstance()
        {
            if (pubin)
                throw new InvalidOperationException(
                    "Trying to decrypt using a instance without private key.");
        }

        /// <summary>
        /// Return ceil of a / b. 
        /// </summary>
        protected static int CeilDiv(int a, int b)
        {
            return (int)Math.Ceiling((decimal)a / b);
        }

        #region IDisposeable
        private bool _disposed = false;
        private void AssertIfDisposed()
        {
            if (_disposed)
                throw new InvalidOperationException("Instance has been disposed.");
        }

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            try
            {
                File.Delete(pubkeyPath);
                File.Delete(prikeyPath);
            }
            catch (Exception ex)
            {
#if DEBUG
                Console.WriteLine("Exception happened when disposing Openssl instance:");
                Console.WriteLine(ex);
#endif
            }

            _disposed = true;
        }
        #endregion
    }
}