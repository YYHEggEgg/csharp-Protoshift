// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessEquipCardRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriChessEquipCardRsp.proto</summary>
public static partial class IrodoriChessEquipCardRspReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriChessEquipCardRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriChessEquipCardRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5Jcm9kb3JpQ2hlc3NFcXVpcENhcmRSc3AucHJvdG8iYwoYSXJvZG9yaUNo",
          "ZXNzRXF1aXBDYXJkUnNwEg8KB3JldGNvZGUYAiABKAUSDwoHY2FyZF9pZBgI",
          "IAEoDRIQCghsZXZlbF9pZBgFIAEoDRITCgtpc19oYXJkX21hcBgMIAEoCEIe",
          "ChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriChessEquipCardRsp), global::IrodoriChessEquipCardRsp.Parser, new[]{ "Retcode", "CardId", "LevelId", "IsHardMap" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 8308
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class IrodoriChessEquipCardRsp : pb::IMessage<IrodoriChessEquipCardRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriChessEquipCardRsp> _parser = new pb::MessageParser<IrodoriChessEquipCardRsp>(() => new IrodoriChessEquipCardRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriChessEquipCardRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriChessEquipCardRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEquipCardRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEquipCardRsp(IrodoriChessEquipCardRsp other) : this() {
    retcode_ = other.retcode_;
    cardId_ = other.cardId_;
    levelId_ = other.levelId_;
    isHardMap_ = other.isHardMap_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessEquipCardRsp Clone() {
    return new IrodoriChessEquipCardRsp(this);
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 2;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "card_id" field.</summary>
  public const int CardIdFieldNumber = 8;
  private uint cardId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CardId {
    get { return cardId_; }
    set {
      cardId_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 5;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "is_hard_map" field.</summary>
  public const int IsHardMapFieldNumber = 12;
  private bool isHardMap_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsHardMap {
    get { return isHardMap_; }
    set {
      isHardMap_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriChessEquipCardRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriChessEquipCardRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Retcode != other.Retcode) return false;
    if (CardId != other.CardId) return false;
    if (LevelId != other.LevelId) return false;
    if (IsHardMap != other.IsHardMap) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (CardId != 0) hash ^= CardId.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (IsHardMap != false) hash ^= IsHardMap.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Retcode);
    }
    if (LevelId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(LevelId);
    }
    if (CardId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CardId);
    }
    if (IsHardMap != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsHardMap);
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
    if (Retcode != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Retcode);
    }
    if (LevelId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(LevelId);
    }
    if (CardId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CardId);
    }
    if (IsHardMap != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsHardMap);
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
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (CardId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardId);
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (IsHardMap != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriChessEquipCardRsp other) {
    if (other == null) {
      return;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.CardId != 0) {
      CardId = other.CardId;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.IsHardMap != false) {
      IsHardMap = other.IsHardMap;
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
          Retcode = input.ReadInt32();
          break;
        }
        case 40: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 64: {
          CardId = input.ReadUInt32();
          break;
        }
        case 96: {
          IsHardMap = input.ReadBool();
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
          Retcode = input.ReadInt32();
          break;
        }
        case 40: {
          LevelId = input.ReadUInt32();
          break;
        }
        case 64: {
          CardId = input.ReadUInt32();
          break;
        }
        case 96: {
          IsHardMap = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
