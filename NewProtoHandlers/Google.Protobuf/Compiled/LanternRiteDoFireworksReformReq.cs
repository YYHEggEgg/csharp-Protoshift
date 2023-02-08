// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternRiteDoFireworksReformReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from LanternRiteDoFireworksReformReq.proto</summary>
  public static partial class LanternRiteDoFireworksReformReqReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternRiteDoFireworksReformReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternRiteDoFireworksReformReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVMYW50ZXJuUml0ZURvRmlyZXdvcmtzUmVmb3JtUmVxLnByb3RvIm4KH0xh",
            "bnRlcm5SaXRlRG9GaXJld29ya3NSZWZvcm1SZXESEAoIc3RhZ2VfaWQYDyAB",
            "KA0SFAoMY2hhbGxlbmdlX2lkGA0gASgNEhEKCWZhY3Rvcl9pZBgJIAEoDRIQ",
            "Cghza2lsbF9pZBgEIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.LanternRiteDoFireworksReformReq), global::NewProtos.LanternRiteDoFireworksReformReq.Parser, new[]{ "StageId", "ChallengeId", "FactorId", "SkillId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8517;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class LanternRiteDoFireworksReformReq : pb::IMessage<LanternRiteDoFireworksReformReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternRiteDoFireworksReformReq> _parser = new pb::MessageParser<LanternRiteDoFireworksReformReq>(() => new LanternRiteDoFireworksReformReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternRiteDoFireworksReformReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.LanternRiteDoFireworksReformReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteDoFireworksReformReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteDoFireworksReformReq(LanternRiteDoFireworksReformReq other) : this() {
      stageId_ = other.stageId_;
      challengeId_ = other.challengeId_;
      factorId_ = other.factorId_;
      skillId_ = other.skillId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteDoFireworksReformReq Clone() {
      return new LanternRiteDoFireworksReformReq(this);
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 15;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 13;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "factor_id" field.</summary>
    public const int FactorIdFieldNumber = 9;
    private uint factorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FactorId {
      get { return factorId_; }
      set {
        factorId_ = value;
      }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 4;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternRiteDoFireworksReformReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternRiteDoFireworksReformReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StageId != other.StageId) return false;
      if (ChallengeId != other.ChallengeId) return false;
      if (FactorId != other.FactorId) return false;
      if (SkillId != other.SkillId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (FactorId != 0) hash ^= FactorId.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
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
      if (SkillId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillId);
      }
      if (FactorId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FactorId);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeId);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (SkillId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillId);
      }
      if (FactorId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FactorId);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeId);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (FactorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FactorId);
      }
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternRiteDoFireworksReformReq other) {
      if (other == null) {
        return;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.FactorId != 0) {
        FactorId = other.FactorId;
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
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
          case 32: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 72: {
            FactorId = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
          case 32: {
            SkillId = input.ReadUInt32();
            break;
          }
          case 72: {
            FactorId = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
