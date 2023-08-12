using CommandLine;
using System.Text;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Commands
{
    internal abstract class CommandHandlerBase
    {
        public static List<string> ParseAsArgs(string cmd)
        {
            List<string> argv = new List<string>();
            bool inQuotes = false;
            bool escaped = false;
            string currentArg = "";

            foreach (char c in cmd)
            {
                if (c == ' ' || c == '\t')
                {
                    if (inQuotes)
                    {
                        currentArg += c;
                    }
                    else if (currentArg != "")
                    {
                        argv.Add(currentArg);
                        currentArg = "";
                    }
                }
                else if (c == '"')
                {
                    if (escaped)
                    {
                        currentArg += c;
                        escaped = false;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == '\\')
                {
                    if (escaped)
                    {
                        currentArg += c;
                        escaped = false;
                    }
                    else
                    {
                        escaped = true;
                    }
                }
                else
                {
                    if (escaped)
                    {
                        currentArg += '\\';
                    }
                    currentArg += c;
                    escaped = false;
                }
            }

            if (currentArg != "")
            {
                argv.Add(currentArg);
            }

            return argv;
        }

        public abstract string CommandName { get; }
        /// <summary>
        /// A brief and one-line description of this command.
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// Basic usage of this command. You can put multiple lines here.
        /// </summary>
        public abstract string Usage { get; }
        /// <summary>
        /// Command Handler. Note that the method may invoke Log.Info or so on to output messages. The Command Dispatch won't do it.
        /// </summary>
        /// <param name="args"></param>
        public abstract Task HandleAsync(string argList);
        public virtual void CleanUp() { }

        public virtual void ShowUsage()
        {
            Log.Info($"Command '{CommandName}': {Description}", CommandName);
            string[] help = Usage.Split(Environment.NewLine);
            foreach (var line in help) Log.Info(line, CommandName);
        }
    }

    internal class LogTextWriter : TextWriter
    {
        public override Encoding Encoding => Encoding.UTF8;

        private StringBuilder writebuf = new();

        public override void Write(char value)
        {
            if (value == '\n')
            {
                Log.Info(writebuf.ToString(), nameof(LogTextWriter));
                writebuf.Clear();
            }
            else writebuf.Append(value);
        }
    }

    /// <summary>
    /// A more standard command handle using <see cref="Parser"/>.
    /// </summary>
    /// <typeparam name="TCmdOption"></typeparam>
    internal abstract class StandardCommandHandler<TCmdOption> : CommandHandlerBase
    {
        /// <summary>
        /// Command Handler, using <see cref="TCmdOption"/>.
        /// </summary>
        /// <param name="cmdOption"></param>
        /// <returns></returns>
        public abstract Task HandleAsync(TCmdOption o);

        /// <summary>
        /// Handle the errors happened in the command args parsing. In most cases, it don't need to be overriden.
        /// </summary>
        /// <param name="errors"></param>
        public virtual void HandleInvalidUsage(IEnumerable<Error> errors)
        {
            Log.Erro("Unrecognized args detected. Please check your input.", nameof(StandardCommandHandler<TCmdOption>));
            ShowUsage();
            throw new AccessViolationException();
        }

        public override async Task HandleAsync(string argList)
        {
            var args = ParseAsArgs(argList);
            var cmd_parser = new Parser(config =>
            {
                // 在构建时设置自定义 ConsoleWriter
                config.HelpWriter = new LogTextWriter();
            });
            try
            {
                await cmd_parser.ParseArguments<TCmdOption>(args)
                    .WithNotParsed(errs => HandleInvalidUsage(errs))
                    .WithParsedAsync(opt => HandleAsync(opt));
            }
            catch (AccessViolationException) { }
        }
    }
}