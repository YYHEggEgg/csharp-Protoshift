// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrialAvatarInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TrialAvatarInfo.proto</summary>
public static partial class TrialAvatarInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for TrialAvatarInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TrialAvatarInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVUcmlhbEF2YXRhckluZm8ucHJvdG8aCkl0ZW0ucHJvdG8aHFRyaWFsQXZh",
          "dGFyR3JhbnRSZWNvcmQucHJvdG8iegoPVHJpYWxBdmF0YXJJbmZvEhcKD3Ry",
          "aWFsX2F2YXRhcl9pZBgBIAEoDRIfChB0cmlhbF9lcXVpcF9saXN0GAIgAygL",
          "MgUuSXRlbRItCgxncmFudF9yZWNvcmQYAyABKAsyFy5UcmlhbEF2YXRhckdy",
          "YW50UmVjb3JkQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ItemReflection.Descriptor, global::TrialAvatarGrantRecordReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TrialAvatarInfo), global::TrialAvatarInfo.Parser, new[]{ "TrialAvatarId", "TrialEquipList", "GrantRecord" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TrialAvatarInfo : pb::IMessage<TrialAvatarInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TrialAvatarInfo> _parser = new pb::MessageParser<TrialAvatarInfo>(() => new TrialAvatarInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TrialAvatarInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TrialAvatarInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TrialAvatarInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TrialAvatarInfo(TrialAvatarInfo other) : this() {
    trialAvatarId_ = other.trialAvatarId_;
    trialEquipList_ = other.trialEquipList_.Clone();
    grantRecord_ = other.grantRecord_ != null ? other.grantRecord_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TrialAvatarInfo Clone() {
    return new TrialAvatarInfo(this);
  }

  /// <summary>Field number for the "trial_avatar_id" field.</summary>
  public const int TrialAvatarIdFieldNumber = 1;
  private uint trialAvatarId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TrialAvatarId {
    get { return trialAvatarId_; }
    set {
      trialAvatarId_ = value;
    }
  }

  /// <summary>Field number for the "trial_equip_list" field.</summary>
  public const int TrialEquipListFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Item> _repeated_trialEquipList_codec
      = pb::FieldCodec.ForMessage(18, global::Item.Parser);
  private readonly pbc::RepeatedField<global::Item> trialEquipList_ = new pbc::RepeatedField<global::Item>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::Item> TrialEquipList {
    get { return trialEquipList_; }
  }

  /// <summary>Field number for the "grant_record" field.</summary>
  public const int GrantRecordFieldNumber = 3;
  private global::TrialAvatarGrantRecord grantRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::TrialAvatarGrantRecord GrantRecord {
    get { return grantRecord_; }
    set {
      grantRecord_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TrialAvatarInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TrialAvatarInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TrialAvatarId != other.TrialAvatarId) return false;
    if(!trialEquipList_.Equals(other.trialEquipList_)) return false;
    if (!object.Equals(GrantRecord, other.GrantRecord)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (TrialAvatarId != 0) hash ^= TrialAvatarId.GetHashCode();
    hash ^= trialEquipList_.GetHashCode();
    if (grantRecord_ != null) hash ^= GrantRecord.GetHashCode();
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
    if (TrialAvatarId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(TrialAvatarId);
    }
    trialEquipList_.WriteTo(output, _repeated_trialEquipList_codec);
    if (grantRecord_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(GrantRecord);
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
    if (TrialAvatarId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(TrialAvatarId);
    }
    trialEquipList_.WriteTo(ref output, _repeated_trialEquipList_codec);
    if (grantRecord_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(GrantRecord);
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
    if (TrialAvatarId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialAvatarId);
    }
    size += trialEquipList_.CalculateSize(_repeated_trialEquipList_codec);
    if (grantRecord_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrantRecord);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TrialAvatarInfo other) {
    if (other == null) {
      return;
    }
    if (other.TrialAvatarId != 0) {
      TrialAvatarId = other.TrialAvatarId;
    }
    trialEquipList_.Add(other.trialEquipList_);
    if (other.grantRecord_ != null) {
      if (grantRecord_ == null) {
        GrantRecord = new global::TrialAvatarGrantRecord();
      }
      GrantRecord.MergeFrom(other.GrantRecord);
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
          TrialAvatarId = input.ReadUInt32();
          break;
        }
        case 18: {
          trialEquipList_.AddEntriesFrom(input, _repeated_trialEquipList_codec);
          break;
        }
        case 26: {
          if (grantRecord_ == null) {
            GrantRecord = new global::TrialAvatarGrantRecord();
          }
          input.ReadMessage(GrantRecord);
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
          TrialAvatarId = input.ReadUInt32();
          break;
        }
        case 18: {
          trialEquipList_.AddEntriesFrom(ref input, _repeated_trialEquipList_codec);
          break;
        }
        case 26: {
          if (grantRecord_ == null) {
            GrantRecord = new global::TrialAvatarGrantRecord();
          }
          input.ReadMessage(GrantRecord);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
