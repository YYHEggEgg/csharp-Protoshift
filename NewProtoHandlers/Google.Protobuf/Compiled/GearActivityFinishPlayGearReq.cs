// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GearActivityFinishPlayGearReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GearActivityFinishPlayGearReq.proto</summary>
public static partial class GearActivityFinishPlayGearReqReflection {

  #region Descriptor
  /// <summary>File descriptor for GearActivityFinishPlayGearReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GearActivityFinishPlayGearReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNHZWFyQWN0aXZpdHlGaW5pc2hQbGF5R2VhclJlcS5wcm90bxoUR2VhckNv",
          "bHVtbkluZm8ucHJvdG8ihwEKHUdlYXJBY3Rpdml0eUZpbmlzaFBsYXlHZWFy",
          "UmVxEhAKCHVzZV9jbHVlGAogASgIEhAKCGxldmVsX2lkGAMgASgNEhIKCmlz",
          "X3N1Y2Nlc3MYCCABKAgSLgoVZ2Vhcl9jb2x1bW5faW5mb19saXN0GAwgAygL",
          "Mg8uR2VhckNvbHVtbkluZm9CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GearColumnInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GearActivityFinishPlayGearReq), global::GearActivityFinishPlayGearReq.Parser, new[]{ "UseClue", "LevelId", "IsSuccess", "GearColumnInfoList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 20236;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
///   IS_ALLOW_CLIENT = 1;
/// }
/// </summary>
public sealed partial class GearActivityFinishPlayGearReq : pb::IMessage<GearActivityFinishPlayGearReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GearActivityFinishPlayGearReq> _parser = new pb::MessageParser<GearActivityFinishPlayGearReq>(() => new GearActivityFinishPlayGearReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GearActivityFinishPlayGearReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GearActivityFinishPlayGearReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GearActivityFinishPlayGearReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GearActivityFinishPlayGearReq(GearActivityFinishPlayGearReq other) : this() {
    useClue_ = other.useClue_;
    levelId_ = other.levelId_;
    isSuccess_ = other.isSuccess_;
    gearColumnInfoList_ = other.gearColumnInfoList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GearActivityFinishPlayGearReq Clone() {
    return new GearActivityFinishPlayGearReq(this);
  }

  /// <summary>Field number for the "use_clue" field.</summary>
  public const int UseClueFieldNumber = 10;
  private bool useClue_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool UseClue {
    get { return useClue_; }
    set {
      useClue_ = value;
    }
  }

  /// <summary>Field number for the "level_id" field.</summary>
  public const int LevelIdFieldNumber = 3;
  private uint levelId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint LevelId {
    get { return levelId_; }
    set {
      levelId_ = value;
    }
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 8;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "gear_column_info_list" field.</summary>
  public const int GearColumnInfoListFieldNumber = 12;
  private static readonly pb::FieldCodec<global::GearColumnInfo> _repeated_gearColumnInfoList_codec
      = pb::FieldCodec.ForMessage(98, global::GearColumnInfo.Parser);
  private readonly pbc::RepeatedField<global::GearColumnInfo> gearColumnInfoList_ = new pbc::RepeatedField<global::GearColumnInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GearColumnInfo> GearColumnInfoList {
    get { return gearColumnInfoList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GearActivityFinishPlayGearReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GearActivityFinishPlayGearReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UseClue != other.UseClue) return false;
    if (LevelId != other.LevelId) return false;
    if (IsSuccess != other.IsSuccess) return false;
    if(!gearColumnInfoList_.Equals(other.gearColumnInfoList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (UseClue != false) hash ^= UseClue.GetHashCode();
    if (LevelId != 0) hash ^= LevelId.GetHashCode();
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    hash ^= gearColumnInfoList_.GetHashCode();
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
    if (LevelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LevelId);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsSuccess);
    }
    if (UseClue != false) {
      output.WriteRawTag(80);
      output.WriteBool(UseClue);
    }
    gearColumnInfoList_.WriteTo(output, _repeated_gearColumnInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (LevelId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(LevelId);
    }
    if (IsSuccess != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsSuccess);
    }
    if (UseClue != false) {
      output.WriteRawTag(80);
      output.WriteBool(UseClue);
    }
    gearColumnInfoList_.WriteTo(ref output, _repeated_gearColumnInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (UseClue != false) {
      size += 1 + 1;
    }
    if (LevelId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
    }
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    size += gearColumnInfoList_.CalculateSize(_repeated_gearColumnInfoList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GearActivityFinishPlayGearReq other) {
    if (other == null) {
      return;
    }
    if (other.UseClue != false) {
      UseClue = other.UseClue;
    }
    if (other.LevelId != 0) {
      LevelId = other.LevelId;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    gearColumnInfoList_.Add(other.gearColumnInfoList_);
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
          LevelId = input.ReadUInt32();
          break;
        }
        case 64: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          UseClue = input.ReadBool();
          break;
        }
        case 98: {
          gearColumnInfoList_.AddEntriesFrom(input, _repeated_gearColumnInfoList_codec);
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
          LevelId = input.ReadUInt32();
          break;
        }
        case 64: {
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          UseClue = input.ReadBool();
          break;
        }
        case 98: {
          gearColumnInfoList_.AddEntriesFrom(ref input, _repeated_gearColumnInfoList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
