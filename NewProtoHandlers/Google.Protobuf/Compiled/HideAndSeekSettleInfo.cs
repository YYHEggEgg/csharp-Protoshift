// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HideAndSeekSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HideAndSeekSettleInfo.proto</summary>
public static partial class HideAndSeekSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for HideAndSeekSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HideAndSeekSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtIaWRlQW5kU2Vla1NldHRsZUluZm8ucHJvdG8aG0V4aGliaXRpb25EaXNw",
          "bGF5SW5mby5wcm90bxoUUHJvZmlsZVBpY3R1cmUucHJvdG8isgEKFUhpZGVB",
          "bmRTZWVrU2V0dGxlSW5mbxIpCgljYXJkX2xpc3QYAiADKAsyFi5FeGhpYml0",
          "aW9uRGlzcGxheUluZm8SEAoIbmlja25hbWUYDyABKAkSEgoKaGVhZF9pbWFn",
          "ZRgJIAEoDRILCgN1aWQYBiABKA0SEQoJb25saW5lX2lkGAUgASgJEigKD3By",
          "b2ZpbGVfcGljdHVyZRgOIAEoCzIPLlByb2ZpbGVQaWN0dXJlQhYKFG9yZy5z",
          "b3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ExhibitionDisplayInfoReflection.Descriptor, global::ProfilePictureReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HideAndSeekSettleInfo), global::HideAndSeekSettleInfo.Parser, new[]{ "CardList", "Nickname", "HeadImage", "Uid", "OnlineId", "ProfilePicture" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HideAndSeekSettleInfo : pb::IMessage<HideAndSeekSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HideAndSeekSettleInfo> _parser = new pb::MessageParser<HideAndSeekSettleInfo>(() => new HideAndSeekSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HideAndSeekSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HideAndSeekSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleInfo(HideAndSeekSettleInfo other) : this() {
    cardList_ = other.cardList_.Clone();
    nickname_ = other.nickname_;
    headImage_ = other.headImage_;
    uid_ = other.uid_;
    onlineId_ = other.onlineId_;
    profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HideAndSeekSettleInfo Clone() {
    return new HideAndSeekSettleInfo(this);
  }

  /// <summary>Field number for the "card_list" field.</summary>
  public const int CardListFieldNumber = 2;
  private static readonly pb::FieldCodec<global::ExhibitionDisplayInfo> _repeated_cardList_codec
      = pb::FieldCodec.ForMessage(18, global::ExhibitionDisplayInfo.Parser);
  private readonly pbc::RepeatedField<global::ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::ExhibitionDisplayInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ExhibitionDisplayInfo> CardList {
    get { return cardList_; }
  }

  /// <summary>Field number for the "nickname" field.</summary>
  public const int NicknameFieldNumber = 15;
  private string nickname_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string Nickname {
    get { return nickname_; }
    set {
      nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "head_image" field.</summary>
  public const int HeadImageFieldNumber = 9;
  private uint headImage_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint HeadImage {
    get { return headImage_; }
    set {
      headImage_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 6;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "online_id" field.</summary>
  public const int OnlineIdFieldNumber = 5;
  private string onlineId_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string OnlineId {
    get { return onlineId_; }
    set {
      onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "profile_picture" field.</summary>
  public const int ProfilePictureFieldNumber = 14;
  private global::ProfilePicture profilePicture_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ProfilePicture ProfilePicture {
    get { return profilePicture_; }
    set {
      profilePicture_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HideAndSeekSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HideAndSeekSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!cardList_.Equals(other.cardList_)) return false;
    if (Nickname != other.Nickname) return false;
    if (HeadImage != other.HeadImage) return false;
    if (Uid != other.Uid) return false;
    if (OnlineId != other.OnlineId) return false;
    if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= cardList_.GetHashCode();
    if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
    if (HeadImage != 0) hash ^= HeadImage.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
    if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
    if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
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
    cardList_.WriteTo(output, _repeated_cardList_codec);
    if (OnlineId.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(OnlineId);
    }
    if (Uid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Uid);
    }
    if (HeadImage != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(HeadImage);
    }
    if (profilePicture_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(ProfilePicture);
    }
    if (Nickname.Length != 0) {
      output.WriteRawTag(122);
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
    cardList_.WriteTo(ref output, _repeated_cardList_codec);
    if (OnlineId.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(OnlineId);
    }
    if (Uid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Uid);
    }
    if (HeadImage != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(HeadImage);
    }
    if (profilePicture_ != null) {
      output.WriteRawTag(114);
      output.WriteMessage(ProfilePicture);
    }
    if (Nickname.Length != 0) {
      output.WriteRawTag(122);
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
    size += cardList_.CalculateSize(_repeated_cardList_codec);
    if (Nickname.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
    }
    if (HeadImage != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadImage);
    }
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (OnlineId.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
    }
    if (profilePicture_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HideAndSeekSettleInfo other) {
    if (other == null) {
      return;
    }
    cardList_.Add(other.cardList_);
    if (other.Nickname.Length != 0) {
      Nickname = other.Nickname;
    }
    if (other.HeadImage != 0) {
      HeadImage = other.HeadImage;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    if (other.OnlineId.Length != 0) {
      OnlineId = other.OnlineId;
    }
    if (other.profilePicture_ != null) {
      if (profilePicture_ == null) {
        ProfilePicture = new global::ProfilePicture();
      }
      ProfilePicture.MergeFrom(other.ProfilePicture);
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
          cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
          break;
        }
        case 42: {
          OnlineId = input.ReadString();
          break;
        }
        case 48: {
          Uid = input.ReadUInt32();
          break;
        }
        case 72: {
          HeadImage = input.ReadUInt32();
          break;
        }
        case 114: {
          if (profilePicture_ == null) {
            ProfilePicture = new global::ProfilePicture();
          }
          input.ReadMessage(ProfilePicture);
          break;
        }
        case 122: {
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
        case 18: {
          cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
          break;
        }
        case 42: {
          OnlineId = input.ReadString();
          break;
        }
        case 48: {
          Uid = input.ReadUInt32();
          break;
        }
        case 72: {
          HeadImage = input.ReadUInt32();
          break;
        }
        case 114: {
          if (profilePicture_ == null) {
            ProfilePicture = new global::ProfilePicture();
          }
          input.ReadMessage(ProfilePicture);
          break;
        }
        case 122: {
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