using csharp_Protoshift.SkillIssue;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class AbilityInvocationFailNotifyOuterFix
        : ISpecialOuterSkillIssueFixer<NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        public string Protoname => "AbilityInvocationFailNotify";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>? 
            fixer_bytes { get; set; }
        
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public AbilityInvocationFailNotifyOuterFix()
        {
            NewProtos.QueryCmdId.TryGetSerializer(Protoname, out var newserializer);
            Mainutil_new = newserializer;
            OldProtos.QueryCmdId.TryGetSerializer(Protoname, out var oldserializer);
            Mainutil_old = oldserializer;
        }

        public byte[] Handle(byte[] data, bool isNewCmdid)
        {
            if (isNewCmdid)
            {
                #region Outer Protoshift
                var newjson = Mainutil_new.DeserializeToJson(data);
                var olddata = Mainutil_old.SerializeFromJson(newjson);
                SkillIssueDetect.StartHandleNewPacketWithoutRecord("AbilityInvocationFailNotify",
                    "AbilityInvocationFailNotifyOuterFix(Client)",
                    newbody: data, oldbody: olddata, newjson, Mainutil_new, Mainutil_old);
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.AbilityInvocationFailNotify newnotify;
                try
                {
                    newnotify = NewProtos.AbilityInvocationFailNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvocationFailNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationFailNotifyFix(Client)");
                    return data;
                }
                OldProtos.AbilityInvocationFailNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.AbilityInvocationFailNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvocationFailNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationFailNotifyFix(Client)");
                    return data;
                }
                #endregion
                oldnotify.Invoke = fixer_bytes?.NewShiftToOld(newnotify.Invoke);
                return oldnotify.ToByteArray();
            }
            else
            {
                #region Outer Protoshift
                var oldjson = Mainutil_old.DeserializeToJson(data);
                var newdata = Mainutil_new.SerializeFromJson(oldjson);
                SkillIssueDetect.StartHandleOldPacketWithoutRecord("AbilityInvocationFailNotify",
                    "AbilityInvocationFailNotifyOuterFix(Server)",
                    oldbody: data, newbody: newdata, oldjson, Mainutil_old, Mainutil_new);
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.AbilityInvocationFailNotify newnotify;
                try
                {
                    newnotify = NewProtos.AbilityInvocationFailNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvocationFailNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationFailNotifyFix(Server)");
                    return data;
                }
                OldProtos.AbilityInvocationFailNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.AbilityInvocationFailNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvocationFailNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationFailNotifyFix(Server)");
                    return data;
                }
                #endregion
                newnotify.Invoke = fixer_bytes?.OldShiftToNew(oldnotify.Invoke);
                return newnotify.ToByteArray();
            }
        }
    }
}