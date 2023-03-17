using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class ClientAbilityInitFinishNotifyOuterFix
            : ISpecialOuterSkillIssueFixer<NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        public string Protoname => "ClientAbilityInitFinishNotify";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>? 
            fixer_bytes { get; set; }
        
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public ClientAbilityInitFinishNotifyOuterFix()
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
                    Log.Warn($"ClientAbilityInitFinishNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "ClientAbilityInitFinishNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilityInitFinishNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilityInitFinishNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilityInitFinishNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityInitFinishNotifyFix(Client)");
                    return data;
                }
                OldProtos.ClientAbilityInitFinishNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilityInitFinishNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilityInitFinishNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityInitFinishNotifyFix(Client)");
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
                    Log.Warn($"ClientAbilityInitFinishNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "ClientAbilityInitFinishNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilityInitFinishNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilityInitFinishNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilityInitFinishNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityInitFinishNotifyFix(Server)");
                    return data;
                }
                OldProtos.ClientAbilityInitFinishNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilityInitFinishNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilityInitFinishNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilityInitFinishNotifyFix(Server)");
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