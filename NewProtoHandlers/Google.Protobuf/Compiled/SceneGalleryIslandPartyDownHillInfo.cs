// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryIslandPartyDownHillInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from SceneGalleryIslandPartyDownHillInfo.proto</summary>
  public static partial class SceneGalleryIslandPartyDownHillInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryIslandPartyDownHillInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryIslandPartyDownHillInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilTY2VuZUdhbGxlcnlJc2xhbmRQYXJ0eURvd25IaWxsSW5mby5wcm90bxoY",
            "R2FsbGVyeVN0YXJ0U291cmNlLnByb3RvIqABCiNTY2VuZUdhbGxlcnlJc2xh",
            "bmRQYXJ0eURvd25IaWxsSW5mbxIeChZtYXhfa2lsbF9tb25zdGVyX2NvdW50",
            "GAogASgNEikKDHN0YXJ0X3NvdXJjZRgCIAEoDjITLkdhbGxlcnlTdGFydFNv",
            "dXJjZRIgChh0b3RhbF9raWxsX21vbnN0ZXJfY291bnQYDCABKA0SDAoEY29p",
            "bhgEIAEoDUIMqgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GalleryStartSourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.SceneGalleryIslandPartyDownHillInfo), global::NewProtos.SceneGalleryIslandPartyDownHillInfo.Parser, new[]{ "MaxKillMonsterCount", "StartSource", "TotalKillMonsterCount", "Coin" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryIslandPartyDownHillInfo : pb::IMessage<SceneGalleryIslandPartyDownHillInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryIslandPartyDownHillInfo> _parser = new pb::MessageParser<SceneGalleryIslandPartyDownHillInfo>(() => new SceneGalleryIslandPartyDownHillInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryIslandPartyDownHillInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.SceneGalleryIslandPartyDownHillInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartyDownHillInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartyDownHillInfo(SceneGalleryIslandPartyDownHillInfo other) : this() {
      maxKillMonsterCount_ = other.maxKillMonsterCount_;
      startSource_ = other.startSource_;
      totalKillMonsterCount_ = other.totalKillMonsterCount_;
      coin_ = other.coin_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryIslandPartyDownHillInfo Clone() {
      return new SceneGalleryIslandPartyDownHillInfo(this);
    }

    /// <summary>Field number for the "max_kill_monster_count" field.</summary>
    public const int MaxKillMonsterCountFieldNumber = 10;
    private uint maxKillMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxKillMonsterCount {
      get { return maxKillMonsterCount_; }
      set {
        maxKillMonsterCount_ = value;
      }
    }

    /// <summary>Field number for the "start_source" field.</summary>
    public const int StartSourceFieldNumber = 2;
    private global::NewProtos.GalleryStartSource startSource_ = global::NewProtos.GalleryStartSource.ByNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GalleryStartSource StartSource {
      get { return startSource_; }
      set {
        startSource_ = value;
      }
    }

    /// <summary>Field number for the "total_kill_monster_count" field.</summary>
    public const int TotalKillMonsterCountFieldNumber = 12;
    private uint totalKillMonsterCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalKillMonsterCount {
      get { return totalKillMonsterCount_; }
      set {
        totalKillMonsterCount_ = value;
      }
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 4;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryIslandPartyDownHillInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryIslandPartyDownHillInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxKillMonsterCount != other.MaxKillMonsterCount) return false;
      if (StartSource != other.StartSource) return false;
      if (TotalKillMonsterCount != other.TotalKillMonsterCount) return false;
      if (Coin != other.Coin) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxKillMonsterCount != 0) hash ^= MaxKillMonsterCount.GetHashCode();
      if (StartSource != global::NewProtos.GalleryStartSource.ByNone) hash ^= StartSource.GetHashCode();
      if (TotalKillMonsterCount != 0) hash ^= TotalKillMonsterCount.GetHashCode();
      if (Coin != 0) hash ^= Coin.GetHashCode();
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
      if (StartSource != global::NewProtos.GalleryStartSource.ByNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) StartSource);
      }
      if (Coin != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Coin);
      }
      if (MaxKillMonsterCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxKillMonsterCount);
      }
      if (TotalKillMonsterCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalKillMonsterCount);
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
      if (StartSource != global::NewProtos.GalleryStartSource.ByNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) StartSource);
      }
      if (Coin != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Coin);
      }
      if (MaxKillMonsterCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxKillMonsterCount);
      }
      if (TotalKillMonsterCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TotalKillMonsterCount);
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
      if (MaxKillMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxKillMonsterCount);
      }
      if (StartSource != global::NewProtos.GalleryStartSource.ByNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StartSource);
      }
      if (TotalKillMonsterCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalKillMonsterCount);
      }
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryIslandPartyDownHillInfo other) {
      if (other == null) {
        return;
      }
      if (other.MaxKillMonsterCount != 0) {
        MaxKillMonsterCount = other.MaxKillMonsterCount;
      }
      if (other.StartSource != global::NewProtos.GalleryStartSource.ByNone) {
        StartSource = other.StartSource;
      }
      if (other.TotalKillMonsterCount != 0) {
        TotalKillMonsterCount = other.TotalKillMonsterCount;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
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
            StartSource = (global::NewProtos.GalleryStartSource) input.ReadEnum();
            break;
          }
          case 32: {
            Coin = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxKillMonsterCount = input.ReadUInt32();
            break;
          }
          case 96: {
            TotalKillMonsterCount = input.ReadUInt32();
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
            StartSource = (global::NewProtos.GalleryStartSource) input.ReadEnum();
            break;
          }
          case 32: {
            Coin = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxKillMonsterCount = input.ReadUInt32();
            break;
          }
          case 96: {
            TotalKillMonsterCount = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code