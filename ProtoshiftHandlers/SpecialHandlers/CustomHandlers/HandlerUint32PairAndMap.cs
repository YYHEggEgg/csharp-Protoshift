using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using Google.Protobuf.Collections;

namespace csharp_Protoshift.Enhanced.Handlers.CustomHandlers
{
    internal class HandlerUint32PairAndMap
    {
        public void NewShiftToOld(MapField<uint, uint>? newprotocol,
            /*ref*/ RepeatedField<OldProtos.Uint32Pair> outputTo_oldprotocol)
        {
            if (newprotocol == null) return;
            outputTo_oldprotocol.AddRange(
                from pair in newprotocol
                select new OldProtos.Uint32Pair
                {
                    Key = pair.Key,
                    Value = pair.Value
                });
        }

        public void OldShiftToNew(MapField<uint, uint>? oldprotocol,
            /*ref*/ RepeatedField<NewProtos.Uint32Pair> outputTo_newprotocol)
        {
            if (oldprotocol == null) return;
            outputTo_newprotocol.AddRange(
                from pair in oldprotocol
                select new NewProtos.Uint32Pair
                {
                    Key = pair.Key,
                    Value = pair.Value
                });
        }

        public void NewShiftToOld(RepeatedField<NewProtos.Uint32Pair>? newprotocol,
            /*ref*/ MapField<uint, uint> outputTo_oldprotocol)
        {
            if (newprotocol == null) return;
            foreach (var pair in newprotocol)
            {
                outputTo_oldprotocol.Add(pair.Key, pair.Value);
            }
        }

        public void OldShiftToNew(RepeatedField<OldProtos.Uint32Pair>? oldprotocol,
            /*ref*/ MapField<uint, uint> outputTo_newprotocol)
        {
            if (oldprotocol == null) return;
            foreach (var pair in oldprotocol)
            {
                outputTo_newprotocol.Add(pair.Key, pair.Value);
            }
        }

        private static HandlerUint32PairAndMap _globalOnlyInstance = new HandlerUint32PairAndMap();
        public static HandlerUint32PairAndMap GlobalInstance => _globalOnlyInstance;

        private HandlerUint32Pair handler_Uint32Pair = HandlerUint32Pair.GlobalInstance;
        public NewProtos.Uint32Pair GetNewShiftToOldJitInstance() =>
            handler_Uint32Pair.GetNewShiftToOldJitInstance();
    }
}
