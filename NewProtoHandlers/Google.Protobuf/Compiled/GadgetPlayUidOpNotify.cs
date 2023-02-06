// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetPlayUidOpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from GadgetPlayUidOpNotify.proto</summary>
public static partial class GadgetPlayUidOpNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for GadgetPlayUidOpNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static GadgetPlayUidOpNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtHYWRnZXRQbGF5VWlkT3BOb3RpZnkucHJvdG8iggEKFUdhZGdldFBsYXlV",
          "aWRPcE5vdGlmeRIRCglwYXJhbV9zdHIYDiABKAkSCgoCb3AYAiABKA0SEQoJ",
          "ZW50aXR5X2lkGAogASgNEhIKCnBhcmFtX2xpc3QYDCADKA0SEQoJcGxheV90",
          "eXBlGAkgASgNEhAKCHVpZF9saXN0GAUgAygNQhYKFG9yZy5zb3JhcG9pbnRh",
          "LnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::GadgetPlayUidOpNotify), global::GadgetPlayUidOpNotify.Parser, new[]{ "ParamStr", "Op", "EntityId", "ParamList", "PlayType", "UidList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 839;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class GadgetPlayUidOpNotify : pb::IMessage<GadgetPlayUidOpNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<GadgetPlayUidOpNotify> _parser = new pb::MessageParser<GadgetPlayUidOpNotify>(() => new GadgetPlayUidOpNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<GadgetPlayUidOpNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::GadgetPlayUidOpNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayUidOpNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayUidOpNotify(GadgetPlayUidOpNotify other) : this() {
    paramStr_ = other.paramStr_;
    op_ = other.op_;
    entityId_ = other.entityId_;
    paramList_ = other.paramList_.Clone();
    playType_ = other.playType_;
    uidList_ = other.uidList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public GadgetPlayUidOpNotify Clone() {
    return new GadgetPlayUidOpNotify(this);
  }

  /// <summary>Field number for the "param_str" field.</summary>
  public const int ParamStrFieldNumber = 14;
  private string paramStr_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ParamStr {
    get { return paramStr_; }
    set {
      paramStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "op" field.</summary>
  public const int OpFieldNumber = 2;
  private uint op_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Op {
    get { return op_; }
    set {
      op_ = value;
    }
  }

  /// <summary>Field number for the "entity_id" field.</summary>
  public const int EntityIdFieldNumber = 10;
  private uint entityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint EntityId {
    get { return entityId_; }
    set {
      entityId_ = value;
    }
  }

  /// <summary>Field number for the "param_list" field.</summary>
  public const int ParamListFieldNumber = 12;
  private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
      = pb::FieldCodec.ForUInt32(98);
  private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> ParamList {
    get { return paramList_; }
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 9;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  /// <summary>Field number for the "uid_list" field.</summary>
  public const int UidListFieldNumber = 5;
  private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
      = pb::FieldCodec.ForUInt32(42);
  private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> UidList {
    get { return uidList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as GadgetPlayUidOpNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(GadgetPlayUidOpNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ParamStr != other.ParamStr) return false;
    if (Op != other.Op) return false;
    if (EntityId != other.EntityId) return false;
    if(!paramList_.Equals(other.paramList_)) return false;
    if (PlayType != other.PlayType) return false;
    if(!uidList_.Equals(other.uidList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ParamStr.Length != 0) hash ^= ParamStr.GetHashCode();
    if (Op != 0) hash ^= Op.GetHashCode();
    if (EntityId != 0) hash ^= EntityId.GetHashCode();
    hash ^= paramList_.GetHashCode();
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    hash ^= uidList_.GetHashCode();
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
    if (Op != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Op);
    }
    uidList_.WriteTo(output, _repeated_uidList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PlayType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(EntityId);
    }
    paramList_.WriteTo(output, _repeated_paramList_codec);
    if (ParamStr.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(ParamStr);
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
    if (Op != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(Op);
    }
    uidList_.WriteTo(ref output, _repeated_uidList_codec);
    if (PlayType != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(PlayType);
    }
    if (EntityId != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(EntityId);
    }
    paramList_.WriteTo(ref output, _repeated_paramList_codec);
    if (ParamStr.Length != 0) {
      output.WriteRawTag(114);
      output.WriteString(ParamStr);
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
    if (ParamStr.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ParamStr);
    }
    if (Op != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Op);
    }
    if (EntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
    }
    size += paramList_.CalculateSize(_repeated_paramList_codec);
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    size += uidList_.CalculateSize(_repeated_uidList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(GadgetPlayUidOpNotify other) {
    if (other == null) {
      return;
    }
    if (other.ParamStr.Length != 0) {
      ParamStr = other.ParamStr;
    }
    if (other.Op != 0) {
      Op = other.Op;
    }
    if (other.EntityId != 0) {
      EntityId = other.EntityId;
    }
    paramList_.Add(other.paramList_);
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    uidList_.Add(other.uidList_);
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
        case 16: {
          Op = input.ReadUInt32();
          break;
        }
        case 42:
        case 40: {
          uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
          break;
        }
        case 72: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 80: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 98:
        case 96: {
          paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
          break;
        }
        case 114: {
          ParamStr = input.ReadString();
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
        case 16: {
          Op = input.ReadUInt32();
          break;
        }
        case 42:
        case 40: {
          uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
          break;
        }
        case 72: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 80: {
          EntityId = input.ReadUInt32();
          break;
        }
        case 98:
        case 96: {
          paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
          break;
        }
        case 114: {
          ParamStr = input.ReadString();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
