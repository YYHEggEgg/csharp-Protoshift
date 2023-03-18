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
    internal class ClientAbilityChangeNotifyOuterFix
        : ISpecialOuterSkillIssueFixer<NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        public string Protoname => "ClientAbilityChangeNotify";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>? 
            fixer_bytes { get; set; }
        
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public ClientAbilityChangeNotifyOuterFix()
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
                SkillIssueDetect.StartHandleNewPacketWithoutRecord("ClientAbilityChangeNotify",
                    "ClientAbilityChangeNotifyOuterFix(Client)",
                    newbody: data, oldbody: olddata, newjson, Mainutil_new, Mainutil_old);
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilityChangeNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilityChangeNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilityChangeNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityChangeNotifyFix(Client)");
                    return data;
                }
                OldProtos.ClientAbilityChangeNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilityChangeNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilityChangeNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityChangeNotifyFix(Client)");
                    return data;
                }

                var newinvokes = newnotify.Invokes;
                #endregion
                oldnotify.Invokes.Clear();
                foreach (var invoke in newinvokes)
                {
                    oldnotify.Invokes.Add(fixer_bytes?.NewShiftToOld(invoke));
                }
                return oldnotify.ToByteArray();
            }
            else
            {
                #region Outer Protoshift
                var oldjson = Mainutil_old.DeserializeToJson(data);
                var newdata = Mainutil_new.SerializeFromJson(oldjson);
                SkillIssueDetect.StartHandleOldPacketWithoutRecord("ClientAbilityChangeNotify",
                    "ClientAbilityChangeNotifyOuterFix(Server)",
                    oldbody: data, newbody: newdata, oldjson, Mainutil_old, Mainutil_new);
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilityChangeNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilityChangeNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilityChangeNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityChangeNotifyFix(Server)");
                    return data;
                }
                OldProtos.ClientAbilityChangeNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilityChangeNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilityChangeNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityChangeNotifyFix(Server)");
                    return data;
                }

                var oldinvokes = oldnotify.Invokes;
                #endregion
                newnotify.Invokes.Clear();
                foreach (var invoke in oldinvokes)
                {
                    newnotify.Invokes.Add(fixer_bytes?.OldShiftToNew(invoke));
                }
                return newnotify.ToByteArray();
            }
        }
    }
}
