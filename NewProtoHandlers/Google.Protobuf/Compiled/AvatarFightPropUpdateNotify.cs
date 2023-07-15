// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarFightPropUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from AvatarFightPropUpdateNotify.proto</summary>
  public static partial class AvatarFightPropUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarFightPropUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarFightPropUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFBdmF0YXJGaWdodFByb3BVcGRhdGVOb3RpZnkucHJvdG8irwEKG0F2YXRh",
            "ckZpZ2h0UHJvcFVwZGF0ZU5vdGlmeRITCgthdmF0YXJfZ3VpZBgNIAEoBBJG",
            "Cg5maWdodF9wcm9wX21hcBgKIAMoCzIuLkF2YXRhckZpZ2h0UHJvcFVwZGF0",
            "ZU5vdGlmeS5GaWdodFByb3BNYXBFbnRyeRozChFGaWdodFByb3BNYXBFbnRy",
            "eRILCgNrZXkYASABKA0SDQoFdmFsdWUYAiABKAI6AjgBQgyqAglOZXdQcm90",
            "b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.AvatarFightPropUpdateNotify), global::NewProtos.AvatarFightPropUpdateNotify.Parser, new[]{ "AvatarGuid", "FightPropMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 1243;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class AvatarFightPropUpdateNotify : pb::IMessage<AvatarFightPropUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarFightPropUpdateNotify> _parser = new pb::MessageParser<AvatarFightPropUpdateNotify>(() => new AvatarFightPropUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarFightPropUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.AvatarFightPropUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarFightPropUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarFightPropUpdateNotify(AvatarFightPropUpdateNotify other) : this() {
      avatarGuid_ = other.avatarGuid_;
      fightPropMap_ = other.fightPropMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarFightPropUpdateNotify Clone() {
      return new AvatarFightPropUpdateNotify(this);
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

    /// <summary>Field number for the "fight_prop_map" field.</summary>
    public const int FightPropMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, float>.Codec _map_fightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 82);
    private readonly pbc::MapField<uint, float> fightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> FightPropMap {
      get { return fightPropMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarFightPropUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarFightPropUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
      if (!FightPropMap.Equals(other.FightPropMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      hash ^= FightPropMap.GetHashCode();
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
      fightPropMap_.WriteTo(output, _map_fightPropMap_codec);
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
      fightPropMap_.WriteTo(ref output, _map_fightPropMap_codec);
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
      size += fightPropMap_.CalculateSize(_map_fightPropMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarFightPropUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      fightPropMap_.MergeFrom(other.fightPropMap_);
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
          case 82: {
            fightPropMap_.AddEntriesFrom(input, _map_fightPropMap_codec);
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
          case 82: {
            fightPropMap_.AddEntriesFrom(ref input, _map_fightPropMap_codec);
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
