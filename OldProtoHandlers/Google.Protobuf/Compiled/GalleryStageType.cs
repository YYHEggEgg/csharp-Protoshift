// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryStageType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GalleryStageType.proto</summary>
  public static partial class GalleryStageTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryStageType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryStageTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZHYWxsZXJ5U3RhZ2VUeXBlLnByb3RvKm4KEEdhbGxlcnlTdGFnZVR5cGUS",
            "GwoXR0FMTEVSWV9TVEFHRV9UWVBFX05PTkUQABIfChtHQUxMRVJZX1NUQUdF",
            "X1RZUEVfUFJFU1RBUlQQARIcChhHQUxMRVJZX1NUQUdFX1RZUEVfU1RBUlQQ",
            "AkIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.GalleryStageType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GalleryStageType {
    [pbr::OriginalName("GALLERY_STAGE_TYPE_NONE")] None = 0,
    [pbr::OriginalName("GALLERY_STAGE_TYPE_PRESTART")] Prestart = 1,
    [pbr::OriginalName("GALLERY_STAGE_TYPE_START")] Start = 2,
  }

  #endregion

}

#endregion Designer generated code
