using Google.Protobuf;
using PacketLogInspector.Models;
using System.Text.Json;
using YYHEggEgg.Logger;

namespace PacketLogInspector.Services;

/// <summary>
/// Singleton service that initializes OldProtos/NewProtos QueryJsonSerializer
/// and provides deserialization methods for packet bodies.
/// </summary>
public class ProtoDeserializerService
{
    private static bool _eggEggLoggerInitialized = false;
    private static readonly object _initLock = new();

    // Use WithFormatDefaultValues so proto3 fields with default values (0 / empty string)
    // are still included in the JSON output, instead of being silently omitted.
    private static readonly JsonFormatter _fullFormatter =
        new(JsonFormatter.Settings.Default.WithFormatDefaultValues(true));

    private static readonly JsonSerializerOptions _prettyOptions =
        new() { WriteIndented = true };

    public ProtoDeserializerService(ILogger<ProtoDeserializerService> logger)
    {
        // EggEgg.CSharp-Logger must be initialized before QueryJsonSerializer
        // static constructors run (they use Log.Dbug/Log.Warn internally).
        lock (_initLock)
        {
            if (!_eggEggLoggerInitialized)
            {
                Log.Initialize(new LoggerConfig(
                    max_Output_Char_Count: 16 * 1024,
                    use_Console_Wrapper: false,
                    use_Working_Directory: true,
                    global_Minimum_LogLevel: YYHEggEgg.Logger.LogLevel.Information,
                    console_Minimum_LogLevel: YYHEggEgg.Logger.LogLevel.Warning,
                    debug_LogWriter_AutoFlush: false
                ));
                _eggEggLoggerInitialized = true;
            }
        }

        // Trigger static constructors (initialization is idempotent)
        var oldMsg = OldProtos.QueryJsonSerializer.Initialize();
        var newMsg = NewProtos.QueryJsonSerializer.Initialize();
        logger.LogInformation("Proto serializers ready: {Old} | {New}", oldMsg, newMsg);
    }

    /// <summary>
    /// Deserializes and pretty-prints a protobuf byte array using the given serializer.
    /// Uses WithFormatDefaultValues to prevent proto3 default-value fields from being omitted.
    /// </summary>
    private string FormatBytes(OldProtos.ProtoSerializeJson s, byte[] bytes)
    {
        var msg = s.Deserialize(bytes);
        return PrettyPrint(_fullFormatter.Format(msg));
    }

    private string FormatBytes(NewProtos.ProtoSerializeJson s, byte[] bytes)
    {
        var msg = s.Deserialize(bytes);
        return PrettyPrint(_fullFormatter.Format(msg));
    }

    private static string PrettyPrint(string compactJson)
    {
        try
        {
            using var doc = JsonDocument.Parse(compactJson);
            return JsonSerializer.Serialize(doc.RootElement, _prettyOptions);
        }
        catch { return compactJson; }
    }

    /// <summary>
    /// Deserializes the body bytes of a packet record to a pretty-printed JSON string.
    /// SentByClient=true → body is NewProtos; SentByClient=false → body is OldProtos.
    /// </summary>
    public string DeserializeBody(PacketRecord record)
    {
        if (record.BodyBytes.Length == 0) return "{}";
        try
        {
            if (record.SentByClient)
            {
                if (NewProtos.QueryJsonSerializer.TryGetJsonSerializer(record.PacketName, out var s))
                    return FormatBytes(s, record.BodyBytes);
            }
            else
            {
                if (OldProtos.QueryJsonSerializer.TryGetJsonSerializer(record.PacketName, out var s))
                    return FormatBytes(s, record.BodyBytes);
            }
        }
        catch { /* fall through to default */ }
        return "{}";
    }

    /// <summary>
    /// Deserializes the shiftedData bytes of a packet record to a pretty-printed JSON string.
    /// SentByClient=true → shiftedData is OldProtos; SentByClient=false → shiftedData is NewProtos.
    /// </summary>
    public string DeserializeShifted(PacketRecord record)
    {
        if (record.ShiftedDataBytes.Length == 0) return "{}";
        try
        {
            if (record.SentByClient)
            {
                // Client packet: body=NewProtos, shiftedData=OldProtos
                if (OldProtos.QueryJsonSerializer.TryGetJsonSerializer(record.PacketName, out var s))
                    return FormatBytes(s, record.ShiftedDataBytes);
            }
            else
            {
                // Server packet: body=OldProtos, shiftedData=NewProtos
                if (NewProtos.QueryJsonSerializer.TryGetJsonSerializer(record.PacketName, out var s))
                    return FormatBytes(s, record.ShiftedDataBytes);
            }
        }
        catch { /* fall through to default */ }
        return "{}";
    }
}
