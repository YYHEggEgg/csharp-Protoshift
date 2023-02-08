// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MassivePropParam.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from MassivePropParam.proto</summary>
  public static partial class MassivePropParamReflection {

    #region Descriptor
    /// <summary>File descriptor for MassivePropParam.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MassivePropParamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZNYXNzaXZlUHJvcFBhcmFtLnByb3RvImMKEE1hc3NpdmVQcm9wUGFyYW0S",
            "DAoEdHlwZRgBIAEoBRIaChJyZWFjdGlvbl9pbmZvX2xpc3QYAiADKA0SEgoK",
            "cGFyYW1fbGlzdBgDIAMoAhIRCglzeW5jX2ZsYWcYBCABKA1CDKoCCU9sZFBy",
            "b3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.MassivePropParam), global::OldProtos.MassivePropParam.Parser, new[]{ "Type", "ReactionInfoList", "ParamList", "SyncFlag" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MassivePropParam : pb::IMessage<MassivePropParam>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MassivePropParam> _parser = new pb::MessageParser<MassivePropParam>(() => new MassivePropParam());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MassivePropParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.MassivePropParamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassivePropParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassivePropParam(MassivePropParam other) : this() {
      type_ = other.type_;
      reactionInfoList_ = other.reactionInfoList_.Clone();
      paramList_ = other.paramList_.Clone();
      syncFlag_ = other.syncFlag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MassivePropParam Clone() {
      return new MassivePropParam(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private int type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "reaction_info_list" field.</summary>
    public const int ReactionInfoListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_reactionInfoList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> reactionInfoList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ReactionInfoList {
      get { return reactionInfoList_; }
    }

    /// <summary>Field number for the "param_list" field.</summary>
    public const int ParamListFieldNumber = 3;
    private static readonly pb::FieldCodec<float> _repeated_paramList_codec
        = pb::FieldCodec.ForFloat(26);
    private readonly pbc::RepeatedField<float> paramList_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<float> ParamList {
      get { return paramList_; }
    }

    /// <summary>Field number for the "sync_flag" field.</summary>
    public const int SyncFlagFieldNumber = 4;
    private uint syncFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SyncFlag {
      get { return syncFlag_; }
      set {
        syncFlag_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MassivePropParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MassivePropParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if(!reactionInfoList_.Equals(other.reactionInfoList_)) return false;
      if(!paramList_.Equals(other.paramList_)) return false;
      if (SyncFlag != other.SyncFlag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= reactionInfoList_.GetHashCode();
      hash ^= paramList_.GetHashCode();
      if (SyncFlag != 0) hash ^= SyncFlag.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Type);
      }
      reactionInfoList_.WriteTo(output, _repeated_reactionInfoList_codec);
      paramList_.WriteTo(output, _repeated_paramList_codec);
      if (SyncFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SyncFlag);
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Type);
      }
      reactionInfoList_.WriteTo(ref output, _repeated_reactionInfoList_codec);
      paramList_.WriteTo(ref output, _repeated_paramList_codec);
      if (SyncFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SyncFlag);
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
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      size += reactionInfoList_.CalculateSize(_repeated_reactionInfoList_codec);
      size += paramList_.CalculateSize(_repeated_paramList_codec);
      if (SyncFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SyncFlag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MassivePropParam other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      reactionInfoList_.Add(other.reactionInfoList_);
      paramList_.Add(other.paramList_);
      if (other.SyncFlag != 0) {
        SyncFlag = other.SyncFlag;
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
            Type = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            reactionInfoList_.AddEntriesFrom(input, _repeated_reactionInfoList_codec);
            break;
          }
          case 26:
          case 29: {
            paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
            break;
          }
          case 32: {
            SyncFlag = input.ReadUInt32();
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
            Type = input.ReadInt32();
            break;
          }
          case 18:
          case 16: {
            reactionInfoList_.AddEntriesFrom(ref input, _repeated_reactionInfoList_codec);
            break;
          }
          case 26:
          case 29: {
            paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
            break;
          }
          case 32: {
            SyncFlag = input.ReadUInt32();
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
