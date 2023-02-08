// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeResourceNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from HomeResourceNotify.proto</summary>
  public static partial class HomeResourceNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeResourceNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeResourceNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhIb21lUmVzb3VyY2VOb3RpZnkucHJvdG8aEkhvbWVSZXNvdXJjZS5wcm90",
            "byJZChJIb21lUmVzb3VyY2VOb3RpZnkSIAoJaG9tZV9jb2luGAkgASgLMg0u",
            "SG9tZVJlc291cmNlEiEKCmZldHRlcl9leHAYCCABKAsyDS5Ib21lUmVzb3Vy",
            "Y2VCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.HomeResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.HomeResourceNotify), global::OldProtos.HomeResourceNotify.Parser, new[]{ "HomeCoin", "FetterExp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 4892
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class HomeResourceNotify : pb::IMessage<HomeResourceNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeResourceNotify> _parser = new pb::MessageParser<HomeResourceNotify>(() => new HomeResourceNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeResourceNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.HomeResourceNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeResourceNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeResourceNotify(HomeResourceNotify other) : this() {
      homeCoin_ = other.homeCoin_ != null ? other.homeCoin_.Clone() : null;
      fetterExp_ = other.fetterExp_ != null ? other.fetterExp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeResourceNotify Clone() {
      return new HomeResourceNotify(this);
    }

    /// <summary>Field number for the "home_coin" field.</summary>
    public const int HomeCoinFieldNumber = 9;
    private global::OldProtos.HomeResource homeCoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.HomeResource HomeCoin {
      get { return homeCoin_; }
      set {
        homeCoin_ = value;
      }
    }

    /// <summary>Field number for the "fetter_exp" field.</summary>
    public const int FetterExpFieldNumber = 8;
    private global::OldProtos.HomeResource fetterExp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.HomeResource FetterExp {
      get { return fetterExp_; }
      set {
        fetterExp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeResourceNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeResourceNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(HomeCoin, other.HomeCoin)) return false;
      if (!object.Equals(FetterExp, other.FetterExp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (homeCoin_ != null) hash ^= HomeCoin.GetHashCode();
      if (fetterExp_ != null) hash ^= FetterExp.GetHashCode();
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
      if (fetterExp_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FetterExp);
      }
      if (homeCoin_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HomeCoin);
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
      if (fetterExp_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FetterExp);
      }
      if (homeCoin_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(HomeCoin);
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
      if (homeCoin_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HomeCoin);
      }
      if (fetterExp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FetterExp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeResourceNotify other) {
      if (other == null) {
        return;
      }
      if (other.homeCoin_ != null) {
        if (homeCoin_ == null) {
          HomeCoin = new global::OldProtos.HomeResource();
        }
        HomeCoin.MergeFrom(other.HomeCoin);
      }
      if (other.fetterExp_ != null) {
        if (fetterExp_ == null) {
          FetterExp = new global::OldProtos.HomeResource();
        }
        FetterExp.MergeFrom(other.FetterExp);
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
          case 66: {
            if (fetterExp_ == null) {
              FetterExp = new global::OldProtos.HomeResource();
            }
            input.ReadMessage(FetterExp);
            break;
          }
          case 74: {
            if (homeCoin_ == null) {
              HomeCoin = new global::OldProtos.HomeResource();
            }
            input.ReadMessage(HomeCoin);
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
          case 66: {
            if (fetterExp_ == null) {
              FetterExp = new global::OldProtos.HomeResource();
            }
            input.ReadMessage(FetterExp);
            break;
          }
          case 74: {
            if (homeCoin_ == null) {
              HomeCoin = new global::OldProtos.HomeResource();
            }
            input.ReadMessage(HomeCoin);
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
