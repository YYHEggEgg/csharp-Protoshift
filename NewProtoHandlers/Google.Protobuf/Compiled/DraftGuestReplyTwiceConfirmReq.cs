// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DraftGuestReplyTwiceConfirmReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from DraftGuestReplyTwiceConfirmReq.proto</summary>
  public static partial class DraftGuestReplyTwiceConfirmReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DraftGuestReplyTwiceConfirmReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DraftGuestReplyTwiceConfirmReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiREcmFmdEd1ZXN0UmVwbHlUd2ljZUNvbmZpcm1SZXEucHJvdG8iRAoeRHJh",
            "ZnRHdWVzdFJlcGx5VHdpY2VDb25maXJtUmVxEhAKCGlzX2FncmVlGAggASgI",
            "EhAKCGRyYWZ0X2lkGA0gASgNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.DraftGuestReplyTwiceConfirmReq), global::NewProtos.DraftGuestReplyTwiceConfirmReq.Parser, new[]{ "IsAgree", "DraftId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5427;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class DraftGuestReplyTwiceConfirmReq : pb::IMessage<DraftGuestReplyTwiceConfirmReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DraftGuestReplyTwiceConfirmReq> _parser = new pb::MessageParser<DraftGuestReplyTwiceConfirmReq>(() => new DraftGuestReplyTwiceConfirmReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DraftGuestReplyTwiceConfirmReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.DraftGuestReplyTwiceConfirmReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmReq(DraftGuestReplyTwiceConfirmReq other) : this() {
      isAgree_ = other.isAgree_;
      draftId_ = other.draftId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyTwiceConfirmReq Clone() {
      return new DraftGuestReplyTwiceConfirmReq(this);
    }

    /// <summary>Field number for the "is_agree" field.</summary>
    public const int IsAgreeFieldNumber = 8;
    private bool isAgree_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAgree {
      get { return isAgree_; }
      set {
        isAgree_ = value;
      }
    }

    /// <summary>Field number for the "draft_id" field.</summary>
    public const int DraftIdFieldNumber = 13;
    private uint draftId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DraftId {
      get { return draftId_; }
      set {
        draftId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DraftGuestReplyTwiceConfirmReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DraftGuestReplyTwiceConfirmReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAgree != other.IsAgree) return false;
      if (DraftId != other.DraftId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAgree != false) hash ^= IsAgree.GetHashCode();
      if (DraftId != 0) hash ^= DraftId.GetHashCode();
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
      if (IsAgree != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(DraftId);
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
      if (IsAgree != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(DraftId);
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
      if (IsAgree != false) {
        size += 1 + 1;
      }
      if (DraftId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DraftId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DraftGuestReplyTwiceConfirmReq other) {
      if (other == null) {
        return;
      }
      if (other.IsAgree != false) {
        IsAgree = other.IsAgree;
      }
      if (other.DraftId != 0) {
        DraftId = other.DraftId;
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
            IsAgree = input.ReadBool();
            break;
          }
          case 104: {
            DraftId = input.ReadUInt32();
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
            IsAgree = input.ReadBool();
            break;
          }
          case 104: {
            DraftId = input.ReadUInt32();
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
