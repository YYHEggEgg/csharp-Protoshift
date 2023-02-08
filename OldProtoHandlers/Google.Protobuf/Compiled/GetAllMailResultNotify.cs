// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAllMailResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GetAllMailResultNotify.proto</summary>
  public static partial class GetAllMailResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAllMailResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAllMailResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRBbGxNYWlsUmVzdWx0Tm90aWZ5LnByb3RvGg5NYWlsRGF0YS5wcm90",
            "byKgAQoWR2V0QWxsTWFpbFJlc3VsdE5vdGlmeRITCgt0cmFuc2FjdGlvbhgJ",
            "IAEoCRIcCgltYWlsX2xpc3QYBSADKAsyCS5NYWlsRGF0YRISCgpwYWdlX2lu",
            "ZGV4GAsgASgNEhgKEHRvdGFsX3BhZ2VfY291bnQYBCABKA0SFAoMaXNfY29s",
            "bGVjdGVkGAcgASgIEg8KB3JldGNvZGUYDiABKAVCDKoCCU9sZFByb3Rvc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.MailDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.GetAllMailResultNotify), global::OldProtos.GetAllMailResultNotify.Parser, new[]{ "Transaction", "MailList", "PageIndex", "TotalPageCount", "IsCollected", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1481
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class GetAllMailResultNotify : pb::IMessage<GetAllMailResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAllMailResultNotify> _parser = new pb::MessageParser<GetAllMailResultNotify>(() => new GetAllMailResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAllMailResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.GetAllMailResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify(GetAllMailResultNotify other) : this() {
      transaction_ = other.transaction_;
      mailList_ = other.mailList_.Clone();
      pageIndex_ = other.pageIndex_;
      totalPageCount_ = other.totalPageCount_;
      isCollected_ = other.isCollected_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAllMailResultNotify Clone() {
      return new GetAllMailResultNotify(this);
    }

    /// <summary>Field number for the "transaction" field.</summary>
    public const int TransactionFieldNumber = 9;
    private string transaction_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Transaction {
      get { return transaction_; }
      set {
        transaction_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "mail_list" field.</summary>
    public const int MailListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::OldProtos.MailData> _repeated_mailList_codec
        = pb::FieldCodec.ForMessage(42, global::OldProtos.MailData.Parser);
    private readonly pbc::RepeatedField<global::OldProtos.MailData> mailList_ = new pbc::RepeatedField<global::OldProtos.MailData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::OldProtos.MailData> MailList {
      get { return mailList_; }
    }

    /// <summary>Field number for the "page_index" field.</summary>
    public const int PageIndexFieldNumber = 11;
    private uint pageIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PageIndex {
      get { return pageIndex_; }
      set {
        pageIndex_ = value;
      }
    }

    /// <summary>Field number for the "total_page_count" field.</summary>
    public const int TotalPageCountFieldNumber = 4;
    private uint totalPageCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalPageCount {
      get { return totalPageCount_; }
      set {
        totalPageCount_ = value;
      }
    }

    /// <summary>Field number for the "is_collected" field.</summary>
    public const int IsCollectedFieldNumber = 7;
    private bool isCollected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCollected {
      get { return isCollected_; }
      set {
        isCollected_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAllMailResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAllMailResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Transaction != other.Transaction) return false;
      if(!mailList_.Equals(other.mailList_)) return false;
      if (PageIndex != other.PageIndex) return false;
      if (TotalPageCount != other.TotalPageCount) return false;
      if (IsCollected != other.IsCollected) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Transaction.Length != 0) hash ^= Transaction.GetHashCode();
      hash ^= mailList_.GetHashCode();
      if (PageIndex != 0) hash ^= PageIndex.GetHashCode();
      if (TotalPageCount != 0) hash ^= TotalPageCount.GetHashCode();
      if (IsCollected != false) hash ^= IsCollected.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (TotalPageCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalPageCount);
      }
      mailList_.WriteTo(output, _repeated_mailList_codec);
      if (IsCollected != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsCollected);
      }
      if (Transaction.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Transaction);
      }
      if (PageIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PageIndex);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (TotalPageCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(TotalPageCount);
      }
      mailList_.WriteTo(ref output, _repeated_mailList_codec);
      if (IsCollected != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsCollected);
      }
      if (Transaction.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Transaction);
      }
      if (PageIndex != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(PageIndex);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
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
      if (Transaction.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Transaction);
      }
      size += mailList_.CalculateSize(_repeated_mailList_codec);
      if (PageIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PageIndex);
      }
      if (TotalPageCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalPageCount);
      }
      if (IsCollected != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAllMailResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.Transaction.Length != 0) {
        Transaction = other.Transaction;
      }
      mailList_.Add(other.mailList_);
      if (other.PageIndex != 0) {
        PageIndex = other.PageIndex;
      }
      if (other.TotalPageCount != 0) {
        TotalPageCount = other.TotalPageCount;
      }
      if (other.IsCollected != false) {
        IsCollected = other.IsCollected;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 32: {
            TotalPageCount = input.ReadUInt32();
            break;
          }
          case 42: {
            mailList_.AddEntriesFrom(input, _repeated_mailList_codec);
            break;
          }
          case 56: {
            IsCollected = input.ReadBool();
            break;
          }
          case 74: {
            Transaction = input.ReadString();
            break;
          }
          case 88: {
            PageIndex = input.ReadUInt32();
            break;
          }
          case 112: {
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
          case 32: {
            TotalPageCount = input.ReadUInt32();
            break;
          }
          case 42: {
            mailList_.AddEntriesFrom(ref input, _repeated_mailList_codec);
            break;
          }
          case 56: {
            IsCollected = input.ReadBool();
            break;
          }
          case 74: {
            Transaction = input.ReadString();
            break;
          }
          case 88: {
            PageIndex = input.ReadUInt32();
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
