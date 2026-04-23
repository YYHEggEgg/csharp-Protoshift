# csharp-Protoshift 包查看器设计概要

本文档主要说明为 csharp-Protoshift 项目导出的 `latest.packet.log` 文件设计一个方便的包查看器的方案。

## 背景

csharp-Protoshift 项目是一个用于在使用两套 Protobuf 协议的连接双方中充当翻译的工具。它会使用 codegen 的方式生成协议的 C# 代码，并在运行时解析、转换、转发协议数据包。

`latest.packet.log` 的格式如下：

```cs
// new read format:
// [time]|Info|[uid]|[PacketName]|[CmdId]|[sentByClient]|[head]|[body]|[handleNanoseconds]|[shiftedData]
2026-04-02 12:36:14 462 1463|Info|0|GetPlayerTokenReq|179|True|...|...|123601237|...
2026-04-02 12:36:15 628 5237|Info|1|GetPlayerTokenRsp|198|False|...|...|6636890|...
```

本项目在解决此问题的过程中，一般进行以下约定：

- 服务端使用的协议 = `OldProtos` 协议 = `SentByClient = False`
- 客户端使用的协议 = `NewProtos` 协议 = `SentByClient = True`

## 引用

本项目应该导入解决方案中的以下项目：

- `OldProtoHandlers`
- `NewProtoHandlers`

它们**各包含一个（命名空间不同！）**自动生成的 `QueryJsonSerializer` 类，其中可以按照消息名称查询到对应的 JSON 序列化器 `ProtoSerializeJson` 实例。可使用后者的 `SerializeFromJson` 和 `DeserializeToJson` 方法进行 JSON 与 Protobuf 消息对象之间的转换。

此外，`csharp-Protoshift` 项目包含一个 `PacketRecord` 类，其中的 `Parse` 方法可以直接读入 `latest.packet.log` PSV 文件中的一行，并解析成一个 `PacketRecord` 实例。但由于整个项目及其引用较大，建议你直接复制 `PacketRecord` 类的定义到你的项目中，而不是引用整个 `csharp-Protoshift` 项目。

## 目标

实现对于指定 `latest.packet.log` 文件的解析、反序列化、展示、查找。需要支持该文件的增量更新。

在程序启动时，如果 `../csharp-Protoshift/Logs/latest.packet.log` 文件存在，则加载并解析该文件的内容。之后持续监视该文件的变化，并在文件更新时增量加载新的日志记录。用户可以手动更换其他的文件。

用户应该能够按照时间范围、`PacketName`、`CmdId` 字段进行过滤和查找。对于每条日志记录，用户应该能够查看其详细信息，包括：

- 该包发出的具体时间；
- 该包传入时的 JSON 对应（body）；
- 提供专门的页面查看该报传入和传出时的 JSON 对应（shiftedData）之间的对比，应该做成一个专门的 diff 查看器，提供高亮、相同部分默认折叠等功能。

用户应该能够将选定的日志、当前符合筛选条件的日志或全部日志导出为相同格式的 PSV 文件，但将 body 和 shiftedData 字段替换为 JSON 格式的字符串。导出时可以选择是否包含转换后等效数据，如果否则不包含 handledNanoseconds 和 shiftedData 字段，默认不选中。

## 实现方式

应用程序的基础显然需要是 C#，**但为了保证界面的整体水准，我强制你必须使用 Vue 实现前端**。Vue 项目和 C# 项目分离，但是 C# 项目编译必须随同 Vue 项目一起编译，并在 C# 服务器中以静态文件的形式提供 Vue 项目的构建产物。C# 服务器需要提供一个 API 来读取和解析 `latest.packet.log` 文件，并将数据提供给前端。

不需要考虑网页在非本机上访问的情况。不限制其他的任何包引用。

## 参考

对比 JSON 时需要将输入排序。可以使用以下运用 `Newtonsoft.Json` 的代码：

```cs
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public static partial class JTokenHelper
{
    /// <summary>
    /// Sort <paramref name="token"/> with strict but low-performance rules to make the result unique.
    /// </summary>
    /// <returns>A sorted deep clone of the provided <paramref name="token"/>.</returns>
    /// <remarks>
    /// The detailed sort rule is: <para/>
    /// - Each JSON object must be sorted by key. <para/>
    /// - Each JSON Array must sort the values in it, or by common alignment strategy if it is a normal type; In the case of JSON Objects or JSON Array sequences, each one is internally sorted and converted to an equivalent string to determine their relative order. <para/>
    /// - When sorting the JSON Array, null is greater than all values (so that it'll be put at the end of the sequence).
    /// </remarks>
    public static JToken SortStrict(this JToken token)
    {
        if (token is JObject jObject)
        {
            return SortJObject(jObject);
        }
        if (token is JArray jArray)
        {
            return SortJArray(jArray);
        }
        return token.DeepClone();
    }

    private static JObject SortJObject(JObject obj)
    {
        var sortedProperties = obj.Properties()
            .OrderBy(p => p.Name, StringComparer.Ordinal)
            .Select(p => new JProperty(p.Name, p.Value.SortStrict()));
        return new JObject(sortedProperties);
    }

    private static JArray SortJArray(JArray array)
    {
        if (array.Count > 0)
        {
            ValidateArrayElementTypes(array);
        }
        var sortedElements = array
            .Select(SortStrict)
            .OrderBy(x => x, JTokenComparer.Instance);
        return new JArray(sortedElements);
    }

    private class JTokenComparer : IComparer<JToken>
    {
        public int Compare(JToken? x, JToken? y)
        {
            // null is greatest
            if (x is null) return y is null ? 0 : 1;
            if (y is null) return -1;
            if (x.Type != y.Type) return x.Type.CompareTo(y.Type);

            if (x is JValue xValue && y is JValue yValue)
            {
                if (xValue.Type == JTokenType.Null || xValue.Type == JTokenType.Undefined)
                    return (yValue.Type == JTokenType.Null || yValue.Type == JTokenType.Undefined) ? 0 : 1;
                var xCmp = (IComparable?)xValue.Value;
                var yCmp = (IComparable?)yValue.Value;
                if (xCmp is null || yCmp is null) throw new InvalidOperationException(
                    $"Cannot compare {xValue.Value?.GetType().Name} and {yValue.Value?.GetType().Name}");
                return xCmp.CompareTo(yCmp);
            }
            else if (x is JObject xJObj && y is JObject yJObj)
            {
                return JObjectComparer.Instance.Compare(xJObj, yJObj);
            }
            else if (x is JArray xJArr && y is JArray yJArr)
            {
                xJArr = SortJArray(xJArr);
                yJArr = SortJArray(yJArr);
                var xEnumerator = xJArr.GetEnumerator();
                var yEnumerator = yJArr.GetEnumerator();
                while (xEnumerator.MoveNext() && yEnumerator.MoveNext())
                {
                    var cmp = Compare(xEnumerator.Current, yEnumerator.Current);
                    if (cmp != 0) return cmp;
                }
                return xJArr.Count.CompareTo(yJArr.Count);
            }
            else throw new NotSupportedException($"Unsupported token pair type: {x.GetType().Name}, {y.GetType().Name}");
        }

        public static readonly JTokenComparer Instance = new();
    }

    private class JObjectComparer : IComparer<JObject>
    {
        public int Compare(JObject? x, JObject? y)
        {
            if (x is null) return y is null ? 0 : 1;
            if (y is null) return -1;

            var xEnumerator = x.Properties().OrderBy(x => x.Name).GetEnumerator();
            var yEnumerator = y.Properties().OrderBy(x => x.Name).GetEnumerator();
            while (xEnumerator.MoveNext() && yEnumerator.MoveNext())
            {
                var cmp = xEnumerator.Current.Name.CompareTo(yEnumerator.Current.Name);
                if (cmp != 0) return cmp;
                cmp = JTokenComparer.Instance.Compare(xEnumerator.Current.Value, yEnumerator.Current.Value);
                if (cmp != 0) return cmp;
            }
            return x.Properties().Count().CompareTo(y.Properties().Count());
        }

        public static readonly JObjectComparer Instance = new();
    }

    private static void ValidateArrayElementTypes(JArray array)
    {
        JTokenType? baseType = null;
        Type? baseClrType = null;
        bool isObjectArray = false;
        bool isArrayArray = false;

        foreach (var item in array)
        {
            if (item.Type == JTokenType.Null) continue;

            if (baseType == null)
            {
                baseType = item.Type;
                if (item is JValue baseValue)
                {
                    baseClrType = baseValue.Value?.GetType();
                }
                else if (item is JObject)
                {
                    isObjectArray = true;
                }
                else if (item is JArray)
                {
                    isArrayArray = true;
                }
                continue;
            }

            if (item.Type != baseType)
            {
                throw new InvalidOperationException("Array contains mixed element types");
            }

            if (item is JValue currentValue)
            {
                var currentClrType = currentValue.Value?.GetType();
                if (currentClrType != baseClrType)
                {
                    throw new InvalidOperationException("Array contains mixed value types");
                }
            }
            else if (isObjectArray && item is not JObject)
            {
                throw new InvalidOperationException("Array contains mixed object types");
            }
            else if (isArrayArray && item is not JArray)
            {
                throw new InvalidOperationException("Array contains mixed array types");
            }
        }
    }

    private static object? GetSortKey(JToken token)
    {
        if (token.Type == JTokenType.Null) return null;

        return token switch
        {
            JObject or JArray => token.ToString(Formatting.None),
            JValue jValue => jValue.Value,
            _ => throw new NotSupportedException($"Unsupported token type: {token.GetType().Name}")
        };
    }

    private static int CompareSortKeys(object? a, object? b)
    {
        if (a == null && b == null) return 0;
        if (a == null) return 1;
        if (b == null) return -1;

        return (a, b) switch
        {
            (string sa, string sb) => string.CompareOrdinal(sa, sb),
            (IComparable ac, IComparable bc) => ac.CompareTo(bc),
            _ => throw new InvalidOperationException($"Cannot compare {a.GetType().Name} and {b.GetType().Name}")
        };
    }
}
```
