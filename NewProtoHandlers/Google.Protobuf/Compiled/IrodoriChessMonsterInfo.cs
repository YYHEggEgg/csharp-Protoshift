// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessMonsterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriChessMonsterInfo.proto</summary>
public static partial class IrodoriChessMonsterInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriChessMonsterInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriChessMonsterInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1Jcm9kb3JpQ2hlc3NNb25zdGVySW5mby5wcm90byJmChdJcm9kb3JpQ2hl",
          "c3NNb25zdGVySW5mbxIUCgxncmFudF9wb2ludHMYByABKA0SEgoKbW9uc3Rl",
          "cl9pZBgNIAEoDRINCgVsZXZlbBgLIAEoDRISCgphZmZpeF9saXN0GAogAygN",
          "QhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriChessMonsterInfo), global::IrodoriChessMonsterInfo.Parser, new[]{ "GrantPoints", "MonsterId", "Level", "AffixList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IrodoriChessMonsterInfo : pb::IMessage<IrodoriChessMonsterInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriChessMonsterInfo> _parser = new pb::MessageParser<IrodoriChessMonsterInfo>(() => new IrodoriChessMonsterInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriChessMonsterInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriChessMonsterInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessMonsterInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessMonsterInfo(IrodoriChessMonsterInfo other) : this() {
    grantPoints_ = other.grantPoints_;
    monsterId_ = other.monsterId_;
    level_ = other.level_;
    affixList_ = other.affixList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessMonsterInfo Clone() {
    return new IrodoriChessMonsterInfo(this);
  }

  /// <summary>Field number for the "grant_points" field.</summary>
  public const int GrantPointsFieldNumber = 7;
  private uint grantPoints_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GrantPoints {
    get { return grantPoints_; }
    set {
      grantPoints_ = value;
    }
  }

  /// <summary>Field number for the "monster_id" field.</summary>
  public const int MonsterIdFieldNumber = 13;
  private uint monsterId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MonsterId {
    get { return monsterId_; }
    set {
      monsterId_ = value;
    }
  }

  /// <summary>Field number for the "level" field.</summary>
  public const int LevelFieldNumber = 11;
  private uint level_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Level {
    get { return level_; }
    set {
      level_ = value;
    }
  }

  /// <summary>Field number for the "affix_list" field.</summary>
  public const int AffixListFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_affixList_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> affixList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> AffixList {
    get { return affixList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriChessMonsterInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriChessMonsterInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GrantPoints != other.GrantPoints) return false;
    if (MonsterId != other.MonsterId) return false;
    if (Level != other.Level) return false;
    if(!affixList_.Equals(other.affixList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (GrantPoints != 0) hash ^= GrantPoints.GetHashCode();
    if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
    if (Level != 0) hash ^= Level.GetHashCode();
    hash ^= affixList_.GetHashCode();
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
    if (GrantPoints != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(GrantPoints);
    }
    affixList_.WriteTo(output, _repeated_affixList_codec);
    if (Level != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Level);
    }
    if (MonsterId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(MonsterId);
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
    if (GrantPoints != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(GrantPoints);
    }
    affixList_.WriteTo(ref output, _repeated_affixList_codec);
    if (Level != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Level);
    }
    if (MonsterId != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(MonsterId);
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
    if (GrantPoints != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GrantPoints);
    }
    if (MonsterId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
    }
    if (Level != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
    }
    size += affixList_.CalculateSize(_repeated_affixList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriChessMonsterInfo other) {
    if (other == null) {
      return;
    }
    if (other.GrantPoints != 0) {
      GrantPoints = other.GrantPoints;
    }
    if (other.MonsterId != 0) {
      MonsterId = other.MonsterId;
    }
    if (other.Level != 0) {
      Level = other.Level;
    }
    affixList_.Add(other.affixList_);
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
        case 56: {
          GrantPoints = input.ReadUInt32();
          break;
        }
        case 82:
        case 80: {
          affixList_.AddEntriesFrom(input, _repeated_affixList_codec);
          break;
        }
        case 88: {
          Level = input.ReadUInt32();
          break;
        }
        case 104: {
          MonsterId = input.ReadUInt32();
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
        case 56: {
          GrantPoints = input.ReadUInt32();
          break;
        }
        case 82:
        case 80: {
          affixList_.AddEntriesFrom(ref input, _repeated_affixList_codec);
          break;
        }
        case 88: {
          Level = input.ReadUInt32();
          break;
        }
        case 104: {
          MonsterId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
