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
          "LnByb3RvIoUBChVTZWFsQmF0dGxlQmVnaW5Ob3RpZnkSGQoRc2VhbF9tYXhf",
          "cHJvZ3Jlc3MYCSABKA0SFgoOc2VhbF9lbnRpdHlfaWQYASABKA0SEwoLc2Vh",
          "bF9yYWRpdXMYDCABKA0SJAoLYmF0dGxlX3R5cGUYDiABKA4yDy5TZWFsQmF0",
          "dGxlVHlwZUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90",
          "bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SealBattleTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SealBattleBeginNotify), global::SealBattleBeginNotify.Parser, new[]{ "SealMaxProgress", "SealEntityId", "SealRadius", "BattleType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 289
/// EnetChannelId: 0
/// EnetIsReliable: true
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
    sealMaxProgress_ = other.sealMaxProgress_;
    sealEntityId_ = other.sealEntityId_;
    sealRadius_ = other.sealRadius_;
    battleType_ = other.battleType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SealBattleBeginNotify Clone() {
    return new SealBattleBeginNotify(this);
  }

  /// <summary>Field number for the "seal_max_progress" field.</summary>
  public const int SealMaxProgressFieldNumber = 9;
  private uint sealMaxProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealMaxProgress {
    get { return sealMaxProgress_; }
    set {
      sealMaxProgress_ = value;
    }
  }

  /// <summary>Field number for the "seal_entity_id" field.</summary>
  public const int SealEntityIdFieldNumber = 1;
  private uint sealEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealEntityId {
    get { return sealEntityId_; }
    set {
      sealEntityId_ = value;
    }
  }

  /// <summary>Field number for the "seal_radius" field.</summary>
  public const int SealRadiusFieldNumber = 12;
  private uint sealRadius_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SealRadius {
    get { return sealRadius_; }
    set {
      sealRadius_ = value;
    }
  }

  /// <summary>Field number for the "battle_type" field.</summary>
  public const int BattleTypeFieldNumber = 14;
  private global::SealBattleType battleType_ = global::SealBattleType.KeepAlive;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SealBattleType BattleType {
    get { return battleType_; }
    set {
      battleType_ = value;
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
    if (SealMaxProgress != other.SealMaxProgress) return false;
    if (SealEntityId != other.SealEntityId) return false;
    if (SealRadius != other.SealRadius) return false;
    if (BattleType != other.BattleType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (SealMaxProgress != 0) hash ^= SealMaxProgress.GetHashCode();
    if (SealEntityId != 0) hash ^= SealEntityId.GetHashCode();
    if (SealRadius != 0) hash ^= SealRadius.GetHashCode();
    if (BattleType != global::SealBattleType.KeepAlive) hash ^= BattleType.GetHashCode();
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
    if (SealEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(SealEntityId);
    }
    if (SealMaxProgress != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(SealMaxProgress);
    }
    if (SealRadius != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(SealRadius);
    }
    if (BattleType != global::SealBattleType.KeepAlive) {
      output.WriteRawTag(112);
      output.WriteEnum((int) BattleType);
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
    if (SealEntityId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(SealEntityId);
    }
    if (SealMaxProgress != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(SealMaxProgress);
    }
    if (SealRadius != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(SealRadius);
    }
    if (BattleType != global::SealBattleType.KeepAlive) {
      output.WriteRawTag(112);
      output.WriteEnum((int) BattleType);
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
    if (SealMaxProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealMaxProgress);
    }
    if (SealEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealEntityId);
    }
    if (SealRadius != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SealRadius);
    }
    if (BattleType != global::SealBattleType.KeepAlive) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BattleType);
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
    if (other.SealMaxProgress != 0) {
      SealMaxProgress = other.SealMaxProgress;
    }
    if (other.SealEntityId != 0) {
      SealEntityId = other.SealEntityId;
    }
    if (other.SealRadius != 0) {
      SealRadius = other.SealRadius;
    }
    if (other.BattleType != global::SealBattleType.KeepAlive) {
      BattleType = other.BattleType;
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
        case 8: {
          SealEntityId = input.ReadUInt32();
          break;
        }
        case 72: {
          SealMaxProgress = input.ReadUInt32();
          break;
        }
        case 96: {
          SealRadius = input.ReadUInt32();
          break;
        }
        case 112: {
          BattleType = (global::SealBattleType) input.ReadEnum();
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
          SealEntityId = input.ReadUInt32();
          break;
        }
        case 72: {
          SealMaxProgress = input.ReadUInt32();
          break;
        }
        case 96: {
          SealRadius = input.ReadUInt32();
          break;
        }
        case 112: {
          BattleType = (global::SealBattleType) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
