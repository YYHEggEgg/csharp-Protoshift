// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ToTheMoonQueryPathReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ToTheMoonQueryPathReq.proto</summary>
public static partial class ToTheMoonQueryPathReqReflection {

  #region Descriptor
  /// <summary>File descriptor for ToTheMoonQueryPathReq.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ToTheMoonQueryPathReqReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChtUb1RoZU1vb25RdWVyeVBhdGhSZXEucHJvdG8aDFZlY3Rvci5wcm90byLv",
          "BAoVVG9UaGVNb29uUXVlcnlQYXRoUmVxEiAKD2Rlc3RpbmF0aW9uX3BvcxgJ",
          "IAEoCzIHLlZlY3RvchITCgtmdXp6eV9yYW5nZRgPIAEoBRI1CgpxdWVyeV90",
          "eXBlGAggASgOMiEuVG9UaGVNb29uUXVlcnlQYXRoUmVxLk9wdGlvblR5cGUS",
          "OAoMYXN0YXJfbWV0aG9kGAEgASgOMiIuVG9UaGVNb29uUXVlcnlQYXRoUmVx",
          "LkFTdGFyTWV0aG9kEhAKCHNjZW5lX2lkGAYgASgNEhAKCHF1ZXJ5X2lkGAsg",
          "ASgFEjYKC2ZpbHRlcl90eXBlGAMgASgOMiEuVG9UaGVNb29uUXVlcnlQYXRo",
          "UmVxLkZpbHRlclR5cGUSDwoHcmVmaW5lZBgNIAEoCBIZChF1c2VfZnVsbF9u",
          "ZWlnaGJvchgFIAEoCBIbCgpzb3VyY2VfcG9zGAogASgLMgcuVmVjdG9yIjoK",
          "Ck9wdGlvblR5cGUSFAoQT1BUSU9OX1RZUEVfTk9ORRAAEhYKEk9QVElPTl9U",
          "WVBFX05PUk1BTBABIn4KC0FTdGFyTWV0aG9kEhkKFUFfU1RBUl9NRVRIT0Rf",
          "Q0xBU1NJQxAAEhoKFkFfU1RBUl9NRVRIT0RfVEVOREVOQ1kQARIaChZBX1NU",
          "QVJfTUVUSE9EX0FEQVBUSVZFEAISHAoYQV9TVEFSX01FVEhPRF9JTkZMRUNU",
          "SU9OEAMiTQoKRmlsdGVyVHlwZRITCg9GSUxURVJfVFlQRV9BTEwQABITCg9G",
          "SUxURVJfVFlQRV9BSVIQARIVChFGSUxURVJfVFlQRV9XQVRFUhACQh4KHGVt",
          "dS5ncmFzc2N1dHRlci5uZXQub2xkcHJvdG9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::VectorReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ToTheMoonQueryPathReq), global::ToTheMoonQueryPathReq.Parser, new[]{ "DestinationPos", "FuzzyRange", "QueryType", "AstarMethod", "SceneId", "QueryId", "FilterType", "Refined", "UseFullNeighbor", "SourcePos" }, null, new[]{ typeof(global::ToTheMoonQueryPathReq.Types.OptionType), typeof(global::ToTheMoonQueryPathReq.Types.AStarMethod), typeof(global::ToTheMoonQueryPathReq.Types.FilterType) }, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 6172
/// EnetChannelId: 0
/// EnetIsReliable: true
/// IsAllowClient: true
/// </summary>
public sealed partial class ToTheMoonQueryPathReq : pb::IMessage<ToTheMoonQueryPathReq>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ToTheMoonQueryPathReq> _parser = new pb::MessageParser<ToTheMoonQueryPathReq>(() => new ToTheMoonQueryPathReq());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ToTheMoonQueryPathReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ToTheMoonQueryPathReqReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ToTheMoonQueryPathReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ToTheMoonQueryPathReq(ToTheMoonQueryPathReq other) : this() {
    destinationPos_ = other.destinationPos_ != null ? other.destinationPos_.Clone() : null;
    fuzzyRange_ = other.fuzzyRange_;
    queryType_ = other.queryType_;
    astarMethod_ = other.astarMethod_;
    sceneId_ = other.sceneId_;
    queryId_ = other.queryId_;
    filterType_ = other.filterType_;
    refined_ = other.refined_;
    useFullNeighbor_ = other.useFullNeighbor_;
    sourcePos_ = other.sourcePos_ != null ? other.sourcePos_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ToTheMoonQueryPathReq Clone() {
    return new ToTheMoonQueryPathReq(this);
  }

  /// <summary>Field number for the "destination_pos" field.</summary>
  public const int DestinationPosFieldNumber = 9;
  private global::Vector destinationPos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector DestinationPos {
    get { return destinationPos_; }
    set {
      destinationPos_ = value;
    }
  }

  /// <summary>Field number for the "fuzzy_range" field.</summary>
  public const int FuzzyRangeFieldNumber = 15;
  private int fuzzyRange_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int FuzzyRange {
    get { return fuzzyRange_; }
    set {
      fuzzyRange_ = value;
    }
  }

  /// <summary>Field number for the "query_type" field.</summary>
  public const int QueryTypeFieldNumber = 8;
  private global::ToTheMoonQueryPathReq.Types.OptionType queryType_ = global::ToTheMoonQueryPathReq.Types.OptionType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ToTheMoonQueryPathReq.Types.OptionType QueryType {
    get { return queryType_; }
    set {
      queryType_ = value;
    }
  }

  /// <summary>Field number for the "astar_method" field.</summary>
  public const int AstarMethodFieldNumber = 1;
  private global::ToTheMoonQueryPathReq.Types.AStarMethod astarMethod_ = global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ToTheMoonQueryPathReq.Types.AStarMethod AstarMethod {
    get { return astarMethod_; }
    set {
      astarMethod_ = value;
    }
  }

  /// <summary>Field number for the "scene_id" field.</summary>
  public const int SceneIdFieldNumber = 6;
  private uint sceneId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint SceneId {
    get { return sceneId_; }
    set {
      sceneId_ = value;
    }
  }

  /// <summary>Field number for the "query_id" field.</summary>
  public const int QueryIdFieldNumber = 11;
  private int queryId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int QueryId {
    get { return queryId_; }
    set {
      queryId_ = value;
    }
  }

  /// <summary>Field number for the "filter_type" field.</summary>
  public const int FilterTypeFieldNumber = 3;
  private global::ToTheMoonQueryPathReq.Types.FilterType filterType_ = global::ToTheMoonQueryPathReq.Types.FilterType.All;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ToTheMoonQueryPathReq.Types.FilterType FilterType {
    get { return filterType_; }
    set {
      filterType_ = value;
    }
  }

  /// <summary>Field number for the "refined" field.</summary>
  public const int RefinedFieldNumber = 13;
  private bool refined_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Refined {
    get { return refined_; }
    set {
      refined_ = value;
    }
  }

  /// <summary>Field number for the "use_full_neighbor" field.</summary>
  public const int UseFullNeighborFieldNumber = 5;
  private bool useFullNeighbor_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool UseFullNeighbor {
    get { return useFullNeighbor_; }
    set {
      useFullNeighbor_ = value;
    }
  }

  /// <summary>Field number for the "source_pos" field.</summary>
  public const int SourcePosFieldNumber = 10;
  private global::Vector sourcePos_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::Vector SourcePos {
    get { return sourcePos_; }
    set {
      sourcePos_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ToTheMoonQueryPathReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ToTheMoonQueryPathReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(DestinationPos, other.DestinationPos)) return false;
    if (FuzzyRange != other.FuzzyRange) return false;
    if (QueryType != other.QueryType) return false;
    if (AstarMethod != other.AstarMethod) return false;
    if (SceneId != other.SceneId) return false;
    if (QueryId != other.QueryId) return false;
    if (FilterType != other.FilterType) return false;
    if (Refined != other.Refined) return false;
    if (UseFullNeighbor != other.UseFullNeighbor) return false;
    if (!object.Equals(SourcePos, other.SourcePos)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (destinationPos_ != null) hash ^= DestinationPos.GetHashCode();
    if (FuzzyRange != 0) hash ^= FuzzyRange.GetHashCode();
    if (QueryType != global::ToTheMoonQueryPathReq.Types.OptionType.None) hash ^= QueryType.GetHashCode();
    if (AstarMethod != global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic) hash ^= AstarMethod.GetHashCode();
    if (SceneId != 0) hash ^= SceneId.GetHashCode();
    if (QueryId != 0) hash ^= QueryId.GetHashCode();
    if (FilterType != global::ToTheMoonQueryPathReq.Types.FilterType.All) hash ^= FilterType.GetHashCode();
    if (Refined != false) hash ^= Refined.GetHashCode();
    if (UseFullNeighbor != false) hash ^= UseFullNeighbor.GetHashCode();
    if (sourcePos_ != null) hash ^= SourcePos.GetHashCode();
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
    if (AstarMethod != global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
      output.WriteRawTag(8);
      output.WriteEnum((int) AstarMethod);
    }
    if (FilterType != global::ToTheMoonQueryPathReq.Types.FilterType.All) {
      output.WriteRawTag(24);
      output.WriteEnum((int) FilterType);
    }
    if (UseFullNeighbor != false) {
      output.WriteRawTag(40);
      output.WriteBool(UseFullNeighbor);
    }
    if (SceneId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(SceneId);
    }
    if (QueryType != global::ToTheMoonQueryPathReq.Types.OptionType.None) {
      output.WriteRawTag(64);
      output.WriteEnum((int) QueryType);
    }
    if (destinationPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(DestinationPos);
    }
    if (sourcePos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(SourcePos);
    }
    if (QueryId != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(QueryId);
    }
    if (Refined != false) {
      output.WriteRawTag(104);
      output.WriteBool(Refined);
    }
    if (FuzzyRange != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(FuzzyRange);
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
    if (AstarMethod != global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
      output.WriteRawTag(8);
      output.WriteEnum((int) AstarMethod);
    }
    if (FilterType != global::ToTheMoonQueryPathReq.Types.FilterType.All) {
      output.WriteRawTag(24);
      output.WriteEnum((int) FilterType);
    }
    if (UseFullNeighbor != false) {
      output.WriteRawTag(40);
      output.WriteBool(UseFullNeighbor);
    }
    if (SceneId != 0) {
      output.WriteRawTag(48);
      output.WriteUInt32(SceneId);
    }
    if (QueryType != global::ToTheMoonQueryPathReq.Types.OptionType.None) {
      output.WriteRawTag(64);
      output.WriteEnum((int) QueryType);
    }
    if (destinationPos_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(DestinationPos);
    }
    if (sourcePos_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(SourcePos);
    }
    if (QueryId != 0) {
      output.WriteRawTag(88);
      output.WriteInt32(QueryId);
    }
    if (Refined != false) {
      output.WriteRawTag(104);
      output.WriteBool(Refined);
    }
    if (FuzzyRange != 0) {
      output.WriteRawTag(120);
      output.WriteInt32(FuzzyRange);
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
    if (destinationPos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(DestinationPos);
    }
    if (FuzzyRange != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(FuzzyRange);
    }
    if (QueryType != global::ToTheMoonQueryPathReq.Types.OptionType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QueryType);
    }
    if (AstarMethod != global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AstarMethod);
    }
    if (SceneId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
    }
    if (QueryId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(QueryId);
    }
    if (FilterType != global::ToTheMoonQueryPathReq.Types.FilterType.All) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FilterType);
    }
    if (Refined != false) {
      size += 1 + 1;
    }
    if (UseFullNeighbor != false) {
      size += 1 + 1;
    }
    if (sourcePos_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourcePos);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ToTheMoonQueryPathReq other) {
    if (other == null) {
      return;
    }
    if (other.destinationPos_ != null) {
      if (destinationPos_ == null) {
        DestinationPos = new global::Vector();
      }
      DestinationPos.MergeFrom(other.DestinationPos);
    }
    if (other.FuzzyRange != 0) {
      FuzzyRange = other.FuzzyRange;
    }
    if (other.QueryType != global::ToTheMoonQueryPathReq.Types.OptionType.None) {
      QueryType = other.QueryType;
    }
    if (other.AstarMethod != global::ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
      AstarMethod = other.AstarMethod;
    }
    if (other.SceneId != 0) {
      SceneId = other.SceneId;
    }
    if (other.QueryId != 0) {
      QueryId = other.QueryId;
    }
    if (other.FilterType != global::ToTheMoonQueryPathReq.Types.FilterType.All) {
      FilterType = other.FilterType;
    }
    if (other.Refined != false) {
      Refined = other.Refined;
    }
    if (other.UseFullNeighbor != false) {
      UseFullNeighbor = other.UseFullNeighbor;
    }
    if (other.sourcePos_ != null) {
      if (sourcePos_ == null) {
        SourcePos = new global::Vector();
      }
      SourcePos.MergeFrom(other.SourcePos);
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
          AstarMethod = (global::ToTheMoonQueryPathReq.Types.AStarMethod) input.ReadEnum();
          break;
        }
        case 24: {
          FilterType = (global::ToTheMoonQueryPathReq.Types.FilterType) input.ReadEnum();
          break;
        }
        case 40: {
          UseFullNeighbor = input.ReadBool();
          break;
        }
        case 48: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 64: {
          QueryType = (global::ToTheMoonQueryPathReq.Types.OptionType) input.ReadEnum();
          break;
        }
        case 74: {
          if (destinationPos_ == null) {
            DestinationPos = new global::Vector();
          }
          input.ReadMessage(DestinationPos);
          break;
        }
        case 82: {
          if (sourcePos_ == null) {
            SourcePos = new global::Vector();
          }
          input.ReadMessage(SourcePos);
          break;
        }
        case 88: {
          QueryId = input.ReadInt32();
          break;
        }
        case 104: {
          Refined = input.ReadBool();
          break;
        }
        case 120: {
          FuzzyRange = input.ReadInt32();
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
          AstarMethod = (global::ToTheMoonQueryPathReq.Types.AStarMethod) input.ReadEnum();
          break;
        }
        case 24: {
          FilterType = (global::ToTheMoonQueryPathReq.Types.FilterType) input.ReadEnum();
          break;
        }
        case 40: {
          UseFullNeighbor = input.ReadBool();
          break;
        }
        case 48: {
          SceneId = input.ReadUInt32();
          break;
        }
        case 64: {
          QueryType = (global::ToTheMoonQueryPathReq.Types.OptionType) input.ReadEnum();
          break;
        }
        case 74: {
          if (destinationPos_ == null) {
            DestinationPos = new global::Vector();
          }
          input.ReadMessage(DestinationPos);
          break;
        }
        case 82: {
          if (sourcePos_ == null) {
            SourcePos = new global::Vector();
          }
          input.ReadMessage(SourcePos);
          break;
        }
        case 88: {
          QueryId = input.ReadInt32();
          break;
        }
        case 104: {
          Refined = input.ReadBool();
          break;
        }
        case 120: {
          FuzzyRange = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

  #region Nested types
  /// <summary>Container for nested types declared in the ToTheMoonQueryPathReq message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static partial class Types {
    public enum OptionType {
      [pbr::OriginalName("OPTION_TYPE_NONE")] None = 0,
      [pbr::OriginalName("OPTION_TYPE_NORMAL")] Normal = 1,
    }

    public enum AStarMethod {
      [pbr::OriginalName("A_STAR_METHOD_CLASSIC")] Classic = 0,
      [pbr::OriginalName("A_STAR_METHOD_TENDENCY")] Tendency = 1,
      [pbr::OriginalName("A_STAR_METHOD_ADAPTIVE")] Adaptive = 2,
      [pbr::OriginalName("A_STAR_METHOD_INFLECTION")] Inflection = 3,
    }

    public enum FilterType {
      [pbr::OriginalName("FILTER_TYPE_ALL")] All = 0,
      [pbr::OriginalName("FILTER_TYPE_AIR")] Air = 1,
      [pbr::OriginalName("FILTER_TYPE_WATER")] Water = 2,
    }

  }
  #endregion

}

#endregion


#endregion Designer generated code
