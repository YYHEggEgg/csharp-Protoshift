// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HitCollision.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HitCollision.proto</summary>
  public static partial class HitCollisionReflection {

    #region Descriptor
    /// <summary>File descriptor for HitCollision.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HitCollisionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJIaXRDb2xsaXNpb24ucHJvdG8aFUhpdENvbGxpZGVyVHlwZS5wcm90bxoM",
            "VmVjdG9yLnByb3RvIs0BCgxIaXRDb2xsaXNpb24SKwoRaGl0X2NvbGxpZGVy",
            "X3R5cGUYCCABKA4yEC5IaXRDb2xsaWRlclR5cGUSGgoJaGl0X3BvaW50GAcg",
            "ASgLMgcuVmVjdG9yEiAKGGF0dGFja2VlX2hpdF9mb3JjZV9hbmdsZRgCIAEo",
            "AhIYCgdoaXRfZGlyGA0gASgLMgcuVmVjdG9yEiEKGWF0dGFja2VlX2hpdF9l",
            "bnRpdHlfYW5nbGUYDyABKAISFQoNaGl0X2JveF9pbmRleBgEIAEoBUIMqgIJ",
            "T2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HitColliderTypeReflection.Descriptor, global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HitCollision), global::OldProtos.HitCollision.Parser, new[]{ "HitColliderType", "HitPoint", "AttackeeHitForceAngle", "HitDir", "AttackeeHitEntityAngle", "HitBoxIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HitCollision : pb::IMessage<HitCollision>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HitCollision> _parser = new pb::MessageParser<HitCollision>(() => new HitCollision());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HitCollision> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HitCollisionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision(HitCollision other) : this() {
      hitColliderType_ = other.hitColliderType_;
      hitPoint_ = other.hitPoint_ != null ? other.hitPoint_.Clone() : null;
      attackeeHitForceAngle_ = other.attackeeHitForceAngle_;
      hitDir_ = other.hitDir_ != null ? other.hitDir_.Clone() : null;
      attackeeHitEntityAngle_ = other.attackeeHitEntityAngle_;
      hitBoxIndex_ = other.hitBoxIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HitCollision Clone() {
      return new HitCollision(this);
    }

    /// <summary>Field number for the "hit_collider_type" field.</summary>
    public const int HitColliderTypeFieldNumber = 8;
    private global::OldProtos.HitColliderType hitColliderType_ = global::OldProtos.HitColliderType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.HitColliderType HitColliderType {
      get { return hitColliderType_; }
      set {
        hitColliderType_ = value;
      }
    }

    /// <summary>Field number for the "hit_point" field.</summary>
    public const int HitPointFieldNumber = 7;
    private global::OldProtos.Vector hitPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector HitPoint {
      get { return hitPoint_; }
      set {
        hitPoint_ = value;
      }
    }

    /// <summary>Field number for the "attackee_hit_force_angle" field.</summary>
    public const int AttackeeHitForceAngleFieldNumber = 2;
    private float attackeeHitForceAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AttackeeHitForceAngle {
      get { return attackeeHitForceAngle_; }
      set {
        attackeeHitForceAngle_ = value;
      }
    }

    /// <summary>Field number for the "hit_dir" field.</summary>
    public const int HitDirFieldNumber = 13;
    private global::OldProtos.Vector hitDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.Vector HitDir {
      get { return hitDir_; }
      set {
        hitDir_ = value;
      }
    }

    /// <summary>Field number for the "attackee_hit_entity_angle" field.</summary>
    public const int AttackeeHitEntityAngleFieldNumber = 15;
    private float attackeeHitEntityAngle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float AttackeeHitEntityAngle {
      get { return attackeeHitEntityAngle_; }
      set {
        attackeeHitEntityAngle_ = value;
      }
    }

    /// <summary>Field number for the "hit_box_index" field.</summary>
    public const int HitBoxIndexFieldNumber = 4;
    private int hitBoxIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HitBoxIndex {
      get { return hitBoxIndex_; }
      set {
        hitBoxIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HitCollision);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HitCollision other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HitColliderType != other.HitColliderType) return false;
      if (!object.Equals(HitPoint, other.HitPoint)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackeeHitForceAngle, other.AttackeeHitForceAngle)) return false;
      if (!object.Equals(HitDir, other.HitDir)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(AttackeeHitEntityAngle, other.AttackeeHitEntityAngle)) return false;
      if (HitBoxIndex != other.HitBoxIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HitColliderType != global::OldProtos.HitColliderType.Invalid) hash ^= HitColliderType.GetHashCode();
      if (hitPoint_ != null) hash ^= HitPoint.GetHashCode();
      if (AttackeeHitForceAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackeeHitForceAngle);
      if (hitDir_ != null) hash ^= HitDir.GetHashCode();
      if (AttackeeHitEntityAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(AttackeeHitEntityAngle);
      if (HitBoxIndex != 0) hash ^= HitBoxIndex.GetHashCode();
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
      if (AttackeeHitForceAngle != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(AttackeeHitForceAngle);
      }
      if (HitBoxIndex != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HitBoxIndex);
      }
      if (hitPoint_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HitPoint);
      }
      if (HitColliderType != global::OldProtos.HitColliderType.Invalid) {
        output.WriteRawTag(64);
        output.WriteEnum((int) HitColliderType);
      }
      if (hitDir_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(HitDir);
      }
      if (AttackeeHitEntityAngle != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(AttackeeHitEntityAngle);
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
      if (AttackeeHitForceAngle != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(AttackeeHitForceAngle);
      }
      if (HitBoxIndex != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(HitBoxIndex);
      }
      if (hitPoint_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(HitPoint);
      }
      if (HitColliderType != global::OldProtos.HitColliderType.Invalid) {
        output.WriteRawTag(64);
        output.WriteEnum((int) HitColliderType);
      }
      if (hitDir_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(HitDir);
      }
      if (AttackeeHitEntityAngle != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(AttackeeHitEntityAngle);
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
      if (HitColliderType != global::OldProtos.HitColliderType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) HitColliderType);
      }
      if (hitPoint_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HitPoint);
      }
      if (AttackeeHitForceAngle != 0F) {
        size += 1 + 4;
      }
      if (hitDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HitDir);
      }
      if (AttackeeHitEntityAngle != 0F) {
        size += 1 + 4;
      }
      if (HitBoxIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HitBoxIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HitCollision other) {
      if (other == null) {
        return;
      }
      if (other.HitColliderType != global::OldProtos.HitColliderType.Invalid) {
        HitColliderType = other.HitColliderType;
      }
      if (other.hitPoint_ != null) {
        if (hitPoint_ == null) {
          HitPoint = new global::OldProtos.Vector();
        }
        HitPoint.MergeFrom(other.HitPoint);
      }
      if (other.AttackeeHitForceAngle != 0F) {
        AttackeeHitForceAngle = other.AttackeeHitForceAngle;
      }
      if (other.hitDir_ != null) {
        if (hitDir_ == null) {
          HitDir = new global::OldProtos.Vector();
        }
        HitDir.MergeFrom(other.HitDir);
      }
      if (other.AttackeeHitEntityAngle != 0F) {
        AttackeeHitEntityAngle = other.AttackeeHitEntityAngle;
      }
      if (other.HitBoxIndex != 0) {
        HitBoxIndex = other.HitBoxIndex;
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
          case 21: {
            AttackeeHitForceAngle = input.ReadFloat();
            break;
          }
          case 32: {
            HitBoxIndex = input.ReadInt32();
            break;
          }
          case 58: {
            if (hitPoint_ == null) {
              HitPoint = new global::OldProtos.Vector();
            }
            input.ReadMessage(HitPoint);
            break;
          }
          case 64: {
            HitColliderType = (global::OldProtos.HitColliderType) input.ReadEnum();
            break;
          }
          case 106: {
            if (hitDir_ == null) {
              HitDir = new global::OldProtos.Vector();
            }
            input.ReadMessage(HitDir);
            break;
          }
          case 125: {
            AttackeeHitEntityAngle = input.ReadFloat();
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
          case 21: {
            AttackeeHitForceAngle = input.ReadFloat();
            break;
          }
          case 32: {
            HitBoxIndex = input.ReadInt32();
            break;
          }
          case 58: {
            if (hitPoint_ == null) {
              HitPoint = new global::OldProtos.Vector();
            }
            input.ReadMessage(HitPoint);
            break;
          }
          case 64: {
            HitColliderType = (global::OldProtos.HitColliderType) input.ReadEnum();
            break;
          }
          case 106: {
            if (hitDir_ == null) {
              HitDir = new global::OldProtos.Vector();
            }
            input.ReadMessage(HitDir);
            break;
          }
          case 125: {
            AttackeeHitEntityAngle = input.ReadFloat();
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
