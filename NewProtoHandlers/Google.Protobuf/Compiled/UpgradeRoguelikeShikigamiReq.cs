// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UpgradeRoguelikeShikigamiReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from UpgradeRoguelikeShikigamiReq.proto</summary>
  public static partial class UpgradeRoguelikeShikigamiReqReflection {

    #region Descriptor
    /// <summary>File descriptor for UpgradeRoguelikeShikigamiReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UpgradeRoguelikeShikigamiReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJVcGdyYWRlUm9ndWVsaWtlU2hpa2lnYW1pUmVxLnByb3RvIlEKHFVwZ3Jh",
            "ZGVSb2d1ZWxpa2VTaGlraWdhbWlSZXESGgoSc2hpa2lnYW1pX2dyb3VwX2lk",
            "GA8gASgNEhUKDXVwZ3JhZGVfbGV2ZWwYCiABKA1CDKoCCU5ld1Byb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.UpgradeRoguelikeShikigamiReq), global::NewProtos.UpgradeRoguelikeShikigamiReq.Parser, new[]{ "ShikigamiGroupId", "UpgradeLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 8282;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class UpgradeRoguelikeShikigamiReq : pb::IMessage<UpgradeRoguelikeShikigamiReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UpgradeRoguelikeShikigamiReq> _parser = new pb::MessageParser<UpgradeRoguelikeShikigamiReq>(() => new UpgradeRoguelikeShikigamiReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UpgradeRoguelikeShikigamiReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.UpgradeRoguelikeShikigamiReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq(UpgradeRoguelikeShikigamiReq other) : this() {
      shikigamiGroupId_ = other.shikigamiGroupId_;
      upgradeLevel_ = other.upgradeLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UpgradeRoguelikeShikigamiReq Clone() {
      return new UpgradeRoguelikeShikigamiReq(this);
    }

    /// <summary>Field number for the "shikigami_group_id" field.</summary>
    public const int ShikigamiGroupIdFieldNumber = 15;
    private uint shikigamiGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShikigamiGroupId {
      get { return shikigamiGroupId_; }
      set {
        shikigamiGroupId_ = value;
      }
    }

    /// <summary>Field number for the "upgrade_level" field.</summary>
    public const int UpgradeLevelFieldNumber = 10;
    private uint upgradeLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UpgradeLevel {
      get { return upgradeLevel_; }
      set {
        upgradeLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UpgradeRoguelikeShikigamiReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UpgradeRoguelikeShikigamiReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShikigamiGroupId != other.ShikigamiGroupId) return false;
      if (UpgradeLevel != other.UpgradeLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShikigamiGroupId != 0) hash ^= ShikigamiGroupId.GetHashCode();
      if (UpgradeLevel != 0) hash ^= UpgradeLevel.GetHashCode();
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
      if (UpgradeLevel != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(UpgradeLevel);
      }
      if (ShikigamiGroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShikigamiGroupId);
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
      if (UpgradeLevel != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(UpgradeLevel);
      }
      if (ShikigamiGroupId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ShikigamiGroupId);
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
      if (ShikigamiGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShikigamiGroupId);
      }
      if (UpgradeLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UpgradeLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UpgradeRoguelikeShikigamiReq other) {
      if (other == null) {
        return;
      }
      if (other.ShikigamiGroupId != 0) {
        ShikigamiGroupId = other.ShikigamiGroupId;
      }
      if (other.UpgradeLevel != 0) {
        UpgradeLevel = other.UpgradeLevel;
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
          case 80: {
            UpgradeLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            ShikigamiGroupId = input.ReadUInt32();
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
          case 80: {
            UpgradeLevel = input.ReadUInt32();
            break;
          }
          case 120: {
            ShikigamiGroupId = input.ReadUInt32();
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
