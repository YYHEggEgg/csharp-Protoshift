// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IslandPartyRaftInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IslandPartyRaftInfoNotify.proto</summary>
public static partial class IslandPartyRaftInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for IslandPartyRaftInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IslandPartyRaftInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9Jc2xhbmRQYXJ0eVJhZnRJbmZvTm90aWZ5LnByb3RvInUKGUlzbGFuZFBh",
          "cnR5UmFmdEluZm9Ob3RpZnkSGwoTVW5rMzMwMF9ITkVDRUdOTUtOSxgEIAEo",
          "DRIbChNVbmszMzAwX0ZCQUNNT0ZHUEdKGAEgASgNEhAKCHBvaW50X2lkGAgg",
          "ASgNEgwKBGNvaW4YDiABKA1CFgoUb3JnLnNvcmFwb2ludGEucHJvdG9iBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IslandPartyRaftInfoNotify), global::IslandPartyRaftInfoNotify.Parser, new[]{ "Unk3300HNECEGNMKNK", "Unk3300FBACMOFGPGJ", "PointId", "Coin" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 5589;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class IslandPartyRaftInfoNotify : pb::IMessage<IslandPartyRaftInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IslandPartyRaftInfoNotify> _parser = new pb::MessageParser<IslandPartyRaftInfoNotify>(() => new IslandPartyRaftInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IslandPartyRaftInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IslandPartyRaftInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IslandPartyRaftInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IslandPartyRaftInfoNotify(IslandPartyRaftInfoNotify other) : this() {
    unk3300HNECEGNMKNK_ = other.unk3300HNECEGNMKNK_;
    unk3300FBACMOFGPGJ_ = other.unk3300FBACMOFGPGJ_;
    pointId_ = other.pointId_;
    coin_ = other.coin_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IslandPartyRaftInfoNotify Clone() {
    return new IslandPartyRaftInfoNotify(this);
  }

  /// <summary>Field number for the "Unk3300_HNECEGNMKNK" field.</summary>
  public const int Unk3300HNECEGNMKNKFieldNumber = 4;
  private uint unk3300HNECEGNMKNK_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300HNECEGNMKNK {
    get { return unk3300HNECEGNMKNK_; }
    set {
      unk3300HNECEGNMKNK_ = value;
    }
  }

  /// <summary>Field number for the "Unk3300_FBACMOFGPGJ" field.</summary>
  public const int Unk3300FBACMOFGPGJFieldNumber = 1;
  private uint unk3300FBACMOFGPGJ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Unk3300FBACMOFGPGJ {
    get { return unk3300FBACMOFGPGJ_; }
    set {
      unk3300FBACMOFGPGJ_ = value;
    }
  }

  /// <summary>Field number for the "point_id" field.</summary>
  public const int PointIdFieldNumber = 8;
  private uint pointId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PointId {
    get { return pointId_; }
    set {
      pointId_ = value;
    }
  }

  /// <summary>Field number for the "coin" field.</summary>
  public const int CoinFieldNumber = 14;
  private uint coin_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Coin {
    get { return coin_; }
    set {
      coin_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IslandPartyRaftInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IslandPartyRaftInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Unk3300HNECEGNMKNK != other.Unk3300HNECEGNMKNK) return false;
    if (Unk3300FBACMOFGPGJ != other.Unk3300FBACMOFGPGJ) return false;
    if (PointId != other.PointId) return false;
    if (Coin != other.Coin) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (Unk3300HNECEGNMKNK != 0) hash ^= Unk3300HNECEGNMKNK.GetHashCode();
    if (Unk3300FBACMOFGPGJ != 0) hash ^= Unk3300FBACMOFGPGJ.GetHashCode();
    if (PointId != 0) hash ^= PointId.GetHashCode();
    if (Coin != 0) hash ^= Coin.GetHashCode();
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
    if (Unk3300FBACMOFGPGJ != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Unk3300FBACMOFGPGJ);
    }
    if (Unk3300HNECEGNMKNK != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300HNECEGNMKNK);
    }
    if (PointId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(PointId);
    }
    if (Coin != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Coin);
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
    if (Unk3300FBACMOFGPGJ != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(Unk3300FBACMOFGPGJ);
    }
    if (Unk3300HNECEGNMKNK != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(Unk3300HNECEGNMKNK);
    }
    if (PointId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(PointId);
    }
    if (Coin != 0) {
      output.WriteRawTag(112);
      output.WriteUInt32(Coin);
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
    if (Unk3300HNECEGNMKNK != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HNECEGNMKNK);
    }
    if (Unk3300FBACMOFGPGJ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FBACMOFGPGJ);
    }
    if (PointId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
    }
    if (Coin != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IslandPartyRaftInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.Unk3300HNECEGNMKNK != 0) {
      Unk3300HNECEGNMKNK = other.Unk3300HNECEGNMKNK;
    }
    if (other.Unk3300FBACMOFGPGJ != 0) {
      Unk3300FBACMOFGPGJ = other.Unk3300FBACMOFGPGJ;
    }
    if (other.PointId != 0) {
      PointId = other.PointId;
    }
    if (other.Coin != 0) {
      Coin = other.Coin;
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
          Unk3300FBACMOFGPGJ = input.ReadUInt32();
          break;
        }
        case 32: {
          Unk3300HNECEGNMKNK = input.ReadUInt32();
          break;
        }
        case 64: {
          PointId = input.ReadUInt32();
          break;
        }
        case 112: {
          Coin = input.ReadUInt32();
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
          Unk3300FBACMOFGPGJ = input.ReadUInt32();
          break;
        }
        case 32: {
          Unk3300HNECEGNMKNK = input.ReadUInt32();
          break;
        }
        case 64: {
          PointId = input.ReadUInt32();
          break;
        }
        case 112: {
          Coin = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
