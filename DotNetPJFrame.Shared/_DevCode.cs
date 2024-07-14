using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPJFrame.Shared;

public static partial class _DevCode
{
    public static JObject ToJObject(this object? obj)
    {
        return JObject.FromObject(obj);
    }

    public static string? ToJson<T>(this T? obj, bool format = false)
    {
        if (obj == null) return string.Empty;
        string? result;
        if (obj is string)
        {
            result = obj.ToString();
        }
        var settings = new JsonSerializerSettings { DateFormatString = "yyyy-MM-ddTHH:mm:ss.sssZ" };
        result = format
            ? JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, settings)
            : JsonConvert.SerializeObject(obj, settings);
    Result:
        return result;
    }

    public static T ToEnum<T>(this string? l_value) where T : Enum
    {
        try
        {
            return (T)Enum.Parse(typeof(T), l_value, true);
        }
        catch
        {
            return (T)Enum.ToObject(typeof(T), 0);
        }
    }

}