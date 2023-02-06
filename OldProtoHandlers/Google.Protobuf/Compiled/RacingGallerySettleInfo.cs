// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RacingGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RacingGallerySettleInfo.proto</summary>
public static partial class RacingGallerySettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for RacingGallerySettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RacingGallerySettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1SYWNpbmdHYWxsZXJ5U2V0dGxlSW5mby5wcm90bxoXR2FsbGVyeVN0b3BS",
          "ZWFzb24ucHJvdG8iYwoXUmFjaW5nR2FsbGVyeVNldHRsZUluZm8SEgoKd2lu",
          "bmVyX3VpZBgGIAEoDRIiCgZyZWFzb24YBCABKA4yEi5HYWxsZXJ5U3RvcFJl",
          "YXNvbhIQCgh1c2VfdGltZRgBIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0",
          "Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GalleryStopReasonReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RacingGallerySettleInfo), global::RacingGallerySettleInfo.Parser, new[]{ "WinnerUid", "Reason", "UseTime" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RacingGallerySettleInfo : pb::IMessage<RacingGallerySettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RacingGallerySettleInfo> _parser = new pb::MessageParser<RacingGallerySettleInfo>(() => new RacingGallerySettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RacingGallerySettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RacingGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RacingGallerySettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RacingGallerySettleInfo(RacingGallerySettleInfo other) : this() {
    winnerUid_ = other.winnerUid_;
    reason_ = other.reason_;
    useTime_ = other.useTime_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RacingGallerySettleInfo Clone() {
    return new RacingGallerySettleInfo(this);
  }

  /// <summary>Field number for the "winner_uid" field.</summary>
  public const int WinnerUidFieldNumber = 6;
  private uint winnerUid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WinnerUid {
    get { return winnerUid_; }
    set {
      winnerUid_ = value;
    }
  }

  /// <summary>Field number for the "reason" field.</summary>
  public const int ReasonFieldNumber = 4;
  private global::GalleryStopReason reason_ = global::GalleryStopReason.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GalleryStopReason Reason {
    get { return reason_; }
    set {
      reason_ = value;
    }
  }

  /// <summary>Field number for the "use_time" field.</summary>
  public const int UseTimeFieldNumber = 1;
  private uint useTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint UseTime {
    get { return useTime_; }
    set {
      useTime_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RacingGallerySettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RacingGallerySettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (WinnerUid != other.WinnerUid) return false;
    if (Reason != other.Reason) return false;
    if (UseTime != other.UseTime) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (WinnerUid != 0) hash ^= WinnerUid.GetHashCode();
    if (Reason != global::GalleryStopReason.None) hash ^= Reason.GetHashCode();
    if (UseTime != 0) hash ^= UseTime.GetHashCode();
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
    if (UseTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(UseTime);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (WinnerUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(WinnerUid);
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
    if (UseTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(UseTime);
    }
    if (Reason != global::GalleryStopReason.None) {
      output.WriteRawTag(32);
      output.WriteEnum((int) Reason);
    }
    if (WinnerUid != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(WinnerUid);
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
    if (WinnerUid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WinnerUid);
    }
    if (Reason != global::GalleryStopReason.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
    }
    if (UseTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseTime);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RacingGallerySettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.WinnerUid != 0) {
      WinnerUid = other.WinnerUid;
    }
    if (other.Reason != global::GalleryStopReason.None) {
      Reason = other.Reason;
    }
    if (other.UseTime != 0) {
      UseTime = other.UseTime;
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
        case 8: {
          UseTime = input.ReadUInt32();
          break;
        }
        case 32: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
          break;
        }
        case 48: {
          WinnerUid = input.ReadUInt32();
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
        case 8: {
          UseTime = input.ReadUInt32();
          break;
        }
        case 32: {
          Reason = (global::GalleryStopReason) input.ReadEnum();
          break;
        }
        case 48: {
          WinnerUid = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code