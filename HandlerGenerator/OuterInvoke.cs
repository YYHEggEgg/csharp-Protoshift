using System.Diagnostics;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public struct OuterInvokeInfo
    {
        /// <summary>
        /// The path of the executable.
        /// </summary>
        public string ProcessPath;
        /// <summary>
        /// The command line args that will be provided to the process.
        /// </summary>
        public string? CmdLine;
        /// <summary>
        /// The notice that will be send to the user when the invoke start.
        /// </summary>
        public string? StartingNotice;
        /// <summary>
        /// The reason for auto terminate. May be a complete sentence. <para/> 
        /// If it's given not null, the program will auto terminate before the method return.
        /// </summary>
        public string? AutoTerminateReason;
        /// <summary>
        /// The working directory of the program. The default value is <see cref="Environment.CurrentDirectory"/>.
        /// </summary>
        public string? WorkingDir;
    }

    public static class OuterInvoke
    {
        private static async Task<int> InnerRun(OuterInvokeInfo invokeInfo)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(
                invokeInfo.ProcessPath, invokeInfo.CmdLine ?? "")
            {
                WorkingDirectory = invokeInfo.WorkingDir ?? Environment.CurrentDirectory
            };
            if (invokeInfo.StartingNotice != null) Log.Info(invokeInfo.StartingNotice, nameof(OuterInvoke));
            Process? p = Process.Start(startInfo);
            await (p?.WaitForExitAsync() ?? Task.CompletedTask);
            return p?.ExitCode ?? int.MinValue;
        }

        /// <summary>
        /// Run a process with certain args and wait for exit.
        /// </summary>
        /// <param name="invokeInfo">The details of the invoke.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static async Task<int> Run(OuterInvokeInfo invokeInfo,
            int autoTerminateCode = -1)
        {
            var exitcode = await InnerRun(invokeInfo);
            if (exitcode != 0 && invokeInfo.AutoTerminateReason != null)
            {
                Log.Erro($"{invokeInfo.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return exitcode;
        }

        /// <summary>
        /// Run multiple processes with certain args and wait for exit.
        /// </summary>
        /// <param name="invokeInfo1">The details of the first invoke.</param>
        /// <param name="invokeInfo2">The details of the second invoke.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static async Task<int[]> RunMultiple(
            OuterInvokeInfo invokeInfo1, OuterInvokeInfo invokeInfo2,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[2];
            rtn[0] = await InnerRun(invokeInfo1);
            rtn[1] = await InnerRun(invokeInfo2);

            bool exiting = false;
            if (rtn[0] != 0 && invokeInfo1.AutoTerminateReason != null)
            {
                exiting = true;
                Log.Erro($"{invokeInfo1.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
            }
            if (rtn[1] != 0 && invokeInfo2.AutoTerminateReason != null)
            {
                exiting = true;
                Log.Erro($"{invokeInfo2.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }

        /// <summary>
        /// Run multiple processes with certain args and wait for exit.
        /// </summary>
        /// <param name="invokeInfo1">The details of the first invoke.</param>
        /// <param name="invokeInfo2">The details of the second invoke.</param>
        /// <param name="invokeInfo3">The details of the third invoke.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static async Task<int[]> RunMultiple(
            OuterInvokeInfo invokeInfo1, OuterInvokeInfo invokeInfo2, OuterInvokeInfo invokeInfo3,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[3];
            rtn[0] = await InnerRun(invokeInfo1);
            rtn[1] = await InnerRun(invokeInfo2);
            rtn[2] = await InnerRun(invokeInfo3);

            bool exiting = false;
            if (rtn[0] != 0 && invokeInfo1.AutoTerminateReason != null)
            {
                exiting = true;
                Log.Erro($"{invokeInfo1.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
            }
            if (rtn[1] != 0 && invokeInfo2.AutoTerminateReason != null)
            {
                exiting = true;
                Log.Erro($"{invokeInfo2.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
            }
            if (rtn[2] != 0 && invokeInfo3.AutoTerminateReason != null)
            {
                exiting = true;
                Log.Erro($"{invokeInfo3.AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }

        /// <summary>
        /// Syncronously run multiple processes with certain args and wait for exit.
        /// </summary>
        /// <param name="invokeInfos">The details of the invokes.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static async Task<int[]> RunMultiple(OuterInvokeInfo[] invokeInfos,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[invokeInfos.Length];
            for (int i = 0; i < invokeInfos.Length; i++)
            {
                rtn[i] = await InnerRun(invokeInfos[i]);
            }

            bool exiting = false;
            for (int i = 0; i < invokeInfos.Length; i++)
            {
                if (rtn[i] != 0 && invokeInfos[i].AutoTerminateReason != null)
                {
                    exiting = true;
                    Log.Erro($"{invokeInfos[i].AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
                }
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }
    
        
        /// <summary>
        /// Syncronously run multiple processes with certain args and wait for exit.
        /// </summary>
        /// <param name="invokeInfos">The details of the invokes.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static async Task<int[]> RunMultiple(List<OuterInvokeInfo> invokeInfos,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[invokeInfos.Count];
            for (int i = 0; i < invokeInfos.Count; i++)
            {
                rtn[i] = await InnerRun(invokeInfos[i]);
            }

            bool exiting = false;
            for (int i = 0; i < invokeInfos.Count; i++)
            {
                if (rtn[i] != 0 && invokeInfos[i].AutoTerminateReason != null)
                {
                    exiting = true;
                    Log.Erro($"{invokeInfos[i].AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
                }
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }
    
        /// <summary>
        /// Run multiple processes parallel with certain args and wait for exit. Notice: may cause unexpected behaviour.
        /// </summary>
        /// <param name="invokeInfos">The details of the invokes.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static int[] RunParallel(OuterInvokeInfo[] invokeInfos,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[invokeInfos.Length];
            Parallel.For(0, invokeInfos.Length, async (i) =>
            {
                rtn[i] = await InnerRun(invokeInfos[i]);
            });

            bool exiting = false;
            for (int i = 0; i < invokeInfos.Length; i++)
            {
                if (rtn[i] != 0 && invokeInfos[i].AutoTerminateReason != null)
                {
                    exiting = true;
                    Log.Erro($"{invokeInfos[i].AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
                }
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }
    
        /// <summary>
        /// Run multiple processes parallel with certain args and wait for exit. Notice: may cause unexpected behaviour.
        /// </summary>
        /// <param name="invokeInfos">The details of the invokes.</param>
        /// <param name="autoTerminateCode">The exut code for the program's auto terminate.</param>
        /// <returns>The exit code of the program.</returns>
        public static int[] RunParallel(List<OuterInvokeInfo> invokeInfos,
            int autoTerminateCode = -1)
        {
            int[] rtn = new int[invokeInfos.Count];
            Parallel.For(0, invokeInfos.Count, async (i) =>
            {
                rtn[i] = await InnerRun(invokeInfos[i]);
            });

            bool exiting = false;
            for (int i = 0; i < invokeInfos.Count; i++)
            {
                if (rtn[i] != 0 && invokeInfos[i].AutoTerminateReason != null)
                {
                    exiting = true;
                    Log.Erro($"{invokeInfos[i].AutoTerminateReason} failed. Exit code is {autoTerminateCode}. ", "OuterInvoke");
                }
            }
            if (exiting)
            {
                Log.Info("Press any key to exit...");
                Console.ReadLine();
                Environment.Exit(autoTerminateCode);
            }
            return rtn;
        }
    }
}