using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using XC.RSAUtil;
using TextCopy;
using YYHEggEgg.Logger;
using CommandLine;
using System.Reflection;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CommandLine.Text;
using System.Text;
using Google.Protobuf;

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

        #region Clipboard (TextCopy)
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
        #endregion

        #region Update Check
        public static void RunBackgroundUpdateCheck()
        {
            _ = Task.Run(UpdateCheck);
        }

        private class VersionInfo
        {
            public string? CurrentVersion;
            /// <summary>
            /// Only when the current version is earlier
            /// than this will the update notice be raised
            /// as a warning.
            /// </summary>
            public string? EarliestStableVersion;
        }

        private static string GitHubRestApiUserAgent =>
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36 Edg/118.0.2088.46";

        private static async Task UpdateCheck()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.UserAgent.ParseAdd(GitHubRestApiUserAgent);
            var logger = Log.GetChannel(nameof(UpdateCheck));
            var json = JObject.Parse(await client.GetStringAsync(
                $"https://api.github.com/repos/YYHEggEgg/csharp-Protoshift/releases/latest"));

            if (!Version.TryParse(((string?)json["tag_name"])?.Substring(1), out var version_latest)) return;
            var version_current = Assembly.GetExecutingAssembly().GetName().Version;
            if (version_latest.CompareTo(version_current) <= 0) return;

            logger.LogInfo($"The new version: v{version_latest} of csharp-Protoshift is avaliable!");
            // Not a Git repository
            if (!Directory.Exists("./../.git")) return;

            foreach (var jtoken in json["assets"] ?? Enumerable.Empty<JToken>())
            {
                if ((string?)jtoken["name"] != "versioninfo.json") continue;
                var remoteinfo = await client.GetFromJsonAsync<VersionInfo>((string?)jtoken["browser_download_url"]);
                if (!Version.TryParse(remoteinfo?.EarliestStableVersion, out var version_stable)) return;

                if (version_stable.CompareTo(version_current) > 0) // Later
                {
                    logger.LogWarn($"You are recommended to update to this version. Just run 'update' script.");
                }
            }
        }
        #endregion

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

        public static JToken SortJson(JToken token)
        {
            switch (token.Type)
            {
                case JTokenType.Object:
                    return new JObject(
                        token.Children<JProperty>()
                             .OrderBy(prop => prop.Name)
                             .Select(prop => new JProperty(prop.Name, SortJson(prop.Value))));

                case JTokenType.Array:
                    return new JArray(
                        token.Select(SortJson)
                             .OrderBy(item => item.ToString()));

                default:
                    return token;
            }
        }

        public static string SortJsonIndented(string json) =>
            SortJson(JObject.Parse(json)).ToString(Newtonsoft.Json.Formatting.Indented);

        public static string SortJsonUnindented(string json) =>
            SortJson(JObject.Parse(json)).ToString(Newtonsoft.Json.Formatting.None);

        public static string SortJsonSingleLine(string json)
        {
            var jobj = JObject.Parse(json);
            var token = SortJson(jobj);
            using var stringWriter = new StringWriter();

            using (var jsonWriter = new JsonTextWriter(stringWriter))
            {
                jsonWriter.Formatting = Formatting.Indented;
                jsonWriter.IndentChar = ' ';
                jsonWriter.Indentation = 0;

                token.WriteTo(jsonWriter);
            }

            return stringWriter.ToString().ReplaceLineEndings(" ");
        }
        #endregion

        #region CommandLineParser
        private static SentenceBuilder _defaultFormatError = SentenceBuilder.Create();

        public static IEnumerable<string?> ReportCommandLineErrors(IEnumerable<Error> errors)
        {
            foreach (var error in errors)
            {
                yield return _defaultFormatError.FormatError(error);
            }
            yield break;
            // yield return "Unknown command line args detected.";
        }

        public static TextWriter NothingWriter => DropTextWriter.Instance;

        private class DropTextWriter : TextWriter
        {
            public static DropTextWriter Instance = new DropTextWriter();

            public override Encoding Encoding => Encoding.Default;

            public override void Close() { }
            public override void Flush() { }
            public override void Write(bool para_bool) { }
            public override void Write(char para_char) { }
            public override void Write(char[]? para_chars) { }
            public override void Write(char[] para_chars, int para_int1, int para_int2) { }
            public override void Write(decimal para_decimal) { }
            public override void Write(double para_double) { }
            public override void Write(int para_int) { }
            public override void Write(long para_long) { }
            public override void Write(object? para_obj1) { }
            public override void Write(ReadOnlySpan<Char> para_span_char) { }
            public override void Write(Single para_single) { }
            public override void Write(string? para_str) { }
            public override void Write(string? para_str, object? para_obj1) { }
            public override void Write(string? para_str, object? para_obj1, object? para_obj2) { }
            public override void Write(string? para_str, object? para_obj1, object? para_obj2, object? para_obj3) { }
            public override void Write(string? para_str, Object?[] para_objs) { }
            public override void Write(StringBuilder? para_stringBuilder) { }
            public override void Write(uint para_int) { }
            public override void Write(ulong para_long) { }
            public override void WriteLine() { }
            public override void WriteLine(bool para_bool) { }
            public override void WriteLine(char para_char) { }
            public override void WriteLine(char[]? para_chars) { }
            public override void WriteLine(char[] para_chars, int para_int1, int para_int2) { }
            public override void WriteLine(decimal para_decimal) { }
            public override void WriteLine(double para_double) { }
            public override void WriteLine(int para_int) { }
            public override void WriteLine(long para_long) { }
            public override void WriteLine(object? para_obj1) { }
            public override void WriteLine(ReadOnlySpan<Char> para_span_char) { }
            public override void WriteLine(Single para_single) { }
            public override void WriteLine(string? para_str) { }
            public override void WriteLine(string? para_str, object? para_obj1) { }
            public override void WriteLine(string? para_str, object? para_obj1, object? para_obj2) { }
            public override void WriteLine(string? para_str, object? para_obj1, object? para_obj2, object? para_obj3) { }
            public override void WriteLine(string? para_str, Object?[] para_objs) { }
            public override void WriteLine(StringBuilder? para_stringBuilder) { }
            public override void WriteLine(uint para_int) { }
            public override void WriteLine(ulong para_long) { }
        }
        #endregion

        public static void ExitOnLaunching(object? sender, EventArgs? args) =>
            Environment.Exit(6);

        #region Protobuf
        public static int GetUnknownFieldsSize(object message, Type prototype)
        {
            var log = Log.GetChannel(nameof(GetUnknownFieldsSize));
            var unkFieldSet_field = prototype.GetField("_unknownFields", BindingFlags.NonPublic | BindingFlags.Instance);
            if (unkFieldSet_field == null)
            {
                log.LogVerb($"Warn: unkFieldSet_field == null");
                return 0;
            }
            var unkFieldSet = (UnknownFieldSet?)unkFieldSet_field.GetValue(message);
            if (unkFieldSet == null)
            {
                log.LogVerb($"Warn: unkFieldSet == null");
                return 0;
            }
            return unkFieldSet.CalculateSize();
        }
        #endregion
    }
}
