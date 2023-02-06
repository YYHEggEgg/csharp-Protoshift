// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldPlayerLocationNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WorldPlayerLocationNotify.proto</summary>
public static partial class WorldPlayerLocationNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for WorldPlayerLocationNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WorldPlayerLocationNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Ch9Xb3JsZFBsYXllckxvY2F0aW9uTm90aWZ5LnByb3RvGhhQbGF5ZXJMb2Nh",
          "dGlvbkluZm8ucHJvdG8aHVBsYXllcldvcmxkTG9jYXRpb25JbmZvLnByb3Rv",
          "IoIBChlXb3JsZFBsYXllckxvY2F0aW9uTm90aWZ5EjcKFXBsYXllcl93b3Js",
          "ZF9sb2NfbGlzdBgIIAMoCzIYLlBsYXllcldvcmxkTG9jYXRpb25JbmZvEiwK",
          "D3BsYXllcl9sb2NfbGlzdBgPIAMoCzITLlBsYXllckxvY2F0aW9uSW5mb0Ie",
          "ChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::PlayerLocationInfoReflection.Descriptor, global::PlayerWorldLocationInfoReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WorldPlayerLocationNotify), global::WorldPlayerLocationNotify.Parser, new[]{ "PlayerWorldLocList", "PlayerLocList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 258
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class WorldPlayerLocationNotify : pb::IMessage<WorldPlayerLocationNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WorldPlayerLocationNotify> _parser = new pb::MessageParser<WorldPlayerLocationNotify>(() => new WorldPlayerLocationNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WorldPlayerLocationNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WorldPlayerLocationNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldPlayerLocationNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldPlayerLocationNotify(WorldPlayerLocationNotify other) : this() {
    playerWorldLocList_ = other.playerWorldLocList_.Clone();
    playerLocList_ = other.playerLocList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WorldPlayerLocationNotify Clone() {
    return new WorldPlayerLocationNotify(this);
  }

  /// <summary>Field number for the "player_world_loc_list" field.</summary>
  public const int PlayerWorldLocListFieldNumber = 8;
  private static readonly pb::FieldCodec<global::PlayerWorldLocationInfo> _repeated_playerWorldLocList_codec
      = pb::FieldCodec.ForMessage(66, global::PlayerWorldLocationInfo.Parser);
  private readonly pbc::RepeatedField<global::PlayerWorldLocationInfo> playerWorldLocList_ = new pbc::RepeatedField<global::PlayerWorldLocationInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::PlayerWorldLocationInfo> PlayerWorldLocList {
    get { return playerWorldLocList_; }
  }

  /// <summary>Field number for the "player_loc_list" field.</summary>
  public const int PlayerLocListFieldNumber = 15;
  private static readonly pb::FieldCodec<global::PlayerLocationInfo> _repeated_playerLocList_codec
      = pb::FieldCodec.ForMessage(122, global::PlayerLocationInfo.Parser);
  private readonly pbc::RepeatedField<global::PlayerLocationInfo> playerLocList_ = new pbc::RepeatedField<global::PlayerLocationInfo>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::PlayerLocationInfo> PlayerLocList {
    get { return playerLocList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WorldPlayerLocationNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WorldPlayerLocationNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!playerWorldLocList_.Equals(other.playerWorldLocList_)) return false;
    if(!playerLocList_.Equals(other.playerLocList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= playerWorldLocList_.GetHashCode();
    hash ^= playerLocList_.GetHashCode();
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
    playerWorldLocList_.WriteTo(output, _repeated_playerWorldLocList_codec);
    playerLocList_.WriteTo(output, _repeated_playerLocList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    playerWorldLocList_.WriteTo(ref output, _repeated_playerWorldLocList_codec);
    playerLocList_.WriteTo(ref output, _repeated_playerLocList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += playerWorldLocList_.CalculateSize(_repeated_playerWorldLocList_codec);
    size += playerLocList_.CalculateSize(_repeated_playerLocList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WorldPlayerLocationNotify other) {
    if (other == null) {
      return;
    }
    playerWorldLocList_.Add(other.playerWorldLocList_);
    playerLocList_.Add(other.playerLocList_);
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
        case 66: {
          playerWorldLocList_.AddEntriesFrom(input, _repeated_playerWorldLocList_codec);
          break;
        }
        case 122: {
          playerLocList_.AddEntriesFrom(input, _repeated_playerLocList_codec);
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
        case 66: {
          playerWorldLocList_.AddEntriesFrom(ref input, _repeated_playerWorldLocList_codec);
          break;
        }
        case 122: {
          playerLocList_.AddEntriesFrom(ref input, _repeated_playerLocList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
