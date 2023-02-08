// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleUidOpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ScenePlayBattleUidOpNotify.proto</summary>
  public static partial class ScenePlayBattleUidOpNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePlayBattleUidOpNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePlayBattleUidOpNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBTY2VuZVBsYXlCYXR0bGVVaWRPcE5vdGlmeS5wcm90byLgAQoaU2NlbmVQ",
            "bGF5QmF0dGxlVWlkT3BOb3RpZnkSCgoCb3AYBSABKA0SFgoOcGFyYW1fZHVy",
            "YXRpb24YCiABKA0SDwoHcGxheV9pZBgNIAEoDRIZChFwYXJhbV90YXJnZXRf",
            "bGlzdBgMIAMoDRIRCgllbnRpdHlfaWQYAiABKA0SEgoKcGFyYW1fbGlzdBgJ",
            "IAMoDRIRCglwYXJhbV9zdHIYCyABKAkSEwoLcGFyYW1faW5kZXgYDyABKA0S",
            "EAoIdWlkX2xpc3QYBiADKA0SEQoJcGxheV90eXBlGA4gASgNQgyqAglOZXdQ",
            "cm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ScenePlayBattleUidOpNotify), global::NewProtos.ScenePlayBattleUidOpNotify.Parser, new[]{ "Op", "ParamDuration", "PlayId", "ParamTargetList", "EntityId", "ParamList", "ParamStr", "ParamIndex", "UidList", "PlayType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 4449;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ScenePlayBattleUidOpNotify : pb::IMessage<ScenePlayBattleUidOpNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScenePlayBattleUidOpNotify> _parser = new pb::MessageParser<ScenePlayBattleUidOpNotify>(() => new ScenePlayBattleUidOpNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScenePlayBattleUidOpNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ScenePlayBattleUidOpNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleUidOpNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleUidOpNotify(ScenePlayBattleUidOpNotify other) : this() {
      op_ = other.op_;
      paramDuration_ = other.paramDuration_;
      playId_ = other.playId_;
      paramTargetList_ = other.paramTargetList_.Clone();
      entityId_ = other.entityId_;
      paramList_ = other.paramList_.Clone();
      paramStr_ = other.paramStr_;
      paramIndex_ = other.paramIndex_;
      uidList_ = other.uidList_.Clone();
      playType_ = other.playType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayBattleUidOpNotify Clone() {
      return new ScenePlayBattleUidOpNotify(this);
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 5;
    private uint op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "param_duration" field.</summary>
    public const int ParamDurationFieldNumber = 10;
    private uint paramDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParamDuration {
      get { return paramDuration_; }
      set {
        paramDuration_ = value;
      }
    }

    /// <summary>Field number for the "play_id" field.</summary>
    public const int PlayIdFieldNumber = 13;
    private uint playId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayId {
      get { return playId_; }
      set {
        playId_ = value;
      }
    }

    /// <summary>Field number for the "param_target_list" field.</summary>
    public const int ParamTargetListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_paramTargetList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> paramTargetList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ParamTargetList {
      get { return paramTargetList_; }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
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
    public const int ParamListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ParamList {
      get { return paramList_; }
    }

    /// <summary>Field number for the "param_str" field.</summary>
    public const int ParamStrFieldNumber = 11;
    private string paramStr_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ParamStr {
      get { return paramStr_; }
      set {
        paramStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "param_index" field.</summary>
    public const int ParamIndexFieldNumber = 15;
    private uint paramIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParamIndex {
      get { return paramIndex_; }
      set {
        paramIndex_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    /// <summary>Field number for the "play_type" field.</summary>
    public const int PlayTypeFieldNumber = 14;
    private uint playType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayType {
      get { return playType_; }
      set {
        playType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScenePlayBattleUidOpNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScenePlayBattleUidOpNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Op != other.Op) return false;
      if (ParamDuration != other.ParamDuration) return false;
      if (PlayId != other.PlayId) return false;
      if(!paramTargetList_.Equals(other.paramTargetList_)) return false;
      if (EntityId != other.EntityId) return false;
      if(!paramList_.Equals(other.paramList_)) return false;
      if (ParamStr != other.ParamStr) return false;
      if (ParamIndex != other.ParamIndex) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      if (PlayType != other.PlayType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Op != 0) hash ^= Op.GetHashCode();
      if (ParamDuration != 0) hash ^= ParamDuration.GetHashCode();
      if (PlayId != 0) hash ^= PlayId.GetHashCode();
      hash ^= paramTargetList_.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      hash ^= paramList_.GetHashCode();
      if (ParamStr.Length != 0) hash ^= ParamStr.GetHashCode();
      if (ParamIndex != 0) hash ^= ParamIndex.GetHashCode();
      hash ^= uidList_.GetHashCode();
      if (PlayType != 0) hash ^= PlayType.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (Op != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Op);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      paramList_.WriteTo(output, _repeated_paramList_codec);
      if (ParamDuration != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ParamDuration);
      }
      if (ParamStr.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ParamStr);
      }
      paramTargetList_.WriteTo(output, _repeated_paramTargetList_codec);
      if (PlayId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PlayId);
      }
      if (PlayType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayType);
      }
      if (ParamIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ParamIndex);
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
      if (EntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(EntityId);
      }
      if (Op != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Op);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      paramList_.WriteTo(ref output, _repeated_paramList_codec);
      if (ParamDuration != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ParamDuration);
      }
      if (ParamStr.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(ParamStr);
      }
      paramTargetList_.WriteTo(ref output, _repeated_paramTargetList_codec);
      if (PlayId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PlayId);
      }
      if (PlayType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PlayType);
      }
      if (ParamIndex != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ParamIndex);
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
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Op);
      }
      if (ParamDuration != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParamDuration);
      }
      if (PlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayId);
      }
      size += paramTargetList_.CalculateSize(_repeated_paramTargetList_codec);
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      size += paramList_.CalculateSize(_repeated_paramList_codec);
      if (ParamStr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParamStr);
      }
      if (ParamIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParamIndex);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (PlayType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScenePlayBattleUidOpNotify other) {
      if (other == null) {
        return;
      }
      if (other.Op != 0) {
        Op = other.Op;
      }
      if (other.ParamDuration != 0) {
        ParamDuration = other.ParamDuration;
      }
      if (other.PlayId != 0) {
        PlayId = other.PlayId;
      }
      paramTargetList_.Add(other.paramTargetList_);
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      paramList_.Add(other.paramList_);
      if (other.ParamStr.Length != 0) {
        ParamStr = other.ParamStr;
      }
      if (other.ParamIndex != 0) {
        ParamIndex = other.ParamIndex;
      }
      uidList_.Add(other.uidList_);
      if (other.PlayType != 0) {
        PlayType = other.PlayType;
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
          case 16: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            Op = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 74:
          case 72: {
            paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
            break;
          }
          case 80: {
            ParamDuration = input.ReadUInt32();
            break;
          }
          case 90: {
            ParamStr = input.ReadString();
            break;
          }
          case 98:
          case 96: {
            paramTargetList_.AddEntriesFrom(input, _repeated_paramTargetList_codec);
            break;
          }
          case 104: {
            PlayId = input.ReadUInt32();
            break;
          }
          case 112: {
            PlayType = input.ReadUInt32();
            break;
          }
          case 120: {
            ParamIndex = input.ReadUInt32();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            Op = input.ReadUInt32();
            break;
          }
          case 50:
          case 48: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 74:
          case 72: {
            paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
            break;
          }
          case 80: {
            ParamDuration = input.ReadUInt32();
            break;
          }
          case 90: {
            ParamStr = input.ReadString();
            break;
          }
          case 98:
          case 96: {
            paramTargetList_.AddEntriesFrom(ref input, _repeated_paramTargetList_codec);
            break;
          }
          case 104: {
            PlayId = input.ReadUInt32();
            break;
          }
          case 112: {
            PlayType = input.ReadUInt32();
            break;
          }
          case 120: {
            ParamIndex = input.ReadUInt32();
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
