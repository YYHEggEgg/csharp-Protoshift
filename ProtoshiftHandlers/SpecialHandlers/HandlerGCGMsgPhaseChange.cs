using csharp_Protoshift.Enhanced.Handlers.CustomHandlers;
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerGCGMsgPhaseChange 
        : HandlerBase<NewProtos.GCGMsgPhaseChange, OldProtos.GCGMsgPhaseChange>
    {
        #region Base Type
        MessageParser<NewProtos.GCGMsgPhaseChange> newproto_parser_base = NewProtos.GCGMsgPhaseChange.Parser;
        MessageParser<OldProtos.GCGMsgPhaseChange> oldproto_parser_base = OldProtos.GCGMsgPhaseChange.Parser;
        #endregion
        #region Import Types
        HandlerGCGPhaseType handler_GCGPhaseType = HandlerGCGPhaseType.GlobalInstance;
        HandlerUint32PairAndMap handler_fuck = HandlerUint32PairAndMap.GlobalInstance;
        #endregion

        #region Protocol Shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override OldProtos.GCGMsgPhaseChange? NewShiftToOld(NewProtos.GCGMsgPhaseChange? newprotocol)
        {
            if (newprotocol == null) return null;
            OldProtos.GCGMsgPhaseChange oldprotocol = new();
            handler_fuck.NewShiftToOld(newprotocol.AllowControllerList, oldprotocol.AllowControllerMap);
            oldprotocol.AfterPhase = handler_GCGPhaseType.NewShiftToOld(newprotocol.AfterPhase);
            oldprotocol.BeforePhase = handler_GCGPhaseType.NewShiftToOld(newprotocol.BeforePhase);
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGMsgPhaseChange? OldShiftToNew(OldProtos.GCGMsgPhaseChange? oldprotocol)
        {
            if (oldprotocol == null) return null;
            NewProtos.GCGMsgPhaseChange newprotocol = new();
            newprotocol.AfterPhase = handler_GCGPhaseType.OldShiftToNew(oldprotocol.AfterPhase);
            newprotocol.BeforePhase = handler_GCGPhaseType.OldShiftToNew(oldprotocol.BeforePhase);
            handler_fuck.OldShiftToNew(oldprotocol.AllowControllerMap, newprotocol.AllowControllerList);
            return newprotocol;
        }

        #region JIT API
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGMsgPhaseChange GetNewShiftToOldJitInstance()
        {
            NewProtos.GCGMsgPhaseChange newprotocol = new();
            newprotocol.AfterPhase = handler_GCGPhaseType.GetNewShiftToOldJitInstance();
            newprotocol.AllowControllerList.Add(handler_fuck.GetNewShiftToOldJitInstance());
            newprotocol.BeforePhase = handler_GCGPhaseType.GetNewShiftToOldJitInstance();
            return newprotocol;
        }
            
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override void RunJit()
        {
            var instance = GetNewShiftToOldJitInstance();
            OldShiftToNew(NewShiftToOld(instance.ToByteArray()));
            OldShiftToNew(new Span<byte>(NewShiftToOld(new Span<byte>(instance.ToByteArray())).ToByteArray()));
            OldShiftToNew(NewShiftToOld(instance.ToByteString()));
        }
        #endregion
        #endregion

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override IMessage? NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn;
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString NewShiftToOld(ByteString bytes)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override IMessage? OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn;
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }

        private static HandlerGCGMsgPhaseChange _globalOnlyInstance = new HandlerGCGMsgPhaseChange();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public static HandlerGCGMsgPhaseChange GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}