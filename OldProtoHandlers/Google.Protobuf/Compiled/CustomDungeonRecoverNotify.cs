// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonRecoverNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from CustomDungeonRecoverNotify.proto</summary>
public static partial class CustomDungeonRecoverNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for CustomDungeonRecoverNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static CustomDungeonRecoverNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CiBDdXN0b21EdW5nZW9uUmVjb3Zlck5vdGlmeS5wcm90bxoTQ3VzdG9tRHVu",
          "Z2Vvbi5wcm90bxocRW50ZXJDdXN0b21EdW5nZW9uVHlwZS5wcm90bxoaVHJ5",
          "Q3VzdG9tRHVuZ2VvblR5cGUucHJvdG8ivAEKGkN1c3RvbUR1bmdlb25SZWNv",
          "dmVyTm90aWZ5EisKCmVudGVyX3R5cGUYDiABKA4yFy5FbnRlckN1c3RvbUR1",
          "bmdlb25UeXBlEicKCHRyeV90eXBlGAMgASgOMhUuVHJ5Q3VzdG9tRHVuZ2Vv",
          "blR5cGUSJgoOY3VzdG9tX2R1bmdlb24YCiABKAsyDi5DdXN0b21EdW5nZW9u",
          "EiAKGG9mZmljaWFsX2JsYWNrX2NvaW5fbGlzdBgMIAMoDUIeChxlbXUuZ3Jh",
          "c3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::CustomDungeonReflection.Descriptor, global::EnterCustomDungeonTypeReflection.Descriptor, global::TryCustomDungeonTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::CustomDungeonRecoverNotify), global::CustomDungeonRecoverNotify.Parser, new[]{ "EnterType", "TryType", "CustomDungeon", "OfficialBlackCoinList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 6217
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class CustomDungeonRecoverNotify : pb::IMessage<CustomDungeonRecoverNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<CustomDungeonRecoverNotify> _parser = new pb::MessageParser<CustomDungeonRecoverNotify>(() => new CustomDungeonRecoverNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<CustomDungeonRecoverNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::CustomDungeonRecoverNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRecoverNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRecoverNotify(CustomDungeonRecoverNotify other) : this() {
    enterType_ = other.enterType_;
    tryType_ = other.tryType_;
    customDungeon_ = other.customDungeon_ != null ? other.customDungeon_.Clone() : null;
    officialBlackCoinList_ = other.officialBlackCoinList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public CustomDungeonRecoverNotify Clone() {
    return new CustomDungeonRecoverNotify(this);
  }

  /// <summary>Field number for the "enter_type" field.</summary>
  public const int EnterTypeFieldNumber = 14;
  private global::EnterCustomDungeonType enterType_ = global::EnterCustomDungeonType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::EnterCustomDungeonType EnterType {
    get { return enterType_; }
    set {
      enterType_ = value;
    }
  }

  /// <summary>Field number for the "try_type" field.</summary>
  public const int TryTypeFieldNumber = 3;
  private global::TryCustomDungeonType tryType_ = global::TryCustomDungeonType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::TryCustomDungeonType TryType {
    get { return tryType_; }
    set {
      tryType_ = value;
    }
  }

  /// <summary>Field number for the "custom_dungeon" field.</summary>
  public const int CustomDungeonFieldNumber = 10;
  private global::CustomDungeon customDungeon_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::CustomDungeon CustomDungeon {
    get { return customDungeon_; }
    set {
      customDungeon_ = value;
    }
  }

  /// <summary>Field number for the "official_black_coin_list" field.</summary>
  public const int OfficialBlackCoinListFieldNumber = 12;
  private static readonly pb::FieldCodec<uint> _repeated_officialBlackCoinList_codec
      = pb::FieldCodec.ForUInt32(98);
  private readonly pbc::RepeatedField<uint> officialBlackCoinList_ = new pbc::RepeatedField<uint>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<uint> OfficialBlackCoinList {
    get { return officialBlackCoinList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as CustomDungeonRecoverNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(CustomDungeonRecoverNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (EnterType != other.EnterType) return false;
    if (TryType != other.TryType) return false;
    if (!object.Equals(CustomDungeon, other.CustomDungeon)) return false;
    if(!officialBlackCoinList_.Equals(other.officialBlackCoinList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (EnterType != global::EnterCustomDungeonType.None) hash ^= EnterType.GetHashCode();
    if (TryType != global::TryCustomDungeonType.None) hash ^= TryType.GetHashCode();
    if (customDungeon_ != null) hash ^= CustomDungeon.GetHashCode();
    hash ^= officialBlackCoinList_.GetHashCode();
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
    if (TryType != global::TryCustomDungeonType.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) TryType);
    }
    if (customDungeon_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(CustomDungeon);
    }
    officialBlackCoinList_.WriteTo(output, _repeated_officialBlackCoinList_codec);
    if (EnterType != global::EnterCustomDungeonType.None) {
      output.WriteRawTag(112);
      output.WriteEnum((int) EnterType);
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
    if (TryType != global::TryCustomDungeonType.None) {
      output.WriteRawTag(24);
      output.WriteEnum((int) TryType);
    }
    if (customDungeon_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(CustomDungeon);
    }
    officialBlackCoinList_.WriteTo(ref output, _repeated_officialBlackCoinList_codec);
    if (EnterType != global::EnterCustomDungeonType.None) {
      output.WriteRawTag(112);
      output.WriteEnum((int) EnterType);
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
    if (EnterType != global::EnterCustomDungeonType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EnterType);
    }
    if (TryType != global::TryCustomDungeonType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TryType);
    }
    if (customDungeon_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomDungeon);
    }
    size += officialBlackCoinList_.CalculateSize(_repeated_officialBlackCoinList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(CustomDungeonRecoverNotify other) {
    if (other == null) {
      return;
    }
    if (other.EnterType != global::EnterCustomDungeonType.None) {
      EnterType = other.EnterType;
    }
    if (other.TryType != global::TryCustomDungeonType.None) {
      TryType = other.TryType;
    }
    if (other.customDungeon_ != null) {
      if (customDungeon_ == null) {
        CustomDungeon = new global::CustomDungeon();
      }
      CustomDungeon.MergeFrom(other.CustomDungeon);
    }
    officialBlackCoinList_.Add(other.officialBlackCoinList_);
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
          TryType = (global::TryCustomDungeonType) input.ReadEnum();
          break;
        }
        case 82: {
          if (customDungeon_ == null) {
            CustomDungeon = new global::CustomDungeon();
          }
          input.ReadMessage(CustomDungeon);
          break;
        }
        case 98:
        case 96: {
          officialBlackCoinList_.AddEntriesFrom(input, _repeated_officialBlackCoinList_codec);
          break;
        }
        case 112: {
          EnterType = (global::EnterCustomDungeonType) input.ReadEnum();
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
          TryType = (global::TryCustomDungeonType) input.ReadEnum();
          break;
        }
        case 82: {
          if (customDungeon_ == null) {
            CustomDungeon = new global::CustomDungeon();
          }
          input.ReadMessage(CustomDungeon);
          break;
        }
        case 98:
        case 96: {
          officialBlackCoinList_.AddEntriesFrom(ref input, _repeated_officialBlackCoinList_codec);
          break;
        }
        case 112: {
          EnterType = (global::EnterCustomDungeonType) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
