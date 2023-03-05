// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: NicknameSignatureAuditData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from NicknameSignatureAuditData.proto</summary>
  public static partial class NicknameSignatureAuditDataReflection {

    #region Descriptor
    /// <summary>File descriptor for NicknameSignatureAuditData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NicknameSignatureAuditDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBOaWNrbmFtZVNpZ25hdHVyZUF1ZGl0RGF0YS5wcm90bxogQ29udGVudEF1",
            "ZGl0QXV4aWxpYXJ5RmllbGQucHJvdG8aF0NvbnRlbnRBdWRpdEZpZWxkLnBy",
            "b3RvIt0BChpOaWNrbmFtZVNpZ25hdHVyZUF1ZGl0RGF0YRILCgNhaWQYASAB",
            "KAkSEQoJZW50aXR5X2lkGAIgASgJEgwKBGxhbmcYAyABKAkSEQoJcXVldWVf",
            "a2V5GAQgASgJEg4KBnJlZ2lvbhgFIAEoCRILCgN1aWQYBiABKA0SLAoQYXVk",
            "aXRfZmllbGRfbGlzdBgHIAMoCzISLkNvbnRlbnRBdWRpdEZpZWxkEjMKDmF1",
            "eF9maWVsZF9saXN0GAggAygLMhsuQ29udGVudEF1ZGl0QXV4aWxpYXJ5Rmll",
            "bGRCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ContentAuditAuxiliaryFieldReflection.Descriptor, global::NewProtos.ContentAuditFieldReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.NicknameSignatureAuditData), global::NewProtos.NicknameSignatureAuditData.Parser, new[]{ "Aid", "EntityId", "Lang", "QueueKey", "Region", "Uid", "AuditFieldList", "AuxFieldList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NicknameSignatureAuditData : pb::IMessage<NicknameSignatureAuditData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NicknameSignatureAuditData> _parser = new pb::MessageParser<NicknameSignatureAuditData>(() => new NicknameSignatureAuditData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<NicknameSignatureAuditData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.NicknameSignatureAuditDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NicknameSignatureAuditData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NicknameSignatureAuditData(NicknameSignatureAuditData other) : this() {
      aid_ = other.aid_;
      entityId_ = other.entityId_;
      lang_ = other.lang_;
      queueKey_ = other.queueKey_;
      region_ = other.region_;
      uid_ = other.uid_;
      auditFieldList_ = other.auditFieldList_.Clone();
      auxFieldList_ = other.auxFieldList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public NicknameSignatureAuditData Clone() {
      return new NicknameSignatureAuditData(this);
    }

    /// <summary>Field number for the "aid" field.</summary>
    public const int AidFieldNumber = 1;
    private string aid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Aid {
      get { return aid_; }
      set {
        aid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 2;
    private string entityId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EntityId {
      get { return entityId_; }
      set {
        entityId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "lang" field.</summary>
    public const int LangFieldNumber = 3;
    private string lang_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Lang {
      get { return lang_; }
      set {
        lang_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "queue_key" field.</summary>
    public const int QueueKeyFieldNumber = 4;
    private string queueKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string QueueKey {
      get { return queueKey_; }
      set {
        queueKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 5;
    private string region_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 6;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "audit_field_list" field.</summary>
    public const int AuditFieldListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::NewProtos.ContentAuditField> _repeated_auditFieldList_codec
        = pb::FieldCodec.ForMessage(58, global::NewProtos.ContentAuditField.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ContentAuditField> auditFieldList_ = new pbc::RepeatedField<global::NewProtos.ContentAuditField>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ContentAuditField> AuditFieldList {
      get { return auditFieldList_; }
    }

    /// <summary>Field number for the "aux_field_list" field.</summary>
    public const int AuxFieldListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::NewProtos.ContentAuditAuxiliaryField> _repeated_auxFieldList_codec
        = pb::FieldCodec.ForMessage(66, global::NewProtos.ContentAuditAuxiliaryField.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ContentAuditAuxiliaryField> auxFieldList_ = new pbc::RepeatedField<global::NewProtos.ContentAuditAuxiliaryField>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ContentAuditAuxiliaryField> AuxFieldList {
      get { return auxFieldList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as NicknameSignatureAuditData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(NicknameSignatureAuditData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Aid != other.Aid) return false;
      if (EntityId != other.EntityId) return false;
      if (Lang != other.Lang) return false;
      if (QueueKey != other.QueueKey) return false;
      if (Region != other.Region) return false;
      if (Uid != other.Uid) return false;
      if(!auditFieldList_.Equals(other.auditFieldList_)) return false;
      if(!auxFieldList_.Equals(other.auxFieldList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Aid.Length != 0) hash ^= Aid.GetHashCode();
      if (EntityId.Length != 0) hash ^= EntityId.GetHashCode();
      if (Lang.Length != 0) hash ^= Lang.GetHashCode();
      if (QueueKey.Length != 0) hash ^= QueueKey.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= auditFieldList_.GetHashCode();
      hash ^= auxFieldList_.GetHashCode();
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
      if (Aid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Aid);
      }
      if (EntityId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EntityId);
      }
      if (Lang.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Lang);
      }
      if (QueueKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(QueueKey);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Region);
      }
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      auditFieldList_.WriteTo(output, _repeated_auditFieldList_codec);
      auxFieldList_.WriteTo(output, _repeated_auxFieldList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Aid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Aid);
      }
      if (EntityId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EntityId);
      }
      if (Lang.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Lang);
      }
      if (QueueKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(QueueKey);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Region);
      }
      if (Uid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Uid);
      }
      auditFieldList_.WriteTo(ref output, _repeated_auditFieldList_codec);
      auxFieldList_.WriteTo(ref output, _repeated_auxFieldList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Aid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Aid);
      }
      if (EntityId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EntityId);
      }
      if (Lang.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Lang);
      }
      if (QueueKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QueueKey);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += auditFieldList_.CalculateSize(_repeated_auditFieldList_codec);
      size += auxFieldList_.CalculateSize(_repeated_auxFieldList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(NicknameSignatureAuditData other) {
      if (other == null) {
        return;
      }
      if (other.Aid.Length != 0) {
        Aid = other.Aid;
      }
      if (other.EntityId.Length != 0) {
        EntityId = other.EntityId;
      }
      if (other.Lang.Length != 0) {
        Lang = other.Lang;
      }
      if (other.QueueKey.Length != 0) {
        QueueKey = other.QueueKey;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      auditFieldList_.Add(other.auditFieldList_);
      auxFieldList_.Add(other.auxFieldList_);
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
            Aid = input.ReadString();
            break;
          }
          case 18: {
            EntityId = input.ReadString();
            break;
          }
          case 26: {
            Lang = input.ReadString();
            break;
          }
          case 34: {
            QueueKey = input.ReadString();
            break;
          }
          case 42: {
            Region = input.ReadString();
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 58: {
            auditFieldList_.AddEntriesFrom(input, _repeated_auditFieldList_codec);
            break;
          }
          case 66: {
            auxFieldList_.AddEntriesFrom(input, _repeated_auxFieldList_codec);
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
            Aid = input.ReadString();
            break;
          }
          case 18: {
            EntityId = input.ReadString();
            break;
          }
          case 26: {
            Lang = input.ReadString();
            break;
          }
          case 34: {
            QueueKey = input.ReadString();
            break;
          }
          case 42: {
            Region = input.ReadString();
            break;
          }
          case 48: {
            Uid = input.ReadUInt32();
            break;
          }
          case 58: {
            auditFieldList_.AddEntriesFrom(ref input, _repeated_auditFieldList_codec);
            break;
          }
          case 66: {
            auxFieldList_.AddEntriesFrom(ref input, _repeated_auxFieldList_codec);
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