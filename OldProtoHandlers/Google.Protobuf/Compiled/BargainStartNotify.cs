// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BargainStartNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from BargainStartNotify.proto</summary>
public static partial class BargainStartNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for BargainStartNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static BargainStartNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChhCYXJnYWluU3RhcnROb3RpZnkucHJvdG8aFUJhcmdhaW5TbmFwc2hvdC5w",
          "cm90byJMChJCYXJnYWluU3RhcnROb3RpZnkSEgoKYmFyZ2Fpbl9pZBgEIAEo",
          "DRIiCghzbmFwc2hvdBgCIAEoCzIQLkJhcmdhaW5TbmFwc2hvdEIeChxlbXUu",
          "Z3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BargainSnapshotReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::BargainStartNotify), global::BargainStartNotify.Parser, new[]{ "BargainId", "Snapshot" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 404
/// EnetChannelId: 0
/// EnetIsReliable: true
/// </summary>
public sealed partial class BargainStartNotify : pb::IMessage<BargainStartNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<BargainStartNotify> _parser = new pb::MessageParser<BargainStartNotify>(() => new BargainStartNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<BargainStartNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::BargainStartNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BargainStartNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BargainStartNotify(BargainStartNotify other) : this() {
    bargainId_ = other.bargainId_;
    snapshot_ = other.snapshot_ != null ? other.snapshot_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public BargainStartNotify Clone() {
    return new BargainStartNotify(this);
  }

  /// <summary>Field number for the "bargain_id" field.</summary>
  public const int BargainIdFieldNumber = 4;
  private uint bargainId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint BargainId {
    get { return bargainId_; }
    set {
      bargainId_ = value;
    }
  }

  /// <summary>Field number for the "snapshot" field.</summary>
  public const int SnapshotFieldNumber = 2;
  private global::BargainSnapshot snapshot_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::BargainSnapshot Snapshot {
    get { return snapshot_; }
    set {
      snapshot_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as BargainStartNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(BargainStartNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (BargainId != other.BargainId) return false;
    if (!object.Equals(Snapshot, other.Snapshot)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (BargainId != 0) hash ^= BargainId.GetHashCode();
    if (snapshot_ != null) hash ^= Snapshot.GetHashCode();
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
    if (snapshot_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Snapshot);
    }
    if (BargainId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(BargainId);
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
    if (snapshot_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(Snapshot);
    }
    if (BargainId != 0) {
      output.WriteRawTag(32);
      output.WriteUInt32(BargainId);
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
    if (BargainId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BargainId);
    }
    if (snapshot_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Snapshot);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(BargainStartNotify other) {
    if (other == null) {
      return;
    }
    if (other.BargainId != 0) {
      BargainId = other.BargainId;
    }
    if (other.snapshot_ != null) {
      if (snapshot_ == null) {
        Snapshot = new global::BargainSnapshot();
      }
      Snapshot.MergeFrom(other.Snapshot);
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
        case 18: {
          if (snapshot_ == null) {
            Snapshot = new global::BargainSnapshot();
          }
          input.ReadMessage(Snapshot);
          break;
        }
        case 32: {
          BargainId = input.ReadUInt32();
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
        case 18: {
          if (snapshot_ == null) {
            Snapshot = new global::BargainSnapshot();
          }
          input.ReadMessage(Snapshot);
          break;
        }
        case 32: {
          BargainId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
