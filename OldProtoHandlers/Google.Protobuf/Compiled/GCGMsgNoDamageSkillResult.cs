// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgNoDamageSkillResult.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGMsgNoDamageSkillResult.proto</summary>
  public static partial class GCGMsgNoDamageSkillResultReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgNoDamageSkillResult.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgNoDamageSkillResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HQ0dNc2dOb0RhbWFnZVNraWxsUmVzdWx0LnByb3RvGhVHQ0dEYW1hZ2VE",
            "ZXRhaWwucHJvdG8iygEKGUdDR01zZ05vRGFtYWdlU2tpbGxSZXN1bHQSEgoK",
            "cmVzdWx0X3NlcRgIIAEoDRIXCg9mcm9tX3Jlc3VsdF9zZXEYBCABKA0SFgoO",
            "ZWZmZWN0X2VsZW1lbnQYCSABKA0SGAoQdGFyZ2V0X2NhcmRfZ3VpZBgFIAEo",
            "DRIlCgtkZXRhaWxfbGlzdBgNIAMoCzIQLkdDR0RhbWFnZURldGFpbBIQCghz",
            "a2lsbF9pZBgKIAEoDRIVCg1zcmNfY2FyZF9ndWlkGAwgASgNQgyqAglPbGRQ",
            "cm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGDamageDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGMsgNoDamageSkillResult), global::OldProtos.GCGMsgNoDamageSkillResult.Parser, new[]{ "ResultSeq", "FromResultSeq", "EffectElement", "TargetCardGuid", "DetailList", "SkillId", "SrcCardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgNoDamageSkillResult : pb::IMessage<GCGMsgNoDamageSkillResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgNoDamageSkillResult> _parser = new pb::MessageParser<GCGMsgNoDamageSkillResult>(() => new GCGMsgNoDamageSkillResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgNoDamageSkillResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGMsgNoDamageSkillResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgNoDamageSkillResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgNoDamageSkillResult(GCGMsgNoDamageSkillResult other) : this() {
      resultSeq_ = other.resultSeq_;
      fromResultSeq_ = other.fromResultSeq_;
      effectElement_ = other.effectElement_;
      targetCardGuid_ = other.targetCardGuid_;
      detailList_ = other.detailList_.Clone();
      skillId_ = other.skillId_;
      srcCardGuid_ = other.srcCardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgNoDamageSkillResult Clone() {
      return new GCGMsgNoDamageSkillResult(this);
    }

    /// <summary>Field number for the "result_seq" field.</summary>
    public const int ResultSeqFieldNumber = 8;
    private uint resultSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ResultSeq {
      get { return resultSeq_; }
      set {
        resultSeq_ = value;
      }
    }

    /// <summary>Field number for the "from_result_seq" field.</summary>
    public const int FromResultSeqFieldNumber = 4;
    private uint fromResultSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FromResultSeq {
      get { return fromResultSeq_; }
      set {
        fromResultSeq_ = value;
      }
    }

    /// <summary>Field number for the "effect_element" field.</summary>
    public const int EffectElementFieldNumber = 9;
    private uint effectElement_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EffectElement {
      get { return effectElement_; }
      set {
        effectElement_ = value;
      }
    }

    /// <summary>Field number for the "target_card_guid" field.</summary>
    public const int TargetCardGuidFieldNumber = 5;
    private uint targetCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetCardGuid {
      get { return targetCardGuid_; }
      set {
        targetCardGuid_ = value;
      }
    }

    /// <summary>Field number for the "detail_list" field.</summary>
    public const int DetailListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::OldProtos.GCGDamageDetail> _repeated_detailList_codec
        = pb::FieldCodec.ForMessage(106, global::OldProtos.GCGDamageDetail.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.GCGDamageDetail> detailList_ = new pbc::RepeatedField<global::OldProtos.GCGDamageDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGDamageDetail> DetailList {
      get { return detailList_; }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 10;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    /// <summary>Field number for the "src_card_guid" field.</summary>
    public const int SrcCardGuidFieldNumber = 12;
    private uint srcCardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SrcCardGuid {
      get { return srcCardGuid_; }
      set {
        srcCardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgNoDamageSkillResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgNoDamageSkillResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResultSeq != other.ResultSeq) return false;
      if (FromResultSeq != other.FromResultSeq) return false;
      if (EffectElement != other.EffectElement) return false;
      if (TargetCardGuid != other.TargetCardGuid) return false;
      if(!detailList_.Equals(other.detailList_)) return false;
      if (SkillId != other.SkillId) return false;
      if (SrcCardGuid != other.SrcCardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResultSeq != 0) hash ^= ResultSeq.GetHashCode();
      if (FromResultSeq != 0) hash ^= FromResultSeq.GetHashCode();
      if (EffectElement != 0) hash ^= EffectElement.GetHashCode();
      if (TargetCardGuid != 0) hash ^= TargetCardGuid.GetHashCode();
      hash ^= detailList_.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
      if (SrcCardGuid != 0) hash ^= SrcCardGuid.GetHashCode();
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
      if (FromResultSeq != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FromResultSeq);
      }
      if (TargetCardGuid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetCardGuid);
      }
      if (ResultSeq != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ResultSeq);
      }
      if (EffectElement != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EffectElement);
      }
      if (SkillId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkillId);
      }
      if (SrcCardGuid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SrcCardGuid);
      }
      detailList_.WriteTo(output, _repeated_detailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FromResultSeq != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(FromResultSeq);
      }
      if (TargetCardGuid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetCardGuid);
      }
      if (ResultSeq != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ResultSeq);
      }
      if (EffectElement != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EffectElement);
      }
      if (SkillId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(SkillId);
      }
      if (SrcCardGuid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SrcCardGuid);
      }
      detailList_.WriteTo(ref output, _repeated_detailList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResultSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ResultSeq);
      }
      if (FromResultSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FromResultSeq);
      }
      if (EffectElement != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EffectElement);
      }
      if (TargetCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetCardGuid);
      }
      size += detailList_.CalculateSize(_repeated_detailList_codec);
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (SrcCardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SrcCardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgNoDamageSkillResult other) {
      if (other == null) {
        return;
      }
      if (other.ResultSeq != 0) {
        ResultSeq = other.ResultSeq;
      }
      if (other.FromResultSeq != 0) {
        FromResultSeq = other.FromResultSeq;
      }
      if (other.EffectElement != 0) {
        EffectElement = other.EffectElement;
      }
      if (other.TargetCardGuid != 0) {
        TargetCardGuid = other.TargetCardGuid;
      }
      detailList_.Add(other.detailList_);
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
      }
      if (other.SrcCardGuid != 0) {
        SrcCardGuid = other.SrcCardGuid;
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
          case 32: {
            FromResultSeq = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetCardGuid = input.ReadUInt32();
            break;
          }
          case 64: {
            ResultSeq = input.ReadUInt32();
            break;
          }
          case 72: {
            EffectElement = input.ReadUInt32();
            break;
          }
          case 80: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 96: {
            SrcCardGuid = input.ReadUInt32();
            break;
          }
          case 106: {
            detailList_.AddEntriesFrom(input, _repeated_detailList_codec);
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
          case 32: {
            FromResultSeq = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetCardGuid = input.ReadUInt32();
            break;
          }
          case 64: {
            ResultSeq = input.ReadUInt32();
            break;
          }
          case 72: {
            EffectElement = input.ReadUInt32();
            break;
          }
          case 80: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 96: {
            SrcCardGuid = input.ReadUInt32();
            break;
          }
          case 106: {
            detailList_.AddEntriesFrom(ref input, _repeated_detailList_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
