// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk3300_PPKPCOCOMDH.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Unk3300_PPKPCOCOMDH.proto</summary>
public static partial class Unk3300PPKPCOCOMDHReflection {

  #region Descriptor
  /// <summary>File descriptor for Unk3300_PPKPCOCOMDH.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static Unk3300PPKPCOCOMDHReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlVbmszMzAwX1BQS1BDT0NPTURILnByb3RvGg1HQ0dEdWVsLnByb3RvInIK",
          "E1VuazMzMDBfUFBLUENPQ09NREgSFQoNY29udHJvbGxlcl9pZBgMIAEoDRIO",
          "CgZvcF9zZXEYDSABKA0SEAoGZ21fbXNnGAIgASgJSAASGAoEZHVlbBgOIAEo",
          "CzIILkdDR0R1ZWxIAEIICgZkZXRhaWxCFgoUb3JnLnNvcmFwb2ludGEucHJv",
          "dG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GCGDuelReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Unk3300_PPKPCOCOMDH), global::Unk3300_PPKPCOCOMDH.Parser, new[]{ "ControllerId", "OpSeq", "GmMsg", "Duel" }, new[]{ "Detail" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Unk3300_PPKPCOCOMDH : pb::IMessage<Unk3300_PPKPCOCOMDH>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Unk3300_PPKPCOCOMDH> _parser = new pb::MessageParser<Unk3300_PPKPCOCOMDH>(() => new Unk3300_PPKPCOCOMDH());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<Unk3300_PPKPCOCOMDH> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::Unk3300PPKPCOCOMDHReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_PPKPCOCOMDH() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_PPKPCOCOMDH(Unk3300_PPKPCOCOMDH other) : this() {
    controllerId_ = other.controllerId_;
    opSeq_ = other.opSeq_;
    switch (other.DetailCase) {
      case DetailOneofCase.GmMsg:
        GmMsg = other.GmMsg;
        break;
      case DetailOneofCase.Duel:
        Duel = other.Duel.Clone();
        break;
    }

    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public Unk3300_PPKPCOCOMDH Clone() {
    return new Unk3300_PPKPCOCOMDH(this);
  }

  /// <summary>Field number for the "controller_id" field.</summary>
  public const int ControllerIdFieldNumber = 12;
  private uint controllerId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ControllerId {
    get { return controllerId_; }
    set {
      controllerId_ = value;
    }
  }

  /// <summary>Field number for the "op_seq" field.</summary>
  public const int OpSeqFieldNumber = 13;
  private uint opSeq_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OpSeq {
    get { return opSeq_; }
    set {
      opSeq_ = value;
    }
  }

  /// <summary>Field number for the "gm_msg" field.</summary>
  public const int GmMsgFieldNumber = 2;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string GmMsg {
    get { return detailCase_ == DetailOneofCase.GmMsg ? (string) detail_ : ""; }
    set {
      detail_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      detailCase_ = DetailOneofCase.GmMsg;
    }
  }

  /// <summary>Field number for the "duel" field.</summary>
  public const int DuelFieldNumber = 14;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GCGDuel Duel {
    get { return detailCase_ == DetailOneofCase.Duel ? (global::GCGDuel) detail_ : null; }
    set {
      detail_ = value;
      detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.Duel;
    }
  }

  private object detail_;
  /// <summary>Enum of possible cases for the "detail" oneof.</summary>
  public enum DetailOneofCase {
    None = 0,
    GmMsg = 2,
    Duel = 14,
  }
  private DetailOneofCase detailCase_ = DetailOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public DetailOneofCase DetailCase {
    get { return detailCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearDetail() {
    detailCase_ = DetailOneofCase.None;
    detail_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as Unk3300_PPKPCOCOMDH);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(Unk3300_PPKPCOCOMDH other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ControllerId != other.ControllerId) return false;
    if (OpSeq != other.OpSeq) return false;
    if (GmMsg != other.GmMsg) return false;
    if (!object.Equals(Duel, other.Duel)) return false;
    if (DetailCase != other.DetailCase) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
    if (OpSeq != 0) hash ^= OpSeq.GetHashCode();
    if (detailCase_ == DetailOneofCase.GmMsg) hash ^= GmMsg.GetHashCode();
    if (detailCase_ == DetailOneofCase.Duel) hash ^= Duel.GetHashCode();
    hash ^= (int) detailCase_;
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
    if (detailCase_ == DetailOneofCase.GmMsg) {
      output.WriteRawTag(18);
      output.WriteString(GmMsg);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ControllerId);
    }
    if (OpSeq != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(OpSeq);
    }
    if (detailCase_ == DetailOneofCase.Duel) {
      output.WriteRawTag(114);
      output.WriteMessage(Duel);
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
    if (detailCase_ == DetailOneofCase.GmMsg) {
      output.WriteRawTag(18);
      output.WriteString(GmMsg);
    }
    if (ControllerId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(ControllerId);
    }
    if (OpSeq != 0) {
      output.WriteRawTag(104);
      output.WriteUInt32(OpSeq);
    }
    if (detailCase_ == DetailOneofCase.Duel) {
      output.WriteRawTag(114);
      output.WriteMessage(Duel);
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
    if (ControllerId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
    }
    if (OpSeq != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpSeq);
    }
    if (detailCase_ == DetailOneofCase.GmMsg) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(GmMsg);
    }
    if (detailCase_ == DetailOneofCase.Duel) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duel);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(Unk3300_PPKPCOCOMDH other) {
    if (other == null) {
      return;
    }
    if (other.ControllerId != 0) {
      ControllerId = other.ControllerId;
    }
    if (other.OpSeq != 0) {
      OpSeq = other.OpSeq;
    }
    switch (other.DetailCase) {
      case DetailOneofCase.GmMsg:
        GmMsg = other.GmMsg;
        break;
      case DetailOneofCase.Duel:
        if (Duel == null) {
          Duel = new global::GCGDuel();
        }
        Duel.MergeFrom(other.Duel);
        break;
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
        case 18: {
          GmMsg = input.ReadString();
          break;
        }
        case 96: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 104: {
          OpSeq = input.ReadUInt32();
          break;
        }
        case 114: {
          global::GCGDuel subBuilder = new global::GCGDuel();
          if (detailCase_ == DetailOneofCase.Duel) {
            subBuilder.MergeFrom(Duel);
          }
          input.ReadMessage(subBuilder);
          Duel = subBuilder;
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
        case 18: {
          GmMsg = input.ReadString();
          break;
        }
        case 96: {
          ControllerId = input.ReadUInt32();
          break;
        }
        case 104: {
          OpSeq = input.ReadUInt32();
          break;
        }
        case 114: {
          global::GCGDuel subBuilder = new global::GCGDuel();
          if (detailCase_ == DetailOneofCase.Duel) {
            subBuilder.MergeFrom(Duel);
          }
          input.ReadMessage(subBuilder);
          Duel = subBuilder;
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
