// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AuditState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AuditState.proto</summary>
  public static partial class AuditStateReflection {

    #region Descriptor
    /// <summary>File descriptor for AuditState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AuditStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBBdWRpdFN0YXRlLnByb3RvKlMKCkF1ZGl0U3RhdGUSFAoQQVVESVRfU1RB",
            "VEVfTk9ORRAAEhcKE0FVRElUX1NUQVRFX1dBSVRJTkcQARIWChJBVURJVF9T",
            "VEFURV9GQUlMRUQQAkIMqgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.AuditState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AuditState {
    [pbr::OriginalName("AUDIT_STATE_NONE")] None = 0,
    [pbr::OriginalName("AUDIT_STATE_WAITING")] Waiting = 1,
    [pbr::OriginalName("AUDIT_STATE_FAILED")] Failed = 2,
  }

  #endregion

}

#endregion Designer generated code
