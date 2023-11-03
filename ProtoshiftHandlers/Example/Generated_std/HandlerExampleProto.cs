// Below is human-written, acting as an generated code example.
// 
// ------------------------------------------------------------
//
// <auto-generated>
//     Generated by csharp-Protoshift.HandlerGenerator. 
// </auto-generated>

#nullable enable
#region Designer Generated Code
using csharp_Protoshift.ProtoHotPatch;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System.Collections.Generic;

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
        HandlerExampleEnum handler_ExampleEnum = HandlerExampleEnum.GlobalInstance;
        HandlerExampleProto2 handler_ExampleProto2 = HandlerExampleProto2.GlobalInstance;
        HandlerInMessage handler_InMessage = HandlerInMessage.GlobalInstance;
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static string[] ImportedHandlers = new string[] {
            "ExampleEnum", 
            "ExampleProto2", 
            "InMessage",
        };
        #endregion

        #region Protocol shift
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override OldProtos.ExampleProto? NewShiftToOld(NewProtos.ExampleProto? newprotocol)
        {
            if (newprotocol == null) return null;
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
            #region Skill issue Middleware
            #if DEBUG
            var __worker = HotPatchMiddleware.Worker;
            if (__worker.HasNewShiftToOldMiddleare(typeof(NewProtos.ExampleProto).Name))
            {
                oldprotocol = (OldProtos.ExampleProto)__worker.ExecuteNewShiftToOldMiddleware(
                    typeof(NewProtos.ExampleProto).Name, newprotocol, oldprotocol);
            }
            #endif
            #endregion
            return oldprotocol;
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override NewProtos.ExampleProto? OldShiftToNew(OldProtos.ExampleProto? oldprotocol)
        {
            if (oldprotocol == null) return null;
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
            #region Skill issue Middleware
            #if DEBUG
            var __worker = HotPatchMiddleware.Worker;
            if (__worker.HasOldShiftToNewMiddleare(typeof(OldProtos.ExampleProto).Name))
            {
                newprotocol = (NewProtos.ExampleProto)__worker.ExecuteOldShiftToNewMiddleware(
                    typeof(OldProtos.ExampleProto).Name, oldprotocol, newprotocol);
            }
            #endif
            #endregion
            return newprotocol;
        }

        #region JIT API
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override NewProtos.ExampleProto GetNewShiftToOldJitInstance()
        {
            NewProtos.ExampleProto newprotocol = new();
            newprotocol.EgEnum = handler_ExampleEnum.GetNewShiftToOldJitInstance();
            newprotocol.EgStr = "miHomo Technology Presents";
            newprotocol.EgProto2.Add("miHomo Technology Presents", handler_ExampleProto2.GetNewShiftToOldJitInstance());
            newprotocol.AEnum = handler_ExampleEnum.GetNewShiftToOldJitInstance();
            return newprotocol;
        }
        #endregion
        #endregion

        public bool HasSkillIssue = true;
        #pragma warning disable CS8603
        #pragma warning disable CS8604
        #region Skill issue APIs
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)> 
            oldSkillIssueList = new List<(string, string, string, bool)>
            {
                ("uint32", "retcode", "Retcode", true),
                ("InMessage", "inner_messages", "InnerMessage", true),
            };
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static object GetNewRetcode(OldProtos.ExampleProto oldprotocol)
            => oldprotocol.Retcode;
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static object GetNewInnerMessage(OldProtos.ExampleProto oldprotocol)
        {
            List<NewProtos.InMessage> res = new();
            foreach (var element_inner_messages in oldprotocol.InnerMessages)
            {
                res.Add(HandlerInMessage.GlobalInstance.OldShiftToNew(element_inner_messages));
            }
            return res;
        }
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static List<(string type_protobuf, string name_protobuf, string name_compiled, bool supported_type)>
            newSkillIssueList = new List<(string, string, string, bool)>
            {
                ("uint32", "UnkExample_FNSDOAGFD", "UnkExampleFNSDOAGFD", true),
                ("InMessage", "UnkExample_NSKLDVKVC", "UnkExampleNSKLDVKVC", true),
            };
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static object GetOldUnkExampleFNSDOAGFD(NewProtos.ExampleProto newprotocol)
            => newprotocol.UnkExampleFNSDOAGFD;
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static object GetOldUnkExampleNSKLDVKVC(NewProtos.ExampleProto newprotocol)
        {
            List<OldProtos.InMessage> res = new();
            foreach (var element_UnkExample_NSKLDVKVC in newprotocol.UnkExampleNSKLDVKVC)
            {
                res.Add(HandlerInMessage.GlobalInstance.NewShiftToOld(element_UnkExample_NSKLDVKVC));
            }
            return res;
        }
        #endregion
        #pragma warning restore CS8603
        #pragma warning restore CS8604

        #region Outer bytes invoke
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
        {
            var rtn = NewShiftToOld(newproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
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
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(span));
            return rtn == null ? Array.Empty<byte>() : rtn.ToByteArray();
        }
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public override ByteString OldShiftToNew(ByteString bytes)
        {
            var rtn = OldShiftToNew(oldproto_parser_base.ParseFrom(bytes));
            return rtn == null ? ByteString.Empty : rtn.ToByteString();
        }
        #endregion

        private static HandlerExampleProto _globalOnlyInstance = new HandlerExampleProto();
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("YYHEggEgg/csharp_Protoshift.HandlerGenerator", "1.0.0.0")]
        public static HandlerExampleProto GlobalInstance => _globalOnlyInstance;
    }
}
#endregion Designer generated code