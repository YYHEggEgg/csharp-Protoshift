// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneAvatarStaminaStepRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneAvatarStaminaStepRsp.proto</summary>
public static partial class SceneAvatarStaminaStepRspReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneAvatarStaminaStepRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneAvatarStaminaStepRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9TY2VuZUF2YXRhclN0YW1pbmFTdGVwUnNwLnByb3RvGgxWZWN0b3IucHJv",
          "dG8iWgoZU2NlbmVBdmF0YXJTdGFtaW5hU3RlcFJzcBIWCg51c2VfY2xpZW50",
          "X3JvdBgJIAEoCBIPCgdyZXRjb2RlGAcgASgFEhQKA3JvdBgLIAEoCzIHLlZl",
          "Y3RvckIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneAvatarStaminaStepRsp), global::SceneAvatarStaminaStepRsp.Parser, new[]{ "UseClientRot", "Retcode", "Rot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 231
/// EnetChannelId: 1
/// EnetIsReliable: true
/// </summary>
public sealed partial class SceneAvatarStaminaStepRsp : pb::IMessage<SceneAvatarStaminaStepRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneAvatarStaminaStepRsp> _parser = new pb::MessageParser<SceneAvatarStaminaStepRsp>(() => new SceneAvatarStaminaStepRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneAvatarStaminaStepRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneAvatarStaminaStepRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAvatarStaminaStepRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAvatarStaminaStepRsp(SceneAvatarStaminaStepRsp other) : this() {
    useClientRot_ = other.useClientRot_;
    retcode_ = other.retcode_;
    rot_ = other.rot_ != null ? other.rot_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneAvatarStaminaStepRsp Clone() {
    return new SceneAvatarStaminaStepRsp(this);
  }

  /// <summary>Field number for the "use_client_rot" field.</summary>
  public const int UseClientRotFieldNumber = 9;
  private bool useClientRot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool UseClientRot {
    get { return useClientRot_; }
    set {
      useClientRot_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 7;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "rot" field.</summary>
  public const int RotFieldNumber = 11;
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
    return Equals(other as SceneAvatarStaminaStepRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneAvatarStaminaStepRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (UseClientRot != other.UseClientRot) return false;
    if (Retcode != other.Retcode) return false;
    if (!object.Equals(Rot, other.Rot)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (UseClientRot != false) hash ^= UseClientRot.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
    if (Retcode != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(Retcode);
    }
    if (UseClientRot != false) {
      output.WriteRawTag(72);
      output.WriteBool(UseClientRot);
    }
    if (rot_ != null) {
      output.WriteRawTag(90);
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
    if (Retcode != 0) {
      output.WriteRawTag(56);
      output.WriteInt32(Retcode);
    }
    if (UseClientRot != false) {
      output.WriteRawTag(72);
      output.WriteBool(UseClientRot);
    }
    if (rot_ != null) {
      output.WriteRawTag(90);
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
    if (UseClientRot != false) {
      size += 1 + 1;
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
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
  public void MergeFrom(SceneAvatarStaminaStepRsp other) {
    if (other == null) {
      return;
    }
    if (other.UseClientRot != false) {
      UseClientRot = other.UseClientRot;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
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
        case 56: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          UseClientRot = input.ReadBool();
          break;
        }
        case 90: {
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
        case 56: {
          Retcode = input.ReadInt32();
          break;
        }
        case 72: {
          UseClientRot = input.ReadBool();
          break;
        }
        case 90: {
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
