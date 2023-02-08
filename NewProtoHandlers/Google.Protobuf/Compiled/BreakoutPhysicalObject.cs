// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BreakoutPhysicalObject.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from BreakoutPhysicalObject.proto</summary>
  public static partial class BreakoutPhysicalObjectReflection {

    #region Descriptor
    /// <summary>File descriptor for BreakoutPhysicalObject.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BreakoutPhysicalObjectReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxCcmVha291dFBoeXNpY2FsT2JqZWN0LnByb3RvGhdCcmVha291dEJyaWNr",
            "SW5mby5wcm90bxokQnJlYWtvdXRQaHlzaWNhbE9iamVjdE1vZGlmaWVyLnBy",
            "b3RvGhVCcmVha291dFZlY3RvcjIucHJvdG8isQMKFkJyZWFrb3V0UGh5c2lj",
            "YWxPYmplY3QSCgoCaWQYASABKA0SDQoFaW5kZXgYAiABKA0SEQoJaXNfYWN0",
            "aXZlGAMgASgIEh0KA3BvcxgEIAEoCzIQLkJyZWFrb3V0VmVjdG9yMhIiCght",
            "b3ZlX2RpchgFIAEoCzIQLkJyZWFrb3V0VmVjdG9yMhINCgVzcGVlZBgGIAEo",
            "BRIUCgxpbml0X3BlZXJfaWQYByABKA0SDQoFc3RhdGUYCCABKA0SFAoMZWxl",
            "bWVudF90eXBlGAkgASgNEh0KFWVsZW1lbnRfcmVhY3Rpb25fYnVmZhgKIAEo",
            "DRI2Cg1tb2RpZmllcl9saXN0GAsgAygLMh8uQnJlYWtvdXRQaHlzaWNhbE9i",
            "amVjdE1vZGlmaWVyEhYKDnRvdGFsX3JvdGF0aW9uGAwgASgFEiUKCWluZm9f",
            "bGlzdBgNIAMoCzISLkJyZWFrb3V0QnJpY2tJbmZvEhgKEGxhc3RfaGl0X3Bl",
            "ZXJfaWQYDiABKA0SHAoUc3BlZWRfaW5jcmVhc2VfY291bnQYDyABKA0SDgoG",
            "b2Zmc2V0GBAgASgFQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.BreakoutBrickInfoReflection.Descriptor, global::NewProtos.BreakoutPhysicalObjectModifierReflection.Descriptor, global::NewProtos.BreakoutVector2Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.BreakoutPhysicalObject), global::NewProtos.BreakoutPhysicalObject.Parser, new[]{ "Id", "Index", "IsActive", "Pos", "MoveDir", "Speed", "InitPeerId", "State", "ElementType", "ElementReactionBuff", "ModifierList", "TotalRotation", "InfoList", "LastHitPeerId", "SpeedIncreaseCount", "Offset" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BreakoutPhysicalObject : pb::IMessage<BreakoutPhysicalObject>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BreakoutPhysicalObject> _parser = new pb::MessageParser<BreakoutPhysicalObject>(() => new BreakoutPhysicalObject());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BreakoutPhysicalObject> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.BreakoutPhysicalObjectReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutPhysicalObject() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutPhysicalObject(BreakoutPhysicalObject other) : this() {
      id_ = other.id_;
      index_ = other.index_;
      isActive_ = other.isActive_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      moveDir_ = other.moveDir_ != null ? other.moveDir_.Clone() : null;
      speed_ = other.speed_;
      initPeerId_ = other.initPeerId_;
      state_ = other.state_;
      elementType_ = other.elementType_;
      elementReactionBuff_ = other.elementReactionBuff_;
      modifierList_ = other.modifierList_.Clone();
      totalRotation_ = other.totalRotation_;
      infoList_ = other.infoList_.Clone();
      lastHitPeerId_ = other.lastHitPeerId_;
      speedIncreaseCount_ = other.speedIncreaseCount_;
      offset_ = other.offset_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutPhysicalObject Clone() {
      return new BreakoutPhysicalObject(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 2;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "is_active" field.</summary>
    public const int IsActiveFieldNumber = 3;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 4;
    private global::NewProtos.BreakoutVector2 pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BreakoutVector2 Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "move_dir" field.</summary>
    public const int MoveDirFieldNumber = 5;
    private global::NewProtos.BreakoutVector2 moveDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BreakoutVector2 MoveDir {
      get { return moveDir_; }
      set {
        moveDir_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 6;
    private int speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "init_peer_id" field.</summary>
    public const int InitPeerIdFieldNumber = 7;
    private uint initPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InitPeerId {
      get { return initPeerId_; }
      set {
        initPeerId_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 8;
    private uint state_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "element_type" field.</summary>
    public const int ElementTypeFieldNumber = 9;
    private uint elementType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementType {
      get { return elementType_; }
      set {
        elementType_ = value;
      }
    }

    /// <summary>Field number for the "element_reaction_buff" field.</summary>
    public const int ElementReactionBuffFieldNumber = 10;
    private uint elementReactionBuff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementReactionBuff {
      get { return elementReactionBuff_; }
      set {
        elementReactionBuff_ = value;
      }
    }

    /// <summary>Field number for the "modifier_list" field.</summary>
    public const int ModifierListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::NewProtos.BreakoutPhysicalObjectModifier> _repeated_modifierList_codec
        = pb::FieldCodec.ForMessage(90, global::NewProtos.BreakoutPhysicalObjectModifier.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.BreakoutPhysicalObjectModifier> modifierList_ = new pbc::RepeatedField<global::NewProtos.BreakoutPhysicalObjectModifier>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.BreakoutPhysicalObjectModifier> ModifierList {
      get { return modifierList_; }
    }

    /// <summary>Field number for the "total_rotation" field.</summary>
    public const int TotalRotationFieldNumber = 12;
    private int totalRotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TotalRotation {
      get { return totalRotation_; }
      set {
        totalRotation_ = value;
      }
    }

    /// <summary>Field number for the "info_list" field.</summary>
    public const int InfoListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::NewProtos.BreakoutBrickInfo> _repeated_infoList_codec
        = pb::FieldCodec.ForMessage(106, global::NewProtos.BreakoutBrickInfo.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.BreakoutBrickInfo> infoList_ = new pbc::RepeatedField<global::NewProtos.BreakoutBrickInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.BreakoutBrickInfo> InfoList {
      get { return infoList_; }
    }

    /// <summary>Field number for the "last_hit_peer_id" field.</summary>
    public const int LastHitPeerIdFieldNumber = 14;
    private uint lastHitPeerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastHitPeerId {
      get { return lastHitPeerId_; }
      set {
        lastHitPeerId_ = value;
      }
    }

    /// <summary>Field number for the "speed_increase_count" field.</summary>
    public const int SpeedIncreaseCountFieldNumber = 15;
    private uint speedIncreaseCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SpeedIncreaseCount {
      get { return speedIncreaseCount_; }
      set {
        speedIncreaseCount_ = value;
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 16;
    private int offset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BreakoutPhysicalObject);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BreakoutPhysicalObject other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Index != other.Index) return false;
      if (IsActive != other.IsActive) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(MoveDir, other.MoveDir)) return false;
      if (Speed != other.Speed) return false;
      if (InitPeerId != other.InitPeerId) return false;
      if (State != other.State) return false;
      if (ElementType != other.ElementType) return false;
      if (ElementReactionBuff != other.ElementReactionBuff) return false;
      if(!modifierList_.Equals(other.modifierList_)) return false;
      if (TotalRotation != other.TotalRotation) return false;
      if(!infoList_.Equals(other.infoList_)) return false;
      if (LastHitPeerId != other.LastHitPeerId) return false;
      if (SpeedIncreaseCount != other.SpeedIncreaseCount) return false;
      if (Offset != other.Offset) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (moveDir_ != null) hash ^= MoveDir.GetHashCode();
      if (Speed != 0) hash ^= Speed.GetHashCode();
      if (InitPeerId != 0) hash ^= InitPeerId.GetHashCode();
      if (State != 0) hash ^= State.GetHashCode();
      if (ElementType != 0) hash ^= ElementType.GetHashCode();
      if (ElementReactionBuff != 0) hash ^= ElementReactionBuff.GetHashCode();
      hash ^= modifierList_.GetHashCode();
      if (TotalRotation != 0) hash ^= TotalRotation.GetHashCode();
      hash ^= infoList_.GetHashCode();
      if (LastHitPeerId != 0) hash ^= LastHitPeerId.GetHashCode();
      if (SpeedIncreaseCount != 0) hash ^= SpeedIncreaseCount.GetHashCode();
      if (Offset != 0) hash ^= Offset.GetHashCode();
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Index);
      }
      if (IsActive != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsActive);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (moveDir_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MoveDir);
      }
      if (Speed != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Speed);
      }
      if (InitPeerId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(InitPeerId);
      }
      if (State != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(State);
      }
      if (ElementType != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ElementType);
      }
      if (ElementReactionBuff != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ElementReactionBuff);
      }
      modifierList_.WriteTo(output, _repeated_modifierList_codec);
      if (TotalRotation != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TotalRotation);
      }
      infoList_.WriteTo(output, _repeated_infoList_codec);
      if (LastHitPeerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LastHitPeerId);
      }
      if (SpeedIncreaseCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SpeedIncreaseCount);
      }
      if (Offset != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(Offset);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Index);
      }
      if (IsActive != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsActive);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (moveDir_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(MoveDir);
      }
      if (Speed != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Speed);
      }
      if (InitPeerId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(InitPeerId);
      }
      if (State != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(State);
      }
      if (ElementType != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ElementType);
      }
      if (ElementReactionBuff != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ElementReactionBuff);
      }
      modifierList_.WriteTo(ref output, _repeated_modifierList_codec);
      if (TotalRotation != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(TotalRotation);
      }
      infoList_.WriteTo(ref output, _repeated_infoList_codec);
      if (LastHitPeerId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LastHitPeerId);
      }
      if (SpeedIncreaseCount != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SpeedIncreaseCount);
      }
      if (Offset != 0) {
        output.WriteRawTag(128, 1);
        output.WriteInt32(Offset);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (IsActive != false) {
        size += 1 + 1;
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (moveDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MoveDir);
      }
      if (Speed != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Speed);
      }
      if (InitPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InitPeerId);
      }
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(State);
      }
      if (ElementType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
      }
      if (ElementReactionBuff != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementReactionBuff);
      }
      size += modifierList_.CalculateSize(_repeated_modifierList_codec);
      if (TotalRotation != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalRotation);
      }
      size += infoList_.CalculateSize(_repeated_infoList_codec);
      if (LastHitPeerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastHitPeerId);
      }
      if (SpeedIncreaseCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpeedIncreaseCount);
      }
      if (Offset != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(Offset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BreakoutPhysicalObject other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::NewProtos.BreakoutVector2();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.moveDir_ != null) {
        if (moveDir_ == null) {
          MoveDir = new global::NewProtos.BreakoutVector2();
        }
        MoveDir.MergeFrom(other.MoveDir);
      }
      if (other.Speed != 0) {
        Speed = other.Speed;
      }
      if (other.InitPeerId != 0) {
        InitPeerId = other.InitPeerId;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.ElementType != 0) {
        ElementType = other.ElementType;
      }
      if (other.ElementReactionBuff != 0) {
        ElementReactionBuff = other.ElementReactionBuff;
      }
      modifierList_.Add(other.modifierList_);
      if (other.TotalRotation != 0) {
        TotalRotation = other.TotalRotation;
      }
      infoList_.Add(other.infoList_);
      if (other.LastHitPeerId != 0) {
        LastHitPeerId = other.LastHitPeerId;
      }
      if (other.SpeedIncreaseCount != 0) {
        SpeedIncreaseCount = other.SpeedIncreaseCount;
      }
      if (other.Offset != 0) {
        Offset = other.Offset;
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
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Index = input.ReadUInt32();
            break;
          }
          case 24: {
            IsActive = input.ReadBool();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::NewProtos.BreakoutVector2();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 42: {
            if (moveDir_ == null) {
              MoveDir = new global::NewProtos.BreakoutVector2();
            }
            input.ReadMessage(MoveDir);
            break;
          }
          case 48: {
            Speed = input.ReadInt32();
            break;
          }
          case 56: {
            InitPeerId = input.ReadUInt32();
            break;
          }
          case 64: {
            State = input.ReadUInt32();
            break;
          }
          case 72: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 80: {
            ElementReactionBuff = input.ReadUInt32();
            break;
          }
          case 90: {
            modifierList_.AddEntriesFrom(input, _repeated_modifierList_codec);
            break;
          }
          case 96: {
            TotalRotation = input.ReadInt32();
            break;
          }
          case 106: {
            infoList_.AddEntriesFrom(input, _repeated_infoList_codec);
            break;
          }
          case 112: {
            LastHitPeerId = input.ReadUInt32();
            break;
          }
          case 120: {
            SpeedIncreaseCount = input.ReadUInt32();
            break;
          }
          case 128: {
            Offset = input.ReadInt32();
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
            Id = input.ReadUInt32();
            break;
          }
          case 16: {
            Index = input.ReadUInt32();
            break;
          }
          case 24: {
            IsActive = input.ReadBool();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::NewProtos.BreakoutVector2();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 42: {
            if (moveDir_ == null) {
              MoveDir = new global::NewProtos.BreakoutVector2();
            }
            input.ReadMessage(MoveDir);
            break;
          }
          case 48: {
            Speed = input.ReadInt32();
            break;
          }
          case 56: {
            InitPeerId = input.ReadUInt32();
            break;
          }
          case 64: {
            State = input.ReadUInt32();
            break;
          }
          case 72: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 80: {
            ElementReactionBuff = input.ReadUInt32();
            break;
          }
          case 90: {
            modifierList_.AddEntriesFrom(ref input, _repeated_modifierList_codec);
            break;
          }
          case 96: {
            TotalRotation = input.ReadInt32();
            break;
          }
          case 106: {
            infoList_.AddEntriesFrom(ref input, _repeated_infoList_codec);
            break;
          }
          case 112: {
            LastHitPeerId = input.ReadUInt32();
            break;
          }
          case 120: {
            SpeedIncreaseCount = input.ReadUInt32();
            break;
          }
          case 128: {
            Offset = input.ReadInt32();
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
