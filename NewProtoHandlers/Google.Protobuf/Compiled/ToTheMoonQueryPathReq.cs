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
namespace NewProtos {

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
            "ChtUb1RoZU1vb25RdWVyeVBhdGhSZXEucHJvdG8aDFZlY3Rvci5wcm90byL9",
            "BAoVVG9UaGVNb29uUXVlcnlQYXRoUmVxEjUKCnF1ZXJ5X3R5cGUYBSABKA4y",
            "IS5Ub1RoZU1vb25RdWVyeVBhdGhSZXEuT3B0aW9uVHlwZRIbChNVbmszMzAw",
            "X0JCTE1CSUxJT0dQGAggASgIEjYKC2ZpbHRlcl90eXBlGA0gASgOMiEuVG9U",
            "aGVNb29uUXVlcnlQYXRoUmVxLkZpbHRlclR5cGUSEAoIcXVlcnlfaWQYAiAB",
            "KAUSOAoMYXN0YXJfbWV0aG9kGAwgASgOMiIuVG9UaGVNb29uUXVlcnlQYXRo",
            "UmVxLkFTdGFyTWV0aG9kEhsKCnNvdXJjZV9wb3MYCyABKAsyBy5WZWN0b3IS",
            "IAoPZGVzdGluYXRpb25fcG9zGAMgASgLMgcuVmVjdG9yEhMKC2Z1enp5X3Jh",
            "bmdlGAcgASgFEhsKE1VuazMzMDBfT0ZHT05BTU5JSkcYBiABKAgSEAoIc2Nl",
            "bmVfaWQYBCABKA0iOgoKT3B0aW9uVHlwZRIUChBPUFRJT05fVFlQRV9OT05F",
            "EAASFgoST1BUSU9OX1RZUEVfTk9STUFMEAEifgoLQVN0YXJNZXRob2QSGQoV",
            "QV9TVEFSX01FVEhPRF9DTEFTU0lDEAASGgoWQV9TVEFSX01FVEhPRF9URU5E",
            "RU5DWRABEhoKFkFfU1RBUl9NRVRIT0RfQURBUFRJVkUQAhIcChhBX1NUQVJf",
            "TUVUSE9EX0lORkxFQ1RJT04QAyJNCgpGaWx0ZXJUeXBlEhMKD0ZJTFRFUl9U",
            "WVBFX0FMTBAAEhMKD0ZJTFRFUl9UWVBFX0FJUhABEhUKEUZJTFRFUl9UWVBF",
            "X1dBVEVSEAJCDKoCCU5ld1Byb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.ToTheMoonQueryPathReq), global::NewProtos.ToTheMoonQueryPathReq.Parser, new[]{ "QueryType", "Unk3300BBLMBILIOGP", "FilterType", "QueryId", "AstarMethod", "SourcePos", "DestinationPos", "FuzzyRange", "Unk3300OFGONAMNIJG", "SceneId" }, null, new[]{ typeof(global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType), typeof(global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod), typeof(global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 6179;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
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
      get { return global::NewProtos.ToTheMoonQueryPathReqReflection.Descriptor.MessageTypes[0]; }
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
      queryType_ = other.queryType_;
      unk3300BBLMBILIOGP_ = other.unk3300BBLMBILIOGP_;
      filterType_ = other.filterType_;
      queryId_ = other.queryId_;
      astarMethod_ = other.astarMethod_;
      sourcePos_ = other.sourcePos_ != null ? other.sourcePos_.Clone() : null;
      destinationPos_ = other.destinationPos_ != null ? other.destinationPos_.Clone() : null;
      fuzzyRange_ = other.fuzzyRange_;
      unk3300OFGONAMNIJG_ = other.unk3300OFGONAMNIJG_;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonQueryPathReq Clone() {
      return new ToTheMoonQueryPathReq(this);
    }

    /// <summary>Field number for the "query_type" field.</summary>
    public const int QueryTypeFieldNumber = 5;
    private global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType queryType_ = global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType QueryType {
      get { return queryType_; }
      set {
        queryType_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BBLMBILIOGP" field.</summary>
    public const int Unk3300BBLMBILIOGPFieldNumber = 8;
    private bool unk3300BBLMBILIOGP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BBLMBILIOGP {
      get { return unk3300BBLMBILIOGP_; }
      set {
        unk3300BBLMBILIOGP_ = value;
      }
    }

    /// <summary>Field number for the "filter_type" field.</summary>
    public const int FilterTypeFieldNumber = 13;
    private global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType filterType_ = global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType FilterType {
      get { return filterType_; }
      set {
        filterType_ = value;
      }
    }

    /// <summary>Field number for the "query_id" field.</summary>
    public const int QueryIdFieldNumber = 2;
    private int queryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int QueryId {
      get { return queryId_; }
      set {
        queryId_ = value;
      }
    }

    /// <summary>Field number for the "astar_method" field.</summary>
    public const int AstarMethodFieldNumber = 12;
    private global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod astarMethod_ = global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod AstarMethod {
      get { return astarMethod_; }
      set {
        astarMethod_ = value;
      }
    }

    /// <summary>Field number for the "source_pos" field.</summary>
    public const int SourcePosFieldNumber = 11;
    private global::NewProtos.Vector sourcePos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector SourcePos {
      get { return sourcePos_; }
      set {
        sourcePos_ = value;
      }
    }

    /// <summary>Field number for the "destination_pos" field.</summary>
    public const int DestinationPosFieldNumber = 3;
    private global::NewProtos.Vector destinationPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.Vector DestinationPos {
      get { return destinationPos_; }
      set {
        destinationPos_ = value;
      }
    }

    /// <summary>Field number for the "fuzzy_range" field.</summary>
    public const int FuzzyRangeFieldNumber = 7;
    private int fuzzyRange_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int FuzzyRange {
      get { return fuzzyRange_; }
      set {
        fuzzyRange_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_OFGONAMNIJG" field.</summary>
    public const int Unk3300OFGONAMNIJGFieldNumber = 6;
    private bool unk3300OFGONAMNIJG_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300OFGONAMNIJG {
      get { return unk3300OFGONAMNIJG_; }
      set {
        unk3300OFGONAMNIJG_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 4;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
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
      if (QueryType != other.QueryType) return false;
      if (Unk3300BBLMBILIOGP != other.Unk3300BBLMBILIOGP) return false;
      if (FilterType != other.FilterType) return false;
      if (QueryId != other.QueryId) return false;
      if (AstarMethod != other.AstarMethod) return false;
      if (!object.Equals(SourcePos, other.SourcePos)) return false;
      if (!object.Equals(DestinationPos, other.DestinationPos)) return false;
      if (FuzzyRange != other.FuzzyRange) return false;
      if (Unk3300OFGONAMNIJG != other.Unk3300OFGONAMNIJG) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (QueryType != global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None) hash ^= QueryType.GetHashCode();
      if (Unk3300BBLMBILIOGP != false) hash ^= Unk3300BBLMBILIOGP.GetHashCode();
      if (FilterType != global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All) hash ^= FilterType.GetHashCode();
      if (QueryId != 0) hash ^= QueryId.GetHashCode();
      if (AstarMethod != global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic) hash ^= AstarMethod.GetHashCode();
      if (sourcePos_ != null) hash ^= SourcePos.GetHashCode();
      if (destinationPos_ != null) hash ^= DestinationPos.GetHashCode();
      if (FuzzyRange != 0) hash ^= FuzzyRange.GetHashCode();
      if (Unk3300OFGONAMNIJG != false) hash ^= Unk3300OFGONAMNIJG.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
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
      if (QueryId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(QueryId);
      }
      if (destinationPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DestinationPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (QueryType != global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) QueryType);
      }
      if (Unk3300OFGONAMNIJG != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300OFGONAMNIJG);
      }
      if (FuzzyRange != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(FuzzyRange);
      }
      if (Unk3300BBLMBILIOGP != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300BBLMBILIOGP);
      }
      if (sourcePos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SourcePos);
      }
      if (AstarMethod != global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AstarMethod);
      }
      if (FilterType != global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All) {
        output.WriteRawTag(104);
        output.WriteEnum((int) FilterType);
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
      if (QueryId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(QueryId);
      }
      if (destinationPos_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DestinationPos);
      }
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      if (QueryType != global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None) {
        output.WriteRawTag(40);
        output.WriteEnum((int) QueryType);
      }
      if (Unk3300OFGONAMNIJG != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300OFGONAMNIJG);
      }
      if (FuzzyRange != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(FuzzyRange);
      }
      if (Unk3300BBLMBILIOGP != false) {
        output.WriteRawTag(64);
        output.WriteBool(Unk3300BBLMBILIOGP);
      }
      if (sourcePos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SourcePos);
      }
      if (AstarMethod != global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
        output.WriteRawTag(96);
        output.WriteEnum((int) AstarMethod);
      }
      if (FilterType != global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All) {
        output.WriteRawTag(104);
        output.WriteEnum((int) FilterType);
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
      if (QueryType != global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QueryType);
      }
      if (Unk3300BBLMBILIOGP != false) {
        size += 1 + 1;
      }
      if (FilterType != global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FilterType);
      }
      if (QueryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QueryId);
      }
      if (AstarMethod != global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AstarMethod);
      }
      if (sourcePos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SourcePos);
      }
      if (destinationPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DestinationPos);
      }
      if (FuzzyRange != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FuzzyRange);
      }
      if (Unk3300OFGONAMNIJG != false) {
        size += 1 + 1;
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
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
      if (other.QueryType != global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType.None) {
        QueryType = other.QueryType;
      }
      if (other.Unk3300BBLMBILIOGP != false) {
        Unk3300BBLMBILIOGP = other.Unk3300BBLMBILIOGP;
      }
      if (other.FilterType != global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType.All) {
        FilterType = other.FilterType;
      }
      if (other.QueryId != 0) {
        QueryId = other.QueryId;
      }
      if (other.AstarMethod != global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod.Classic) {
        AstarMethod = other.AstarMethod;
      }
      if (other.sourcePos_ != null) {
        if (sourcePos_ == null) {
          SourcePos = new global::NewProtos.Vector();
        }
        SourcePos.MergeFrom(other.SourcePos);
      }
      if (other.destinationPos_ != null) {
        if (destinationPos_ == null) {
          DestinationPos = new global::NewProtos.Vector();
        }
        DestinationPos.MergeFrom(other.DestinationPos);
      }
      if (other.FuzzyRange != 0) {
        FuzzyRange = other.FuzzyRange;
      }
      if (other.Unk3300OFGONAMNIJG != false) {
        Unk3300OFGONAMNIJG = other.Unk3300OFGONAMNIJG;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
            QueryId = input.ReadInt32();
            break;
          }
          case 26: {
            if (destinationPos_ == null) {
              DestinationPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(DestinationPos);
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            QueryType = (global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType) input.ReadEnum();
            break;
          }
          case 48: {
            Unk3300OFGONAMNIJG = input.ReadBool();
            break;
          }
          case 56: {
            FuzzyRange = input.ReadInt32();
            break;
          }
          case 64: {
            Unk3300BBLMBILIOGP = input.ReadBool();
            break;
          }
          case 90: {
            if (sourcePos_ == null) {
              SourcePos = new global::NewProtos.Vector();
            }
            input.ReadMessage(SourcePos);
            break;
          }
          case 96: {
            AstarMethod = (global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod) input.ReadEnum();
            break;
          }
          case 104: {
            FilterType = (global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType) input.ReadEnum();
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
            QueryId = input.ReadInt32();
            break;
          }
          case 26: {
            if (destinationPos_ == null) {
              DestinationPos = new global::NewProtos.Vector();
            }
            input.ReadMessage(DestinationPos);
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 40: {
            QueryType = (global::NewProtos.ToTheMoonQueryPathReq.Types.OptionType) input.ReadEnum();
            break;
          }
          case 48: {
            Unk3300OFGONAMNIJG = input.ReadBool();
            break;
          }
          case 56: {
            FuzzyRange = input.ReadInt32();
            break;
          }
          case 64: {
            Unk3300BBLMBILIOGP = input.ReadBool();
            break;
          }
          case 90: {
            if (sourcePos_ == null) {
              SourcePos = new global::NewProtos.Vector();
            }
            input.ReadMessage(SourcePos);
            break;
          }
          case 96: {
            AstarMethod = (global::NewProtos.ToTheMoonQueryPathReq.Types.AStarMethod) input.ReadEnum();
            break;
          }
          case 104: {
            FilterType = (global::NewProtos.ToTheMoonQueryPathReq.Types.FilterType) input.ReadEnum();
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

}

#endregion Designer generated code
