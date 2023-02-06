// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryIslandPartyRaftInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from SceneGalleryIslandPartyRaftInfo.proto</summary>
public static partial class SceneGalleryIslandPartyRaftInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for SceneGalleryIslandPartyRaftInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SceneGalleryIslandPartyRaftInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiVTY2VuZUdhbGxlcnlJc2xhbmRQYXJ0eVJhZnRJbmZvLnByb3RvGhhHYWxs",
          "ZXJ5U3RhcnRTb3VyY2UucHJvdG8ipQEKH1NjZW5lR2FsbGVyeUlzbGFuZFBh",
          "cnR5UmFmdEluZm8SDAoEY29pbhgGIAEoDRIpCgxzdGFydF9zb3VyY2UYByAB",
          "KA4yEy5HYWxsZXJ5U3RhcnRTb3VyY2USEQoJY29tcG9uZW50GAEgASgNEgwK",
          "BGZ1ZWwYDyABKA0SEAoIcG9pbnRfaWQYDCABKA0SFgoOcmFmdF9lbnRpdHlf",
          "aWQYBCABKA1CHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::GalleryStartSourceReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SceneGalleryIslandPartyRaftInfo), global::SceneGalleryIslandPartyRaftInfo.Parser, new[]{ "Coin", "StartSource", "Component", "Fuel", "PointId", "RaftEntityId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SceneGalleryIslandPartyRaftInfo : pb::IMessage<SceneGalleryIslandPartyRaftInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SceneGalleryIslandPartyRaftInfo> _parser = new pb::MessageParser<SceneGalleryIslandPartyRaftInfo>(() => new SceneGalleryIslandPartyRaftInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SceneGalleryIslandPartyRaftInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SceneGalleryIslandPartyRaftInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryIslandPartyRaftInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryIslandPartyRaftInfo(SceneGalleryIslandPartyRaftInfo other) : this() {
    coin_ = other.coin_;
    startSource_ = other.startSource_;
    component_ = other.component_;
    fuel_ = other.fuel_;
    pointId_ = other.pointId_;
    raftEntityId_ = other.raftEntityId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SceneGalleryIslandPartyRaftInfo Clone() {
    return new SceneGalleryIslandPartyRaftInfo(this);
  }

  /// <summary>Field number for the "coin" field.</summary>
  public const int CoinFieldNumber = 6;
  private uint coin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Coin {
    get { return coin_; }
    set {
      coin_ = value;
    }
  }

  /// <summary>Field number for the "start_source" field.</summary>
  public const int StartSourceFieldNumber = 7;
  private global::GalleryStartSource startSource_ = global::GalleryStartSource.ByNone;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::GalleryStartSource StartSource {
    get { return startSource_; }
    set {
      startSource_ = value;
    }
  }

  /// <summary>Field number for the "component" field.</summary>
  public const int ComponentFieldNumber = 1;
  private uint component_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Component {
    get { return component_; }
    set {
      component_ = value;
    }
  }

  /// <summary>Field number for the "fuel" field.</summary>
  public const int FuelFieldNumber = 15;
  private uint fuel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Fuel {
    get { return fuel_; }
    set {
      fuel_ = value;
    }
  }

  /// <summary>Field number for the "point_id" field.</summary>
  public const int PointIdFieldNumber = 12;
  private uint pointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointId {
    get { return pointId_; }
    set {
      pointId_ = value;
    }
  }

  /// <summary>Field number for the "raft_entity_id" field.</summary>
  public const int RaftEntityIdFieldNumber = 4;
  private uint raftEntityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RaftEntityId {
    get { return raftEntityId_; }
    set {
      raftEntityId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SceneGalleryIslandPartyRaftInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SceneGalleryIslandPartyRaftInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Coin != other.Coin) return false;
    if (StartSource != other.StartSource) return false;
    if (Component != other.Component) return false;
    if (Fuel != other.Fuel) return false;
    if (PointId != other.PointId) return false;
    if (RaftEntityId != other.RaftEntityId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Coin != 0) hash ^= Coin.GetHashCode();
    if (StartSource != global::GalleryStartSource.ByNone) hash ^= StartSource.GetHashCode();
    if (Component != 0) hash ^= Component.GetHashCode();
    if (Fuel != 0) hash ^= Fuel.GetHashCode();
    if (PointId != 0) hash ^= PointId.GetHashCode();
    if (RaftEntityId != 0) hash ^= RaftEntityId.GetHashCode();
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
    if (Component != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Component);
    }
    if (RaftEntityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(RaftEntityId);
    }
    if (Coin != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Coin);
    }
    if (StartSource != global::GalleryStartSource.ByNone) {
      output.WriteRawTag(56);
      output.WriteEnum((int) StartSource);
    }
    if (PointId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PointId);
    }
    if (Fuel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Fuel);
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
    if (Component != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Component);
    }
    if (RaftEntityId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(RaftEntityId);
    }
    if (Coin != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Coin);
    }
    if (StartSource != global::GalleryStartSource.ByNone) {
      output.WriteRawTag(56);
      output.WriteEnum((int) StartSource);
    }
    if (PointId != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(PointId);
    }
    if (Fuel != 0) {
      output.WriteRawTag(120);
      output.WriteUInt32(Fuel);
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
    if (Coin != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
    }
    if (StartSource != global::GalleryStartSource.ByNone) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StartSource);
    }
    if (Component != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Component);
    }
    if (Fuel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Fuel);
    }
    if (PointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
    }
    if (RaftEntityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RaftEntityId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SceneGalleryIslandPartyRaftInfo other) {
    if (other == null) {
      return;
    }
    if (other.Coin != 0) {
      Coin = other.Coin;
    }
    if (other.StartSource != global::GalleryStartSource.ByNone) {
      StartSource = other.StartSource;
    }
    if (other.Component != 0) {
      Component = other.Component;
    }
    if (other.Fuel != 0) {
      Fuel = other.Fuel;
    }
    if (other.PointId != 0) {
      PointId = other.PointId;
    }
    if (other.RaftEntityId != 0) {
      RaftEntityId = other.RaftEntityId;
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
          Component = input.ReadUInt32();
          break;
        }
        case 32: {
          RaftEntityId = input.ReadUInt32();
          break;
        }
        case 48: {
          Coin = input.ReadUInt32();
          break;
        }
        case 56: {
          StartSource = (global::GalleryStartSource) input.ReadEnum();
          break;
        }
        case 96: {
          PointId = input.ReadUInt32();
          break;
        }
        case 120: {
          Fuel = input.ReadUInt32();
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
          Component = input.ReadUInt32();
          break;
        }
        case 32: {
          RaftEntityId = input.ReadUInt32();
          break;
        }
        case 48: {
          Coin = input.ReadUInt32();
          break;
        }
        case 56: {
          StartSource = (global::GalleryStartSource) input.ReadEnum();
          break;
        }
        case 96: {
          PointId = input.ReadUInt32();
          break;
        }
        case 120: {
          Fuel = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
