// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerBuffChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ServerBuffChangeNotify.proto</summary>
  public static partial class ServerBuffChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ServerBuffChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerBuffChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTZXJ2ZXJCdWZmQ2hhbmdlTm90aWZ5LnByb3RvGhBTZXJ2ZXJCdWZmLnBy",
            "b3RvIswCChZTZXJ2ZXJCdWZmQ2hhbmdlTm90aWZ5EiUKEHNlcnZlcl9idWZm",
            "X2xpc3QYBCADKAsyCy5TZXJ2ZXJCdWZmEhgKEGlzX2NyZWF0dXJlX2J1ZmYY",
            "CCABKAgSFgoOZW50aXR5X2lkX2xpc3QYBiADKA0STQoXc2VydmVyX2J1ZmZf",
            "Y2hhbmdlX3R5cGUYCSABKA4yLC5TZXJ2ZXJCdWZmQ2hhbmdlTm90aWZ5LlNl",
            "cnZlckJ1ZmZDaGFuZ2VUeXBlEhgKEGF2YXRhcl9ndWlkX2xpc3QYBSADKAQi",
            "cAoUU2VydmVyQnVmZkNoYW5nZVR5cGUSKwonU0VSVkVSX0JVRkZfQ0hBTkdF",
            "X1RZUEVfQUREX1NFUlZFUl9CVUZGEAASKwonU0VSVkVSX0JVRkZfQ0hBTkdF",
            "X1RZUEVfREVMX1NFUlZFUl9CVUZGEAFCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.ServerBuffReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ServerBuffChangeNotify), global::NewProtos.ServerBuffChangeNotify.Parser, new[]{ "ServerBuffList", "IsCreatureBuff", "EntityIdList", "ServerBuffChangeType", "AvatarGuidList" }, null, new[]{ typeof(global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 398;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class ServerBuffChangeNotify : pb::IMessage<ServerBuffChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServerBuffChangeNotify> _parser = new pb::MessageParser<ServerBuffChangeNotify>(() => new ServerBuffChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ServerBuffChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ServerBuffChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerBuffChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerBuffChangeNotify(ServerBuffChangeNotify other) : this() {
      serverBuffList_ = other.serverBuffList_.Clone();
      isCreatureBuff_ = other.isCreatureBuff_;
      entityIdList_ = other.entityIdList_.Clone();
      serverBuffChangeType_ = other.serverBuffChangeType_;
      avatarGuidList_ = other.avatarGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServerBuffChangeNotify Clone() {
      return new ServerBuffChangeNotify(this);
    }

    /// <summary>Field number for the "server_buff_list" field.</summary>
    public const int ServerBuffListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::NewProtos.ServerBuff> _repeated_serverBuffList_codec
        = pb::FieldCodec.ForMessage(34, global::NewProtos.ServerBuff.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.ServerBuff> serverBuffList_ = new pbc::RepeatedField<global::NewProtos.ServerBuff>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.ServerBuff> ServerBuffList {
      get { return serverBuffList_; }
    }

    /// <summary>Field number for the "is_creature_buff" field.</summary>
    public const int IsCreatureBuffFieldNumber = 8;
    private bool isCreatureBuff_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCreatureBuff {
      get { return isCreatureBuff_; }
      set {
        isCreatureBuff_ = value;
      }
    }

    /// <summary>Field number for the "entity_id_list" field.</summary>
    public const int EntityIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_entityIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> entityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> EntityIdList {
      get { return entityIdList_; }
    }

    /// <summary>Field number for the "server_buff_change_type" field.</summary>
    public const int ServerBuffChangeTypeFieldNumber = 9;
    private global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType serverBuffChangeType_ = global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType ServerBuffChangeType {
      get { return serverBuffChangeType_; }
      set {
        serverBuffChangeType_ = value;
      }
    }

    /// <summary>Field number for the "avatar_guid_list" field.</summary>
    public const int AvatarGuidListFieldNumber = 5;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarGuidList_codec
        = pb::FieldCodec.ForUInt64(42);
    private readonly pbc::RepeatedField<ulong> avatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarGuidList {
      get { return avatarGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ServerBuffChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ServerBuffChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!serverBuffList_.Equals(other.serverBuffList_)) return false;
      if (IsCreatureBuff != other.IsCreatureBuff) return false;
      if(!entityIdList_.Equals(other.entityIdList_)) return false;
      if (ServerBuffChangeType != other.ServerBuffChangeType) return false;
      if(!avatarGuidList_.Equals(other.avatarGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= serverBuffList_.GetHashCode();
      if (IsCreatureBuff != false) hash ^= IsCreatureBuff.GetHashCode();
      hash ^= entityIdList_.GetHashCode();
      if (ServerBuffChangeType != global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff) hash ^= ServerBuffChangeType.GetHashCode();
      hash ^= avatarGuidList_.GetHashCode();
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
      serverBuffList_.WriteTo(output, _repeated_serverBuffList_codec);
      avatarGuidList_.WriteTo(output, _repeated_avatarGuidList_codec);
      entityIdList_.WriteTo(output, _repeated_entityIdList_codec);
      if (IsCreatureBuff != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsCreatureBuff);
      }
      if (ServerBuffChangeType != global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ServerBuffChangeType);
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
      serverBuffList_.WriteTo(ref output, _repeated_serverBuffList_codec);
      avatarGuidList_.WriteTo(ref output, _repeated_avatarGuidList_codec);
      entityIdList_.WriteTo(ref output, _repeated_entityIdList_codec);
      if (IsCreatureBuff != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsCreatureBuff);
      }
      if (ServerBuffChangeType != global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ServerBuffChangeType);
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
      size += serverBuffList_.CalculateSize(_repeated_serverBuffList_codec);
      if (IsCreatureBuff != false) {
        size += 1 + 1;
      }
      size += entityIdList_.CalculateSize(_repeated_entityIdList_codec);
      if (ServerBuffChangeType != global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ServerBuffChangeType);
      }
      size += avatarGuidList_.CalculateSize(_repeated_avatarGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ServerBuffChangeNotify other) {
      if (other == null) {
        return;
      }
      serverBuffList_.Add(other.serverBuffList_);
      if (other.IsCreatureBuff != false) {
        IsCreatureBuff = other.IsCreatureBuff;
      }
      entityIdList_.Add(other.entityIdList_);
      if (other.ServerBuffChangeType != global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType.AddServerBuff) {
        ServerBuffChangeType = other.ServerBuffChangeType;
      }
      avatarGuidList_.Add(other.avatarGuidList_);
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
          case 34: {
            serverBuffList_.AddEntriesFrom(input, _repeated_serverBuffList_codec);
            break;
          }
          case 42:
          case 40: {
            avatarGuidList_.AddEntriesFrom(input, _repeated_avatarGuidList_codec);
            break;
          }
          case 50:
          case 48: {
            entityIdList_.AddEntriesFrom(input, _repeated_entityIdList_codec);
            break;
          }
          case 64: {
            IsCreatureBuff = input.ReadBool();
            break;
          }
          case 72: {
            ServerBuffChangeType = (global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType) input.ReadEnum();
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
          case 34: {
            serverBuffList_.AddEntriesFrom(ref input, _repeated_serverBuffList_codec);
            break;
          }
          case 42:
          case 40: {
            avatarGuidList_.AddEntriesFrom(ref input, _repeated_avatarGuidList_codec);
            break;
          }
          case 50:
          case 48: {
            entityIdList_.AddEntriesFrom(ref input, _repeated_entityIdList_codec);
            break;
          }
          case 64: {
            IsCreatureBuff = input.ReadBool();
            break;
          }
          case 72: {
            ServerBuffChangeType = (global::NewProtos.ServerBuffChangeNotify.Types.ServerBuffChangeType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ServerBuffChangeNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ServerBuffChangeType {
        [pbr::OriginalName("SERVER_BUFF_CHANGE_TYPE_ADD_SERVER_BUFF")] AddServerBuff = 0,
        [pbr::OriginalName("SERVER_BUFF_CHANGE_TYPE_DEL_SERVER_BUFF")] DelServerBuff = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
