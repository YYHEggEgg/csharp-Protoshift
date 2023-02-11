// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgDiceReroll.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGMsgDiceReroll.proto</summary>
  public static partial class GCGMsgDiceRerollReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgDiceReroll.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgDiceRerollReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHQ0dNc2dEaWNlUmVyb2xsLnByb3RvGhVHQ0dEaWNlU2lkZVR5cGUucHJv",
            "dG8icwoQR0NHTXNnRGljZVJlcm9sbBIVCg1jb250cm9sbGVyX2lkGAIgASgN",
            "Eh4KFnNlbGVjdF9kaWNlX2luZGV4X2xpc3QYASADKA0SKAoOZGljZV9zaWRl",
            "X2xpc3QYBiADKA4yEC5HQ0dEaWNlU2lkZVR5cGVCDKoCCU9sZFByb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.GCGDiceSideTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GCGMsgDiceReroll), global::OldProtos.GCGMsgDiceReroll.Parser, new[]{ "ControllerId", "SelectDiceIndexList", "DiceSideList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgDiceReroll : pb::IMessage<GCGMsgDiceReroll>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgDiceReroll> _parser = new pb::MessageParser<GCGMsgDiceReroll>(() => new GCGMsgDiceReroll());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgDiceReroll> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GCGMsgDiceRerollReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgDiceReroll() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgDiceReroll(GCGMsgDiceReroll other) : this() {
      controllerId_ = other.controllerId_;
      selectDiceIndexList_ = other.selectDiceIndexList_.Clone();
      diceSideList_ = other.diceSideList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgDiceReroll Clone() {
      return new GCGMsgDiceReroll(this);
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 2;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "select_dice_index_list" field.</summary>
    public const int SelectDiceIndexListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_selectDiceIndexList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> selectDiceIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SelectDiceIndexList {
      get { return selectDiceIndexList_; }
    }

    /// <summary>Field number for the "dice_side_list" field.</summary>
    public const int DiceSideListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::OldProtos.GCGDiceSideType> _repeated_diceSideList_codec
        = pb::FieldCodec.ForEnum(50, x => (int) x, x => (global::OldProtos.GCGDiceSideType) x);
    private readonly pbc::RepeatedField<global::OldProtos.GCGDiceSideType> diceSideList_ = new pbc::RepeatedField<global::OldProtos.GCGDiceSideType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.GCGDiceSideType> DiceSideList {
      get { return diceSideList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgDiceReroll);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgDiceReroll other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ControllerId != other.ControllerId) return false;
      if(!selectDiceIndexList_.Equals(other.selectDiceIndexList_)) return false;
      if(!diceSideList_.Equals(other.diceSideList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      hash ^= selectDiceIndexList_.GetHashCode();
      hash ^= diceSideList_.GetHashCode();
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
      selectDiceIndexList_.WriteTo(output, _repeated_selectDiceIndexList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ControllerId);
      }
      diceSideList_.WriteTo(output, _repeated_diceSideList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      selectDiceIndexList_.WriteTo(ref output, _repeated_selectDiceIndexList_codec);
      if (ControllerId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ControllerId);
      }
      diceSideList_.WriteTo(ref output, _repeated_diceSideList_codec);
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
      size += selectDiceIndexList_.CalculateSize(_repeated_selectDiceIndexList_codec);
      size += diceSideList_.CalculateSize(_repeated_diceSideList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgDiceReroll other) {
      if (other == null) {
        return;
      }
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      selectDiceIndexList_.Add(other.selectDiceIndexList_);
      diceSideList_.Add(other.diceSideList_);
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
          case 10:
          case 8: {
            selectDiceIndexList_.AddEntriesFrom(input, _repeated_selectDiceIndexList_codec);
            break;
          }
          case 16: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            diceSideList_.AddEntriesFrom(input, _repeated_diceSideList_codec);
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
          case 10:
          case 8: {
            selectDiceIndexList_.AddEntriesFrom(ref input, _repeated_selectDiceIndexList_codec);
            break;
          }
          case 16: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            diceSideList_.AddEntriesFrom(ref input, _repeated_diceSideList_codec);
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