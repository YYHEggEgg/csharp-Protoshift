using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PacketLogInspector.Helpers;

public static partial class JTokenHelper
{
    /// <summary>
    /// Sort <paramref name="token"/> with strict but low-performance rules to make the result unique.
    /// </summary>
    public static JToken SortStrict(this JToken token)
    {
        if (token is JObject jObject) return SortJObject(jObject);
        if (token is JArray jArray) return SortJArray(jArray);
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
        if (array.Count > 0) ValidateArrayElementTypes(array);
        var sortedElements = array.Select(SortStrict).OrderBy(x => x, JTokenComparer.Instance);
        return new JArray(sortedElements);
    }

    private class JTokenComparer : IComparer<JToken>
    {
        public int Compare(JToken? x, JToken? y)
        {
            if (x is null) return y is null ? 0 : 1;
            if (y is null) return -1;
            if (x.Type != y.Type) return x.Type.CompareTo(y.Type);

            if (x is JValue xValue && y is JValue yValue)
            {
                if (xValue.Type == JTokenType.Null || xValue.Type == JTokenType.Undefined)
                    return (yValue.Type == JTokenType.Null || yValue.Type == JTokenType.Undefined) ? 0 : 1;
                var xCmp = (IComparable?)xValue.Value;
                var yCmp = (IComparable?)yValue.Value;
                if (xCmp is null || yCmp is null)
                    throw new InvalidOperationException(
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
                var xEnum = xJArr.GetEnumerator();
                var yEnum = yJArr.GetEnumerator();
                while (xEnum.MoveNext() && yEnum.MoveNext())
                {
                    var cmp = Compare(xEnum.Current, yEnum.Current);
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

            var xEnum = x.Properties().OrderBy(p => p.Name).GetEnumerator();
            var yEnum = y.Properties().OrderBy(p => p.Name).GetEnumerator();
            while (xEnum.MoveNext() && yEnum.MoveNext())
            {
                var cmp = xEnum.Current.Name.CompareTo(yEnum.Current.Name);
                if (cmp != 0) return cmp;
                cmp = JTokenComparer.Instance.Compare(xEnum.Current.Value, yEnum.Current.Value);
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
                if (item is JValue baseValue) baseClrType = baseValue.Value?.GetType();
                else if (item is JObject) isObjectArray = true;
                else if (item is JArray) isArrayArray = true;
                continue;
            }

            if (item.Type != baseType)
                throw new InvalidOperationException("Array contains mixed element types");

            if (item is JValue currentValue && currentValue.Value?.GetType() != baseClrType)
                throw new InvalidOperationException("Array contains mixed value types");
            else if (isObjectArray && item is not JObject)
                throw new InvalidOperationException("Array contains mixed object types");
            else if (isArrayArray && item is not JArray)
                throw new InvalidOperationException("Array contains mixed array types");
        }
    }
}
