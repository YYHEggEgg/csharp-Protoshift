using System;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

public static class ObjectExtensions
{
    public static T ToObject<T>(this IDictionary<string, object> source)
        where T : class, new()
    {
        var someObject = new T();
        var someObjectType = typeof(T);

        foreach (var item in source)
        {
            if (someObjectType.GetProperty(item.Key) != null)
                someObjectType
                    .GetProperty(item.Key)
                    .SetValue(someObject, item.Value, null);
            else
                someObjectType
                    .GetField(item.Key)
                    .SetValue(someObject, item.Value);
        }

        return someObject;
    }

    public static IDictionary<string, object> AsDictionary(this object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
    {
        return source.GetType().GetProperties(bindingAttr).ToDictionary
        (
            propInfo => propInfo.Name,
            propInfo => propInfo.GetValue(source, null)
        );

    }
}
