// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BargainResultType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from BargainResultType.proto</summary>
  public static partial class BargainResultTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for BargainResultType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BargainResultTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdCYXJnYWluUmVzdWx0VHlwZS5wcm90byqGAQoRQmFyZ2FpblJlc3VsdFR5",
            "cGUSJQohQkFSR0FJTl9SRVNVTFRfVFlQRV9DT01QTEVURV9TVUNDEAASIwof",
            "QkFSR0FJTl9SRVNVTFRfVFlQRV9TSU5HTEVfRkFJTBABEiUKIUJBUkdBSU5f",
            "UkVTVUxUX1RZUEVfQ09NUExFVEVfRkFJTBACQgyqAglPbGRQcm90b3NiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.BargainResultType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum BargainResultType {
    [pbr::OriginalName("BARGAIN_RESULT_TYPE_COMPLETE_SUCC")] CompleteSucc = 0,
    [pbr::OriginalName("BARGAIN_RESULT_TYPE_SINGLE_FAIL")] SingleFail = 1,
    [pbr::OriginalName("BARGAIN_RESULT_TYPE_COMPLETE_FAIL")] CompleteFail = 2,
  }

  #endregion

}

#endregion Designer generated code
