// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageHuntingFirstStageSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from VintageHuntingFirstStageSettleInfo.proto</summary>
public static partial class VintageHuntingFirstStageSettleInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for VintageHuntingFirstStageSettleInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static VintageHuntingFirstStageSettleInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CihWaW50YWdlSHVudGluZ0ZpcnN0U3RhZ2VTZXR0bGVJbmZvLnByb3RvIooB",
          "CiJWaW50YWdlSHVudGluZ0ZpcnN0U3RhZ2VTZXR0bGVJbmZvEhsKE1VuazMz",
          "MDBfSElLQURIQkxQRUIYAiABKA0SDQoFc2NvcmUYASABKA0SGwoTVW5rMzMw",
          "MF9OSUxHTkhPUEdMRBgDIAEoDRIbChNVbmszMzAwX0lQQUpMS09CREtDGAsg",
          "ASgNQhYKFG9yZy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::VintageHuntingFirstStageSettleInfo), global::VintageHuntingFirstStageSettleInfo.Parser, new[]{ "Unk3300HIKADHBLPEB", "Score", "Unk3300NILGNHOPGLD", "Unk3300IPAJLKOBDKC" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class VintageHuntingFirstStageSettleInfo : pb::IMessage<VintageHuntingFirstStageSettleInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<VintageHuntingFirstStageSettleInfo> _parser = new pb::MessageParser<VintageHuntingFirstStageSettleInfo>(() => new VintageHuntingFirstStageSettleInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<VintageHuntingFirstStageSettleInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::VintageHuntingFirstStageSettleInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageHuntingFirstStageSettleInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageHuntingFirstStageSettleInfo(VintageHuntingFirstStageSettleInfo other) : this() {
    unk3300HIKADHBLPEB_ = other.unk3300HIKADHBLPEB_;
    score_ = other.score_;
    unk3300NILGNHOPGLD_ = other.unk3300NILGNHOPGLD_;
    unk3300IPAJLKOBDKC_ = other.unk3300IPAJLKOBDKC_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public VintageHuntingFirstStageSettleInfo Clone() {
    return new VintageHuntingFirstStageSettleInfo(this);
  }

  /// <summary>Field number for the "Unk3300_HIKADHBLPEB" field.</summary>
  public const int Unk3300HIKADHBLPEBFieldNumber = 2;
  private uint unk3300HIKADHBLPEB_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300HIKADHBLPEB {
    get { return unk3300HIKADHBLPEB_; }
    set {
      unk3300HIKADHBLPEB_ = value;
    }
  }

  /// <summary>Field number for the "score" field.</summary>
  public const int ScoreFieldNumber = 1;
  private uint score_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Score {
    get { return score_; }
    set {
      score_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_NILGNHOPGLD" field.</summary>
  public const int Unk3300NILGNHOPGLDFieldNumber = 3;
  private uint unk3300NILGNHOPGLD_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300NILGNHOPGLD {
    get { return unk3300NILGNHOPGLD_; }
    set {
      unk3300NILGNHOPGLD_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_IPAJLKOBDKC" field.</summary>
  public const int Unk3300IPAJLKOBDKCFieldNumber = 11;
  private uint unk3300IPAJLKOBDKC_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300IPAJLKOBDKC {
    get { return unk3300IPAJLKOBDKC_; }
    set {
      unk3300IPAJLKOBDKC_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as VintageHuntingFirstStageSettleInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(VintageHuntingFirstStageSettleInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300HIKADHBLPEB != other.Unk3300HIKADHBLPEB) return false;
    if (Score != other.Score) return false;
    if (Unk3300NILGNHOPGLD != other.Unk3300NILGNHOPGLD) return false;
    if (Unk3300IPAJLKOBDKC != other.Unk3300IPAJLKOBDKC) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300HIKADHBLPEB != 0) hash ^= Unk3300HIKADHBLPEB.GetHashCode();
    if (Score != 0) hash ^= Score.GetHashCode();
    if (Unk3300NILGNHOPGLD != 0) hash ^= Unk3300NILGNHOPGLD.GetHashCode();
    if (Unk3300IPAJLKOBDKC != 0) hash ^= Unk3300IPAJLKOBDKC.GetHashCode();
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
    if (Score != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Score);
    }
    if (Unk3300HIKADHBLPEB != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Unk3300HIKADHBLPEB);
    }
    if (Unk3300NILGNHOPGLD != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300NILGNHOPGLD);
    }
    if (Unk3300IPAJLKOBDKC != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300IPAJLKOBDKC);
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
    if (Score != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Score);
    }
    if (Unk3300HIKADHBLPEB != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Unk3300HIKADHBLPEB);
    }
    if (Unk3300NILGNHOPGLD != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(Unk3300NILGNHOPGLD);
    }
    if (Unk3300IPAJLKOBDKC != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(Unk3300IPAJLKOBDKC);
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
    if (Unk3300HIKADHBLPEB != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HIKADHBLPEB);
    }
    if (Score != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
    }
    if (Unk3300NILGNHOPGLD != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300NILGNHOPGLD);
    }
    if (Unk3300IPAJLKOBDKC != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IPAJLKOBDKC);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(VintageHuntingFirstStageSettleInfo other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300HIKADHBLPEB != 0) {
      Unk3300HIKADHBLPEB = other.Unk3300HIKADHBLPEB;
    }
    if (other.Score != 0) {
      Score = other.Score;
    }
    if (other.Unk3300NILGNHOPGLD != 0) {
      Unk3300NILGNHOPGLD = other.Unk3300NILGNHOPGLD;
    }
    if (other.Unk3300IPAJLKOBDKC != 0) {
      Unk3300IPAJLKOBDKC = other.Unk3300IPAJLKOBDKC;
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
          Score = input.ReadUInt32();
          break;
        }
        case 16: {
          Unk3300HIKADHBLPEB = input.ReadUInt32();
          break;
        }
        case 24: {
          Unk3300NILGNHOPGLD = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300IPAJLKOBDKC = input.ReadUInt32();
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
          Score = input.ReadUInt32();
          break;
        }
        case 16: {
          Unk3300HIKADHBLPEB = input.ReadUInt32();
          break;
        }
        case 24: {
          Unk3300NILGNHOPGLD = input.ReadUInt32();
          break;
        }
        case 88: {
          Unk3300IPAJLKOBDKC = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
