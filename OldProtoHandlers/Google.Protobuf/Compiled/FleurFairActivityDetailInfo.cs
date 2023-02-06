// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FleurFairActivityDetailInfo.proto</summary>
public static partial class FleurFairActivityDetailInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for FleurFairActivityDetailInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FleurFairActivityDetailInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiFGbGV1ckZhaXJBY3Rpdml0eURldGFpbEluZm8ucHJvdG8aGkZsZXVyRmFp",
          "ckNoYXB0ZXJJbmZvLnByb3RvGiFGbGV1ckZhaXJEdW5nZW9uU2VjdGlvbklu",
          "Zm8ucHJvdG8aG0ZsZXVyRmFpck1pbmlnYW1lSW5mby5wcm90byKyBAobRmxl",
          "dXJGYWlyQWN0aXZpdHlEZXRhaWxJbmZvEhkKEWlzX2NvbnRlbnRfY2xvc2Vk",
          "GAQgASgIEiAKGGR1bmdlb25fcHVuaXNoX292ZXJfdGltZRgGIAEoDRIaChJj",
          "b250ZW50X2Nsb3NlX3RpbWUYDyABKA0SFgoOb2J0YWluZWRfdG9rZW4YDSAB",
          "KA0SMAoRY2hhcHRlcl9pbmZvX2xpc3QYDiADKAsyFS5GbGV1ckZhaXJDaGFw",
          "dGVySW5mbxJMChFtaW5pZ2FtZV9pbmZvX21hcBgJIAMoCzIxLkZsZXVyRmFp",
          "ckFjdGl2aXR5RGV0YWlsSW5mby5NaW5pZ2FtZUluZm9NYXBFbnRyeRJZChhk",
          "dW5nZW9uX3NlY3Rpb25faW5mb19tYXAYAyADKAsyNy5GbGV1ckZhaXJBY3Rp",
          "dml0eURldGFpbEluZm8uRHVuZ2VvblNlY3Rpb25JbmZvTWFwRW50cnkSGwoT",
          "aXNfZHVuZ2Vvbl91bmxvY2tlZBgLIAEoCBpOChRNaW5pZ2FtZUluZm9NYXBF",
          "bnRyeRILCgNrZXkYASABKA0SJQoFdmFsdWUYAiABKAsyFi5GbGV1ckZhaXJN",
          "aW5pZ2FtZUluZm86AjgBGloKGkR1bmdlb25TZWN0aW9uSW5mb01hcEVudHJ5",
          "EgsKA2tleRgBIAEoDRIrCgV2YWx1ZRgCIAEoCzIcLkZsZXVyRmFpckR1bmdl",
          "b25TZWN0aW9uSW5mbzoCOAFCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRw",
          "cm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::FleurFairChapterInfoReflection.Descriptor, global::FleurFairDungeonSectionInfoReflection.Descriptor, global::FleurFairMinigameInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FleurFairActivityDetailInfo), global::FleurFairActivityDetailInfo.Parser, new[]{ "IsContentClosed", "DungeonPunishOverTime", "ContentCloseTime", "ObtainedToken", "ChapterInfoList", "MinigameInfoMap", "DungeonSectionInfoMap", "IsDungeonUnlocked" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
        }));
  }
  #endregion

}
#region Messages
public sealed partial class FleurFairActivityDetailInfo : pb::IMessage<FleurFairActivityDetailInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FleurFairActivityDetailInfo> _parser = new pb::MessageParser<FleurFairActivityDetailInfo>(() => new FleurFairActivityDetailInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FleurFairActivityDetailInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FleurFairActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairActivityDetailInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairActivityDetailInfo(FleurFairActivityDetailInfo other) : this() {
    isContentClosed_ = other.isContentClosed_;
    dungeonPunishOverTime_ = other.dungeonPunishOverTime_;
    contentCloseTime_ = other.contentCloseTime_;
    obtainedToken_ = other.obtainedToken_;
    chapterInfoList_ = other.chapterInfoList_.Clone();
    minigameInfoMap_ = other.minigameInfoMap_.Clone();
    dungeonSectionInfoMap_ = other.dungeonSectionInfoMap_.Clone();
    isDungeonUnlocked_ = other.isDungeonUnlocked_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairActivityDetailInfo Clone() {
    return new FleurFairActivityDetailInfo(this);
  }

  /// <summary>Field number for the "is_content_closed" field.</summary>
  public const int IsContentClosedFieldNumber = 4;
  private bool isContentClosed_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsContentClosed {
    get { return isContentClosed_; }
    set {
      isContentClosed_ = value;
    }
  }

  /// <summary>Field number for the "dungeon_punish_over_time" field.</summary>
  public const int DungeonPunishOverTimeFieldNumber = 6;
  private uint dungeonPunishOverTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint DungeonPunishOverTime {
    get { return dungeonPunishOverTime_; }
    set {
      dungeonPunishOverTime_ = value;
    }
  }

  /// <summary>Field number for the "content_close_time" field.</summary>
  public const int ContentCloseTimeFieldNumber = 15;
  private uint contentCloseTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ContentCloseTime {
    get { return contentCloseTime_; }
    set {
      contentCloseTime_ = value;
    }
  }

  /// <summary>Field number for the "obtained_token" field.</summary>
  public const int ObtainedTokenFieldNumber = 13;
  private uint obtainedToken_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ObtainedToken {
    get { return obtainedToken_; }
    set {
      obtainedToken_ = value;
    }
  }

  /// <summary>Field number for the "chapter_info_list" field.</summary>
  public const int ChapterInfoListFieldNumber = 14;
  private static readonly pb::FieldCodec<global::FleurFairChapterInfo> _repeated_chapterInfoList_codec
      = pb::FieldCodec.ForMessage(114, global::FleurFairChapterInfo.Parser);
  private readonly pbc::RepeatedField<global::FleurFairChapterInfo> chapterInfoList_ = new pbc::RepeatedField<global::FleurFairChapterInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::FleurFairChapterInfo> ChapterInfoList {
    get { return chapterInfoList_; }
  }

  /// <summary>Field number for the "minigame_info_map" field.</summary>
  public const int MinigameInfoMapFieldNumber = 9;
  private static readonly pbc::MapField<uint, global::FleurFairMinigameInfo>.Codec _map_minigameInfoMap_codec
      = new pbc::MapField<uint, global::FleurFairMinigameInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::FleurFairMinigameInfo.Parser), 74);
  private readonly pbc::MapField<uint, global::FleurFairMinigameInfo> minigameInfoMap_ = new pbc::MapField<uint, global::FleurFairMinigameInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::FleurFairMinigameInfo> MinigameInfoMap {
    get { return minigameInfoMap_; }
  }

  /// <summary>Field number for the "dungeon_section_info_map" field.</summary>
  public const int DungeonSectionInfoMapFieldNumber = 3;
  private static readonly pbc::MapField<uint, global::FleurFairDungeonSectionInfo>.Codec _map_dungeonSectionInfoMap_codec
      = new pbc::MapField<uint, global::FleurFairDungeonSectionInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::FleurFairDungeonSectionInfo.Parser), 26);
  private readonly pbc::MapField<uint, global::FleurFairDungeonSectionInfo> dungeonSectionInfoMap_ = new pbc::MapField<uint, global::FleurFairDungeonSectionInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::MapField<uint, global::FleurFairDungeonSectionInfo> DungeonSectionInfoMap {
    get { return dungeonSectionInfoMap_; }
  }

  /// <summary>Field number for the "is_dungeon_unlocked" field.</summary>
  public const int IsDungeonUnlockedFieldNumber = 11;
  private bool isDungeonUnlocked_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsDungeonUnlocked {
    get { return isDungeonUnlocked_; }
    set {
      isDungeonUnlocked_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FleurFairActivityDetailInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FleurFairActivityDetailInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsContentClosed != other.IsContentClosed) return false;
    if (DungeonPunishOverTime != other.DungeonPunishOverTime) return false;
    if (ContentCloseTime != other.ContentCloseTime) return false;
    if (ObtainedToken != other.ObtainedToken) return false;
    if(!chapterInfoList_.Equals(other.chapterInfoList_)) return false;
    if (!MinigameInfoMap.Equals(other.MinigameInfoMap)) return false;
    if (!DungeonSectionInfoMap.Equals(other.DungeonSectionInfoMap)) return false;
    if (IsDungeonUnlocked != other.IsDungeonUnlocked) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
    if (DungeonPunishOverTime != 0) hash ^= DungeonPunishOverTime.GetHashCode();
    if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
    if (ObtainedToken != 0) hash ^= ObtainedToken.GetHashCode();
    hash ^= chapterInfoList_.GetHashCode();
    hash ^= MinigameInfoMap.GetHashCode();
    hash ^= DungeonSectionInfoMap.GetHashCode();
    if (IsDungeonUnlocked != false) hash ^= IsDungeonUnlocked.GetHashCode();
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
    dungeonSectionInfoMap_.WriteTo(output, _map_dungeonSectionInfoMap_codec);
    if (IsContentClosed != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsContentClosed);
    }
    if (DungeonPunishOverTime != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(DungeonPunishOverTime);
    }
    minigameInfoMap_.WriteTo(output, _map_minigameInfoMap_codec);
    if (IsDungeonUnlocked != false) {
      output.WriteRawTag(88);
      output.WriteBool(IsDungeonUnlocked);
    }
    if (ObtainedToken != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ObtainedToken);
    }
    chapterInfoList_.WriteTo(output, _repeated_chapterInfoList_codec);
    if (ContentCloseTime != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ContentCloseTime);
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
    dungeonSectionInfoMap_.WriteTo(ref output, _map_dungeonSectionInfoMap_codec);
    if (IsContentClosed != false) {
      output.WriteRawTag(32);
      output.WriteBool(IsContentClosed);
    }
    if (DungeonPunishOverTime != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(DungeonPunishOverTime);
    }
    minigameInfoMap_.WriteTo(ref output, _map_minigameInfoMap_codec);
    if (IsDungeonUnlocked != false) {
      output.WriteRawTag(88);
      output.WriteBool(IsDungeonUnlocked);
    }
    if (ObtainedToken != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ObtainedToken);
    }
    chapterInfoList_.WriteTo(ref output, _repeated_chapterInfoList_codec);
    if (ContentCloseTime != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(ContentCloseTime);
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
    if (IsContentClosed != false) {
      size += 1 + 1;
    }
    if (DungeonPunishOverTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonPunishOverTime);
    }
    if (ContentCloseTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
    }
    if (ObtainedToken != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ObtainedToken);
    }
    size += chapterInfoList_.CalculateSize(_repeated_chapterInfoList_codec);
    size += minigameInfoMap_.CalculateSize(_map_minigameInfoMap_codec);
    size += dungeonSectionInfoMap_.CalculateSize(_map_dungeonSectionInfoMap_codec);
    if (IsDungeonUnlocked != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FleurFairActivityDetailInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsContentClosed != false) {
      IsContentClosed = other.IsContentClosed;
    }
    if (other.DungeonPunishOverTime != 0) {
      DungeonPunishOverTime = other.DungeonPunishOverTime;
    }
    if (other.ContentCloseTime != 0) {
      ContentCloseTime = other.ContentCloseTime;
    }
    if (other.ObtainedToken != 0) {
      ObtainedToken = other.ObtainedToken;
    }
    chapterInfoList_.Add(other.chapterInfoList_);
    minigameInfoMap_.Add(other.minigameInfoMap_);
    dungeonSectionInfoMap_.Add(other.dungeonSectionInfoMap_);
    if (other.IsDungeonUnlocked != false) {
      IsDungeonUnlocked = other.IsDungeonUnlocked;
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
        case 26: {
          dungeonSectionInfoMap_.AddEntriesFrom(input, _map_dungeonSectionInfoMap_codec);
          break;
        }
        case 32: {
          IsContentClosed = input.ReadBool();
          break;
        }
        case 48: {
          DungeonPunishOverTime = input.ReadUInt32();
          break;
        }
        case 74: {
          minigameInfoMap_.AddEntriesFrom(input, _map_minigameInfoMap_codec);
          break;
        }
        case 88: {
          IsDungeonUnlocked = input.ReadBool();
          break;
        }
        case 104: {
          ObtainedToken = input.ReadUInt32();
          break;
        }
        case 114: {
          chapterInfoList_.AddEntriesFrom(input, _repeated_chapterInfoList_codec);
          break;
        }
        case 120: {
          ContentCloseTime = input.ReadUInt32();
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
        case 26: {
          dungeonSectionInfoMap_.AddEntriesFrom(ref input, _map_dungeonSectionInfoMap_codec);
          break;
        }
        case 32: {
          IsContentClosed = input.ReadBool();
          break;
        }
        case 48: {
          DungeonPunishOverTime = input.ReadUInt32();
          break;
        }
        case 74: {
          minigameInfoMap_.AddEntriesFrom(ref input, _map_minigameInfoMap_codec);
          break;
        }
        case 88: {
          IsDungeonUnlocked = input.ReadBool();
          break;
        }
        case 104: {
          ObtainedToken = input.ReadUInt32();
          break;
        }
        case 114: {
          chapterInfoList_.AddEntriesFrom(ref input, _repeated_chapterInfoList_codec);
          break;
        }
        case 120: {
          ContentCloseTime = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code