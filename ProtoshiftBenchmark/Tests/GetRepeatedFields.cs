namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetRepeatedFields
    {
        public static NewProtos.AbilityActionServerMonsterLog Produce(int repeat)
        {
            NewProtos.AbilityActionServerMonsterLog rtn = new();
            for (int i = 0; i < repeat; i++)
            {
                rtn.ParamList.Add(i ^ 987842561);
            }
            return rtn;
        }
    }

    internal static class GetRepeatedFieldsVerity
    {
        public static OldProtos.AbilityActionServerMonsterLog Produce(int repeat)
        {
            OldProtos.AbilityActionServerMonsterLog rtn = new();
            for (int i = 0; i < repeat; i++)
            {
                rtn.ParamList.Add(i ^ 987842561);
            }
            return rtn;
        }
    }
}