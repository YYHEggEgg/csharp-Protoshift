// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonSettingMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from CustomDungeonSettingMuipData.proto</summary>
  public static partial class CustomDungeonSettingMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonSettingMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonSettingMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJDdXN0b21EdW5nZW9uU2V0dGluZ011aXBEYXRhLnByb3RvIosBChxDdXN0",
            "b21EdW5nZW9uU2V0dGluZ011aXBEYXRhEhgKEGlzX2Fycml2ZV9maW5pc2gY",
            "ASABKAgSEgoKY29pbl9saW1pdBgCIAEoDRISCgp0aW1lX2xpbWl0GAMgASgN",
            "EhcKD2lzX2ZvcmJpZF9za2lsbBgEIAEoCBIQCghsaWZlX251bRgFIAEoDUIM",
            "qgIJTmV3UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.CustomDungeonSettingMuipData), global::NewProtos.CustomDungeonSettingMuipData.Parser, new[]{ "IsArriveFinish", "CoinLimit", "TimeLimit", "IsForbidSkill", "LifeNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonSettingMuipData : pb::IMessage<CustomDungeonSettingMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonSettingMuipData> _parser = new pb::MessageParser<CustomDungeonSettingMuipData>(() => new CustomDungeonSettingMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonSettingMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.CustomDungeonSettingMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSettingMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSettingMuipData(CustomDungeonSettingMuipData other) : this() {
      isArriveFinish_ = other.isArriveFinish_;
      coinLimit_ = other.coinLimit_;
      timeLimit_ = other.timeLimit_;
      isForbidSkill_ = other.isForbidSkill_;
      lifeNum_ = other.lifeNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSettingMuipData Clone() {
      return new CustomDungeonSettingMuipData(this);
    }

    /// <summary>Field number for the "is_arrive_finish" field.</summary>
    public const int IsArriveFinishFieldNumber = 1;
    private bool isArriveFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsArriveFinish {
      get { return isArriveFinish_; }
      set {
        isArriveFinish_ = value;
      }
    }

    /// <summary>Field number for the "coin_limit" field.</summary>
    public const int CoinLimitFieldNumber = 2;
    private uint coinLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinLimit {
      get { return coinLimit_; }
      set {
        coinLimit_ = value;
      }
    }

    /// <summary>Field number for the "time_limit" field.</summary>
    public const int TimeLimitFieldNumber = 3;
    private uint timeLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimeLimit {
      get { return timeLimit_; }
      set {
        timeLimit_ = value;
      }
    }

    /// <summary>Field number for the "is_forbid_skill" field.</summary>
    public const int IsForbidSkillFieldNumber = 4;
    private bool isForbidSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForbidSkill {
      get { return isForbidSkill_; }
      set {
        isForbidSkill_ = value;
      }
    }

    /// <summary>Field number for the "life_num" field.</summary>
    public const int LifeNumFieldNumber = 5;
    private uint lifeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LifeNum {
      get { return lifeNum_; }
      set {
        lifeNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonSettingMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonSettingMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsArriveFinish != other.IsArriveFinish) return false;
      if (CoinLimit != other.CoinLimit) return false;
      if (TimeLimit != other.TimeLimit) return false;
      if (IsForbidSkill != other.IsForbidSkill) return false;
      if (LifeNum != other.LifeNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsArriveFinish != false) hash ^= IsArriveFinish.GetHashCode();
      if (CoinLimit != 0) hash ^= CoinLimit.GetHashCode();
      if (TimeLimit != 0) hash ^= TimeLimit.GetHashCode();
      if (IsForbidSkill != false) hash ^= IsForbidSkill.GetHashCode();
      if (LifeNum != 0) hash ^= LifeNum.GetHashCode();
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
      if (IsArriveFinish != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsArriveFinish);
      }
      if (CoinLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CoinLimit);
      }
      if (TimeLimit != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TimeLimit);
      }
      if (IsForbidSkill != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsForbidSkill);
      }
      if (LifeNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LifeNum);
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
      if (IsArriveFinish != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsArriveFinish);
      }
      if (CoinLimit != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CoinLimit);
      }
      if (TimeLimit != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TimeLimit);
      }
      if (IsForbidSkill != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsForbidSkill);
      }
      if (LifeNum != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LifeNum);
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
      if (IsArriveFinish != false) {
        size += 1 + 1;
      }
      if (CoinLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinLimit);
      }
      if (TimeLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimeLimit);
      }
      if (IsForbidSkill != false) {
        size += 1 + 1;
      }
      if (LifeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonSettingMuipData other) {
      if (other == null) {
        return;
      }
      if (other.IsArriveFinish != false) {
        IsArriveFinish = other.IsArriveFinish;
      }
      if (other.CoinLimit != 0) {
        CoinLimit = other.CoinLimit;
      }
      if (other.TimeLimit != 0) {
        TimeLimit = other.TimeLimit;
      }
      if (other.IsForbidSkill != false) {
        IsForbidSkill = other.IsForbidSkill;
      }
      if (other.LifeNum != 0) {
        LifeNum = other.LifeNum;
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
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 16: {
            CoinLimit = input.ReadUInt32();
            break;
          }
          case 24: {
            TimeLimit = input.ReadUInt32();
            break;
          }
          case 32: {
            IsForbidSkill = input.ReadBool();
            break;
          }
          case 40: {
            LifeNum = input.ReadUInt32();
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
            IsArriveFinish = input.ReadBool();
            break;
          }
          case 16: {
            CoinLimit = input.ReadUInt32();
            break;
          }
          case 24: {
            TimeLimit = input.ReadUInt32();
            break;
          }
          case 32: {
            IsForbidSkill = input.ReadBool();
            break;
          }
          case 40: {
            LifeNum = input.ReadUInt32();
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
