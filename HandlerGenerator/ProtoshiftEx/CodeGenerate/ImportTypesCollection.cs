// The example used in this file:

// message ExampleProto2 {
//     bytes ex_bytes = 8;
//     repeated string list_str = 3;
//     ExampleInnerProto inner_msg = 6;
//     ExampleInnerEnum inner_enum = 7;

//     message ExampleInnerProto {
//         uint32 inner_code = 2;
//     }

//     enum ExampleInnerEnum {
//         EXAMPLE_INNER_ENUM_NONE = 0;
//         EXAMPLE_INNER_ENUM_SOMEOBJ = 1;
//         EXAMPLE_INNER_ENUM_OTHEROBJ = 2;
//     }
// }

using Google.Protobuf;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using YYHEggEgg.Logger;
using YYHEggEgg.ProtoParser;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class HandlerCodeWriter
    {
        public struct ImportTypeElement
        {
            /// <summary>
            /// The friendly name in the current context, <para/>
            /// e.g. ExampleProto2, ExampleInnerProto.
            /// </summary>
            public string friendlyTypeName;
            /// <summary>
            /// Indicate the import type is Message/Enum.
            /// </summary>
            // public bool importIsMessage;
            /// <summary>
            /// The name can be identified by the compilier in the global context
            /// (but without NewProtos/OldProtos prefix), <para/>
            /// e.g. ExampleProto2, ExampleProto2.Types.ExampleInnerProto
            /// </summary>
            public string compileTypeName;
        }

        public class ImportTypesCollection
        {
            public readonly ReadOnlyDictionary<string, ImportTypeElement> searchByFriendlyName;

            /// <summary>
            /// Initialize a import types collection from two <see cref="MessageResult"/>s. Only handle the intersect fields.
            /// </summary>
            public ImportTypesCollection(MessageResult oldmessage, MessageResult newmessage)
            {
                Dictionary<string, ImportTypeElement> res = new();
                var oldCompileNameList = GetInnerMessageTypesAsCompileName(oldmessage);
                var newCompileNameList = GetInnerMessageTypesAsCompileName(newmessage);
                #region GetInnerMessageTypesAsFriendlyName
                Dictionary<string, (string compileName, bool isMessage)> friendlyToCompileNameList = new();
                oldCompileNameList.messages.IntersectWith(newCompileNameList.messages);
                oldCompileNameList.enums.IntersectWith(newCompileNameList.enums);
                foreach (var compileMessageName in oldCompileNameList.messages)
                {
                    if (friendlyToCompileNameList.ContainsKey(
                        compileMessageName.Substring(compileMessageName.LastIndexOf('.') + 1)))
                    {
                        Log.Erro($"Protocol invalid: {oldmessage.MessageName}'s sub protos have the same name with the other.", nameof(ImportTypesCollection));
                        Debug.Assert(false, $"Protocol invalid: {oldmessage.MessageName}'s sub protos have the same name with the other.");
                    }
                    friendlyToCompileNameList.Add(compileMessageName.Substring(compileMessageName.LastIndexOf('.')), (compileMessageName, true));
                }
                foreach (var compileEnumName in oldCompileNameList.enums)
                {
                    if (friendlyToCompileNameList.ContainsKey(
                        compileEnumName.Substring(compileEnumName.LastIndexOf('.') + 1)))
                    {
                        Log.Erro($"Protocol invalid: {oldmessage.MessageName}'s sub protos (enum) have the same name with the other.", nameof(ImportTypesCollection));
                        Debug.Assert(false, $"Protocol invalid: {oldmessage.MessageName}'s sub protos (enum) have the same name with the other.");
                    }
                    friendlyToCompileNameList.Add(compileEnumName.Substring(compileEnumName.LastIndexOf('.')), (compileEnumName, false));
                }
                #endregion
                var oldimports = GetMessageImportTypesAsFrieldlyName(oldmessage);
                var newimports = GetMessageImportTypesAsFrieldlyName(newmessage);
                oldimports.IntersectWith(newimports);
                var bothimports = oldimports;
                foreach (var importName in bothimports)
                {
                    if (friendlyToCompileNameList.ContainsKey(importName))
                    {
                        var query = friendlyToCompileNameList[importName];
                        var rtn_element = new ImportTypeElement
                        {
                            friendlyTypeName = importName,
                            compileTypeName = query.compileName
                        };
                        res.Add(importName, rtn_element);
                    }
                    else
                    {
                        var rtn_element = new ImportTypeElement
                        {
                            friendlyTypeName = importName,
                            compileTypeName = importName
                        };
                        res.Add(importName, rtn_element);
                    }
                }
                searchByFriendlyName = new(res);
            }

            public static SortedSet<string> GetMessageImportTypesAsFrieldlyName(MessageResult messageResult)
            {
                SortedSet<string> res = new();
                foreach (var commonField in messageResult.CommonFields)
                {
                    if (commonField.IsImportType) res.Add(commonField.FieldType);
                }
                foreach (var mapField in messageResult.MapFields)
                {
                    if (mapField.KeyIsImportType) res.Add(mapField.KeyType);
                    if (mapField.ValueIsImportType) res.Add(mapField.ValueType);
                }
                foreach (var oneofField in messageResult.OneofFields)
                {
                    foreach (var oneofInnerField in oneofField.OneofInnerFields)
                    {
                        if (oneofInnerField.IsImportType) res.Add(oneofInnerField.FieldType);
                    }
                }
                foreach (var enumField in messageResult.EnumFields)
                {
                    res.Add(enumField.EnumName);
                }
                foreach (var messageField in messageResult.MessageFields)
                {
                    foreach (var addrange_single in GetMessageImportTypesAsFrieldlyName(messageField))
                    {
                        res.Add(addrange_single);
                    }
                }
                return res;
            }

            public static (SortedSet<string> messages, SortedSet<string> enums)
                GetInnerMessageTypesAsCompileName(MessageResult messageResult)
            {
                SortedSet<string> messages = new();
                SortedSet<string> enums = new();
                foreach (var messageField in messageResult.MessageFields)
                {
                    var inner_message_field_name = $"{messageResult.MessageName}.Types.{messageField.MessageName}";
                    messages.Add(inner_message_field_name);
                    var innerTypePair = GetInnerMessageTypesAsCompileName(messageField);
                    foreach (var innerMessageFieldName in innerTypePair.messages)
                    {
                        messages.Add($"{inner_message_field_name}.Types.{innerMessageFieldName}");
                    }
                    foreach (var innerEnumFieldName in innerTypePair.enums)
                    {
                        enums.Add($"{inner_message_field_name}.Types.{innerEnumFieldName}");
                    }
                }
                foreach (var enumField in messageResult.EnumFields)
                {
                    enums.Add($"{messageResult.MessageName}.Types.{enumField.EnumName}");
                }
                return (messages, enums);
            }
        
            public bool ContainsKey(string friendlyName) => searchByFriendlyName.ContainsKey(friendlyName);
            public ImportTypeElement this[string friendlyName] => searchByFriendlyName[friendlyName];
            public bool TryGetValue(string friendlyName, [MaybeNullWhen(false)] out ImportTypeElement value)
                => searchByFriendlyName.TryGetValue(friendlyName, out value);

            public static readonly ReadOnlyDictionary<string, string> QueryProtobufNativeTypes = new(new Dictionary<string, string>
            {
                { "double", nameof(Double) },
                { "float", nameof(Single) },
                { "int32", nameof(Int32) },
                { "int64", nameof(Int64) },
                { "uint32", nameof(UInt32) },
                { "uint64", nameof(UInt64) },
                { "sint32", nameof(Int32) },
                { "sint64", nameof(Int64) },
                { "fixed32", nameof(Int32) },
                { "fixed64", nameof(Int64) },
                { "sfixed32", nameof(Int32) },
                { "sfixed64", nameof(Int64) },
                { "bool", nameof(Boolean) },
                { "string", nameof(String) },
                { "bytes", nameof(ByteString) },
            });
        }
    }
}