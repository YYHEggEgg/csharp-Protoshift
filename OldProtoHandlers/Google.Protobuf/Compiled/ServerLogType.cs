// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServerLogType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from ServerLogType.proto</summary>
  public static partial class ServerLogTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ServerLogType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerLogTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNTZXJ2ZXJMb2dUeXBlLnByb3RvKpYBCg1TZXJ2ZXJMb2dUeXBlEhgKFFNF",
            "UlZFUl9MT0dfVFlQRV9OT05FEAASGwoXU0VSVkVSX0xPR19UWVBFX0FCSUxJ",
            "VFkQARIZChVTRVJWRVJfTE9HX1RZUEVfTEVWRUwQAhIaChZTRVJWRVJfTE9H",
            "X1RZUEVfRU5USVRZEAMSFwoTU0VSVkVSX0xPR19UWVBFX0xVQRAEQgyqAglP",
            "bGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.ServerLogType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ServerLogType {
    [pbr::OriginalName("SERVER_LOG_TYPE_NONE")] None = 0,
    [pbr::OriginalName("SERVER_LOG_TYPE_ABILITY")] Ability = 1,
    [pbr::OriginalName("SERVER_LOG_TYPE_LEVEL")] Level = 2,
    [pbr::OriginalName("SERVER_LOG_TYPE_ENTITY")] Entity = 3,
    [pbr::OriginalName("SERVER_LOG_TYPE_LUA")] Lua = 4,
  }

  #endregion

}

#endregion Designer generated code
