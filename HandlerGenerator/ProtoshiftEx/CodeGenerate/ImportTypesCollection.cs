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

using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using YYHEggEgg.Logger;

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
            public bool importIsMessage;
            /// <summary>
            /// The name can be identified by the compilier in the global context <para/>
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
                        compileMessageName.Substring(compileMessageName.LastIndexOf('.'))))
                    {
                        Log.Erro($"Protocol invalid: {oldmessage.messageName}'s sub protos have the same name with the other.", nameof(ImportTypesCollection));
                        Debug.Assert(false, $"Protocol invalid: {oldmessage.messageName}'s sub protos have the same name with the other.");
                    }
                    friendlyToCompileNameList.Add(compileMessageName.Substring(compileMessageName.LastIndexOf('.')), (compileMessageName, true));
                }
                foreach (var compileEnumName in oldCompileNameList.messages)
                {
                    if (friendlyToCompileNameList.ContainsKey(
                        compileEnumName.Substring(compileEnumName.LastIndexOf('.'))))
                    {
                        Log.Erro($"Protocol invalid: {oldmessage.messageName}'s sub protos (enum) have the same name with the other.", nameof(ImportTypesCollection));
                        Debug.Assert(false);
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
                    if (!friendlyToCompileNameList.ContainsKey(importName))
                    {
                        Log.Dbug($"Proto {oldmessage.messageName}: Skipping analyzing import type {importName} for not found any match actual compiled types (in both Protos).", nameof(ImportTypesCollection));
                    }
                    var query = friendlyToCompileNameList[importName];
                    var rtn_element = new ImportTypeElement
                    {
                        friendlyTypeName = importName,
                        importIsMessage = query.isMessage,
                        compileTypeName = query.compileName
                    };
                    res.Add(importName, rtn_element);
                }
                searchByFriendlyName = new(res);
            }

            public static SortedSet<string> GetMessageImportTypesAsFrieldlyName(MessageResult messageResult)
            {
                SortedSet<string> res = new();
                foreach (var commonField in messageResult.commonFields)
                {
                    if (commonField.isImportType) res.Add(commonField.fieldType);
                }
                foreach (var mapField in messageResult.mapFields)
                {
                    if (mapField.keyIsImportType) res.Add(mapField.keyType);
                    if (mapField.valueIsImportType) res.Add(mapField.valueType);
                }
                foreach (var oneofField in messageResult.oneofFields)
                {
                    foreach (var oneofInnerField in oneofField.oneofInnerFields)
                    {
                        if (oneofInnerField.isImportType) res.Add(oneofInnerField.fieldType);
                    }
                }
                foreach (var enumField in messageResult.enumFields)
                {
                    res.Add(enumField.enumName);
                }
                foreach (var messageField in messageResult.messageFields)
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
                foreach (var messageField in messageResult.messageFields)
                {
                    messages.Add(messageField.messageName);
                    var innerTypePair = GetInnerMessageTypesAsCompileName(messageField);
                    foreach (var innerMessageFieldName in innerTypePair.messages)
                    {
                        messages.Add($"{messageResult.messageName}.Types.{innerMessageFieldName}");
                    }
                    foreach (var innerEnumFieldName in innerTypePair.enums)
                    {
                        enums.Add($"{messageResult.messageName}.Types.{innerEnumFieldName}");
                    }
                }
                foreach (var enumField in messageResult.enumFields)
                {
                    enums.Add(enumField.enumName);
                }
                return (messages, enums);
            }
        
            public bool ContainsKey(string friendlyName) => searchByFriendlyName.ContainsKey(friendlyName);
            public ImportTypeElement this[string friendlyName] => searchByFriendlyName[friendlyName];
            public bool TryGetValue(string friendlyName, [MaybeNullWhen(false)] out ImportTypeElement value)
                => searchByFriendlyName.TryGetValue(friendlyName, out value);
        }
    }
}