namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetMapFields
    {
        public static NewProtos.ChannelerSlabBuffSchemeInfo GetUInt32AndUInt32(int repeat)
        {
            NewProtos.ChannelerSlabBuffSchemeInfo rtn = new();
            for (uint i = 0; i < repeat; i++)
            {
                rtn.SlotMap.Add(i ^ 824323094, i ^ 295420825);
            }
            return rtn;
        }

        public static NewProtos.FleurFairMusicGameInfo GetUInt32AndImported(int repeat)
        {
            throw new NotImplementedException();
        }
    }

    internal static class GetMapFieldsVerity
    {
        public static OldProtos.ChannelerSlabBuffSchemeInfo GetUInt32AndUInt32(int repeat)
        {
            OldProtos.ChannelerSlabBuffSchemeInfo rtn = new();
            for (uint i = 0; i < repeat; i++)
            {
                rtn.SlotMap.Add(i ^ 824323094, i ^ 295420825);
            }
            return rtn;
        }
    }
}