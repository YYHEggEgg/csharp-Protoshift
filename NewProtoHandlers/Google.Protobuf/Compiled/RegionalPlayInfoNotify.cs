// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegionalPlayInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RegionalPlayInfoNotify.proto</summary>
public static partial class RegionalPlayInfoNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for RegionalPlayInfoNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RegionalPlayInfoNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxSZWdpb25hbFBsYXlJbmZvTm90aWZ5LnByb3RvGhVSZWdpb25hbFBsYXlW",
          "YXIucHJvdG8ijAEKFlJlZ2lvbmFsUGxheUluZm9Ob3RpZnkSEQoJcGxheV90",
          "eXBlGAMgASgNEiIKCHZhcl9saXN0GA0gAygLMhAuUmVnaW9uYWxQbGF5VmFy",
          "EhEKCXBsYXlfbmFtZRgFIAEoCRISCgppc19lbmFibGVkGAEgASgIEhQKDGlz",
          "X2luX3JlZ2lvbhgOIAEoCEIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJv",
          "dG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::RegionalPlayVarReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RegionalPlayInfoNotify), global::RegionalPlayInfoNotify.Parser, new[]{ "PlayType", "VarList", "PlayName", "IsEnabled", "IsInRegion" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// enum CmdId {
///   option allow_alias = true;
///   NONE = 0;
///   CMD_ID = 6292;
///   ENET_CHANNEL_ID = 0;
///   ENET_IS_RELIABLE = 1;
/// }
/// </summary>
public sealed partial class RegionalPlayInfoNotify : pb::IMessage<RegionalPlayInfoNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RegionalPlayInfoNotify> _parser = new pb::MessageParser<RegionalPlayInfoNotify>(() => new RegionalPlayInfoNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RegionalPlayInfoNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RegionalPlayInfoNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionalPlayInfoNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionalPlayInfoNotify(RegionalPlayInfoNotify other) : this() {
    playType_ = other.playType_;
    varList_ = other.varList_.Clone();
    playName_ = other.playName_;
    isEnabled_ = other.isEnabled_;
    isInRegion_ = other.isInRegion_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionalPlayInfoNotify Clone() {
    return new RegionalPlayInfoNotify(this);
  }

  /// <summary>Field number for the "play_type" field.</summary>
  public const int PlayTypeFieldNumber = 3;
  private uint playType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint PlayType {
    get { return playType_; }
    set {
      playType_ = value;
    }
  }

  /// <summary>Field number for the "var_list" field.</summary>
  public const int VarListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::RegionalPlayVar> _repeated_varList_codec
      = pb::FieldCodec.ForMessage(106, global::RegionalPlayVar.Parser);
  private readonly pbc::RepeatedField<global::RegionalPlayVar> varList_ = new pbc::RepeatedField<global::RegionalPlayVar>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::RegionalPlayVar> VarList {
    get { return varList_; }
  }

  /// <summary>Field number for the "play_name" field.</summary>
  public const int PlayNameFieldNumber = 5;
  private string playName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string PlayName {
    get { return playName_; }
    set {
      playName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "is_enabled" field.</summary>
  public const int IsEnabledFieldNumber = 1;
  private bool isEnabled_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsEnabled {
    get { return isEnabled_; }
    set {
      isEnabled_ = value;
    }
  }

  /// <summary>Field number for the "is_in_region" field.</summary>
  public const int IsInRegionFieldNumber = 14;
  private bool isInRegion_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsInRegion {
    get { return isInRegion_; }
    set {
      isInRegion_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RegionalPlayInfoNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RegionalPlayInfoNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (PlayType != other.PlayType) return false;
    if(!varList_.Equals(other.varList_)) return false;
    if (PlayName != other.PlayName) return false;
    if (IsEnabled != other.IsEnabled) return false;
    if (IsInRegion != other.IsInRegion) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (PlayType != 0) hash ^= PlayType.GetHashCode();
    hash ^= varList_.GetHashCode();
    if (PlayName.Length != 0) hash ^= PlayName.GetHashCode();
    if (IsEnabled != false) hash ^= IsEnabled.GetHashCode();
    if (IsInRegion != false) hash ^= IsInRegion.GetHashCode();
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
    if (IsEnabled != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsEnabled);
    }
    if (PlayType != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(PlayType);
    }
    if (PlayName.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(PlayName);
    }
    varList_.WriteTo(output, _repeated_varList_codec);
    if (IsInRegion != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsInRegion);
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
    if (IsEnabled != false) {
      output.WriteRawTag(8);
      output.WriteBool(IsEnabled);
    }
    if (PlayType != 0) {
      output.WriteRawTag(24);
      output.WriteUInt32(PlayType);
    }
    if (PlayName.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(PlayName);
    }
    varList_.WriteTo(ref output, _repeated_varList_codec);
    if (IsInRegion != false) {
      output.WriteRawTag(112);
      output.WriteBool(IsInRegion);
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
    if (PlayType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
    }
    size += varList_.CalculateSize(_repeated_varList_codec);
    if (PlayName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayName);
    }
    if (IsEnabled != false) {
      size += 1 + 1;
    }
    if (IsInRegion != false) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RegionalPlayInfoNotify other) {
    if (other == null) {
      return;
    }
    if (other.PlayType != 0) {
      PlayType = other.PlayType;
    }
    varList_.Add(other.varList_);
    if (other.PlayName.Length != 0) {
      PlayName = other.PlayName;
    }
    if (other.IsEnabled != false) {
      IsEnabled = other.IsEnabled;
    }
    if (other.IsInRegion != false) {
      IsInRegion = other.IsInRegion;
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
          IsEnabled = input.ReadBool();
          break;
        }
        case 24: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 42: {
          PlayName = input.ReadString();
          break;
        }
        case 106: {
          varList_.AddEntriesFrom(input, _repeated_varList_codec);
          break;
        }
        case 112: {
          IsInRegion = input.ReadBool();
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
          IsEnabled = input.ReadBool();
          break;
        }
        case 24: {
          PlayType = input.ReadUInt32();
          break;
        }
        case 42: {
          PlayName = input.ReadString();
          break;
        }
        case 106: {
          varList_.AddEntriesFrom(ref input, _repeated_varList_codec);
          break;
        }
        case 112: {
          IsInRegion = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
