// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleMechanicusConfirmCardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InBattleMechanicusConfirmCardRsp.proto</summary>
public static partial class InBattleMechanicusConfirmCardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for InBattleMechanicusConfirmCardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InBattleMechanicusConfirmCardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiZJbkJhdHRsZU1lY2hhbmljdXNDb25maXJtQ2FyZFJzcC5wcm90byJqCiBJ",
          "bkJhdHRsZU1lY2hhbmljdXNDb25maXJtQ2FyZFJzcBISCgpwbGF5X2luZGV4",
          "GAIgASgNEg8KB2NhcmRfaWQYDiABKA0SDwoHcmV0Y29kZRgLIAEoBRIQCghn",
          "cm91cF9pZBgGIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3Rv",
          "YgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InBattleMechanicusConfirmCardRsp), global::InBattleMechanicusConfirmCardRsp.Parser, new[]{ "PlayIndex", "CardId", "Retcode", "GroupId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 5375
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class InBattleMechanicusConfirmCardRsp : pb::IMessage<InBattleMechanicusConfirmCardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InBattleMechanicusConfirmCardRsp> _parser = new pb::MessageParser<InBattleMechanicusConfirmCardRsp>(() => new InBattleMechanicusConfirmCardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InBattleMechanicusConfirmCardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InBattleMechanicusConfirmCardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusConfirmCardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusConfirmCardRsp(InBattleMechanicusConfirmCardRsp other) : this() {
    playIndex_ = other.playIndex_;
    cardId_ = other.cardId_;
    retcode_ = other.retcode_;
    groupId_ = other.groupId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleMechanicusConfirmCardRsp Clone() {
    return new InBattleMechanicusConfirmCardRsp(this);
  }

  /// <summary>Field number for the "play_index" field.</summary>
  public const int PlayIndexFieldNumber = 2;
  private uint playIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayIndex {
    get { return playIndex_; }
    set {
      playIndex_ = value;
    }
  }

  /// <summary>Field number for the "card_id" field.</summary>
  public const int CardIdFieldNumber = 14;
  private uint cardId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CardId {
    get { return cardId_; }
    set {
      cardId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 11;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 6;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InBattleMechanicusConfirmCardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InBattleMechanicusConfirmCardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (PlayIndex != other.PlayIndex) return false;
    if (CardId != other.CardId) return false;
    if (Retcode != other.Retcode) return false;
    if (GroupId != other.GroupId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (PlayIndex != 0) hash ^= PlayIndex.GetHashCode();
    if (CardId != 0) hash ^= CardId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
    if (PlayIndex != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PlayIndex);
    }
    if (GroupId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GroupId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
    }
    if (CardId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CardId);
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
    if (PlayIndex != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(PlayIndex);
    }
    if (GroupId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(GroupId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
    }
    if (CardId != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(CardId);
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
    if (PlayIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayIndex);
    }
    if (CardId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InBattleMechanicusConfirmCardRsp other) {
    if (other == null) {
      return;
    }
    if (other.PlayIndex != 0) {
      PlayIndex = other.PlayIndex;
    }
    if (other.CardId != 0) {
      CardId = other.CardId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
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
          PlayIndex = input.ReadUInt32();
          break;
        }
        case 48: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
          break;
        }
        case 112: {
          CardId = input.ReadUInt32();
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
          PlayIndex = input.ReadUInt32();
          break;
        }
        case 48: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
          break;
        }
        case 112: {
          CardId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
