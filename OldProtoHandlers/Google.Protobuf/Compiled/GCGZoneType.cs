// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGZoneType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from GCGZoneType.proto</summary>
  public static partial class GCGZoneTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGZoneType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGZoneTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQ0dab25lVHlwZS5wcm90byr2AQoLR0NHWm9uZVR5cGUSGQoVR0NHX1pP",
            "TkVfVFlQRV9JTlZBTElEEAASFgoSR0NHX1pPTkVfVFlQRV9ERUNLEAESFgoS",
            "R0NHX1pPTkVfVFlQRV9IQU5EEAISGwoXR0NHX1pPTkVfVFlQRV9DSEFSQUNU",
            "RVIQAxIYChRHQ0dfWk9ORV9UWVBFX01PRElGWRAEEhgKFEdDR19aT05FX1RZ",
            "UEVfU1VNTU9OEAUSGAoUR0NHX1pPTkVfVFlQRV9BU1NJU1QQBxIZChVHQ0df",
            "Wk9ORV9UWVBFX09OU1RBR0UQCBIWChJHQ0dfWk9ORV9UWVBFX1JVTEUQCUIM",
            "qgIJT2xkUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OldProtos.GCGZoneType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGZoneType {
    [pbr::OriginalName("GCG_ZONE_TYPE_INVALID")] Invalid = 0,
    [pbr::OriginalName("GCG_ZONE_TYPE_DECK")] Deck = 1,
    [pbr::OriginalName("GCG_ZONE_TYPE_HAND")] Hand = 2,
    [pbr::OriginalName("GCG_ZONE_TYPE_CHARACTER")] Character = 3,
    [pbr::OriginalName("GCG_ZONE_TYPE_MODIFY")] Modify = 4,
    [pbr::OriginalName("GCG_ZONE_TYPE_SUMMON")] Summon = 5,
    [pbr::OriginalName("GCG_ZONE_TYPE_ASSIST")] Assist = 7,
    [pbr::OriginalName("GCG_ZONE_TYPE_ONSTAGE")] Onstage = 8,
    [pbr::OriginalName("GCG_ZONE_TYPE_RULE")] Rule = 9,
  }

  #endregion

}

#endregion Designer generated code