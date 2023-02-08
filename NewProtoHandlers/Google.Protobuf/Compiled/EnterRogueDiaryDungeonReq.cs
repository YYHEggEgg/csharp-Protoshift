// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterRogueDiaryDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EnterRogueDiaryDungeonReq.proto</summary>
  public static partial class EnterRogueDiaryDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterRogueDiaryDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterRogueDiaryDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9FbnRlclJvZ3VlRGlhcnlEdW5nZW9uUmVxLnByb3RvGhZSb2d1ZURpYXJ5",
            "QXZhdGFyLnByb3RvImQKGUVudGVyUm9ndWVEaWFyeUR1bmdlb25SZXESGAoQ",
            "Y2hvc2VuX2NhcmRfbGlzdBgFIAMoDRItChJjaG9zZW5fYXZhdGFyX2xpc3QY",
            "CSADKAsyES5Sb2d1ZURpYXJ5QXZhdGFyQgyqAglOZXdQcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EnterRogueDiaryDungeonReq), global::NewProtos.EnterRogueDiaryDungeonReq.Parser, new[]{ "ChosenCardList", "ChosenAvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8627;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class EnterRogueDiaryDungeonReq : pb::IMessage<EnterRogueDiaryDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterRogueDiaryDungeonReq> _parser = new pb::MessageParser<EnterRogueDiaryDungeonReq>(() => new EnterRogueDiaryDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterRogueDiaryDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EnterRogueDiaryDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq(EnterRogueDiaryDungeonReq other) : this() {
      chosenCardList_ = other.chosenCardList_.Clone();
      chosenAvatarList_ = other.chosenAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq Clone() {
      return new EnterRogueDiaryDungeonReq(this);
    }

    /// <summary>Field number for the "chosen_card_list" field.</summary>
    public const int ChosenCardListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_chosenCardList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> chosenCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenCardList {
      get { return chosenCardList_; }
    }

    /// <summary>Field number for the "chosen_avatar_list" field.</summary>
    public const int ChosenAvatarListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::NewProtos.RogueDiaryAvatar> _repeated_chosenAvatarList_codec
        = pb::FieldCodec.ForMessage(74, global::NewProtos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar> chosenAvatarList_ = new pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.RogueDiaryAvatar> ChosenAvatarList {
      get { return chosenAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterRogueDiaryDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterRogueDiaryDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chosenCardList_.Equals(other.chosenCardList_)) return false;
      if(!chosenAvatarList_.Equals(other.chosenAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chosenCardList_.GetHashCode();
      hash ^= chosenAvatarList_.GetHashCode();
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
      chosenCardList_.WriteTo(output, _repeated_chosenCardList_codec);
      chosenAvatarList_.WriteTo(output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      chosenCardList_.WriteTo(ref output, _repeated_chosenCardList_codec);
      chosenAvatarList_.WriteTo(ref output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += chosenCardList_.CalculateSize(_repeated_chosenCardList_codec);
      size += chosenAvatarList_.CalculateSize(_repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterRogueDiaryDungeonReq other) {
      if (other == null) {
        return;
      }
      chosenCardList_.Add(other.chosenCardList_);
      chosenAvatarList_.Add(other.chosenAvatarList_);
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
          case 42:
          case 40: {
            chosenCardList_.AddEntriesFrom(input, _repeated_chosenCardList_codec);
            break;
          }
          case 74: {
            chosenAvatarList_.AddEntriesFrom(input, _repeated_chosenAvatarList_codec);
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
          case 42:
          case 40: {
            chosenCardList_.AddEntriesFrom(ref input, _repeated_chosenCardList_codec);
            break;
          }
          case 74: {
            chosenAvatarList_.AddEntriesFrom(ref input, _repeated_chosenAvatarList_codec);
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
