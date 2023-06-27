using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using csharp_Protoshift.Enhanced.Handlers.GeneratedCode;
using csharp_Protoshift.Enhanced.Benchmark.Experimental;

namespace csharp_Protoshift.Enhanced.Benchmark
{
    public class Program
    {
        static NewProtos.GravenInnocencePhotoReminderNotify normal_2Fields = GetNormalFields.Get2Fields();
        static NewProtos.GadgetPlayStartNotify normal_3Fields = GetNormalFields.Get3Fields();

        static NewProtos.ChannelerSlabBuffSchemeInfo map_uint32_uint32_50 = GetMapFields.GetUInt32AndUInt32(50);
        static NewProtos.ChannelerSlabBuffSchemeInfo map_uint32_uint32_100 = GetMapFields.GetUInt32AndUInt32(100);
        static NewProtos.ChannelerSlabBuffSchemeInfo map_uint32_uint32_200 = GetMapFields.GetUInt32AndUInt32(200);
        static NewProtos.ChannelerSlabBuffSchemeInfo map_uint32_uint32_500 = GetMapFields.GetUInt32AndUInt32(500);
        static NewProtos.ChannelerSlabBuffSchemeInfo map_uint32_uint32_1000 = GetMapFields.GetUInt32AndUInt32(1000);

        static NewProtos.AbilityArgument oneof_normal_none = GetOneofFields.GetNormalNone();
        static NewProtos.AbilityArgument oneof_normal_float = GetOneofFields.GetNormalFloatContent();
        static NewProtos.AbilityArgument oneof_normal_string = GetOneofFields.GetNormalStringContent();

        static NewProtos.AbilityActionServerMonsterLog repeated_normal_100 = GetRepeatedFields.Produce(100);
        static NewProtos.AbilityActionServerMonsterLog repeated_normal_20000 = GetRepeatedFields.Produce(20000);

        static NewProtos.UnionCmdNotify union_AbilityInvocationsNotify_30_100 = GetUnionCmdNotify.GetSameRepeated(30, 100);
        
        static NewProtos.PingReq normal_longbytes_10 = GetPingReq.GetLongBytes(10);
        static NewProtos.PingReq normal_longbytes_100 = GetPingReq.GetLongBytes(100);
        static NewProtos.PingReq normal_longbytes_1000 = GetPingReq.GetLongBytes(1000);
        static NewProtos.PingReq normal_longbytes_10000 = GetPingReq.GetLongBytes(10000);

        #region Handlers
        static HandlerGravenInnocencePhotoReminderNotify handler_GravenInnocencePhotoReminderNotify = HandlerGravenInnocencePhotoReminderNotify.GlobalInstance;
        static HandlerGadgetPlayStartNotify handler_GadgetPlayStartNotify = HandlerGadgetPlayStartNotify.GlobalInstance;

        static HandlerChannelerSlabBuffSchemeInfo handler_ChannelerSlabBuffSchemeInfo = HandlerChannelerSlabBuffSchemeInfo.GlobalInstance;
        
        static HandlerAbilityArgument handler_AbilityArgument = HandlerAbilityArgument.GlobalInstance;
        
        static HandlerAbilityActionServerMonsterLog handler_AbilityActionServerMonsterLog = HandlerAbilityActionServerMonsterLog.GlobalInstance;
        static HandlerChannelerSlabBuffSchemeInfo_Special handler_new_ChannelerSlabBuffSchemeInfo = HandlerChannelerSlabBuffSchemeInfo_Special.GlobalInstance;

        static HandlerUnionCmdNotify handler_UnionCmdNotify = HandlerUnionCmdNotify.GlobalInstance;

        static HandlerPingReq handler_PingReq = HandlerPingReq.GlobalInstance;
        #endregion

        private static void Main(string[] args)
        {
            Console.WriteLine("Protoshift Benchmark v0.01");
            Console.WriteLine("Verifying protoshift accuracy...");
            bool properlyWork = true;
            if (!handler_GravenInnocencePhotoReminderNotify.NewShiftToOld(normal_2Fields).Equals(GetNormalFieldsVerity.Get2Fields())
                || !handler_GadgetPlayStartNotify.NewShiftToOld(normal_3Fields).Equals(GetNormalFieldsVerity.Get3Fields()))
            {
                Console.WriteLine("Normal Protoshift verity failed!");
                properlyWork = false;
            }
            if (!handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_50).Equals(GetMapFieldsVerity.GetUInt32AndUInt32(50))
                || !handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_1000).Equals(GetMapFieldsVerity.GetUInt32AndUInt32(1000)))
            {
                Console.WriteLine("Map Protoshift verity failed!");
                properlyWork = false;
            }
            if (!handler_AbilityArgument.NewShiftToOld(oneof_normal_none).Equals(GetOneofFieldsVerity.GetNormalNone())
                || !handler_AbilityArgument.NewShiftToOld(oneof_normal_float).Equals(GetOneofFieldsVerity.GetNormalFloatContent())
                || !handler_AbilityArgument.NewShiftToOld(oneof_normal_string).Equals(GetOneofFieldsVerity.GetNormalStringContent()))
            {
                Console.WriteLine("Oneof Protoshift verity failed!");
                properlyWork = false;
            }
            if (!handler_AbilityActionServerMonsterLog.NewShiftToOld(repeated_normal_100).Equals(GetRepeatedFieldsVerity.Produce(100))
                || !handler_AbilityActionServerMonsterLog.NewShiftToOld(repeated_normal_20000).Equals(GetRepeatedFieldsVerity.Produce(20000)))
            {
                Console.WriteLine("Repeated Protoshift verity failed!");
                properlyWork = false;
            }
            /*if (!handler_UnionCmdNotify.NewShiftToOld(union_AbilityInvocationsNotify_30_100).Equals(GetUnionCmdNotifyVerity.GetSameRepeated(30, 100)))
            {
                Console.WriteLine("UnionCmd Protoshift verity failed!");
                properlyWork = false;
            }*/
            if (!properlyWork)
            {
                Console.WriteLine("Protoshift not working properly. Exit with 114514. ");
                Environment.Exit(114514);
            }
            else Console.WriteLine("Protoshift verity check passed!");
            
            BenchmarkRunner.Run<Program>();
        }

        // [Benchmark]
        public void TestShift_normal_2Fields()
            => handler_GravenInnocencePhotoReminderNotify.NewShiftToOld(normal_2Fields);
        // [Benchmark]
        public void TestShift_normal_3Fields()
            => handler_GadgetPlayStartNotify.NewShiftToOld(normal_3Fields);
        // [Benchmark]
        public void TestShift_map_uint32_uint32_50()
            => handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_50);
        // [Benchmark]
        public void TestShift_map_uint32_uint32_100()
            => handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_100);
        // [Benchmark]
        public void TestShift_map_uint32_uint32_200()
            => handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_200);
        // [Benchmark]
        public void TestShift_map_uint32_uint32_500()
            => handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_500);
        // [Benchmark]
        public void TestShift_map_uint32_uint32_1000()
            => handler_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_1000);
        // [Benchmark]
        public void TestShift_oneof_normal_none()
            => handler_AbilityArgument.NewShiftToOld(oneof_normal_none);
        // [Benchmark]
        public void TestShift_oneof_normal_float()
            => handler_AbilityArgument.NewShiftToOld(oneof_normal_float);
        // [Benchmark]
        public void TestShift_oneof_normal_string()
            => handler_AbilityArgument.NewShiftToOld(oneof_normal_string);
        // [Benchmark]
        public void TestShift_repeated_normal_100()
            => handler_AbilityActionServerMonsterLog.NewShiftToOld(repeated_normal_100);
        // [Benchmark]
        public void TestShift_repeated_normal_20000()
            => handler_AbilityActionServerMonsterLog.NewShiftToOld(repeated_normal_20000);
        // [Benchmark]
        public void TestShift_union_AbilityInvocationsNotify_30_100()
            => handler_UnionCmdNotify.NewShiftToOld(union_AbilityInvocationsNotify_30_100);
        [Benchmark]
        public void TestShift_normal_longbytes_10()
            => handler_PingReq.NewShiftToOld(normal_longbytes_10);
        [Benchmark]
        public void TestShift_normal_longbytes_100()
            => handler_PingReq.NewShiftToOld(normal_longbytes_100);
        [Benchmark]
        public void TestShift_normal_longbytes_1000()
            => handler_PingReq.NewShiftToOld(normal_longbytes_1000);
        [Benchmark]
        public void TestShift_normal_longbytes_10000()
            => handler_PingReq.NewShiftToOld(normal_longbytes_10000);

        
        // [Benchmark]
        public void TestShift_new_map_uint32_uint32_50()
            => handler_new_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_50);
        // [Benchmark]
        public void TestShift_new_map_uint32_uint32_100()
            => handler_new_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_100);
        // [Benchmark]
        public void TestShift_new_map_uint32_uint32_200()
            => handler_new_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_200);
        // [Benchmark]
        public void TestShift_new_map_uint32_uint32_500()
            => handler_new_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_500);
        // [Benchmark]
        public void TestShift_new_map_uint32_uint32_1000()
            => handler_new_ChannelerSlabBuffSchemeInfo.NewShiftToOld(map_uint32_uint32_1000);
    }
}