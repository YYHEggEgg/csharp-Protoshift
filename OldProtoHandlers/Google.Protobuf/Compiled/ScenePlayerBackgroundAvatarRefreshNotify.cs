// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayerBackgroundAvatarRefreshNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ScenePlayerBackgroundAvatarRefreshNotify.proto</summary>
public static partial class ScenePlayerBackgroundAvatarRefreshNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ScenePlayerBackgroundAvatarRefreshNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ScenePlayerBackgroundAvatarRefreshNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ci5TY2VuZVBsYXllckJhY2tncm91bmRBdmF0YXJSZWZyZXNoTm90aWZ5LnBy",
          "b3RvGhVTY2VuZUVudGl0eUluZm8ucHJvdG8aEFZpc2lvblR5cGUucHJvdG8i",
          "ggEKKFNjZW5lUGxheWVyQmFja2dyb3VuZEF2YXRhclJlZnJlc2hOb3RpZnkS",
          "JQoLZW50aXR5X2xpc3QYBCADKAsyEC5TY2VuZUVudGl0eUluZm8SIAoLYXBw",
          "ZWFyX3R5cGUYCCABKA4yCy5WaXNpb25UeXBlEg0KBXBhcmFtGAkgASgNQh4K",
          "HGVtdS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::SceneEntityInfoReflection.Descriptor, global::VisionTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ScenePlayerBackgroundAvatarRefreshNotify), global::ScenePlayerBackgroundAvatarRefreshNotify.Parser, new[]{ "EntityList", "AppearType", "Param" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 3274
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class ScenePlayerBackgroundAvatarRefreshNotify : pb::IMessage<ScenePlayerBackgroundAvatarRefreshNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ScenePlayerBackgroundAvatarRefreshNotify> _parser = new pb::MessageParser<ScenePlayerBackgroundAvatarRefreshNotify>(() => new ScenePlayerBackgroundAvatarRefreshNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ScenePlayerBackgroundAvatarRefreshNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ScenePlayerBackgroundAvatarRefreshNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayerBackgroundAvatarRefreshNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayerBackgroundAvatarRefreshNotify(ScenePlayerBackgroundAvatarRefreshNotify other) : this() {
    entityList_ = other.entityList_.Clone();
    appearType_ = other.appearType_;
    param_ = other.param_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ScenePlayerBackgroundAvatarRefreshNotify Clone() {
    return new ScenePlayerBackgroundAvatarRefreshNotify(this);
  }

  /// <summary>Field number for the "entity_list" field.</summary>
  public const int EntityListFieldNumber = 4;
  private static readonly pb::FieldCodec<global::SceneEntityInfo> _repeated_entityList_codec
      = pb::FieldCodec.ForMessage(34, global::SceneEntityInfo.Parser);
  private readonly pbc::RepeatedField<global::SceneEntityInfo> entityList_ = new pbc::RepeatedField<global::SceneEntityInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::SceneEntityInfo> EntityList {
    get { return entityList_; }
  }

  /// <summary>Field number for the "appear_type" field.</summary>
  public const int AppearTypeFieldNumber = 8;
  private global::VisionType appearType_ = global::VisionType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::VisionType AppearType {
    get { return appearType_; }
    set {
      appearType_ = value;
    }
  }

  /// <summary>Field number for the "param" field.</summary>
  public const int ParamFieldNumber = 9;
  private uint param_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Param {
    get { return param_; }
    set {
      param_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ScenePlayerBackgroundAvatarRefreshNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ScenePlayerBackgroundAvatarRefreshNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!entityList_.Equals(other.entityList_)) return false;
    if (AppearType != other.AppearType) return false;
    if (Param != other.Param) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= entityList_.GetHashCode();
    if (AppearType != global::VisionType.None) hash ^= AppearType.GetHashCode();
    if (Param != 0) hash ^= Param.GetHashCode();
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
    entityList_.WriteTo(output, _repeated_entityList_codec);
    if (AppearType != global::VisionType.None) {
      output.WriteRawTag(64);
      output.WriteEnum((int) AppearType);
    }
    if (Param != 0) {
      output.WriteRawTag(72);
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
    entityList_.WriteTo(ref output, _repeated_entityList_codec);
    if (AppearType != global::VisionType.None) {
      output.WriteRawTag(64);
      output.WriteEnum((int) AppearType);
    }
    if (Param != 0) {
      output.WriteRawTag(72);
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
    size += entityList_.CalculateSize(_repeated_entityList_codec);
    if (AppearType != global::VisionType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AppearType);
    }
    if (Param != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ScenePlayerBackgroundAvatarRefreshNotify other) {
    if (other == null) {
      return;
    }
    entityList_.Add(other.entityList_);
    if (other.AppearType != global::VisionType.None) {
      AppearType = other.AppearType;
    }
    if (other.Param != 0) {
      Param = other.Param;
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
        case 34: {
          entityList_.AddEntriesFrom(input, _repeated_entityList_codec);
          break;
        }
        case 64: {
          AppearType = (global::VisionType) input.ReadEnum();
          break;
        }
        case 72: {
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
        case 34: {
          entityList_.AddEntriesFrom(ref input, _repeated_entityList_codec);
          break;
        }
        case 64: {
          AppearType = (global::VisionType) input.ReadEnum();
          break;
        }
        case 72: {
          Param = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
