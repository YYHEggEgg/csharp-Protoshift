using System.Reflection;

namespace AssetLib.Managers
{
    public static class FormatManager
    {
        private static Dictionary<string, Format> Formats = new();
        static FormatManager()
        {
            foreach (Type type in
                Assembly.GetAssembly(typeof(Format)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Format))))
            {
                var format = (Format)Activator.CreateInstance(type);
                Formats.Add(format.Name, format);
            }
        }
        public static Format GetFormat(string name)
        {
            if (!Formats.TryGetValue(name, out var format))
            {
                throw new ArgumentException("Invalid Format !!");
            }

            return format;
        }
        public static string ToString() => string.Join("\n", Formats.Values);
        public static Format[] GetFormats() => Formats.Values.ToArray();
        public static string[] GetSupportedFormats() => Formats.Values.Select(x => x.Name).ToArray();
    }
    public abstract class Format
    {
        public string Name;
        public string DisplayName;
        public (string, string) Pattern;
        public (string, string) Extension;
        protected abstract void Decrypt(string input, string output);
        protected abstract void Encrypt(string input, string output);
        protected virtual (string, string)[] CollectPaths(string input, string output, bool isEncrypt)
        {
            if (File.Exists(input))
            {
                var extension = isEncrypt ? Extension.Item2 : Extension.Item1;
                var fileName = $"{Path.GetFileNameWithoutExtension(input)}{extension}";
                Directory.CreateDirectory(output);
                return new (string, string)[] { (input, Path.Combine(output, fileName)) };
            }
            var files = Directory.GetFiles(input, isEncrypt ? Pattern.Item2 : Pattern.Item1, SearchOption.AllDirectories);
            var paths = new List<(string, string)>();
            foreach (var file in files)
            {
                var relativePath = Path.GetRelativePath(input, file);
                relativePath = Path.ChangeExtension(relativePath, isEncrypt ? Extension.Item2 : Extension.Item1);
                var outPath = Path.Combine(output, relativePath);
                Directory.CreateDirectory(output);
                paths.Add((file, outPath));
            }
            return paths.ToArray();

        }
        public void Process(string input, string output, bool isEncrypt)
        {
            if (!IsSupported(isEncrypt))
            {
                throw new NotImplementedException();
            }
            var paths = CollectPaths(input, output, isEncrypt);
            var count = paths.Length;
            Console.WriteLine($"Found {count} file(s).");
            for (int i = 0; i < count; i++)
            {
                var pair = paths[i];

                if (isEncrypt)
                    Encrypt(pair.Item1, pair.Item2);
                else
                    Decrypt(pair.Item1, pair.Item2);

                Console.WriteLine($"Processed [{i + 1}/{count}] file(s).");
            }
        }
        protected void WriteOutput(string output, byte[] buffer)
        {
            File.WriteAllBytes(output, buffer);
        }
        public override string ToString() => DisplayName;
        private bool IsSupported(bool isEncrypt) => !string.IsNullOrEmpty(isEncrypt ? Pattern.Item2 : Pattern.Item1) || !string.IsNullOrEmpty(isEncrypt ? Extension.Item2 : Extension.Item1);
    }
}
