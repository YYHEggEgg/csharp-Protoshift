// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriPoetryThemeData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriPoetryThemeData.proto</summary>
public static partial class IrodoriPoetryThemeDataReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriPoetryThemeData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriPoetryThemeDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxJcm9kb3JpUG9ldHJ5VGhlbWVEYXRhLnByb3RvIsYBChZJcm9kb3JpUG9l",
          "dHJ5VGhlbWVEYXRhEhsKE1VuazMzMDBfSEZNS1BOT0JQREsYDiABKA0SGwoT",
          "VW5rMzMwMF9DTk5NRUhPR0dMTBgKIAMoDRIQCghwcm9ncmVzcxgLIAEoDRIQ",
          "Cgh0aGVtZV9pZBgMIAEoDRIUCgxtYXhfcHJvZ3Jlc3MYByABKA0SGwoTVW5r",
          "MzMwMF9IT0RKS0tEQkpEShgPIAMoDRIbChNVbmszMzAwX05KSE1OTElBR0lL",
          "GAYgASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriPoetryThemeData), global::IrodoriPoetryThemeData.Parser, new[]{ "Unk3300HFMKPNOBPDK", "Unk3300CNNMEHOGGLL", "Progress", "ThemeId", "MaxProgress", "Unk3300HODJKKDBJDJ", "Unk3300NJHMNLIAGIK" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IrodoriPoetryThemeData : pb::IMessage<IrodoriPoetryThemeData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriPoetryThemeData> _parser = new pb::MessageParser<IrodoriPoetryThemeData>(() => new IrodoriPoetryThemeData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriPoetryThemeData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriPoetryThemeDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriPoetryThemeData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriPoetryThemeData(IrodoriPoetryThemeData other) : this() {
    unk3300HFMKPNOBPDK_ = other.unk3300HFMKPNOBPDK_;
    unk3300CNNMEHOGGLL_ = other.unk3300CNNMEHOGGLL_.Clone();
    progress_ = other.progress_;
    themeId_ = other.themeId_;
    maxProgress_ = other.maxProgress_;
    unk3300HODJKKDBJDJ_ = other.unk3300HODJKKDBJDJ_.Clone();
    unk3300NJHMNLIAGIK_ = other.unk3300NJHMNLIAGIK_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriPoetryThemeData Clone() {
    return new IrodoriPoetryThemeData(this);
  }

  /// <summary>Field number for the "Unk3300_HFMKPNOBPDK" field.</summary>
  public const int Unk3300HFMKPNOBPDKFieldNumber = 14;
  private uint unk3300HFMKPNOBPDK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300HFMKPNOBPDK {
    get { return unk3300HFMKPNOBPDK_; }
    set {
      unk3300HFMKPNOBPDK_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_CNNMEHOGGLL" field.</summary>
  public const int Unk3300CNNMEHOGGLLFieldNumber = 10;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300CNNMEHOGGLL_codec
      = pb::FieldCodec.ForUInt32(82);
  private readonly pbc::RepeatedField<uint> unk3300CNNMEHOGGLL_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300CNNMEHOGGLL {
    get { return unk3300CNNMEHOGGLL_; }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 11;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "theme_id" field.</summary>
  public const int ThemeIdFieldNumber = 12;
  private uint themeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ThemeId {
    get { return themeId_; }
    set {
      themeId_ = value;
    }
  }

  /// <summary>Field number for the "max_progress" field.</summary>
  public const int MaxProgressFieldNumber = 7;
  private uint maxProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint MaxProgress {
    get { return maxProgress_; }
    set {
      maxProgress_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_HODJKKDBJDJ" field.</summary>
  public const int Unk3300HODJKKDBJDJFieldNumber = 15;
  private static readonly pb::FieldCodec<uint> _repeated_unk3300HODJKKDBJDJ_codec
      = pb::FieldCodec.ForUInt32(122);
  private readonly pbc::RepeatedField<uint> unk3300HODJKKDBJDJ_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> Unk3300HODJKKDBJDJ {
    get { return unk3300HODJKKDBJDJ_; }
  }

  /// <summary>Field number for the "Unk3300_NJHMNLIAGIK" field.</summary>
  public const int Unk3300NJHMNLIAGIKFieldNumber = 6;
  private uint unk3300NJHMNLIAGIK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300NJHMNLIAGIK {
    get { return unk3300NJHMNLIAGIK_; }
    set {
      unk3300NJHMNLIAGIK_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriPoetryThemeData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriPoetryThemeData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300HFMKPNOBPDK != other.Unk3300HFMKPNOBPDK) return false;
    if(!unk3300CNNMEHOGGLL_.Equals(other.unk3300CNNMEHOGGLL_)) return false;
    if (Progress != other.Progress) return false;
    if (ThemeId != other.ThemeId) return false;
    if (MaxProgress != other.MaxProgress) return false;
    if(!unk3300HODJKKDBJDJ_.Equals(other.unk3300HODJKKDBJDJ_)) return false;
    if (Unk3300NJHMNLIAGIK != other.Unk3300NJHMNLIAGIK) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300HFMKPNOBPDK != 0) hash ^= Unk3300HFMKPNOBPDK.GetHashCode();
    hash ^= unk3300CNNMEHOGGLL_.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (ThemeId != 0) hash ^= ThemeId.GetHashCode();
    if (MaxProgress != 0) hash ^= MaxProgress.GetHashCode();
    hash ^= unk3300HODJKKDBJDJ_.GetHashCode();
    if (Unk3300NJHMNLIAGIK != 0) hash ^= Unk3300NJHMNLIAGIK.GetHashCode();
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
    if (Unk3300NJHMNLIAGIK != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300NJHMNLIAGIK);
    }
    if (MaxProgress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(MaxProgress);
    }
    unk3300CNNMEHOGGLL_.WriteTo(output, _repeated_unk3300CNNMEHOGGLL_codec);
    if (Progress != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Progress);
    }
    if (ThemeId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ThemeId);
    }
    if (Unk3300HFMKPNOBPDK != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300HFMKPNOBPDK);
    }
    unk3300HODJKKDBJDJ_.WriteTo(output, _repeated_unk3300HODJKKDBJDJ_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (Unk3300NJHMNLIAGIK != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Unk3300NJHMNLIAGIK);
    }
    if (MaxProgress != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(MaxProgress);
    }
    unk3300CNNMEHOGGLL_.WriteTo(ref output, _repeated_unk3300CNNMEHOGGLL_codec);
    if (Progress != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Progress);
    }
    if (ThemeId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ThemeId);
    }
    if (Unk3300HFMKPNOBPDK != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300HFMKPNOBPDK);
    }
    unk3300HODJKKDBJDJ_.WriteTo(ref output, _repeated_unk3300HODJKKDBJDJ_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (Unk3300HFMKPNOBPDK != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HFMKPNOBPDK);
    }
    size += unk3300CNNMEHOGGLL_.CalculateSize(_repeated_unk3300CNNMEHOGGLL_codec);
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (ThemeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ThemeId);
    }
    if (MaxProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxProgress);
    }
    size += unk3300HODJKKDBJDJ_.CalculateSize(_repeated_unk3300HODJKKDBJDJ_codec);
    if (Unk3300NJHMNLIAGIK != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NJHMNLIAGIK);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriPoetryThemeData other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300HFMKPNOBPDK != 0) {
      Unk3300HFMKPNOBPDK = other.Unk3300HFMKPNOBPDK;
    }
    unk3300CNNMEHOGGLL_.Add(other.unk3300CNNMEHOGGLL_);
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.ThemeId != 0) {
      ThemeId = other.ThemeId;
    }
    if (other.MaxProgress != 0) {
      MaxProgress = other.MaxProgress;
    }
    unk3300HODJKKDBJDJ_.Add(other.unk3300HODJKKDBJDJ_);
    if (other.Unk3300NJHMNLIAGIK != 0) {
      Unk3300NJHMNLIAGIK = other.Unk3300NJHMNLIAGIK;
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
        case 48: {
          Unk3300NJHMNLIAGIK = input.ReadUInt32();
          break;
        }
        case 56: {
          MaxProgress = input.ReadUInt32();
          break;
        }
        case 82:
        case 80: {
          unk3300CNNMEHOGGLL_.AddEntriesFrom(input, _repeated_unk3300CNNMEHOGGLL_codec);
          break;
        }
        case 88: {
          Progress = input.ReadUInt32();
          break;
        }
        case 96: {
          ThemeId = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300HFMKPNOBPDK = input.ReadUInt32();
          break;
        }
        case 122:
        case 120: {
          unk3300HODJKKDBJDJ_.AddEntriesFrom(input, _repeated_unk3300HODJKKDBJDJ_codec);
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
        case 48: {
          Unk3300NJHMNLIAGIK = input.ReadUInt32();
          break;
        }
        case 56: {
          MaxProgress = input.ReadUInt32();
          break;
        }
        case 82:
        case 80: {
          unk3300CNNMEHOGGLL_.AddEntriesFrom(ref input, _repeated_unk3300CNNMEHOGGLL_codec);
          break;
        }
        case 88: {
          Progress = input.ReadUInt32();
          break;
        }
        case 96: {
          ThemeId = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300HFMKPNOBPDK = input.ReadUInt32();
          break;
        }
        case 122:
        case 120: {
          unk3300HODJKKDBJDJ_.AddEntriesFrom(ref input, _repeated_unk3300HODJKKDBJDJ_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code