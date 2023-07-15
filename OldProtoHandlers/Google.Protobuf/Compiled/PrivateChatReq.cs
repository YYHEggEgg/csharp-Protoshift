// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PrivateChatReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from PrivateChatReq.proto</summary>
  public static partial class PrivateChatReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PrivateChatReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrivateChatReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcml2YXRlQ2hhdFJlcS5wcm90byJPCg5Qcml2YXRlQ2hhdFJlcRISCgp0",
            "YXJnZXRfdWlkGAcgASgNEg4KBHRleHQYAyABKAlIABIOCgRpY29uGAQgASgN",
            "SABCCQoHY29udGVudEIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.PrivateChatReq), global::OldProtos.PrivateChatReq.Parser, new[]{ "TargetUid", "Text", "Icon" }, new[]{ "Content" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5022
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class PrivateChatReq : pb::IMessage<PrivateChatReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PrivateChatReq> _parser = new pb::MessageParser<PrivateChatReq>(() => new PrivateChatReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PrivateChatReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.PrivateChatReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatReq(PrivateChatReq other) : this() {
      targetUid_ = other.targetUid_;
      switch (other.ContentCase) {
        case ContentOneofCase.Text:
          Text = other.Text;
          break;
        case ContentOneofCase.Icon:
          Icon = other.Icon;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PrivateChatReq Clone() {
      return new PrivateChatReq(this);
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 7;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Text {
      get { return contentCase_ == ContentOneofCase.Text ? (string) content_ : ""; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        contentCase_ = ContentOneofCase.Text;
      }
    }

    /// <summary>Field number for the "icon" field.</summary>
    public const int IconFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Icon {
      get { return contentCase_ == ContentOneofCase.Icon ? (uint) content_ : 0; }
      set {
        content_ = value;
        contentCase_ = ContentOneofCase.Icon;
      }
    }

    private object content_;
    /// <summary>Enum of possible cases for the "content" oneof.</summary>
    public enum ContentOneofCase {
      None = 0,
      Text = 3,
      Icon = 4,
    }
    private ContentOneofCase contentCase_ = ContentOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentOneofCase ContentCase {
      get { return contentCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearContent() {
      contentCase_ = ContentOneofCase.None;
      content_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PrivateChatReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PrivateChatReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetUid != other.TargetUid) return false;
      if (Text != other.Text) return false;
      if (Icon != other.Icon) return false;
      if (ContentCase != other.ContentCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (contentCase_ == ContentOneofCase.Text) hash ^= Text.GetHashCode();
      if (contentCase_ == ContentOneofCase.Icon) hash ^= Icon.GetHashCode();
      hash ^= (int) contentCase_;
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
      if (contentCase_ == ContentOneofCase.Text) {
        output.WriteRawTag(26);
        output.WriteString(Text);
      }
      if (contentCase_ == ContentOneofCase.Icon) {
        output.WriteRawTag(32);
        output.WriteUInt32(Icon);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(56);
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
      if (contentCase_ == ContentOneofCase.Text) {
        output.WriteRawTag(26);
        output.WriteString(Text);
      }
      if (contentCase_ == ContentOneofCase.Icon) {
        output.WriteRawTag(32);
        output.WriteUInt32(Icon);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(56);
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
      if (contentCase_ == ContentOneofCase.Text) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Text);
      }
      if (contentCase_ == ContentOneofCase.Icon) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Icon);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PrivateChatReq other) {
      if (other == null) {
        return;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      switch (other.ContentCase) {
        case ContentOneofCase.Text:
          Text = other.Text;
          break;
        case ContentOneofCase.Icon:
          Icon = other.Icon;
          break;
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
          case 26: {
            Text = input.ReadString();
            break;
          }
          case 32: {
            Icon = input.ReadUInt32();
            break;
          }
          case 56: {
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
          case 26: {
            Text = input.ReadString();
            break;
          }
          case 32: {
            Icon = input.ReadUInt32();
            break;
          }
          case 56: {
            TargetUid = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
