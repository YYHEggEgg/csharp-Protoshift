// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureSeelieRegionData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TreasureSeelieRegionData.proto</summary>
public static partial class TreasureSeelieRegionDataReflection {

  #region Descriptor
  /// <summary>File descriptor for TreasureSeelieRegionData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TreasureSeelieRegionDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch5UcmVhc3VyZVNlZWxpZVJlZ2lvbkRhdGEucHJvdG8aDFZlY3Rvci5wcm90",
          "byKGAgoYVHJlYXN1cmVTZWVsaWVSZWdpb25EYXRhEhEKCXJlZ2lvbl9pZBgP",
          "IAEoDRIPCgdpc19vcGVuGAEgASgIEhEKCW9wZW5fdGltZRgLIAEoDRIiChFy",
          "ZWdpb25fY2VudGVyX3BvcxgJIAEoCzIHLlZlY3RvchIbChNVbmszMzAwX0NQ",
          "SE9KTk1FREJDGAggASgNEhUKDXJlZ2lvbl9yYWRpdXMYBiABKAISGwoTVW5r",
          "MzMwMF9LR0VDT0lJS0pMShgFIAEoDRIbChNVbmszMzAwX0FGQU1IUENFSUtQ",
          "GA4gASgNEg8KB2lzX2RvbmUYCiABKAgSEAoIc2NlbmVfaWQYAyABKA1CFgoU",
          "b3JnLnNvcmFwb2ludGEucHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TreasureSeelieRegionData), global::TreasureSeelieRegionData.Parser, new[]{ "RegionId", "IsOpen", "OpenTime", "RegionCenterPos", "Unk3300CPHOJNMEDBC", "RegionRadius", "Unk3300KGECOIIKJLJ", "Unk3300AFAMHPCEIKP", "IsDone", "SceneId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class TreasureSeelieRegionData : pb::IMessage<TreasureSeelieRegionData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<TreasureSeelieRegionData> _parser = new pb::MessageParser<TreasureSeelieRegionData>(() => new TreasureSeelieRegionData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<TreasureSeelieRegionData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TreasureSeelieRegionDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TreasureSeelieRegionData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TreasureSeelieRegionData(TreasureSeelieRegionData other) : this() {
    regionId_ = other.regionId_;
    isOpen_ = other.isOpen_;
    openTime_ = other.openTime_;
    regionCenterPos_ = other.regionCenterPos_ != null ? other.regionCenterPos_.Clone() : null;
    unk3300CPHOJNMEDBC_ = other.unk3300CPHOJNMEDBC_;
    regionRadius_ = other.regionRadius_;
    unk3300KGECOIIKJLJ_ = other.unk3300KGECOIIKJLJ_;
    unk3300AFAMHPCEIKP_ = other.unk3300AFAMHPCEIKP_;
    isDone_ = other.isDone_;
    sceneId_ = other.sceneId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public TreasureSeelieRegionData Clone() {
    return new TreasureSeelieRegionData(this);
  }

  /// <summary>Field number for the "region_id" field.</summary>
  public const int RegionIdFieldNumber = 15;
  private uint regionId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RegionId {
    get { return regionId_; }
    set {
      regionId_ = value;
    }
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 1;
  private bool isOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsOpen {
    get { return isOpen_; }
    set {
      isOpen_ = value;
    }
  }

  /// <summary>Field number for the "open_time" field.</summary>
  public const int OpenTimeFieldNumber = 11;
  private uint openTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OpenTime {
    get { return openTime_; }
    set {
      openTime_ = value;
    }
  }

  /// <summary>Field number for the "region_center_pos" field.</summary>
  public const int RegionCenterPosFieldNumber = 9;
  private global::Vector regionCenterPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector RegionCenterPos {
    get { return regionCenterPos_; }
    set {
      regionCenterPos_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_CPHOJNMEDBC" field.</summary>
  public const int Unk3300CPHOJNMEDBCFieldNumber = 8;
  private uint unk3300CPHOJNMEDBC_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300CPHOJNMEDBC {
    get { return unk3300CPHOJNMEDBC_; }
    set {
      unk3300CPHOJNMEDBC_ = value;
    }
  }

  /// <summary>Field number for the "region_radius" field.</summary>
  public const int RegionRadiusFieldNumber = 6;
  private float regionRadius_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float RegionRadius {
    get { return regionRadius_; }
    set {
      regionRadius_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_KGECOIIKJLJ" field.</summary>
  public const int Unk3300KGECOIIKJLJFieldNumber = 5;
  private uint unk3300KGECOIIKJLJ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300KGECOIIKJLJ {
    get { return unk3300KGECOIIKJLJ_; }
    set {
      unk3300KGECOIIKJLJ_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_AFAMHPCEIKP" field.</summary>
  public const int Unk3300AFAMHPCEIKPFieldNumber = 14;
  private uint unk3300AFAMHPCEIKP_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300AFAMHPCEIKP {
    get { return unk3300AFAMHPCEIKP_; }
    set {
      unk3300AFAMHPCEIKP_ = value;
    }
  }

  /// <summary>Field number for the "is_done" field.</summary>
  public const int IsDoneFieldNumber = 10;
  private bool isDone_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsDone {
    get { return isDone_; }
    set {
      isDone_ = value;
    }
  }

  /// <summary>Field number for the "scene_id" field.</summary>
  public const int SceneIdFieldNumber = 3;
  private uint sceneId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SceneId {
    get { return sceneId_; }
    set {
      sceneId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as TreasureSeelieRegionData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(TreasureSeelieRegionData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (RegionId != other.RegionId) return false;
    if (IsOpen != other.IsOpen) return false;
    if (OpenTime != other.OpenTime) return false;
    if (!object.Equals(RegionCenterPos, other.RegionCenterPos)) return false;
    if (Unk3300CPHOJNMEDBC != other.Unk3300CPHOJNMEDBC) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RegionRadius, other.RegionRadius)) return false;
    if (Unk3300KGECOIIKJLJ != other.Unk3300KGECOIIKJLJ) return false;
    if (Unk3300AFAMHPCEIKP != other.Unk3300AFAMHPCEIKP) return false;
    if (IsDone != other.IsDone) return false;
    if (SceneId != other.SceneId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (RegionId != 0) hash ^= RegionId.GetHashCode();
    if (IsOpen != false) hash ^= IsOpen.GetHashCode();
    if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
    if (regionCenterPos_ != null) hash ^= RegionCenterPos.GetHashCode();
    if (Unk3300CPHOJNMEDBC != 0) hash ^= Unk3300CPHOJNMEDBC.GetHashCode();
    if (RegionRadius != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RegionRadius);
    if (Unk3300KGECOIIKJLJ != 0) hash ^= Unk3300KGECOIIKJLJ.GetHashCode();
    if (Unk3300AFAMHPCEIKP != 0) hash ^= Unk3300AFAMHPCEIKP.GetHashCode();
    if (IsDone != false) hash ^= IsDone.GetHashCode();
    if (SceneId != 0) hash ^= SceneId.GetHashCode();
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
    if (IsOpen != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsOpen);
    }
    if (SceneId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SceneId);
    }
    if (Unk3300KGECOIIKJLJ != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Unk3300KGECOIIKJLJ);
    }
    if (RegionRadius != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(RegionRadius);
    }
    if (Unk3300CPHOJNMEDBC != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300CPHOJNMEDBC);
    }
    if (regionCenterPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(RegionCenterPos);
    }
    if (IsDone != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsDone);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(OpenTime);
    }
    if (Unk3300AFAMHPCEIKP != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300AFAMHPCEIKP);
    }
    if (RegionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(RegionId);
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
    if (IsOpen != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsOpen);
    }
    if (SceneId != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SceneId);
    }
    if (Unk3300KGECOIIKJLJ != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Unk3300KGECOIIKJLJ);
    }
    if (RegionRadius != 0F) {
      output.WriteRawTag(53);
      output.WriteFloat(RegionRadius);
    }
    if (Unk3300CPHOJNMEDBC != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(Unk3300CPHOJNMEDBC);
    }
    if (regionCenterPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(RegionCenterPos);
    }
    if (IsDone != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsDone);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(88);
      output.WriteUInt32(OpenTime);
    }
    if (Unk3300AFAMHPCEIKP != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Unk3300AFAMHPCEIKP);
    }
    if (RegionId != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(RegionId);
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
    if (RegionId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionId);
    }
    if (IsOpen != false) {
      size += 1 + 1;
    }
    if (OpenTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
    }
    if (regionCenterPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(RegionCenterPos);
    }
    if (Unk3300CPHOJNMEDBC != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300CPHOJNMEDBC);
    }
    if (RegionRadius != 0F) {
      size += 1 + 4;
    }
    if (Unk3300KGECOIIKJLJ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KGECOIIKJLJ);
    }
    if (Unk3300AFAMHPCEIKP != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AFAMHPCEIKP);
    }
    if (IsDone != false) {
      size += 1 + 1;
    }
    if (SceneId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(TreasureSeelieRegionData other) {
    if (other == null) {
      return;
    }
    if (other.RegionId != 0) {
      RegionId = other.RegionId;
    }
    if (other.IsOpen != false) {
      IsOpen = other.IsOpen;
    }
    if (other.OpenTime != 0) {
      OpenTime = other.OpenTime;
    }
    if (other.regionCenterPos_ != null) {
      if (regionCenterPos_ == null) {
        RegionCenterPos = new global::Vector();
      }
      RegionCenterPos.MergeFrom(other.RegionCenterPos);
    }
    if (other.Unk3300CPHOJNMEDBC != 0) {
      Unk3300CPHOJNMEDBC = other.Unk3300CPHOJNMEDBC;
    }
    if (other.RegionRadius != 0F) {
      RegionRadius = other.RegionRadius;
    }
    if (other.Unk3300KGECOIIKJLJ != 0) {
      Unk3300KGECOIIKJLJ = other.Unk3300KGECOIIKJLJ;
    }
    if (other.Unk3300AFAMHPCEIKP != 0) {
      Unk3300AFAMHPCEIKP = other.Unk3300AFAMHPCEIKP;
    }
    if (other.IsDone != false) {
      IsDone = other.IsDone;
    }
    if (other.SceneId != 0) {
      SceneId = other.SceneId;
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
          IsOpen = input.ReadBool();
          break;
        }
        case 24: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 40: {
          Unk3300KGECOIIKJLJ = input.ReadUInt32();
          break;
        }
        case 53: {
          RegionRadius = input.ReadFloat();
          break;
        }
        case 64: {
          Unk3300CPHOJNMEDBC = input.ReadUInt32();
          break;
        }
        case 74: {
          if (regionCenterPos_ == null) {
            RegionCenterPos = new global::Vector();
          }
          input.ReadMessage(RegionCenterPos);
          break;
        }
        case 80: {
          IsDone = input.ReadBool();
          break;
        }
        case 88: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300AFAMHPCEIKP = input.ReadUInt32();
          break;
        }
        case 120: {
          RegionId = input.ReadUInt32();
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
          IsOpen = input.ReadBool();
          break;
        }
        case 24: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 40: {
          Unk3300KGECOIIKJLJ = input.ReadUInt32();
          break;
        }
        case 53: {
          RegionRadius = input.ReadFloat();
          break;
        }
        case 64: {
          Unk3300CPHOJNMEDBC = input.ReadUInt32();
          break;
        }
        case 74: {
          if (regionCenterPos_ == null) {
            RegionCenterPos = new global::Vector();
          }
          input.ReadMessage(RegionCenterPos);
          break;
        }
        case 80: {
          IsDone = input.ReadBool();
          break;
        }
        case 88: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 112: {
          Unk3300AFAMHPCEIKP = input.ReadUInt32();
          break;
        }
        case 120: {
          RegionId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
