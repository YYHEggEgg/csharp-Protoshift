// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IslandPartySettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from IslandPartySettleNotify.proto</summary>
  public static partial class IslandPartySettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for IslandPartySettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IslandPartySettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Jc2xhbmRQYXJ0eVNldHRsZU5vdGlmeS5wcm90bxobRXhoaWJpdGlvbkRp",
            "c3BsYXlJbmZvLnByb3RvGhdHYWxsZXJ5U3RvcFJlYXNvbi5wcm90bxoiSXNs",
            "YW5kUGFydHlHYWxsZXJ5U2V0dGxlSW5mby5wcm90byLOAQoXSXNsYW5kUGFy",
            "dHlTZXR0bGVOb3RpZnkSEwoLdGltZV9yZW1haW4YCSABKA0SFQoNaXNfbmV3",
            "X3JlY29yZBgDIAEoCBIqCgpzY29yZV9saXN0GAUgAygLMhYuRXhoaWJpdGlv",
            "bkRpc3BsYXlJbmZvEiIKBnJlYXNvbhgMIAEoDjISLkdhbGxlcnlTdG9wUmVh",
            "c29uEjcKEHNldHRsZV9pbmZvX2xpc3QYDSADKAsyHS5Jc2xhbmRQYXJ0eUdh",
            "bGxlcnlTZXR0bGVJbmZvQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ExhibitionDisplayInfoReflection.Descriptor, global::NewProtos.GalleryStopReasonReflection.Descriptor, global::NewProtos.IslandPartyGallerySettleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.IslandPartySettleNotify), global::NewProtos.IslandPartySettleNotify.Parser, new[]{ "TimeRemain", "IsNewRecord", "ScoreList", "Reason", "SettleInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 24127;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class IslandPartySettleNotify : pb::IMessage<IslandPartySettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IslandPartySettleNotify> _parser = new pb::MessageParser<IslandPartySettleNotify>(() => new IslandPartySettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IslandPartySettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.IslandPartySettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartySettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartySettleNotify(IslandPartySettleNotify other) : this() {
      timeRemain_ = other.timeRemain_;
      isNewRecord_ = other.isNewRecord_;
      scoreList_ = other.scoreList_.Clone();
      reason_ = other.reason_;
      settleInfoList_ = other.settleInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartySettleNotify Clone() {
      return new IslandPartySettleNotify(this);
    }

    /// <summary>Field number for the "time_remain" field.</summary>
    public const int TimeRemainFieldNumber = 9;
    private uint timeRemain_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeRemain {
      get { return timeRemain_; }
      set {
        timeRemain_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 3;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "score_list" field.</summary>
    public const int ScoreListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::NewProtos.ExhibitionDisplayInfo> _repeated_scoreList_codec
        = pb::FieldCodec.ForMessage(42, global::NewProtos.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo> scoreList_ = new pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ExhibitionDisplayInfo> ScoreList {
      get { return scoreList_; }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 12;
    private global::NewProtos.GalleryStopReason reason_ = global::NewProtos.GalleryStopReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GalleryStopReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "settle_info_list" field.</summary>
    public const int SettleInfoListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.IslandPartyGallerySettleInfo> _repeated_settleInfoList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.IslandPartyGallerySettleInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.IslandPartyGallerySettleInfo> settleInfoList_ = new pbc::RepeatedField<global::NewProtos.IslandPartyGallerySettleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.IslandPartyGallerySettleInfo> SettleInfoList {
      get { return settleInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IslandPartySettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IslandPartySettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TimeRemain != other.TimeRemain) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if(!scoreList_.Equals(other.scoreList_)) return false;
      if (Reason != other.Reason) return false;
      if(!settleInfoList_.Equals(other.settleInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TimeRemain != 0) hash ^= TimeRemain.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      hash ^= scoreList_.GetHashCode();
      if (Reason != global::NewProtos.GalleryStopReason.None) hash ^= Reason.GetHashCode();
      hash ^= settleInfoList_.GetHashCode();
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
      if (IsNewRecord != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewRecord);
      }
      scoreList_.WriteTo(output, _repeated_scoreList_codec);
      if (TimeRemain != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeRemain);
      }
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Reason);
      }
      settleInfoList_.WriteTo(output, _repeated_settleInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsNewRecord != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewRecord);
      }
      scoreList_.WriteTo(ref output, _repeated_scoreList_codec);
      if (TimeRemain != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(TimeRemain);
      }
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Reason);
      }
      settleInfoList_.WriteTo(ref output, _repeated_settleInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TimeRemain != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeRemain);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      size += scoreList_.CalculateSize(_repeated_scoreList_codec);
      if (Reason != global::NewProtos.GalleryStopReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      size += settleInfoList_.CalculateSize(_repeated_settleInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IslandPartySettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.TimeRemain != 0) {
        TimeRemain = other.TimeRemain;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      scoreList_.Add(other.scoreList_);
      if (other.Reason != global::NewProtos.GalleryStopReason.None) {
        Reason = other.Reason;
      }
      settleInfoList_.Add(other.settleInfoList_);
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
          case 24: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 42: {
            scoreList_.AddEntriesFrom(input, _repeated_scoreList_codec);
            break;
          }
          case 72: {
            TimeRemain = input.ReadUInt32();
            break;
          }
          case 96: {
            Reason = (global::NewProtos.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 106: {
            settleInfoList_.AddEntriesFrom(input, _repeated_settleInfoList_codec);
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
          case 24: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 42: {
            scoreList_.AddEntriesFrom(ref input, _repeated_scoreList_codec);
            break;
          }
          case 72: {
            TimeRemain = input.ReadUInt32();
            break;
          }
          case 96: {
            Reason = (global::NewProtos.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 106: {
            settleInfoList_.AddEntriesFrom(ref input, _repeated_settleInfoList_codec);
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
