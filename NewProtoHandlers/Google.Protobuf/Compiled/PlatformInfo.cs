// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlatformInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from PlatformInfo.proto</summary>
public static partial class PlatformInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for PlatformInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static PlatformInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJQbGF0Zm9ybUluZm8ucHJvdG8aFE1hdGhRdWF0ZXJuaW9uLnByb3RvGhhN",
          "b3ZpbmdQbGF0Zm9ybVR5cGUucHJvdG8aC1JvdXRlLnByb3RvGgxWZWN0b3Iu",
          "cHJvdG8ihwMKDFBsYXRmb3JtSW5mbxIQCghyb3V0ZV9pZBgBIAEoDRITCgtz",
          "dGFydF9pbmRleBgCIAEoBRIYChBzdGFydF9yb3V0ZV90aW1lGAMgASgNEhgK",
          "EHN0YXJ0X3NjZW5lX3RpbWUYBCABKA0SGgoJc3RhcnRfcG9zGAcgASgLMgcu",
          "VmVjdG9yEhIKCmlzX3N0YXJ0ZWQYCCABKAgSIgoJc3RhcnRfcm90GAkgASgL",
          "Mg8uTWF0aFF1YXRlcm5pb24SFwoPc3RvcF9zY2VuZV90aW1lGAogASgNEhsK",
          "CnBvc19vZmZzZXQYCyABKAsyBy5WZWN0b3ISIwoKcm90X29mZnNldBgMIAEo",
          "CzIPLk1hdGhRdWF0ZXJuaW9uEjEKFG1vdmluZ19wbGF0Zm9ybV90eXBlGA0g",
          "ASgOMhMuTW92aW5nUGxhdGZvcm1UeXBlEhEKCWlzX2FjdGl2ZRgOIAEoCBIV",
          "CgVyb3V0ZRgPIAEoCzIGLlJvdXRlEhAKCHBvaW50X2lkGBAgASgNQhYKFG9y",
          "Zy5zb3JhcG9pbnRhLnByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MathQuaternionReflection.Descriptor, global::MovingPlatformTypeReflection.Descriptor, global::RouteReflection.Descriptor, global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::PlatformInfo), global::PlatformInfo.Parser, new[]{ "RouteId", "StartIndex", "StartRouteTime", "StartSceneTime", "StartPos", "IsStarted", "StartRot", "StopSceneTime", "PosOffset", "RotOffset", "MovingPlatformType", "IsActive", "Route", "PointId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class PlatformInfo : pb::IMessage<PlatformInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<PlatformInfo> _parser = new pb::MessageParser<PlatformInfo>(() => new PlatformInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<PlatformInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::PlatformInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlatformInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlatformInfo(PlatformInfo other) : this() {
    routeId_ = other.routeId_;
    startIndex_ = other.startIndex_;
    startRouteTime_ = other.startRouteTime_;
    startSceneTime_ = other.startSceneTime_;
    startPos_ = other.startPos_ != null ? other.startPos_.Clone() : null;
    isStarted_ = other.isStarted_;
    startRot_ = other.startRot_ != null ? other.startRot_.Clone() : null;
    stopSceneTime_ = other.stopSceneTime_;
    posOffset_ = other.posOffset_ != null ? other.posOffset_.Clone() : null;
    rotOffset_ = other.rotOffset_ != null ? other.rotOffset_.Clone() : null;
    movingPlatformType_ = other.movingPlatformType_;
    isActive_ = other.isActive_;
    route_ = other.route_ != null ? other.route_.Clone() : null;
    pointId_ = other.pointId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public PlatformInfo Clone() {
    return new PlatformInfo(this);
  }

  /// <summary>Field number for the "route_id" field.</summary>
  public const int RouteIdFieldNumber = 1;
  private uint routeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RouteId {
    get { return routeId_; }
    set {
      routeId_ = value;
    }
  }

  /// <summary>Field number for the "start_index" field.</summary>
  public const int StartIndexFieldNumber = 2;
  private int startIndex_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int StartIndex {
    get { return startIndex_; }
    set {
      startIndex_ = value;
    }
  }

  /// <summary>Field number for the "start_route_time" field.</summary>
  public const int StartRouteTimeFieldNumber = 3;
  private uint startRouteTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartRouteTime {
    get { return startRouteTime_; }
    set {
      startRouteTime_ = value;
    }
  }

  /// <summary>Field number for the "start_scene_time" field.</summary>
  public const int StartSceneTimeFieldNumber = 4;
  private uint startSceneTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StartSceneTime {
    get { return startSceneTime_; }
    set {
      startSceneTime_ = value;
    }
  }

  /// <summary>Field number for the "start_pos" field.</summary>
  public const int StartPosFieldNumber = 7;
  private global::Vector startPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector StartPos {
    get { return startPos_; }
    set {
      startPos_ = value;
    }
  }

  /// <summary>Field number for the "is_started" field.</summary>
  public const int IsStartedFieldNumber = 8;
  private bool isStarted_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsStarted {
    get { return isStarted_; }
    set {
      isStarted_ = value;
    }
  }

  /// <summary>Field number for the "start_rot" field.</summary>
  public const int StartRotFieldNumber = 9;
  private global::MathQuaternion startRot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MathQuaternion StartRot {
    get { return startRot_; }
    set {
      startRot_ = value;
    }
  }

  /// <summary>Field number for the "stop_scene_time" field.</summary>
  public const int StopSceneTimeFieldNumber = 10;
  private uint stopSceneTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint StopSceneTime {
    get { return stopSceneTime_; }
    set {
      stopSceneTime_ = value;
    }
  }

  /// <summary>Field number for the "pos_offset" field.</summary>
  public const int PosOffsetFieldNumber = 11;
  private global::Vector posOffset_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector PosOffset {
    get { return posOffset_; }
    set {
      posOffset_ = value;
    }
  }

  /// <summary>Field number for the "rot_offset" field.</summary>
  public const int RotOffsetFieldNumber = 12;
  private global::MathQuaternion rotOffset_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MathQuaternion RotOffset {
    get { return rotOffset_; }
    set {
      rotOffset_ = value;
    }
  }

  /// <summary>Field number for the "moving_platform_type" field.</summary>
  public const int MovingPlatformTypeFieldNumber = 13;
  private global::MovingPlatformType movingPlatformType_ = global::MovingPlatformType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MovingPlatformType MovingPlatformType {
    get { return movingPlatformType_; }
    set {
      movingPlatformType_ = value;
    }
  }

  /// <summary>Field number for the "is_active" field.</summary>
  public const int IsActiveFieldNumber = 14;
  private bool isActive_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsActive {
    get { return isActive_; }
    set {
      isActive_ = value;
    }
  }

  /// <summary>Field number for the "route" field.</summary>
  public const int RouteFieldNumber = 15;
  private global::Route route_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Route Route {
    get { return route_; }
    set {
      route_ = value;
    }
  }

  /// <summary>Field number for the "point_id" field.</summary>
  public const int PointIdFieldNumber = 16;
  private uint pointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointId {
    get { return pointId_; }
    set {
      pointId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as PlatformInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(PlatformInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RouteId != other.RouteId) return false;
    if (StartIndex != other.StartIndex) return false;
    if (StartRouteTime != other.StartRouteTime) return false;
    if (StartSceneTime != other.StartSceneTime) return false;
    if (!object.Equals(StartPos, other.StartPos)) return false;
    if (IsStarted != other.IsStarted) return false;
    if (!object.Equals(StartRot, other.StartRot)) return false;
    if (StopSceneTime != other.StopSceneTime) return false;
    if (!object.Equals(PosOffset, other.PosOffset)) return false;
    if (!object.Equals(RotOffset, other.RotOffset)) return false;
    if (MovingPlatformType != other.MovingPlatformType) return false;
    if (IsActive != other.IsActive) return false;
    if (!object.Equals(Route, other.Route)) return false;
    if (PointId != other.PointId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RouteId != 0) hash ^= RouteId.GetHashCode();
    if (StartIndex != 0) hash ^= StartIndex.GetHashCode();
    if (StartRouteTime != 0) hash ^= StartRouteTime.GetHashCode();
    if (StartSceneTime != 0) hash ^= StartSceneTime.GetHashCode();
    if (startPos_ != null) hash ^= StartPos.GetHashCode();
    if (IsStarted != false) hash ^= IsStarted.GetHashCode();
    if (startRot_ != null) hash ^= StartRot.GetHashCode();
    if (StopSceneTime != 0) hash ^= StopSceneTime.GetHashCode();
    if (posOffset_ != null) hash ^= PosOffset.GetHashCode();
    if (rotOffset_ != null) hash ^= RotOffset.GetHashCode();
    if (MovingPlatformType != global::MovingPlatformType.None) hash ^= MovingPlatformType.GetHashCode();
    if (IsActive != false) hash ^= IsActive.GetHashCode();
    if (route_ != null) hash ^= Route.GetHashCode();
    if (PointId != 0) hash ^= PointId.GetHashCode();
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
    if (RouteId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(RouteId);
    }
    if (StartIndex != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(StartIndex);
    }
    if (StartRouteTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(StartRouteTime);
    }
    if (StartSceneTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StartSceneTime);
    }
    if (startPos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(StartPos);
    }
    if (IsStarted != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsStarted);
    }
    if (startRot_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(StartRot);
    }
    if (StopSceneTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StopSceneTime);
    }
    if (posOffset_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(PosOffset);
    }
    if (rotOffset_ != null) {
      output.WriteRawTag(98);
      output.WriteMessage(RotOffset);
    }
    if (MovingPlatformType != global::MovingPlatformType.None) {
      output.WriteRawTag(104);
      output.WriteEnum((int) MovingPlatformType);
    }
    if (IsActive != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsActive);
    }
    if (route_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Route);
    }
    if (PointId != 0) {
      output.WriteRawTag(128, 1);
      output.WriteUInt32(PointId);
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
    if (RouteId != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(RouteId);
    }
    if (StartIndex != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(StartIndex);
    }
    if (StartRouteTime != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(StartRouteTime);
    }
    if (StartSceneTime != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(StartSceneTime);
    }
    if (startPos_ != null) {
      output.WriteRawTag(58);
      output.WriteMessage(StartPos);
    }
    if (IsStarted != false) {
      output.WriteRawTag(64);
      output.WriteBool(IsStarted);
    }
    if (startRot_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(StartRot);
    }
    if (StopSceneTime != 0) {
      output.WriteRawTag(80);
      output.WriteUInt32(StopSceneTime);
    }
    if (posOffset_ != null) {
      output.WriteRawTag(90);
      output.WriteMessage(PosOffset);
    }
    if (rotOffset_ != null) {
      output.WriteRawTag(98);
      output.WriteMessage(RotOffset);
    }
    if (MovingPlatformType != global::MovingPlatformType.None) {
      output.WriteRawTag(104);
      output.WriteEnum((int) MovingPlatformType);
    }
    if (IsActive != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsActive);
    }
    if (route_ != null) {
      output.WriteRawTag(122);
      output.WriteMessage(Route);
    }
    if (PointId != 0) {
      output.WriteRawTag(128, 1);
      output.WriteUInt32(PointId);
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
    if (RouteId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RouteId);
    }
    if (StartIndex != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartIndex);
    }
    if (StartRouteTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartRouteTime);
    }
    if (StartSceneTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartSceneTime);
    }
    if (startPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartPos);
    }
    if (IsStarted != false) {
      size += 1 + 1;
    }
    if (startRot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartRot);
    }
    if (StopSceneTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StopSceneTime);
    }
    if (posOffset_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(PosOffset);
    }
    if (rotOffset_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RotOffset);
    }
    if (MovingPlatformType != global::MovingPlatformType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MovingPlatformType);
    }
    if (IsActive != false) {
      size += 1 + 1;
    }
    if (route_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Route);
    }
    if (PointId != 0) {
      size += 2 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(PlatformInfo other) {
    if (other == null) {
      return;
    }
    if (other.RouteId != 0) {
      RouteId = other.RouteId;
    }
    if (other.StartIndex != 0) {
      StartIndex = other.StartIndex;
    }
    if (other.StartRouteTime != 0) {
      StartRouteTime = other.StartRouteTime;
    }
    if (other.StartSceneTime != 0) {
      StartSceneTime = other.StartSceneTime;
    }
    if (other.startPos_ != null) {
      if (startPos_ == null) {
        StartPos = new global::Vector();
      }
      StartPos.MergeFrom(other.StartPos);
    }
    if (other.IsStarted != false) {
      IsStarted = other.IsStarted;
    }
    if (other.startRot_ != null) {
      if (startRot_ == null) {
        StartRot = new global::MathQuaternion();
      }
      StartRot.MergeFrom(other.StartRot);
    }
    if (other.StopSceneTime != 0) {
      StopSceneTime = other.StopSceneTime;
    }
    if (other.posOffset_ != null) {
      if (posOffset_ == null) {
        PosOffset = new global::Vector();
      }
      PosOffset.MergeFrom(other.PosOffset);
    }
    if (other.rotOffset_ != null) {
      if (rotOffset_ == null) {
        RotOffset = new global::MathQuaternion();
      }
      RotOffset.MergeFrom(other.RotOffset);
    }
    if (other.MovingPlatformType != global::MovingPlatformType.None) {
      MovingPlatformType = other.MovingPlatformType;
    }
    if (other.IsActive != false) {
      IsActive = other.IsActive;
    }
    if (other.route_ != null) {
      if (route_ == null) {
        Route = new global::Route();
      }
      Route.MergeFrom(other.Route);
    }
    if (other.PointId != 0) {
      PointId = other.PointId;
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
          RouteId = input.ReadUInt32();
          break;
        }
        case 16: {
          StartIndex = input.ReadInt32();
          break;
        }
        case 24: {
          StartRouteTime = input.ReadUInt32();
          break;
        }
        case 32: {
          StartSceneTime = input.ReadUInt32();
          break;
        }
        case 58: {
          if (startPos_ == null) {
            StartPos = new global::Vector();
          }
          input.ReadMessage(StartPos);
          break;
        }
        case 64: {
          IsStarted = input.ReadBool();
          break;
        }
        case 74: {
          if (startRot_ == null) {
            StartRot = new global::MathQuaternion();
          }
          input.ReadMessage(StartRot);
          break;
        }
        case 80: {
          StopSceneTime = input.ReadUInt32();
          break;
        }
        case 90: {
          if (posOffset_ == null) {
            PosOffset = new global::Vector();
          }
          input.ReadMessage(PosOffset);
          break;
        }
        case 98: {
          if (rotOffset_ == null) {
            RotOffset = new global::MathQuaternion();
          }
          input.ReadMessage(RotOffset);
          break;
        }
        case 104: {
          MovingPlatformType = (global::MovingPlatformType) input.ReadEnum();
          break;
        }
        case 112: {
          IsActive = input.ReadBool();
          break;
        }
        case 122: {
          if (route_ == null) {
            Route = new global::Route();
          }
          input.ReadMessage(Route);
          break;
        }
        case 128: {
          PointId = input.ReadUInt32();
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
          RouteId = input.ReadUInt32();
          break;
        }
        case 16: {
          StartIndex = input.ReadInt32();
          break;
        }
        case 24: {
          StartRouteTime = input.ReadUInt32();
          break;
        }
        case 32: {
          StartSceneTime = input.ReadUInt32();
          break;
        }
        case 58: {
          if (startPos_ == null) {
            StartPos = new global::Vector();
          }
          input.ReadMessage(StartPos);
          break;
        }
        case 64: {
          IsStarted = input.ReadBool();
          break;
        }
        case 74: {
          if (startRot_ == null) {
            StartRot = new global::MathQuaternion();
          }
          input.ReadMessage(StartRot);
          break;
        }
        case 80: {
          StopSceneTime = input.ReadUInt32();
          break;
        }
        case 90: {
          if (posOffset_ == null) {
            PosOffset = new global::Vector();
          }
          input.ReadMessage(PosOffset);
          break;
        }
        case 98: {
          if (rotOffset_ == null) {
            RotOffset = new global::MathQuaternion();
          }
          input.ReadMessage(RotOffset);
          break;
        }
        case 104: {
          MovingPlatformType = (global::MovingPlatformType) input.ReadEnum();
          break;
        }
        case 112: {
          IsActive = input.ReadBool();
          break;
        }
        case 122: {
          if (route_ == null) {
            Route = new global::Route();
          }
          input.ReadMessage(Route);
          break;
        }
        case 128: {
          PointId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
