// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryTiredAvatarNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from RogueDiaryTiredAvatarNotify.proto</summary>
  public static partial class RogueDiaryTiredAvatarNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryTiredAvatarNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryTiredAvatarNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFSb2d1ZURpYXJ5VGlyZWRBdmF0YXJOb3RpZnkucHJvdG8aFlJvZ3VlRGlh",
            "cnlBdmF0YXIucHJvdG8ipAEKG1JvZ3VlRGlhcnlUaXJlZEF2YXRhck5vdGlm",
            "eRIbChNVbmszMzAwX0RNRU1CQlBFSUdLGAEgASgNEhsKE1VuazMzMDBfQkdF",
            "SkdMQk1GSUkYDiABKA0SFAoMaXNfbmVlZF9zaG93GAsgASgIEjUKGm9wdGlv",
            "bmFsX3RpcmVkX2F2YXRhcl9saXN0GAUgAygLMhEuUm9ndWVEaWFyeUF2YXRh",
            "ckIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.RogueDiaryTiredAvatarNotify), global::NewProtos.RogueDiaryTiredAvatarNotify.Parser, new[]{ "Unk3300DMEMBBPEIGK", "Unk3300BGEJGLBMFII", "IsNeedShow", "OptionalTiredAvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8660;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class RogueDiaryTiredAvatarNotify : pb::IMessage<RogueDiaryTiredAvatarNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryTiredAvatarNotify> _parser = new pb::MessageParser<RogueDiaryTiredAvatarNotify>(() => new RogueDiaryTiredAvatarNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryTiredAvatarNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.RogueDiaryTiredAvatarNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify(RogueDiaryTiredAvatarNotify other) : this() {
      unk3300DMEMBBPEIGK_ = other.unk3300DMEMBBPEIGK_;
      unk3300BGEJGLBMFII_ = other.unk3300BGEJGLBMFII_;
      isNeedShow_ = other.isNeedShow_;
      optionalTiredAvatarList_ = other.optionalTiredAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryTiredAvatarNotify Clone() {
      return new RogueDiaryTiredAvatarNotify(this);
    }

    /// <summary>Field number for the "Unk3300_DMEMBBPEIGK" field.</summary>
    public const int Unk3300DMEMBBPEIGKFieldNumber = 1;
    private uint unk3300DMEMBBPEIGK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DMEMBBPEIGK {
      get { return unk3300DMEMBBPEIGK_; }
      set {
        unk3300DMEMBBPEIGK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BGEJGLBMFII" field.</summary>
    public const int Unk3300BGEJGLBMFIIFieldNumber = 14;
    private uint unk3300BGEJGLBMFII_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300BGEJGLBMFII {
      get { return unk3300BGEJGLBMFII_; }
      set {
        unk3300BGEJGLBMFII_ = value;
      }
    }

    /// <summary>Field number for the "is_need_show" field.</summary>
    public const int IsNeedShowFieldNumber = 11;
    private bool isNeedShow_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNeedShow {
      get { return isNeedShow_; }
      set {
        isNeedShow_ = value;
      }
    }

    /// <summary>Field number for the "optional_tired_avatar_list" field.</summary>
    public const int OptionalTiredAvatarListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NewProtos.RogueDiaryAvatar> _repeated_optionalTiredAvatarList_codec
        = pb::FieldCodec.ForMessage(42, global::NewProtos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar> optionalTiredAvatarList_ = new pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar> OptionalTiredAvatarList {
      get { return optionalTiredAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryTiredAvatarNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryTiredAvatarNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300DMEMBBPEIGK != other.Unk3300DMEMBBPEIGK) return false;
      if (Unk3300BGEJGLBMFII != other.Unk3300BGEJGLBMFII) return false;
      if (IsNeedShow != other.IsNeedShow) return false;
      if(!optionalTiredAvatarList_.Equals(other.optionalTiredAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300DMEMBBPEIGK != 0) hash ^= Unk3300DMEMBBPEIGK.GetHashCode();
      if (Unk3300BGEJGLBMFII != 0) hash ^= Unk3300BGEJGLBMFII.GetHashCode();
      if (IsNeedShow != false) hash ^= IsNeedShow.GetHashCode();
      hash ^= optionalTiredAvatarList_.GetHashCode();
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
      if (Unk3300DMEMBBPEIGK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300DMEMBBPEIGK);
      }
      optionalTiredAvatarList_.WriteTo(output, _repeated_optionalTiredAvatarList_codec);
      if (IsNeedShow != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsNeedShow);
      }
      if (Unk3300BGEJGLBMFII != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300BGEJGLBMFII);
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
      if (Unk3300DMEMBBPEIGK != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300DMEMBBPEIGK);
      }
      optionalTiredAvatarList_.WriteTo(ref output, _repeated_optionalTiredAvatarList_codec);
      if (IsNeedShow != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsNeedShow);
      }
      if (Unk3300BGEJGLBMFII != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300BGEJGLBMFII);
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
      if (Unk3300DMEMBBPEIGK != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DMEMBBPEIGK);
      }
      if (Unk3300BGEJGLBMFII != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BGEJGLBMFII);
      }
      if (IsNeedShow != false) {
        size += 1 + 1;
      }
      size += optionalTiredAvatarList_.CalculateSize(_repeated_optionalTiredAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryTiredAvatarNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300DMEMBBPEIGK != 0) {
        Unk3300DMEMBBPEIGK = other.Unk3300DMEMBBPEIGK;
      }
      if (other.Unk3300BGEJGLBMFII != 0) {
        Unk3300BGEJGLBMFII = other.Unk3300BGEJGLBMFII;
      }
      if (other.IsNeedShow != false) {
        IsNeedShow = other.IsNeedShow;
      }
      optionalTiredAvatarList_.Add(other.optionalTiredAvatarList_);
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
            Unk3300DMEMBBPEIGK = input.ReadUInt32();
            break;
          }
          case 42: {
            optionalTiredAvatarList_.AddEntriesFrom(input, _repeated_optionalTiredAvatarList_codec);
            break;
          }
          case 88: {
            IsNeedShow = input.ReadBool();
            break;
          }
          case 112: {
            Unk3300BGEJGLBMFII = input.ReadUInt32();
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
            Unk3300DMEMBBPEIGK = input.ReadUInt32();
            break;
          }
          case 42: {
            optionalTiredAvatarList_.AddEntriesFrom(ref input, _repeated_optionalTiredAvatarList_codec);
            break;
          }
          case 88: {
            IsNeedShow = input.ReadBool();
            break;
          }
          case 112: {
            Unk3300BGEJGLBMFII = input.ReadUInt32();
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