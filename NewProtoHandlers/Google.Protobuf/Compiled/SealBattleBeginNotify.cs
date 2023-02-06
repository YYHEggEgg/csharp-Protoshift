// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SealBattleBeginNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SealBattleBeginNotify.proto</summary>
public static partial class SealBattleBeginNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SealBattleBeginNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SealBattleBeginNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtTZWFsQmF0dGxlQmVnaW5Ob3RpZnkucHJvdG8aFFNlYWxCYXR0bGVUeXBl",
          "LnByb3RvIoUBChVTZWFsQmF0dGxlQmVnaW5Ob3RpZnkSJAoLYmF0dGxlX3R5",
          "cGUYCiABKA4yDy5TZWFsQmF0dGxlVHlwZRIWCg5zZWFsX2VudGl0eV9pZBgH",
          "IAEoDRIZChFzZWFsX21heF9wcm9ncmVzcxgNIAEoDRITCgtzZWFsX3JhZGl1",
          "cxgFIAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SealBattleTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SealBattleBeginNotify), global::SealBattleBeginNotify.Parser, new[]{ "BattleType", "SealEntityId", "SealMaxProgress", "SealRadius" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 226;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class SealBattleBeginNotify : pb::IMessage<SealBattleBeginNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SealBattleBeginNotify> _parser = new pb::MessageParser<SealBattleBeginNotify>(() => new SealBattleBeginNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SealBattleBeginNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SealBattleBeginNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SealBattleBeginNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SealBattleBeginNotify(SealBattleBeginNotify other) : this() {
    battleType_ = other.battleType_;
    sealEntityId_ = other.sealEntityId_;
    sealMaxProgress_ = other.sealMaxProgress_;
    sealRadius_ = other.sealRadius_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SealBattleBeginNotify Clone() {
    return new SealBattleBeginNotify(this);
  }

  /// <summary>Field number for the "battle_type" field.</summary>
  public const int BattleTypeFieldNumber = 10;
  private global::SealBattleType battleType_ = global::SealBattleType.KeepAlive;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SealBattleType BattleType {
    get { return battleType_; }
    set {
      battleType_ = value;
    }
  }

  /// <summary>Field number for the "seal_entity_id" field.</summary>
  public const int SealEntityIdFieldNumber = 7;
  private uint sealEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealEntityId {
    get { return sealEntityId_; }
    set {
      sealEntityId_ = value;
    }
  }

  /// <summary>Field number for the "seal_max_progress" field.</summary>
  public const int SealMaxProgressFieldNumber = 13;
  private uint sealMaxProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealMaxProgress {
    get { return sealMaxProgress_; }
    set {
      sealMaxProgress_ = value;
    }
  }

  /// <summary>Field number for the "seal_radius" field.</summary>
  public const int SealRadiusFieldNumber = 5;
  private uint sealRadius_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealRadius {
    get { return sealRadius_; }
    set {
      sealRadius_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SealBattleBeginNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SealBattleBeginNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (BattleType != other.BattleType) return false;
    if (SealEntityId != other.SealEntityId) return false;
    if (SealMaxProgress != other.SealMaxProgress) return false;
    if (SealRadius != other.SealRadius) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (BattleType != global::SealBattleType.KeepAlive) hash ^= BattleType.GetHashCode();
    if (SealEntityId != 0) hash ^= SealEntityId.GetHashCode();
    if (SealMaxProgress != 0) hash ^= SealMaxProgress.GetHashCode();
    if (SealRadius != 0) hash ^= SealRadius.GetHashCode();
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
    if (SealRadius != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SealRadius);
    }
    if (SealEntityId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(SealEntityId);
    }
    if (BattleType != global::SealBattleType.KeepAlive) {
      output.WriteRawTag(80);
      output.WriteEnum((int) BattleType);
    }
    if (SealMaxProgress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(SealMaxProgress);
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
    if (SealRadius != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(SealRadius);
    }
    if (SealEntityId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(SealEntityId);
    }
    if (BattleType != global::SealBattleType.KeepAlive) {
      output.WriteRawTag(80);
      output.WriteEnum((int) BattleType);
    }
    if (SealMaxProgress != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(SealMaxProgress);
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
    if (BattleType != global::SealBattleType.KeepAlive) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BattleType);
    }
    if (SealEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealEntityId);
    }
    if (SealMaxProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealMaxProgress);
    }
    if (SealRadius != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealRadius);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SealBattleBeginNotify other) {
    if (other == null) {
      return;
    }
    if (other.BattleType != global::SealBattleType.KeepAlive) {
      BattleType = other.BattleType;
    }
    if (other.SealEntityId != 0) {
      SealEntityId = other.SealEntityId;
    }
    if (other.SealMaxProgress != 0) {
      SealMaxProgress = other.SealMaxProgress;
    }
    if (other.SealRadius != 0) {
      SealRadius = other.SealRadius;
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
        case 40: {
          SealRadius = input.ReadUInt32();
          break;
        }
        case 56: {
          SealEntityId = input.ReadUInt32();
          break;
        }
        case 80: {
          BattleType = (global::SealBattleType) input.ReadEnum();
          break;
        }
        case 104: {
          SealMaxProgress = input.ReadUInt32();
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
        case 40: {
          SealRadius = input.ReadUInt32();
          break;
        }
        case 56: {
          SealEntityId = input.ReadUInt32();
          break;
        }
        case 80: {
          BattleType = (global::SealBattleType) input.ReadEnum();
          break;
        }
        case 104: {
          SealMaxProgress = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code