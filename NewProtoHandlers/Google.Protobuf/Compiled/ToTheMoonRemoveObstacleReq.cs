// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ToTheMoonRemoveObstacleReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from ToTheMoonRemoveObstacleReq.proto</summary>
  public static partial class ToTheMoonRemoveObstacleReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ToTheMoonRemoveObstacleReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ToTheMoonRemoveObstacleReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBUb1RoZU1vb25SZW1vdmVPYnN0YWNsZVJlcS5wcm90byKSAQoaVG9UaGVN",
            "b29uUmVtb3ZlT2JzdGFjbGVSZXESDgoGaGFuZGxlGA8gASgFEhAKCHNjZW5l",
            "X2lkGAcgASgNEhAKCHF1ZXJ5X2lkGAYgASgFIkAKDE9ic3RhY2xlVHlwZRIV",
            "ChFPQlNUQUNMRV9UWVBFX0JPWBAAEhkKFU9CU1RBQ0xFX1RZUEVfQ0FQU1VM",
            "RRABQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ToTheMoonRemoveObstacleReq), global::NewProtos.ToTheMoonRemoveObstacleReq.Parser, new[]{ "Handle", "SceneId", "QueryId" }, null, new[]{ typeof(global::NewProtos.ToTheMoonRemoveObstacleReq.Types.ObstacleType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6147;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class ToTheMoonRemoveObstacleReq : pb::IMessage<ToTheMoonRemoveObstacleReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ToTheMoonRemoveObstacleReq> _parser = new pb::MessageParser<ToTheMoonRemoveObstacleReq>(() => new ToTheMoonRemoveObstacleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ToTheMoonRemoveObstacleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.ToTheMoonRemoveObstacleReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleReq(ToTheMoonRemoveObstacleReq other) : this() {
      handle_ = other.handle_;
      sceneId_ = other.sceneId_;
      queryId_ = other.queryId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleReq Clone() {
      return new ToTheMoonRemoveObstacleReq(this);
    }

    /// <summary>Field number for the "handle" field.</summary>
    public const int HandleFieldNumber = 15;
    private int handle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Handle {
      get { return handle_; }
      set {
        handle_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 7;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "query_id" field.</summary>
    public const int QueryIdFieldNumber = 6;
    private int queryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int QueryId {
      get { return queryId_; }
      set {
        queryId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ToTheMoonRemoveObstacleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ToTheMoonRemoveObstacleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Handle != other.Handle) return false;
      if (SceneId != other.SceneId) return false;
      if (QueryId != other.QueryId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Handle != 0) hash ^= Handle.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (QueryId != 0) hash ^= QueryId.GetHashCode();
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
      if (QueryId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(QueryId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SceneId);
      }
      if (Handle != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Handle);
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
      if (QueryId != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(QueryId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SceneId);
      }
      if (Handle != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(Handle);
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
      if (Handle != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Handle);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (QueryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QueryId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ToTheMoonRemoveObstacleReq other) {
      if (other == null) {
        return;
      }
      if (other.Handle != 0) {
        Handle = other.Handle;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.QueryId != 0) {
        QueryId = other.QueryId;
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
          case 48: {
            QueryId = input.ReadInt32();
            break;
          }
          case 56: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 120: {
            Handle = input.ReadInt32();
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
          case 48: {
            QueryId = input.ReadInt32();
            break;
          }
          case 56: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 120: {
            Handle = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ToTheMoonRemoveObstacleReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ObstacleType {
        [pbr::OriginalName("OBSTACLE_TYPE_BOX")] Box = 0,
        [pbr::OriginalName("OBSTACLE_TYPE_CAPSULE")] Capsule = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
