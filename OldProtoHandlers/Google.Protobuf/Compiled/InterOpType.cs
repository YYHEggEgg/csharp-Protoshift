// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InterOpType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from InterOpType.proto</summary>
  public static partial class InterOpTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InterOpType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InterOpTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFJbnRlck9wVHlwZS5wcm90bypACgtJbnRlck9wVHlwZRIYChRJTlRFUl9P",
            "UF9UWVBFX0ZJTklTSBAAEhcKE0lOVEVSX09QX1RZUEVfU1RBUlQQAUIMqgIJ",
            "T2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.InterOpType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InterOpType {
    [pbr::OriginalName("INTER_OP_TYPE_FINISH")] Finish = 0,
    [pbr::OriginalName("INTER_OP_TYPE_START")] Start = 1,
  }

  #endregion

}

#endregion Designer generated code