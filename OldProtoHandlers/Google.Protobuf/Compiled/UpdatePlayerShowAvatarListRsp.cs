// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpdatePlayerShowAvatarListRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from UpdatePlayerShowAvatarListRsp.proto</summary>
public static partial class UpdatePlayerShowAvatarListRspReflection {

  #region Descriptor
  /// <summary>File descriptor for UpdatePlayerShowAvatarListRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static UpdatePlayerShowAvatarListRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNVcGRhdGVQbGF5ZXJTaG93QXZhdGFyTGlzdFJzcC5wcm90byJlCh1VcGRh",
          "dGVQbGF5ZXJTaG93QXZhdGFyTGlzdFJzcBIbChNzaG93X2F2YXRhcl9pZF9s",
          "aXN0GAEgAygNEhYKDmlzX3Nob3dfYXZhdGFyGAMgASgIEg8KB3JldGNvZGUY",
          "CiABKAVCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::UpdatePlayerShowAvatarListRsp), global::UpdatePlayerShowAvatarListRsp.Parser, new[]{ "ShowAvatarIdList", "IsShowAvatar", "Retcode" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 4058
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class UpdatePlayerShowAvatarListRsp : pb::IMessage<UpdatePlayerShowAvatarListRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<UpdatePlayerShowAvatarListRsp> _parser = new pb::MessageParser<UpdatePlayerShowAvatarListRsp>(() => new UpdatePlayerShowAvatarListRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<UpdatePlayerShowAvatarListRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::UpdatePlayerShowAvatarListRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UpdatePlayerShowAvatarListRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UpdatePlayerShowAvatarListRsp(UpdatePlayerShowAvatarListRsp other) : this() {
    showAvatarIdList_ = other.showAvatarIdList_.Clone();
    isShowAvatar_ = other.isShowAvatar_;
    retcode_ = other.retcode_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public UpdatePlayerShowAvatarListRsp Clone() {
    return new UpdatePlayerShowAvatarListRsp(this);
  }

  /// <summary>Field number for the "show_avatar_id_list" field.</summary>
  public const int ShowAvatarIdListFieldNumber = 1;
  private static readonly pb::FieldCodec<uint> _repeated_showAvatarIdList_codec
      = pb::FieldCodec.ForUInt32(10);
  private readonly pbc::RepeatedField<uint> showAvatarIdList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ShowAvatarIdList {
    get { return showAvatarIdList_; }
  }

  /// <summary>Field number for the "is_show_avatar" field.</summary>
  public const int IsShowAvatarFieldNumber = 3;
  private bool isShowAvatar_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsShowAvatar {
    get { return isShowAvatar_; }
    set {
      isShowAvatar_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 10;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as UpdatePlayerShowAvatarListRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(UpdatePlayerShowAvatarListRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!showAvatarIdList_.Equals(other.showAvatarIdList_)) return false;
    if (IsShowAvatar != other.IsShowAvatar) return false;
    if (Retcode != other.Retcode) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= showAvatarIdList_.GetHashCode();
    if (IsShowAvatar != false) hash ^= IsShowAvatar.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    showAvatarIdList_.WriteTo(output, _repeated_showAvatarIdList_codec);
    if (IsShowAvatar != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsShowAvatar);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
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
    showAvatarIdList_.WriteTo(ref output, _repeated_showAvatarIdList_codec);
    if (IsShowAvatar != false) {
      output.WriteRawTag(24);
      output.WriteBool(IsShowAvatar);
    }
    if (Retcode != 0) {
      output.WriteRawTag(80);
      output.WriteInt32(Retcode);
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
    size += showAvatarIdList_.CalculateSize(_repeated_showAvatarIdList_codec);
    if (IsShowAvatar != false) {
      size += 1 + 1;
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(UpdatePlayerShowAvatarListRsp other) {
    if (other == null) {
      return;
    }
    showAvatarIdList_.Add(other.showAvatarIdList_);
    if (other.IsShowAvatar != false) {
      IsShowAvatar = other.IsShowAvatar;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
        case 10:
        case 8: {
          showAvatarIdList_.AddEntriesFrom(input, _repeated_showAvatarIdList_codec);
          break;
        }
        case 24: {
          IsShowAvatar = input.ReadBool();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
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
        case 10:
        case 8: {
          showAvatarIdList_.AddEntriesFrom(ref input, _repeated_showAvatarIdList_codec);
          break;
        }
        case 24: {
          IsShowAvatar = input.ReadBool();
          break;
        }
        case 80: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
