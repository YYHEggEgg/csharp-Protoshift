// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddQuestContentProgressReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AddQuestContentProgressReq.proto</summary>
  public static partial class AddQuestContentProgressReqReflection {

    #region Descriptor
    /// <summary>File descriptor for AddQuestContentProgressReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddQuestContentProgressReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBBZGRRdWVzdENvbnRlbnRQcm9ncmVzc1JlcS5wcm90byJXChpBZGRRdWVz",
            "dENvbnRlbnRQcm9ncmVzc1JlcRIUCgxjb250ZW50X3R5cGUYASABKA0SFAoM",
            "YWRkX3Byb2dyZXNzGAYgASgNEg0KBXBhcmFtGAsgASgNQgyqAglOZXdQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AddQuestContentProgressReq), global::NewProtos.AddQuestContentProgressReq.Parser, new[]{ "ContentType", "AddProgress", "Param" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 443;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class AddQuestContentProgressReq : pb::IMessage<AddQuestContentProgressReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddQuestContentProgressReq> _parser = new pb::MessageParser<AddQuestContentProgressReq>(() => new AddQuestContentProgressReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddQuestContentProgressReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AddQuestContentProgressReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddQuestContentProgressReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddQuestContentProgressReq(AddQuestContentProgressReq other) : this() {
      contentType_ = other.contentType_;
      addProgress_ = other.addProgress_;
      param_ = other.param_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddQuestContentProgressReq Clone() {
      return new AddQuestContentProgressReq(this);
    }

    /// <summary>Field number for the "content_type" field.</summary>
    public const int ContentTypeFieldNumber = 1;
    private uint contentType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentType {
      get { return contentType_; }
      set {
        contentType_ = value;
      }
    }

    /// <summary>Field number for the "add_progress" field.</summary>
    public const int AddProgressFieldNumber = 6;
    private uint addProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddProgress {
      get { return addProgress_; }
      set {
        addProgress_ = value;
      }
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 11;
    private uint param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddQuestContentProgressReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddQuestContentProgressReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ContentType != other.ContentType) return false;
      if (AddProgress != other.AddProgress) return false;
      if (Param != other.Param) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ContentType != 0) hash ^= ContentType.GetHashCode();
      if (AddProgress != 0) hash ^= AddProgress.GetHashCode();
      if (Param != 0) hash ^= Param.GetHashCode();
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
      if (ContentType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentType);
      }
      if (AddProgress != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AddProgress);
      }
      if (Param != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Param);
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
      if (ContentType != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ContentType);
      }
      if (AddProgress != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(AddProgress);
      }
      if (Param != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Param);
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
      if (ContentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentType);
      }
      if (AddProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddProgress);
      }
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddQuestContentProgressReq other) {
      if (other == null) {
        return;
      }
      if (other.ContentType != 0) {
        ContentType = other.ContentType;
      }
      if (other.AddProgress != 0) {
        AddProgress = other.AddProgress;
      }
      if (other.Param != 0) {
        Param = other.Param;
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
            ContentType = input.ReadUInt32();
            break;
          }
          case 48: {
            AddProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            Param = input.ReadUInt32();
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
            ContentType = input.ReadUInt32();
            break;
          }
          case 48: {
            AddProgress = input.ReadUInt32();
            break;
          }
          case 88: {
            Param = input.ReadUInt32();
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
