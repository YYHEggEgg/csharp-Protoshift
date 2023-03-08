using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YYHEggEgg.Logger
{
    public enum LogLevel
    {
        Debug = 0,
        Information = 1,
        Warning = 2,
        Error = 3
    }

    public static class Log
    {
        #region Save
        public static string logPath;
        private static StreamWriter logwriter;
#if DEBUG
        public static string logPath_debug;
        private static StreamWriter logwriter_debug;
#endif
        static Log()
        {
            RefershLogTicks = 100;
            InputPrefix = "";
            string dir = Environment.CurrentDirectory;
            Directory.CreateDirectory("logs");

            #region Handle Past Log
            if (File.Exists("logs/latest.log"))
            {
                FileInfo info = new("logs/latest.log");
                File.Move("logs/latest.log", $"logs/{info.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.log");
            }
            if (File.Exists("logs/latest.debug.log"))
            {
                FileInfo info = new("logs/latest.debug.log");
                File.Move("logs/latest.debug.log", $"logs/{info.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.debug.log");
            }
            #endregion

            #region Compress Past Logs
            List<string> logs = new();
            string belongDate = "";
            foreach (var logfile in Directory.EnumerateFiles("logs"))
            {
                // Get Date
                FileInfo loginfo = new(logfile);
                string thisdate;
                if (loginfo.Extension != ".log" || loginfo.Name.Length < 10
                    || !DateTime.TryParse(thisdate = loginfo.Name.Substring(0, 10), out _))
                {
                    continue;
                }
                #region auto compress logs
                if (thisdate != belongDate)
                {
                    if (belongDate != "")
                    {
                        string cmd = $"a \"logs/log.{belongDate}.zip\"";
                        foreach (var log in logs)
                            cmd += $" \"{log}\"";
                        if (!OperatingSystem.IsWindows())
                        {
                            Console.WriteLine("Sorry but auto compress logs are only supported in Windows now.");
                        }
                        else
                        {
                            ProcessStartInfo startinfo = new();
                            startinfo.FileName = "7z";
                            startinfo.Arguments = cmd;
                            startinfo.RedirectStandardOutput = true;
                            startinfo.RedirectStandardError = true;
                            Process.Start(startinfo)?.WaitForExit();
                        }
                        // Delete original files
                        try
                        {
                            foreach (var log in logs)
                            {
                                File.Delete(log);
                            }
                            logs = new();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }
                    }
                    belongDate = thisdate;
                }
                #endregion
                logs.Add(logfile);
            }
            #endregion

            logPath = "logs/latest.log";
            logwriter = new(logPath, true);
            logwriter.AutoFlush = true;
#if DEBUG
            logPath_debug = "logs/latest.log";
            logwriter_debug = new(logPath_debug, true);
#endif
        }
        #endregion

        #region Refresh Prefix
        // Reference:
        // [ Can Console.Clear be used to only clear a line instead of whole console? ]
        // https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
        private static void ClearSingleLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        
        public static string InputPrefix { get; set; }
        private static bool AddPrefix;
        private static object PrefixLock = "YYHEggEgg.Logger";

        public static void BeginRegisterPrefix()
        {
            AddPrefix = true;
            lock (PrefixLock)
            {
                ClearSingleLine();
                Console.WriteLine(InputPrefix);
            }
        }

        public static void EndRegisterPrefix()
        {
            AddPrefix = false;
            lock (PrefixLock)
            {
                ClearSingleLine();
            }
        }
        #endregion

        #region Logger
        public static void Dbug(string content, string? sender = null)
        {
#if DEBUG
            qlog.Enqueue(new LogDetail(content, LogLevel.Debug, sender));
#endif
        }

        public static void Info(string content, string? sender = null)
            => qlog.Enqueue(new LogDetail(content, LogLevel.Information, sender));

        public static void Warn(string content, string? sender = null)
            => qlog.Enqueue(new LogDetail(content, LogLevel.Warning, sender));

        public static void Erro(string content, string? sender = null)
            => qlog.Enqueue(new LogDetail(content, LogLevel.Error, sender));

        #region Background Refresh
        public struct LogDetail 
        {
            public LogLevel level;
            public string content;
            public string? sender;
            public DateTime create_time;

            public LogDetail(LogLevel lvl, string con, string? snd)
            {
                level = lvl;
                content = con;
                sender = snd;
                create_time = DateTime.Now;
            }
        }

        private ConcurrentQueue<LogDetail> qlog;
        public int RefreshLogTicks { get; set; }
        
        private async Task BackgroundUpdate()
        {
            ClearSingleLine();
            while (qlog.TryDequeue(out LogDetail log))
            {
                WriteLog(log);
            }
            lock (PrefixLock)
            {
                Console.WriteLine(AddPrefix ? InputPrefix : string.Empty);
            }

            await Task.Wait(RefreshLogTicks);
            await Task.Run(BackgroundUpdate);
        }

        private static void WriteLog(LogDetail log)
        {
            string nowtime = log.create_time.ToString("HH:mm:ss");
            Console.Write(nowtime);
            string header = WriteAndGetLogInfo(level, sender);
            // content should < 16 KB, or not output to console
            if (content.Length < 16 * 1024)
                Console.WriteLine(content);
            else
                Console.WriteLine("[content too long (>16 KB), so not output to console]");
#if DEBUG
            if (log.level != LogLevel.Debug)
#endif
                logwriter.WriteLine($"{nowtime}{header}{content}");
#if DEBUG
            logwriter_debug.WriteLine($"{nowtime}{header}{content}");
#endif
        }
        #endregion

        /// <summary>
        /// Write info <[level]:[sender]> like <Info:KCP>. Notice: has side effect.
        /// </summary>
        private static string WriteAndGetLogInfo(LogLevel level, string? sender)
        {
            string rtn = " <";
            Console.Write(" <");
            switch (level)
            {
                case LogLevel.Debug:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Dbug");
                    rtn += "Dbug";
                    break;
                case LogLevel.Information:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Info");
                    rtn += "Info";
                    break;
                case LogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Warn");
                    rtn += "Warn";
                    break;
                case LogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Erro");
                    rtn += "Erro";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            if (sender != null)
            {
                Console.Write($":{sender}> ");
                rtn += $":{sender}> ";
            }
            else
            {
                Console.Write($"> ");
                rtn += $"> ";
            }
            return rtn;
        }
        #endregion
    }
}
