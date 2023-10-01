using Newtonsoft.Json;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class RebuildWatcher
    {
        private readonly List<DirectoryInfo> _directories = new List<DirectoryInfo>();
        private readonly Dictionary<string, Dictionary<string, string>> _fileHashes = new Dictionary<string, Dictionary<string, string>>();
        private bool _needRebuild = true;

        /// <summary>
        /// The key of dictionary is not relative, but the value in list is relative.
        /// </summary>
        public readonly Dictionary<string, List<string>> rebuild_files_relative_list = new();

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

            var dirData = new Dictionary<string, string>();
            foreach (var file in dir.EnumerateFiles("*", SearchOption.AllDirectories))
            {
                if (file.FullName.Contains($".git{Path.DirectorySeparatorChar}")) continue;
                var relativePath = GetRelativePath(file.FullName, dir.FullName);
                dirData[relativePath] = GetFileHash(file.FullName);
            }
            _fileHashes[dir.FullName] = dirData;
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
                data[dir.FullName] = _fileHashes[dir.FullName];
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
            var data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(json);
            var watcher = new RebuildWatcher();

            foreach (var dirPath in data.Keys)
            {
                watcher.CaptureDirectory(dirPath);
            }

            watcher._needRebuild = false;

            foreach (var dir in watcher._directories)
            {
                watcher.rebuild_files_relative_list.Add(dir.FullName, new());
                foreach (var file in dir.GetFiles("*", SearchOption.AllDirectories))
                {
                    if (file.FullName.Contains($".git{Path.DirectorySeparatorChar}")) continue;
                    var relativePath = GetRelativePath(file.FullName, dir.FullName);
                    if (data[dir.FullName].ContainsKey(relativePath))
                    {
                        var hash = GetFileHash(file.FullName);
                        if (hash != data[dir.FullName][relativePath])
                        {
                            watcher._needRebuild = true;
                            watcher.rebuild_files_relative_list[dir.FullName].Add(relativePath);
                        }
                    }
                    else
                    {
                        watcher._needRebuild = true;
                        watcher.rebuild_files_relative_list[dir.FullName].Add(relativePath);
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