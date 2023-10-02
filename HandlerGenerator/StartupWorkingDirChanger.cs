using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    internal static class StartupWorkingDirChanger
    {
        public const string? Required_file = "./HandlerGenerator.csproj";
        public const string? Required_directory = "./../csharp-Protoshift/resources";

        public const string Terminating_Note = "Can't find source code path. Please run this program with dotnet run. \n" +
            "***********WARNING**********\n" +
            "DO NOT USE --project PARAM! USE cd COMMAND INSTEAD!\n" +
            "***********WARNING**********";

        public static void ChangeToDotNetRunPath(LoggerConfig log_init_config)
        {
            string before_workingdir = Environment.CurrentDirectory;
            string after_workingdir;
            if (CheckForRequirements())
            {
                after_workingdir = before_workingdir;
            }
            else
            {
                var program_path = AppDomain.CurrentDomain.BaseDirectory;
                after_workingdir = GetParentDirectory(program_path, 4);
            }

            if (Directory.Exists(after_workingdir) && CheckForRequirements(after_workingdir))
            {
                Environment.CurrentDirectory = after_workingdir;
                Log.Initialize(log_init_config);
                Log.Dbug($"Startup Current directory is: {before_workingdir}.");
                Log.Dbug($"Changed Current directory to: {after_workingdir}.");
            }
            else
            {
                Log.Initialize(log_init_config);
                Log.Warn($"Startup Current directory is: {before_workingdir}.");
                Log.Warn($"Found Current directory is: {after_workingdir}.");
                Log.Erro(Terminating_Note, nameof(StartupWorkingDirChanger));
                Log.Erro("Process terminated for false launch. Exit code is 4206.", nameof(StartupWorkingDirChanger));
                // if (log_init_config.Use_Console_Wrapper)
                //     ConsoleWrapper.ReadLine();
                // else Console.ReadLine();
                Environment.Exit(4206);
            }
        }

        private static bool CheckForRequirements(string? dir = null)
        {
            dir ??= Environment.CurrentDirectory;
            if (Required_file != null && !File.Exists($"{dir}/{Required_file}")) return false;
            if (Required_directory != null && !Directory.Exists($"{dir}/{Required_directory}")) return false;
            return true;
        }

        private static string GetParentDirectory(string? base_dir, int parent_level)
        {
            if (base_dir == null) return string.Empty;
            if (parent_level == 0) return base_dir;
            return GetParentDirectory(Directory.GetParent(base_dir)?.FullName, parent_level - 1);
        }
    }
}