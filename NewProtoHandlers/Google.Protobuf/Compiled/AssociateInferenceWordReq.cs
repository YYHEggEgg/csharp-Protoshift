// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AssociateInferenceWordReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AssociateInferenceWordReq.proto</summary>
  public static partial class AssociateInferenceWordReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AssociateInferenceWordReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssociateInferenceWordReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Bc3NvY2lhdGVJbmZlcmVuY2VXb3JkUmVxLnByb3RvImYKGUFzc29jaWF0",
            "ZUluZmVyZW5jZVdvcmRSZXESDwoHcGFnZV9pZBgGIAEoDRIbChNVbmszMzAw",
            "X0VQTUdIRUxFQ05IGAIgASgNEhsKE1VuazMzMDBfRkRHTEJMSk9LT0sYBCAB",
            "KA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AssociateInferenceWordReq), global::NewProtos.AssociateInferenceWordReq.Parser, new[]{ "PageId", "Unk3300EPMGHELECNH", "Unk3300FDGLBLJOKOK" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 420;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class AssociateInferenceWordReq : pb::IMessage<AssociateInferenceWordReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssociateInferenceWordReq> _parser = new pb::MessageParser<AssociateInferenceWordReq>(() => new AssociateInferenceWordReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssociateInferenceWordReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AssociateInferenceWordReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssociateInferenceWordReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssociateInferenceWordReq(AssociateInferenceWordReq other) : this() {
      pageId_ = other.pageId_;
      unk3300EPMGHELECNH_ = other.unk3300EPMGHELECNH_;
      unk3300FDGLBLJOKOK_ = other.unk3300FDGLBLJOKOK_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssociateInferenceWordReq Clone() {
      return new AssociateInferenceWordReq(this);
    }

    /// <summary>Field number for the "page_id" field.</summary>
    public const int PageIdFieldNumber = 6;
    private uint pageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PageId {
      get { return pageId_; }
      set {
        pageId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EPMGHELECNH" field.</summary>
    public const int Unk3300EPMGHELECNHFieldNumber = 2;
    private uint unk3300EPMGHELECNH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EPMGHELECNH {
      get { return unk3300EPMGHELECNH_; }
      set {
        unk3300EPMGHELECNH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FDGLBLJOKOK" field.</summary>
    public const int Unk3300FDGLBLJOKOKFieldNumber = 4;
    private uint unk3300FDGLBLJOKOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FDGLBLJOKOK {
      get { return unk3300FDGLBLJOKOK_; }
      set {
        unk3300FDGLBLJOKOK_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssociateInferenceWordReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssociateInferenceWordReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageId != other.PageId) return false;
      if (Unk3300EPMGHELECNH != other.Unk3300EPMGHELECNH) return false;
      if (Unk3300FDGLBLJOKOK != other.Unk3300FDGLBLJOKOK) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PageId != 0) hash ^= PageId.GetHashCode();
      if (Unk3300EPMGHELECNH != 0) hash ^= Unk3300EPMGHELECNH.GetHashCode();
      if (Unk3300FDGLBLJOKOK != 0) hash ^= Unk3300FDGLBLJOKOK.GetHashCode();
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
      if (Unk3300EPMGHELECNH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300EPMGHELECNH);
      }
      if (Unk3300FDGLBLJOKOK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FDGLBLJOKOK);
      }
      if (PageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PageId);
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
      if (Unk3300EPMGHELECNH != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Unk3300EPMGHELECNH);
      }
      if (Unk3300FDGLBLJOKOK != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300FDGLBLJOKOK);
      }
      if (PageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PageId);
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
      if (PageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PageId);
      }
      if (Unk3300EPMGHELECNH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EPMGHELECNH);
      }
      if (Unk3300FDGLBLJOKOK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FDGLBLJOKOK);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssociateInferenceWordReq other) {
      if (other == null) {
        return;
      }
      if (other.PageId != 0) {
        PageId = other.PageId;
      }
      if (other.Unk3300EPMGHELECNH != 0) {
        Unk3300EPMGHELECNH = other.Unk3300EPMGHELECNH;
      }
      if (other.Unk3300FDGLBLJOKOK != 0) {
        Unk3300FDGLBLJOKOK = other.Unk3300FDGLBLJOKOK;
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
          case 16: {
            Unk3300EPMGHELECNH = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300FDGLBLJOKOK = input.ReadUInt32();
            break;
          }
          case 48: {
            PageId = input.ReadUInt32();
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
          case 16: {
            Unk3300EPMGHELECNH = input.ReadUInt32();
            break;
          }
          case 32: {
            Unk3300FDGLBLJOKOK = input.ReadUInt32();
            break;
          }
          case 48: {
            PageId = input.ReadUInt32();
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
