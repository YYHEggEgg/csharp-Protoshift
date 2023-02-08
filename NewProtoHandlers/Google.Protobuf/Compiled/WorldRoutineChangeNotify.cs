// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldRoutineChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from WorldRoutineChangeNotify.proto</summary>
  public static partial class WorldRoutineChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldRoutineChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldRoutineChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Xb3JsZFJvdXRpbmVDaGFuZ2VOb3RpZnkucHJvdG8aFldvcmxkUm91dGlu",
            "ZUluZm8ucHJvdG8iWQoYV29ybGRSb3V0aW5lQ2hhbmdlTm90aWZ5EicKDHJv",
            "dXRpbmVfaW5mbxgOIAEoCzIRLldvcmxkUm91dGluZUluZm8SFAoMcm91dGlu",
            "ZV90eXBlGAogASgNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.WorldRoutineInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.WorldRoutineChangeNotify), global::NewProtos.WorldRoutineChangeNotify.Parser, new[]{ "RoutineInfo", "RoutineType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 3535;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  /// }
  /// </summary>
  public sealed partial class WorldRoutineChangeNotify : pb::IMessage<WorldRoutineChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldRoutineChangeNotify> _parser = new pb::MessageParser<WorldRoutineChangeNotify>(() => new WorldRoutineChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldRoutineChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.WorldRoutineChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineChangeNotify(WorldRoutineChangeNotify other) : this() {
      routineInfo_ = other.routineInfo_ != null ? other.routineInfo_.Clone() : null;
      routineType_ = other.routineType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldRoutineChangeNotify Clone() {
      return new WorldRoutineChangeNotify(this);
    }

    /// <summary>Field number for the "routine_info" field.</summary>
    public const int RoutineInfoFieldNumber = 14;
    private global::NewProtos.WorldRoutineInfo routineInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.WorldRoutineInfo RoutineInfo {
      get { return routineInfo_; }
      set {
        routineInfo_ = value;
      }
    }

    /// <summary>Field number for the "routine_type" field.</summary>
    public const int RoutineTypeFieldNumber = 10;
    private uint routineType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoutineType {
      get { return routineType_; }
      set {
        routineType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldRoutineChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldRoutineChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(RoutineInfo, other.RoutineInfo)) return false;
      if (RoutineType != other.RoutineType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (routineInfo_ != null) hash ^= RoutineInfo.GetHashCode();
      if (RoutineType != 0) hash ^= RoutineType.GetHashCode();
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
      if (RoutineType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RoutineType);
      }
      if (routineInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RoutineInfo);
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
      if (RoutineType != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RoutineType);
      }
      if (routineInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(RoutineInfo);
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
      if (routineInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoutineInfo);
      }
      if (RoutineType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoutineType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldRoutineChangeNotify other) {
      if (other == null) {
        return;
      }
      if (other.routineInfo_ != null) {
        if (routineInfo_ == null) {
          RoutineInfo = new global::NewProtos.WorldRoutineInfo();
        }
        RoutineInfo.MergeFrom(other.RoutineInfo);
      }
      if (other.RoutineType != 0) {
        RoutineType = other.RoutineType;
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
            RoutineType = input.ReadUInt32();
            break;
          }
          case 114: {
            if (routineInfo_ == null) {
              RoutineInfo = new global::NewProtos.WorldRoutineInfo();
            }
            input.ReadMessage(RoutineInfo);
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
            RoutineType = input.ReadUInt32();
            break;
          }
          case 114: {
            if (routineInfo_ == null) {
              RoutineInfo = new global::NewProtos.WorldRoutineInfo();
            }
            input.ReadMessage(RoutineInfo);
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
