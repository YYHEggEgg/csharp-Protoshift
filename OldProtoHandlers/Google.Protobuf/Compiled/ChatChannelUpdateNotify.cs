// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChatChannelUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ChatChannelUpdateNotify.proto</summary>
public static partial class ChatChannelUpdateNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ChatChannelUpdateNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ChatChannelUpdateNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1DaGF0Q2hhbm5lbFVwZGF0ZU5vdGlmeS5wcm90bxoVQ2hhdENoYW5uZWxJ",
          "bmZvLnByb3RvImgKF0NoYXRDaGFubmVsVXBkYXRlTm90aWZ5EhIKCmNoYW5u",
          "ZWxfaWQYAyABKA0SEQoJaXNfY3JlYXRlGA8gASgIEiYKDGNoYW5uZWxfaW5m",
          "bxgOIAEoCzIQLkNoYXRDaGFubmVsSW5mb0IeChxlbXUuZ3Jhc3NjdXR0ZXIu",
          "bmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ChatChannelInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ChatChannelUpdateNotify), global::ChatChannelUpdateNotify.Parser, new[]{ "ChannelId", "IsCreate", "ChannelInfo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ChatChannelUpdateNotify : pb::IMessage<ChatChannelUpdateNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ChatChannelUpdateNotify> _parser = new pb::MessageParser<ChatChannelUpdateNotify>(() => new ChatChannelUpdateNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ChatChannelUpdateNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ChatChannelUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatChannelUpdateNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatChannelUpdateNotify(ChatChannelUpdateNotify other) : this() {
    channelId_ = other.channelId_;
    isCreate_ = other.isCreate_;
    channelInfo_ = other.channelInfo_ != null ? other.channelInfo_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ChatChannelUpdateNotify Clone() {
    return new ChatChannelUpdateNotify(this);
  }

  /// <summary>Field number for the "channel_id" field.</summary>
  public const int ChannelIdFieldNumber = 3;
  private uint channelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChannelId {
    get { return channelId_; }
    set {
      channelId_ = value;
    }
  }

  /// <summary>Field number for the "is_create" field.</summary>
  public const int IsCreateFieldNumber = 15;
  private bool isCreate_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsCreate {
    get { return isCreate_; }
    set {
      isCreate_ = value;
    }
  }

  /// <summary>Field number for the "channel_info" field.</summary>
  public const int ChannelInfoFieldNumber = 14;
  private global::ChatChannelInfo channelInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ChatChannelInfo ChannelInfo {
    get { return channelInfo_; }
    set {
      channelInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ChatChannelUpdateNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ChatChannelUpdateNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ChannelId != other.ChannelId) return false;
    if (IsCreate != other.IsCreate) return false;
    if (!object.Equals(ChannelInfo, other.ChannelInfo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ChannelId != 0) hash ^= ChannelId.GetHashCode();
    if (IsCreate != false) hash ^= IsCreate.GetHashCode();
    if (channelInfo_ != null) hash ^= ChannelInfo.GetHashCode();
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
    if (ChannelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ChannelId);
    }
    if (channelInfo_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(ChannelInfo);
    }
    if (IsCreate != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsCreate);
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
    if (ChannelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(ChannelId);
    }
    if (channelInfo_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(ChannelInfo);
    }
    if (IsCreate != false) {
      output.WriteRawTag(120);
      output.WriteBool(IsCreate);
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
    if (ChannelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChannelId);
    }
    if (IsCreate != false) {
      size += 1 + 1;
    }
    if (channelInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChannelInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ChatChannelUpdateNotify other) {
    if (other == null) {
      return;
    }
    if (other.ChannelId != 0) {
      ChannelId = other.ChannelId;
    }
    if (other.IsCreate != false) {
      IsCreate = other.IsCreate;
    }
    if (other.channelInfo_ != null) {
      if (channelInfo_ == null) {
        ChannelInfo = new global::ChatChannelInfo();
      }
      ChannelInfo.MergeFrom(other.ChannelInfo);
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
        case 24: {
          ChannelId = input.ReadUInt32();
          break;
        }
        case 114: {
          if (channelInfo_ == null) {
            ChannelInfo = new global::ChatChannelInfo();
          }
          input.ReadMessage(ChannelInfo);
          break;
        }
        case 120: {
          IsCreate = input.ReadBool();
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
        case 24: {
          ChannelId = input.ReadUInt32();
          break;
        }
        case 114: {
          if (channelInfo_ == null) {
            ChannelInfo = new global::ChatChannelInfo();
          }
          input.ReadMessage(ChannelInfo);
          break;
        }
        case 120: {
          IsCreate = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
