using System.Diagnostics;
using System.Reflection;

namespace csharp_Protoshift.Enhanced.Handlers.Generator;

internal static class Tools
{
    public static readonly string ProgramVersion =
        Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "<unknown version>";

    public static string? GetContentFromExecute(string processPath, string workingDir, string commandLine)
    {
        ProcessStartInfo startInfo = new(processPath)
        {
            WorkingDirectory = workingDir,
            Arguments = commandLine,
            RedirectStandardOutput = true
        };
        try
        {
            var p = Process.Start(startInfo);
            string? rtnvalue = null;
            p.WaitForExit();
            if (p.ExitCode != 0) return null;
            rtnvalue = p.StandardOutput.ReadToEnd();
            if (rtnvalue == string.Empty) return null;
            return rtnvalue?.Trim();
        }
        catch { return null; }
    }

    public static void CopyDir(string source, string target) => 
        CopyFilesRecursively(Path.GetFullPath(source), Path.GetFullPath(target));

    // .net - Copy the entire contents of a directory in C#
    // https://stackoverflow.com/questions/58744/copy-the-entire-contents-of-a-directory-in-c-sharp
    public static void CopyFilesRecursively(string sourcePath, string targetPath)
    {
        //Now Create all of the directories
        foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
        {
            Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
        }

        //Copy all the files & Replaces any files with the same name
        foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
        {
            File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
        }
    }
}