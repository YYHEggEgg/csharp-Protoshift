// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMetaAddOrGetAbilityAndTrigger.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AbilityMetaAddOrGetAbilityAndTrigger.proto</summary>
  public static partial class AbilityMetaAddOrGetAbilityAndTriggerReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMetaAddOrGetAbilityAndTrigger.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMetaAddOrGetAbilityAndTriggerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipBYmlsaXR5TWV0YUFkZE9yR2V0QWJpbGl0eUFuZFRyaWdnZXIucHJvdG8a",
            "E0FiaWxpdHlTdHJpbmcucHJvdG8ikAEKJEFiaWxpdHlNZXRhQWRkT3JHZXRB",
            "YmlsaXR5QW5kVHJpZ2dlchIkCgxhYmlsaXR5X25hbWUYDSABKAsyDi5BYmls",
            "aXR5U3RyaW5nEhgKEHRyaWdnZXJfYXJndW1lbnQYAyABKAISKAoQYWJpbGl0",
            "eV9vdmVycmlkZRgIIAEoCzIOLkFiaWxpdHlTdHJpbmdCDKoCCU9sZFByb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.AbilityStringReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMetaAddOrGetAbilityAndTrigger), global::OldProtos.AbilityMetaAddOrGetAbilityAndTrigger.Parser, new[]{ "AbilityName", "TriggerArgument", "AbilityOverride" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMetaAddOrGetAbilityAndTrigger : pb::IMessage<AbilityMetaAddOrGetAbilityAndTrigger>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMetaAddOrGetAbilityAndTrigger> _parser = new pb::MessageParser<AbilityMetaAddOrGetAbilityAndTrigger>(() => new AbilityMetaAddOrGetAbilityAndTrigger());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMetaAddOrGetAbilityAndTrigger> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AbilityMetaAddOrGetAbilityAndTriggerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaAddOrGetAbilityAndTrigger() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaAddOrGetAbilityAndTrigger(AbilityMetaAddOrGetAbilityAndTrigger other) : this() {
      abilityName_ = other.abilityName_ != null ? other.abilityName_.Clone() : null;
      triggerArgument_ = other.triggerArgument_;
      abilityOverride_ = other.abilityOverride_ != null ? other.abilityOverride_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMetaAddOrGetAbilityAndTrigger Clone() {
      return new AbilityMetaAddOrGetAbilityAndTrigger(this);
    }

    /// <summary>Field number for the "ability_name" field.</summary>
    public const int AbilityNameFieldNumber = 13;
    private global::OldProtos.AbilityString abilityName_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AbilityString AbilityName {
      get { return abilityName_; }
      set {
        abilityName_ = value;
      }
    }

    /// <summary>Field number for the "trigger_argument" field.</summary>
    public const int TriggerArgumentFieldNumber = 3;
    private float triggerArgument_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TriggerArgument {
      get { return triggerArgument_; }
      set {
        triggerArgument_ = value;
      }
    }

    /// <summary>Field number for the "ability_override" field.</summary>
    public const int AbilityOverrideFieldNumber = 8;
    private global::OldProtos.AbilityString abilityOverride_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AbilityString AbilityOverride {
      get { return abilityOverride_; }
      set {
        abilityOverride_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMetaAddOrGetAbilityAndTrigger);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMetaAddOrGetAbilityAndTrigger other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AbilityName, other.AbilityName)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TriggerArgument, other.TriggerArgument)) return false;
      if (!object.Equals(AbilityOverride, other.AbilityOverride)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (abilityName_ != null) hash ^= AbilityName.GetHashCode();
      if (TriggerArgument != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TriggerArgument);
      if (abilityOverride_ != null) hash ^= AbilityOverride.GetHashCode();
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
      if (TriggerArgument != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(TriggerArgument);
      }
      if (abilityOverride_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AbilityOverride);
      }
      if (abilityName_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(AbilityName);
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
      if (TriggerArgument != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(TriggerArgument);
      }
      if (abilityOverride_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(AbilityOverride);
      }
      if (abilityName_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(AbilityName);
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
      if (abilityName_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityName);
      }
      if (TriggerArgument != 0F) {
        size += 1 + 4;
      }
      if (abilityOverride_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AbilityOverride);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMetaAddOrGetAbilityAndTrigger other) {
      if (other == null) {
        return;
      }
      if (other.abilityName_ != null) {
        if (abilityName_ == null) {
          AbilityName = new global::OldProtos.AbilityString();
        }
        AbilityName.MergeFrom(other.AbilityName);
      }
      if (other.TriggerArgument != 0F) {
        TriggerArgument = other.TriggerArgument;
      }
      if (other.abilityOverride_ != null) {
        if (abilityOverride_ == null) {
          AbilityOverride = new global::OldProtos.AbilityString();
        }
        AbilityOverride.MergeFrom(other.AbilityOverride);
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
          case 29: {
            TriggerArgument = input.ReadFloat();
            break;
          }
          case 66: {
            if (abilityOverride_ == null) {
              AbilityOverride = new global::OldProtos.AbilityString();
            }
            input.ReadMessage(AbilityOverride);
            break;
          }
          case 106: {
            if (abilityName_ == null) {
              AbilityName = new global::OldProtos.AbilityString();
            }
            input.ReadMessage(AbilityName);
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
          case 29: {
            TriggerArgument = input.ReadFloat();
            break;
          }
          case 66: {
            if (abilityOverride_ == null) {
              AbilityOverride = new global::OldProtos.AbilityString();
            }
            input.ReadMessage(AbilityOverride);
            break;
          }
          case 106: {
            if (abilityName_ == null) {
              AbilityName = new global::OldProtos.AbilityString();
            }
            input.ReadMessage(AbilityName);
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
