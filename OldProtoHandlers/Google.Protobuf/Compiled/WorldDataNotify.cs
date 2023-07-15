// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from WorldDataNotify.proto</summary>
  public static partial class WorldDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVXb3JsZERhdGFOb3RpZnkucHJvdG8aD1Byb3BWYWx1ZS5wcm90byLmAQoP",
            "V29ybGREYXRhTm90aWZ5EjoKDndvcmxkX3Byb3BfbWFwGAkgAygLMiIuV29y",
            "bGREYXRhTm90aWZ5LldvcmxkUHJvcE1hcEVudHJ5Gj8KEVdvcmxkUHJvcE1h",
            "cEVudHJ5EgsKA2tleRgBIAEoDRIZCgV2YWx1ZRgCIAEoCzIKLlByb3BWYWx1",
            "ZToCOAEiVgoIRGF0YVR5cGUSEgoOREFUQV9UWVBFX05PTkUQABIZChVEQVRB",
            "X1RZUEVfV09STERfTEVWRUwQARIbChdEQVRBX1RZUEVfSVNfSU5fTVBfTU9E",
            "RRACQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.PropValueReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.WorldDataNotify), global::OldProtos.WorldDataNotify.Parser, new[]{ "WorldPropMap" }, null, new[]{ typeof(global::OldProtos.WorldDataNotify.Types.DataType) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 3308
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class WorldDataNotify : pb::IMessage<WorldDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldDataNotify> _parser = new pb::MessageParser<WorldDataNotify>(() => new WorldDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.WorldDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldDataNotify(WorldDataNotify other) : this() {
      worldPropMap_ = other.worldPropMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldDataNotify Clone() {
      return new WorldDataNotify(this);
    }

    /// <summary>Field number for the "world_prop_map" field.</summary>
    public const int WorldPropMapFieldNumber = 9;
    private static readonly pbc::MapField<uint, global::OldProtos.PropValue>.Codec _map_worldPropMap_codec
        = new pbc::MapField<uint, global::OldProtos.PropValue>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::OldProtos.PropValue.Parser), 74);
    private readonly pbc::MapField<uint, global::OldProtos.PropValue> worldPropMap_ = new pbc::MapField<uint, global::OldProtos.PropValue>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::OldProtos.PropValue> WorldPropMap {
      get { return worldPropMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!WorldPropMap.Equals(other.WorldPropMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= WorldPropMap.GetHashCode();
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
      worldPropMap_.WriteTo(output, _map_worldPropMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      worldPropMap_.WriteTo(ref output, _map_worldPropMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += worldPropMap_.CalculateSize(_map_worldPropMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldDataNotify other) {
      if (other == null) {
        return;
      }
      worldPropMap_.Add(other.worldPropMap_);
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
          case 74: {
            worldPropMap_.AddEntriesFrom(input, _map_worldPropMap_codec);
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
          case 74: {
            worldPropMap_.AddEntriesFrom(ref input, _map_worldPropMap_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WorldDataNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum DataType {
        [pbr::OriginalName("DATA_TYPE_NONE")] None = 0,
        [pbr::OriginalName("DATA_TYPE_WORLD_LEVEL")] WorldLevel = 1,
        [pbr::OriginalName("DATA_TYPE_IS_IN_MP_MODE")] IsInMpMode = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
