// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SummerTimeV2DungeonSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SummerTimeV2DungeonSettleInfo.proto</summary>
public static partial class SummerTimeV2DungeonSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SummerTimeV2DungeonSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SummerTimeV2DungeonSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNTdW1tZXJUaW1lVjJEdW5nZW9uU2V0dGxlSW5mby5wcm90byJtCh1TdW1t",
          "ZXJUaW1lVjJEdW5nZW9uU2V0dGxlSW5mbxIbChNVbmszMzAwX0pIQkNIRkhB",
          "R0ZPGAogASgNEhIKCmlzX3N1Y2Nlc3MYASABKAgSGwoTVW5rMzMwMF9CTk5N",
          "TkNLRUhITxgLIAEoDUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SummerTimeV2DungeonSettleInfo), global::SummerTimeV2DungeonSettleInfo.Parser, new[]{ "Unk3300JHBCHFHAGFO", "IsSuccess", "Unk3300BNNMNCKEHHO" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SummerTimeV2DungeonSettleInfo : pb::IMessage<SummerTimeV2DungeonSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SummerTimeV2DungeonSettleInfo> _parser = new pb::MessageParser<SummerTimeV2DungeonSettleInfo>(() => new SummerTimeV2DungeonSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SummerTimeV2DungeonSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SummerTimeV2DungeonSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeV2DungeonSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeV2DungeonSettleInfo(SummerTimeV2DungeonSettleInfo other) : this() {
    unk3300JHBCHFHAGFO_ = other.unk3300JHBCHFHAGFO_;
    isSuccess_ = other.isSuccess_;
    unk3300BNNMNCKEHHO_ = other.unk3300BNNMNCKEHHO_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SummerTimeV2DungeonSettleInfo Clone() {
    return new SummerTimeV2DungeonSettleInfo(this);
  }

  /// <summary>Field number for the "Unk3300_JHBCHFHAGFO" field.</summary>
  public const int Unk3300JHBCHFHAGFOFieldNumber = 10;
  private uint unk3300JHBCHFHAGFO_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300JHBCHFHAGFO {
    get { return unk3300JHBCHFHAGFO_; }
    set {
      unk3300JHBCHFHAGFO_ = value;
    }
  }

  /// <summary>Field number for the "is_success" field.</summary>
  public const int IsSuccessFieldNumber = 1;
  private bool isSuccess_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsSuccess {
    get { return isSuccess_; }
    set {
      isSuccess_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_BNNMNCKEHHO" field.</summary>
  public const int Unk3300BNNMNCKEHHOFieldNumber = 11;
  private uint unk3300BNNMNCKEHHO_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300BNNMNCKEHHO {
    get { return unk3300BNNMNCKEHHO_; }
    set {
      unk3300BNNMNCKEHHO_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SummerTimeV2DungeonSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SummerTimeV2DungeonSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300JHBCHFHAGFO != other.Unk3300JHBCHFHAGFO) return false;
    if (IsSuccess != other.IsSuccess) return false;
    if (Unk3300BNNMNCKEHHO != other.Unk3300BNNMNCKEHHO) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300JHBCHFHAGFO != 0) hash ^= Unk3300JHBCHFHAGFO.GetHashCode();
    if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
    if (Unk3300BNNMNCKEHHO != 0) hash ^= Unk3300BNNMNCKEHHO.GetHashCode();
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
    if (IsSuccess != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsSuccess);
    }
    if (Unk3300JHBCHFHAGFO != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Unk3300JHBCHFHAGFO);
    }
    if (Unk3300BNNMNCKEHHO != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300BNNMNCKEHHO);
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
    if (IsSuccess != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsSuccess);
    }
    if (Unk3300JHBCHFHAGFO != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(Unk3300JHBCHFHAGFO);
    }
    if (Unk3300BNNMNCKEHHO != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300BNNMNCKEHHO);
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
    if (Unk3300JHBCHFHAGFO != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300JHBCHFHAGFO);
    }
    if (IsSuccess != false) {
      size += 1 + 1;
    }
    if (Unk3300BNNMNCKEHHO != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300BNNMNCKEHHO);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SummerTimeV2DungeonSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300JHBCHFHAGFO != 0) {
      Unk3300JHBCHFHAGFO = other.Unk3300JHBCHFHAGFO;
    }
    if (other.IsSuccess != false) {
      IsSuccess = other.IsSuccess;
    }
    if (other.Unk3300BNNMNCKEHHO != 0) {
      Unk3300BNNMNCKEHHO = other.Unk3300BNNMNCKEHHO;
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          Unk3300JHBCHFHAGFO = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300BNNMNCKEHHO = input.ReadUInt32();
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
          IsSuccess = input.ReadBool();
          break;
        }
        case 80: {
          Unk3300JHBCHFHAGFO = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300BNNMNCKEHHO = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
