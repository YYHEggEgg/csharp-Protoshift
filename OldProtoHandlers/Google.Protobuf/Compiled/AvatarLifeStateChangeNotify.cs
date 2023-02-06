// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarLifeStateChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AvatarLifeStateChangeNotify.proto</summary>
public static partial class AvatarLifeStateChangeNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for AvatarLifeStateChangeNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AvatarLifeStateChangeNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFBdmF0YXJMaWZlU3RhdGVDaGFuZ2VOb3RpZnkucHJvdG8aE1BsYXllckRp",
          "ZVR5cGUucHJvdG8aEFNlcnZlckJ1ZmYucHJvdG8i2AEKG0F2YXRhckxpZmVT",
          "dGF0ZUNoYW5nZU5vdGlmeRISCgpsaWZlX3N0YXRlGA0gASgNEhIKCmF0dGFj",
          "a190YWcYCiABKAkSIAoIZGllX3R5cGUYAiABKA4yDi5QbGF5ZXJEaWVUeXBl",
          "EiUKEHNlcnZlcl9idWZmX2xpc3QYDCADKAsyCy5TZXJ2ZXJCdWZmEhkKEW1v",
          "dmVfcmVsaWFibGVfc2VxGAUgASgNEhgKEHNvdXJjZV9lbnRpdHlfaWQYAyAB",
          "KA0SEwoLYXZhdGFyX2d1aWQYCyABKARCHgocZW11LmdyYXNzY3V0dGVyLm5l",
          "dC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::PlayerDieTypeReflection.Descriptor, global::ServerBuffReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AvatarLifeStateChangeNotify), global::AvatarLifeStateChangeNotify.Parser, new[]{ "LifeState", "AttackTag", "DieType", "ServerBuffList", "MoveReliableSeq", "SourceEntityId", "AvatarGuid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 1290
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class AvatarLifeStateChangeNotify : pb::IMessage<AvatarLifeStateChangeNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AvatarLifeStateChangeNotify> _parser = new pb::MessageParser<AvatarLifeStateChangeNotify>(() => new AvatarLifeStateChangeNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AvatarLifeStateChangeNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AvatarLifeStateChangeNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarLifeStateChangeNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarLifeStateChangeNotify(AvatarLifeStateChangeNotify other) : this() {
    lifeState_ = other.lifeState_;
    attackTag_ = other.attackTag_;
    dieType_ = other.dieType_;
    serverBuffList_ = other.serverBuffList_.Clone();
    moveReliableSeq_ = other.moveReliableSeq_;
    sourceEntityId_ = other.sourceEntityId_;
    avatarGuid_ = other.avatarGuid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AvatarLifeStateChangeNotify Clone() {
    return new AvatarLifeStateChangeNotify(this);
  }

  /// <summary>Field number for the "life_state" field.</summary>
  public const int LifeStateFieldNumber = 13;
  private uint lifeState_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LifeState {
    get { return lifeState_; }
    set {
      lifeState_ = value;
    }
  }

  /// <summary>Field number for the "attack_tag" field.</summary>
  public const int AttackTagFieldNumber = 10;
  private string attackTag_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string AttackTag {
    get { return attackTag_; }
    set {
      attackTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "die_type" field.</summary>
  public const int DieTypeFieldNumber = 2;
  private global::PlayerDieType dieType_ = global::PlayerDieType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::PlayerDieType DieType {
    get { return dieType_; }
    set {
      dieType_ = value;
    }
  }

  /// <summary>Field number for the "server_buff_list" field.</summary>
  public const int ServerBuffListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::ServerBuff> _repeated_serverBuffList_codec
      = pb::FieldCodec.ForMessage(98, global::ServerBuff.Parser);
  private readonly pbc::RepeatedField<global::ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::ServerBuff>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ServerBuff> ServerBuffList {
    get { return serverBuffList_; }
  }

  /// <summary>Field number for the "move_reliable_seq" field.</summary>
  public const int MoveReliableSeqFieldNumber = 5;
  private uint moveReliableSeq_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MoveReliableSeq {
    get { return moveReliableSeq_; }
    set {
      moveReliableSeq_ = value;
    }
  }

  /// <summary>Field number for the "source_entity_id" field.</summary>
  public const int SourceEntityIdFieldNumber = 3;
  private uint sourceEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SourceEntityId {
    get { return sourceEntityId_; }
    set {
      sourceEntityId_ = value;
    }
  }

  /// <summary>Field number for the "avatar_guid" field.</summary>
  public const int AvatarGuidFieldNumber = 11;
  private ulong avatarGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong AvatarGuid {
    get { return avatarGuid_; }
    set {
      avatarGuid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AvatarLifeStateChangeNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AvatarLifeStateChangeNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (LifeState != other.LifeState) return false;
    if (AttackTag != other.AttackTag) return false;
    if (DieType != other.DieType) return false;
    if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
    if (MoveReliableSeq != other.MoveReliableSeq) return false;
    if (SourceEntityId != other.SourceEntityId) return false;
    if (AvatarGuid != other.AvatarGuid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (LifeState != 0) hash ^= LifeState.GetHashCode();
    if (AttackTag.Length != 0) hash ^= AttackTag.GetHashCode();
    if (DieType != global::PlayerDieType.None) hash ^= DieType.GetHashCode();
    hash ^= serverBuffList_.GetHashCode();
    if (MoveReliableSeq != 0) hash ^= MoveReliableSeq.GetHashCode();
    if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
    if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
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
    if (DieType != global::PlayerDieType.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) DieType);
    }
    if (SourceEntityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SourceEntityId);
    }
    if (MoveReliableSeq != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MoveReliableSeq);
    }
    if (AttackTag.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(AttackTag);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(88);
      output.WriteUInt64(AvatarGuid);
    }
    serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
    if (LifeState != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LifeState);
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
    if (DieType != global::PlayerDieType.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) DieType);
    }
    if (SourceEntityId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SourceEntityId);
    }
    if (MoveReliableSeq != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(MoveReliableSeq);
    }
    if (AttackTag.Length != 0) {
      output.WriteRawTag(82);
      output.WriteString(AttackTag);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(88);
      output.WriteUInt64(AvatarGuid);
    }
    serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
    if (LifeState != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(LifeState);
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
    if (LifeState != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeState);
    }
    if (AttackTag.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(AttackTag);
    }
    if (DieType != global::PlayerDieType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DieType);
    }
    size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
    if (MoveReliableSeq != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MoveReliableSeq);
    }
    if (SourceEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
    }
    if (AvatarGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AvatarLifeStateChangeNotify other) {
    if (other == null) {
      return;
    }
    if (other.LifeState != 0) {
      LifeState = other.LifeState;
    }
    if (other.AttackTag.Length != 0) {
      AttackTag = other.AttackTag;
    }
    if (other.DieType != global::PlayerDieType.None) {
      DieType = other.DieType;
    }
    serverBuffList_.Add(other.serverBuffList_);
    if (other.MoveReliableSeq != 0) {
      MoveReliableSeq = other.MoveReliableSeq;
    }
    if (other.SourceEntityId != 0) {
      SourceEntityId = other.SourceEntityId;
    }
    if (other.AvatarGuid != 0UL) {
      AvatarGuid = other.AvatarGuid;
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
          DieType = (global::PlayerDieType) input.ReadEnum();
          break;
        }
        case 24: {
          SourceEntityId = input.ReadUInt32();
          break;
        }
        case 40: {
          MoveReliableSeq = input.ReadUInt32();
          break;
        }
        case 82: {
          AttackTag = input.ReadString();
          break;
        }
        case 88: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 98: {
          serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
          break;
        }
        case 104: {
          LifeState = input.ReadUInt32();
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
          DieType = (global::PlayerDieType) input.ReadEnum();
          break;
        }
        case 24: {
          SourceEntityId = input.ReadUInt32();
          break;
        }
        case 40: {
          MoveReliableSeq = input.ReadUInt32();
          break;
        }
        case 82: {
          AttackTag = input.ReadString();
          break;
        }
        case 88: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 98: {
          serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
          break;
        }
        case 104: {
          LifeState = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
