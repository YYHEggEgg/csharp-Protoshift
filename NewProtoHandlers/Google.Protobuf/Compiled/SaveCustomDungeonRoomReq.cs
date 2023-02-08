// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SaveCustomDungeonRoomReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SaveCustomDungeonRoomReq.proto</summary>
  public static partial class SaveCustomDungeonRoomReqReflection {

    #region Descriptor
    /// <summary>File descriptor for SaveCustomDungeonRoomReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SaveCustomDungeonRoomReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TYXZlQ3VzdG9tRHVuZ2VvblJvb21SZXEucHJvdG8aF0N1c3RvbUR1bmdl",
            "b25Sb29tLnByb3RvGhpDdXN0b21EdW5nZW9uU2V0dGluZy5wcm90byKOAQoY",
            "U2F2ZUN1c3RvbUR1bmdlb25Sb29tUmVxEiYKB3NldHRpbmcYASABKAsyFS5D",
            "dXN0b21EdW5nZW9uU2V0dGluZxIvChNjdXN0b21fZHVuZ2Vvbl9yb29tGAQg",
            "ASgLMhIuQ3VzdG9tRHVuZ2VvblJvb20SGQoRaXNfdXBkYXRlX3NldHRpbmcY",
            "DCABKAhCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.CustomDungeonRoomReflection.Descriptor, global::NewProtos.CustomDungeonSettingReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SaveCustomDungeonRoomReq), global::NewProtos.SaveCustomDungeonRoomReq.Parser, new[]{ "Setting", "CustomDungeonRoom", "IsUpdateSetting" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6222;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class SaveCustomDungeonRoomReq : pb::IMessage<SaveCustomDungeonRoomReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SaveCustomDungeonRoomReq> _parser = new pb::MessageParser<SaveCustomDungeonRoomReq>(() => new SaveCustomDungeonRoomReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SaveCustomDungeonRoomReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SaveCustomDungeonRoomReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCustomDungeonRoomReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCustomDungeonRoomReq(SaveCustomDungeonRoomReq other) : this() {
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      customDungeonRoom_ = other.customDungeonRoom_ != null ? other.customDungeonRoom_.Clone() : null;
      isUpdateSetting_ = other.isUpdateSetting_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SaveCustomDungeonRoomReq Clone() {
      return new SaveCustomDungeonRoomReq(this);
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 1;
    private global::NewProtos.CustomDungeonSetting setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeonSetting Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "custom_dungeon_room" field.</summary>
    public const int CustomDungeonRoomFieldNumber = 4;
    private global::NewProtos.CustomDungeonRoom customDungeonRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.CustomDungeonRoom CustomDungeonRoom {
      get { return customDungeonRoom_; }
      set {
        customDungeonRoom_ = value;
      }
    }

    /// <summary>Field number for the "is_update_setting" field.</summary>
    public const int IsUpdateSettingFieldNumber = 12;
    private bool isUpdateSetting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUpdateSetting {
      get { return isUpdateSetting_; }
      set {
        isUpdateSetting_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SaveCustomDungeonRoomReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SaveCustomDungeonRoomReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Setting, other.Setting)) return false;
      if (!object.Equals(CustomDungeonRoom, other.CustomDungeonRoom)) return false;
      if (IsUpdateSetting != other.IsUpdateSetting) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (customDungeonRoom_ != null) hash ^= CustomDungeonRoom.GetHashCode();
      if (IsUpdateSetting != false) hash ^= IsUpdateSetting.GetHashCode();
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
      if (setting_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Setting);
      }
      if (customDungeonRoom_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CustomDungeonRoom);
      }
      if (IsUpdateSetting != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsUpdateSetting);
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
      if (setting_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Setting);
      }
      if (customDungeonRoom_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CustomDungeonRoom);
      }
      if (IsUpdateSetting != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsUpdateSetting);
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
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (customDungeonRoom_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomDungeonRoom);
      }
      if (IsUpdateSetting != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SaveCustomDungeonRoomReq other) {
      if (other == null) {
        return;
      }
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::NewProtos.CustomDungeonSetting();
        }
        Setting.MergeFrom(other.Setting);
      }
      if (other.customDungeonRoom_ != null) {
        if (customDungeonRoom_ == null) {
          CustomDungeonRoom = new global::NewProtos.CustomDungeonRoom();
        }
        CustomDungeonRoom.MergeFrom(other.CustomDungeonRoom);
      }
      if (other.IsUpdateSetting != false) {
        IsUpdateSetting = other.IsUpdateSetting;
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
            if (setting_ == null) {
              Setting = new global::NewProtos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 34: {
            if (customDungeonRoom_ == null) {
              CustomDungeonRoom = new global::NewProtos.CustomDungeonRoom();
            }
            input.ReadMessage(CustomDungeonRoom);
            break;
          }
          case 96: {
            IsUpdateSetting = input.ReadBool();
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
            if (setting_ == null) {
              Setting = new global::NewProtos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 34: {
            if (customDungeonRoom_ == null) {
              CustomDungeonRoom = new global::NewProtos.CustomDungeonRoom();
            }
            input.ReadMessage(CustomDungeonRoom);
            break;
          }
          case 96: {
            IsUpdateSetting = input.ReadBool();
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
