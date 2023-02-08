// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProudSkillExtraLevelNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ProudSkillExtraLevelNotify.proto</summary>
  public static partial class ProudSkillExtraLevelNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ProudSkillExtraLevelNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProudSkillExtraLevelNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQcm91ZFNraWxsRXh0cmFMZXZlbE5vdGlmeS5wcm90byJxChpQcm91ZFNr",
            "aWxsRXh0cmFMZXZlbE5vdGlmeRITCgthdmF0YXJfZ3VpZBgNIAEoBBITCgtl",
            "eHRyYV9sZXZlbBgEIAEoDRITCgt0YWxlbnRfdHlwZRgIIAEoDRIUCgx0YWxl",
            "bnRfaW5kZXgYAiABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ProudSkillExtraLevelNotify), global::NewProtos.ProudSkillExtraLevelNotify.Parser, new[]{ "AvatarGuid", "ExtraLevel", "TalentType", "TalentIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1025;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ProudSkillExtraLevelNotify : pb::IMessage<ProudSkillExtraLevelNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProudSkillExtraLevelNotify> _parser = new pb::MessageParser<ProudSkillExtraLevelNotify>(() => new ProudSkillExtraLevelNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProudSkillExtraLevelNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ProudSkillExtraLevelNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillExtraLevelNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillExtraLevelNotify(ProudSkillExtraLevelNotify other) : this() {
      avatarGuid_ = other.avatarGuid_;
      extraLevel_ = other.extraLevel_;
      talentType_ = other.talentType_;
      talentIndex_ = other.talentIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillExtraLevelNotify Clone() {
      return new ProudSkillExtraLevelNotify(this);
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 13;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "extra_level" field.</summary>
    public const int ExtraLevelFieldNumber = 4;
    private uint extraLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ExtraLevel {
      get { return extraLevel_; }
      set {
        extraLevel_ = value;
      }
    }

    /// <summary>Field number for the "talent_type" field.</summary>
    public const int TalentTypeFieldNumber = 8;
    private uint talentType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TalentType {
      get { return talentType_; }
      set {
        talentType_ = value;
      }
    }

    /// <summary>Field number for the "talent_index" field.</summary>
    public const int TalentIndexFieldNumber = 2;
    private uint talentIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TalentIndex {
      get { return talentIndex_; }
      set {
        talentIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProudSkillExtraLevelNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProudSkillExtraLevelNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
      if (ExtraLevel != other.ExtraLevel) return false;
      if (TalentType != other.TalentType) return false;
      if (TalentIndex != other.TalentIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (ExtraLevel != 0) hash ^= ExtraLevel.GetHashCode();
      if (TalentType != 0) hash ^= TalentType.GetHashCode();
      if (TalentIndex != 0) hash ^= TalentIndex.GetHashCode();
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
      if (TalentIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TalentIndex);
      }
      if (ExtraLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ExtraLevel);
      }
      if (TalentType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TalentType);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(AvatarGuid);
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
      if (TalentIndex != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TalentIndex);
      }
      if (ExtraLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ExtraLevel);
      }
      if (TalentType != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(TalentType);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (ExtraLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExtraLevel);
      }
      if (TalentType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TalentType);
      }
      if (TalentIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TalentIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProudSkillExtraLevelNotify other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.ExtraLevel != 0) {
        ExtraLevel = other.ExtraLevel;
      }
      if (other.TalentType != 0) {
        TalentType = other.TalentType;
      }
      if (other.TalentIndex != 0) {
        TalentIndex = other.TalentIndex;
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
            TalentIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            ExtraLevel = input.ReadUInt32();
            break;
          }
          case 64: {
            TalentType = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarGuid = input.ReadUInt64();
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
            TalentIndex = input.ReadUInt32();
            break;
          }
          case 32: {
            ExtraLevel = input.ReadUInt32();
            break;
          }
          case 64: {
            TalentType = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarGuid = input.ReadUInt64();
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
