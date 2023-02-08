// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ContentAuditInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ContentAuditInfo.proto</summary>
  public static partial class ContentAuditInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ContentAuditInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContentAuditInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDb250ZW50QXVkaXRJbmZvLnByb3RvGhBBdWRpdFN0YXRlLnByb3RvIoIB",
            "ChBDb250ZW50QXVkaXRJbmZvEg8KB2lzX29wZW4YASABKAgSDwoHY29udGVu",
            "dBgCIAEoCRIUCgxzdWJtaXRfY291bnQYAyABKA0SIAoLYXVkaXRfc3RhdGUY",
            "BCABKA4yCy5BdWRpdFN0YXRlEhQKDHN1Ym1pdF9saW1pdBgFIAEoDUIMqgIJ",
            "TmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.AuditStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ContentAuditInfo), global::NewProtos.ContentAuditInfo.Parser, new[]{ "IsOpen", "Content", "SubmitCount", "AuditState", "SubmitLimit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContentAuditInfo : pb::IMessage<ContentAuditInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ContentAuditInfo> _parser = new pb::MessageParser<ContentAuditInfo>(() => new ContentAuditInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ContentAuditInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ContentAuditInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentAuditInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentAuditInfo(ContentAuditInfo other) : this() {
      isOpen_ = other.isOpen_;
      content_ = other.content_;
      submitCount_ = other.submitCount_;
      auditState_ = other.auditState_;
      submitLimit_ = other.submitLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ContentAuditInfo Clone() {
      return new ContentAuditInfo(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 1;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 2;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "submit_count" field.</summary>
    public const int SubmitCountFieldNumber = 3;
    private uint submitCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SubmitCount {
      get { return submitCount_; }
      set {
        submitCount_ = value;
      }
    }

    /// <summary>Field number for the "audit_state" field.</summary>
    public const int AuditStateFieldNumber = 4;
    private global::NewProtos.AuditState auditState_ = global::NewProtos.AuditState.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.AuditState AuditState {
      get { return auditState_; }
      set {
        auditState_ = value;
      }
    }

    /// <summary>Field number for the "submit_limit" field.</summary>
    public const int SubmitLimitFieldNumber = 5;
    private uint submitLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SubmitLimit {
      get { return submitLimit_; }
      set {
        submitLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ContentAuditInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ContentAuditInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if (Content != other.Content) return false;
      if (SubmitCount != other.SubmitCount) return false;
      if (AuditState != other.AuditState) return false;
      if (SubmitLimit != other.SubmitLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (SubmitCount != 0) hash ^= SubmitCount.GetHashCode();
      if (AuditState != global::NewProtos.AuditState.None) hash ^= AuditState.GetHashCode();
      if (SubmitLimit != 0) hash ^= SubmitLimit.GetHashCode();
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
      if (IsOpen != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOpen);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Content);
      }
      if (SubmitCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SubmitCount);
      }
      if (AuditState != global::NewProtos.AuditState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AuditState);
      }
      if (SubmitLimit != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SubmitLimit);
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
      if (IsOpen != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsOpen);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Content);
      }
      if (SubmitCount != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SubmitCount);
      }
      if (AuditState != global::NewProtos.AuditState.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AuditState);
      }
      if (SubmitLimit != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SubmitLimit);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (SubmitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SubmitCount);
      }
      if (AuditState != global::NewProtos.AuditState.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AuditState);
      }
      if (SubmitLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SubmitLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ContentAuditInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.SubmitCount != 0) {
        SubmitCount = other.SubmitCount;
      }
      if (other.AuditState != global::NewProtos.AuditState.None) {
        AuditState = other.AuditState;
      }
      if (other.SubmitLimit != 0) {
        SubmitLimit = other.SubmitLimit;
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
            IsOpen = input.ReadBool();
            break;
          }
          case 18: {
            Content = input.ReadString();
            break;
          }
          case 24: {
            SubmitCount = input.ReadUInt32();
            break;
          }
          case 32: {
            AuditState = (global::NewProtos.AuditState) input.ReadEnum();
            break;
          }
          case 40: {
            SubmitLimit = input.ReadUInt32();
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
            IsOpen = input.ReadBool();
            break;
          }
          case 18: {
            Content = input.ReadString();
            break;
          }
          case 24: {
            SubmitCount = input.ReadUInt32();
            break;
          }
          case 32: {
            AuditState = (global::NewProtos.AuditState) input.ReadEnum();
            break;
          }
          case 40: {
            SubmitLimit = input.ReadUInt32();
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
