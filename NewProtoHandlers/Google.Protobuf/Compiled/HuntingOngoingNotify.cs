// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HuntingOngoingNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HuntingOngoingNotify.proto</summary>
public static partial class HuntingOngoingNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for HuntingOngoingNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HuntingOngoingNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChpIdW50aW5nT25nb2luZ05vdGlmeS5wcm90bxoRSHVudGluZ1BhaXIucHJv",
          "dG8aDFZlY3Rvci5wcm90byKuAQoUSHVudGluZ09uZ29pbmdOb3RpZnkSIgoM",
          "aHVudGluZ19wYWlyGAsgASgLMgwuSHVudGluZ1BhaXISGQoRZmluaXNoX2Ns",
          "dWVfY291bnQYByABKA0SHgoNbmV4dF9wb3NpdGlvbhgCIAEoCzIHLlZlY3Rv",
          "chIQCghpc19maW5hbBgFIAEoCBISCgppc19zdGFydGVkGA0gASgIEhEKCWZh",
          "aWxfdGltZRgEIAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HuntingPairReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HuntingOngoingNotify), global::HuntingOngoingNotify.Parser, new[]{ "HuntingPair", "FinishClueCount", "NextPosition", "IsFinal", "IsStarted", "FailTime" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 4318;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class HuntingOngoingNotify : pb::IMessage<HuntingOngoingNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HuntingOngoingNotify> _parser = new pb::MessageParser<HuntingOngoingNotify>(() => new HuntingOngoingNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HuntingOngoingNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HuntingOngoingNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOngoingNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOngoingNotify(HuntingOngoingNotify other) : this() {
    huntingPair_ = other.huntingPair_ != null ? other.huntingPair_.Clone() : null;
    finishClueCount_ = other.finishClueCount_;
    nextPosition_ = other.nextPosition_ != null ? other.nextPosition_.Clone() : null;
    isFinal_ = other.isFinal_;
    isStarted_ = other.isStarted_;
    failTime_ = other.failTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOngoingNotify Clone() {
    return new HuntingOngoingNotify(this);
  }

  /// <summary>Field number for the "hunting_pair" field.</summary>
  public const int HuntingPairFieldNumber = 11;
  private global::HuntingPair huntingPair_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HuntingPair HuntingPair {
    get { return huntingPair_; }
    set {
      huntingPair_ = value;
    }
  }

  /// <summary>Field number for the "finish_clue_count" field.</summary>
  public const int FinishClueCountFieldNumber = 7;
  private uint finishClueCount_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinishClueCount {
    get { return finishClueCount_; }
    set {
      finishClueCount_ = value;
    }
  }

  /// <summary>Field number for the "next_position" field.</summary>
  public const int NextPositionFieldNumber = 2;
  private global::Vector nextPosition_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector NextPosition {
    get { return nextPosition_; }
    set {
      nextPosition_ = value;
    }
  }

  /// <summary>Field number for the "is_final" field.</summary>
  public const int IsFinalFieldNumber = 5;
  private bool isFinal_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinal {
    get { return isFinal_; }
    set {
      isFinal_ = value;
    }
  }

  /// <summary>Field number for the "is_started" field.</summary>
  public const int IsStartedFieldNumber = 13;
  private bool isStarted_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsStarted {
    get { return isStarted_; }
    set {
      isStarted_ = value;
    }
  }

  /// <summary>Field number for the "fail_time" field.</summary>
  public const int FailTimeFieldNumber = 4;
  private uint failTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FailTime {
    get { return failTime_; }
    set {
      failTime_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HuntingOngoingNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HuntingOngoingNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(HuntingPair, other.HuntingPair)) return false;
    if (FinishClueCount != other.FinishClueCount) return false;
    if (!object.Equals(NextPosition, other.NextPosition)) return false;
    if (IsFinal != other.IsFinal) return false;
    if (IsStarted != other.IsStarted) return false;
    if (FailTime != other.FailTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (huntingPair_ != null) hash ^= HuntingPair.GetHashCode();
    if (FinishClueCount != 0) hash ^= FinishClueCount.GetHashCode();
    if (nextPosition_ != null) hash ^= NextPosition.GetHashCode();
    if (IsFinal != false) hash ^= IsFinal.GetHashCode();
    if (IsStarted != false) hash ^= IsStarted.GetHashCode();
    if (FailTime != 0) hash ^= FailTime.GetHashCode();
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
    if (nextPosition_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(NextPosition);
    }
    if (FailTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(FailTime);
    }
    if (IsFinal != false) {
      output.WriteRawTag(40);
      output.WriteBool(IsFinal);
    }
    if (FinishClueCount != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(FinishClueCount);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(HuntingPair);
    }
    if (IsStarted != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsStarted);
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
    if (nextPosition_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(NextPosition);
    }
    if (FailTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(FailTime);
    }
    if (IsFinal != false) {
      output.WriteRawTag(40);
      output.WriteBool(IsFinal);
    }
    if (FinishClueCount != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(FinishClueCount);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(HuntingPair);
    }
    if (IsStarted != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsStarted);
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
    if (huntingPair_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntingPair);
    }
    if (FinishClueCount != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishClueCount);
    }
    if (nextPosition_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(NextPosition);
    }
    if (IsFinal != false) {
      size += 1 + 1;
    }
    if (IsStarted != false) {
      size += 1 + 1;
    }
    if (FailTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FailTime);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HuntingOngoingNotify other) {
    if (other == null) {
      return;
    }
    if (other.huntingPair_ != null) {
      if (huntingPair_ == null) {
        HuntingPair = new global::HuntingPair();
      }
      HuntingPair.MergeFrom(other.HuntingPair);
    }
    if (other.FinishClueCount != 0) {
      FinishClueCount = other.FinishClueCount;
    }
    if (other.nextPosition_ != null) {
      if (nextPosition_ == null) {
        NextPosition = new global::Vector();
      }
      NextPosition.MergeFrom(other.NextPosition);
    }
    if (other.IsFinal != false) {
      IsFinal = other.IsFinal;
    }
    if (other.IsStarted != false) {
      IsStarted = other.IsStarted;
    }
    if (other.FailTime != 0) {
      FailTime = other.FailTime;
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
        case 18: {
          if (nextPosition_ == null) {
            NextPosition = new global::Vector();
          }
          input.ReadMessage(NextPosition);
          break;
        }
        case 32: {
          FailTime = input.ReadUInt32();
          break;
        }
        case 40: {
          IsFinal = input.ReadBool();
          break;
        }
        case 56: {
          FinishClueCount = input.ReadUInt32();
          break;
        }
        case 90: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
          break;
        }
        case 104: {
          IsStarted = input.ReadBool();
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
        case 18: {
          if (nextPosition_ == null) {
            NextPosition = new global::Vector();
          }
          input.ReadMessage(NextPosition);
          break;
        }
        case 32: {
          FailTime = input.ReadUInt32();
          break;
        }
        case 40: {
          IsFinal = input.ReadBool();
          break;
        }
        case 56: {
          FinishClueCount = input.ReadUInt32();
          break;
        }
        case 90: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
          break;
        }
        case 104: {
          IsStarted = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
