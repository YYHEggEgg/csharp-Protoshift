using Google.Protobuf;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerUnionCmd 
        : HandlerBase<NewProtos.UnionCmd, OldProtos.UnionCmd>
    {
        #region Base Type
        MessageParser<NewProtos.UnionCmd> newproto_parser_base = NewProtos.UnionCmd.Parser;
        MessageParser<OldProtos.UnionCmd> oldproto_parser_base = OldProtos.UnionCmd.Parser;
        #endregion
        #region Import Types
        #endregion

        #region Protocol Shift
        public override OldProtos.UnionCmd NewShiftToOld(NewProtos.UnionCmd? newprotocol)
        {
            OldProtos.UnionCmd oldprotocol = new();
            if (newprotocol == null) return oldprotocol;
            try
            {
                if (newprotocol.MessageId != 0 && !newprotocol.Body.IsEmpty)
                {
                    oldprotocol.MessageId = ShiftCmdId.NewShiftToOld(newprotocol.MessageId);
                    oldprotocol.Body = ProtoshiftDispatch.NewShiftToOld(
                        newprotocol.MessageId, null, newprotocol.Body);
                }
            }
            catch (NotSupportedException)
            {
                Log.Warn($"HandlerUnionCmd meets error so dropped a packet: Cmd {newprotocol.MessageId} (new) not supported.", nameof(HandlerUnionCmd));
                return new OldProtos.UnionCmd();
            }
            catch (Exception ex)
            {
                Log.Warn($"HandlerUnionCmd meets error so dropped a packet: {ex}", nameof(HandlerUnionCmd));
                return new OldProtos.UnionCmd();
            }
            return oldprotocol;
        }

        public override NewProtos.UnionCmd OldShiftToNew(OldProtos.UnionCmd? oldprotocol)
        {
            NewProtos.UnionCmd newprotocol = new();
            if (oldprotocol == null) return newprotocol;
            try
            {
                if (oldprotocol.MessageId != 0 && !oldprotocol.Body.IsEmpty)
                {
                    newprotocol.MessageId = ShiftCmdId.OldShiftToNew(oldprotocol.MessageId);
                    newprotocol.Body = ProtoshiftDispatch.OldShiftToNew(
                        oldprotocol.MessageId, null, oldprotocol.Body);
                }
            }
            catch (NotSupportedException ex)
            {
                Log.Warn($"HandlerUnionCmd meets error so dropped a packet: Cmd {oldprotocol.MessageId} (old) not supported.", nameof(HandlerUnionCmd));
                return new NewProtos.UnionCmd();
            }
            catch (Exception ex)
            {
                Log.Warn($"HandlerUnionCmd meets error so dropped a packet: {ex}", nameof(HandlerUnionCmd));
                return new NewProtos.UnionCmd();
            }
            return newprotocol;
        }

        #region JIT API
        public override NewProtos.UnionCmd GetNewShiftToOldJitInstance()
        {
            NewProtos.UnionCmd newprotocol = new();
            newprotocol.MessageId = 0;
            return newprotocol;
        }
        #endregion
        #endregion

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override IMessage? NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn;
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override ByteString NewShiftToOld(ByteString bytes)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override IMessage? OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn;
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }

        private static HandlerUnionCmd _globalOnlyInstance = new HandlerUnionCmd();
        public static HandlerUnionCmd GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
