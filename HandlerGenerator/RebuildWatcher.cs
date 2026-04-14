using Newtonsoft.Json;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class RebuildWatcher
    {
        private readonly List<DirectoryInfo> _directories = new List<DirectoryInfo>();
        private readonly Dictionary<string, Dictionary<string, string>> _fileHashes = new Dictionary<string, Dictionary<string, string>>();
        private bool _needRebuild = true;

        /// <summary>
        /// Key: normalized working-directory-relative path with forward-slash separators
        /// (see <see cref="GetDirectoryKey"/>). Value: list of relative file paths that
        /// changed since the last captured snapshot.
        /// </summary>
        public readonly Dictionary<string, List<string>> rebuild_files_relative_list = new();

        /// <summary>
        /// Returns the canonical key used in <see cref="rebuild_files_relative_list"/>:
        /// a path relative to the current working directory with forward-slash separators.
        /// Accepts both absolute paths and relative paths in any format.
        /// </summary>
        public static string GetDirectoryKey(string dirPath)
        {
            return Path.GetRelativePath(Environment.CurrentDirectory, Path.GetFullPath(dirPath))
                       .Replace(Path.DirectorySeparatorChar, '/');
        }

        /// <summary>
        /// 无参构造器
        /// </summary>
        public RebuildWatcher()
        {
        }

        /// <summary>
        /// 记录文件夹中的各个文件状态
        /// </summary>
        /// <param name="dirPath">文件夹路径</param>
        public void CaptureDirectory(string dirPath)
        {
            var dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException($"Directory {dirPath} not found.");
            }

            _directories.Add(dir);

            var key = GetDirectoryKey(dir.FullName);
            var dirData = new Dictionary<string, string>();
            foreach (var file in dir.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                if (file.FullName.Contains($".git{Path.DirectorySeparatorChar}")) continue;
                var relativePath = GetRelativePath(file.FullName, dir.FullName);
                dirData[relativePath] = GetFileHash(file.FullName);
            }
            _fileHashes[key] = dirData;
        }

        /// <summary>
        /// 返回一个 Json 字符串，记录当前的状态。它必须可以被反序列化。
        /// </summary>
        /// <returns>Json 字符串</returns>
        public string SerializeToJson()
        {
            var data = new Dictionary<string, Dictionary<string, string>>();
            foreach (var dir in _directories)
            {
                var key = GetDirectoryKey(dir.FullName);
                data[key] = _fileHashes[key];
            }

            return JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// 从 Json 字符串中反序列化出一个 RebuildWatcher 实例
        /// </summary>
        /// <param name="json">Json 字符串</param>
        /// <returns>RebuildWatcher 实例</returns>
        public static RebuildWatcher DeserializeFromJson(string json)
        {
            var rawData = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json)!;
            var watcher = new RebuildWatcher();

            // Normalize all keys from the JSON snapshot: transparently handles both
            // the legacy format (absolute paths) and the current format (CWD-relative
            // paths with forward slashes). GetDirectoryKey accepts either form.
            var data = new Dictionary<string, Dictionary<string, string>>();
            foreach (var kvp in rawData)
                data[GetDirectoryKey(kvp.Key)] = kvp.Value;

            foreach (var key in data.Keys)
                watcher.CaptureDirectory(key);

            watcher._needRebuild = false;

            foreach (var dir in watcher._directories)
            {
                var key = GetDirectoryKey(dir.FullName);
                watcher.rebuild_files_relative_list.Add(key, new());
                foreach (var file in dir.GetFiles("*", SearchOption.AllDirectories))
                {
                    if (file.FullName.Contains($".git{Path.DirectorySeparatorChar}")) continue;
                    var relativePath = GetRelativePath(file.FullName, dir.FullName);
                    if (data[key].TryGetValue(relativePath, out var storedHash))
                    {
                        if (GetFileHash(file.FullName) != storedHash)
                        {
                            watcher._needRebuild = true;
                            watcher.rebuild_files_relative_list[key].Add(relativePath);
                        }
                    }
                    else
                    {
                        watcher._needRebuild = true;
                        watcher.rebuild_files_relative_list[key].Add(relativePath);
                    }
                }
            }

            return watcher;
        }

        private static bool DataEqual(Dictionary<string, Dictionary<string, string>> left, Dictionary<string, Dictionary<string, string>> right)
        {
            //判断两个字典中的键值对是否相等
            if (!CollectionEqual(left.Keys, right.Keys))
            {
                return false;
            }
            foreach (var item in left)
            {
                if (!right.TryGetValue(item.Key, out var rightValue))
                {
                    return false;
                }
                if (!CollectionEqual(item.Value.Keys, rightValue.Keys))
                {
                    return false;
                }
                if (!CollectionEqual(item.Value.Values, rightValue.Values))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CollectionEqual(ICollection<string> left, ICollection<string> right)
        {
            if (left.Count != right.Count) return false;
            SortedSet<string> lset = new(left);
            return lset.SetEquals(right);
        }

        /// <summary>
        /// 从无参构造器中构造时默认为 true。
        /// </summary>
        public bool NeedRebuild
        {
            get => _needRebuild;
            private set => _needRebuild = value;
        }

        private static string GetRelativePath(string fullPath, string basePath)
        {
            return Path.GetRelativePath(basePath, fullPath);
        }

        private static string GetFileHash(string filePath)
        {
            /*using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }*/
            var info = new FileInfo(filePath);
            return $"{filePath};len:{info.Length}b;crt_time:{info.CreationTimeUtc:yyyyMMdd-HHmmss.fffffff};mod_time:{info.LastWriteTimeUtc:yyyyMMdd-HHmmss.fffffff};";
        }
    }
}