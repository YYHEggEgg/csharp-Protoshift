// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FoundationOpType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace NewProtos {

  /// <summary>Holder for reflection information generated from FoundationOpType.proto</summary>
  public static partial class FoundationOpTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for FoundationOpType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FoundationOpTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGb3VuZGF0aW9uT3BUeXBlLnByb3RvKusBChBGb3VuZGF0aW9uT3BUeXBl",
            "EhsKF0ZPVU5EQVRJT05fT1BfVFlQRV9OT05FEAASHAoYRk9VTkRBVElPTl9P",
            "UF9UWVBFX0JVSUxEEAESIQodRk9VTkRBVElPTl9PUF9UWVBFX0RFTU9MSVRJ",
            "T04QAhIeChpGT1VOREFUSU9OX09QX1RZUEVfUkVCVUlMRBADEh0KGUZPVU5E",
            "QVRJT05fT1BfVFlQRV9ST1RBVEUQBBIbChdGT1VOREFUSU9OX09QX1RZUEVf",
            "TE9DSxAFEh0KGUZPVU5EQVRJT05fT1BfVFlQRV9VTkxPQ0sQBkIMqgIJTmV3",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::NewProtos.FoundationOpType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FoundationOpType {
    [pbr::OriginalName("FOUNDATION_OP_TYPE_NONE")] None = 0,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_BUILD")] Build = 1,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_DEMOLITION")] Demolition = 2,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_REBUILD")] Rebuild = 3,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_ROTATE")] Rotate = 4,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_LOCK")] Lock = 5,
    [pbr::OriginalName("FOUNDATION_OP_TYPE_UNLOCK")] Unlock = 6,
  }

  #endregion

}

#endregion Designer generated code
