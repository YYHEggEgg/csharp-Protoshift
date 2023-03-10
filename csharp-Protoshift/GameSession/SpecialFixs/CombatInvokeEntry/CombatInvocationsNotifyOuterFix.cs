using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs.CombatInvokeEntry
{
    internal class CombatInvocationsNotifyOuterFix 
        : ISpecialOuterSkillIssueFixer<NewProtos.CombatInvokeEntry, OldProtos.CombatInvokeEntry>
    {
        public string Protoname => "CombatInvocationsNotify";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.CombatInvokeEntry, OldProtos.CombatInvokeEntry>? fixer_bytes { get; set; }

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public CombatInvocationsNotifyOuterFix()
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
#if DEBUG
                var oldjson = Mainutil_old.DeserializeToJson(olddata);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"CombatInvocationNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "CombatInvocationNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.CombatInvocationsNotify newnotify;
                try
                {
                    newnotify = NewProtos.CombatInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix(Client)");
                    return data;
                }
                OldProtos.CombatInvocationsNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.CombatInvocationsNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix(Client)");
                    return data;
                }

                var newinvokes = newnotify.InvokeList;
                #endregion
                oldnotify.InvokeList.Clear();
                foreach (var invoke in newinvokes)
                {
                    oldnotify.InvokeList.Add(fixer_bytes?.NewShiftToOld(invoke));
                }
                return oldnotify.ToByteArray();
            }
            else
            {
                #region Outer Protoshift
                var oldjson = Mainutil_old.DeserializeToJson(data);
                var newdata = Mainutil_new.SerializeFromJson(oldjson);
#if DEBUG
                var newjson = Mainutil_old.DeserializeToJson(newdata);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"CombatInvocationNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "CombatInvocationNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.CombatInvocationsNotify newnotify;
                try
                {
                    newnotify = NewProtos.CombatInvocationsNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix(Server)");
                    return data;
                }
                OldProtos.CombatInvocationsNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.CombatInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix(Server)");
                    return data;
                }

                var oldinvokes = oldnotify.InvokeList;
                #endregion
                newnotify.InvokeList.Clear();
                foreach (var invoke in oldinvokes)
                {
                    newnotify.InvokeList.Add(fixer_bytes?.OldShiftToNew(invoke));
                }
                return newnotify.ToByteArray();
            }
        }
    }
}
