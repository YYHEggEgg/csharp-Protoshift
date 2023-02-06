// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonRoom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CustomDungeonRoom.proto</summary>
public static partial class CustomDungeonRoomReflection {

  #region Descriptor
  /// <summary>File descriptor for CustomDungeonRoom.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CustomDungeonRoomReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChdDdXN0b21EdW5nZW9uUm9vbS5wcm90bxoYQ3VzdG9tRHVuZ2VvbkJsb2Nr",
          "LnByb3RvIk0KEUN1c3RvbUR1bmdlb25Sb29tEg8KB3Jvb21faWQYDyABKA0S",
          "JwoKYmxvY2tfbGlzdBgLIAMoCzITLkN1c3RvbUR1bmdlb25CbG9ja0IWChRv",
          "cmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CustomDungeonBlockReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CustomDungeonRoom), global::CustomDungeonRoom.Parser, new[]{ "RoomId", "BlockList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class CustomDungeonRoom : pb::IMessage<CustomDungeonRoom>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CustomDungeonRoom> _parser = new pb::MessageParser<CustomDungeonRoom>(() => new CustomDungeonRoom());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CustomDungeonRoom> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CustomDungeonRoomReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRoom() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRoom(CustomDungeonRoom other) : this() {
    roomId_ = other.roomId_;
    blockList_ = other.blockList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRoom Clone() {
    return new CustomDungeonRoom(this);
  }

  /// <summary>Field number for the "room_id" field.</summary>
  public const int RoomIdFieldNumber = 15;
  private uint roomId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RoomId {
    get { return roomId_; }
    set {
      roomId_ = value;
    }
  }

  /// <summary>Field number for the "block_list" field.</summary>
  public const int BlockListFieldNumber = 11;
  private static readonly pb::FieldCodec<global::CustomDungeonBlock> _repeated_blockList_codec
      = pb::FieldCodec.ForMessage(90, global::CustomDungeonBlock.Parser);
  private readonly pbc::RepeatedField<global::CustomDungeonBlock> blockList_ = new pbc::RepeatedField<global::CustomDungeonBlock>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::CustomDungeonBlock> BlockList {
    get { return blockList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CustomDungeonRoom);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CustomDungeonRoom other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RoomId != other.RoomId) return false;
    if(!blockList_.Equals(other.blockList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RoomId != 0) hash ^= RoomId.GetHashCode();
    hash ^= blockList_.GetHashCode();
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
    blockList_.WriteTo(output, _repeated_blockList_codec);
    if (RoomId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(RoomId);
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
    blockList_.WriteTo(ref output, _repeated_blockList_codec);
    if (RoomId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(RoomId);
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
    if (RoomId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
    }
    size += blockList_.CalculateSize(_repeated_blockList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CustomDungeonRoom other) {
    if (other == null) {
      return;
    }
    if (other.RoomId != 0) {
      RoomId = other.RoomId;
    }
    blockList_.Add(other.blockList_);
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
        case 90: {
          blockList_.AddEntriesFrom(input, _repeated_blockList_codec);
          break;
        }
        case 120: {
          RoomId = input.ReadUInt32();
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
        case 90: {
          blockList_.AddEntriesFrom(ref input, _repeated_blockList_codec);
          break;
        }
        case 120: {
          RoomId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
