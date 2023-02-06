// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityShopSheetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ActivityShopSheetInfo.proto</summary>
public static partial class ActivityShopSheetInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for ActivityShopSheetInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ActivityShopSheetInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtBY3Rpdml0eVNob3BTaGVldEluZm8ucHJvdG8iTwoVQWN0aXZpdHlTaG9w",
          "U2hlZXRJbmZvEhAKCGVuZF90aW1lGAEgASgNEhIKCmJlZ2luX3RpbWUYDCAB",
          "KA0SEAoIc2hlZXRfaWQYAiABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5v",
          "bGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ActivityShopSheetInfo), global::ActivityShopSheetInfo.Parser, new[]{ "EndTime", "BeginTime", "SheetId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ActivityShopSheetInfo : pb::IMessage<ActivityShopSheetInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ActivityShopSheetInfo> _parser = new pb::MessageParser<ActivityShopSheetInfo>(() => new ActivityShopSheetInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ActivityShopSheetInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ActivityShopSheetInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityShopSheetInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityShopSheetInfo(ActivityShopSheetInfo other) : this() {
    endTime_ = other.endTime_;
    beginTime_ = other.beginTime_;
    sheetId_ = other.sheetId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ActivityShopSheetInfo Clone() {
    return new ActivityShopSheetInfo(this);
  }

  /// <summary>Field number for the "end_time" field.</summary>
  public const int EndTimeFieldNumber = 1;
  private uint endTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EndTime {
    get { return endTime_; }
    set {
      endTime_ = value;
    }
  }

  /// <summary>Field number for the "begin_time" field.</summary>
  public const int BeginTimeFieldNumber = 12;
  private uint beginTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BeginTime {
    get { return beginTime_; }
    set {
      beginTime_ = value;
    }
  }

  /// <summary>Field number for the "sheet_id" field.</summary>
  public const int SheetIdFieldNumber = 2;
  private uint sheetId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SheetId {
    get { return sheetId_; }
    set {
      sheetId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ActivityShopSheetInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ActivityShopSheetInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EndTime != other.EndTime) return false;
    if (BeginTime != other.BeginTime) return false;
    if (SheetId != other.SheetId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (EndTime != 0) hash ^= EndTime.GetHashCode();
    if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
    if (SheetId != 0) hash ^= SheetId.GetHashCode();
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
    if (EndTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(EndTime);
    }
    if (SheetId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(SheetId);
    }
    if (BeginTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(BeginTime);
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
    if (EndTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(EndTime);
    }
    if (SheetId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(SheetId);
    }
    if (BeginTime != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(BeginTime);
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
    if (EndTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
    }
    if (BeginTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
    }
    if (SheetId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SheetId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ActivityShopSheetInfo other) {
    if (other == null) {
      return;
    }
    if (other.EndTime != 0) {
      EndTime = other.EndTime;
    }
    if (other.BeginTime != 0) {
      BeginTime = other.BeginTime;
    }
    if (other.SheetId != 0) {
      SheetId = other.SheetId;
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
          EndTime = input.ReadUInt32();
          break;
        }
        case 16: {
          SheetId = input.ReadUInt32();
          break;
        }
        case 96: {
          BeginTime = input.ReadUInt32();
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
          EndTime = input.ReadUInt32();
          break;
        }
        case 16: {
          SheetId = input.ReadUInt32();
          break;
        }
        case 96: {
          BeginTime = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
