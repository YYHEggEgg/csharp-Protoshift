// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerLogLevel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ServerLogLevel.proto</summary>
public static partial class ServerLogLevelReflection {

  #region Descriptor
  /// <summary>File descriptor for ServerLogLevel.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ServerLogLevelReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRTZXJ2ZXJMb2dMZXZlbC5wcm90byqcAQoOU2VydmVyTG9nTGV2ZWwSGQoV",
          "U0VSVkVSX0xPR19MRVZFTF9OT05FEAASGgoWU0VSVkVSX0xPR19MRVZFTF9E",
          "RUJVRxABEhkKFVNFUlZFUl9MT0dfTEVWRUxfSU5GTxACEhwKGFNFUlZFUl9M",
          "T0dfTEVWRUxfV0FSTklORxADEhoKFlNFUlZFUl9MT0dfTEVWRUxfRVJST1IQ",
          "BEIeChxlbXUuZ3Jhc3NjdXR0ZXIubmV0Lm9sZHByb3RvYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ServerLogLevel), }, null, null));
  }
  #endregion

}
#region Enums
public enum ServerLogLevel {
  [pbr::OriginalName("SERVER_LOG_LEVEL_NONE")] None = 0,
  [pbr::OriginalName("SERVER_LOG_LEVEL_DEBUG")] Debug = 1,
  [pbr::OriginalName("SERVER_LOG_LEVEL_INFO")] Info = 2,
  [pbr::OriginalName("SERVER_LOG_LEVEL_WARNING")] Warning = 3,
  [pbr::OriginalName("SERVER_LOG_LEVEL_ERROR")] Error = 4,
}

#endregion


#endregion Designer generated code
