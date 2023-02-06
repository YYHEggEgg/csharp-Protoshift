// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CreateVehicleReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CreateVehicleReq.proto</summary>
public static partial class CreateVehicleReqReflection {

  #region Descriptor
  /// <summary>File descriptor for CreateVehicleReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CreateVehicleReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZDcmVhdGVWZWhpY2xlUmVxLnByb3RvGgxWZWN0b3IucHJvdG8iagoQQ3Jl",
          "YXRlVmVoaWNsZVJlcRIUCgNwb3MYCyABKAsyBy5WZWN0b3ISEgoKdmVoaWNs",
          "ZV9pZBgCIAEoDRIWCg5zY2VuZV9wb2ludF9pZBgHIAEoDRIUCgNyb3QYBSAB",
          "KAsyBy5WZWN0b3JCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IG",
          "cHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CreateVehicleReq), global::CreateVehicleReq.Parser, new[]{ "Pos", "VehicleId", "ScenePointId", "Rot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 893
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class CreateVehicleReq : pb::IMessage<CreateVehicleReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CreateVehicleReq> _parser = new pb::MessageParser<CreateVehicleReq>(() => new CreateVehicleReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CreateVehicleReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CreateVehicleReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CreateVehicleReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CreateVehicleReq(CreateVehicleReq other) : this() {
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    vehicleId_ = other.vehicleId_;
    scenePointId_ = other.scenePointId_;
    rot_ = other.rot_ != null ? other.rot_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CreateVehicleReq Clone() {
    return new CreateVehicleReq(this);
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 11;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  /// <summary>Field number for the "vehicle_id" field.</summary>
  public const int VehicleIdFieldNumber = 2;
  private uint vehicleId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint VehicleId {
    get { return vehicleId_; }
    set {
      vehicleId_ = value;
    }
  }

  /// <summary>Field number for the "scene_point_id" field.</summary>
  public const int ScenePointIdFieldNumber = 7;
  private uint scenePointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScenePointId {
    get { return scenePointId_; }
    set {
      scenePointId_ = value;
    }
  }

  /// <summary>Field number for the "rot" field.</summary>
  public const int RotFieldNumber = 5;
  private global::Vector rot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Rot {
    get { return rot_; }
    set {
      rot_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CreateVehicleReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CreateVehicleReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Pos, other.Pos)) return false;
    if (VehicleId != other.VehicleId) return false;
    if (ScenePointId != other.ScenePointId) return false;
    if (!object.Equals(Rot, other.Rot)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (pos_ != null) hash ^= Pos.GetHashCode();
    if (VehicleId != 0) hash ^= VehicleId.GetHashCode();
    if (ScenePointId != 0) hash ^= ScenePointId.GetHashCode();
    if (rot_ != null) hash ^= Rot.GetHashCode();
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
    if (VehicleId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(VehicleId);
    }
    if (rot_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Rot);
    }
    if (ScenePointId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ScenePointId);
    }
    if (pos_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(Pos);
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
    if (VehicleId != 0) {
      output.WriteRawTag(16);
      output.WriteUInt32(VehicleId);
    }
    if (rot_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Rot);
    }
    if (ScenePointId != 0) {
      output.WriteRawTag(56);
      output.WriteUInt32(ScenePointId);
    }
    if (pos_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(Pos);
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
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (VehicleId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VehicleId);
    }
    if (ScenePointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScenePointId);
    }
    if (rot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CreateVehicleReq other) {
    if (other == null) {
      return;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
    }
    if (other.VehicleId != 0) {
      VehicleId = other.VehicleId;
    }
    if (other.ScenePointId != 0) {
      ScenePointId = other.ScenePointId;
    }
    if (other.rot_ != null) {
      if (rot_ == null) {
        Rot = new global::Vector();
      }
      Rot.MergeFrom(other.Rot);
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
        case 16: {
          VehicleId = input.ReadUInt32();
          break;
        }
        case 42: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
        case 56: {
          ScenePointId = input.ReadUInt32();
          break;
        }
        case 90: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
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
        case 16: {
          VehicleId = input.ReadUInt32();
          break;
        }
        case 42: {
          if (rot_ == null) {
            Rot = new global::Vector();
          }
          input.ReadMessage(Rot);
          break;
        }
        case 56: {
          ScenePointId = input.ReadUInt32();
          break;
        }
        case 90: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
