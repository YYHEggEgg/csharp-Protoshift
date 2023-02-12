// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishBattleEndReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FishBattleEndReq.proto</summary>
  public static partial class FishBattleEndReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FishBattleEndReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishBattleEndReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaXNoQmF0dGxlRW5kUmVxLnByb3RvGhZGaXNoQmF0dGxlUmVzdWx0LnBy",
            "b3RvIm0KEEZpc2hCYXR0bGVFbmRSZXESKAoNYmF0dGxlX3Jlc3VsdBgLIAEo",
            "DjIRLkZpc2hCYXR0bGVSZXN1bHQSFwoPaXNfYWx3YXlzX2JvbnVzGAMgASgI",
            "EhYKDm1heF9ib251c190aW1lGAIgASgNQgyqAglOZXdQcm90b3NiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.FishBattleResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.FishBattleEndReq), global::NewProtos.FishBattleEndReq.Parser, new[]{ "BattleResult", "IsAlwaysBonus", "MaxBonusTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// enum CmdId {
  ///   option allow_alias = true;
  ///   NONE = 0;
  ///   CMD_ID = 5808;
  ///   ENET_CHANNEL_ID = 0;
  ///   ENET_IS_RELIABLE = 1;
  ///   IS_ALLOW_CLIENT = 1;
  /// }
  /// </summary>
  public sealed partial class FishBattleEndReq : pb::IMessage<FishBattleEndReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishBattleEndReq> _parser = new pb::MessageParser<FishBattleEndReq>(() => new FishBattleEndReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishBattleEndReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.FishBattleEndReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndReq(FishBattleEndReq other) : this() {
      battleResult_ = other.battleResult_;
      isAlwaysBonus_ = other.isAlwaysBonus_;
      maxBonusTime_ = other.maxBonusTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishBattleEndReq Clone() {
      return new FishBattleEndReq(this);
    }

    /// <summary>Field number for the "battle_result" field.</summary>
    public const int BattleResultFieldNumber = 11;
    private global::NewProtos.FishBattleResult battleResult_ = global::NewProtos.FishBattleResult.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.FishBattleResult BattleResult {
      get { return battleResult_; }
      set {
        battleResult_ = value;
      }
    }

    /// <summary>Field number for the "is_always_bonus" field.</summary>
    public const int IsAlwaysBonusFieldNumber = 3;
    private bool isAlwaysBonus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAlwaysBonus {
      get { return isAlwaysBonus_; }
      set {
        isAlwaysBonus_ = value;
      }
    }

    /// <summary>Field number for the "max_bonus_time" field.</summary>
    public const int MaxBonusTimeFieldNumber = 2;
    private uint maxBonusTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxBonusTime {
      get { return maxBonusTime_; }
      set {
        maxBonusTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishBattleEndReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishBattleEndReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleResult != other.BattleResult) return false;
      if (IsAlwaysBonus != other.IsAlwaysBonus) return false;
      if (MaxBonusTime != other.MaxBonusTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleResult != global::NewProtos.FishBattleResult.None) hash ^= BattleResult.GetHashCode();
      if (IsAlwaysBonus != false) hash ^= IsAlwaysBonus.GetHashCode();
      if (MaxBonusTime != 0) hash ^= MaxBonusTime.GetHashCode();
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
      if (MaxBonusTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaxBonusTime);
      }
      if (IsAlwaysBonus != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAlwaysBonus);
      }
      if (BattleResult != global::NewProtos.FishBattleResult.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) BattleResult);
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
      if (MaxBonusTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaxBonusTime);
      }
      if (IsAlwaysBonus != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAlwaysBonus);
      }
      if (BattleResult != global::NewProtos.FishBattleResult.None) {
        output.WriteRawTag(88);
        output.WriteEnum((int) BattleResult);
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
      if (BattleResult != global::NewProtos.FishBattleResult.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BattleResult);
      }
      if (IsAlwaysBonus != false) {
        size += 1 + 1;
      }
      if (MaxBonusTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxBonusTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishBattleEndReq other) {
      if (other == null) {
        return;
      }
      if (other.BattleResult != global::NewProtos.FishBattleResult.None) {
        BattleResult = other.BattleResult;
      }
      if (other.IsAlwaysBonus != false) {
        IsAlwaysBonus = other.IsAlwaysBonus;
      }
      if (other.MaxBonusTime != 0) {
        MaxBonusTime = other.MaxBonusTime;
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
            MaxBonusTime = input.ReadUInt32();
            break;
          }
          case 24: {
            IsAlwaysBonus = input.ReadBool();
            break;
          }
          case 88: {
            BattleResult = (global::NewProtos.FishBattleResult) input.ReadEnum();
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
            MaxBonusTime = input.ReadUInt32();
            break;
          }
          case 24: {
            IsAlwaysBonus = input.ReadBool();
            break;
          }
          case 88: {
            BattleResult = (global::NewProtos.FishBattleResult) input.ReadEnum();
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