// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BeginCameraSceneLookWithTemplateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from BeginCameraSceneLookWithTemplateNotify.proto</summary>
  public static partial class BeginCameraSceneLookWithTemplateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BeginCameraSceneLookWithTemplateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeginCameraSceneLookWithTemplateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixCZWdpbkNhbWVyYVNjZW5lTG9va1dpdGhUZW1wbGF0ZU5vdGlmeS5wcm90",
            "bxoMVmVjdG9yLnByb3RvIu4CCiZCZWdpbkNhbWVyYVNjZW5lTG9va1dpdGhU",
            "ZW1wbGF0ZU5vdGlmeRJHCgtmb2xsb3dfdHlwZRgFIAEoDjIyLkJlZ2luQ2Ft",
            "ZXJhU2NlbmVMb29rV2l0aFRlbXBsYXRlTm90aWZ5LkZvbGxvd1R5cGUSEQoJ",
            "ZW50aXR5X2lkGAcgASgNEiQKE1VuazMzMDBfRkpERkdMTkxNQk4YASABKAsy",
            "By5WZWN0b3ISEwoLdGVtcGxhdGVfaWQYDSABKA0SFAoMb3RoZXJfcGFyYW1z",
            "GAwgAygJEiQKE1VuazMzMDBfUFBDSURJQ01JRU4YCiABKAsyBy5WZWN0b3Ii",
            "cQoKRm9sbG93VHlwZRIfChtGT0xMT1dfVFlQRV9JTklUX0ZPTExPV19QT1MQ",
            "ABIeChpGT0xMT1dfVFlQRV9TRVRfRk9MTE9XX1BPUxABEiIKHkZPTExPV19U",
            "WVBFX1NFVF9BQlNfRk9MTE9XX1BPUxACQgyqAglOZXdQcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.BeginCameraSceneLookWithTemplateNotify), global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Parser, new[]{ "FollowType", "EntityId", "Unk3300FJDFGLNLMBN", "TemplateId", "OtherParams", "Unk3300PPCIDICMIEN" }, null, new[]{ typeof(global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3342;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class BeginCameraSceneLookWithTemplateNotify : pb::IMessage<BeginCameraSceneLookWithTemplateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BeginCameraSceneLookWithTemplateNotify> _parser = new pb::MessageParser<BeginCameraSceneLookWithTemplateNotify>(() => new BeginCameraSceneLookWithTemplateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BeginCameraSceneLookWithTemplateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.BeginCameraSceneLookWithTemplateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookWithTemplateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookWithTemplateNotify(BeginCameraSceneLookWithTemplateNotify other) : this() {
      followType_ = other.followType_;
      entityId_ = other.entityId_;
      unk3300FJDFGLNLMBN_ = other.unk3300FJDFGLNLMBN_ != null ? other.unk3300FJDFGLNLMBN_.Clone() : null;
      templateId_ = other.templateId_;
      otherParams_ = other.otherParams_.Clone();
      unk3300PPCIDICMIEN_ = other.unk3300PPCIDICMIEN_ != null ? other.unk3300PPCIDICMIEN_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookWithTemplateNotify Clone() {
      return new BeginCameraSceneLookWithTemplateNotify(this);
    }

    /// <summary>Field number for the "follow_type" field.</summary>
    public const int FollowTypeFieldNumber = 5;
    private global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType followType_ = global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType FollowType {
      get { return followType_; }
      set {
        followType_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 7;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FJDFGLNLMBN" field.</summary>
    public const int Unk3300FJDFGLNLMBNFieldNumber = 1;
    private global::NewProtos.Vector unk3300FJDFGLNLMBN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Unk3300FJDFGLNLMBN {
      get { return unk3300FJDFGLNLMBN_; }
      set {
        unk3300FJDFGLNLMBN_ = value;
      }
    }

    /// <summary>Field number for the "template_id" field.</summary>
    public const int TemplateIdFieldNumber = 13;
    private uint templateId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TemplateId {
      get { return templateId_; }
      set {
        templateId_ = value;
      }
    }

    /// <summary>Field number for the "other_params" field.</summary>
    public const int OtherParamsFieldNumber = 12;
    private static readonly pb::FieldCodec<string> _repeated_otherParams_codec
        = pb::FieldCodec.ForString(98);
    private readonly pbc::RepeatedField<string> otherParams_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> OtherParams {
      get { return otherParams_; }
    }

    /// <summary>Field number for the "Unk3300_PPCIDICMIEN" field.</summary>
    public const int Unk3300PPCIDICMIENFieldNumber = 10;
    private global::NewProtos.Vector unk3300PPCIDICMIEN_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector Unk3300PPCIDICMIEN {
      get { return unk3300PPCIDICMIEN_; }
      set {
        unk3300PPCIDICMIEN_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BeginCameraSceneLookWithTemplateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BeginCameraSceneLookWithTemplateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FollowType != other.FollowType) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(Unk3300FJDFGLNLMBN, other.Unk3300FJDFGLNLMBN)) return false;
      if (TemplateId != other.TemplateId) return false;
      if(!otherParams_.Equals(other.otherParams_)) return false;
      if (!object.Equals(Unk3300PPCIDICMIEN, other.Unk3300PPCIDICMIEN)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FollowType != global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos) hash ^= FollowType.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (unk3300FJDFGLNLMBN_ != null) hash ^= Unk3300FJDFGLNLMBN.GetHashCode();
      if (TemplateId != 0) hash ^= TemplateId.GetHashCode();
      hash ^= otherParams_.GetHashCode();
      if (unk3300PPCIDICMIEN_ != null) hash ^= Unk3300PPCIDICMIEN.GetHashCode();
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
      if (unk3300FJDFGLNLMBN_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unk3300FJDFGLNLMBN);
      }
      if (FollowType != global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FollowType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (unk3300PPCIDICMIEN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3300PPCIDICMIEN);
      }
      otherParams_.WriteTo(output, _repeated_otherParams_codec);
      if (TemplateId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TemplateId);
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
      if (unk3300FJDFGLNLMBN_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Unk3300FJDFGLNLMBN);
      }
      if (FollowType != global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos) {
        output.WriteRawTag(40);
        output.WriteEnum((int) FollowType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (unk3300PPCIDICMIEN_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Unk3300PPCIDICMIEN);
      }
      otherParams_.WriteTo(ref output, _repeated_otherParams_codec);
      if (TemplateId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TemplateId);
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
      if (FollowType != global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FollowType);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (unk3300FJDFGLNLMBN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300FJDFGLNLMBN);
      }
      if (TemplateId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TemplateId);
      }
      size += otherParams_.CalculateSize(_repeated_otherParams_codec);
      if (unk3300PPCIDICMIEN_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Unk3300PPCIDICMIEN);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BeginCameraSceneLookWithTemplateNotify other) {
      if (other == null) {
        return;
      }
      if (other.FollowType != global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType.InitFollowPos) {
        FollowType = other.FollowType;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.unk3300FJDFGLNLMBN_ != null) {
        if (unk3300FJDFGLNLMBN_ == null) {
          Unk3300FJDFGLNLMBN = new global::NewProtos.Vector();
        }
        Unk3300FJDFGLNLMBN.MergeFrom(other.Unk3300FJDFGLNLMBN);
      }
      if (other.TemplateId != 0) {
        TemplateId = other.TemplateId;
      }
      otherParams_.Add(other.otherParams_);
      if (other.unk3300PPCIDICMIEN_ != null) {
        if (unk3300PPCIDICMIEN_ == null) {
          Unk3300PPCIDICMIEN = new global::NewProtos.Vector();
        }
        Unk3300PPCIDICMIEN.MergeFrom(other.Unk3300PPCIDICMIEN);
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
          case 10: {
            if (unk3300FJDFGLNLMBN_ == null) {
              Unk3300FJDFGLNLMBN = new global::NewProtos.Vector();
            }
            input.ReadMessage(Unk3300FJDFGLNLMBN);
            break;
          }
          case 40: {
            FollowType = (global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType) input.ReadEnum();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (unk3300PPCIDICMIEN_ == null) {
              Unk3300PPCIDICMIEN = new global::NewProtos.Vector();
            }
            input.ReadMessage(Unk3300PPCIDICMIEN);
            break;
          }
          case 98: {
            otherParams_.AddEntriesFrom(input, _repeated_otherParams_codec);
            break;
          }
          case 104: {
            TemplateId = input.ReadUInt32();
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
          case 10: {
            if (unk3300FJDFGLNLMBN_ == null) {
              Unk3300FJDFGLNLMBN = new global::NewProtos.Vector();
            }
            input.ReadMessage(Unk3300FJDFGLNLMBN);
            break;
          }
          case 40: {
            FollowType = (global::NewProtos.BeginCameraSceneLookWithTemplateNotify.Types.FollowType) input.ReadEnum();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 82: {
            if (unk3300PPCIDICMIEN_ == null) {
              Unk3300PPCIDICMIEN = new global::NewProtos.Vector();
            }
            input.ReadMessage(Unk3300PPCIDICMIEN);
            break;
          }
          case 98: {
            otherParams_.AddEntriesFrom(ref input, _repeated_otherParams_codec);
            break;
          }
          case 104: {
            TemplateId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BeginCameraSceneLookWithTemplateNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum FollowType {
        [pbr::OriginalName("FOLLOW_TYPE_INIT_FOLLOW_POS")] InitFollowPos = 0,
        [pbr::OriginalName("FOLLOW_TYPE_SET_FOLLOW_POS")] SetFollowPos = 1,
        [pbr::OriginalName("FOLLOW_TYPE_SET_ABS_FOLLOW_POS")] SetAbsFollowPos = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
