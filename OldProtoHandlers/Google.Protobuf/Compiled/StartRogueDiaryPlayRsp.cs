// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartRogueDiaryPlayRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from StartRogueDiaryPlayRsp.proto</summary>
  public static partial class StartRogueDiaryPlayRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartRogueDiaryPlayRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRogueDiaryPlayRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdGFydFJvZ3VlRGlhcnlQbGF5UnNwLnByb3RvGhZSb2d1ZURpYXJ5QXZh",
            "dGFyLnByb3RvIpcBChZTdGFydFJvZ3VlRGlhcnlQbGF5UnNwEg8KB3JldGNv",
            "ZGUYCyABKAUSLAoRdHJpYWxfYXZhdGFyX2xpc3QYDSADKAsyES5Sb2d1ZURp",
            "YXJ5QXZhdGFyEhYKDnJhbmRfY2FyZF9saXN0GAwgAygNEiYKC2F2YXRhcl9s",
            "aXN0GAkgAygLMhEuUm9ndWVEaWFyeUF2YXRhckIMqgIJT2xkUHJvdG9zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.StartRogueDiaryPlayRsp), global::OldProtos.StartRogueDiaryPlayRsp.Parser, new[]{ "Retcode", "TrialAvatarList", "RandCardList", "AvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 8385
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class StartRogueDiaryPlayRsp : pb::IMessage<StartRogueDiaryPlayRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartRogueDiaryPlayRsp> _parser = new pb::MessageParser<StartRogueDiaryPlayRsp>(() => new StartRogueDiaryPlayRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartRogueDiaryPlayRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.StartRogueDiaryPlayRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp(StartRogueDiaryPlayRsp other) : this() {
      retcode_ = other.retcode_;
      trialAvatarList_ = other.trialAvatarList_.Clone();
      randCardList_ = other.randCardList_.Clone();
      avatarList_ = other.avatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp Clone() {
      return new StartRogueDiaryPlayRsp(this);
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "trial_avatar_list" field.</summary>
    public const int TrialAvatarListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::OldProtos.RogueDiaryAvatar> _repeated_trialAvatarList_codec
        = pb::FieldCodec.ForMessage(106, global::OldProtos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar> trialAvatarList_ = new pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar> TrialAvatarList {
      get { return trialAvatarList_; }
    }

    /// <summary>Field number for the "rand_card_list" field.</summary>
    public const int RandCardListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_randCardList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> randCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RandCardList {
      get { return randCardList_; }
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::OldProtos.RogueDiaryAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(74, global::OldProtos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar> avatarList_ = new pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.RogueDiaryAvatar> AvatarList {
      get { return avatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartRogueDiaryPlayRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartRogueDiaryPlayRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Retcode != other.Retcode) return false;
      if(!trialAvatarList_.Equals(other.trialAvatarList_)) return false;
      if(!randCardList_.Equals(other.randCardList_)) return false;
      if(!avatarList_.Equals(other.avatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= trialAvatarList_.GetHashCode();
      hash ^= randCardList_.GetHashCode();
      hash ^= avatarList_.GetHashCode();
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
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      randCardList_.WriteTo(output, _repeated_randCardList_codec);
      trialAvatarList_.WriteTo(output, _repeated_trialAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      randCardList_.WriteTo(ref output, _repeated_randCardList_codec);
      trialAvatarList_.WriteTo(ref output, _repeated_trialAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += trialAvatarList_.CalculateSize(_repeated_trialAvatarList_codec);
      size += randCardList_.CalculateSize(_repeated_randCardList_codec);
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartRogueDiaryPlayRsp other) {
      if (other == null) {
        return;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      trialAvatarList_.Add(other.trialAvatarList_);
      randCardList_.Add(other.randCardList_);
      avatarList_.Add(other.avatarList_);
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
          case 74: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98:
          case 96: {
            randCardList_.AddEntriesFrom(input, _repeated_randCardList_codec);
            break;
          }
          case 106: {
            trialAvatarList_.AddEntriesFrom(input, _repeated_trialAvatarList_codec);
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
          case 74: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98:
          case 96: {
            randCardList_.AddEntriesFrom(ref input, _repeated_randCardList_codec);
            break;
          }
          case 106: {
            trialAvatarList_.AddEntriesFrom(ref input, _repeated_trialAvatarList_codec);
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
