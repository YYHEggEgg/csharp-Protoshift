// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChannelerSlabCamp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ChannelerSlabCamp.proto</summary>
public static partial class ChannelerSlabCampReflection {

  #region Descriptor
  /// <summary>File descriptor for ChannelerSlabCamp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ChannelerSlabCampReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdDaGFubmVsZXJTbGFiQ2FtcC5wcm90bxoMVmVjdG9yLnByb3RvImAKEUNo",
          "YW5uZWxlclNsYWJDYW1wEhAKCGJ1ZmZfbnVtGAsgASgNEhEKCXJld2FyZF9p",
          "ZBgJIAEoDRIQCghncm91cF9pZBgIIAEoDRIUCgNwb3MYDyABKAsyBy5WZWN0",
          "b3JCFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ChannelerSlabCamp), global::ChannelerSlabCamp.Parser, new[]{ "BuffNum", "RewardId", "GroupId", "Pos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ChannelerSlabCamp : pb::IMessage<ChannelerSlabCamp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChannelerSlabCamp> _parser = new pb::MessageParser<ChannelerSlabCamp>(() => new ChannelerSlabCamp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ChannelerSlabCamp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ChannelerSlabCampReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabCamp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabCamp(ChannelerSlabCamp other) : this() {
    buffNum_ = other.buffNum_;
    rewardId_ = other.rewardId_;
    groupId_ = other.groupId_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChannelerSlabCamp Clone() {
    return new ChannelerSlabCamp(this);
  }

  /// <summary>Field number for the "buff_num" field.</summary>
  public const int BuffNumFieldNumber = 11;
  private uint buffNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuffNum {
    get { return buffNum_; }
    set {
      buffNum_ = value;
    }
  }

  /// <summary>Field number for the "reward_id" field.</summary>
  public const int RewardIdFieldNumber = 9;
  private uint rewardId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RewardId {
    get { return rewardId_; }
    set {
      rewardId_ = value;
    }
  }

  /// <summary>Field number for the "group_id" field.</summary>
  public const int GroupIdFieldNumber = 8;
  private uint groupId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint GroupId {
    get { return groupId_; }
    set {
      groupId_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 15;
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
    return Equals(other as ChannelerSlabCamp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ChannelerSlabCamp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (BuffNum != other.BuffNum) return false;
    if (RewardId != other.RewardId) return false;
    if (GroupId != other.GroupId) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (BuffNum != 0) hash ^= BuffNum.GetHashCode();
    if (RewardId != 0) hash ^= RewardId.GetHashCode();
    if (GroupId != 0) hash ^= GroupId.GetHashCode();
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
    if (GroupId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(GroupId);
    }
    if (RewardId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(RewardId);
    }
    if (BuffNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(BuffNum);
    }
    if (pos_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Pos);
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
    if (GroupId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(GroupId);
    }
    if (RewardId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(RewardId);
    }
    if (BuffNum != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(BuffNum);
    }
    if (pos_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Pos);
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
    if (BuffNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffNum);
    }
    if (RewardId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
    }
    if (GroupId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
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
  public void MergeFrom(ChannelerSlabCamp other) {
    if (other == null) {
      return;
    }
    if (other.BuffNum != 0) {
      BuffNum = other.BuffNum;
    }
    if (other.RewardId != 0) {
      RewardId = other.RewardId;
    }
    if (other.GroupId != 0) {
      GroupId = other.GroupId;
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
        case 64: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 72: {
          RewardId = input.ReadUInt32();
          break;
        }
        case 88: {
          BuffNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
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
        case 64: {
          GroupId = input.ReadUInt32();
          break;
        }
        case 72: {
          RewardId = input.ReadUInt32();
          break;
        }
        case 88: {
          BuffNum = input.ReadUInt32();
          break;
        }
        case 122: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code