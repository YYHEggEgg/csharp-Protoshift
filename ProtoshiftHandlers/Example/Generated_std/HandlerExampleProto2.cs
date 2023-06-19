// Below is human-written, acting as an generated code example.
// 
// ------------------------------------------------------------
//
// <auto-generated>
//     Generated by csharp-Protoshift.HandlerGenerator. 
// </auto-generated>

#region Designer Generated Code
using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerExampleProto2 
        : HandlerBase<NewProtos.ExampleProto2, OldProtos.ExampleProto2>
    {
        #region Base Type
        MessageParser<NewProtos.ExampleProto2> newproto_parser_base = NewProtos.ExampleProto2.Parser;
        MessageParser<OldProtos.ExampleProto2> oldproto_parser_base = OldProtos.ExampleProto2.Parser;
        #endregion
        #region Import Types
        HandlerExampleEnum handler_ExampleEnum = new();
        HandlerExampleProto2 handler_ExampleProto2 = new();
        HandlerInMessage handler_InMessage = new();
        #endregion

        #region Protocol shift
        public override OldProtos.ExampleProto2 NewShiftToOld(NewProtos.ExampleProto2 newprotocol)
        {
            OldProtos.ExampleProto2 oldprotocol = new();
            return oldprotocol;
        }

        public override NewProtos.ExampleProto2 OldShiftToNew(OldProtos.ExampleProto2 oldprotocol)
        {
            NewProtos.ExampleProto2 newprotocol = new();
            return newprotocol;
        }
        #endregion

        #region Outer bytes invoke
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
            => NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
            => NewShiftToOld(newproto_parser_base.ParseFrom(span)).ToByteArray();
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(span)).ToByteArray();
        #endregion

        #region Inner Message
        public class HandlerExampleInnerProto
            : HandlerBase<NewProtos.ExampleProto2.Types.ExampleInnerProto, OldProtos.ExampleProto2.Types.ExampleInnerProto>
        {
            #region Base Type
            MessageParser<NewProtos.ExampleProto2.Types.ExampleInnerProto> newproto_parser_base = NewProtos.ExampleProto2.Types.ExampleInnerProto.Parser;
            MessageParser<OldProtos.ExampleProto2.Types.ExampleInnerProto> oldproto_parser_base = OldProtos.ExampleProto2.Types.ExampleInnerProto.Parser;
            #endregion
            #region Import Types
            #endregion

            #region Protocol shift
            public override OldProtos.ExampleProto2.Types.ExampleInnerProto NewShiftToOld(NewProtos.ExampleProto2.Types.ExampleInnerProto newprotocol)
            {
                OldProtos.ExampleProto2.Types.ExampleInnerProto oldprotocol = new();
                oldprotocol.InnerCode = newprotocol.InnerCode;
                return oldprotocol;
            }

            public override NewProtos.ExampleProto2.Types.ExampleInnerProto OldShiftToNew(OldProtos.ExampleProto2.Types.ExampleInnerProto oldprotocol)
            {
                NewProtos.ExampleProto2.Types.ExampleInnerProto newprotocol = new();
                newprotocol.InnerCode = oldprotocol.InnerCode;
                return newprotocol;
            }
            #endregion

            #region Outer bytes invoke
            public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
                => NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
            public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
                => NewShiftToOld(newproto_parser_base.ParseFrom(span)).ToByteArray();
            public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
                => OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
            public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
                => OldShiftToNew(oldproto_parser_base.ParseFrom(span)).ToByteArray();
            #endregion
        }
        #endregion

        #region Inner Enums
        public class HandlerExampleInnerEnum
            : HandlerEnumBase<NewProtos.ExampleProto2.Types.ExampleInnerEnum, OldProtos.ExampleProto2.Types.ExampleInnerEnum>
        {
            public override OldProtos.ExampleProto2.Types.ExampleInnerEnum NewShiftToOld(NewProtos.ExampleProto2.Types.ExampleInnerEnum newprotocol)
            {
                switch (newprotocol)
                {
                    case NewProtos.ExampleProto2.Types.ExampleInnerEnum.None:
                        return OldProtos.ExampleProto2.Types.ExampleInnerEnum.None;
                    case NewProtos.ExampleProto2.Types.ExampleInnerEnum.Someobj:
                        return OldProtos.ExampleProto2.Types.ExampleInnerEnum.Someobj;
                    case NewProtos.ExampleProto2.Types.ExampleInnerEnum.Otherobj:
                        return OldProtos.ExampleProto2.Types.ExampleInnerEnum.Otherobj;
                    default:
                        return OldProtos.ExampleProto2.Types.ExampleInnerEnum.None;
                }
            }

            public override NewProtos.ExampleProto2.Types.ExampleInnerEnum OldShiftToNew(OldProtos.ExampleProto2.Types.ExampleInnerEnum oldprotocol)
            {
                switch (oldprotocol)
                {
                    case OldProtos.ExampleProto2.Types.ExampleInnerEnum.None:
                        return NewProtos.ExampleProto2.Types.ExampleInnerEnum.None;
                    case OldProtos.ExampleProto2.Types.ExampleInnerEnum.Someobj:
                        return NewProtos.ExampleProto2.Types.ExampleInnerEnum.Someobj;
                    case OldProtos.ExampleProto2.Types.ExampleInnerEnum.Otherobj:
                        return NewProtos.ExampleProto2.Types.ExampleInnerEnum.Otherobj;
                    default:
                        return NewProtos.ExampleProto2.Types.ExampleInnerEnum.None;
                }
            }
        }
        #endregion
    }
}
#endregion Designer generated code