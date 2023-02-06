// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairBalloonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FleurFairBalloonSettleInfo.proto</summary>
public static partial class FleurFairBalloonSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for FleurFairBalloonSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FleurFairBalloonSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBGbGV1ckZhaXJCYWxsb29uU2V0dGxlSW5mby5wcm90bxoXQmFsbG9vblNl",
          "dHRsZUluZm8ucHJvdG8iXAoaRmxldXJGYWlyQmFsbG9vblNldHRsZUluZm8S",
          "JwoLc2V0dGxlX2luZm8YCiABKAsyEi5CYWxsb29uU2V0dGxlSW5mbxIVCg1p",
          "c19uZXdfcmVjb3JkGAcgASgIQh4KHGVtdS5ncmFzc2N1dHRlci5uZXQub2xk",
          "cHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BalloonSettleInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FleurFairBalloonSettleInfo), global::FleurFairBalloonSettleInfo.Parser, new[]{ "SettleInfo", "IsNewRecord" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class FleurFairBalloonSettleInfo : pb::IMessage<FleurFairBalloonSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FleurFairBalloonSettleInfo> _parser = new pb::MessageParser<FleurFairBalloonSettleInfo>(() => new FleurFairBalloonSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FleurFairBalloonSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FleurFairBalloonSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairBalloonSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairBalloonSettleInfo(FleurFairBalloonSettleInfo other) : this() {
    settleInfo_ = other.settleInfo_ != null ? other.settleInfo_.Clone() : null;
    isNewRecord_ = other.isNewRecord_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FleurFairBalloonSettleInfo Clone() {
    return new FleurFairBalloonSettleInfo(this);
  }

  /// <summary>Field number for the "settle_info" field.</summary>
  public const int SettleInfoFieldNumber = 10;
  private global::BalloonSettleInfo settleInfo_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BalloonSettleInfo SettleInfo {
    get { return settleInfo_; }
    set {
      settleInfo_ = value;
    }
  }

  /// <summary>Field number for the "is_new_record" field.</summary>
  public const int IsNewRecordFieldNumber = 7;
  private bool isNewRecord_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsNewRecord {
    get { return isNewRecord_; }
    set {
      isNewRecord_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FleurFairBalloonSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FleurFairBalloonSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(SettleInfo, other.SettleInfo)) return false;
    if (IsNewRecord != other.IsNewRecord) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (settleInfo_ != null) hash ^= SettleInfo.GetHashCode();
    if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
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
      output.WriteRawTag(56);
      output.WriteBool(IsNewRecord);
    }
    if (settleInfo_ != null) {
      output.WriteRawTag(82);
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
      output.WriteRawTag(56);
      output.WriteBool(IsNewRecord);
    }
    if (settleInfo_ != null) {
      output.WriteRawTag(82);
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
    if (settleInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SettleInfo);
    }
    if (IsNewRecord != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FleurFairBalloonSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.settleInfo_ != null) {
      if (settleInfo_ == null) {
        SettleInfo = new global::BalloonSettleInfo();
      }
      SettleInfo.MergeFrom(other.SettleInfo);
    }
    if (other.IsNewRecord != false) {
      IsNewRecord = other.IsNewRecord;
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
          IsNewRecord = input.ReadBool();
          break;
        }
        case 82: {
          if (settleInfo_ == null) {
            SettleInfo = new global::BalloonSettleInfo();
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
        case 56: {
          IsNewRecord = input.ReadBool();
          break;
        }
        case 82: {
          if (settleInfo_ == null) {
            SettleInfo = new global::BalloonSettleInfo();
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
