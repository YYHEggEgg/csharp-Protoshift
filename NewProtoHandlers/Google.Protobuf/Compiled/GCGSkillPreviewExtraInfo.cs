// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSkillPreviewExtraInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GCGSkillPreviewExtraInfo.proto</summary>
public static partial class GCGSkillPreviewExtraInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for GCGSkillPreviewExtraInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GCGSkillPreviewExtraInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5HQ0dTa2lsbFByZXZpZXdFeHRyYUluZm8ucHJvdG8aHUdDR1NraWxsUHJl",
          "dmlld0NhcmRJbmZvLnByb3RvIogBChhHQ0dTa2lsbFByZXZpZXdFeHRyYUlu",
          "Zm8SNQoTVW5rMzMwMF9LSUZGSkdGRE5LQRgGIAMoCzIYLkdDR1NraWxsUHJl",
          "dmlld0NhcmRJbmZvEjUKE1VuazMzMDBfR01FTU1ESktDR04YCCADKAsyGC5H",
          "Q0dTa2lsbFByZXZpZXdDYXJkSW5mb0IWChRvcmcuc29yYXBvaW50YS5wcm90",
          "b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGSkillPreviewCardInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GCGSkillPreviewExtraInfo), global::GCGSkillPreviewExtraInfo.Parser, new[]{ "Unk3300KIFFJGFDNKA", "Unk3300GMEMMDJKCGN" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class GCGSkillPreviewExtraInfo : pb::IMessage<GCGSkillPreviewExtraInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GCGSkillPreviewExtraInfo> _parser = new pb::MessageParser<GCGSkillPreviewExtraInfo>(() => new GCGSkillPreviewExtraInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GCGSkillPreviewExtraInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GCGSkillPreviewExtraInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGSkillPreviewExtraInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGSkillPreviewExtraInfo(GCGSkillPreviewExtraInfo other) : this() {
    unk3300KIFFJGFDNKA_ = other.unk3300KIFFJGFDNKA_.Clone();
    unk3300GMEMMDJKCGN_ = other.unk3300GMEMMDJKCGN_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GCGSkillPreviewExtraInfo Clone() {
    return new GCGSkillPreviewExtraInfo(this);
  }

  /// <summary>Field number for the "Unk3300_KIFFJGFDNKA" field.</summary>
  public const int Unk3300KIFFJGFDNKAFieldNumber = 6;
  private static readonly pb::FieldCodec<global::GCGSkillPreviewCardInfo> _repeated_unk3300KIFFJGFDNKA_codec
      = pb::FieldCodec.ForMessage(50, global::GCGSkillPreviewCardInfo.Parser);
  private readonly pbc::RepeatedField<global::GCGSkillPreviewCardInfo> unk3300KIFFJGFDNKA_ = new pbc::RepeatedField<global::GCGSkillPreviewCardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGSkillPreviewCardInfo> Unk3300KIFFJGFDNKA {
    get { return unk3300KIFFJGFDNKA_; }
  }

  /// <summary>Field number for the "Unk3300_GMEMMDJKCGN" field.</summary>
  public const int Unk3300GMEMMDJKCGNFieldNumber = 8;
  private static readonly pb::FieldCodec<global::GCGSkillPreviewCardInfo> _repeated_unk3300GMEMMDJKCGN_codec
      = pb::FieldCodec.ForMessage(66, global::GCGSkillPreviewCardInfo.Parser);
  private readonly pbc::RepeatedField<global::GCGSkillPreviewCardInfo> unk3300GMEMMDJKCGN_ = new pbc::RepeatedField<global::GCGSkillPreviewCardInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::GCGSkillPreviewCardInfo> Unk3300GMEMMDJKCGN {
    get { return unk3300GMEMMDJKCGN_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GCGSkillPreviewExtraInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GCGSkillPreviewExtraInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!unk3300KIFFJGFDNKA_.Equals(other.unk3300KIFFJGFDNKA_)) return false;
    if(!unk3300GMEMMDJKCGN_.Equals(other.unk3300GMEMMDJKCGN_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= unk3300KIFFJGFDNKA_.GetHashCode();
    hash ^= unk3300GMEMMDJKCGN_.GetHashCode();
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
    unk3300KIFFJGFDNKA_.WriteTo(output, _repeated_unk3300KIFFJGFDNKA_codec);
    unk3300GMEMMDJKCGN_.WriteTo(output, _repeated_unk3300GMEMMDJKCGN_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    unk3300KIFFJGFDNKA_.WriteTo(ref output, _repeated_unk3300KIFFJGFDNKA_codec);
    unk3300GMEMMDJKCGN_.WriteTo(ref output, _repeated_unk3300GMEMMDJKCGN_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += unk3300KIFFJGFDNKA_.CalculateSize(_repeated_unk3300KIFFJGFDNKA_codec);
    size += unk3300GMEMMDJKCGN_.CalculateSize(_repeated_unk3300GMEMMDJKCGN_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GCGSkillPreviewExtraInfo other) {
    if (other == null) {
      return;
    }
    unk3300KIFFJGFDNKA_.Add(other.unk3300KIFFJGFDNKA_);
    unk3300GMEMMDJKCGN_.Add(other.unk3300GMEMMDJKCGN_);
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
        case 50: {
          unk3300KIFFJGFDNKA_.AddEntriesFrom(input, _repeated_unk3300KIFFJGFDNKA_codec);
          break;
        }
        case 66: {
          unk3300GMEMMDJKCGN_.AddEntriesFrom(input, _repeated_unk3300GMEMMDJKCGN_codec);
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
        case 50: {
          unk3300KIFFJGFDNKA_.AddEntriesFrom(ref input, _repeated_unk3300KIFFJGFDNKA_codec);
          break;
        }
        case 66: {
          unk3300GMEMMDJKCGN_.AddEntriesFrom(ref input, _repeated_unk3300GMEMMDJKCGN_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
