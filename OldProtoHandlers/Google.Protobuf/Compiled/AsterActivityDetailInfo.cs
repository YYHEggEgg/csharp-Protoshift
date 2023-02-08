// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AsterActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AsterActivityDetailInfo.proto</summary>
  public static partial class AsterActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AsterActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AsterActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Bc3RlckFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoaQXN0ZXJMYXJnZURl",
            "dGFpbEluZm8ucHJvdG8aG0FzdGVyTGl0dGxlRGV0YWlsSW5mby5wcm90bxoY",
            "QXN0ZXJNaWREZXRhaWxJbmZvLnByb3RvGh1Bc3RlclByb2dyZXNzRGV0YWls",
            "SW5mby5wcm90byLQAgoXQXN0ZXJBY3Rpdml0eURldGFpbEluZm8SLAoMYXN0",
            "ZXJfbGl0dGxlGAcgASgLMhYuQXN0ZXJMaXR0bGVEZXRhaWxJbmZvEhQKDGFz",
            "dGVyX2NyZWRpdBgOIAEoDRIqCgthc3Rlcl9sYXJnZRgJIAEoCzIVLkFzdGVy",
            "TGFyZ2VEZXRhaWxJbmZvEh8KF2lzX3NwZWNpYWxfcmV3YXJkX3Rha2VuGAEg",
            "ASgIEhkKEWlzX2NvbnRlbnRfY2xvc2VkGA0gASgIEhoKEmNvbnRlbnRfY2xv",
            "c2VfdGltZRgIIAEoDRITCgthc3Rlcl90b2tlbhgFIAEoDRImCglhc3Rlcl9t",
            "aWQYBiABKAsyEy5Bc3Rlck1pZERldGFpbEluZm8SMAoOYXN0ZXJfcHJvZ3Jl",
            "c3MYAiABKAsyGC5Bc3RlclByb2dyZXNzRGV0YWlsSW5mb0IMqgIJT2xkUHJv",
            "dG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.AsterLargeDetailInfoReflection.Descriptor, global::OldProtos.AsterLittleDetailInfoReflection.Descriptor, global::OldProtos.AsterMidDetailInfoReflection.Descriptor, global::OldProtos.AsterProgressDetailInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AsterActivityDetailInfo), global::OldProtos.AsterActivityDetailInfo.Parser, new[]{ "AsterLittle", "AsterCredit", "AsterLarge", "IsSpecialRewardTaken", "IsContentClosed", "ContentCloseTime", "AsterToken", "AsterMid", "AsterProgress" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AsterActivityDetailInfo : pb::IMessage<AsterActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AsterActivityDetailInfo> _parser = new pb::MessageParser<AsterActivityDetailInfo>(() => new AsterActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AsterActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AsterActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo(AsterActivityDetailInfo other) : this() {
      asterLittle_ = other.asterLittle_ != null ? other.asterLittle_.Clone() : null;
      asterCredit_ = other.asterCredit_;
      asterLarge_ = other.asterLarge_ != null ? other.asterLarge_.Clone() : null;
      isSpecialRewardTaken_ = other.isSpecialRewardTaken_;
      isContentClosed_ = other.isContentClosed_;
      contentCloseTime_ = other.contentCloseTime_;
      asterToken_ = other.asterToken_;
      asterMid_ = other.asterMid_ != null ? other.asterMid_.Clone() : null;
      asterProgress_ = other.asterProgress_ != null ? other.asterProgress_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AsterActivityDetailInfo Clone() {
      return new AsterActivityDetailInfo(this);
    }

    /// <summary>Field number for the "aster_little" field.</summary>
    public const int AsterLittleFieldNumber = 7;
    private global::OldProtos.AsterLittleDetailInfo asterLittle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AsterLittleDetailInfo AsterLittle {
      get { return asterLittle_; }
      set {
        asterLittle_ = value;
      }
    }

    /// <summary>Field number for the "aster_credit" field.</summary>
    public const int AsterCreditFieldNumber = 14;
    private uint asterCredit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AsterCredit {
      get { return asterCredit_; }
      set {
        asterCredit_ = value;
      }
    }

    /// <summary>Field number for the "aster_large" field.</summary>
    public const int AsterLargeFieldNumber = 9;
    private global::OldProtos.AsterLargeDetailInfo asterLarge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AsterLargeDetailInfo AsterLarge {
      get { return asterLarge_; }
      set {
        asterLarge_ = value;
      }
    }

    /// <summary>Field number for the "is_special_reward_taken" field.</summary>
    public const int IsSpecialRewardTakenFieldNumber = 1;
    private bool isSpecialRewardTaken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSpecialRewardTaken {
      get { return isSpecialRewardTaken_; }
      set {
        isSpecialRewardTaken_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 13;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "content_close_time" field.</summary>
    public const int ContentCloseTimeFieldNumber = 8;
    private uint contentCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ContentCloseTime {
      get { return contentCloseTime_; }
      set {
        contentCloseTime_ = value;
      }
    }

    /// <summary>Field number for the "aster_token" field.</summary>
    public const int AsterTokenFieldNumber = 5;
    private uint asterToken_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AsterToken {
      get { return asterToken_; }
      set {
        asterToken_ = value;
      }
    }

    /// <summary>Field number for the "aster_mid" field.</summary>
    public const int AsterMidFieldNumber = 6;
    private global::OldProtos.AsterMidDetailInfo asterMid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AsterMidDetailInfo AsterMid {
      get { return asterMid_; }
      set {
        asterMid_ = value;
      }
    }

    /// <summary>Field number for the "aster_progress" field.</summary>
    public const int AsterProgressFieldNumber = 2;
    private global::OldProtos.AsterProgressDetailInfo asterProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AsterProgressDetailInfo AsterProgress {
      get { return asterProgress_; }
      set {
        asterProgress_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AsterActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AsterActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AsterLittle, other.AsterLittle)) return false;
      if (AsterCredit != other.AsterCredit) return false;
      if (!object.Equals(AsterLarge, other.AsterLarge)) return false;
      if (IsSpecialRewardTaken != other.IsSpecialRewardTaken) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (ContentCloseTime != other.ContentCloseTime) return false;
      if (AsterToken != other.AsterToken) return false;
      if (!object.Equals(AsterMid, other.AsterMid)) return false;
      if (!object.Equals(AsterProgress, other.AsterProgress)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (asterLittle_ != null) hash ^= AsterLittle.GetHashCode();
      if (AsterCredit != 0) hash ^= AsterCredit.GetHashCode();
      if (asterLarge_ != null) hash ^= AsterLarge.GetHashCode();
      if (IsSpecialRewardTaken != false) hash ^= IsSpecialRewardTaken.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (ContentCloseTime != 0) hash ^= ContentCloseTime.GetHashCode();
      if (AsterToken != 0) hash ^= AsterToken.GetHashCode();
      if (asterMid_ != null) hash ^= AsterMid.GetHashCode();
      if (asterProgress_ != null) hash ^= AsterProgress.GetHashCode();
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
      if (IsSpecialRewardTaken != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSpecialRewardTaken);
      }
      if (asterProgress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AsterProgress);
      }
      if (AsterToken != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AsterToken);
      }
      if (asterMid_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AsterMid);
      }
      if (asterLittle_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AsterLittle);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ContentCloseTime);
      }
      if (asterLarge_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(AsterLarge);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsContentClosed);
      }
      if (AsterCredit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AsterCredit);
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
      if (IsSpecialRewardTaken != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSpecialRewardTaken);
      }
      if (asterProgress_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AsterProgress);
      }
      if (AsterToken != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(AsterToken);
      }
      if (asterMid_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(AsterMid);
      }
      if (asterLittle_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(AsterLittle);
      }
      if (ContentCloseTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(ContentCloseTime);
      }
      if (asterLarge_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(AsterLarge);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsContentClosed);
      }
      if (AsterCredit != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AsterCredit);
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
      if (asterLittle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterLittle);
      }
      if (AsterCredit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AsterCredit);
      }
      if (asterLarge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterLarge);
      }
      if (IsSpecialRewardTaken != false) {
        size += 1 + 1;
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (ContentCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ContentCloseTime);
      }
      if (AsterToken != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AsterToken);
      }
      if (asterMid_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterMid);
      }
      if (asterProgress_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AsterProgress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AsterActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.asterLittle_ != null) {
        if (asterLittle_ == null) {
          AsterLittle = new global::OldProtos.AsterLittleDetailInfo();
        }
        AsterLittle.MergeFrom(other.AsterLittle);
      }
      if (other.AsterCredit != 0) {
        AsterCredit = other.AsterCredit;
      }
      if (other.asterLarge_ != null) {
        if (asterLarge_ == null) {
          AsterLarge = new global::OldProtos.AsterLargeDetailInfo();
        }
        AsterLarge.MergeFrom(other.AsterLarge);
      }
      if (other.IsSpecialRewardTaken != false) {
        IsSpecialRewardTaken = other.IsSpecialRewardTaken;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.ContentCloseTime != 0) {
        ContentCloseTime = other.ContentCloseTime;
      }
      if (other.AsterToken != 0) {
        AsterToken = other.AsterToken;
      }
      if (other.asterMid_ != null) {
        if (asterMid_ == null) {
          AsterMid = new global::OldProtos.AsterMidDetailInfo();
        }
        AsterMid.MergeFrom(other.AsterMid);
      }
      if (other.asterProgress_ != null) {
        if (asterProgress_ == null) {
          AsterProgress = new global::OldProtos.AsterProgressDetailInfo();
        }
        AsterProgress.MergeFrom(other.AsterProgress);
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
            IsSpecialRewardTaken = input.ReadBool();
            break;
          }
          case 18: {
            if (asterProgress_ == null) {
              AsterProgress = new global::OldProtos.AsterProgressDetailInfo();
            }
            input.ReadMessage(AsterProgress);
            break;
          }
          case 40: {
            AsterToken = input.ReadUInt32();
            break;
          }
          case 50: {
            if (asterMid_ == null) {
              AsterMid = new global::OldProtos.AsterMidDetailInfo();
            }
            input.ReadMessage(AsterMid);
            break;
          }
          case 58: {
            if (asterLittle_ == null) {
              AsterLittle = new global::OldProtos.AsterLittleDetailInfo();
            }
            input.ReadMessage(AsterLittle);
            break;
          }
          case 64: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (asterLarge_ == null) {
              AsterLarge = new global::OldProtos.AsterLargeDetailInfo();
            }
            input.ReadMessage(AsterLarge);
            break;
          }
          case 104: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 112: {
            AsterCredit = input.ReadUInt32();
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
            IsSpecialRewardTaken = input.ReadBool();
            break;
          }
          case 18: {
            if (asterProgress_ == null) {
              AsterProgress = new global::OldProtos.AsterProgressDetailInfo();
            }
            input.ReadMessage(AsterProgress);
            break;
          }
          case 40: {
            AsterToken = input.ReadUInt32();
            break;
          }
          case 50: {
            if (asterMid_ == null) {
              AsterMid = new global::OldProtos.AsterMidDetailInfo();
            }
            input.ReadMessage(AsterMid);
            break;
          }
          case 58: {
            if (asterLittle_ == null) {
              AsterLittle = new global::OldProtos.AsterLittleDetailInfo();
            }
            input.ReadMessage(AsterLittle);
            break;
          }
          case 64: {
            ContentCloseTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (asterLarge_ == null) {
              AsterLarge = new global::OldProtos.AsterLargeDetailInfo();
            }
            input.ReadMessage(AsterLarge);
            break;
          }
          case 104: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 112: {
            AsterCredit = input.ReadUInt32();
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
