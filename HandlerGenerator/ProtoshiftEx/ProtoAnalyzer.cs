// Generated by ChatGPT

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public static class JsonAnalyzer
{
public static readonly string[] nativeTypes = new string[] {"double", "float", "int32", "int64", "uint32", "uint64", "sint32", "sint64", "fixed32", "fixed64", "sfixed32", "sfixed64", "bool", "string", "bytes" };
public static ProtoJsonResult AnalyzeProtoJson(string json)
{
    var result = new ProtoJsonResult();

    var jsonObj = JObject.Parse(json);
    var protoBodies = jsonObj["ProtoBody"].Children();

    // 筛选出所有具有 MessageName 字段的项
    foreach (var body in protoBodies.Where(b => b["MessageName"] != null))
    {
        var messageResult = new MessageResult();
        messageResult.commonFields = new List<CommonResult>();
        messageResult.mapFields = new List<MapResult>();
        messageResult.oneofFields = new List<OneofResult>();
        messageResult.enumFields = new List<EnumResult>();

        var protoname = (string)body["MessageName"];
        messageResult.messageName = protoname;
        var messageBodies = body["MessageBody"].Children();

        // 对每个 MessageBody 进行分析
        foreach (var mb in messageBodies)
        {
            if (mb["EnumName"] != null)
            {
                var enumResult = new EnumResult();
                enumResult.enumName = (string)mb["EnumName"];
                var enumIdents = mb["EnumBody"].Children();
                foreach (var ei in enumIdents)
                {
                    if (ei["Ident"] != null)
                    {
                        enumResult.enumNodes.Add((string)ei["Ident"]);
                    }
                }
                messageResult.enumFields.Add(enumResult);
            }
            else if (mb["FieldName"] != null)
            {
                var commonResult = new CommonResult();
                commonResult.fieldType = (string)mb["Type"];
                commonResult.fieldName = (string)mb["FieldName"];
                commonResult.IsRepeatedField = (bool)mb["IsRepeated"];

                commonResult.isImportType = !nativeTypes.Contains(commonResult.fieldType);

                messageResult.commonFields.Add(commonResult);
                
            }
            else if (mb["OneofName"] != null)
            {
                var oneofResult = new OneofResult();
                oneofResult.oneofEntryName = (string)mb["OneofName"];
                oneofResult.oneofInnerFields = new List<CommonResult>();
                var oneofFields = mb["OneofFields"].Children();

                foreach (var ob in oneofFields)
                {
                    var innerCommonResult = new CommonResult();
                    innerCommonResult.fieldType = (string)ob["Type"];
                    innerCommonResult.fieldName = (string)ob["FieldName"];
                    innerCommonResult.IsRepeatedField = false;
                    innerCommonResult.isImportType = !nativeTypes.Contains(innerCommonResult.fieldType);
                    oneofResult.oneofInnerFields.Add(innerCommonResult);
                }

                messageResult.oneofFields.Add(oneofResult);
            }
            else if (mb["MapName"] != null)
            {
                var mapResult = new MapResult();
                mapResult.keyType = (string)mb["KeyType"];
                mapResult.valueType = (string)mb["Type"];
                mapResult.fieldName = (string)mb["MapName"];
                messageResult.mapFields.Add(mapResult);

                mapResult.keyIsImportType = !nativeTypes.Contains(mapResult.keyType);
                mapResult.valueIsImportType = !nativeTypes.Contains(mapResult.valueType);
            }
        }

        result.messageBodys.Add(messageResult);
    }

    // 筛选出所有具有 EnumName 字段的项并进行分析
    var enumBodies = protoBodies.Where(b => b["EnumName"] != null);

    foreach (var eb in enumBodies)
    {
        var enumResult = new EnumResult();
        enumResult.enumName = (string)eb["EnumName"];
        var enumIdents = eb["EnumBody"].Children();
        foreach (var ei in enumIdents)
        {
            if (ei["Ident"] != null)
            {
                enumResult.enumNodes.Add((string)ei["Ident"]);
            }
        }
        result.enumBodys.Add(enumResult);
    }

    return result;
}
}
}