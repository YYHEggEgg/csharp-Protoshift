 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class RebuildWatcher
    {
        private readonly List<DirectoryInfo> _directories = new List<DirectoryInfo>();
        private readonly Dictionary<string, Dictionary<string, string>> _fileHashes = new Dictionary<string, Dictionary<string, string>>();
        private bool _needRebuild = true;

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
            foreach (var file in dir.GetFiles("*", SearchOption.AllDirectories))
            {
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

            foreach (var dir in watcher._directories)
            {
                foreach (var file in dir.GetFiles("*", SearchOption.AllDirectories))
                {
                    var relativePath = GetRelativePath(file.FullName, dir.FullName);
                    if (data[dir.FullName].ContainsKey(relativePath))
                    {
                        var hash = GetFileHash(file.FullName);
                        if (hash != data[dir.FullName][relativePath])
                        {
                            watcher._needRebuild = true;
                            return watcher;
                        }
                    }
                    else
                    {
                        watcher._needRebuild = true;
                        return watcher;
                    }
                }
            }

            watcher._needRebuild = false;
            return watcher;
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
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}