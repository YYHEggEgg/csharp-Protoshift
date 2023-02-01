﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift
{
    internal enum LogLevel
    {
        Information = 1,
        Warning = 2,
        Error = 3
    }

    internal static class Log
    {
        #region Save
        public static string logPath;
        private static StreamWriter logwriter;
        static Log()
        {
            string dir = Environment.CurrentDirectory;
            Directory.CreateDirectory("logs");

            #region Handle Past Log
            if (File.Exists("logs/latest.log"))
            {
                FileInfo info = new("logs/latest.log");
                File.Move("logs/latest.log", $"logs/{info.LastWriteTime:yyyy-MM-dd_HH-mm-ss}.log");
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
                            Process.Start(startinfo).WaitForExit();
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
        }
        #endregion

        #region Logger
        public static void Info(string content, string? sender = null)
            => WriteLog(content, LogLevel.Information, sender);

        public static void Warn(string content, string? sender = null)
            => WriteLog(content, LogLevel.Warning, sender);

        public static void Erro(string content, string? sender = null)
            => WriteLog(content, LogLevel.Error, sender);

        private static void WriteLog(string content, LogLevel level, string? sender = null)
        {
            string nowtime = DateTime.Now.ToString("HH:mm:ss");
            Console.Write(nowtime);
            string header = WriteAndGetLogInfo(level, sender);
            Console.WriteLine(content);
            logwriter.WriteLine($"{nowtime}{header}{content}");
        }

        /// <summary>
        /// Write info <[level]:[sender]> like <Info:KCP>. Notice: has side effect.
        /// </summary>
        private static string WriteAndGetLogInfo(LogLevel level, string? sender)
        {
            string rtn = " <";
            Console.Write(" <");
            switch (level)
            {
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
            return rtn;
        }
        #endregion
    }
}
