// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from WinterCampStageInfo.proto</summary>
public static partial class WinterCampStageInfoReflection {

  #region Descriptor
  /// <summary>File descriptor for WinterCampStageInfo.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static WinterCampStageInfoReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChlXaW50ZXJDYW1wU3RhZ2VJbmZvLnByb3RvGgxWZWN0b3IucHJvdG8ijQEK",
          "E1dpbnRlckNhbXBTdGFnZUluZm8SFAoMY3VyX3Byb2dyZXNzGAwgASgNEgoK",
          "AmlkGAYgASgNEhEKCW9wZW5fdGltZRgIIAEoDRITCgtpc19maW5pc2hlZBgK",
          "IAEoCBIWCg50b3RhbF9wcm9ncmVzcxgJIAEoDRIUCgNwb3MYBSABKAsyBy5W",
          "ZWN0b3JCHgocZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::WinterCampStageInfo), global::WinterCampStageInfo.Parser, new[]{ "CurProgress", "Id", "OpenTime", "IsFinished", "TotalProgress", "Pos" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class WinterCampStageInfo : pb::IMessage<WinterCampStageInfo>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<WinterCampStageInfo> _parser = new pb::MessageParser<WinterCampStageInfo>(() => new WinterCampStageInfo());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<WinterCampStageInfo> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::WinterCampStageInfoReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WinterCampStageInfo() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WinterCampStageInfo(WinterCampStageInfo other) : this() {
    curProgress_ = other.curProgress_;
    id_ = other.id_;
    openTime_ = other.openTime_;
    isFinished_ = other.isFinished_;
    totalProgress_ = other.totalProgress_;
    pos_ = other.pos_ != null ? other.pos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public WinterCampStageInfo Clone() {
    return new WinterCampStageInfo(this);
  }

  /// <summary>Field number for the "cur_progress" field.</summary>
  public const int CurProgressFieldNumber = 12;
  private uint curProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurProgress {
    get { return curProgress_; }
    set {
      curProgress_ = value;
    }
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 6;
  private uint id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "open_time" field.</summary>
  public const int OpenTimeFieldNumber = 8;
  private uint openTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint OpenTime {
    get { return openTime_; }
    set {
      openTime_ = value;
    }
  }

  /// <summary>Field number for the "is_finished" field.</summary>
  public const int IsFinishedFieldNumber = 10;
  private bool isFinished_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsFinished {
    get { return isFinished_; }
    set {
      isFinished_ = value;
    }
  }

  /// <summary>Field number for the "total_progress" field.</summary>
  public const int TotalProgressFieldNumber = 9;
  private uint totalProgress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint TotalProgress {
    get { return totalProgress_; }
    set {
      totalProgress_ = value;
    }
  }

  /// <summary>Field number for the "pos" field.</summary>
  public const int PosFieldNumber = 5;
  private global::Vector pos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector Pos {
    get { return pos_; }
    set {
      pos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as WinterCampStageInfo);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(WinterCampStageInfo other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (CurProgress != other.CurProgress) return false;
    if (Id != other.Id) return false;
    if (OpenTime != other.OpenTime) return false;
    if (IsFinished != other.IsFinished) return false;
    if (TotalProgress != other.TotalProgress) return false;
    if (!object.Equals(Pos, other.Pos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (CurProgress != 0) hash ^= CurProgress.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
    if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
    if (IsFinished != false) hash ^= IsFinished.GetHashCode();
    if (TotalProgress != 0) hash ^= TotalProgress.GetHashCode();
    if (pos_ != null) hash ^= Pos.GetHashCode();
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
    if (pos_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Pos);
    }
    if (Id != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Id);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(OpenTime);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(TotalProgress);
    }
    if (IsFinished != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinished);
    }
    if (CurProgress != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CurProgress);
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
    if (pos_ != null) {
      output.WriteRawTag(42);
      output.WriteMessage(Pos);
    }
    if (Id != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(Id);
    }
    if (OpenTime != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(OpenTime);
    }
    if (TotalProgress != 0) {
      output.WriteRawTag(72);
      output.WriteUInt32(TotalProgress);
    }
    if (IsFinished != false) {
      output.WriteRawTag(80);
      output.WriteBool(IsFinished);
    }
    if (CurProgress != 0) {
      output.WriteRawTag(96);
      output.WriteUInt32(CurProgress);
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
    if (CurProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurProgress);
    }
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
    }
    if (OpenTime != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
    }
    if (IsFinished != false) {
      size += 1 + 1;
    }
    if (TotalProgress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalProgress);
    }
    if (pos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(WinterCampStageInfo other) {
    if (other == null) {
      return;
    }
    if (other.CurProgress != 0) {
      CurProgress = other.CurProgress;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.OpenTime != 0) {
      OpenTime = other.OpenTime;
    }
    if (other.IsFinished != false) {
      IsFinished = other.IsFinished;
    }
    if (other.TotalProgress != 0) {
      TotalProgress = other.TotalProgress;
    }
    if (other.pos_ != null) {
      if (pos_ == null) {
        Pos = new global::Vector();
      }
      Pos.MergeFrom(other.Pos);
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
        case 42: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 48: {
          Id = input.ReadUInt32();
          break;
        }
        case 64: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 72: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 80: {
          IsFinished = input.ReadBool();
          break;
        }
        case 96: {
          CurProgress = input.ReadUInt32();
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
        case 42: {
          if (pos_ == null) {
            Pos = new global::Vector();
          }
          input.ReadMessage(Pos);
          break;
        }
        case 48: {
          Id = input.ReadUInt32();
          break;
        }
        case 64: {
          OpenTime = input.ReadUInt32();
          break;
        }
        case 72: {
          TotalProgress = input.ReadUInt32();
          break;
        }
        case 80: {
          IsFinished = input.ReadBool();
          break;
        }
        case 96: {
          CurProgress = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
