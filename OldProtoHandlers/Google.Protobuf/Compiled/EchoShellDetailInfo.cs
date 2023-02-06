// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EchoShellDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EchoShellDetailInfo.proto</summary>
public static partial class EchoShellDetailInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for EchoShellDetailInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EchoShellDetailInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlFY2hvU2hlbGxEZXRhaWxJbmZvLnByb3RvGhtTdW1tZXJUaW1lRHVuZ2Vv",
          "bkluZm8ucHJvdG8imQEKE0VjaG9TaGVsbERldGFpbEluZm8SOAoYc3VtbWVy",
          "X3RpbWVfZHVuZ2Vvbl9saXN0GAggAygLMhYuU3VtbWVyVGltZUR1bmdlb25J",
          "bmZvEhIKCnNoZWxsX2xpc3QYDSADKA0SGQoRcGFzc19kdW5nZW9uX2xpc3QY",
          "BCADKA0SGQoRdGFrZW5fcmV3YXJkX2xpc3QYAiADKA1CHgocZW11LmdyYXNz",
          "Y3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SummerTimeDungeonInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EchoShellDetailInfo), global::EchoShellDetailInfo.Parser, new[]{ "SummerTimeDungeonList", "ShellList", "PassDungeonList", "TakenRewardList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EchoShellDetailInfo : pb::IMessage<EchoShellDetailInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EchoShellDetailInfo> _parser = new pb::MessageParser<EchoShellDetailInfo>(() => new EchoShellDetailInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EchoShellDetailInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EchoShellDetailInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EchoShellDetailInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EchoShellDetailInfo(EchoShellDetailInfo other) : this() {
    summerTimeDungeonList_ = other.summerTimeDungeonList_.Clone();
    shellList_ = other.shellList_.Clone();
    passDungeonList_ = other.passDungeonList_.Clone();
    takenRewardList_ = other.takenRewardList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EchoShellDetailInfo Clone() {
    return new EchoShellDetailInfo(this);
  }

  /// <summary>Field number for the "summer_time_dungeon_list" field.</summary>
  public const int SummerTimeDungeonListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::SummerTimeDungeonInfo> _repeated_summerTimeDungeonList_codec
      = pb::FieldCodec.ForMessage(66, global::SummerTimeDungeonInfo.Parser);
  private readonly pbc::RepeatedField<global::SummerTimeDungeonInfo> summerTimeDungeonList_ = new pbc::RepeatedField<global::SummerTimeDungeonInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SummerTimeDungeonInfo> SummerTimeDungeonList {
    get { return summerTimeDungeonList_; }
  }

  /// <summary>Field number for the "shell_list" field.</summary>
  public const int ShellListFieldNumber = 13;
  private static readonly pb::FieldCodec<uint> _repeated_shellList_codec
      = pb::FieldCodec.ForUInt32(106);
  private readonly pbc::RepeatedField<uint> shellList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ShellList {
    get { return shellList_; }
  }

  /// <summary>Field number for the "pass_dungeon_list" field.</summary>
  public const int PassDungeonListFieldNumber = 4;
  private static readonly pb::FieldCodec<uint> _repeated_passDungeonList_codec
      = pb::FieldCodec.ForUInt32(34);
  private readonly pbc::RepeatedField<uint> passDungeonList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> PassDungeonList {
    get { return passDungeonList_; }
  }

  /// <summary>Field number for the "taken_reward_list" field.</summary>
  public const int TakenRewardListFieldNumber = 2;
  private static readonly pb::FieldCodec<uint> _repeated_takenRewardList_codec
      = pb::FieldCodec.ForUInt32(18);
  private readonly pbc::RepeatedField<uint> takenRewardList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> TakenRewardList {
    get { return takenRewardList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EchoShellDetailInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EchoShellDetailInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!summerTimeDungeonList_.Equals(other.summerTimeDungeonList_)) return false;
    if(!shellList_.Equals(other.shellList_)) return false;
    if(!passDungeonList_.Equals(other.passDungeonList_)) return false;
    if(!takenRewardList_.Equals(other.takenRewardList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= summerTimeDungeonList_.GetHashCode();
    hash ^= shellList_.GetHashCode();
    hash ^= passDungeonList_.GetHashCode();
    hash ^= takenRewardList_.GetHashCode();
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
    takenRewardList_.WriteTo(output, _repeated_takenRewardList_codec);
    passDungeonList_.WriteTo(output, _repeated_passDungeonList_codec);
    summerTimeDungeonList_.WriteTo(output, _repeated_summerTimeDungeonList_codec);
    shellList_.WriteTo(output, _repeated_shellList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    takenRewardList_.WriteTo(ref output, _repeated_takenRewardList_codec);
    passDungeonList_.WriteTo(ref output, _repeated_passDungeonList_codec);
    summerTimeDungeonList_.WriteTo(ref output, _repeated_summerTimeDungeonList_codec);
    shellList_.WriteTo(ref output, _repeated_shellList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += summerTimeDungeonList_.CalculateSize(_repeated_summerTimeDungeonList_codec);
    size += shellList_.CalculateSize(_repeated_shellList_codec);
    size += passDungeonList_.CalculateSize(_repeated_passDungeonList_codec);
    size += takenRewardList_.CalculateSize(_repeated_takenRewardList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EchoShellDetailInfo other) {
    if (other == null) {
      return;
    }
    summerTimeDungeonList_.Add(other.summerTimeDungeonList_);
    shellList_.Add(other.shellList_);
    passDungeonList_.Add(other.passDungeonList_);
    takenRewardList_.Add(other.takenRewardList_);
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
        case 18:
        case 16: {
          takenRewardList_.AddEntriesFrom(input, _repeated_takenRewardList_codec);
          break;
        }
        case 34:
        case 32: {
          passDungeonList_.AddEntriesFrom(input, _repeated_passDungeonList_codec);
          break;
        }
        case 66: {
          summerTimeDungeonList_.AddEntriesFrom(input, _repeated_summerTimeDungeonList_codec);
          break;
        }
        case 106:
        case 104: {
          shellList_.AddEntriesFrom(input, _repeated_shellList_codec);
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
        case 18:
        case 16: {
          takenRewardList_.AddEntriesFrom(ref input, _repeated_takenRewardList_codec);
          break;
        }
        case 34:
        case 32: {
          passDungeonList_.AddEntriesFrom(ref input, _repeated_passDungeonList_codec);
          break;
        }
        case 66: {
          summerTimeDungeonList_.AddEntriesFrom(ref input, _repeated_summerTimeDungeonList_codec);
          break;
        }
        case 106:
        case 104: {
          shellList_.AddEntriesFrom(ref input, _repeated_shellList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
