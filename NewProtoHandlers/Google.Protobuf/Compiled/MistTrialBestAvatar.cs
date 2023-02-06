// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MistTrialBestAvatar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from MistTrialBestAvatar.proto</summary>
public static partial class MistTrialBestAvatarReflection {

  #region Descriptor
  /// <summary>File descriptor for MistTrialBestAvatar.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MistTrialBestAvatarReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlNaXN0VHJpYWxCZXN0QXZhdGFyLnByb3RvGhBBdmF0YXJUeXBlLnByb3Rv",
          "Il4KE01pc3RUcmlhbEJlc3RBdmF0YXISEQoJYXZhdGFyX2lkGAQgASgNEhIK",
          "CmNvc3R1bWVfaWQYDCABKA0SIAoLYXZhdGFyX3R5cGUYBiABKA4yCy5BdmF0",
          "YXJUeXBlQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::AvatarTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MistTrialBestAvatar), global::MistTrialBestAvatar.Parser, new[]{ "AvatarId", "CostumeId", "AvatarType" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class MistTrialBestAvatar : pb::IMessage<MistTrialBestAvatar>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MistTrialBestAvatar> _parser = new pb::MessageParser<MistTrialBestAvatar>(() => new MistTrialBestAvatar());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MistTrialBestAvatar> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MistTrialBestAvatarReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialBestAvatar() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialBestAvatar(MistTrialBestAvatar other) : this() {
    avatarId_ = other.avatarId_;
    costumeId_ = other.costumeId_;
    avatarType_ = other.avatarType_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MistTrialBestAvatar Clone() {
    return new MistTrialBestAvatar(this);
  }

  /// <summary>Field number for the "avatar_id" field.</summary>
  public const int AvatarIdFieldNumber = 4;
  private uint avatarId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AvatarId {
    get { return avatarId_; }
    set {
      avatarId_ = value;
    }
  }

  /// <summary>Field number for the "costume_id" field.</summary>
  public const int CostumeIdFieldNumber = 12;
  private uint costumeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CostumeId {
    get { return costumeId_; }
    set {
      costumeId_ = value;
    }
  }

  /// <summary>Field number for the "avatar_type" field.</summary>
  public const int AvatarTypeFieldNumber = 6;
  private global::AvatarType avatarType_ = global::AvatarType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::AvatarType AvatarType {
    get { return avatarType_; }
    set {
      avatarType_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MistTrialBestAvatar);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MistTrialBestAvatar other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (AvatarId != other.AvatarId) return false;
    if (CostumeId != other.CostumeId) return false;
    if (AvatarType != other.AvatarType) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
    if (CostumeId != 0) hash ^= CostumeId.GetHashCode();
    if (AvatarType != global::AvatarType.None) hash ^= AvatarType.GetHashCode();
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
    if (AvatarId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(AvatarId);
    }
    if (AvatarType != global::AvatarType.None) {
      output.WriteRawTag(48);
      output.WriteEnum((int) AvatarType);
    }
    if (CostumeId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CostumeId);
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
    if (AvatarId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(AvatarId);
    }
    if (AvatarType != global::AvatarType.None) {
      output.WriteRawTag(48);
      output.WriteEnum((int) AvatarType);
    }
    if (CostumeId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CostumeId);
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
    if (AvatarId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
    }
    if (CostumeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostumeId);
    }
    if (AvatarType != global::AvatarType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AvatarType);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MistTrialBestAvatar other) {
    if (other == null) {
      return;
    }
    if (other.AvatarId != 0) {
      AvatarId = other.AvatarId;
    }
    if (other.CostumeId != 0) {
      CostumeId = other.CostumeId;
    }
    if (other.AvatarType != global::AvatarType.None) {
      AvatarType = other.AvatarType;
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
        case 32: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 48: {
          AvatarType = (global::AvatarType) input.ReadEnum();
          break;
        }
        case 96: {
          CostumeId = input.ReadUInt32();
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
        case 32: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 48: {
          AvatarType = (global::AvatarType) input.ReadEnum();
          break;
        }
        case 96: {
          CostumeId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
