// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DataResVersionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from DataResVersionNotify.proto</summary>
  public static partial class DataResVersionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DataResVersionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataResVersionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpEYXRhUmVzVmVyc2lvbk5vdGlmeS5wcm90bxoWUmVzVmVyc2lvbkNvbmZp",
            "Zy5wcm90byLjAwoURGF0YVJlc1ZlcnNpb25Ob3RpZnkSGgoSY2xpZW50X3Np",
            "bGVuY2VfbWQ1GAogASgJEiUKHWNsaWVudF9zaWxlbmNlX3ZlcnNpb25fc3Vm",
            "Zml4GA8gASgJEi0KEnJlc192ZXJzaW9uX2NvbmZpZxgJIAEoCzIRLlJlc1Zl",
            "cnNpb25Db25maWcSHAoUaXNfZGF0YV9uZWVkX3JlbG9naW4YByABKAgSOwoH",
            "b3BfdHlwZRgMIAEoDjIqLkRhdGFSZXNWZXJzaW9uTm90aWZ5LkRhdGFSZXNW",
            "ZXJzaW9uT3BUeXBlEhsKE2NsaWVudF9kYXRhX3ZlcnNpb24YAiABKA0SHQoV",
            "Y2xpZW50X3ZlcnNpb25fc3VmZml4GAUgASgJEiMKG2NsaWVudF9zaWxlbmNl",
            "X2RhdGFfdmVyc2lvbhgBIAEoDRISCgpjbGllbnRfbWQ1GA4gASgJIogBChRE",
            "YXRhUmVzVmVyc2lvbk9wVHlwZRIhCh1EQVRBX1JFU19WRVJTSU9OX09QX1RZ",
            "UEVfTk9ORRAAEiQKIERBVEFfUkVTX1ZFUlNJT05fT1BfVFlQRV9SRUxPR0lO",
            "EAESJwojREFUQV9SRVNfVkVSU0lPTl9PUF9UWVBFX01QX1JFTE9HSU4QAkIM",
            "qgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.ResVersionConfigReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.DataResVersionNotify), global::OldProtos.DataResVersionNotify.Parser, new[]{ "ClientSilenceMd5", "ClientSilenceVersionSuffix", "ResVersionConfig", "IsDataNeedRelogin", "OpType", "ClientDataVersion", "ClientVersionSuffix", "ClientSilenceDataVersion", "ClientMd5" }, null, new[]{ typeof(global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 167
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class DataResVersionNotify : pb::IMessage<DataResVersionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataResVersionNotify> _parser = new pb::MessageParser<DataResVersionNotify>(() => new DataResVersionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataResVersionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.DataResVersionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify(DataResVersionNotify other) : this() {
      clientSilenceMd5_ = other.clientSilenceMd5_;
      clientSilenceVersionSuffix_ = other.clientSilenceVersionSuffix_;
      resVersionConfig_ = other.resVersionConfig_ != null ? other.resVersionConfig_.Clone() : null;
      isDataNeedRelogin_ = other.isDataNeedRelogin_;
      opType_ = other.opType_;
      clientDataVersion_ = other.clientDataVersion_;
      clientVersionSuffix_ = other.clientVersionSuffix_;
      clientSilenceDataVersion_ = other.clientSilenceDataVersion_;
      clientMd5_ = other.clientMd5_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataResVersionNotify Clone() {
      return new DataResVersionNotify(this);
    }

    /// <summary>Field number for the "client_silence_md5" field.</summary>
    public const int ClientSilenceMd5FieldNumber = 10;
    private string clientSilenceMd5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientSilenceMd5 {
      get { return clientSilenceMd5_; }
      set {
        clientSilenceMd5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_silence_version_suffix" field.</summary>
    public const int ClientSilenceVersionSuffixFieldNumber = 15;
    private string clientSilenceVersionSuffix_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientSilenceVersionSuffix {
      get { return clientSilenceVersionSuffix_; }
      set {
        clientSilenceVersionSuffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "res_version_config" field.</summary>
    public const int ResVersionConfigFieldNumber = 9;
    private global::OldProtos.ResVersionConfig resVersionConfig_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.ResVersionConfig ResVersionConfig {
      get { return resVersionConfig_; }
      set {
        resVersionConfig_ = value;
      }
    }

    /// <summary>Field number for the "is_data_need_relogin" field.</summary>
    public const int IsDataNeedReloginFieldNumber = 7;
    private bool isDataNeedRelogin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDataNeedRelogin {
      get { return isDataNeedRelogin_; }
      set {
        isDataNeedRelogin_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 12;
    private global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType opType_ = global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    /// <summary>Field number for the "client_data_version" field.</summary>
    public const int ClientDataVersionFieldNumber = 2;
    private uint clientDataVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientDataVersion {
      get { return clientDataVersion_; }
      set {
        clientDataVersion_ = value;
      }
    }

    /// <summary>Field number for the "client_version_suffix" field.</summary>
    public const int ClientVersionSuffixFieldNumber = 5;
    private string clientVersionSuffix_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientVersionSuffix {
      get { return clientVersionSuffix_; }
      set {
        clientVersionSuffix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_silence_data_version" field.</summary>
    public const int ClientSilenceDataVersionFieldNumber = 1;
    private uint clientSilenceDataVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientSilenceDataVersion {
      get { return clientSilenceDataVersion_; }
      set {
        clientSilenceDataVersion_ = value;
      }
    }

    /// <summary>Field number for the "client_md5" field.</summary>
    public const int ClientMd5FieldNumber = 14;
    private string clientMd5_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientMd5 {
      get { return clientMd5_; }
      set {
        clientMd5_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataResVersionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataResVersionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientSilenceMd5 != other.ClientSilenceMd5) return false;
      if (ClientSilenceVersionSuffix != other.ClientSilenceVersionSuffix) return false;
      if (!object.Equals(ResVersionConfig, other.ResVersionConfig)) return false;
      if (IsDataNeedRelogin != other.IsDataNeedRelogin) return false;
      if (OpType != other.OpType) return false;
      if (ClientDataVersion != other.ClientDataVersion) return false;
      if (ClientVersionSuffix != other.ClientVersionSuffix) return false;
      if (ClientSilenceDataVersion != other.ClientSilenceDataVersion) return false;
      if (ClientMd5 != other.ClientMd5) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientSilenceMd5.Length != 0) hash ^= ClientSilenceMd5.GetHashCode();
      if (ClientSilenceVersionSuffix.Length != 0) hash ^= ClientSilenceVersionSuffix.GetHashCode();
      if (resVersionConfig_ != null) hash ^= ResVersionConfig.GetHashCode();
      if (IsDataNeedRelogin != false) hash ^= IsDataNeedRelogin.GetHashCode();
      if (OpType != global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None) hash ^= OpType.GetHashCode();
      if (ClientDataVersion != 0) hash ^= ClientDataVersion.GetHashCode();
      if (ClientVersionSuffix.Length != 0) hash ^= ClientVersionSuffix.GetHashCode();
      if (ClientSilenceDataVersion != 0) hash ^= ClientSilenceDataVersion.GetHashCode();
      if (ClientMd5.Length != 0) hash ^= ClientMd5.GetHashCode();
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
      if (ClientSilenceDataVersion != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ClientSilenceDataVersion);
      }
      if (ClientDataVersion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ClientDataVersion);
      }
      if (ClientVersionSuffix.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ClientVersionSuffix);
      }
      if (IsDataNeedRelogin != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsDataNeedRelogin);
      }
      if (resVersionConfig_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ResVersionConfig);
      }
      if (ClientSilenceMd5.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ClientSilenceMd5);
      }
      if (OpType != global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) OpType);
      }
      if (ClientMd5.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(ClientMd5);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(ClientSilenceVersionSuffix);
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
      if (ClientSilenceDataVersion != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ClientSilenceDataVersion);
      }
      if (ClientDataVersion != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ClientDataVersion);
      }
      if (ClientVersionSuffix.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ClientVersionSuffix);
      }
      if (IsDataNeedRelogin != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsDataNeedRelogin);
      }
      if (resVersionConfig_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ResVersionConfig);
      }
      if (ClientSilenceMd5.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ClientSilenceMd5);
      }
      if (OpType != global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) OpType);
      }
      if (ClientMd5.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(ClientMd5);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(ClientSilenceVersionSuffix);
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
      if (ClientSilenceMd5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientSilenceMd5);
      }
      if (ClientSilenceVersionSuffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientSilenceVersionSuffix);
      }
      if (resVersionConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ResVersionConfig);
      }
      if (IsDataNeedRelogin != false) {
        size += 1 + 1;
      }
      if (OpType != global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (ClientDataVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientDataVersion);
      }
      if (ClientVersionSuffix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientVersionSuffix);
      }
      if (ClientSilenceDataVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientSilenceDataVersion);
      }
      if (ClientMd5.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientMd5);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataResVersionNotify other) {
      if (other == null) {
        return;
      }
      if (other.ClientSilenceMd5.Length != 0) {
        ClientSilenceMd5 = other.ClientSilenceMd5;
      }
      if (other.ClientSilenceVersionSuffix.Length != 0) {
        ClientSilenceVersionSuffix = other.ClientSilenceVersionSuffix;
      }
      if (other.resVersionConfig_ != null) {
        if (resVersionConfig_ == null) {
          ResVersionConfig = new global::OldProtos.ResVersionConfig();
        }
        ResVersionConfig.MergeFrom(other.ResVersionConfig);
      }
      if (other.IsDataNeedRelogin != false) {
        IsDataNeedRelogin = other.IsDataNeedRelogin;
      }
      if (other.OpType != global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType.None) {
        OpType = other.OpType;
      }
      if (other.ClientDataVersion != 0) {
        ClientDataVersion = other.ClientDataVersion;
      }
      if (other.ClientVersionSuffix.Length != 0) {
        ClientVersionSuffix = other.ClientVersionSuffix;
      }
      if (other.ClientSilenceDataVersion != 0) {
        ClientSilenceDataVersion = other.ClientSilenceDataVersion;
      }
      if (other.ClientMd5.Length != 0) {
        ClientMd5 = other.ClientMd5;
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
          case 8: {
            ClientSilenceDataVersion = input.ReadUInt32();
            break;
          }
          case 16: {
            ClientDataVersion = input.ReadUInt32();
            break;
          }
          case 42: {
            ClientVersionSuffix = input.ReadString();
            break;
          }
          case 56: {
            IsDataNeedRelogin = input.ReadBool();
            break;
          }
          case 74: {
            if (resVersionConfig_ == null) {
              ResVersionConfig = new global::OldProtos.ResVersionConfig();
            }
            input.ReadMessage(ResVersionConfig);
            break;
          }
          case 82: {
            ClientSilenceMd5 = input.ReadString();
            break;
          }
          case 96: {
            OpType = (global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType) input.ReadEnum();
            break;
          }
          case 114: {
            ClientMd5 = input.ReadString();
            break;
          }
          case 122: {
            ClientSilenceVersionSuffix = input.ReadString();
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
          case 8: {
            ClientSilenceDataVersion = input.ReadUInt32();
            break;
          }
          case 16: {
            ClientDataVersion = input.ReadUInt32();
            break;
          }
          case 42: {
            ClientVersionSuffix = input.ReadString();
            break;
          }
          case 56: {
            IsDataNeedRelogin = input.ReadBool();
            break;
          }
          case 74: {
            if (resVersionConfig_ == null) {
              ResVersionConfig = new global::OldProtos.ResVersionConfig();
            }
            input.ReadMessage(ResVersionConfig);
            break;
          }
          case 82: {
            ClientSilenceMd5 = input.ReadString();
            break;
          }
          case 96: {
            OpType = (global::OldProtos.DataResVersionNotify.Types.DataResVersionOpType) input.ReadEnum();
            break;
          }
          case 114: {
            ClientMd5 = input.ReadString();
            break;
          }
          case 122: {
            ClientSilenceVersionSuffix = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DataResVersionNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum DataResVersionOpType {
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_NONE")] None = 0,
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_RELOGIN")] Relogin = 1,
        [pbr::OriginalName("DATA_RES_VERSION_OP_TYPE_MP_RELOGIN")] MpRelogin = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
