// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForceDragAvatarNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ForceDragAvatarNotify.proto</summary>
  public static partial class ForceDragAvatarNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ForceDragAvatarNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForceDragAvatarNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGb3JjZURyYWdBdmF0YXJOb3RpZnkucHJvdG8aEE1vdGlvbkluZm8ucHJv",
            "dG8isgEKFUZvcmNlRHJhZ0F2YXRhck5vdGlmeRIbChNVbmszMzAwX0lNRk5O",
            "UEdIS0pKGAMgASgEEiAKC21vdGlvbl9pbmZvGAkgASgLMgsuTW90aW9uSW5m",
            "bxIWCg5pc19maXJzdF92YWxpZBgHIAEoCBISCgpzY2VuZV90aW1lGAwgASgN",
            "EhEKCWVudGl0eV9pZBgKIAEoDRIbChNVbmszMzAwX0FGTENMTEZEUEJEGAUg",
            "ASgEQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.MotionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ForceDragAvatarNotify), global::NewProtos.ForceDragAvatarNotify.Parser, new[]{ "Unk3300IMFNNPGHKJJ", "MotionInfo", "IsFirstValid", "SceneTime", "EntityId", "Unk3300AFLCLLFDPBD" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3008;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ForceDragAvatarNotify : pb::IMessage<ForceDragAvatarNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ForceDragAvatarNotify> _parser = new pb::MessageParser<ForceDragAvatarNotify>(() => new ForceDragAvatarNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ForceDragAvatarNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ForceDragAvatarNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify(ForceDragAvatarNotify other) : this() {
      unk3300IMFNNPGHKJJ_ = other.unk3300IMFNNPGHKJJ_;
      motionInfo_ = other.motionInfo_ != null ? other.motionInfo_.Clone() : null;
      isFirstValid_ = other.isFirstValid_;
      sceneTime_ = other.sceneTime_;
      entityId_ = other.entityId_;
      unk3300AFLCLLFDPBD_ = other.unk3300AFLCLLFDPBD_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ForceDragAvatarNotify Clone() {
      return new ForceDragAvatarNotify(this);
    }

    /// <summary>Field number for the "Unk3300_IMFNNPGHKJJ" field.</summary>
    public const int Unk3300IMFNNPGHKJJFieldNumber = 3;
    private ulong unk3300IMFNNPGHKJJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk3300IMFNNPGHKJJ {
      get { return unk3300IMFNNPGHKJJ_; }
      set {
        unk3300IMFNNPGHKJJ_ = value;
      }
    }

    /// <summary>Field number for the "motion_info" field.</summary>
    public const int MotionInfoFieldNumber = 9;
    private global::NewProtos.MotionInfo motionInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.MotionInfo MotionInfo {
      get { return motionInfo_; }
      set {
        motionInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_first_valid" field.</summary>
    public const int IsFirstValidFieldNumber = 7;
    private bool isFirstValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFirstValid {
      get { return isFirstValid_; }
      set {
        isFirstValid_ = value;
      }
    }

    /// <summary>Field number for the "scene_time" field.</summary>
    public const int SceneTimeFieldNumber = 12;
    private uint sceneTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTime {
      get { return sceneTime_; }
      set {
        sceneTime_ = value;
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

    /// <summary>Field number for the "Unk3300_AFLCLLFDPBD" field.</summary>
    public const int Unk3300AFLCLLFDPBDFieldNumber = 5;
    private ulong unk3300AFLCLLFDPBD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Unk3300AFLCLLFDPBD {
      get { return unk3300AFLCLLFDPBD_; }
      set {
        unk3300AFLCLLFDPBD_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ForceDragAvatarNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ForceDragAvatarNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300IMFNNPGHKJJ != other.Unk3300IMFNNPGHKJJ) return false;
      if (!object.Equals(MotionInfo, other.MotionInfo)) return false;
      if (IsFirstValid != other.IsFirstValid) return false;
      if (SceneTime != other.SceneTime) return false;
      if (EntityId != other.EntityId) return false;
      if (Unk3300AFLCLLFDPBD != other.Unk3300AFLCLLFDPBD) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300IMFNNPGHKJJ != 0UL) hash ^= Unk3300IMFNNPGHKJJ.GetHashCode();
      if (motionInfo_ != null) hash ^= MotionInfo.GetHashCode();
      if (IsFirstValid != false) hash ^= IsFirstValid.GetHashCode();
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (Unk3300AFLCLLFDPBD != 0UL) hash ^= Unk3300AFLCLLFDPBD.GetHashCode();
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
      if (Unk3300IMFNNPGHKJJ != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk3300IMFNNPGHKJJ);
      }
      if (Unk3300AFLCLLFDPBD != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Unk3300AFLCLLFDPBD);
      }
      if (IsFirstValid != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFirstValid);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MotionInfo);
      }
      if (EntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneTime);
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
      if (Unk3300IMFNNPGHKJJ != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unk3300IMFNNPGHKJJ);
      }
      if (Unk3300AFLCLLFDPBD != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(Unk3300AFLCLLFDPBD);
      }
      if (IsFirstValid != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFirstValid);
      }
      if (motionInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MotionInfo);
      }
      if (EntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneTime);
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
      if (Unk3300IMFNNPGHKJJ != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300IMFNNPGHKJJ);
      }
      if (motionInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MotionInfo);
      }
      if (IsFirstValid != false) {
        size += 1 + 1;
      }
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (Unk3300AFLCLLFDPBD != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unk3300AFLCLLFDPBD);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ForceDragAvatarNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300IMFNNPGHKJJ != 0UL) {
        Unk3300IMFNNPGHKJJ = other.Unk3300IMFNNPGHKJJ;
      }
      if (other.motionInfo_ != null) {
        if (motionInfo_ == null) {
          MotionInfo = new global::NewProtos.MotionInfo();
        }
        MotionInfo.MergeFrom(other.MotionInfo);
      }
      if (other.IsFirstValid != false) {
        IsFirstValid = other.IsFirstValid;
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.Unk3300AFLCLLFDPBD != 0UL) {
        Unk3300AFLCLLFDPBD = other.Unk3300AFLCLLFDPBD;
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
          case 24: {
            Unk3300IMFNNPGHKJJ = input.ReadUInt64();
            break;
          }
          case 40: {
            Unk3300AFLCLLFDPBD = input.ReadUInt64();
            break;
          }
          case 56: {
            IsFirstValid = input.ReadBool();
            break;
          }
          case 74: {
            if (motionInfo_ == null) {
              MotionInfo = new global::NewProtos.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneTime = input.ReadUInt32();
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
          case 24: {
            Unk3300IMFNNPGHKJJ = input.ReadUInt64();
            break;
          }
          case 40: {
            Unk3300AFLCLLFDPBD = input.ReadUInt64();
            break;
          }
          case 56: {
            IsFirstValid = input.ReadBool();
            break;
          }
          case 74: {
            if (motionInfo_ == null) {
              MotionInfo = new global::NewProtos.MotionInfo();
            }
            input.ReadMessage(MotionInfo);
            break;
          }
          case 80: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneTime = input.ReadUInt32();
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
