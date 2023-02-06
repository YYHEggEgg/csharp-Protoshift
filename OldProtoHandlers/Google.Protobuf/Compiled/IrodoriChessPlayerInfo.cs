// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessPlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriChessPlayerInfo.proto</summary>
public static partial class IrodoriChessPlayerInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriChessPlayerInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriChessPlayerInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxJcm9kb3JpQ2hlc3NQbGF5ZXJJbmZvLnByb3RvIlQKFklyb2RvcmlDaGVz",
          "c1BsYXllckluZm8SCwoDdWlkGAQgASgNEhcKD2J1aWxkaW5nX3BvaW50cxgJ",
          "IAEoDRIUCgxzZXR0bGVfc2NvcmUYAyABKA1CHgocZW11LmdyYXNzY3V0dGVy",
          "Lm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriChessPlayerInfo), global::IrodoriChessPlayerInfo.Parser, new[]{ "Uid", "BuildingPoints", "SettleScore" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IrodoriChessPlayerInfo : pb::IMessage<IrodoriChessPlayerInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriChessPlayerInfo> _parser = new pb::MessageParser<IrodoriChessPlayerInfo>(() => new IrodoriChessPlayerInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriChessPlayerInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriChessPlayerInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessPlayerInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessPlayerInfo(IrodoriChessPlayerInfo other) : this() {
    uid_ = other.uid_;
    buildingPoints_ = other.buildingPoints_;
    settleScore_ = other.settleScore_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessPlayerInfo Clone() {
    return new IrodoriChessPlayerInfo(this);
  }

  /// <summary>Field number for the "uid" field.</summary>
  public const int UidFieldNumber = 4;
  private uint uid_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Uid {
    get { return uid_; }
    set {
      uid_ = value;
    }
  }

  /// <summary>Field number for the "building_points" field.</summary>
  public const int BuildingPointsFieldNumber = 9;
  private uint buildingPoints_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BuildingPoints {
    get { return buildingPoints_; }
    set {
      buildingPoints_ = value;
    }
  }

  /// <summary>Field number for the "settle_score" field.</summary>
  public const int SettleScoreFieldNumber = 3;
  private uint settleScore_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SettleScore {
    get { return settleScore_; }
    set {
      settleScore_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriChessPlayerInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriChessPlayerInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Uid != other.Uid) return false;
    if (BuildingPoints != other.BuildingPoints) return false;
    if (SettleScore != other.SettleScore) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Uid != 0) hash ^= Uid.GetHashCode();
    if (BuildingPoints != 0) hash ^= BuildingPoints.GetHashCode();
    if (SettleScore != 0) hash ^= SettleScore.GetHashCode();
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
    if (SettleScore != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SettleScore);
    }
    if (Uid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Uid);
    }
    if (BuildingPoints != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(BuildingPoints);
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
    if (SettleScore != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(SettleScore);
    }
    if (Uid != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Uid);
    }
    if (BuildingPoints != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(BuildingPoints);
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
    if (Uid != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
    }
    if (BuildingPoints != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuildingPoints);
    }
    if (SettleScore != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SettleScore);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriChessPlayerInfo other) {
    if (other == null) {
      return;
    }
    if (other.Uid != 0) {
      Uid = other.Uid;
    }
    if (other.BuildingPoints != 0) {
      BuildingPoints = other.BuildingPoints;
    }
    if (other.SettleScore != 0) {
      SettleScore = other.SettleScore;
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
        case 24: {
          SettleScore = input.ReadUInt32();
          break;
        }
        case 32: {
          Uid = input.ReadUInt32();
          break;
        }
        case 72: {
          BuildingPoints = input.ReadUInt32();
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
        case 24: {
          SettleScore = input.ReadUInt32();
          break;
        }
        case 32: {
          Uid = input.ReadUInt32();
          break;
        }
        case 72: {
          BuildingPoints = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code