// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FetterData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from FetterData.proto</summary>
public static partial class FetterDataReflection {

  #region Descriptor
  /// <summary>File descriptor for FetterData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static FetterDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBGZXR0ZXJEYXRhLnByb3RvIk4KCkZldHRlckRhdGESEQoJZmV0dGVyX2lk",
          "GAEgASgNEhQKDGZldHRlcl9zdGF0ZRgCIAEoDRIXCg9jb25kX2luZGV4X2xp",
          "c3QYAyADKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::FetterData), global::FetterData.Parser, new[]{ "FetterId", "FetterState", "CondIndexList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class FetterData : pb::IMessage<FetterData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<FetterData> _parser = new pb::MessageParser<FetterData>(() => new FetterData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<FetterData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::FetterDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FetterData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FetterData(FetterData other) : this() {
    fetterId_ = other.fetterId_;
    fetterState_ = other.fetterState_;
    condIndexList_ = other.condIndexList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public FetterData Clone() {
    return new FetterData(this);
  }

  /// <summary>Field number for the "fetter_id" field.</summary>
  public const int FetterIdFieldNumber = 1;
  private uint fetterId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FetterId {
    get { return fetterId_; }
    set {
      fetterId_ = value;
    }
  }

  /// <summary>Field number for the "fetter_state" field.</summary>
  public const int FetterStateFieldNumber = 2;
  private uint fetterState_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint FetterState {
    get { return fetterState_; }
    set {
      fetterState_ = value;
    }
  }

  /// <summary>Field number for the "cond_index_list" field.</summary>
  public const int CondIndexListFieldNumber = 3;
  private static readonly pb::FieldCodec<uint> _repeated_condIndexList_codec
      = pb::FieldCodec.ForUInt32(26);
  private readonly pbc::RepeatedField<uint> condIndexList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> CondIndexList {
    get { return condIndexList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as FetterData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(FetterData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (FetterId != other.FetterId) return false;
    if (FetterState != other.FetterState) return false;
    if(!condIndexList_.Equals(other.condIndexList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (FetterId != 0) hash ^= FetterId.GetHashCode();
    if (FetterState != 0) hash ^= FetterState.GetHashCode();
    hash ^= condIndexList_.GetHashCode();
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
    if (FetterId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FetterId);
    }
    if (FetterState != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FetterState);
    }
    condIndexList_.WriteTo(output, _repeated_condIndexList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (FetterId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(FetterId);
    }
    if (FetterState != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(FetterState);
    }
    condIndexList_.WriteTo(ref output, _repeated_condIndexList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (FetterId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FetterId);
    }
    if (FetterState != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FetterState);
    }
    size += condIndexList_.CalculateSize(_repeated_condIndexList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(FetterData other) {
    if (other == null) {
      return;
    }
    if (other.FetterId != 0) {
      FetterId = other.FetterId;
    }
    if (other.FetterState != 0) {
      FetterState = other.FetterState;
    }
    condIndexList_.Add(other.condIndexList_);
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
          FetterId = input.ReadUInt32();
          break;
        }
        case 16: {
          FetterState = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          condIndexList_.AddEntriesFrom(input, _repeated_condIndexList_codec);
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
          FetterId = input.ReadUInt32();
          break;
        }
        case 16: {
          FetterState = input.ReadUInt32();
          break;
        }
        case 26:
        case 24: {
          condIndexList_.AddEntriesFrom(ref input, _repeated_condIndexList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
