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
    public class HandlerExampleEnum 
        : HandlerEnumBase<NewProtos.ExampleEnum, OldProtos.ExampleEnum>
    {
        public override OldProtos.ExampleEnum NewShiftToOld(NewProtos.ExampleEnum newprotocol)
        {
            switch (newprotocol)
            {
                case NewProtos.ExampleEnum.None:
                    return OldProtos.ExampleEnum.None;
                case NewProtos.ExampleEnum.ObjFirst:
                    return OldProtos.ExampleEnum.ObjFirst;
                case NewProtos.ExampleEnum.ObjSecond:
                    return OldProtos.ExampleEnum.ObjSecond;
                case NewProtos.ExampleEnum.ObjThird:
                    return OldProtos.ExampleEnum.ObjThird;
                default: // fallback
                    return OldProtos.ExampleEnum.None;
            }
        }

        public override NewProtos.ExampleEnum OldShiftToNew(OldProtos.ExampleEnum oldprotocol)
        {
            switch (oldprotocol)
            {
                case OldProtos.ExampleEnum.None:
                    return NewProtos.ExampleEnum.None;
                case OldProtos.ExampleEnum.ObjFirst:
                    return NewProtos.ExampleEnum.ObjFirst;
                case OldProtos.ExampleEnum.ObjSecond:
                    return NewProtos.ExampleEnum.ObjSecond;
                case OldProtos.ExampleEnum.ObjThird:
                    return NewProtos.ExampleEnum.ObjThird;
                default: // fallback
                    return NewProtos.ExampleEnum.None;
            }
        }

        private static HandlerExampleEnum _globalOnlyInstance = new HandlerExampleEnum();
        public static HandlerExampleEnum GlobalInstance => _globalOnlyInstance;
    }
}
#endregion Designer generated code