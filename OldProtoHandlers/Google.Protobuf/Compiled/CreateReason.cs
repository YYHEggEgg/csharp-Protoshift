// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CreateReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from CreateReason.proto</summary>
  public static partial class CreateReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for CreateReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreateReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJDcmVhdGVSZWFzb24ucHJvdG8qWQoMQ3JlYXRlUmVhc29uEhYKEkNSRUFU",
            "RV9SRUFTT05fTk9ORRAAEhcKE0NSRUFURV9SRUFTT05fUVVFU1QQARIYChRD",
            "UkVBVEVfUkVBU09OX0VORVJHWRACQgyqAglPbGRQcm90b3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.CreateReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CreateReason {
    [pbr::OriginalName("CREATE_REASON_NONE")] None = 0,
    [pbr::OriginalName("CREATE_REASON_QUEST")] Quest = 1,
    [pbr::OriginalName("CREATE_REASON_ENERGY")] Energy = 2,
  }

  #endregion

}

#endregion Designer generated code
