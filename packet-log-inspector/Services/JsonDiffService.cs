using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PacketLogInspector.Helpers;
using PacketLogInspector.Models;

namespace PacketLogInspector.Services;

/// <summary>
/// Produces sorted, pretty-printed JSON strings for both sides of a diff.
/// </summary>
public class JsonDiffService
{
    private readonly ProtoDeserializerService _deserializer;

    public JsonDiffService(ProtoDeserializerService deserializer)
    {
        _deserializer = deserializer;
    }

    /// <summary>
    /// Returns (originalJson, modifiedJson) - both are sorted via JTokenHelper.SortStrict
    /// and formatted with indentation for use in Monaco diff editor.
    /// Original = body (as received), Modified = shiftedData (after proto-shift).
    /// </summary>
    public (string Original, string Modified) GetDiff(PacketRecord record)
    {
        var bodyJson = _deserializer.DeserializeBody(record);
        var shiftedJson = _deserializer.DeserializeShifted(record);

        return (FormatSorted(bodyJson), FormatSorted(shiftedJson));
    }

    private static string FormatSorted(string json)
    {
        try
        {
            var token = JToken.Parse(json);
            return token.SortStrict().ToString(Formatting.Indented);
        }
        catch
        {
            return json;
        }
    }
}
