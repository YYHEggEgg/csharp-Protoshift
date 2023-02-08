// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PullPrivateChatReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from PullPrivateChatReq.proto</summary>
  public static partial class PullPrivateChatReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PullPrivateChatReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PullPrivateChatReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQdWxsUHJpdmF0ZUNoYXRSZXEucHJvdG8iUQoSUHVsbFByaXZhdGVDaGF0",
            "UmVxEhUKDWZyb21fc2VxdWVuY2UYBSABKA0SEgoKdGFyZ2V0X3VpZBgMIAEo",
            "DRIQCghwdWxsX251bRgLIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.PullPrivateChatReq), global::NewProtos.PullPrivateChatReq.Parser, new[]{ "FromSequence", "TargetUid", "PullNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4993;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class PullPrivateChatReq : pb::IMessage<PullPrivateChatReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PullPrivateChatReq> _parser = new pb::MessageParser<PullPrivateChatReq>(() => new PullPrivateChatReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PullPrivateChatReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.PullPrivateChatReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq(PullPrivateChatReq other) : this() {
      fromSequence_ = other.fromSequence_;
      targetUid_ = other.targetUid_;
      pullNum_ = other.pullNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq Clone() {
      return new PullPrivateChatReq(this);
    }

    /// <summary>Field number for the "from_sequence" field.</summary>
    public const int FromSequenceFieldNumber = 5;
    private uint fromSequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FromSequence {
      get { return fromSequence_; }
      set {
        fromSequence_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 12;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    /// <summary>Field number for the "pull_num" field.</summary>
    public const int PullNumFieldNumber = 11;
    private uint pullNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PullNum {
      get { return pullNum_; }
      set {
        pullNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PullPrivateChatReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PullPrivateChatReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FromSequence != other.FromSequence) return false;
      if (TargetUid != other.TargetUid) return false;
      if (PullNum != other.PullNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FromSequence != 0) hash ^= FromSequence.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
      if (PullNum != 0) hash ^= PullNum.GetHashCode();
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
      if (FromSequence != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FromSequence);
      }
      if (PullNum != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PullNum);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(96);
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
      if (FromSequence != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FromSequence);
      }
      if (PullNum != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PullNum);
      }
      if (TargetUid != 0) {
        output.WriteRawTag(96);
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
      if (FromSequence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FromSequence);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (PullNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PullNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PullPrivateChatReq other) {
      if (other == null) {
        return;
      }
      if (other.FromSequence != 0) {
        FromSequence = other.FromSequence;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
      }
      if (other.PullNum != 0) {
        PullNum = other.PullNum;
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
          case 40: {
            FromSequence = input.ReadUInt32();
            break;
          }
          case 88: {
            PullNum = input.ReadUInt32();
            break;
          }
          case 96: {
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
          case 40: {
            FromSequence = input.ReadUInt32();
            break;
          }
          case 88: {
            PullNum = input.ReadUInt32();
            break;
          }
          case 96: {
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
