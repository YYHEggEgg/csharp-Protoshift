// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteHintPoint.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from LunaRiteHintPoint.proto</summary>
public static partial class LunaRiteHintPointReflection {

  #region Descriptor
  /// <summary>File descriptor for LunaRiteHintPoint.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static LunaRiteHintPointReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdMdW5hUml0ZUhpbnRQb2ludC5wcm90bxobTHVuYVJpdGVIaW50UG9pbnRU",
          "eXBlLnByb3RvGgxWZWN0b3IucHJvdG8ibwoRTHVuYVJpdGVIaW50UG9pbnQS",
          "DwoHYXJlYV9pZBgLIAEoDRINCgVpbmRleBgHIAEoDRIkCgR0eXBlGAIgASgO",
          "MhYuTHVuYVJpdGVIaW50UG9pbnRUeXBlEhQKA3BvcxgKIAEoCzIHLlZlY3Rv",
          "ckIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::LunaRiteHintPointTypeReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::LunaRiteHintPoint), global::LunaRiteHintPoint.Parser, new[]{ "AreaId", "Index", "Type", "Pos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class LunaRiteHintPoint : pb::IMessage<LunaRiteHintPoint>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<LunaRiteHintPoint> _parser = new pb::MessageParser<LunaRiteHintPoint>(() => new LunaRiteHintPoint());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<LunaRiteHintPoint> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::LunaRiteHintPointReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteHintPoint() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteHintPoint(LunaRiteHintPoint other) : this() {
    areaId_ = other.areaId_;
    index_ = other.index_;
    type_ = other.type_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public LunaRiteHintPoint Clone() {
    return new LunaRiteHintPoint(this);
  }

  /// <summary>Field number for the "area_id" field.</summary>
  public const int AreaIdFieldNumber = 11;
  private uint areaId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AreaId {
    get { return areaId_; }
    set {
      areaId_ = value;
    }
  }

  /// <summary>Field number for the "index" field.</summary>
  public const int IndexFieldNumber = 7;
  private uint index_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Index {
    get { return index_; }
    set {
      index_ = value;
    }
  }

  /// <summary>Field number for the "type" field.</summary>
  public const int TypeFieldNumber = 2;
  private global::LunaRiteHintPointType type_ = global::LunaRiteHintPointType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::LunaRiteHintPointType Type {
    get { return type_; }
    set {
      type_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 10;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as LunaRiteHintPoint);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(LunaRiteHintPoint other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AreaId != other.AreaId) return false;
    if (Index != other.Index) return false;
    if (Type != other.Type) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AreaId != 0) hash ^= AreaId.GetHashCode();
    if (Index != 0) hash ^= Index.GetHashCode();
    if (Type != global::LunaRiteHintPointType.None) hash ^= Type.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
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
    if (Type != global::LunaRiteHintPointType.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Type);
    }
    if (Index != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Index);
    }
    if (pos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(Pos);
    }
    if (AreaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(AreaId);
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
    if (Type != global::LunaRiteHintPointType.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) Type);
    }
    if (Index != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(Index);
    }
    if (pos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(Pos);
    }
    if (AreaId != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(AreaId);
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
    if (AreaId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
    }
    if (Index != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
    }
    if (Type != global::LunaRiteHintPointType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(LunaRiteHintPoint other) {
    if (other == null) {
      return;
    }
    if (other.AreaId != 0) {
      AreaId = other.AreaId;
    }
    if (other.Index != 0) {
      Index = other.Index;
    }
    if (other.Type != global::LunaRiteHintPointType.None) {
      Type = other.Type;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
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
        case 16: {
          Type = (global::LunaRiteHintPointType) input.ReadEnum();
          break;
        }
        case 56: {
          Index = input.ReadUInt32();
          break;
        }
        case 82: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 88: {
          AreaId = input.ReadUInt32();
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
        case 16: {
          Type = (global::LunaRiteHintPointType) input.ReadEnum();
          break;
        }
        case 56: {
          Index = input.ReadUInt32();
          break;
        }
        case 82: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 88: {
          AreaId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code