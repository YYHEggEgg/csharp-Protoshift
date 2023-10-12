using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text.Json;
using XC.RSAUtil;
using TextCopy;
using YYHEggEgg.Logger;
using CommandLine;

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

        #region GetFullFilePath
        public static bool TryGetFullFilePath(string? filePath, string? basePath,
            string allowed_extension, [NotNullWhen(true)] out string? result)
        {
            if (filePath == null || basePath == null)
            {
                result = null;
                return false;
            }
            var normal_relative = Path.GetFullPath($"./{filePath}", basePath);
            if (File.Exists(normal_relative))
            {
                result = normal_relative;
                return true;
            }
            var normal_relative_addext = Path.GetFullPath($"./{filePath}.{allowed_extension}", basePath);
            if (File.Exists(normal_relative_addext))
            {
                result = normal_relative_addext;
                return true;
            }
            var normal_full = filePath;
            if (File.Exists(normal_full))
            {
                result = Path.GetFullPath(normal_full);
                return true;
            }
            var normal_full_addext = $"{filePath}.{allowed_extension}";
            if (File.Exists(normal_full_addext))
            {
                result = Path.GetFullPath(normal_full_addext);
                return true;
            }
            result = null;
            return false;
        }

        public static bool TryGetFullFilePath(string? filePath, string? basePath,
            string allowed_extension, string allowed_extension2, [NotNullWhen(true)] out string? result)
        {
            if (filePath == null || basePath == null)
            {
                result = null;
                return false;
            }
            var normal_relative = Path.GetFullPath($"./{filePath}", basePath);
            if (File.Exists(normal_relative))
            {
                result = normal_relative;
                return true;
            }
            var normal_relative_addext = Path.GetFullPath($"./{filePath}.{allowed_extension}", basePath);
            if (File.Exists(normal_relative_addext))
            {
                result = normal_relative_addext;
                return true;
            }
            var normal_relative_addext2 = Path.GetFullPath($"./{filePath}.{allowed_extension2}", basePath);
            if (File.Exists(normal_relative_addext2))
            {
                result = normal_relative_addext2;
                return true;
            }
            var normal_full = filePath;
            if (File.Exists(normal_full))
            {
                result = Path.GetFullPath(normal_full);
                return true;
            }
            var normal_full_addext = $"{filePath}.{allowed_extension}";
            if (File.Exists(normal_full_addext))
            {
                result = Path.GetFullPath(normal_full_addext);
                return true;
            }
            var normal_full_addext2 = $"{filePath}.{allowed_extension2}";
            if (File.Exists(normal_full_addext2))
            {
                result = Path.GetFullPath(normal_full_addext2);
                return true;
            }
            result = null;
            return false;
        }

        public static bool TryGetFullFilePath(string? filePath, string? basePath,
            [NotNullWhen(true)] out string? result, params string[] allowed_extensions)
        {
            if (filePath == null || basePath == null)
            {
                result = null;
                return false;
            }
            var normal_relative = Path.GetFullPath($"./{filePath}", basePath);
            if (File.Exists(normal_relative))
            {
                result = normal_relative;
                return true;
            }
            foreach (var allowed_extension in allowed_extensions)
            {
                var normal_relative_addext = Path.GetFullPath($"./{filePath}.{allowed_extension}", basePath);
                if (File.Exists(normal_relative_addext))
                {
                    result = normal_relative_addext;
                    return true;
                }
            }
            var normal_full = filePath;
            if (File.Exists(normal_full))
            {
                result = Path.GetFullPath(normal_full);
                return true;
            }
            foreach (var allowed_extension in allowed_extensions)
            {
                var normal_full_addext = $"{filePath}.{allowed_extension}";
                if (File.Exists(normal_full_addext))
                {
                    result = Path.GetFullPath(normal_full_addext);
                    return true;
                }
            }
            result = null;
            return false;
        }
        #endregion // GetFullFilePath

        public static void SetClipBoard(string text)
        {
            try
            {
                ClipboardService.SetText(text);
                Log.Info("Result copied to clipboard.", nameof(SetClipBoard));
            }
            catch (Exception ex)
            {
                LogTrace.WarnTrace(ex, nameof(SetClipBoard), $"Copy to clipboard failed. ");
            }
        }

        public static async Task SetClipBoardAsync(string text)
        {
            try
            {
                await ClipboardService.SetTextAsync(text);
                Log.Info("Result copied to clipboard.", nameof(SetClipBoard));
            }
            catch (Exception ex)
            {
                LogTrace.WarnTrace(ex, nameof(SetClipBoard), $"Copy to clipboard failed. ");
            }
        }

        #region ChatGPT Show Time
        // Code in this region are all Generated by ChatGPT.

        /// <summary>
        /// Can be applied to both file and directory. Generate suffix like (1), (2) for the <paramref name="path"/> when the file/directory already exists.
        /// </summary>
        public static string AddNumberedSuffixToPath(string filePath)
        {
            /* 该方法首先检查给定路径是否已存在。
             * 如果是文件路径，则将文件名分离为文件名和扩展名，并在文件名后添加一个括号附加编号，直到找到可用的文件名。
             * 如果是目录路径，则附加数字后缀到目录名直到找到可用的目录名。
             * 例如，如果传入的参数是"C:\Users\Example\Desktop\test.txt"，
             * 如果该路径已经存在，则返回"C:\Users\Example\Desktop\test (1).txt"。 
             * 
             * 如果参数是"C:\Users\Example\Desktop\test"，
             * 如果该路径已经存在，则返回"C:\Users\Example\Desktop\test (1)"。 
             * 如果路径不存在，则返回原始路径。
             */
            if (File.Exists(filePath))
            {
                string directory = Path.GetDirectoryName(filePath) ?? string.Empty;
                string fileName = Path.GetFileNameWithoutExtension(filePath);
                string extension = Path.GetExtension(filePath);
                string newFilePath = filePath;
                int suffix = 1;

                while (File.Exists(newFilePath))
                {
                    newFilePath = Path.Combine(directory, string.Format("{0} ({1}){2}", fileName, suffix, extension));
                    suffix++;
                }

                return newFilePath;
            }
            else if (Directory.Exists(filePath))
            {
                string directoryName = Path.GetDirectoryName(filePath) ?? string.Empty;
                string directory = Path.Combine(directoryName, Path.GetFileName(filePath));
                string newDirectory = directory;
                int suffix = 1;

                while (Directory.Exists(newDirectory))
                {
                    newDirectory = Path.Combine(directoryName, string.Format("{0} ({1})", Path.GetFileName(filePath), suffix));
                    suffix++;
                }

                return newDirectory;
            }
            else
            {
                return filePath;
            }
        }

        public static string GetFileHash(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        public static string ParseCommandLineError(Error error)
        {
            if (error is BadFormatTokenError)
            {
                return "The provided param is in bad format.";
            }
            else if (error is BadVerbSelectedError)
            {
                return "An invalid verb (sub-command) is selected.";
            }
            else if (error is MissingRequiredOptionError)
            {
                var missingRequiredOptionError = (MissingRequiredOptionError)error;
                return $"Required Option is missing: {missingRequiredOptionError.NameInfo.NameText}.";
            }
            else if (error is NoVerbSelectedError)
            {
                return "No verb (sub-command) is selected.";
            }
            else if (error is SequenceOutOfRangeError)
            {
                var sequenceOutOfRangeError = (SequenceOutOfRangeError)error;
                return $"The value of sequence option '{sequenceOutOfRangeError.NameInfo.NameText}' is out of range.";
            }
            else
            {
                return "Unknown CommandLine error.";
            }
        }

        public static IEnumerable<string> ReportCommandLineErrors(IEnumerable<Error> errors)
        {
            // foreach (var error in errors)
            // {
            //     yield return ParseCommandLineError(error);
            // }
            // yield break;
            yield return "Unknown command line args detected.";
        }
        #endregion
    }
}
