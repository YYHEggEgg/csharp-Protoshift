// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneAvatarStaminaStepReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneAvatarStaminaStepReq.proto</summary>
  public static partial class SceneAvatarStaminaStepReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneAvatarStaminaStepReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneAvatarStaminaStepReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TY2VuZUF2YXRhclN0YW1pbmFTdGVwUmVxLnByb3RvGgxWZWN0b3IucHJv",
            "dG8iSQoZU2NlbmVBdmF0YXJTdGFtaW5hU3RlcFJlcRIWCg51c2VfY2xpZW50",
            "X3JvdBgJIAEoCBIUCgNyb3QYDCABKAsyBy5WZWN0b3JCDKoCCU5ld1Byb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneAvatarStaminaStepReq), global::NewProtos.SceneAvatarStaminaStepReq.Parser, new[]{ "UseClientRot", "Rot" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 257;
  ///   ENET_CHANNEL_ID = 1;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SceneAvatarStaminaStepReq : pb::IMessage<SceneAvatarStaminaStepReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneAvatarStaminaStepReq> _parser = new pb::MessageParser<SceneAvatarStaminaStepReq>(() => new SceneAvatarStaminaStepReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneAvatarStaminaStepReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneAvatarStaminaStepReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarStaminaStepReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarStaminaStepReq(SceneAvatarStaminaStepReq other) : this() {
      useClientRot_ = other.useClientRot_;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneAvatarStaminaStepReq Clone() {
      return new SceneAvatarStaminaStepReq(this);
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

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 12;
    private global::NewProtos.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneAvatarStaminaStepReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneAvatarStaminaStepReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UseClientRot != other.UseClientRot) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (UseClientRot != false) hash ^= UseClientRot.GetHashCode();
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
      if (UseClientRot != false) {
        output.WriteRawTag(72);
        output.WriteBool(UseClientRot);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
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
      if (UseClientRot != false) {
        output.WriteRawTag(72);
        output.WriteBool(UseClientRot);
      }
      if (rot_ != null) {
        output.WriteRawTag(98);
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
    public void MergeFrom(SceneAvatarStaminaStepReq other) {
      if (other == null) {
        return;
      }
      if (other.UseClientRot != false) {
        UseClientRot = other.UseClientRot;
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::NewProtos.Vector();
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
          case 72: {
            UseClientRot = input.ReadBool();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::NewProtos.Vector();
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
          case 72: {
            UseClientRot = input.ReadBool();
            break;
          }
          case 98: {
            if (rot_ == null) {
              Rot = new global::NewProtos.Vector();
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

}

#endregion Designer generated code
