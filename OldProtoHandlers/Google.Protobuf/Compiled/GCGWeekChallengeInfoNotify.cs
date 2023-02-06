// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGWeekChallengeInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGWeekChallengeInfoNotify.proto</summary>
public static partial class GCGWeekChallengeInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGWeekChallengeInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGWeekChallengeInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBHQ0dXZWVrQ2hhbGxlbmdlSW5mb05vdGlmeS5wcm90bxoaR0NHV2Vla0No",
          "YWxsZW5nZUluZm8ucHJvdG8iiQEKGkdDR1dlZWtDaGFsbGVuZ2VJbmZvTm90",
          "aWZ5EjIKE2NoYWxsZW5nZV9pbmZvX2xpc3QYDyADKAsyFS5HQ0dXZWVrQ2hh",
          "bGxlbmdlSW5mbxIZChFuZXh0X3JlZnJlc2hfdGltZRgHIAEoDRIcChRpc19u",
          "b3RpZnlfbnBjX2NoYW5nZRgJIAEoCEIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0",
          "Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGWeekChallengeInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGWeekChallengeInfoNotify), global::GCGWeekChallengeInfoNotify.Parser, new[]{ "ChallengeInfoList", "NextRefreshTime", "IsNotifyNpcChange" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGWeekChallengeInfoNotify : pb::IMessage<GCGWeekChallengeInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGWeekChallengeInfoNotify> _parser = new pb::MessageParser<GCGWeekChallengeInfoNotify>(() => new GCGWeekChallengeInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGWeekChallengeInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGWeekChallengeInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGWeekChallengeInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGWeekChallengeInfoNotify(GCGWeekChallengeInfoNotify other) : this() {
    challengeInfoList_ = other.challengeInfoList_.Clone();
    nextRefreshTime_ = other.nextRefreshTime_;
    isNotifyNpcChange_ = other.isNotifyNpcChange_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGWeekChallengeInfoNotify Clone() {
    return new GCGWeekChallengeInfoNotify(this);
  }

  /// <summary>Field number for the "challenge_info_list" field.</summary>
  public const int ChallengeInfoListFieldNumber = 15;
  private static readonly pb::FieldCodec<global::GCGWeekChallengeInfo> _repeated_challengeInfoList_codec
      = pb::FieldCodec.ForMessage(122, global::GCGWeekChallengeInfo.Parser);
  private readonly pbc::RepeatedField<global::GCGWeekChallengeInfo> challengeInfoList_ = new pbc::RepeatedField<global::GCGWeekChallengeInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGWeekChallengeInfo> ChallengeInfoList {
    get { return challengeInfoList_; }
  }

  /// <summary>Field number for the "next_refresh_time" field.</summary>
  public const int NextRefreshTimeFieldNumber = 7;
  private uint nextRefreshTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint NextRefreshTime {
    get { return nextRefreshTime_; }
    set {
      nextRefreshTime_ = value;
    }
  }

  /// <summary>Field number for the "is_notify_npc_change" field.</summary>
  public const int IsNotifyNpcChangeFieldNumber = 9;
  private bool isNotifyNpcChange_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNotifyNpcChange {
    get { return isNotifyNpcChange_; }
    set {
      isNotifyNpcChange_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGWeekChallengeInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGWeekChallengeInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!challengeInfoList_.Equals(other.challengeInfoList_)) return false;
    if (NextRefreshTime != other.NextRefreshTime) return false;
    if (IsNotifyNpcChange != other.IsNotifyNpcChange) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= challengeInfoList_.GetHashCode();
    if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
    if (IsNotifyNpcChange != false) hash ^= IsNotifyNpcChange.GetHashCode();
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
    if (NextRefreshTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(NextRefreshTime);
    }
    if (IsNotifyNpcChange != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsNotifyNpcChange);
    }
    challengeInfoList_.WriteTo(output, _repeated_challengeInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (NextRefreshTime != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(NextRefreshTime);
    }
    if (IsNotifyNpcChange != false) {
      output.WriteRawTag(72);
      output.WriteBool(IsNotifyNpcChange);
    }
    challengeInfoList_.WriteTo(ref output, _repeated_challengeInfoList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += challengeInfoList_.CalculateSize(_repeated_challengeInfoList_codec);
    if (NextRefreshTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
    }
    if (IsNotifyNpcChange != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGWeekChallengeInfoNotify other) {
    if (other == null) {
      return;
    }
    challengeInfoList_.Add(other.challengeInfoList_);
    if (other.NextRefreshTime != 0) {
      NextRefreshTime = other.NextRefreshTime;
    }
    if (other.IsNotifyNpcChange != false) {
      IsNotifyNpcChange = other.IsNotifyNpcChange;
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
        case 56: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 72: {
          IsNotifyNpcChange = input.ReadBool();
          break;
        }
        case 122: {
          challengeInfoList_.AddEntriesFrom(input, _repeated_challengeInfoList_codec);
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
        case 56: {
          NextRefreshTime = input.ReadUInt32();
          break;
        }
        case 72: {
          IsNotifyNpcChange = input.ReadBool();
          break;
        }
        case 122: {
          challengeInfoList_.AddEntriesFrom(ref input, _repeated_challengeInfoList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
