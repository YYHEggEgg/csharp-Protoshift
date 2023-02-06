// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingFriendPicData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BlessingFriendPicData.proto</summary>
public static partial class BlessingFriendPicDataReflection {

  #region Descriptor
  /// <summary>File descriptor for BlessingFriendPicData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BlessingFriendPicDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtCbGVzc2luZ0ZyaWVuZFBpY0RhdGEucHJvdG8aFFByb2ZpbGVQaWN0dXJl",
          "LnByb3RvIokCChVCbGVzc2luZ0ZyaWVuZFBpY0RhdGESOgoLcGljX251bV9t",
          "YXAYBCADKAsyJS5CbGVzc2luZ0ZyaWVuZFBpY0RhdGEuUGljTnVtTWFwRW50",
          "cnkSEQoJYXZhdGFyX2lkGAUgASgNEhMKC3JlbWFya19uYW1lGAsgASgJEhAK",
          "CG5pY2tuYW1lGA4gASgJEhEKCXNpZ25hdHVyZRgBIAEoCRIoCg9wcm9maWxl",
          "X3BpY3R1cmUYBiABKAsyDy5Qcm9maWxlUGljdHVyZRILCgN1aWQYCSABKA0a",
          "MAoOUGljTnVtTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgN",
          "OgI4AUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ProfilePictureReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BlessingFriendPicData), global::BlessingFriendPicData.Parser, new[]{ "PicNumMap", "AvatarId", "RemarkName", "Nickname", "Signature", "ProfilePicture", "Uid" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BlessingFriendPicData : pb::IMessage<BlessingFriendPicData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BlessingFriendPicData> _parser = new pb::MessageParser<BlessingFriendPicData>(() => new BlessingFriendPicData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BlessingFriendPicData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlessingFriendPicDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingFriendPicData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingFriendPicData(BlessingFriendPicData other) : this() {
    picNumMap_ = other.picNumMap_.Clone();
    avatarId_ = other.avatarId_;
    remarkName_ = other.remarkName_;
    nickname_ = other.nickname_;
    signature_ = other.signature_;
    profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
    uid_ = other.uid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingFriendPicData Clone() {
    return new BlessingFriendPicData(this);
  }

  /// <summary>Field number for the "pic_num_map" field.</summary>
  public const int PicNumMapFieldNumber = 4;
  private static readonly pbc::MapField<uint, uint>.Codec _map_picNumMap_codec
      = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
  private readonly pbc::MapField<uint, uint> picNumMap_ = new pbc::MapField<uint, uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, uint> PicNumMap {
    get { return picNumMap_; }
  }

  /// <summary>Field number for the "avatar_id" field.</summary>
  public const int AvatarIdFieldNumber = 5;
  private uint avatarId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint AvatarId {
    get { return avatarId_; }
    set {
      avatarId_ = value;
    }
  }

  /// <summary>Field number for the "remark_name" field.</summary>
  public const int RemarkNameFieldNumber = 11;
  private string remarkName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string RemarkName {
    get { return remarkName_; }
    set {
      remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "nickname" field.</summary>
  public const int NicknameFieldNumber = 14;
  private string nickname_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Nickname {
    get { return nickname_; }
    set {
      nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "signature" field.</summary>
  public const int SignatureFieldNumber = 1;
  private string signature_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Signature {
    get { return signature_; }
    set {
      signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "profile_picture" field.</summary>
  public const int ProfilePictureFieldNumber = 6;
  private global::ProfilePicture profilePicture_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ProfilePicture ProfilePicture {
    get { return profilePicture_; }
    set {
      profilePicture_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 9;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BlessingFriendPicData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BlessingFriendPicData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!PicNumMap.Equals(other.PicNumMap)) return false;
    if (AvatarId != other.AvatarId) return false;
    if (RemarkName != other.RemarkName) return false;
    if (Nickname != other.Nickname) return false;
    if (Signature != other.Signature) return false;
    if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
    if (Uid != other.Uid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= PicNumMap.GetHashCode();
    if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
    if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
    if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
    if (Signature.Length != 0) hash ^= Signature.GetHashCode();
    if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
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
    if (Signature.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Signature);
    }
    picNumMap_.WriteTo(output, _map_picNumMap_codec);
    if (AvatarId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(AvatarId);
    }
    if (profilePicture_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(ProfilePicture);
    }
    if (Uid != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Uid);
    }
    if (RemarkName.Length != 0) {
      output.WriteRawTag(90);
      output.WriteString(RemarkName);
    }
    if (Nickname.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(Nickname);
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
    if (Signature.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Signature);
    }
    picNumMap_.WriteTo(ref output, _map_picNumMap_codec);
    if (AvatarId != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(AvatarId);
    }
    if (profilePicture_ != null) {
      output.WriteRawTag(50);
      output.WriteMessage(ProfilePicture);
    }
    if (Uid != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(Uid);
    }
    if (RemarkName.Length != 0) {
      output.WriteRawTag(90);
      output.WriteString(RemarkName);
    }
    if (Nickname.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(Nickname);
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
    size += picNumMap_.CalculateSize(_map_picNumMap_codec);
    if (AvatarId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
    }
    if (RemarkName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
    }
    if (Nickname.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
    }
    if (Signature.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
    }
    if (profilePicture_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
    }
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BlessingFriendPicData other) {
    if (other == null) {
      return;
    }
    picNumMap_.Add(other.picNumMap_);
    if (other.AvatarId != 0) {
      AvatarId = other.AvatarId;
    }
    if (other.RemarkName.Length != 0) {
      RemarkName = other.RemarkName;
    }
    if (other.Nickname.Length != 0) {
      Nickname = other.Nickname;
    }
    if (other.Signature.Length != 0) {
      Signature = other.Signature;
    }
    if (other.profilePicture_ != null) {
      if (profilePicture_ == null) {
        ProfilePicture = new global::ProfilePicture();
      }
      ProfilePicture.MergeFrom(other.ProfilePicture);
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
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
        case 10: {
          Signature = input.ReadString();
          break;
        }
        case 34: {
          picNumMap_.AddEntriesFrom(input, _map_picNumMap_codec);
          break;
        }
        case 40: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 50: {
          if (profilePicture_ == null) {
            ProfilePicture = new global::ProfilePicture();
          }
          input.ReadMessage(ProfilePicture);
          break;
        }
        case 72: {
          Uid = input.ReadUInt32();
          break;
        }
        case 90: {
          RemarkName = input.ReadString();
          break;
        }
        case 114: {
          Nickname = input.ReadString();
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
        case 10: {
          Signature = input.ReadString();
          break;
        }
        case 34: {
          picNumMap_.AddEntriesFrom(ref input, _map_picNumMap_codec);
          break;
        }
        case 40: {
          AvatarId = input.ReadUInt32();
          break;
        }
        case 50: {
          if (profilePicture_ == null) {
            ProfilePicture = new global::ProfilePicture();
          }
          input.ReadMessage(ProfilePicture);
          break;
        }
        case 72: {
          Uid = input.ReadUInt32();
          break;
        }
        case 90: {
          RemarkName = input.ReadString();
          break;
        }
        case 114: {
          Nickname = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
