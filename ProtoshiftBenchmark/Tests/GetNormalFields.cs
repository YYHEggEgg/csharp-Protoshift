namespace csharp_Protoshift.Enhanced.Benchmark
{
    internal static class GetNormalFields
    {
        public static NewProtos.GravenInnocencePhotoReminderNotify Get2Fields()
        {
            NewProtos.GravenInnocencePhotoReminderNotify rtn = new();
            rtn.ReminderId = 25645324;
            rtn.GroupBundleId = 433637;
            return rtn;
        }

        public static NewProtos.GadgetPlayStartNotify Get3Fields()
        {
            NewProtos.GadgetPlayStartNotify rtn = new();
            rtn.StartTime = 1656243243;
            rtn.PlayType = 1;
            rtn.EntityId = 89723452;
            return rtn;
        }
    }
    
    internal static class GetNormalFieldsVerity
    {
        public static OldProtos.GravenInnocencePhotoReminderNotify Get2Fields()
        {
            OldProtos.GravenInnocencePhotoReminderNotify rtn = new();
            rtn.ReminderId = 25645324;
            rtn.GroupBundleId = 433637;
            return rtn;
        }

        public static OldProtos.GadgetPlayStartNotify Get3Fields()
        {
            OldProtos.GadgetPlayStartNotify rtn = new();
            rtn.StartTime = 1656243243;
            rtn.PlayType = 1;
            rtn.EntityId = 89723452;
            return rtn;
        }
    }
}