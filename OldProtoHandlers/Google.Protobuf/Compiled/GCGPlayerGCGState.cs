// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGPlayerGCGState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGPlayerGCGState.proto</summary>
public static partial class GCGPlayerGCGStateReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGPlayerGCGState.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGPlayerGCGStateReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdHQ0dQbGF5ZXJHQ0dTdGF0ZS5wcm90byJZChFHQ0dQbGF5ZXJHQ0dTdGF0",
          "ZRIcChRpc19yZWFzb3VjZV9jb21wbGV0ZRgHIAEoCBIZChFpc19nY2dfc3Rh",
          "dGVfb3BlbhgFIAEoCBILCgN1aWQYAiABKA1CHgocZW11LmdyYXNzY3V0dGVy",
          "Lm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGPlayerGCGState), global::GCGPlayerGCGState.Parser, new[]{ "IsReasouceComplete", "IsGcgStateOpen", "Uid" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGPlayerGCGState : pb::IMessage<GCGPlayerGCGState>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGPlayerGCGState> _parser = new pb::MessageParser<GCGPlayerGCGState>(() => new GCGPlayerGCGState());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGPlayerGCGState> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGPlayerGCGStateReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerGCGState() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerGCGState(GCGPlayerGCGState other) : this() {
    isReasouceComplete_ = other.isReasouceComplete_;
    isGcgStateOpen_ = other.isGcgStateOpen_;
    uid_ = other.uid_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGPlayerGCGState Clone() {
    return new GCGPlayerGCGState(this);
  }

  /// <summary>Field number for the "is_reasouce_complete" field.</summary>
  public const int IsReasouceCompleteFieldNumber = 7;
  private bool isReasouceComplete_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsReasouceComplete {
    get { return isReasouceComplete_; }
    set {
      isReasouceComplete_ = value;
    }
  }

  /// <summary>Field number for the "is_gcg_state_open" field.</summary>
  public const int IsGcgStateOpenFieldNumber = 5;
  private bool isGcgStateOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsGcgStateOpen {
    get { return isGcgStateOpen_; }
    set {
      isGcgStateOpen_ = value;
    }
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 2;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGPlayerGCGState);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGPlayerGCGState other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsReasouceComplete != other.IsReasouceComplete) return false;
    if (IsGcgStateOpen != other.IsGcgStateOpen) return false;
    if (Uid != other.Uid) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsReasouceComplete != false) hash ^= IsReasouceComplete.GetHashCode();
    if (IsGcgStateOpen != false) hash ^= IsGcgStateOpen.GetHashCode();
    if (Uid != 0) hash ^= Uid.GetHashCode();
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
    if (Uid != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Uid);
    }
    if (IsGcgStateOpen != false) {
      output.WriteRawTag(40);
      output.WriteBool(IsGcgStateOpen);
    }
    if (IsReasouceComplete != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsReasouceComplete);
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
    if (Uid != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Uid);
    }
    if (IsGcgStateOpen != false) {
      output.WriteRawTag(40);
      output.WriteBool(IsGcgStateOpen);
    }
    if (IsReasouceComplete != false) {
      output.WriteRawTag(56);
      output.WriteBool(IsReasouceComplete);
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
    if (IsReasouceComplete != false) {
      size += 1 + 1;
    }
    if (IsGcgStateOpen != false) {
      size += 1 + 1;
    }
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGPlayerGCGState other) {
    if (other == null) {
      return;
    }
    if (other.IsReasouceComplete != false) {
      IsReasouceComplete = other.IsReasouceComplete;
    }
    if (other.IsGcgStateOpen != false) {
      IsGcgStateOpen = other.IsGcgStateOpen;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
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
          Uid = input.ReadUInt32();
          break;
        }
        case 40: {
          IsGcgStateOpen = input.ReadBool();
          break;
        }
        case 56: {
          IsReasouceComplete = input.ReadBool();
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
          Uid = input.ReadUInt32();
          break;
        }
        case 40: {
          IsGcgStateOpen = input.ReadBool();
          break;
        }
        case 56: {
          IsReasouceComplete = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
