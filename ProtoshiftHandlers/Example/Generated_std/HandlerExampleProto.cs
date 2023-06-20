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
    public class HandlerExampleProto 
        : HandlerBase<NewProtos.ExampleProto, OldProtos.ExampleProto>
    {
        #region Base Type
        MessageParser<NewProtos.ExampleProto> newproto_parser_base = NewProtos.ExampleProto.Parser;
        MessageParser<OldProtos.ExampleProto> oldproto_parser_base = OldProtos.ExampleProto.Parser;
        #endregion
        #region Import Types
        HandlerExampleEnum handler_ExampleEnum = new();
        HandlerExampleProto2 handler_ExampleProto2 = new();
        HandlerInMessage handler_InMessage = new();
        #endregion

        #region Protocol shift
        public override OldProtos.ExampleProto NewShiftToOld(NewProtos.ExampleProto newprotocol)
        {
            OldProtos.ExampleProto oldprotocol = new();
            oldprotocol.EgEnum = handler_ExampleEnum.NewShiftToOld(newprotocol.EgEnum);
            oldprotocol.EgStr = newprotocol.EgStr;
            foreach (var eachmap_newprotocol_eg_proto2 in newprotocol.EgProto2)
            {
                oldprotocol.EgProto2.Add(eachmap_newprotocol_eg_proto2.Key, handler_ExampleProto2.NewShiftToOld(eachmap_newprotocol_eg_proto2.Value));
            }
            switch (newprotocol.EgOnefieldCase)
            {
                case NewProtos.ExampleProto.EgOnefieldOneofCase.AEnum:
                    oldprotocol.AEnum = handler_ExampleEnum.NewShiftToOld(newprotocol.AEnum);
                    break;
                case NewProtos.ExampleProto.EgOnefieldOneofCase.NotAEnum:
                    oldprotocol.NotAEnum = newprotocol.NotAEnum;
                    break;
                default:
                    break;
            }
            // Not found match CommonResult in old: [ Field Type: uint32, Field Name: UnkExample_FNSDOAGFD, Is Repeated: false, Is Import Type: false ]
            // Not found match CommonResult in old: [ Field Type: InMessage, Field Name: UnkExample_NSKLDVKVC, Is Repeated: true, Is Import Type: false ]
            return oldprotocol;
        }

        public override NewProtos.ExampleProto OldShiftToNew(OldProtos.ExampleProto oldprotocol)
        {
            NewProtos.ExampleProto newprotocol = new();
            newprotocol.EgEnum = handler_ExampleEnum.OldShiftToNew(oldprotocol.EgEnum);
            newprotocol.EgStr = newprotocol.EgStr;
            foreach (var eachmap_oldprotocol_eg_proto2 in oldprotocol.EgProto2)
            {
                newprotocol.EgProto2.Add(eachmap_oldprotocol_eg_proto2.Key, handler_ExampleProto2.OldShiftToNew(eachmap_oldprotocol_eg_proto2.Value));
            }
            switch (oldprotocol.EgOnefieldCase)
            {
                case OldProtos.ExampleProto.EgOnefieldOneofCase.AEnum:
                    newprotocol.AEnum = handler_ExampleEnum.OldShiftToNew(oldprotocol.AEnum);
                    break;
                case OldProtos.ExampleProto.EgOnefieldOneofCase.NotAEnum:
                    newprotocol.NotAEnum = oldprotocol.NotAEnum;
                    break;
                default:
                    break;
            }
            // Not found match CommonResult in new: [ Field Type: uint32, Field Name: retcode, Is Repeated: false, Is Import Type: false ]
            // Not found match CommonResult in new: [ Field Type: InMessage, Field Name: inner_messages, Is Repeated: true, Is Import Type: false ]
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
}
#endregion Designer generated code