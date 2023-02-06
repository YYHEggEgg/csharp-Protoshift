// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CharAmusementSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CharAmusementSettleNotify.proto</summary>
public static partial class CharAmusementSettleNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for CharAmusementSettleNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CharAmusementSettleNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9DaGFyQW11c2VtZW50U2V0dGxlTm90aWZ5LnByb3RvIlgKGUNoYXJBbXVz",
          "ZW1lbnRTZXR0bGVOb3RpZnkSFQoNaXNfbmV3X3JlY29yZBgKIAEoCBITCgtm",
          "aW5pc2hfdGltZRgCIAEoDRIPCgdpc19zdWNjGAwgASgIQhYKFG9yZy5zb3Jh",
          "cG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CharAmusementSettleNotify), global::CharAmusementSettleNotify.Parser, new[]{ "IsNewRecord", "FinishTime", "IsSucc" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 23128;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class CharAmusementSettleNotify : pb::IMessage<CharAmusementSettleNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CharAmusementSettleNotify> _parser = new pb::MessageParser<CharAmusementSettleNotify>(() => new CharAmusementSettleNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CharAmusementSettleNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CharAmusementSettleNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CharAmusementSettleNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CharAmusementSettleNotify(CharAmusementSettleNotify other) : this() {
    isNewRecord_ = other.isNewRecord_;
    finishTime_ = other.finishTime_;
    isSucc_ = other.isSucc_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CharAmusementSettleNotify Clone() {
    return new CharAmusementSettleNotify(this);
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 10;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "finish_time" field.</summary>
  public const int FinishTimeFieldNumber = 2;
  private uint finishTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FinishTime {
    get { return finishTime_; }
    set {
      finishTime_ = value;
    }
  }

  /// <summary>Field number for the "is_succ" field.</summary>
  public const int IsSuccFieldNumber = 12;
  private bool isSucc_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSucc {
    get { return isSucc_; }
    set {
      isSucc_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CharAmusementSettleNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CharAmusementSettleNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsNewRecord != other.IsNewRecord) return false;
    if (FinishTime != other.FinishTime) return false;
    if (IsSucc != other.IsSucc) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (FinishTime != 0) hash ^= FinishTime.GetHashCode();
    if (IsSucc != false) hash ^= IsSucc.GetHashCode();
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
    if (FinishTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FinishTime);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsNewRecord);
    }
    if (IsSucc != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsSucc);
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
    if (FinishTime != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FinishTime);
    }
    if (IsNewRecord != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsNewRecord);
    }
    if (IsSucc != false) {
      output.WriteRawTag(96);
      output.WriteBool(IsSucc);
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
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (FinishTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTime);
    }
    if (IsSucc != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CharAmusementSettleNotify other) {
    if (other == null) {
      return;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.FinishTime != 0) {
      FinishTime = other.FinishTime;
    }
    if (other.IsSucc != false) {
      IsSucc = other.IsSucc;
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
        case 16: {
          FinishTime = input.ReadUInt32();
          break;
        }
        case 80: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 96: {
          IsSucc = input.ReadBool();
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
        case 16: {
          FinishTime = input.ReadUInt32();
          break;
        }
        case 80: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 96: {
          IsSucc = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
