using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class ClientAbilitiesInitFinishCombineNotifyOuterFix
            : ISpecialOuterSkillIssueFixer<NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        public string Protoname => "ClientAbilitiesInitFinishCombineNotify";

        public ISpecialBytesSkillIssueFixer
            <NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>?
            fixer_bytes { get; set; }
        
        public NewProtos.ProtoSerialize Mainutil_new { get; }
        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public ClientAbilitiesInitFinishCombineNotifyOuterFix()
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
                    Log.Warn($"ClientAbilitiesInitFinishCombineNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "ClientAbilitiesInitFinishCombineNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilitiesInitFinishCombineNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilitiesInitFinishCombineNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilitiesInitFinishCombineNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilitiesInitFinishCombineNotifyFix(Client)");
                    return data;
                }
                OldProtos.ClientAbilitiesInitFinishCombineNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilitiesInitFinishCombineNotify.Parser.ParseFrom(olddata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilitiesInitFinishCombineNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilitiesInitFinishCombineNotifyFix(Client)");
                    return data;
                }
                #endregion
                #region Enumerate invoke list
                oldnotify.EntityInvokeList.Clear();
                foreach (var newentityinvokes in newnotify.EntityInvokeList)
                {
                    var oldentityinvokes = new OldProtos.EntityAbilityInvokeEntry 
                        { EntityId = newentityinvokes.EntityId };
                    foreach (var invoke in newentityinvokes.Invokes)
                    {
                        oldentityinvokes.Invokes.Add(fixer_bytes?.NewShiftToOld(invoke));
                    }
                    oldnotify.EntityInvokeList.Add(oldentityinvokes);
                }
                #endregion
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
                    Log.Warn($"ClientAbilitiesInitFinishCombineNotify has an information lost in Special Fix Protoshift:\n" +
                        $"new: {newjson}\nold: {oldjson}", "ClientAbilitiesInitFinishCombineNotifyOuterFix(Client)");
                }
#endif
                #endregion
                #region Get New Invokes and Old notify
                NewProtos.ClientAbilitiesInitFinishCombineNotify newnotify;
                try
                {
                    newnotify = NewProtos.ClientAbilitiesInitFinishCombineNotify.Parser.ParseFrom(newdata);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.ClientAbilitiesInitFinishCombineNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilitiesInitFinishCombineNotifyFix(Server)");
                    return data;
                }
                OldProtos.ClientAbilitiesInitFinishCombineNotify oldnotify;
                try
                {
                    oldnotify = OldProtos.ClientAbilitiesInitFinishCombineNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.ClientAbilitiesInitFinishCombineNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "ClientAbilitiesInitFinishCombineNotifyFix(Server)");
                    return data;
                }

                var oldinvokes = oldnotify.Invokes;
                #endregion
                #region Enumerate invoke list
                newnotify.EntityInvokeList.Clear();
                foreach (var oldentityinvokes in oldnotify.EntityInvokeList)
                {
                    var newentityinvokes = new NewProtos.EntityAbilityInvokeEntry 
                        { EntityId = oldentityinvokes.EntityId };
                    foreach (var invoke in oldentityinvokes.Invokes)
                    {
                        newentityinvokes.Invokes.Add(fixer_bytes?.OldShiftToNew(invoke));
                    }
                    newnotify.EntityInvokeList.Add(newentityinvokes);
                }
                #endregion
                return newnotify.ToByteArray();
            }
        }
    }
}