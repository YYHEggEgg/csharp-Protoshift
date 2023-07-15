// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SetSceneWeatherAreaReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from SetSceneWeatherAreaReq.proto</summary>
  public static partial class SetSceneWeatherAreaReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SetSceneWeatherAreaReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetSceneWeatherAreaReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTZXRTY2VuZVdlYXRoZXJBcmVhUmVxLnByb3RvIrQBChZTZXRTY2VuZVdl",
            "YXRoZXJBcmVhUmVxEhkKEXdlYXRoZXJfZ2FkZ2V0X2lkGA0gASgNEkcKEXdl",
            "YXRoZXJfdmFsdWVfbWFwGAQgAygLMiwuU2V0U2NlbmVXZWF0aGVyQXJlYVJl",
            "cS5XZWF0aGVyVmFsdWVNYXBFbnRyeRo2ChRXZWF0aGVyVmFsdWVNYXBFbnRy",
            "eRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAk6AjgBQgyqAglPbGRQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.SetSceneWeatherAreaReq), global::OldProtos.SetSceneWeatherAreaReq.Parser, new[]{ "WeatherGadgetId", "WeatherValueMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 254
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class SetSceneWeatherAreaReq : pb::IMessage<SetSceneWeatherAreaReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SetSceneWeatherAreaReq> _parser = new pb::MessageParser<SetSceneWeatherAreaReq>(() => new SetSceneWeatherAreaReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SetSceneWeatherAreaReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.SetSceneWeatherAreaReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetSceneWeatherAreaReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetSceneWeatherAreaReq(SetSceneWeatherAreaReq other) : this() {
      weatherGadgetId_ = other.weatherGadgetId_;
      weatherValueMap_ = other.weatherValueMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SetSceneWeatherAreaReq Clone() {
      return new SetSceneWeatherAreaReq(this);
    }

    /// <summary>Field number for the "weather_gadget_id" field.</summary>
    public const int WeatherGadgetIdFieldNumber = 13;
    private uint weatherGadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WeatherGadgetId {
      get { return weatherGadgetId_; }
      set {
        weatherGadgetId_ = value;
      }
    }

    /// <summary>Field number for the "weather_value_map" field.</summary>
    public const int WeatherValueMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, string>.Codec _map_weatherValueMap_codec
        = new pbc::MapField<uint, string>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForString(18, ""), 34);
    private readonly pbc::MapField<uint, string> weatherValueMap_ = new pbc::MapField<uint, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, string> WeatherValueMap {
      get { return weatherValueMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SetSceneWeatherAreaReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SetSceneWeatherAreaReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WeatherGadgetId != other.WeatherGadgetId) return false;
      if (!WeatherValueMap.Equals(other.WeatherValueMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (WeatherGadgetId != 0) hash ^= WeatherGadgetId.GetHashCode();
      hash ^= WeatherValueMap.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      weatherValueMap_.WriteTo(output, _map_weatherValueMap_codec);
      if (WeatherGadgetId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WeatherGadgetId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      weatherValueMap_.WriteTo(ref output, _map_weatherValueMap_codec);
      if (WeatherGadgetId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(WeatherGadgetId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (WeatherGadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WeatherGadgetId);
      }
      size += weatherValueMap_.CalculateSize(_map_weatherValueMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SetSceneWeatherAreaReq other) {
      if (other == null) {
        return;
      }
      if (other.WeatherGadgetId != 0) {
        WeatherGadgetId = other.WeatherGadgetId;
      }
      weatherValueMap_.Add(other.weatherValueMap_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 34: {
            weatherValueMap_.AddEntriesFrom(input, _map_weatherValueMap_codec);
            break;
          }
          case 104: {
            WeatherGadgetId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 34: {
            weatherValueMap_.AddEntriesFrom(ref input, _map_weatherValueMap_codec);
            break;
          }
          case 104: {
            WeatherGadgetId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
