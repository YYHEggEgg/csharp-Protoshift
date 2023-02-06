// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VehicleMember.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from VehicleMember.proto</summary>
public static partial class VehicleMemberReflection {

  #region Descriptor
  /// <summary>File descriptor for VehicleMember.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VehicleMemberReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNWZWhpY2xlTWVtYmVyLnByb3RvIj4KDVZlaGljbGVNZW1iZXISCwoDdWlk",
          "GAEgASgNEhMKC2F2YXRhcl9ndWlkGAIgASgEEgsKA3BvcxgDIAEoDUIeChxl",
          "bXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VehicleMember), global::VehicleMember.Parser, new[]{ "Uid", "AvatarGuid", "Pos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class VehicleMember : pb::IMessage<VehicleMember>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VehicleMember> _parser = new pb::MessageParser<VehicleMember>(() => new VehicleMember());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VehicleMember> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VehicleMemberReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VehicleMember() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VehicleMember(VehicleMember other) : this() {
    uid_ = other.uid_;
    avatarGuid_ = other.avatarGuid_;
    pos_ = other.pos_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VehicleMember Clone() {
    return new VehicleMember(this);
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 1;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "avatar_guid" field.</summary>
  public const int AvatarGuidFieldNumber = 2;
  private ulong avatarGuid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong AvatarGuid {
    get { return avatarGuid_; }
    set {
      avatarGuid_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 3;
  private uint pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VehicleMember);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VehicleMember other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Uid != other.Uid) return false;
    if (AvatarGuid != other.AvatarGuid) return false;
    if (Pos != other.Pos) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Uid != 0) hash ^= Uid.GetHashCode();
    if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
    if (Pos != 0) hash ^= Pos.GetHashCode();
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
    if (Uid != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Uid);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(AvatarGuid);
    }
    if (Pos != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Pos);
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
    if (Uid != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Uid);
    }
    if (AvatarGuid != 0UL) {
      output.WriteRawTag(16);
      output.WriteUInt64(AvatarGuid);
    }
    if (Pos != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Pos);
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
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (AvatarGuid != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
    }
    if (Pos != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VehicleMember other) {
    if (other == null) {
      return;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    if (other.AvatarGuid != 0UL) {
      AvatarGuid = other.AvatarGuid;
    }
    if (other.Pos != 0) {
      Pos = other.Pos;
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
          Uid = input.ReadUInt32();
          break;
        }
        case 16: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 24: {
          Pos = input.ReadUInt32();
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
          Uid = input.ReadUInt32();
          break;
        }
        case 16: {
          AvatarGuid = input.ReadUInt64();
          break;
        }
        case 24: {
          Pos = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
