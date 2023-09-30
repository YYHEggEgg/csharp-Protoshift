using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

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

    public static async Task<T?> DeserializeFileAsync<T>(string filePath) where T : class =>
        JsonSerializer.Deserialize<T>(await File.ReadAllTextAsync(filePath), new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            ReadCommentHandling = JsonCommentHandling.Skip
        });

    public static bool DirNonExistsOrEmpty(string dirPath)
    {
        if (!Directory.Exists(dirPath)) return true;
        if (!Directory.EnumerateFiles(dirPath).Any() &&
            !Directory.EnumerateDirectories(dirPath).Any()) return true;
        return false;
    }
}