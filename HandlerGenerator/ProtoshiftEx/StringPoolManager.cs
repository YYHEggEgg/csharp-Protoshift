using System.Collections.ObjectModel;
using System.Diagnostics;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public class ProtocStringPoolManager
    {
        #region String Pool file related
        private StreamWriter[] files;
        public ProtocStringPoolManager()
        {
            files = new StreamWriter[3]
            {
                new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/GeneratedProtos/StringPool1.proto"),
                new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/GeneratedProtos/StringPool2.proto"),
                new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/GeneratedProtos/StringPool3.proto")
            };
            WriteLine("syntax = \"proto3\"");
            files[0].WriteLine("enum StringPool1 { ");
            files[1].WriteLine("enum StringPool2 { ");
            files[2].WriteLine("enum StringPool3 { ");
            WriteLine("    Identifier = 0;");
            names.Add("Identifier");
        }
        private void WriteLine()
        {
            foreach (var writer in files)
            {
                writer.WriteLine();
            }
        }
        private void WriteLine(string content)
        {
            foreach (var writer in files)
            {
                writer.WriteLine(content);
            }
        }
        private void SaveFiles()
        {
            foreach (var writer in files)
            {
                writer.Flush();
                writer.Dispose();
            }
        }
        #endregion

        private bool compiled; // Whether Compile() has been invoked
        private bool compilingFailed;
        private object pushLock = "Ast Rickley";
        private SortedSet<string> names = new();
        private ReadOnlyDictionary<string, string> originalToCompiledDict;

        private const string Compiled_IdentifierLine = "[pbr::OriginalName(\"identifier\")] Identifier = 0,";
        private const string Compiled_AttributePrefix = "[pbr::OriginalName(\"";
        private const string Compiled_AttributeSuffix = "\")] ";
        private const string Compiled_EnumValuePrefix = " = ";

        /// <summary>
        /// Push a field name to string pool. Invoke before <see cref="Compile()"/>.
        /// </summary>
        public void PushFieldName(string originalName)
        {
            if (compiled)
                throw new InvalidOperationException("StringPool has compiled and don't accept any new field names.");
            lock (pushLock)
            {
                names.Add(originalName);
            }
        }

        /// <summary>
        /// Compile the string pool and make it read-only.
        /// </summary>
        /// <exception cref="InvalidOperationException">Compile for this instance is no longer avaliable.</exception>
        /// <exception cref="ApplicationException">protoc Compiling failed.</exception>
        public async Task Compile()
        {
            #region Assert
            if (compilingFailed)
                throw new InvalidOperationException("The instance has failed to compile and not avaliable any more.");
            if (compiled)
                throw new InvalidOperationException("StringPool has compiled and can't compile twice.");
            compiled = true;
            #endregion
            #region Write StringPool
            var namelist = names.ToArray();
            for (int i = 1; i < namelist.Length; i++)
            {
                WriteLine($"    {namelist[i]} = {i};");
            }
            Log.Info($"StringPool started compiling, {namelist.Length} fields detected.", nameof(ProtocStringPoolManager));
            #endregion
            SaveFiles();

            #region Invoke protoc
            string commandLine = string.Concat(
                "--proto_path=\"", Environment.CurrentDirectory, "/ProtoFieldNameAnalyze/GeneratedProtos\" ",
                "\"", Environment.CurrentDirectory, "/ProtoFieldNameAnalyze/GeneratedProtos/*.proto\" ",
                "--csharp_out=\"", Environment.CurrentDirectory, "/ProtoFieldNameAnalyze/Compiled\""
            );
            Stopwatch watch = Stopwatch.StartNew();
            Process p = Process.Start("protoc", commandLine);
            Log.Verb($"Started invoking protoc: protoc {commandLine}", nameof(ProtocStringPoolManager));
            await p.WaitForExitAsync();
            watch.Stop();
            Log.Info($"protoc invoke exited, costed {watch.Elapsed}.", nameof(ProtocStringPoolManager));
            if (p.ExitCode != 0)
            {
                Log.Erro($"protoc compiling exited with code {p.ExitCode}. Compiling Failed. ", nameof(ProtocStringPoolManager));
                compilingFailed = true;
                throw new ApplicationException($"protoc compiling exited with code {p.ExitCode}. Compiling Failed. ");
            }
            #endregion
            Dictionary<string, string> _compiledNameDict = new();
            Dictionary<string, string?> _possibleCompiledNameDict = new();
            #region Analyze compiled file
            using (StreamReader reader1 = new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/Compiled/StringPool1.cs"))
            {
                bool reachedPoolDataRegion = false;
                long currentLine = 0;
                while (!reader1.EndOfStream)
                {
                    #region Data Region Manage
                    currentLine++;
                    string? line = (await reader1.ReadLineAsync())?.Trim();
                    if (!reachedPoolDataRegion)
                    {
                        if (line != Compiled_IdentifierLine) continue;
                        else
                        {
                            Log.Verb($"Reached identifier at line {currentLine}.", nameof(ProtocStringPoolManager));
                            reachedPoolDataRegion = true;
                        }
                    }
                    if (line == null) continue;
                    if (!line.StartsWith(Compiled_AttributePrefix))
                    {
                        Log.Verb($"End of Data Region at line {currentLine}.", nameof(ProtocStringPoolManager));
                        break;
                    }
                    #endregion
                    var res = ReadValueFromCompiledFileLine(line, namelist);
                    _compiledNameDict.Add(res.originalName, res.compiledName);
                    _possibleCompiledNameDict.Add(res.originalName, null);
                }
            }
            using (StreamReader reader2 = new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/Compiled/StringPool2.cs"))
            {
                bool reachedPoolDataRegion = false;
                long currentLine = 0;
                while (!reader2.EndOfStream)
                {
                    #region Data Region Manage
                    currentLine++;
                    string? line = (await reader2.ReadLineAsync())?.Trim();
                    if (!reachedPoolDataRegion)
                    {
                        if (line != Compiled_IdentifierLine) continue;
                        else
                        {
                            Log.Verb($"Reached identifier at line {currentLine}.", nameof(ProtocStringPoolManager));
                            reachedPoolDataRegion = true;
                        }
                    }
                    if (line == null) continue;
                    if (!line.StartsWith(Compiled_AttributePrefix))
                    {
                        Log.Verb($"End of Data Region at line {currentLine}.", nameof(ProtocStringPoolManager));
                        break;
                    }
                    #endregion
                    var res = ReadValueFromCompiledFileLine(line, namelist);
                    if (_compiledNameDict.ContainsKey(res.originalName))
                    {
                        if (_compiledNameDict[res.originalName] != res.compiledName)
                        {
                            _possibleCompiledNameDict[res.originalName] = res.compiledName;
                        }
                    }
                    else 
                    {
                        Log.Dbug($"Field detected in StringPool2 but not in StringPool1, " +
                            $"originalName: {res.originalName}, compiledName: {res.compiledName}", nameof(ProtocStringPoolManager));
                        _compiledNameDict.Add(res.originalName, res.compiledName);
                        _possibleCompiledNameDict.Add(res.originalName, null);
                    }
                }
            }
            using (StreamReader reader3 = new($"{Environment.CurrentDirectory}/ProtoFieldNameAnalyze/Compiled/StringPool3.cs"))
            {
                bool reachedPoolDataRegion = false;
                long currentLine = 0;
                while (!reader3.EndOfStream)
                {
                    #region Data Region Manage
                    currentLine++;
                    string? line = (await reader3.ReadLineAsync())?.Trim();
                    if (!reachedPoolDataRegion)
                    {
                        if (line != Compiled_IdentifierLine) continue;
                        else
                        {
                            Log.Verb($"Reached identifier at line {currentLine}.", nameof(ProtocStringPoolManager));
                            reachedPoolDataRegion = true;
                        }
                    }
                    if (line == null) continue;
                    if (!line.StartsWith(Compiled_AttributePrefix))
                    {
                        Log.Verb($"End of Data Region at line {currentLine}.", nameof(ProtocStringPoolManager));
                        break;
                    }
                    #endregion
                    var res = ReadValueFromCompiledFileLine(line, namelist);
                    if (_compiledNameDict.ContainsKey(res.originalName))
                    {
                        // res.compiledName is not null, possibleName == res.compiledName, so possibleName not null
                        if (_possibleCompiledNameDict[res.originalName] == res.compiledName)
                        {
                            _compiledNameDict[res.originalName] = 
                                (string)_possibleCompiledNameDict[res.originalName];
                        }
                    }
                    else 
                    {
                        Log.Dbug($"Field detected in StringPool3 but not in StringPool1&2, " +
                            $"originalName: {res.originalName}, compiledName: {res.compiledName}", nameof(ProtocStringPoolManager));
                        _compiledNameDict.Add(res.originalName, res.compiledName);
                        _possibleCompiledNameDict.Add(res.originalName, null);
                    }
                }
            }
            #endregion

            originalToCompiledDict = new(_compiledNameDict);
        }

        private (string originalName, string compiledName)
            ReadValueFromCompiledFileLine(string line, string[] namelist)
        {
            #region Read original name
            int indexEndOriginalName = line.IndexOf('"', Compiled_AttributePrefix.Length);
            string originalName = line.Substring(
                Compiled_AttributePrefix.Length, indexEndOriginalName - Compiled_AttributePrefix.Length);
            #endregion
            #region Read Compiled name
            int indexStartCompiledName = indexEndOriginalName + Compiled_AttributeSuffix.Length;
            int indexEndCompiledName = line.IndexOf(
                Compiled_EnumValuePrefix, indexStartCompiledName);
            string compiledName = line.Substring(
                indexStartCompiledName, indexEndCompiledName - indexStartCompiledName);
            #endregion
            #region Read value & verify
            int indexStartEnumValue = indexEndCompiledName + Compiled_EnumValuePrefix.Length;
            int enumValue = int.Parse(line.Substring(indexStartCompiledName,
                line.IndexOf(',', indexStartCompiledName) - indexStartCompiledName));
            if (namelist[enumValue] != originalName)
            {
                Log.Dbug($"Read enum value verify failed, " +
                    $"expected originalName: {namelist[enumValue]}, " +
                    $"read originalName: {originalName}, compiledName: {compiledName}, enumValue: {enumValue}",
                    nameof(ProtocStringPoolManager));
            }
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
}