// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlueprintBriefMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from HomeBlueprintBriefMuipData.proto</summary>
  public static partial class HomeBlueprintBriefMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlueprintBriefMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlueprintBriefMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBIb21lQmx1ZXByaW50QnJpZWZNdWlwRGF0YS5wcm90byKmAQoaSG9tZUJs",
            "dWVwcmludEJyaWVmTXVpcERhdGESEgoKc2hhcmVfY29kZRgBIAEoCRIRCglv",
            "d25lcl91aWQYAiABKA0SEQoJbW9kdWxlX2lkGAMgASgNEhAKCHNjZW5lX2lk",
            "GAQgASgNEhAKCGJsb2NrX2lkGAUgASgNEhUKDWlzX2FsbG93X2NvcHkYBiAB",
            "KAgSEwoLY3JlYXRlX3RpbWUYByABKA1CDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.HomeBlueprintBriefMuipData), global::NewProtos.HomeBlueprintBriefMuipData.Parser, new[]{ "ShareCode", "OwnerUid", "ModuleId", "SceneId", "BlockId", "IsAllowCopy", "CreateTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlueprintBriefMuipData : pb::IMessage<HomeBlueprintBriefMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlueprintBriefMuipData> _parser = new pb::MessageParser<HomeBlueprintBriefMuipData>(() => new HomeBlueprintBriefMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlueprintBriefMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.HomeBlueprintBriefMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBriefMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBriefMuipData(HomeBlueprintBriefMuipData other) : this() {
      shareCode_ = other.shareCode_;
      ownerUid_ = other.ownerUid_;
      moduleId_ = other.moduleId_;
      sceneId_ = other.sceneId_;
      blockId_ = other.blockId_;
      isAllowCopy_ = other.isAllowCopy_;
      createTime_ = other.createTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintBriefMuipData Clone() {
      return new HomeBlueprintBriefMuipData(this);
    }

    /// <summary>Field number for the "share_code" field.</summary>
    public const int ShareCodeFieldNumber = 1;
    private string shareCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ShareCode {
      get { return shareCode_; }
      set {
        shareCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "owner_uid" field.</summary>
    public const int OwnerUidFieldNumber = 2;
    private uint ownerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerUid {
      get { return ownerUid_; }
      set {
        ownerUid_ = value;
      }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 3;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 4;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "block_id" field.</summary>
    public const int BlockIdFieldNumber = 5;
    private uint blockId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlockId {
      get { return blockId_; }
      set {
        blockId_ = value;
      }
    }

    /// <summary>Field number for the "is_allow_copy" field.</summary>
    public const int IsAllowCopyFieldNumber = 6;
    private bool isAllowCopy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllowCopy {
      get { return isAllowCopy_; }
      set {
        isAllowCopy_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 7;
    private uint createTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlueprintBriefMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlueprintBriefMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ShareCode != other.ShareCode) return false;
      if (OwnerUid != other.OwnerUid) return false;
      if (ModuleId != other.ModuleId) return false;
      if (SceneId != other.SceneId) return false;
      if (BlockId != other.BlockId) return false;
      if (IsAllowCopy != other.IsAllowCopy) return false;
      if (CreateTime != other.CreateTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ShareCode.Length != 0) hash ^= ShareCode.GetHashCode();
      if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (BlockId != 0) hash ^= BlockId.GetHashCode();
      if (IsAllowCopy != false) hash ^= IsAllowCopy.GetHashCode();
      if (CreateTime != 0) hash ^= CreateTime.GetHashCode();
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
      if (ShareCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ShareCode);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerUid);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (BlockId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BlockId);
      }
      if (IsAllowCopy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAllowCopy);
      }
      if (CreateTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CreateTime);
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
      if (ShareCode.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ShareCode);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerUid);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (BlockId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BlockId);
      }
      if (IsAllowCopy != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsAllowCopy);
      }
      if (CreateTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CreateTime);
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
      if (ShareCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShareCode);
      }
      if (OwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
      }
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (BlockId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlockId);
      }
      if (IsAllowCopy != false) {
        size += 1 + 1;
      }
      if (CreateTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CreateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlueprintBriefMuipData other) {
      if (other == null) {
        return;
      }
      if (other.ShareCode.Length != 0) {
        ShareCode = other.ShareCode;
      }
      if (other.OwnerUid != 0) {
        OwnerUid = other.OwnerUid;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.BlockId != 0) {
        BlockId = other.BlockId;
      }
      if (other.IsAllowCopy != false) {
        IsAllowCopy = other.IsAllowCopy;
      }
      if (other.CreateTime != 0) {
        CreateTime = other.CreateTime;
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
            ShareCode = input.ReadString();
            break;
          }
          case 16: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 24: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsAllowCopy = input.ReadBool();
            break;
          }
          case 56: {
            CreateTime = input.ReadUInt32();
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
            ShareCode = input.ReadString();
            break;
          }
          case 16: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 24: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            BlockId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsAllowCopy = input.ReadBool();
            break;
          }
          case 56: {
            CreateTime = input.ReadUInt32();
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
