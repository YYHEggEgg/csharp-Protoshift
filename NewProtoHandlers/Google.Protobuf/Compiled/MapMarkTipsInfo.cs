// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MapMarkTipsInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MapMarkTipsInfo.proto</summary>
  public static partial class MapMarkTipsInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MapMarkTipsInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapMarkTipsInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNYXBNYXJrVGlwc0luZm8ucHJvdG8aFU1hcE1hcmtUaXBzVHlwZS5wcm90",
            "byJNCg9NYXBNYXJrVGlwc0luZm8SIwoJdGlwc190eXBlGAEgASgOMhAuTWFw",
            "TWFya1RpcHNUeXBlEhUKDXBvaW50X2lkX2xpc3QYAiADKA1CDKoCCU5ld1By",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.MapMarkTipsTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MapMarkTipsInfo), global::NewProtos.MapMarkTipsInfo.Parser, new[]{ "TipsType", "PointIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MapMarkTipsInfo : pb::IMessage<MapMarkTipsInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MapMarkTipsInfo> _parser = new pb::MessageParser<MapMarkTipsInfo>(() => new MapMarkTipsInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MapMarkTipsInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.MapMarkTipsInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo(MapMarkTipsInfo other) : this() {
      tipsType_ = other.tipsType_;
      pointIdList_ = other.pointIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo Clone() {
      return new MapMarkTipsInfo(this);
    }

    /// <summary>Field number for the "tips_type" field.</summary>
    public const int TipsTypeFieldNumber = 1;
    private global::NewProtos.MapMarkTipsType tipsType_ = global::NewProtos.MapMarkTipsType.DungeonElementTrial;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.MapMarkTipsType TipsType {
      get { return tipsType_; }
      set {
        tipsType_ = value;
      }
    }

    /// <summary>Field number for the "point_id_list" field.</summary>
    public const int PointIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_pointIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> pointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PointIdList {
      get { return pointIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MapMarkTipsInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MapMarkTipsInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TipsType != other.TipsType) return false;
      if(!pointIdList_.Equals(other.pointIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TipsType != global::NewProtos.MapMarkTipsType.DungeonElementTrial) hash ^= TipsType.GetHashCode();
      hash ^= pointIdList_.GetHashCode();
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
      if (TipsType != global::NewProtos.MapMarkTipsType.DungeonElementTrial) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TipsType);
      }
      pointIdList_.WriteTo(output, _repeated_pointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TipsType != global::NewProtos.MapMarkTipsType.DungeonElementTrial) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TipsType);
      }
      pointIdList_.WriteTo(ref output, _repeated_pointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TipsType != global::NewProtos.MapMarkTipsType.DungeonElementTrial) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TipsType);
      }
      size += pointIdList_.CalculateSize(_repeated_pointIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MapMarkTipsInfo other) {
      if (other == null) {
        return;
      }
      if (other.TipsType != global::NewProtos.MapMarkTipsType.DungeonElementTrial) {
        TipsType = other.TipsType;
      }
      pointIdList_.Add(other.pointIdList_);
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
          case 8: {
            TipsType = (global::NewProtos.MapMarkTipsType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            pointIdList_.AddEntriesFrom(input, _repeated_pointIdList_codec);
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
          case 8: {
            TipsType = (global::NewProtos.MapMarkTipsType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            pointIdList_.AddEntriesFrom(ref input, _repeated_pointIdList_codec);
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
