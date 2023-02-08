// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneEntityDisappearNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneEntityDisappearNotify.proto</summary>
  public static partial class SceneEntityDisappearNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneEntityDisappearNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneEntityDisappearNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTY2VuZUVudGl0eURpc2FwcGVhck5vdGlmeS5wcm90bxoQVmlzaW9uVHlw",
            "ZS5wcm90byJlChpTY2VuZUVudGl0eURpc2FwcGVhck5vdGlmeRINCgVwYXJh",
            "bRgPIAEoDRIjCg5kaXNhcHBlYXJfdHlwZRgMIAEoDjILLlZpc2lvblR5cGUS",
            "EwoLZW50aXR5X2xpc3QYDSADKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VisionTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneEntityDisappearNotify), global::NewProtos.SceneEntityDisappearNotify.Parser, new[]{ "Param", "DisappearType", "EntityList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 261;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class SceneEntityDisappearNotify : pb::IMessage<SceneEntityDisappearNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneEntityDisappearNotify> _parser = new pb::MessageParser<SceneEntityDisappearNotify>(() => new SceneEntityDisappearNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneEntityDisappearNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneEntityDisappearNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityDisappearNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityDisappearNotify(SceneEntityDisappearNotify other) : this() {
      param_ = other.param_;
      disappearType_ = other.disappearType_;
      entityList_ = other.entityList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneEntityDisappearNotify Clone() {
      return new SceneEntityDisappearNotify(this);
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 15;
    private uint param_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "disappear_type" field.</summary>
    public const int DisappearTypeFieldNumber = 12;
    private global::NewProtos.VisionType disappearType_ = global::NewProtos.VisionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.VisionType DisappearType {
      get { return disappearType_; }
      set {
        disappearType_ = value;
      }
    }

    /// <summary>Field number for the "entity_list" field.</summary>
    public const int EntityListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_entityList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> entityList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntityList {
      get { return entityList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneEntityDisappearNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneEntityDisappearNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Param != other.Param) return false;
      if (DisappearType != other.DisappearType) return false;
      if(!entityList_.Equals(other.entityList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Param != 0) hash ^= Param.GetHashCode();
      if (DisappearType != global::NewProtos.VisionType.None) hash ^= DisappearType.GetHashCode();
      hash ^= entityList_.GetHashCode();
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
      if (DisappearType != global::NewProtos.VisionType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DisappearType);
      }
      entityList_.WriteTo(output, _repeated_entityList_codec);
      if (Param != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Param);
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
      if (DisappearType != global::NewProtos.VisionType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) DisappearType);
      }
      entityList_.WriteTo(ref output, _repeated_entityList_codec);
      if (Param != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Param);
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
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
      }
      if (DisappearType != global::NewProtos.VisionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DisappearType);
      }
      size += entityList_.CalculateSize(_repeated_entityList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneEntityDisappearNotify other) {
      if (other == null) {
        return;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      if (other.DisappearType != global::NewProtos.VisionType.None) {
        DisappearType = other.DisappearType;
      }
      entityList_.Add(other.entityList_);
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
          case 96: {
            DisappearType = (global::NewProtos.VisionType) input.ReadEnum();
            break;
          }
          case 106:
          case 104: {
            entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
            break;
          }
          case 120: {
            Param = input.ReadUInt32();
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
          case 96: {
            DisappearType = (global::NewProtos.VisionType) input.ReadEnum();
            break;
          }
          case 106:
          case 104: {
            entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
            break;
          }
          case 120: {
            Param = input.ReadUInt32();
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
