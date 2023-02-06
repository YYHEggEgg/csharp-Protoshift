// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryRoomInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RogueDiaryRoomInfo.proto</summary>
public static partial class RogueDiaryRoomInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for RogueDiaryRoomInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RogueDiaryRoomInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhSb2d1ZURpYXJ5Um9vbUluZm8ucHJvdG8aEFVpbnQzMlBhaXIucHJvdG8i",
          "WwoSUm9ndWVEaWFyeVJvb21JbmZvEiEKDG1vbnN0ZXJfbGlzdBgBIAMoCzIL",
          "LlVpbnQzMlBhaXISDwoHaXNfYm9zcxgDIAEoCBIRCgljb25maWdfaWQYByAB",
          "KA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Uint32PairReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RogueDiaryRoomInfo), global::RogueDiaryRoomInfo.Parser, new[]{ "MonsterList", "IsBoss", "ConfigId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RogueDiaryRoomInfo : pb::IMessage<RogueDiaryRoomInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RogueDiaryRoomInfo> _parser = new pb::MessageParser<RogueDiaryRoomInfo>(() => new RogueDiaryRoomInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RogueDiaryRoomInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RogueDiaryRoomInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RogueDiaryRoomInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RogueDiaryRoomInfo(RogueDiaryRoomInfo other) : this() {
    monsterList_ = other.monsterList_.Clone();
    isBoss_ = other.isBoss_;
    configId_ = other.configId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RogueDiaryRoomInfo Clone() {
    return new RogueDiaryRoomInfo(this);
  }

  /// <summary>Field number for the "monster_list" field.</summary>
  public const int MonsterListFieldNumber = 1;
  private static readonly pb::FieldCodec<global::Uint32Pair> _repeated_monsterList_codec
      = pb::FieldCodec.ForMessage(10, global::Uint32Pair.Parser);
  private readonly pbc::RepeatedField<global::Uint32Pair> monsterList_ = new pbc::RepeatedField<global::Uint32Pair>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::Uint32Pair> MonsterList {
    get { return monsterList_; }
  }

  /// <summary>Field number for the "is_boss" field.</summary>
  public const int IsBossFieldNumber = 3;
  private bool isBoss_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsBoss {
    get { return isBoss_; }
    set {
      isBoss_ = value;
    }
  }

  /// <summary>Field number for the "config_id" field.</summary>
  public const int ConfigIdFieldNumber = 7;
  private uint configId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ConfigId {
    get { return configId_; }
    set {
      configId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RogueDiaryRoomInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RogueDiaryRoomInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!monsterList_.Equals(other.monsterList_)) return false;
    if (IsBoss != other.IsBoss) return false;
    if (ConfigId != other.ConfigId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= monsterList_.GetHashCode();
    if (IsBoss != false) hash ^= IsBoss.GetHashCode();
    if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
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
    monsterList_.WriteTo(output, _repeated_monsterList_codec);
    if (IsBoss != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsBoss);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ConfigId);
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
    monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
    if (IsBoss != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsBoss);
    }
    if (ConfigId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ConfigId);
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
    size += monsterList_.CalculateSize(_repeated_monsterList_codec);
    if (IsBoss != false) {
      size += 1 + 1;
    }
    if (ConfigId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RogueDiaryRoomInfo other) {
    if (other == null) {
      return;
    }
    monsterList_.Add(other.monsterList_);
    if (other.IsBoss != false) {
      IsBoss = other.IsBoss;
    }
    if (other.ConfigId != 0) {
      ConfigId = other.ConfigId;
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
        case 10: {
          monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
          break;
        }
        case 24: {
          IsBoss = input.ReadBool();
          break;
        }
        case 56: {
          ConfigId = input.ReadUInt32();
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
        case 10: {
          monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
          break;
        }
        case 24: {
          IsBoss = input.ReadBool();
          break;
        }
        case 56: {
          ConfigId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
