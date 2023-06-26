namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetOneofFields
    {
        public static NewProtos.AbilityArgument GetNormalNone()
        {
            return new NewProtos.AbilityArgument();
        }

        public static NewProtos.AbilityArgument GetNormalFloatContent()
        {
            NewProtos.AbilityArgument rtn = new();
            rtn.FloatArg = 0.135426F;
            return rtn;
        }

        public static NewProtos.AbilityArgument GetNormalStringContent()
        {
            NewProtos.AbilityArgument rtn = new();
            rtn.StrArg = "@YYHEggEgg";
            return rtn;
        }
    }
    
    internal static class GetOneofFieldsVerity
    {
        public static OldProtos.AbilityArgument GetNormalNone()
        {
            return new OldProtos.AbilityArgument();
        }

        public static OldProtos.AbilityArgument GetNormalFloatContent()
        {
            OldProtos.AbilityArgument rtn = new();
            rtn.FloatArg = 0.135426F;
            return rtn;
        }

        public static OldProtos.AbilityArgument GetNormalStringContent()
        {
            OldProtos.AbilityArgument rtn = new();
            rtn.StrArg = "@YYHEggEgg";
            return rtn;
        }
    }
}