// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingScanRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BlessingScanRsp.proto</summary>
public static partial class BlessingScanRspReflection {

  #region Descriptor
  /// <summary>File descriptor for BlessingScanRsp.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BlessingScanRspReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVCbGVzc2luZ1NjYW5Sc3AucHJvdG8iUQoPQmxlc3NpbmdTY2FuUnNwEhMK",
          "C3NjYW5fcGljX2lkGAQgASgNEg8KB3JldGNvZGUYCyABKAUSGAoQY3VyX2Rh",
          "eV9zY2FuX251bRgBIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHBy",
          "b3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BlessingScanRsp), global::BlessingScanRsp.Parser, new[]{ "ScanPicId", "Retcode", "CurDayScanNum" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 2093
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class BlessingScanRsp : pb::IMessage<BlessingScanRsp>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BlessingScanRsp> _parser = new pb::MessageParser<BlessingScanRsp>(() => new BlessingScanRsp());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BlessingScanRsp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BlessingScanRspReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingScanRsp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingScanRsp(BlessingScanRsp other) : this() {
    scanPicId_ = other.scanPicId_;
    retcode_ = other.retcode_;
    curDayScanNum_ = other.curDayScanNum_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BlessingScanRsp Clone() {
    return new BlessingScanRsp(this);
  }

  /// <summary>Field number for the "scan_pic_id" field.</summary>
  public const int ScanPicIdFieldNumber = 4;
  private uint scanPicId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint ScanPicId {
    get { return scanPicId_; }
    set {
      scanPicId_ = value;
    }
  }

  /// <summary>Field number for the "retcode" field.</summary>
  public const int RetcodeFieldNumber = 11;
  private int retcode_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Retcode {
    get { return retcode_; }
    set {
      retcode_ = value;
    }
  }

  /// <summary>Field number for the "cur_day_scan_num" field.</summary>
  public const int CurDayScanNumFieldNumber = 1;
  private uint curDayScanNum_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CurDayScanNum {
    get { return curDayScanNum_; }
    set {
      curDayScanNum_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BlessingScanRsp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BlessingScanRsp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ScanPicId != other.ScanPicId) return false;
    if (Retcode != other.Retcode) return false;
    if (CurDayScanNum != other.CurDayScanNum) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ScanPicId != 0) hash ^= ScanPicId.GetHashCode();
    if (Retcode != 0) hash ^= Retcode.GetHashCode();
    if (CurDayScanNum != 0) hash ^= CurDayScanNum.GetHashCode();
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
    if (CurDayScanNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(CurDayScanNum);
    }
    if (ScanPicId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ScanPicId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
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
    if (CurDayScanNum != 0) {
      output.WriteRawTag(8);
      output.WriteUInt32(CurDayScanNum);
    }
    if (ScanPicId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(ScanPicId);
    }
    if (Retcode != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(Retcode);
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
    if (ScanPicId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScanPicId);
    }
    if (Retcode != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
    }
    if (CurDayScanNum != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurDayScanNum);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BlessingScanRsp other) {
    if (other == null) {
      return;
    }
    if (other.ScanPicId != 0) {
      ScanPicId = other.ScanPicId;
    }
    if (other.Retcode != 0) {
      Retcode = other.Retcode;
    }
    if (other.CurDayScanNum != 0) {
      CurDayScanNum = other.CurDayScanNum;
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
          CurDayScanNum = input.ReadUInt32();
          break;
        }
        case 32: {
          ScanPicId = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
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
          CurDayScanNum = input.ReadUInt32();
          break;
        }
        case 32: {
          ScanPicId = input.ReadUInt32();
          break;
        }
        case 88: {
          Retcode = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
