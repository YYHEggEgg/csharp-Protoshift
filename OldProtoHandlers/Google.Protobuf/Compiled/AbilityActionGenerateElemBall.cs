// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityActionGenerateElemBall.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AbilityActionGenerateElemBall.proto</summary>
public static partial class AbilityActionGenerateElemBallReflection {

  #region Descriptor
  /// <summary>File descriptor for AbilityActionGenerateElemBall.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AbilityActionGenerateElemBallReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiNBYmlsaXR5QWN0aW9uR2VuZXJhdGVFbGVtQmFsbC5wcm90bxoMVmVjdG9y",
          "LnByb3RvIlwKHUFiaWxpdHlBY3Rpb25HZW5lcmF0ZUVsZW1CYWxsEg8KB3Jv",
          "b21faWQYAiABKA0SFAoDcG9zGAcgASgLMgcuVmVjdG9yEhQKA3JvdBgNIAEo",
          "CzIHLlZlY3RvckIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZw",
          "cm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::AbilityActionGenerateElemBall), global::AbilityActionGenerateElemBall.Parser, new[]{ "RoomId", "Pos", "Rot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class AbilityActionGenerateElemBall : pb::IMessage<AbilityActionGenerateElemBall>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AbilityActionGenerateElemBall> _parser = new pb::MessageParser<AbilityActionGenerateElemBall>(() => new AbilityActionGenerateElemBall());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<AbilityActionGenerateElemBall> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AbilityActionGenerateElemBallReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityActionGenerateElemBall() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityActionGenerateElemBall(AbilityActionGenerateElemBall other) : this() {
    roomId_ = other.roomId_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    rot_ = other.rot_ != null ? other.rot_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public AbilityActionGenerateElemBall Clone() {
    return new AbilityActionGenerateElemBall(this);
  }

  /// <summary>Field number for the "room_id" field.</summary>
  public const int RoomIdFieldNumber = 2;
  private uint roomId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RoomId {
    get { return roomId_; }
    set {
      roomId_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 7;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "rot" field.</summary>
  public const int RotFieldNumber = 13;
  private global::Vector rot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Rot {
    get { return rot_; }
    set {
      rot_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as AbilityActionGenerateElemBall);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(AbilityActionGenerateElemBall other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RoomId != other.RoomId) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    if (!object.Equals(Rot, other.Rot)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RoomId != 0) hash ^= RoomId.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (rot_ != null) hash ^= Rot.GetHashCode();
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
    if (RoomId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(RoomId);
    }
    if (pos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Pos);
    }
    if (rot_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Rot);
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
    if (RoomId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(RoomId);
    }
    if (pos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(Pos);
    }
    if (rot_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(Rot);
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
    if (RoomId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (rot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(AbilityActionGenerateElemBall other) {
    if (other == null) {
      return;
    }
    if (other.RoomId != 0) {
      RoomId = other.RoomId;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.rot_ != null) {
      if (rot_ == null) {
        Rot = new global::Vector();
      }
      Rot.MergeFrom(other.Rot);
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
          RoomId = input.ReadUInt32();
          break;
        }
        case 58: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 106: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
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
          RoomId = input.ReadUInt32();
          break;
        }
        case 58: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 106: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
