// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestRenameAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from QuestRenameAvatarReq.proto</summary>
  public static partial class QuestRenameAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestRenameAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestRenameAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpRdWVzdFJlbmFtZUF2YXRhclJlcS5wcm90byJQChRRdWVzdFJlbmFtZUF2",
            "YXRhclJlcRIRCglyZW5hbWVfaWQYCyABKA0SEAoIaXNfY2hlY2sYCCABKAgS",
            "EwoLYXZhdGFyX25hbWUYAiABKAlCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.QuestRenameAvatarReq), global::OldProtos.QuestRenameAvatarReq.Parser, new[]{ "RenameId", "IsCheck", "AvatarName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestRenameAvatarReq : pb::IMessage<QuestRenameAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestRenameAvatarReq> _parser = new pb::MessageParser<QuestRenameAvatarReq>(() => new QuestRenameAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestRenameAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.QuestRenameAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarReq(QuestRenameAvatarReq other) : this() {
      renameId_ = other.renameId_;
      isCheck_ = other.isCheck_;
      avatarName_ = other.avatarName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestRenameAvatarReq Clone() {
      return new QuestRenameAvatarReq(this);
    }

    /// <summary>Field number for the "rename_id" field.</summary>
    public const int RenameIdFieldNumber = 11;
    private uint renameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RenameId {
      get { return renameId_; }
      set {
        renameId_ = value;
      }
    }

    /// <summary>Field number for the "is_check" field.</summary>
    public const int IsCheckFieldNumber = 8;
    private bool isCheck_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCheck {
      get { return isCheck_; }
      set {
        isCheck_ = value;
      }
    }

    /// <summary>Field number for the "avatar_name" field.</summary>
    public const int AvatarNameFieldNumber = 2;
    private string avatarName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AvatarName {
      get { return avatarName_; }
      set {
        avatarName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestRenameAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestRenameAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RenameId != other.RenameId) return false;
      if (IsCheck != other.IsCheck) return false;
      if (AvatarName != other.AvatarName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (RenameId != 0) hash ^= RenameId.GetHashCode();
      if (IsCheck != false) hash ^= IsCheck.GetHashCode();
      if (AvatarName.Length != 0) hash ^= AvatarName.GetHashCode();
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
      if (AvatarName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AvatarName);
      }
      if (IsCheck != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsCheck);
      }
      if (RenameId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RenameId);
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
      if (AvatarName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AvatarName);
      }
      if (IsCheck != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsCheck);
      }
      if (RenameId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(RenameId);
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
      if (RenameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RenameId);
      }
      if (IsCheck != false) {
        size += 1 + 1;
      }
      if (AvatarName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestRenameAvatarReq other) {
      if (other == null) {
        return;
      }
      if (other.RenameId != 0) {
        RenameId = other.RenameId;
      }
      if (other.IsCheck != false) {
        IsCheck = other.IsCheck;
      }
      if (other.AvatarName.Length != 0) {
        AvatarName = other.AvatarName;
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
          case 18: {
            AvatarName = input.ReadString();
            break;
          }
          case 64: {
            IsCheck = input.ReadBool();
            break;
          }
          case 88: {
            RenameId = input.ReadUInt32();
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
          case 18: {
            AvatarName = input.ReadString();
            break;
          }
          case 64: {
            IsCheck = input.ReadBool();
            break;
          }
          case 88: {
            RenameId = input.ReadUInt32();
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
