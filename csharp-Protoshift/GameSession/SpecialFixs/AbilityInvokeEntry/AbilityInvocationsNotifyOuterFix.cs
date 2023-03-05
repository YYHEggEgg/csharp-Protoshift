using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class AbilityInvocationsNotifyOuterFix : ISpecialOuterSkillIssueFixer
    {
        public string Protoname => "AbilityInvocationsNotify";

        public string ApplyToVersion => "3.3.0";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>? fixer_bytes { get; set; }

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public AbilityInvocationsNotifyOuterFix()
        {
            NewProtos.QueryCmdId.TryGetSerializer("AbilityInvocationsNotify", out var newserializer);
            Mainutil_new = newserializer;
            OldProtos.QueryCmdId.TryGetSerializer("AbilityInvocationsNotify", out var oldserializer);
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
                    Log.Warn($"AbilityInvocationNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "AbilityInvocationNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.AbilityInvocationsNotify newnotify;
                try
                {
                    newnotify = NewProtos.AbilityInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Client)");
                    return data;
                }
                OldProtos.AbilityInvocationsNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.AbilityInvocationsNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Client)");
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
#if DEBUG
                var newjson = Mainutil_old.DeserializeToJson(newdata);
                var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                if (newlines.Length != oldlines.Length)
                {
                    Log.Warn($"AbilityInvocationNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "AbilityInvocationNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.AbilityInvocationsNotify newnotify;
                try
                {
                    newnotify = NewProtos.AbilityInvocationsNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Server)");
                    return data;
                }
                OldProtos.AbilityInvocationsNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.AbilityInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Server)");
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
