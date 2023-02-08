// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerReportReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PlayerReportReq.proto</summary>
  public static partial class PlayerReportReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerReportReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReportReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQbGF5ZXJSZXBvcnRSZXEucHJvdG8aFlJlcG9ydFJlYXNvblR5cGUucHJv",
            "dG8imQEKD1BsYXllclJlcG9ydFJlcRIfChd0YXJnZXRfaG9tZV9tb2R1bGVf",
            "bmFtZRgFIAEoCRISCgp0YXJnZXRfdWlkGAogASgNEiEKBnJlYXNvbhgHIAEo",
            "DjIRLlJlcG9ydFJlYXNvblR5cGUSDwoHY29udGVudBgLIAEoCRIdChV0YXJn",
            "ZXRfaG9tZV9tb2R1bGVfaWQYDyABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ReportReasonTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PlayerReportReq), global::NewProtos.PlayerReportReq.Parser, new[]{ "TargetHomeModuleName", "TargetUid", "Reason", "Content", "TargetHomeModuleId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4022;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class PlayerReportReq : pb::IMessage<PlayerReportReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerReportReq> _parser = new pb::MessageParser<PlayerReportReq>(() => new PlayerReportReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerReportReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PlayerReportReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReportReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReportReq(PlayerReportReq other) : this() {
      targetHomeModuleName_ = other.targetHomeModuleName_;
      targetUid_ = other.targetUid_;
      reason_ = other.reason_;
      content_ = other.content_;
      targetHomeModuleId_ = other.targetHomeModuleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerReportReq Clone() {
      return new PlayerReportReq(this);
    }

    /// <summary>Field number for the "target_home_module_name" field.</summary>
    public const int TargetHomeModuleNameFieldNumber = 5;
    private string targetHomeModuleName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetHomeModuleName {
      get { return targetHomeModuleName_; }
      set {
        targetHomeModuleName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 10;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 7;
    private global::NewProtos.ReportReasonType reason_ = global::NewProtos.ReportReasonType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ReportReasonType Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 11;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_home_module_id" field.</summary>
    public const int TargetHomeModuleIdFieldNumber = 15;
    private uint targetHomeModuleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetHomeModuleId {
      get { return targetHomeModuleId_; }
      set {
        targetHomeModuleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerReportReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerReportReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetHomeModuleName != other.TargetHomeModuleName) return false;
      if (TargetUid != other.TargetUid) return false;
      if (Reason != other.Reason) return false;
      if (Content != other.Content) return false;
      if (TargetHomeModuleId != other.TargetHomeModuleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetHomeModuleName.Length != 0) hash ^= TargetHomeModuleName.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (Reason != global::NewProtos.ReportReasonType.None) hash ^= Reason.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (TargetHomeModuleId != 0) hash ^= TargetHomeModuleId.GetHashCode();
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
      if (TargetHomeModuleName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TargetHomeModuleName);
      }
      if (Reason != global::NewProtos.ReportReasonType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetUid);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Content);
      }
      if (TargetHomeModuleId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TargetHomeModuleId);
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
      if (TargetHomeModuleName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(TargetHomeModuleName);
      }
      if (Reason != global::NewProtos.ReportReasonType.None) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TargetUid);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Content);
      }
      if (TargetHomeModuleId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TargetHomeModuleId);
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
      if (TargetHomeModuleName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetHomeModuleName);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (Reason != global::NewProtos.ReportReasonType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (TargetHomeModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetHomeModuleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerReportReq other) {
      if (other == null) {
        return;
      }
      if (other.TargetHomeModuleName.Length != 0) {
        TargetHomeModuleName = other.TargetHomeModuleName;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.Reason != global::NewProtos.ReportReasonType.None) {
        Reason = other.Reason;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.TargetHomeModuleId != 0) {
        TargetHomeModuleId = other.TargetHomeModuleId;
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
          case 42: {
            TargetHomeModuleName = input.ReadString();
            break;
          }
          case 56: {
            Reason = (global::NewProtos.ReportReasonType) input.ReadEnum();
            break;
          }
          case 80: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 90: {
            Content = input.ReadString();
            break;
          }
          case 120: {
            TargetHomeModuleId = input.ReadUInt32();
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
          case 42: {
            TargetHomeModuleName = input.ReadString();
            break;
          }
          case 56: {
            Reason = (global::NewProtos.ReportReasonType) input.ReadEnum();
            break;
          }
          case 80: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 90: {
            Content = input.ReadString();
            break;
          }
          case 120: {
            TargetHomeModuleId = input.ReadUInt32();
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
