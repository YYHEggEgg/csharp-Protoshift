// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgTokenChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from GCGMsgTokenChange.proto</summary>
  public static partial class GCGMsgTokenChangeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgTokenChange.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgTokenChangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHQ0dNc2dUb2tlbkNoYW5nZS5wcm90bxoPR0NHUmVhc29uLnByb3RvIpAB",
            "ChFHQ0dNc2dUb2tlbkNoYW5nZRISCgp0b2tlbl90eXBlGAcgASgNEhsKE1Vu",
            "azMzMDBfTExHSEdFQUxEREkYCiABKA0SGgoGcmVhc29uGAMgASgOMgouR0NH",
            "UmVhc29uEhsKE1VuazMzMDBfTENOS0JGQkpERk0YDCABKA0SEQoJY2FyZF9n",
            "dWlkGA0gASgNQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::NewProtos.GCGReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::NewProtos.GCGMsgTokenChange), global::NewProtos.GCGMsgTokenChange.Parser, new[]{ "TokenType", "Unk3300LLGHGEALDDI", "Reason", "Unk3300LCNKBFBJDFM", "CardGuid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgTokenChange : pb::IMessage<GCGMsgTokenChange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgTokenChange> _parser = new pb::MessageParser<GCGMsgTokenChange>(() => new GCGMsgTokenChange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgTokenChange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::NewProtos.GCGMsgTokenChangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgTokenChange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgTokenChange(GCGMsgTokenChange other) : this() {
      tokenType_ = other.tokenType_;
      unk3300LLGHGEALDDI_ = other.unk3300LLGHGEALDDI_;
      reason_ = other.reason_;
      unk3300LCNKBFBJDFM_ = other.unk3300LCNKBFBJDFM_;
      cardGuid_ = other.cardGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgTokenChange Clone() {
      return new GCGMsgTokenChange(this);
    }

    /// <summary>Field number for the "token_type" field.</summary>
    public const int TokenTypeFieldNumber = 7;
    private uint tokenType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TokenType {
      get { return tokenType_; }
      set {
        tokenType_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LLGHGEALDDI" field.</summary>
    public const int Unk3300LLGHGEALDDIFieldNumber = 10;
    private uint unk3300LLGHGEALDDI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LLGHGEALDDI {
      get { return unk3300LLGHGEALDDI_; }
      set {
        unk3300LLGHGEALDDI_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 3;
    private global::NewProtos.GCGReason reason_ = global::NewProtos.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::NewProtos.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_LCNKBFBJDFM" field.</summary>
    public const int Unk3300LCNKBFBJDFMFieldNumber = 12;
    private uint unk3300LCNKBFBJDFM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300LCNKBFBJDFM {
      get { return unk3300LCNKBFBJDFM_; }
      set {
        unk3300LCNKBFBJDFM_ = value;
      }
    }

    /// <summary>Field number for the "card_guid" field.</summary>
    public const int CardGuidFieldNumber = 13;
    private uint cardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardGuid {
      get { return cardGuid_; }
      set {
        cardGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgTokenChange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgTokenChange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TokenType != other.TokenType) return false;
      if (Unk3300LLGHGEALDDI != other.Unk3300LLGHGEALDDI) return false;
      if (Reason != other.Reason) return false;
      if (Unk3300LCNKBFBJDFM != other.Unk3300LCNKBFBJDFM) return false;
      if (CardGuid != other.CardGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TokenType != 0) hash ^= TokenType.GetHashCode();
      if (Unk3300LLGHGEALDDI != 0) hash ^= Unk3300LLGHGEALDDI.GetHashCode();
      if (Reason != global::NewProtos.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (Unk3300LCNKBFBJDFM != 0) hash ^= Unk3300LCNKBFBJDFM.GetHashCode();
      if (CardGuid != 0) hash ^= CardGuid.GetHashCode();
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
      if (Reason != global::NewProtos.GCGReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (TokenType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TokenType);
      }
      if (Unk3300LLGHGEALDDI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LLGHGEALDDI);
      }
      if (Unk3300LCNKBFBJDFM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300LCNKBFBJDFM);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CardGuid);
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
      if (Reason != global::NewProtos.GCGReason.Default) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Reason);
      }
      if (TokenType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(TokenType);
      }
      if (Unk3300LLGHGEALDDI != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300LLGHGEALDDI);
      }
      if (Unk3300LCNKBFBJDFM != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300LCNKBFBJDFM);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(CardGuid);
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
      if (TokenType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TokenType);
      }
      if (Unk3300LLGHGEALDDI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LLGHGEALDDI);
      }
      if (Reason != global::NewProtos.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Unk3300LCNKBFBJDFM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300LCNKBFBJDFM);
      }
      if (CardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgTokenChange other) {
      if (other == null) {
        return;
      }
      if (other.TokenType != 0) {
        TokenType = other.TokenType;
      }
      if (other.Unk3300LLGHGEALDDI != 0) {
        Unk3300LLGHGEALDDI = other.Unk3300LLGHGEALDDI;
      }
      if (other.Reason != global::NewProtos.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.Unk3300LCNKBFBJDFM != 0) {
        Unk3300LCNKBFBJDFM = other.Unk3300LCNKBFBJDFM;
      }
      if (other.CardGuid != 0) {
        CardGuid = other.CardGuid;
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
          case 24: {
            Reason = (global::NewProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 56: {
            TokenType = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300LLGHGEALDDI = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300LCNKBFBJDFM = input.ReadUInt32();
            break;
          }
          case 104: {
            CardGuid = input.ReadUInt32();
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
          case 24: {
            Reason = (global::NewProtos.GCGReason) input.ReadEnum();
            break;
          }
          case 56: {
            TokenType = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300LLGHGEALDDI = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300LCNKBFBJDFM = input.ReadUInt32();
            break;
          }
          case 104: {
            CardGuid = input.ReadUInt32();
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
