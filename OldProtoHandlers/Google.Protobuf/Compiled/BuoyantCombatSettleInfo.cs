// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BuoyantCombatSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BuoyantCombatSettleInfo.proto</summary>
public static partial class BuoyantCombatSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for BuoyantCombatSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BuoyantCombatSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch1CdW95YW50Q29tYmF0U2V0dGxlSW5mby5wcm90bxokQnVveWFudENvbWJh",
          "dEdhbGxlcnlTZXR0bGVJbmZvLnByb3RvImYKF0J1b3lhbnRDb21iYXRTZXR0",
          "bGVJbmZvEhUKDWlzX25ld19yZWNvcmQYASABKAgSNAoLc2V0dGxlX2luZm8Y",
          "AyABKAsyHy5CdW95YW50Q29tYmF0R2FsbGVyeVNldHRsZUluZm9CHgocZW11",
          "LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BuoyantCombatGallerySettleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BuoyantCombatSettleInfo), global::BuoyantCombatSettleInfo.Parser, new[]{ "IsNewRecord", "SettleInfo" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class BuoyantCombatSettleInfo : pb::IMessage<BuoyantCombatSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BuoyantCombatSettleInfo> _parser = new pb::MessageParser<BuoyantCombatSettleInfo>(() => new BuoyantCombatSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BuoyantCombatSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BuoyantCombatSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuoyantCombatSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuoyantCombatSettleInfo(BuoyantCombatSettleInfo other) : this() {
    isNewRecord_ = other.isNewRecord_;
    settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BuoyantCombatSettleInfo Clone() {
    return new BuoyantCombatSettleInfo(this);
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 1;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  /// <summary>Field number for the "settle_info" field.</summary>
  public const int SettleInfoFieldNumber = 3;
  private global::BuoyantCombatGallerySettleInfo settleInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BuoyantCombatGallerySettleInfo SettleInfo {
    get { return settleInfo_; }
    set {
      settleInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BuoyantCombatSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BuoyantCombatSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsNewRecord != other.IsNewRecord) return false;
    if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
    if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
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
      output.WriteRawTag(8);
      output.WriteBool(IsNewRecord);
    }
    if (settleInfo_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(SettleInfo);
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
    if (IsNewRecord != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsNewRecord);
    }
    if (settleInfo_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(SettleInfo);
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
    if (settleInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BuoyantCombatSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
    }
    if (other.settleInfo_ != null) {
      if (settleInfo_ == null) {
        SettleInfo = new global::BuoyantCombatGallerySettleInfo();
      }
      SettleInfo.MergeFrom(other.SettleInfo);
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
          IsNewRecord = input.ReadBool();
          break;
        }
        case 26: {
          if (settleInfo_ == null) {
            SettleInfo = new global::BuoyantCombatGallerySettleInfo();
          }
          input.ReadMessage(SettleInfo);
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
          IsNewRecord = input.ReadBool();
          break;
        }
        case 26: {
          if (settleInfo_ == null) {
            SettleInfo = new global::BuoyantCombatGallerySettleInfo();
          }
          input.ReadMessage(SettleInfo);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
