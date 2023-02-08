// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterRoute.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MonsterRoute.proto</summary>
  public static partial class MonsterRouteReflection {

    #region Descriptor
    /// <summary>File descriptor for MonsterRoute.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterRouteReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJNb25zdGVyUm91dGUucHJvdG8aEFJvdXRlUG9pbnQucHJvdG8icAoMTW9u",
            "c3RlclJvdXRlEiEKDHJvdXRlX3BvaW50cxgBIAMoCzILLlJvdXRlUG9pbnQS",
            "EwoLc3BlZWRfbGV2ZWwYAiABKA0SEgoKcm91dGVfdHlwZRgDIAEoDRIUCgxh",
            "cnJpdmVfcmFuZ2UYBCABKAJCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.RoutePointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.MonsterRoute), global::NewProtos.MonsterRoute.Parser, new[]{ "RoutePoints", "SpeedLevel", "RouteType", "ArriveRange" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MonsterRoute : pb::IMessage<MonsterRoute>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonsterRoute> _parser = new pb::MessageParser<MonsterRoute>(() => new MonsterRoute());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonsterRoute> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.MonsterRouteReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterRoute() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterRoute(MonsterRoute other) : this() {
      routePoints_ = other.routePoints_.Clone();
      speedLevel_ = other.speedLevel_;
      routeType_ = other.routeType_;
      arriveRange_ = other.arriveRange_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonsterRoute Clone() {
      return new MonsterRoute(this);
    }

    /// <summary>Field number for the "route_points" field.</summary>
    public const int RoutePointsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::NewProtos.RoutePoint> _repeated_routePoints_codec
        = pb::FieldCodec.ForMessage(10, global::NewProtos.RoutePoint.Parser);
    private readonly pbc::RepeatedField<global::NewProtos.RoutePoint> routePoints_ = new pbc::RepeatedField<global::NewProtos.RoutePoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::NewProtos.RoutePoint> RoutePoints {
      get { return routePoints_; }
    }

    /// <summary>Field number for the "speed_level" field.</summary>
    public const int SpeedLevelFieldNumber = 2;
    private uint speedLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SpeedLevel {
      get { return speedLevel_; }
      set {
        speedLevel_ = value;
      }
    }

    /// <summary>Field number for the "route_type" field.</summary>
    public const int RouteTypeFieldNumber = 3;
    private uint routeType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RouteType {
      get { return routeType_; }
      set {
        routeType_ = value;
      }
    }

    /// <summary>Field number for the "arrive_range" field.</summary>
    public const int ArriveRangeFieldNumber = 4;
    private float arriveRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ArriveRange {
      get { return arriveRange_; }
      set {
        arriveRange_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonsterRoute);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonsterRoute other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!routePoints_.Equals(other.routePoints_)) return false;
      if (SpeedLevel != other.SpeedLevel) return false;
      if (RouteType != other.RouteType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ArriveRange, other.ArriveRange)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= routePoints_.GetHashCode();
      if (SpeedLevel != 0) hash ^= SpeedLevel.GetHashCode();
      if (RouteType != 0) hash ^= RouteType.GetHashCode();
      if (ArriveRange != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ArriveRange);
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
      routePoints_.WriteTo(output, _repeated_routePoints_codec);
      if (SpeedLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SpeedLevel);
      }
      if (RouteType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RouteType);
      }
      if (ArriveRange != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(ArriveRange);
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
      routePoints_.WriteTo(ref output, _repeated_routePoints_codec);
      if (SpeedLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SpeedLevel);
      }
      if (RouteType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RouteType);
      }
      if (ArriveRange != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(ArriveRange);
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
      size += routePoints_.CalculateSize(_repeated_routePoints_codec);
      if (SpeedLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SpeedLevel);
      }
      if (RouteType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RouteType);
      }
      if (ArriveRange != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonsterRoute other) {
      if (other == null) {
        return;
      }
      routePoints_.Add(other.routePoints_);
      if (other.SpeedLevel != 0) {
        SpeedLevel = other.SpeedLevel;
      }
      if (other.RouteType != 0) {
        RouteType = other.RouteType;
      }
      if (other.ArriveRange != 0F) {
        ArriveRange = other.ArriveRange;
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
            routePoints_.AddEntriesFrom(input, _repeated_routePoints_codec);
            break;
          }
          case 16: {
            SpeedLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            RouteType = input.ReadUInt32();
            break;
          }
          case 37: {
            ArriveRange = input.ReadFloat();
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
            routePoints_.AddEntriesFrom(ref input, _repeated_routePoints_codec);
            break;
          }
          case 16: {
            SpeedLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            RouteType = input.ReadUInt32();
            break;
          }
          case 37: {
            ArriveRange = input.ReadFloat();
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
