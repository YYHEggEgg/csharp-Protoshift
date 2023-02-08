// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterCustomDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from EnterCustomDungeonRsp.proto</summary>
  public static partial class EnterCustomDungeonRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterCustomDungeonRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterCustomDungeonRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFbnRlckN1c3RvbUR1bmdlb25Sc3AucHJvdG8aE0N1c3RvbUR1bmdlb24u",
            "cHJvdG8aHEVudGVyQ3VzdG9tRHVuZ2VvblR5cGUucHJvdG8i8QEKFUVudGVy",
            "Q3VzdG9tRHVuZ2VvblJzcBI+Cg1yb29tX2Nvc3RfbWFwGAMgAygLMicuRW50",
            "ZXJDdXN0b21EdW5nZW9uUnNwLlJvb21Db3N0TWFwRW50cnkSKwoKZW50ZXJf",
            "dHlwZRgPIAEoDjIXLkVudGVyQ3VzdG9tRHVuZ2VvblR5cGUSJgoOY3VzdG9t",
            "X2R1bmdlb24YDCABKAsyDi5DdXN0b21EdW5nZW9uEg8KB3JldGNvZGUYCCAB",
            "KAUaMgoQUm9vbUNvc3RNYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY",
            "AiABKA06AjgBQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.CustomDungeonReflection.Descriptor, global::NewProtos.EnterCustomDungeonTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.EnterCustomDungeonRsp), global::NewProtos.EnterCustomDungeonRsp.Parser, new[]{ "RoomCostMap", "EnterType", "CustomDungeon", "Retcode" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6241;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class EnterCustomDungeonRsp : pb::IMessage<EnterCustomDungeonRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterCustomDungeonRsp> _parser = new pb::MessageParser<EnterCustomDungeonRsp>(() => new EnterCustomDungeonRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterCustomDungeonRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.EnterCustomDungeonRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp(EnterCustomDungeonRsp other) : this() {
      roomCostMap_ = other.roomCostMap_.Clone();
      enterType_ = other.enterType_;
      customDungeon_ = other.customDungeon_ != null ? other.customDungeon_.Clone() : null;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp Clone() {
      return new EnterCustomDungeonRsp(this);
    }

    /// <summary>Field number for the "room_cost_map" field.</summary>
    public const int RoomCostMapFieldNumber = 3;
    private static readonly pbc::MapField<uint, uint>.Codec _map_roomCostMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 26);
    private readonly pbc::MapField<uint, uint> roomCostMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> RoomCostMap {
      get { return roomCostMap_; }
    }

    /// <summary>Field number for the "enter_type" field.</summary>
    public const int EnterTypeFieldNumber = 15;
    private global::NewProtos.EnterCustomDungeonType enterType_ = global::NewProtos.EnterCustomDungeonType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.EnterCustomDungeonType EnterType {
      get { return enterType_; }
      set {
        enterType_ = value;
      }
    }

    /// <summary>Field number for the "custom_dungeon" field.</summary>
    public const int CustomDungeonFieldNumber = 12;
    private global::NewProtos.CustomDungeon customDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeon CustomDungeon {
      get { return customDungeon_; }
      set {
        customDungeon_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterCustomDungeonRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterCustomDungeonRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!RoomCostMap.Equals(other.RoomCostMap)) return false;
      if (EnterType != other.EnterType) return false;
      if (!object.Equals(CustomDungeon, other.CustomDungeon)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= RoomCostMap.GetHashCode();
      if (EnterType != global::NewProtos.EnterCustomDungeonType.None) hash ^= EnterType.GetHashCode();
      if (customDungeon_ != null) hash ^= CustomDungeon.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      roomCostMap_.WriteTo(output, _map_roomCostMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (customDungeon_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CustomDungeon);
      }
      if (EnterType != global::NewProtos.EnterCustomDungeonType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) EnterType);
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
      roomCostMap_.WriteTo(ref output, _map_roomCostMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (customDungeon_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(CustomDungeon);
      }
      if (EnterType != global::NewProtos.EnterCustomDungeonType.None) {
        output.WriteRawTag(120);
        output.WriteEnum((int) EnterType);
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
      size += roomCostMap_.CalculateSize(_map_roomCostMap_codec);
      if (EnterType != global::NewProtos.EnterCustomDungeonType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EnterType);
      }
      if (customDungeon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomDungeon);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterCustomDungeonRsp other) {
      if (other == null) {
        return;
      }
      roomCostMap_.Add(other.roomCostMap_);
      if (other.EnterType != global::NewProtos.EnterCustomDungeonType.None) {
        EnterType = other.EnterType;
      }
      if (other.customDungeon_ != null) {
        if (customDungeon_ == null) {
          CustomDungeon = new global::NewProtos.CustomDungeon();
        }
        CustomDungeon.MergeFrom(other.CustomDungeon);
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 26: {
            roomCostMap_.AddEntriesFrom(input, _map_roomCostMap_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98: {
            if (customDungeon_ == null) {
              CustomDungeon = new global::NewProtos.CustomDungeon();
            }
            input.ReadMessage(CustomDungeon);
            break;
          }
          case 120: {
            EnterType = (global::NewProtos.EnterCustomDungeonType) input.ReadEnum();
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
          case 26: {
            roomCostMap_.AddEntriesFrom(ref input, _map_roomCostMap_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 98: {
            if (customDungeon_ == null) {
              CustomDungeon = new global::NewProtos.CustomDungeon();
            }
            input.ReadMessage(CustomDungeon);
            break;
          }
          case 120: {
            EnterType = (global::NewProtos.EnterCustomDungeonType) input.ReadEnum();
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
