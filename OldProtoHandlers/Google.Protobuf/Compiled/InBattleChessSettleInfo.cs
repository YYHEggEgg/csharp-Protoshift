// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InBattleChessSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from InBattleChessSettleInfo.proto</summary>
public static partial class InBattleChessSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for InBattleChessSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static InBattleChessSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1JbkJhdHRsZUNoZXNzU2V0dGxlSW5mby5wcm90bxobRXhoaWJpdGlvbkRp",
          "c3BsYXlJbmZvLnByb3RvIsgBChdJbkJhdHRsZUNoZXNzU2V0dGxlSW5mbxIS",
          "Cgppc19zdWNjZXNzGAcgASgIEhEKCWNoZXNzX2V4cBgLIAEoDRITCgtjaGVz",
          "c19sZXZlbBgNIAEoDRIXCg9vbGRfY2hlc3NfbGV2ZWwYCiABKA0SKgoKc2Nv",
          "cmVfbGlzdBgBIAMoCzIWLkV4aGliaXRpb25EaXNwbGF5SW5mbxIVCg1zY2Vu",
          "ZV90aW1lX21zGA4gASgEEhUKDW9sZF9jaGVzc19leHAYAiABKA1CHgocZW11",
          "LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ExhibitionDisplayInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::InBattleChessSettleInfo), global::InBattleChessSettleInfo.Parser, new[]{ "IsSuccess", "ChessExp", "ChessLevel", "OldChessLevel", "ScoreList", "SceneTimeMs", "OldChessExp" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class InBattleChessSettleInfo : pb::IMessage<InBattleChessSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<InBattleChessSettleInfo> _parser = new pb::MessageParser<InBattleChessSettleInfo>(() => new InBattleChessSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<InBattleChessSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::InBattleChessSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleChessSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleChessSettleInfo(InBattleChessSettleInfo other) : this() {
    isSuccess_ = other.isSuccess_;
    chessExp_ = other.chessExp_;
    chessLevel_ = other.chessLevel_;
    oldChessLevel_ = other.oldChessLevel_;
    scoreList_ = other.scoreList_.Clone();
    sceneTimeMs_ = other.sceneTimeMs_;
    oldChessExp_ = other.oldChessExp_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public InBattleChessSettleInfo Clone() {
    return new InBattleChessSettleInfo(this);
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 7;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "chess_exp" field.</summary>
  public const int ChessExpFieldNumber = 11;
  private uint chessExp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChessExp {
    get { return chessExp_; }
    set {
      chessExp_ = value;
    }
  }

  /// <summary>Field number for the "chess_level" field.</summary>
  public const int ChessLevelFieldNumber = 13;
  private uint chessLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ChessLevel {
    get { return chessLevel_; }
    set {
      chessLevel_ = value;
    }
  }

  /// <summary>Field number for the "old_chess_level" field.</summary>
  public const int OldChessLevelFieldNumber = 10;
  private uint oldChessLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OldChessLevel {
    get { return oldChessLevel_; }
    set {
      oldChessLevel_ = value;
    }
  }

  /// <summary>Field number for the "score_list" field.</summary>
  public const int ScoreListFieldNumber = 1;
  private static readonly pb::FieldCodec<global::ExhibitionDisplayInfo> _repeated_scoreList_codec
      = pb::FieldCodec.ForMessage(10, global::ExhibitionDisplayInfo.Parser);
  private readonly pbc::RepeatedField<global::ExhibitionDisplayInfo> scoreList_ = new pbc::RepeatedField<global::ExhibitionDisplayInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::ExhibitionDisplayInfo> ScoreList {
    get { return scoreList_; }
  }

  /// <summary>Field number for the "scene_time_ms" field.</summary>
  public const int SceneTimeMsFieldNumber = 14;
  private ulong sceneTimeMs_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ulong SceneTimeMs {
    get { return sceneTimeMs_; }
    set {
      sceneTimeMs_ = value;
    }
  }

  /// <summary>Field number for the "old_chess_exp" field.</summary>
  public const int OldChessExpFieldNumber = 2;
  private uint oldChessExp_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OldChessExp {
    get { return oldChessExp_; }
    set {
      oldChessExp_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as InBattleChessSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(InBattleChessSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsSuccess != other.IsSuccess) return false;
    if (ChessExp != other.ChessExp) return false;
    if (ChessLevel != other.ChessLevel) return false;
    if (OldChessLevel != other.OldChessLevel) return false;
    if(!scoreList_.Equals(other.scoreList_)) return false;
    if (SceneTimeMs != other.SceneTimeMs) return false;
    if (OldChessExp != other.OldChessExp) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (ChessExp != 0) hash ^= ChessExp.GetHashCode();
    if (ChessLevel != 0) hash ^= ChessLevel.GetHashCode();
    if (OldChessLevel != 0) hash ^= OldChessLevel.GetHashCode();
    hash ^= scoreList_.GetHashCode();
    if (SceneTimeMs != 0UL) hash ^= SceneTimeMs.GetHashCode();
    if (OldChessExp != 0) hash ^= OldChessExp.GetHashCode();
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
    scoreList_.WriteTo(output, _repeated_scoreList_codec);
    if (OldChessExp != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(OldChessExp);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsSuccess);
    }
    if (OldChessLevel != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(OldChessLevel);
    }
    if (ChessExp != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ChessExp);
    }
    if (ChessLevel != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ChessLevel);
    }
    if (SceneTimeMs != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(SceneTimeMs);
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
    scoreList_.WriteTo(ref output, _repeated_scoreList_codec);
    if (OldChessExp != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(OldChessExp);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsSuccess);
    }
    if (OldChessLevel != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(OldChessLevel);
    }
    if (ChessExp != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(ChessExp);
    }
    if (ChessLevel != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(ChessLevel);
    }
    if (SceneTimeMs != 0UL) {
      output.WriteRawTag(112);
      output.WriteUInt64(SceneTimeMs);
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
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (ChessExp != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessExp);
    }
    if (ChessLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChessLevel);
    }
    if (OldChessLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldChessLevel);
    }
    size += scoreList_.CalculateSize(_repeated_scoreList_codec);
    if (SceneTimeMs != 0UL) {
      size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SceneTimeMs);
    }
    if (OldChessExp != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldChessExp);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(InBattleChessSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.ChessExp != 0) {
      ChessExp = other.ChessExp;
    }
    if (other.ChessLevel != 0) {
      ChessLevel = other.ChessLevel;
    }
    if (other.OldChessLevel != 0) {
      OldChessLevel = other.OldChessLevel;
    }
    scoreList_.Add(other.scoreList_);
    if (other.SceneTimeMs != 0UL) {
      SceneTimeMs = other.SceneTimeMs;
    }
    if (other.OldChessExp != 0) {
      OldChessExp = other.OldChessExp;
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
          scoreList_.AddEntriesFrom(input, _repeated_scoreList_codec);
          break;
        }
        case 16: {
          OldChessExp = input.ReadUInt32();
          break;
        }
        case 56: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          OldChessLevel = input.ReadUInt32();
          break;
        }
        case 88: {
          ChessExp = input.ReadUInt32();
          break;
        }
        case 104: {
          ChessLevel = input.ReadUInt32();
          break;
        }
        case 112: {
          SceneTimeMs = input.ReadUInt64();
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
          scoreList_.AddEntriesFrom(ref input, _repeated_scoreList_codec);
          break;
        }
        case 16: {
          OldChessExp = input.ReadUInt32();
          break;
        }
        case 56: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          OldChessLevel = input.ReadUInt32();
          break;
        }
        case 88: {
          ChessExp = input.ReadUInt32();
          break;
        }
        case 104: {
          ChessLevel = input.ReadUInt32();
          break;
        }
        case 112: {
          SceneTimeMs = input.ReadUInt64();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code