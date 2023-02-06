// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HuntingOfferData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from HuntingOfferData.proto</summary>
public static partial class HuntingOfferDataReflection {

  #region Descriptor
  /// <summary>File descriptor for HuntingOfferData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static HuntingOfferDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChZIdW50aW5nT2ZmZXJEYXRhLnByb3RvGhdIdW50aW5nT2ZmZXJTdGF0ZS5w",
          "cm90bxoRSHVudGluZ1BhaXIucHJvdG8iagoQSHVudGluZ09mZmVyRGF0YRIi",
          "CgxodW50aW5nX3BhaXIYBCABKAsyDC5IdW50aW5nUGFpchIPCgdjaXR5X2lk",
          "GAggASgNEiEKBXN0YXRlGAEgASgOMhIuSHVudGluZ09mZmVyU3RhdGVCHgoc",
          "ZW11LmdyYXNzY3V0dGVyLm5ldC5vbGRwcm90b2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::HuntingOfferStateReflection.Descriptor, global::HuntingPairReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::HuntingOfferData), global::HuntingOfferData.Parser, new[]{ "HuntingPair", "CityId", "State" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class HuntingOfferData : pb::IMessage<HuntingOfferData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<HuntingOfferData> _parser = new pb::MessageParser<HuntingOfferData>(() => new HuntingOfferData());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<HuntingOfferData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::HuntingOfferDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOfferData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOfferData(HuntingOfferData other) : this() {
    huntingPair_ = other.huntingPair_ != null ? other.huntingPair_.Clone() : null;
    cityId_ = other.cityId_;
    state_ = other.state_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public HuntingOfferData Clone() {
    return new HuntingOfferData(this);
  }

  /// <summary>Field number for the "hunting_pair" field.</summary>
  public const int HuntingPairFieldNumber = 4;
  private global::HuntingPair huntingPair_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HuntingPair HuntingPair {
    get { return huntingPair_; }
    set {
      huntingPair_ = value;
    }
  }

  /// <summary>Field number for the "city_id" field.</summary>
  public const int CityIdFieldNumber = 8;
  private uint cityId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public uint CityId {
    get { return cityId_; }
    set {
      cityId_ = value;
    }
  }

  /// <summary>Field number for the "state" field.</summary>
  public const int StateFieldNumber = 1;
  private global::HuntingOfferState state_ = global::HuntingOfferState.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::HuntingOfferState State {
    get { return state_; }
    set {
      state_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as HuntingOfferData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(HuntingOfferData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(HuntingPair, other.HuntingPair)) return false;
    if (CityId != other.CityId) return false;
    if (State != other.State) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (huntingPair_ != null) hash ^= HuntingPair.GetHashCode();
    if (CityId != 0) hash ^= CityId.GetHashCode();
    if (State != global::HuntingOfferState.None) hash ^= State.GetHashCode();
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
    if (State != global::HuntingOfferState.None) {
      output.WriteRawTag(8);
      output.WriteEnum((int) State);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(HuntingPair);
    }
    if (CityId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CityId);
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
    if (State != global::HuntingOfferState.None) {
      output.WriteRawTag(8);
      output.WriteEnum((int) State);
    }
    if (huntingPair_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(HuntingPair);
    }
    if (CityId != 0) {
      output.WriteRawTag(64);
      output.WriteUInt32(CityId);
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
    if (huntingPair_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(HuntingPair);
    }
    if (CityId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CityId);
    }
    if (State != global::HuntingOfferState.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(HuntingOfferData other) {
    if (other == null) {
      return;
    }
    if (other.huntingPair_ != null) {
      if (huntingPair_ == null) {
        HuntingPair = new global::HuntingPair();
      }
      HuntingPair.MergeFrom(other.HuntingPair);
    }
    if (other.CityId != 0) {
      CityId = other.CityId;
    }
    if (other.State != global::HuntingOfferState.None) {
      State = other.State;
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
          State = (global::HuntingOfferState) input.ReadEnum();
          break;
        }
        case 34: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
          break;
        }
        case 64: {
          CityId = input.ReadUInt32();
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
          State = (global::HuntingOfferState) input.ReadEnum();
          break;
        }
        case 34: {
          if (huntingPair_ == null) {
            HuntingPair = new global::HuntingPair();
          }
          input.ReadMessage(HuntingPair);
          break;
        }
        case 64: {
          CityId = input.ReadUInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
