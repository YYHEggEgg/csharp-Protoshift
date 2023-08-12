using System.Text.RegularExpressions;
using YYHEggEgg.Logger;
using System.Text;

namespace csharp_Protoshift
{
    /// <summary>
    /// Automatically judge base64, hex, json data and read them.
    /// </summary>
    public static class EasyInput
    {
        public const string MultipleInputNotice =
            "If you want to input a long bin data and don't want to waste too much time " +
            "on auto-detecting base64, HEX or json, add '<color=Yellow>b-</color>', " +
            "'<color=Yellow>h-</color>' or '<color=Yellow>j-</color>' at the start.";

        /// <summary>
        /// Show a notice that instructs how the user can input the content.
        /// </summary>
        /// <param name="msgLevel"></param>
        public static void ShowInputNotice(LogLevel msgLevel = LogLevel.Information)
            => Log.PushLog(MultipleInputNotice, msgLevel, nameof(EasyInput));

        /// <summary>
        /// Process a string and return the judge result.
        /// </summary>
        /// <param name="content">The content.</param>
        public static EasyInputResult TryPreProcess(string? content)
        {
            if (string.IsNullOrWhiteSpace(content)) 
                return new EasyInputResult { InputType = EasyInputType.IdentifyFailure };
            string input = content.Replace("\r\n", "").Replace("\n", "").Trim();
            #region Strictly defined
            if (input.StartsWith("h-"))
            {
                Log.Info("User defined HEX input!");
                return new EasyInputResult { InputType = EasyInputType.Hex, 
                    ProcessedString = input.Substring(2).TrimStart() };
            }
            else if (input.StartsWith("b-"))
            {
                Log.Info("User defined Base64 input!");
                return new EasyInputResult { InputType = EasyInputType.Base64,
                    ProcessedString = input.Substring(2).TrimStart() };
            }
            else if (input.StartsWith("j-"))
            {
                Log.Info("User defined Json input!");
                return new EasyInputResult { InputType = EasyInputType.Json,
                    ProcessedString = input.Substring(2).TrimStart() };
            }
            #endregion
            #region Auto detect
            else if ((input.StartsWith('{') && input.EndsWith('}')) ||
                            (input.StartsWith('[') && input.EndsWith(']')))
            {
                Log.Info("Detected Json input!", nameof(EasyInput));
                return new EasyInputResult { InputType = EasyInputType.Json, ProcessedString = input };
            }
            else if (IsBase64(input))
            {
                Log.Info("Detected Base64 input!", nameof(EasyInput));
                return new EasyInputResult { InputType = EasyInputType.Base64, ProcessedString = input };
            }
            else
            {
                Log.Info("Detected Hex input!", nameof(EasyInput));
                return new EasyInputResult { InputType = EasyInputType.Hex, ProcessedString = input };
            }
            #endregion
        }

        /// <summary>
        /// Process a string and return the judge result.
        /// </summary>
        /// <param name="args">The command line args, which will be <see cref="string.Concat(IEnumerable{string?})"/>ed together before processing.</param>
        /// <param name="offset">The array offset.</param>
        public static EasyInputResult TryPreProcess(string?[] args, int offset = 0)
        {
            string[] innerargs = new string[args.Length - offset];
            if (args.Length > offset)
            {
                Array.Copy(args, offset, innerargs, 0, args.Length - offset);
            }
            return TryPreProcess(string.Concat(innerargs));
        }

        /// <summary>
        /// Process a string and return the judge result.
        /// </summary>
        /// <param name="args">The command line args, which will be <see cref="string.Concat(IEnumerable{string?})"/>ed together before processing.</param>
        /// <param name="offset">The array offset.</param>
        public static EasyInputResult TryPreProcess(List<string> args, int offset = 0)
        {
            string[] innerargs = new string[args.Count - offset];
            if (args.Count > offset)
            {
                for (int i = 0; i < args.Count - offset; i++)
                {
                    innerargs[i] = args[offset + i];
                }
            }
            return TryPreProcess(string.Concat(innerargs));
        }

        /// <summary>
        /// Return the decrypt result for <see cref="EasyInputType.Base64"/> and 
        /// <see cref="EasyInputType.Hex"/>; return <see cref="Encoding.GetByteCount(string)"/>
        /// for <see cref="EasyInputType.Json"/>.
        /// </summary>
        /// <param name="preprocessed"></param>
        /// <returns></returns>
        public static byte[] ToByteArray(this EasyInputResult preprocessed)
        {
            if (preprocessed.ProcessedString == null)
                throw new ArgumentException("Using an instance that failed to process.", nameof(preprocessed));
            switch (preprocessed.InputType)
            {
                case EasyInputType.Json:
                    return Encoding.UTF8.GetBytes(preprocessed.ProcessedString);
                case EasyInputType.Base64:
                    return Convert.FromBase64String(preprocessed.ProcessedString);
                case EasyInputType.Hex:
                    return Convert.FromHexString(preprocessed.ProcessedString);
                case EasyInputType.IdentifyFailure:
                    throw new ArgumentException("Can't identify the input type.", nameof(preprocessed));
                default:
                    throw new NotImplementedException($"Input Type {preprocessed.InputType} hasn't been supported.");
            }
        }

        // 只要字符串包含g/G以后的字母（“以后”遵循字母表顺序，
        // 无论大小写，包含g/G）一个及以上，则一定为base64串
        private static Regex base64worker = new("^.*[g-zG-Z].*$", 
            RegexOptions.Compiled | RegexOptions.Singleline, TimeSpan.FromMilliseconds(2000));
        // 如果字符串的字母只同时为大写/小写（也就是说，字符串中除去
        // 数字以后，剩下的字符要么全为大写要么全为小写），则判定为HEX串
        private static Regex hexworker = new("(^[A-F0-9]*$)|(^[a-f0-9]*$)", 
            RegexOptions.Compiled | RegexOptions.Singleline, TimeSpan.FromMilliseconds(3000));

        private static bool IsBase64(string input)
        {
            if (input.EndsWith('=')) return true;
            if (input.Contains('+') || input.Contains('/')) return true;
            try
            {
                if (base64worker.IsMatch(input)) return true;
            }
            catch (RegexMatchTimeoutException) { }

            try
            {
                if (!hexworker.IsMatch(input)) return true;
            }
            catch (RegexMatchTimeoutException ex)
            {
                throw new RegexMatchTimeoutException("Auto-detect input format exceeded timeout of 5s. " +
                    "Please explicitly specifiy the input format by adding " +
                    "'<color=Yellow>b-</color>' or '<color=Yellow>h-</color>'" +
                    " at the start and retry.", ex);
            }
            return false;
        }
    }

    public enum EasyInputType
    {
        IdentifyFailure = 0,
        Base64 = 1,
        Hex = 2,
        Json = 3,
    }

    public struct EasyInputResult
    {
        public EasyInputType InputType;
        public string? ProcessedString;
    }
}
