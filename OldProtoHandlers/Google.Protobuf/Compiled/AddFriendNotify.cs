// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddFriendNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AddFriendNotify.proto</summary>
public static partial class AddFriendNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for AddFriendNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AddFriendNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVBZGRGcmllbmROb3RpZnkucHJvdG8aEUZyaWVuZEJyaWVmLnByb3RvIlAK",
          "D0FkZEZyaWVuZE5vdGlmeRISCgp0YXJnZXRfdWlkGAsgASgNEikKE3Rhcmdl",
          "dF9mcmllbmRfYnJpZWYYCiABKAsyDC5GcmllbmRCcmllZkIeChxlbXUuZ3Jh",
          "c3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FriendBriefReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AddFriendNotify), global::AddFriendNotify.Parser, new[]{ "TargetUid", "TargetFriendBrief" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4022
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class AddFriendNotify : pb::IMessage<AddFriendNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AddFriendNotify> _parser = new pb::MessageParser<AddFriendNotify>(() => new AddFriendNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AddFriendNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AddFriendNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddFriendNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddFriendNotify(AddFriendNotify other) : this() {
    targetUid_ = other.targetUid_;
    targetFriendBrief_ = other.targetFriendBrief_ != null ? other.targetFriendBrief_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AddFriendNotify Clone() {
    return new AddFriendNotify(this);
  }

  /// <summary>Field number for the "target_uid" field.</summary>
  public const int TargetUidFieldNumber = 11;
  private uint targetUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TargetUid {
    get { return targetUid_; }
    set {
      targetUid_ = value;
    }
  }

  /// <summary>Field number for the "target_friend_brief" field.</summary>
  public const int TargetFriendBriefFieldNumber = 10;
  private global::FriendBrief targetFriendBrief_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::FriendBrief TargetFriendBrief {
    get { return targetFriendBrief_; }
    set {
      targetFriendBrief_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AddFriendNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AddFriendNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (TargetUid != other.TargetUid) return false;
    if (!object.Equals(TargetFriendBrief, other.TargetFriendBrief)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
    if (targetFriendBrief_ != null) hash ^= TargetFriendBrief.GetHashCode();
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
    if (targetFriendBrief_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(TargetFriendBrief);
    }
    if (TargetUid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(TargetUid);
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
    if (targetFriendBrief_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(TargetFriendBrief);
    }
    if (TargetUid != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(TargetUid);
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
    if (TargetUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
    }
    if (targetFriendBrief_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetFriendBrief);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AddFriendNotify other) {
    if (other == null) {
      return;
    }
    if (other.TargetUid != 0) {
      TargetUid = other.TargetUid;
    }
    if (other.targetFriendBrief_ != null) {
      if (targetFriendBrief_ == null) {
        TargetFriendBrief = new global::FriendBrief();
      }
      TargetFriendBrief.MergeFrom(other.TargetFriendBrief);
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
        case 82: {
          if (targetFriendBrief_ == null) {
            TargetFriendBrief = new global::FriendBrief();
          }
          input.ReadMessage(TargetFriendBrief);
          break;
        }
        case 88: {
          TargetUid = input.ReadUInt32();
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
        case 82: {
          if (targetFriendBrief_ == null) {
            TargetFriendBrief = new global::FriendBrief();
          }
          input.ReadMessage(TargetFriendBrief);
          break;
        }
        case 88: {
          TargetUid = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
