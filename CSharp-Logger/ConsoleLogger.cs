using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger.Utils;

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
        public static readonly string logdirPath = AppDomain.CurrentDomain.BaseDirectory;

        public static string logPath;
        private static StreamWriter logwriter;
#if DEBUG
        public static string logPath_debug;
        private static StreamWriter logwriter_debug;
#endif
        static Log()
        {
            RefreshLogTicks = 100;
            string dir = Environment.CurrentDirectory;
            Directory.CreateDirectory($"{logdirPath}/logs");

            #region Handle Past Log
            if (File.Exists($"{logdirPath}/logs/latest.log"))
            {
                FileInfo info = new($"{logdirPath}/logs/latest.log");
                File.Move($"{logdirPath}/logs/latest.log", 
                    $"{logdirPath}/logs/{info.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.log");
            }
            if (File.Exists($"{logdirPath}/logs/latest.debug.log"))
            {
                FileInfo info = new($"{logdirPath}/logs/latest.debug.log");
                File.Move($"{logdirPath}/logs/latest.debug.log", 
                    $"{logdirPath}/logs/{info.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.debug.log");
            }
            #endregion

            #region Compress Past Logs
            List<string> logs = new();
            string belongDate = "";
            foreach (var logfile in Directory.EnumerateFiles($"{logdirPath}/logs"))
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
                        string newzipfile = Tools.AddNumberedSuffixToPath(
                            $"{logdirPath}/logs/log.{belongDate}.zip");
                        Tools.CompressFiles(newzipfile, logs);
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
#if DEBUG
                            Console.WriteLine(ex);
#endif
                        }
                    }
                    belongDate = thisdate;
                }
                #endregion
                logs.Add(logfile);
            }
            #endregion

            logPath = $"{logdirPath}/logs/latest.log";
            logwriter = new(logPath, true);
            logwriter.AutoFlush = true;
#if DEBUG
            logPath_debug = $"{logdirPath}/logs/latest.debug.log";
            logwriter_debug = new(logPath_debug, true);
#endif

            Task.Run(BackgroundUpdate);
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

            public LogDetail(string con, LogLevel lvl, string? snd)
            {
                level = lvl;
                content = con;
                sender = snd;
                create_time = DateTime.Now;
            }
        }

        private static ConcurrentQueue<LogDetail> qlog = new();
        public static int RefreshLogTicks { get; set; }

        private static async Task BackgroundUpdate()
        {
            if (!qlog.TryDequeue(out LogDetail _log))
            {
                await Task.Delay(RefreshLogTicks);
                await Task.Run(BackgroundUpdate);
                return;
            }

            List<string> logs = new(qlog.Count + 1);
            logs.Add(WriteLog(_log));
            while (qlog.TryDequeue(out LogDetail log))
            {
                logs.Add(WriteLog(log));
            }
            ConsoleWrapper.WriteLine(logs);  

            await Task.Delay(RefreshLogTicks);
            await Task.Run(BackgroundUpdate);
        }

        private static string WriteLog(LogDetail log)
        {
            string nowtime = log.create_time.ToString("HH:mm:ss");
            string header = GetLogInfo(log.level, log.sender);
            string res = $"{nowtime}{header}{log.content}";
            if (ConsoleWrapper.TryRemoveColorInfo(res, out string fileres))
            {
#if DEBUG
                if (log.level != LogLevel.Debug)
#endif
                    logwriter.WriteLine(fileres);
#if DEBUG
                logwriter_debug.WriteLine(fileres);
#endif
            }
            else
            {
                logwriter.WriteLine($"{nowtime}{header}{GetLogInfo(LogLevel.Error, "Logger")}" +
                    $"Content has caused exception when resolving color, ex={fileres}; content={res};");
            }

            // content should < 16 KB, or not output to console
            if (log.content.Length < 16 * 1024)
                return res;
            else
                return $"{nowtime}{header}[content too long (>16 KB), so not output to console]";
        }
        #endregion

        /// <summary>
        /// Write info <[level]:[sender]> like <Info:KCP>. 
        /// </summary>
        private static string GetLogInfo(LogLevel level, string? sender)
        {
            string rtn = " <";
            switch (level)
            {
                case LogLevel.Debug:
                    rtn += "<color=Cyan>Dbug</color>";
                    break;
                case LogLevel.Information:
                    rtn += "<color=Blue>Info</color>";
                    break;
                case LogLevel.Warning:
                    rtn += "<color=Yellow>Warn</color>";
                    break;
                case LogLevel.Error:
                    rtn += "<color=Red>Erro</color>";
                    break;
            }
            if (sender != null)
            {
                rtn += $":{sender}> ";
            }
            else
            {
                rtn += $"> ";
            }
            return rtn;
        }
        #endregion
    }
}
