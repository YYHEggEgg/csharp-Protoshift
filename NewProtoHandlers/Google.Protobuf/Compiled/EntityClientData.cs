// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EntityClientData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from EntityClientData.proto</summary>
public static partial class EntityClientDataReflection {

  #region Descriptor
  /// <summary>File descriptor for EntityClientData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static EntityClientDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZFbnRpdHlDbGllbnREYXRhLnByb3RvInEKEEVudGl0eUNsaWVudERhdGES",
          "HgoWd2luZF9jaGFuZ2Vfc2NlbmVfdGltZRgBIAEoDRIbChN3aW5kbWlsbF9z",
          "eW5jX2FuZ2xlGAIgASgCEiAKGHdpbmRfY2hhbmdlX3RhcmdldF9sZXZlbBgD",
          "IAEoBUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::EntityClientData), global::EntityClientData.Parser, new[]{ "WindChangeSceneTime", "WindmillSyncAngle", "WindChangeTargetLevel" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class EntityClientData : pb::IMessage<EntityClientData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<EntityClientData> _parser = new pb::MessageParser<EntityClientData>(() => new EntityClientData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<EntityClientData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::EntityClientDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityClientData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityClientData(EntityClientData other) : this() {
    windChangeSceneTime_ = other.windChangeSceneTime_;
    windmillSyncAngle_ = other.windmillSyncAngle_;
    windChangeTargetLevel_ = other.windChangeTargetLevel_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public EntityClientData Clone() {
    return new EntityClientData(this);
  }

  /// <summary>Field number for the "wind_change_scene_time" field.</summary>
  public const int WindChangeSceneTimeFieldNumber = 1;
  private uint windChangeSceneTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint WindChangeSceneTime {
    get { return windChangeSceneTime_; }
    set {
      windChangeSceneTime_ = value;
    }
  }

  /// <summary>Field number for the "windmill_sync_angle" field.</summary>
  public const int WindmillSyncAngleFieldNumber = 2;
  private float windmillSyncAngle_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float WindmillSyncAngle {
    get { return windmillSyncAngle_; }
    set {
      windmillSyncAngle_ = value;
    }
  }

  /// <summary>Field number for the "wind_change_target_level" field.</summary>
  public const int WindChangeTargetLevelFieldNumber = 3;
  private int windChangeTargetLevel_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int WindChangeTargetLevel {
    get { return windChangeTargetLevel_; }
    set {
      windChangeTargetLevel_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as EntityClientData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(EntityClientData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (WindChangeSceneTime != other.WindChangeSceneTime) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(WindmillSyncAngle, other.WindmillSyncAngle)) return false;
    if (WindChangeTargetLevel != other.WindChangeTargetLevel) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (WindChangeSceneTime != 0) hash ^= WindChangeSceneTime.GetHashCode();
    if (WindmillSyncAngle != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(WindmillSyncAngle);
    if (WindChangeTargetLevel != 0) hash ^= WindChangeTargetLevel.GetHashCode();
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
    if (WindChangeSceneTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(WindChangeSceneTime);
    }
    if (WindmillSyncAngle != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(WindmillSyncAngle);
    }
    if (WindChangeTargetLevel != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(WindChangeTargetLevel);
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
    if (WindChangeSceneTime != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(WindChangeSceneTime);
    }
    if (WindmillSyncAngle != 0F) {
      output.WriteRawTag(21);
      output.WriteFloat(WindmillSyncAngle);
    }
    if (WindChangeTargetLevel != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(WindChangeTargetLevel);
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
    if (WindChangeSceneTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WindChangeSceneTime);
    }
    if (WindmillSyncAngle != 0F) {
      size += 1 + 4;
    }
    if (WindChangeTargetLevel != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(WindChangeTargetLevel);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(EntityClientData other) {
    if (other == null) {
      return;
    }
    if (other.WindChangeSceneTime != 0) {
      WindChangeSceneTime = other.WindChangeSceneTime;
    }
    if (other.WindmillSyncAngle != 0F) {
      WindmillSyncAngle = other.WindmillSyncAngle;
    }
    if (other.WindChangeTargetLevel != 0) {
      WindChangeTargetLevel = other.WindChangeTargetLevel;
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
          WindChangeSceneTime = input.ReadUInt32();
          break;
        }
        case 21: {
          WindmillSyncAngle = input.ReadFloat();
          break;
        }
        case 24: {
          WindChangeTargetLevel = input.ReadInt32();
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
          WindChangeSceneTime = input.ReadUInt32();
          break;
        }
        case 21: {
          WindmillSyncAngle = input.ReadFloat();
          break;
        }
        case 24: {
          WindChangeTargetLevel = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
