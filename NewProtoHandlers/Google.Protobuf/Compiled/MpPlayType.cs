// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MpPlayType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from MpPlayType.proto</summary>
  public static partial class MpPlayTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MpPlayType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MpPlayTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBNcFBsYXlUeXBlLnByb3RvKlgKCk1wUGxheVR5cGUSFQoRTVBfUExBWV9U",
            "WVBFX05PTkUQABIYChRNUF9QTEFZX1RZUEVfRFVOR0VPThABEhkKFU1QX1BM",
            "QVlfVFlQRV9DUlVDSUJMRRACQgyqAglOZXdQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.MpPlayType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MpPlayType {
    [pbr::OriginalName("MP_PLAY_TYPE_NONE")] None = 0,
    [pbr::OriginalName("MP_PLAY_TYPE_DUNGEON")] Dungeon = 1,
    [pbr::OriginalName("MP_PLAY_TYPE_CRUCIBLE")] Crucible = 2,
  }

  #endregion

}

#endregion Designer generated code
