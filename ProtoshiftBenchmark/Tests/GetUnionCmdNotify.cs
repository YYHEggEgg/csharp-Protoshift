using Google.Protobuf;

namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetUnionCmdNotify
    {
        public static NewProtos.UnionCmdNotify GetSameRepeated(int union_repeat, int ability_repeat)
        {
            uint cmd = 1130;
            NewProtos.AbilityInvokeEntry ability = new();
            ability.EventId = 5428745;
            ability.ArgumentType = NewProtos.AbilityInvokeArgument.None;
            ability.TotalTickTime = 0.132435135;
            NewProtos.AbilityInvocationsNotify abilities = new();
            for (int i = 0; i < ability_repeat; i++) abilities.Invokes.Add(ability);
            NewProtos.UnionCmd union = new();
            union.MessageId = cmd;
            union.Body = abilities.ToByteString();
            NewProtos.UnionCmdNotify unions = new();
            for (int i = 0; i < union_repeat; i++) unions.CmdList.Add(union);
            return unions;
        }
    }
    
    internal static class GetUnionCmdNotifyVerity
    {
        public static OldProtos.UnionCmdNotify GetSameRepeated(int union_repeat, int ability_repeat)
        {
            uint cmd = 1130;
            OldProtos.AbilityInvokeEntry ability = new();
            ability.EventId = 5428745;
            ability.ArgumentType = OldProtos.AbilityInvokeArgument.None;
            ability.TotalTickTime = 0.132435135;
            OldProtos.AbilityInvocationsNotify abilities = new();
            for (int i = 0; i < ability_repeat; i++) abilities.Invokes.Add(ability);
            OldProtos.UnionCmd union = new();
            union.MessageId = cmd;
            union.Body = abilities.ToByteString();
            OldProtos.UnionCmdNotify unions = new();
            for (int i = 0; i < union_repeat; i++) unions.CmdList.Add(union);
            return unions;
        }
    }
}