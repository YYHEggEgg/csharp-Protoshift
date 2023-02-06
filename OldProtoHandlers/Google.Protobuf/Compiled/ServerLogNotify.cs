// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerLogNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ServerLogNotify.proto</summary>
public static partial class ServerLogNotifyReflection {

  #region Descriptor
  /// <summary>File descriptor for ServerLogNotify.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ServerLogNotifyReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVTZXJ2ZXJMb2dOb3RpZnkucHJvdG8aFFNlcnZlckxvZ0xldmVsLnByb3Rv",
          "GhNTZXJ2ZXJMb2dUeXBlLnByb3RvImsKD1NlcnZlckxvZ05vdGlmeRISCgpz",
          "ZXJ2ZXJfbG9nGAcgASgJEiAKCGxvZ190eXBlGAkgASgOMg4uU2VydmVyTG9n",
          "VHlwZRIiCglsb2dfbGV2ZWwYDyABKA4yDy5TZXJ2ZXJMb2dMZXZlbEIeChxl",
          "bXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::ServerLogLevelReflection.Descriptor, global::ServerLogTypeReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ServerLogNotify), global::ServerLogNotify.Parser, new[]{ "ServerLog", "LogType", "LogLevel" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// CmdId: 31
/// EnetChannelId: 1
/// EnetIsReliable: true
/// </summary>
public sealed partial class ServerLogNotify : pb::IMessage<ServerLogNotify>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<ServerLogNotify> _parser = new pb::MessageParser<ServerLogNotify>(() => new ServerLogNotify());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<ServerLogNotify> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ServerLogNotifyReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerLogNotify() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerLogNotify(ServerLogNotify other) : this() {
    serverLog_ = other.serverLog_;
    logType_ = other.logType_;
    logLevel_ = other.logLevel_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public ServerLogNotify Clone() {
    return new ServerLogNotify(this);
  }

  /// <summary>Field number for the "server_log" field.</summary>
  public const int ServerLogFieldNumber = 7;
  private string serverLog_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public string ServerLog {
    get { return serverLog_; }
    set {
      serverLog_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "log_type" field.</summary>
  public const int LogTypeFieldNumber = 9;
  private global::ServerLogType logType_ = global::ServerLogType.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ServerLogType LogType {
    get { return logType_; }
    set {
      logType_ = value;
    }
  }

  /// <summary>Field number for the "log_level" field.</summary>
  public const int LogLevelFieldNumber = 15;
  private global::ServerLogLevel logLevel_ = global::ServerLogLevel.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::ServerLogLevel LogLevel {
    get { return logLevel_; }
    set {
      logLevel_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as ServerLogNotify);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(ServerLogNotify other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ServerLog != other.ServerLog) return false;
    if (LogType != other.LogType) return false;
    if (LogLevel != other.LogLevel) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (ServerLog.Length != 0) hash ^= ServerLog.GetHashCode();
    if (LogType != global::ServerLogType.None) hash ^= LogType.GetHashCode();
    if (LogLevel != global::ServerLogLevel.None) hash ^= LogLevel.GetHashCode();
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
    if (ServerLog.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(ServerLog);
    }
    if (LogType != global::ServerLogType.None) {
      output.WriteRawTag(72);
      output.WriteEnum((int) LogType);
    }
    if (LogLevel != global::ServerLogLevel.None) {
      output.WriteRawTag(120);
      output.WriteEnum((int) LogLevel);
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
    if (ServerLog.Length != 0) {
      output.WriteRawTag(58);
      output.WriteString(ServerLog);
    }
    if (LogType != global::ServerLogType.None) {
      output.WriteRawTag(72);
      output.WriteEnum((int) LogType);
    }
    if (LogLevel != global::ServerLogLevel.None) {
      output.WriteRawTag(120);
      output.WriteEnum((int) LogLevel);
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
    if (ServerLog.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerLog);
    }
    if (LogType != global::ServerLogType.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LogType);
    }
    if (LogLevel != global::ServerLogLevel.None) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LogLevel);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(ServerLogNotify other) {
    if (other == null) {
      return;
    }
    if (other.ServerLog.Length != 0) {
      ServerLog = other.ServerLog;
    }
    if (other.LogType != global::ServerLogType.None) {
      LogType = other.LogType;
    }
    if (other.LogLevel != global::ServerLogLevel.None) {
      LogLevel = other.LogLevel;
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
        case 58: {
          ServerLog = input.ReadString();
          break;
        }
        case 72: {
          LogType = (global::ServerLogType) input.ReadEnum();
          break;
        }
        case 120: {
          LogLevel = (global::ServerLogLevel) input.ReadEnum();
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
        case 58: {
          ServerLog = input.ReadString();
          break;
        }
        case 72: {
          LogType = (global::ServerLogType) input.ReadEnum();
          break;
        }
        case 120: {
          LogLevel = (global::ServerLogLevel) input.ReadEnum();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
