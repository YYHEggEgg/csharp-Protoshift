// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientLogBodyPing.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ClientLogBodyPing.proto</summary>
  public static partial class ClientLogBodyPingReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientLogBodyPing.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientLogBodyPingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDbGllbnRMb2dCb2R5UGluZy5wcm90byKpAQoRQ2xpZW50TG9nQm9keVBp",
            "bmcSCgoCeGcYASABKAkSFAoMc2lnbmFsX2xldmVsGAIgASgNEgwKBHBpbmcY",
            "AyABKA0SEgoKc2VydmVydHlwZRgEIAEoCRIQCghzZXJ2ZXJpcBgFIAEoCRIS",
            "CgpzZXJ2ZXJwb3J0GAYgASgJEg4KBnBjb3VudBgHIAEoDRINCgVwbG9zdBgI",
            "IAEoDRILCgNkbnMYCSABKAlCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.ClientLogBodyPing), global::OldProtos.ClientLogBodyPing.Parser, new[]{ "Xg", "SignalLevel", "Ping", "Servertype", "Serverip", "Serverport", "Pcount", "Plost", "Dns" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientLogBodyPing : pb::IMessage<ClientLogBodyPing>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientLogBodyPing> _parser = new pb::MessageParser<ClientLogBodyPing>(() => new ClientLogBodyPing());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientLogBodyPing> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.ClientLogBodyPingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientLogBodyPing() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientLogBodyPing(ClientLogBodyPing other) : this() {
      xg_ = other.xg_;
      signalLevel_ = other.signalLevel_;
      ping_ = other.ping_;
      servertype_ = other.servertype_;
      serverip_ = other.serverip_;
      serverport_ = other.serverport_;
      pcount_ = other.pcount_;
      plost_ = other.plost_;
      dns_ = other.dns_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientLogBodyPing Clone() {
      return new ClientLogBodyPing(this);
    }

    /// <summary>Field number for the "xg" field.</summary>
    public const int XgFieldNumber = 1;
    private string xg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Xg {
      get { return xg_; }
      set {
        xg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signal_level" field.</summary>
    public const int SignalLevelFieldNumber = 2;
    private uint signalLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignalLevel {
      get { return signalLevel_; }
      set {
        signalLevel_ = value;
      }
    }

    /// <summary>Field number for the "ping" field.</summary>
    public const int PingFieldNumber = 3;
    private uint ping_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Ping {
      get { return ping_; }
      set {
        ping_ = value;
      }
    }

    /// <summary>Field number for the "servertype" field.</summary>
    public const int ServertypeFieldNumber = 4;
    private string servertype_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Servertype {
      get { return servertype_; }
      set {
        servertype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "serverip" field.</summary>
    public const int ServeripFieldNumber = 5;
    private string serverip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Serverip {
      get { return serverip_; }
      set {
        serverip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "serverport" field.</summary>
    public const int ServerportFieldNumber = 6;
    private string serverport_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Serverport {
      get { return serverport_; }
      set {
        serverport_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pcount" field.</summary>
    public const int PcountFieldNumber = 7;
    private uint pcount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pcount {
      get { return pcount_; }
      set {
        pcount_ = value;
      }
    }

    /// <summary>Field number for the "plost" field.</summary>
    public const int PlostFieldNumber = 8;
    private uint plost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Plost {
      get { return plost_; }
      set {
        plost_ = value;
      }
    }

    /// <summary>Field number for the "dns" field.</summary>
    public const int DnsFieldNumber = 9;
    private string dns_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Dns {
      get { return dns_; }
      set {
        dns_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientLogBodyPing);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientLogBodyPing other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Xg != other.Xg) return false;
      if (SignalLevel != other.SignalLevel) return false;
      if (Ping != other.Ping) return false;
      if (Servertype != other.Servertype) return false;
      if (Serverip != other.Serverip) return false;
      if (Serverport != other.Serverport) return false;
      if (Pcount != other.Pcount) return false;
      if (Plost != other.Plost) return false;
      if (Dns != other.Dns) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Xg.Length != 0) hash ^= Xg.GetHashCode();
      if (SignalLevel != 0) hash ^= SignalLevel.GetHashCode();
      if (Ping != 0) hash ^= Ping.GetHashCode();
      if (Servertype.Length != 0) hash ^= Servertype.GetHashCode();
      if (Serverip.Length != 0) hash ^= Serverip.GetHashCode();
      if (Serverport.Length != 0) hash ^= Serverport.GetHashCode();
      if (Pcount != 0) hash ^= Pcount.GetHashCode();
      if (Plost != 0) hash ^= Plost.GetHashCode();
      if (Dns.Length != 0) hash ^= Dns.GetHashCode();
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
      if (Xg.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Xg);
      }
      if (SignalLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SignalLevel);
      }
      if (Ping != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Ping);
      }
      if (Servertype.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Servertype);
      }
      if (Serverip.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Serverip);
      }
      if (Serverport.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Serverport);
      }
      if (Pcount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Pcount);
      }
      if (Plost != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Plost);
      }
      if (Dns.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Dns);
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
      if (Xg.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Xg);
      }
      if (SignalLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SignalLevel);
      }
      if (Ping != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Ping);
      }
      if (Servertype.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Servertype);
      }
      if (Serverip.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Serverip);
      }
      if (Serverport.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Serverport);
      }
      if (Pcount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Pcount);
      }
      if (Plost != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Plost);
      }
      if (Dns.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Dns);
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
      if (Xg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Xg);
      }
      if (SignalLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignalLevel);
      }
      if (Ping != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Ping);
      }
      if (Servertype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Servertype);
      }
      if (Serverip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Serverip);
      }
      if (Serverport.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Serverport);
      }
      if (Pcount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pcount);
      }
      if (Plost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Plost);
      }
      if (Dns.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Dns);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientLogBodyPing other) {
      if (other == null) {
        return;
      }
      if (other.Xg.Length != 0) {
        Xg = other.Xg;
      }
      if (other.SignalLevel != 0) {
        SignalLevel = other.SignalLevel;
      }
      if (other.Ping != 0) {
        Ping = other.Ping;
      }
      if (other.Servertype.Length != 0) {
        Servertype = other.Servertype;
      }
      if (other.Serverip.Length != 0) {
        Serverip = other.Serverip;
      }
      if (other.Serverport.Length != 0) {
        Serverport = other.Serverport;
      }
      if (other.Pcount != 0) {
        Pcount = other.Pcount;
      }
      if (other.Plost != 0) {
        Plost = other.Plost;
      }
      if (other.Dns.Length != 0) {
        Dns = other.Dns;
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
          case 10: {
            Xg = input.ReadString();
            break;
          }
          case 16: {
            SignalLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            Ping = input.ReadUInt32();
            break;
          }
          case 34: {
            Servertype = input.ReadString();
            break;
          }
          case 42: {
            Serverip = input.ReadString();
            break;
          }
          case 50: {
            Serverport = input.ReadString();
            break;
          }
          case 56: {
            Pcount = input.ReadUInt32();
            break;
          }
          case 64: {
            Plost = input.ReadUInt32();
            break;
          }
          case 74: {
            Dns = input.ReadString();
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
          case 10: {
            Xg = input.ReadString();
            break;
          }
          case 16: {
            SignalLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            Ping = input.ReadUInt32();
            break;
          }
          case 34: {
            Servertype = input.ReadString();
            break;
          }
          case 42: {
            Serverip = input.ReadString();
            break;
          }
          case 50: {
            Serverport = input.ReadString();
            break;
          }
          case 56: {
            Pcount = input.ReadUInt32();
            break;
          }
          case 64: {
            Plost = input.ReadUInt32();
            break;
          }
          case 74: {
            Dns = input.ReadString();
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
