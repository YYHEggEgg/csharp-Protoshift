// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinWindSeedSpawner.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OldProtos {

  /// <summary>Holder for reflection information generated from AbilityMixinWindSeedSpawner.proto</summary>
  public static partial class AbilityMixinWindSeedSpawnerReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinWindSeedSpawner.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinWindSeedSpawnerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFBYmlsaXR5TWl4aW5XaW5kU2VlZFNwYXduZXIucHJvdG8aDFZlY3Rvci5w",
            "cm90byK5AgobQWJpbGl0eU1peGluV2luZFNlZWRTcGF3bmVyEjwKCmFkZF9z",
            "aWduYWwYAiABKAsyJi5BYmlsaXR5TWl4aW5XaW5kU2VlZFNwYXduZXIuQWRk",
            "U2lnbmFsSAASQAoMcmVmcmVzaF9zZWVkGA8gASgLMiguQWJpbGl0eU1peGlu",
            "V2luZFNlZWRTcGF3bmVyLlJlZnJlc2hTZWVkSAASPAoKY2F0Y2hfc2VlZBgL",
            "IAEoCzImLkFiaWxpdHlNaXhpbldpbmRTZWVkU3Bhd25lci5DYXRjaFNlZWRI",
            "ABoLCglBZGRTaWduYWwaKAoLUmVmcmVzaFNlZWQSGQoIcG9zX2xpc3QYBiAD",
            "KAsyBy5WZWN0b3IaHgoJQ2F0Y2hTZWVkEhEKCWVudGl0eV9pZBgIIAEoDUIF",
            "CgNjbWRCDKoCCU9sZFByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::OldProtos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMixinWindSeedSpawner), global::OldProtos.AbilityMixinWindSeedSpawner.Parser, new[]{ "AddSignal", "RefreshSeed", "CatchSeed" }, new[]{ "Cmd" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal), global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed), global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed.Parser, new[]{ "PosList" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed), global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed.Parser, new[]{ "EntityId" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinWindSeedSpawner : pb::IMessage<AbilityMixinWindSeedSpawner>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinWindSeedSpawner> _parser = new pb::MessageParser<AbilityMixinWindSeedSpawner>(() => new AbilityMixinWindSeedSpawner());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinWindSeedSpawner> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::OldProtos.AbilityMixinWindSeedSpawnerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinWindSeedSpawner() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinWindSeedSpawner(AbilityMixinWindSeedSpawner other) : this() {
      switch (other.CmdCase) {
        case CmdOneofCase.AddSignal:
          AddSignal = other.AddSignal.Clone();
          break;
        case CmdOneofCase.RefreshSeed:
          RefreshSeed = other.RefreshSeed.Clone();
          break;
        case CmdOneofCase.CatchSeed:
          CatchSeed = other.CatchSeed.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinWindSeedSpawner Clone() {
      return new AbilityMixinWindSeedSpawner(this);
    }

    /// <summary>Field number for the "add_signal" field.</summary>
    public const int AddSignalFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal AddSignal {
      get { return cmdCase_ == CmdOneofCase.AddSignal ? (global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal) cmd_ : null; }
      set {
        cmd_ = value;
        cmdCase_ = value == null ? CmdOneofCase.None : CmdOneofCase.AddSignal;
      }
    }

    /// <summary>Field number for the "refresh_seed" field.</summary>
    public const int RefreshSeedFieldNumber = 15;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed RefreshSeed {
      get { return cmdCase_ == CmdOneofCase.RefreshSeed ? (global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed) cmd_ : null; }
      set {
        cmd_ = value;
        cmdCase_ = value == null ? CmdOneofCase.None : CmdOneofCase.RefreshSeed;
      }
    }

    /// <summary>Field number for the "catch_seed" field.</summary>
    public const int CatchSeedFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed CatchSeed {
      get { return cmdCase_ == CmdOneofCase.CatchSeed ? (global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed) cmd_ : null; }
      set {
        cmd_ = value;
        cmdCase_ = value == null ? CmdOneofCase.None : CmdOneofCase.CatchSeed;
      }
    }

    private object cmd_;
    /// <summary>Enum of possible cases for the "cmd" oneof.</summary>
    public enum CmdOneofCase {
      None = 0,
      AddSignal = 2,
      RefreshSeed = 15,
      CatchSeed = 11,
    }
    private CmdOneofCase cmdCase_ = CmdOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CmdOneofCase CmdCase {
      get { return cmdCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCmd() {
      cmdCase_ = CmdOneofCase.None;
      cmd_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinWindSeedSpawner);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinWindSeedSpawner other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AddSignal, other.AddSignal)) return false;
      if (!object.Equals(RefreshSeed, other.RefreshSeed)) return false;
      if (!object.Equals(CatchSeed, other.CatchSeed)) return false;
      if (CmdCase != other.CmdCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (cmdCase_ == CmdOneofCase.AddSignal) hash ^= AddSignal.GetHashCode();
      if (cmdCase_ == CmdOneofCase.RefreshSeed) hash ^= RefreshSeed.GetHashCode();
      if (cmdCase_ == CmdOneofCase.CatchSeed) hash ^= CatchSeed.GetHashCode();
      hash ^= (int) cmdCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (cmdCase_ == CmdOneofCase.AddSignal) {
        output.WriteRawTag(18);
        output.WriteMessage(AddSignal);
      }
      if (cmdCase_ == CmdOneofCase.CatchSeed) {
        output.WriteRawTag(90);
        output.WriteMessage(CatchSeed);
      }
      if (cmdCase_ == CmdOneofCase.RefreshSeed) {
        output.WriteRawTag(122);
        output.WriteMessage(RefreshSeed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (cmdCase_ == CmdOneofCase.AddSignal) {
        output.WriteRawTag(18);
        output.WriteMessage(AddSignal);
      }
      if (cmdCase_ == CmdOneofCase.CatchSeed) {
        output.WriteRawTag(90);
        output.WriteMessage(CatchSeed);
      }
      if (cmdCase_ == CmdOneofCase.RefreshSeed) {
        output.WriteRawTag(122);
        output.WriteMessage(RefreshSeed);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (cmdCase_ == CmdOneofCase.AddSignal) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AddSignal);
      }
      if (cmdCase_ == CmdOneofCase.RefreshSeed) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RefreshSeed);
      }
      if (cmdCase_ == CmdOneofCase.CatchSeed) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CatchSeed);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinWindSeedSpawner other) {
      if (other == null) {
        return;
      }
      switch (other.CmdCase) {
        case CmdOneofCase.AddSignal:
          if (AddSignal == null) {
            AddSignal = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal();
          }
          AddSignal.MergeFrom(other.AddSignal);
          break;
        case CmdOneofCase.RefreshSeed:
          if (RefreshSeed == null) {
            RefreshSeed = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed();
          }
          RefreshSeed.MergeFrom(other.RefreshSeed);
          break;
        case CmdOneofCase.CatchSeed:
          if (CatchSeed == null) {
            CatchSeed = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed();
          }
          CatchSeed.MergeFrom(other.CatchSeed);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal();
            if (cmdCase_ == CmdOneofCase.AddSignal) {
              subBuilder.MergeFrom(AddSignal);
            }
            input.ReadMessage(subBuilder);
            AddSignal = subBuilder;
            break;
          }
          case 90: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed();
            if (cmdCase_ == CmdOneofCase.CatchSeed) {
              subBuilder.MergeFrom(CatchSeed);
            }
            input.ReadMessage(subBuilder);
            CatchSeed = subBuilder;
            break;
          }
          case 122: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed();
            if (cmdCase_ == CmdOneofCase.RefreshSeed) {
              subBuilder.MergeFrom(RefreshSeed);
            }
            input.ReadMessage(subBuilder);
            RefreshSeed = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.AddSignal();
            if (cmdCase_ == CmdOneofCase.AddSignal) {
              subBuilder.MergeFrom(AddSignal);
            }
            input.ReadMessage(subBuilder);
            AddSignal = subBuilder;
            break;
          }
          case 90: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.CatchSeed();
            if (cmdCase_ == CmdOneofCase.CatchSeed) {
              subBuilder.MergeFrom(CatchSeed);
            }
            input.ReadMessage(subBuilder);
            CatchSeed = subBuilder;
            break;
          }
          case 122: {
            global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed subBuilder = new global::OldProtos.AbilityMixinWindSeedSpawner.Types.RefreshSeed();
            if (cmdCase_ == CmdOneofCase.RefreshSeed) {
              subBuilder.MergeFrom(RefreshSeed);
            }
            input.ReadMessage(subBuilder);
            RefreshSeed = subBuilder;
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AbilityMixinWindSeedSpawner message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class AddSignal : pb::IMessage<AddSignal>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<AddSignal> _parser = new pb::MessageParser<AddSignal>(() => new AddSignal());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<AddSignal> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::OldProtos.AbilityMixinWindSeedSpawner.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AddSignal() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AddSignal(AddSignal other) : this() {
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public AddSignal Clone() {
          return new AddSignal(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as AddSignal);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(AddSignal other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(AddSignal other) {
          if (other == null) {
            return;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
            }
          }
        }
        #endif

      }

      public sealed partial class RefreshSeed : pb::IMessage<RefreshSeed>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<RefreshSeed> _parser = new pb::MessageParser<RefreshSeed>(() => new RefreshSeed());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<RefreshSeed> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::OldProtos.AbilityMixinWindSeedSpawner.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RefreshSeed() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RefreshSeed(RefreshSeed other) : this() {
          posList_ = other.posList_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public RefreshSeed Clone() {
          return new RefreshSeed(this);
        }

        /// <summary>Field number for the "pos_list" field.</summary>
        public const int PosListFieldNumber = 6;
        private static readonly pb::FieldCodec<global::OldProtos.Vector> _repeated_posList_codec
            = pb::FieldCodec.ForMessage(50, global::OldProtos.Vector.Parser);
        private readonly pbc::RepeatedField<global::OldProtos.Vector> posList_ = new pbc::RepeatedField<global::OldProtos.Vector>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public pbc::RepeatedField<global::OldProtos.Vector> PosList {
          get { return posList_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as RefreshSeed);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(RefreshSeed other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if(!posList_.Equals(other.posList_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          hash ^= posList_.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          posList_.WriteTo(output, _repeated_posList_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          posList_.WriteTo(ref output, _repeated_posList_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          size += posList_.CalculateSize(_repeated_posList_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(RefreshSeed other) {
          if (other == null) {
            return;
          }
          posList_.Add(other.posList_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 50: {
                posList_.AddEntriesFrom(input, _repeated_posList_codec);
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 50: {
                posList_.AddEntriesFrom(ref input, _repeated_posList_codec);
                break;
              }
            }
          }
        }
        #endif

      }

      public sealed partial class CatchSeed : pb::IMessage<CatchSeed>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<CatchSeed> _parser = new pb::MessageParser<CatchSeed>(() => new CatchSeed());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<CatchSeed> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::OldProtos.AbilityMixinWindSeedSpawner.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CatchSeed() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CatchSeed(CatchSeed other) : this() {
          entityId_ = other.entityId_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public CatchSeed Clone() {
          return new CatchSeed(this);
        }

        /// <summary>Field number for the "entity_id" field.</summary>
        public const int EntityIdFieldNumber = 8;
        private uint entityId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint EntityId {
          get { return entityId_; }
          set {
            entityId_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as CatchSeed);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(CatchSeed other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (EntityId != other.EntityId) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (EntityId != 0) hash ^= EntityId.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (EntityId != 0) {
            output.WriteRawTag(64);
            output.WriteUInt32(EntityId);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (EntityId != 0) {
            output.WriteRawTag(64);
            output.WriteUInt32(EntityId);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (EntityId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(CatchSeed other) {
          if (other == null) {
            return;
          }
          if (other.EntityId != 0) {
            EntityId = other.EntityId;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 64: {
                EntityId = input.ReadUInt32();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 64: {
                EntityId = input.ReadUInt32();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
