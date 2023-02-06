// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegionSearch.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RegionSearch.proto</summary>
public static partial class RegionSearchReflection {

  #region Descriptor
  /// <summary>File descriptor for RegionSearch.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RegionSearchReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChJSZWdpb25TZWFyY2gucHJvdG8aF1JlZ2lvblNlYXJjaFN0YXRlLnByb3Rv",
          "InEKDFJlZ2lvblNlYXJjaBISCgppc19lbnRlcmVkGA0gASgIEhAKCHByb2dy",
          "ZXNzGAUgASgNEiEKBXN0YXRlGAIgASgOMhIuUmVnaW9uU2VhcmNoU3RhdGUS",
          "GAoQcmVnaW9uX3NlYXJjaF9pZBgIIAEoDUIeChxlbXUuZ3Jhc3NjdXR0ZXIu",
          "bmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::RegionSearchStateReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RegionSearch), global::RegionSearch.Parser, new[]{ "IsEntered", "Progress", "State", "RegionSearchId" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RegionSearch : pb::IMessage<RegionSearch>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<RegionSearch> _parser = new pb::MessageParser<RegionSearch>(() => new RegionSearch());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<RegionSearch> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RegionSearchReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionSearch() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionSearch(RegionSearch other) : this() {
    isEntered_ = other.isEntered_;
    progress_ = other.progress_;
    state_ = other.state_;
    regionSearchId_ = other.regionSearchId_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public RegionSearch Clone() {
    return new RegionSearch(this);
  }

  /// <summary>Field number for the "is_entered" field.</summary>
  public const int IsEnteredFieldNumber = 13;
  private bool isEntered_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool IsEntered {
    get { return isEntered_; }
    set {
      isEntered_ = value;
    }
  }

  /// <summary>Field number for the "progress" field.</summary>
  public const int ProgressFieldNumber = 5;
  private uint progress_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint Progress {
    get { return progress_; }
    set {
      progress_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 2;
  private global::RegionSearchState state_ = global::RegionSearchState.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::RegionSearchState State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  /// <summary>Field number for the "region_search_id" field.</summary>
  public const int RegionSearchIdFieldNumber = 8;
  private uint regionSearchId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint RegionSearchId {
    get { return regionSearchId_; }
    set {
      regionSearchId_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as RegionSearch);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(RegionSearch other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (IsEntered != other.IsEntered) return false;
    if (Progress != other.Progress) return false;
    if (State != other.State) return false;
    if (RegionSearchId != other.RegionSearchId) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (IsEntered != false) hash ^= IsEntered.GetHashCode();
    if (Progress != 0) hash ^= Progress.GetHashCode();
    if (State != global::RegionSearchState.None) hash ^= State.GetHashCode();
    if (RegionSearchId != 0) hash ^= RegionSearchId.GetHashCode();
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
    if (State != global::RegionSearchState.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (Progress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Progress);
    }
    if (RegionSearchId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(RegionSearchId);
    }
    if (IsEntered != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsEntered);
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
    if (State != global::RegionSearchState.None) {
      output.WriteRawTag(16);
      output.WriteEnum((int) State);
    }
    if (Progress != 0) {
      output.WriteRawTag(40);
      output.WriteUInt32(Progress);
    }
    if (RegionSearchId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(RegionSearchId);
    }
    if (IsEntered != false) {
      output.WriteRawTag(104);
      output.WriteBool(IsEntered);
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
    if (IsEntered != false) {
      size += 1 + 1;
    }
    if (Progress != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
    }
    if (State != global::RegionSearchState.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (RegionSearchId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionSearchId);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(RegionSearch other) {
    if (other == null) {
      return;
    }
    if (other.IsEntered != false) {
      IsEntered = other.IsEntered;
    }
    if (other.Progress != 0) {
      Progress = other.Progress;
    }
    if (other.State != global::RegionSearchState.None) {
      State = other.State;
    }
    if (other.RegionSearchId != 0) {
      RegionSearchId = other.RegionSearchId;
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
        case 16: {
          State = (global::RegionSearchState) input.ReadEnum();
          break;
        }
        case 40: {
          Progress = input.ReadUInt32();
          break;
        }
        case 64: {
          RegionSearchId = input.ReadUInt32();
          break;
        }
        case 104: {
          IsEntered = input.ReadBool();
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
        case 16: {
          State = (global::RegionSearchState) input.ReadEnum();
          break;
        }
        case 40: {
          Progress = input.ReadUInt32();
          break;
        }
        case 64: {
          RegionSearchId = input.ReadUInt32();
          break;
        }
        case 104: {
          IsEntered = input.ReadBool();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
