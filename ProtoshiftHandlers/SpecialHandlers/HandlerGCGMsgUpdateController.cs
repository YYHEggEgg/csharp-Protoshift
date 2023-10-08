using csharp_Protoshift.Enhanced.Handlers.CustomHandlers;
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerGCGMsgUpdateController 
        : HandlerBase<NewProtos.GCGMsgUpdateController, OldProtos.GCGMsgUpdateController>
    {
        #region Base Type
        MessageParser<NewProtos.GCGMsgUpdateController> newproto_parser_base = NewProtos.GCGMsgUpdateController.Parser;
        MessageParser<OldProtos.GCGMsgUpdateController> oldproto_parser_base = OldProtos.GCGMsgUpdateController.Parser;
        #endregion
        #region Import Types
        HandlerUint32PairAndMap handler_fuck = HandlerUint32PairAndMap.GlobalInstance;
        #endregion

        #region Protocol Shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override OldProtos.GCGMsgUpdateController? NewShiftToOld(NewProtos.GCGMsgUpdateController? newprotocol)
        {
            if (newprotocol == null) return null;
            OldProtos.GCGMsgUpdateController oldprotocol = new();
            handler_fuck.NewShiftToOld(newprotocol.AllowControllerList, oldprotocol.AllowControllerMap);
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override NewProtos.GCGMsgUpdateController? OldShiftToNew(OldProtos.GCGMsgUpdateController? oldprotocol)
        {
            if (oldprotocol == null) return null;
            NewProtos.GCGMsgUpdateController newprotocol = new();
            handler_fuck.OldShiftToNew(oldprotocol.AllowControllerMap, newprotocol.AllowControllerList);
            return newprotocol;
        }
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
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
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
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }

        private static HandlerGCGMsgUpdateController _globalOnlyInstance = new HandlerGCGMsgUpdateController();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.1.0")]
        public static HandlerGCGMsgUpdateController GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
