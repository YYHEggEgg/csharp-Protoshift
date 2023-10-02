using System.Collections.ObjectModel;
using System.Diagnostics;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class CompiledEnumStringPoolManager
    {
        private ReadOnlyDictionary<string, string> originalToCompiledDict;

        private const string Compiled_AttributePrefix = "[pbr::OriginalName(\"";
        private const string Compiled_AttributeSuffix = "\")] ";
        private const string Compiled_AttributeSuffix_IsAlias = "\", PreferredAlias = false)] ";
        private const string Compiled_EnumValuePrefix = " = ";

        /// <summary>
        /// Initialize the StringPool map with a compiled enum code.
        /// </summary>
        /// <param name="compiled_enumproto_path">The compiled protobuf .cs file path.</param>
        /// <param name="start_lineNumber">The line that starts with <c>public enum</c>. Number starts with 1.</param>
        /// <param name="end_lineNumber">The line that contains a <c>}</c>. Number starts with 1.</param>
        /// <exception cref="ArgumentException">Compiled file part don't have the same enum record count as given.</exception>
        public CompiledEnumStringPoolManager(string[] compiled_enumproto_lines,
            int start_lineNumber, int end_lineNumber)
        {
            Dictionary<string, string> _compiledNameDict = new();
            #region Analyze compiled file
            for (int currentLine = start_lineNumber; currentLine <= end_lineNumber; currentLine++)
            {
                int arr_index = currentLine - 1;
                bool reachedPoolDataRegion = false;
                #region Data Region Manage
                if (currentLine < start_lineNumber || currentLine > end_lineNumber) continue;
                string? line = compiled_enumproto_lines[arr_index].Trim();
                if (line == null) continue;
                if (!reachedPoolDataRegion)
                {
                    if (!line.StartsWith(Compiled_AttributePrefix)) continue;
                    else
                    {
                        Log.Verb($"Reached Data Region at line {currentLine}.", nameof(CompiledEnumStringPoolManager));
                        reachedPoolDataRegion = true;
                    }
                }
                if (!line.StartsWith(Compiled_AttributePrefix))
                {
                    Log.Verb($"End of Data Region at line {currentLine}.", nameof(CompiledEnumStringPoolManager));
                    break;
                }
                #endregion
                var res = ReadValueFromCompiledFileLine(line);
                _compiledNameDict.Add(res.originalName, res.compiledName);
            }
            #endregion

            originalToCompiledDict = new(_compiledNameDict);
        }

        private (string originalName, string compiledName)
            ReadValueFromCompiledFileLine(string line)
        {
            #region Read original name
            int indexEndOriginalName = line.IndexOf('"', Compiled_AttributePrefix.Length);
            string originalName = line.Substring(
                Compiled_AttributePrefix.Length, indexEndOriginalName - Compiled_AttributePrefix.Length);
            #endregion
            #region Read Compiled name
            #region Judge IsAlias
            bool isAlias = line.IndexOf(Compiled_AttributeSuffix_IsAlias, indexEndOriginalName) != -1;
            #endregion
            int indexStartCompiledName = indexEndOriginalName +
                (isAlias ? Compiled_AttributeSuffix_IsAlias : Compiled_AttributeSuffix).Length;
            int indexEndCompiledName = line.IndexOf(
                Compiled_EnumValuePrefix, indexStartCompiledName);
            string compiledName = line.Substring(
                indexStartCompiledName, indexEndCompiledName - indexStartCompiledName);
            #endregion
            return (originalName, compiledName);
        }

        /// <summary>
        /// Get Compiled name from original protobuf field name. return null if not found. 
        /// </summary>
        public string? GetCompiledName(string fieldName)
        {
            if (originalToCompiledDict.TryGetValue(fieldName, out string? rtn))
                return rtn;
            else return null;
        }
    }

    public class CompiledEnumsStringPoolCollection
    {
        private Dictionary<string, CompiledEnumStringPoolManager> collection = new();

        /// <summary>
        /// Query a string pool with compiled enum name.
        /// </summary>
        /// <param name="compiled_name">The compiled name, can be identified with C# compiler but without namespace.</param>
        /// <returns></returns>
        public CompiledEnumStringPoolManager Query(string compiled_name)
        {
            return collection[compiled_name];
        }

        public void AddCodeFile(string code_fullPath)
        {
            string codefile_content = File.ReadAllText(code_fullPath);
            // not using Environment.NewLine here
            // maybe the code is generated LF and the platform provides CRLF
            var lines = codefile_content.Split('\n');
            CodeTree fullTree = CodeTreeBuilder.Build(codefile_content);
            var enumCodes = fullTree.GetPathsByType(CodeTreeQueryType.Enum);
            foreach (var enumCode in enumCodes)
            {
                collection.Add(enumCode.FullPath,
                    new(lines, enumCode.StartLine, enumCode.EndLine));
            }
        }
    }
}