// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryVintageHuntingSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryVintageHuntingSettleNotify.proto</summary>
public static partial class SceneGalleryVintageHuntingSettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryVintageHuntingSettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryVintageHuntingSettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CixTY2VuZUdhbGxlcnlWaW50YWdlSHVudGluZ1NldHRsZU5vdGlmeS5wcm90",
          "bxooVmludGFnZUh1bnRpbmdGaXJzdFN0YWdlU2V0dGxlSW5mby5wcm90bxop",
          "VmludGFnZUh1bnRpbmdTZWNvbmRTdGFnZVNldHRsZUluZm8ucHJvdG8aKFZp",
          "bnRhZ2VIdW50aW5nVGhpcmRTdGFnZVNldHRsZUluZm8ucHJvdG8i8QIKJlNj",
          "ZW5lR2FsbGVyeVZpbnRhZ2VIdW50aW5nU2V0dGxlTm90aWZ5EhcKD2hhc19u",
          "ZXdfd2F0Y2hlchgDIAEoCBIVCg1pc19uZXdfcmVjb3JkGA0gASgIEhsKE1Vu",
          "azMzMDBfRUhHRElLT0dMS0wYDyABKA0SGwoTVW5rMzMwMF9LT0FLSE1MRlBH",
          "TRgGIAEoDRIQCghzdGFnZV9pZBgJIAEoDRI/ChBmaXJzdF9zdGFnZV9pbmZv",
          "GAcgASgLMiMuVmludGFnZUh1bnRpbmdGaXJzdFN0YWdlU2V0dGxlSW5mb0gA",
          "EkEKEXNlY29uZF9zdGFnZV9pbmZvGAggASgLMiQuVmludGFnZUh1bnRpbmdT",
          "ZWNvbmRTdGFnZVNldHRsZUluZm9IABI/ChB0aGlyZF9zdGFnZV9pbmZvGA4g",
          "ASgLMiMuVmludGFnZUh1bnRpbmdUaGlyZFN0YWdlU2V0dGxlSW5mb0gAQgYK",
          "BGluZm9CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VintageHuntingFirstStageSettleInfoReflection.Descriptor, global::VintageHuntingSecondStageSettleInfoReflection.Descriptor, global::VintageHuntingThirdStageSettleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryVintageHuntingSettleNotify), global::SceneGalleryVintageHuntingSettleNotify.Parser, new[]{ "HasNewWatcher", "IsNewRecord", "Unk3300EHGDIKOGLKL", "Unk3300KOAKHMLFPGM", "StageId", "FirstStageInfo", "SecondStageInfo", "ThirdStageInfo" }, new[]{ "Info" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 22325;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class SceneGalleryVintageHuntingSettleNotify : pb::IMessage<SceneGalleryVintageHuntingSettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryVintageHuntingSettleNotify> _parser = new pb::MessageParser<SceneGalleryVintageHuntingSettleNotify>(() => new SceneGalleryVintageHuntingSettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryVintageHuntingSettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryVintageHuntingSettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryVintageHuntingSettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryVintageHuntingSettleNotify(SceneGalleryVintageHuntingSettleNotify other) : this() {
    hasNewWatcher_ = other.hasNewWatcher_;
    isNewRecord_ = other.isNewRecord_;
    unk3300EHGDIKOGLKL_ = other.unk3300EHGDIKOGLKL_;
    unk3300KOAKHMLFPGM_ = other.unk3300KOAKHMLFPGM_;
    stageId_ = other.stageId_;
    switch (other.InfoCase) {
      case InfoOneofCase.FirstStageInfo:
        FirstStageInfo = other.FirstStageInfo.Clone();
        break;
      case InfoOneofCase.SecondStageInfo:
        SecondStageInfo = other.SecondStageInfo.Clone();
        break;
      case InfoOneofCase.ThirdStageInfo:
        ThirdStageInfo = other.ThirdStageInfo.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryVintageHuntingSettleNotify Clone() {
    return new SceneGalleryVintageHuntingSettleNotify(this);
  }

  /// <summary>Field number for the "has_new_watcher" field.</summary>
  public const int HasNewWatcherFieldNumber = 3;
  private bool hasNewWatcher_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasNewWatcher {
    get { return hasNewWatcher_; }
    set {
      hasNewWatcher_ = value;
    }
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 13;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_EHGDIKOGLKL" field.</summary>
  public const int Unk3300EHGDIKOGLKLFieldNumber = 15;
  private uint unk3300EHGDIKOGLKL_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300EHGDIKOGLKL {
    get { return unk3300EHGDIKOGLKL_; }
    set {
      unk3300EHGDIKOGLKL_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_KOAKHMLFPGM" field.</summary>
  public const int Unk3300KOAKHMLFPGMFieldNumber = 6;
  private uint unk3300KOAKHMLFPGM_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300KOAKHMLFPGM {
    get { return unk3300KOAKHMLFPGM_; }
    set {
      unk3300KOAKHMLFPGM_ = value;
    }
  }

  /// <summary>Field number for the "stage_id" field.</summary>
  public const int StageIdFieldNumber = 9;
  private uint stageId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StageId {
    get { return stageId_; }
    set {
      stageId_ = value;
    }
  }

  /// <summary>Field number for the "first_stage_info" field.</summary>
  public const int FirstStageInfoFieldNumber = 7;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::VintageHuntingFirstStageSettleInfo FirstStageInfo {
    get { return infoCase_ == InfoOneofCase.FirstStageInfo ? (global::VintageHuntingFirstStageSettleInfo) info_ : null; }
    set {
      info_ = value;
      infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.FirstStageInfo;
    }
  }

  /// <summary>Field number for the "second_stage_info" field.</summary>
  public const int SecondStageInfoFieldNumber = 8;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::VintageHuntingSecondStageSettleInfo SecondStageInfo {
    get { return infoCase_ == InfoOneofCase.SecondStageInfo ? (global::VintageHuntingSecondStageSettleInfo) info_ : null; }
    set {
      info_ = value;
      infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.SecondStageInfo;
    }
  }

  /// <summary>Field number for the "third_stage_info" field.</summary>
  public const int ThirdStageInfoFieldNumber = 14;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::VintageHuntingThirdStageSettleInfo ThirdStageInfo {
    get { return infoCase_ == InfoOneofCase.ThirdStageInfo ? (global::VintageHuntingThirdStageSettleInfo) info_ : null; }
    set {
      info_ = value;
      infoCase_ = value == null ? InfoOneofCase.None : InfoOneofCase.ThirdStageInfo;
    }
  }

  private object info_;
  /// <summary>Enum of possible cases for the "info" oneof.</summary>
  public enum InfoOneofCase {
    None = 0,
    FirstStageInfo = 7,
    SecondStageInfo = 8,
    ThirdStageInfo = 14,
  }
  private InfoOneofCase infoCase_ = InfoOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InfoOneofCase InfoCase {
    get { return infoCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearInfo() {
    infoCase_ = InfoOneofCase.None;
    info_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryVintageHuntingSettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryVintageHuntingSettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (HasNewWatcher != other.HasNewWatcher) return false;
    if (IsNewRecord != other.IsNewRecord) return false;
    if (Unk3300EHGDIKOGLKL != other.Unk3300EHGDIKOGLKL) return false;
    if (Unk3300KOAKHMLFPGM != other.Unk3300KOAKHMLFPGM) return false;
    if (StageId != other.StageId) return false;
    if (!object.Equals(FirstStageInfo, other.FirstStageInfo)) return false;
    if (!object.Equals(SecondStageInfo, other.SecondStageInfo)) return false;
    if (!object.Equals(ThirdStageInfo, other.ThirdStageInfo)) return false;
    if (InfoCase != other.InfoCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (HasNewWatcher != false) hash ^= HasNewWatcher.GetHashCode();
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (Unk3300EHGDIKOGLKL != 0) hash ^= Unk3300EHGDIKOGLKL.GetHashCode();
    if (Unk3300KOAKHMLFPGM != 0) hash ^= Unk3300KOAKHMLFPGM.GetHashCode();
    if (StageId != 0) hash ^= StageId.GetHashCode();
    if (infoCase_ == InfoOneofCase.FirstStageInfo) hash ^= FirstStageInfo.GetHashCode();
    if (infoCase_ == InfoOneofCase.SecondStageInfo) hash ^= SecondStageInfo.GetHashCode();
    if (infoCase_ == InfoOneofCase.ThirdStageInfo) hash ^= ThirdStageInfo.GetHashCode();
    hash ^= (int) infoCase_;
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
    if (HasNewWatcher != false) {
      output.WriteRawTag(24);
      output.WriteBool(HasNewWatcher);
    }
    if (Unk3300KOAKHMLFPGM != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300KOAKHMLFPGM);
    }
    if (infoCase_ == InfoOneofCase.FirstStageInfo) {
      output.WriteRawTag(58);
      output.WriteMessage(FirstStageInfo);
    }
    if (infoCase_ == InfoOneofCase.SecondStageInfo) {
      output.WriteRawTag(66);
      output.WriteMessage(SecondStageInfo);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsNewRecord);
    }
    if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
      output.WriteRawTag(114);
      output.WriteMessage(ThirdStageInfo);
    }
    if (Unk3300EHGDIKOGLKL != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Unk3300EHGDIKOGLKL);
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
    if (HasNewWatcher != false) {
      output.WriteRawTag(24);
      output.WriteBool(HasNewWatcher);
    }
    if (Unk3300KOAKHMLFPGM != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300KOAKHMLFPGM);
    }
    if (infoCase_ == InfoOneofCase.FirstStageInfo) {
      output.WriteRawTag(58);
      output.WriteMessage(FirstStageInfo);
    }
    if (infoCase_ == InfoOneofCase.SecondStageInfo) {
      output.WriteRawTag(66);
      output.WriteMessage(SecondStageInfo);
    }
    if (StageId != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(StageId);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsNewRecord);
    }
    if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
      output.WriteRawTag(114);
      output.WriteMessage(ThirdStageInfo);
    }
    if (Unk3300EHGDIKOGLKL != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Unk3300EHGDIKOGLKL);
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
    if (HasNewWatcher != false) {
      size += 1 + 1;
    }
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (Unk3300EHGDIKOGLKL != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EHGDIKOGLKL);
    }
    if (Unk3300KOAKHMLFPGM != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KOAKHMLFPGM);
    }
    if (StageId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
    }
    if (infoCase_ == InfoOneofCase.FirstStageInfo) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(FirstStageInfo);
    }
    if (infoCase_ == InfoOneofCase.SecondStageInfo) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SecondStageInfo);
    }
    if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(ThirdStageInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryVintageHuntingSettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.HasNewWatcher != false) {
      HasNewWatcher = other.HasNewWatcher;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.Unk3300EHGDIKOGLKL != 0) {
      Unk3300EHGDIKOGLKL = other.Unk3300EHGDIKOGLKL;
    }
    if (other.Unk3300KOAKHMLFPGM != 0) {
      Unk3300KOAKHMLFPGM = other.Unk3300KOAKHMLFPGM;
    }
    if (other.StageId != 0) {
      StageId = other.StageId;
    }
    switch (other.InfoCase) {
      case InfoOneofCase.FirstStageInfo:
        if (FirstStageInfo == null) {
          FirstStageInfo = new global::VintageHuntingFirstStageSettleInfo();
        }
        FirstStageInfo.MergeFrom(other.FirstStageInfo);
        break;
      case InfoOneofCase.SecondStageInfo:
        if (SecondStageInfo == null) {
          SecondStageInfo = new global::VintageHuntingSecondStageSettleInfo();
        }
        SecondStageInfo.MergeFrom(other.SecondStageInfo);
        break;
      case InfoOneofCase.ThirdStageInfo:
        if (ThirdStageInfo == null) {
          ThirdStageInfo = new global::VintageHuntingThirdStageSettleInfo();
        }
        ThirdStageInfo.MergeFrom(other.ThirdStageInfo);
        break;
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
        case 24: {
          HasNewWatcher = input.ReadBool();
          break;
        }
        case 48: {
          Unk3300KOAKHMLFPGM = input.ReadUInt32();
          break;
        }
        case 58: {
          global::VintageHuntingFirstStageSettleInfo subBuilder = new global::VintageHuntingFirstStageSettleInfo();
          if (infoCase_ == InfoOneofCase.FirstStageInfo) {
            subBuilder.MergeFrom(FirstStageInfo);
          }
          input.ReadMessage(subBuilder);
          FirstStageInfo = subBuilder;
          break;
        }
        case 66: {
          global::VintageHuntingSecondStageSettleInfo subBuilder = new global::VintageHuntingSecondStageSettleInfo();
          if (infoCase_ == InfoOneofCase.SecondStageInfo) {
            subBuilder.MergeFrom(SecondStageInfo);
          }
          input.ReadMessage(subBuilder);
          SecondStageInfo = subBuilder;
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 104: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 114: {
          global::VintageHuntingThirdStageSettleInfo subBuilder = new global::VintageHuntingThirdStageSettleInfo();
          if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
            subBuilder.MergeFrom(ThirdStageInfo);
          }
          input.ReadMessage(subBuilder);
          ThirdStageInfo = subBuilder;
          break;
        }
        case 120: {
          Unk3300EHGDIKOGLKL = input.ReadUInt32();
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
          HasNewWatcher = input.ReadBool();
          break;
        }
        case 48: {
          Unk3300KOAKHMLFPGM = input.ReadUInt32();
          break;
        }
        case 58: {
          global::VintageHuntingFirstStageSettleInfo subBuilder = new global::VintageHuntingFirstStageSettleInfo();
          if (infoCase_ == InfoOneofCase.FirstStageInfo) {
            subBuilder.MergeFrom(FirstStageInfo);
          }
          input.ReadMessage(subBuilder);
          FirstStageInfo = subBuilder;
          break;
        }
        case 66: {
          global::VintageHuntingSecondStageSettleInfo subBuilder = new global::VintageHuntingSecondStageSettleInfo();
          if (infoCase_ == InfoOneofCase.SecondStageInfo) {
            subBuilder.MergeFrom(SecondStageInfo);
          }
          input.ReadMessage(subBuilder);
          SecondStageInfo = subBuilder;
          break;
        }
        case 72: {
          StageId = input.ReadUInt32();
          break;
        }
        case 104: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 114: {
          global::VintageHuntingThirdStageSettleInfo subBuilder = new global::VintageHuntingThirdStageSettleInfo();
          if (infoCase_ == InfoOneofCase.ThirdStageInfo) {
            subBuilder.MergeFrom(ThirdStageInfo);
          }
          input.ReadMessage(subBuilder);
          ThirdStageInfo = subBuilder;
          break;
        }
        case 120: {
          Unk3300EHGDIKOGLKL = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
