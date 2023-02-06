// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriChessData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from IrodoriChessData.proto</summary>
public static partial class IrodoriChessDataReflection {

  #region Descriptor
  /// <summary>File descriptor for IrodoriChessData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static IrodoriChessDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZJcm9kb3JpQ2hlc3NEYXRhLnByb3RvGhtJcm9kb3JpQ2hlc3NMZXZlbERh",
          "dGEucHJvdG8iVAoQSXJvZG9yaUNoZXNzRGF0YRIPCgdpc19vcGVuGAggASgI",
          "Ei8KD2xldmVsX2RhdGFfbGlzdBgNIAMoCzIWLklyb2RvcmlDaGVzc0xldmVs",
          "RGF0YUIWChRvcmcuc29yYXBvaW50YS5wcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::IrodoriChessLevelDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::IrodoriChessData), global::IrodoriChessData.Parser, new[]{ "IsOpen", "LevelDataList" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class IrodoriChessData : pb::IMessage<IrodoriChessData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<IrodoriChessData> _parser = new pb::MessageParser<IrodoriChessData>(() => new IrodoriChessData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<IrodoriChessData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::IrodoriChessDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessData(IrodoriChessData other) : this() {
    isOpen_ = other.isOpen_;
    levelDataList_ = other.levelDataList_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public IrodoriChessData Clone() {
    return new IrodoriChessData(this);
  }

  /// <summary>Field number for the "is_open" field.</summary>
  public const int IsOpenFieldNumber = 8;
  private bool isOpen_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsOpen {
    get { return isOpen_; }
    set {
      isOpen_ = value;
    }
  }

  /// <summary>Field number for the "level_data_list" field.</summary>
  public const int LevelDataListFieldNumber = 13;
  private static readonly pb::FieldCodec<global::IrodoriChessLevelData> _repeated_levelDataList_codec
      = pb::FieldCodec.ForMessage(106, global::IrodoriChessLevelData.Parser);
  private readonly pbc::RepeatedField<global::IrodoriChessLevelData> levelDataList_ = new pbc::RepeatedField<global::IrodoriChessLevelData>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::IrodoriChessLevelData> LevelDataList {
    get { return levelDataList_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as IrodoriChessData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(IrodoriChessData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsOpen != other.IsOpen) return false;
    if(!levelDataList_.Equals(other.levelDataList_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsOpen != false) hash ^= IsOpen.GetHashCode();
    hash ^= levelDataList_.GetHashCode();
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
      output.WriteRawTag(64);
      output.WriteBool(IsOpen);
    }
    levelDataList_.WriteTo(output, _repeated_levelDataList_codec);
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
      output.WriteRawTag(64);
      output.WriteBool(IsOpen);
    }
    levelDataList_.WriteTo(ref output, _repeated_levelDataList_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (IsOpen != false) {
      size += 1 + 1;
    }
    size += levelDataList_.CalculateSize(_repeated_levelDataList_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(IrodoriChessData other) {
    if (other == null) {
      return;
    }
    if (other.IsOpen != false) {
      IsOpen = other.IsOpen;
    }
    levelDataList_.Add(other.levelDataList_);
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
        case 64: {
          IsOpen = input.ReadBool();
          break;
        }
        case 106: {
          levelDataList_.AddEntriesFrom(input, _repeated_levelDataList_codec);
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
        case 64: {
          IsOpen = input.ReadBool();
          break;
        }
        case 106: {
          levelDataList_.AddEntriesFrom(ref input, _repeated_levelDataList_codec);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code