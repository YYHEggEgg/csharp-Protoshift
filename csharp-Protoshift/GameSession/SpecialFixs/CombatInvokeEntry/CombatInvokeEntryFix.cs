using Google.Protobuf;
using Newtonsoft.Json.Linq;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession.SpecialFixs.CombatInvokeEntry
{
    internal class CombatInvokeEntryFix : ISpecialBytesSkillIssueFixer
        <NewProtos.CombatTypeArgument, OldProtos.CombatTypeArgument, 
        NewProtos.CombatInvokeEntry, OldProtos.CombatInvokeEntry>
    {
        private readonly Dictionary<NewProtos.CombatTypeArgument, Type> messages;

        public string Protoname => "CombatInvocationsNotify";

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public Dictionary<NewProtos.CombatTypeArgument, ProtoShiftUtils> newutils { get; }

        public Dictionary<OldProtos.CombatTypeArgument, ProtoShiftUtils> oldutils { get; }

        public CombatInvokeEntryFix()
        {
            NewProtos.QueryCmdId.TryGetSerializer("CombatInvocationsNotify", out var newserializer);
            Mainutil_new = newserializer;
            OldProtos.QueryCmdId.TryGetSerializer("CombatInvocationsNotify", out var oldserializer);
            Mainutil_old = oldserializer;
            #region Hardcoded
            messages = new Dictionary<NewProtos.CombatTypeArgument, Type>
            {
                { NewProtos.CombatTypeArgument.EvtBeingHit, typeof(NewProtos.EvtBeingHitInfo) },
                { NewProtos.CombatTypeArgument.AnimatorStateChanged, typeof(NewProtos.EvtAnimatorStateChangedInfo) },
                { NewProtos.CombatTypeArgument.FaceToDir, typeof(NewProtos.EvtFaceToDirInfo) },
                { NewProtos.CombatTypeArgument.SetAttackTarget, typeof(NewProtos.EvtSetAttackTargetInfo) },
                { NewProtos.CombatTypeArgument.RushMove, typeof(NewProtos.EvtRushMoveInfo) },
                { NewProtos.CombatTypeArgument.AnimatorParameterChanged, typeof(NewProtos.EvtAnimatorParameterInfo) }, // Name don't equal
                { NewProtos.CombatTypeArgument.EntityMove, typeof(NewProtos.EntityMoveInfo) }, // Name don't equal
                { NewProtos.CombatTypeArgument.SyncEntityPosition, typeof(NewProtos.EvtSyncEntityPositionInfo) },
                { NewProtos.CombatTypeArgument.SteerMotionInfo, typeof(NewProtos.EvtCombatSteerMotionInfo) }, // Name don't equal
                { NewProtos.CombatTypeArgument.ForceSetPosInfo, typeof(NewProtos.EvtCombatForceSetPosInfo) }, // Name don't equal
                { NewProtos.CombatTypeArgument.CompensatePosDiff, typeof(NewProtos.EvtCompensatePosDiffInfo) },
                { NewProtos.CombatTypeArgument.MonsterDoBlink, typeof(NewProtos.EvtMonsterDoBlink) }, // Name don't equal
                { NewProtos.CombatTypeArgument.FixedRushMove, typeof(NewProtos.EvtFixedRushMove) }, // Name don't equal
                { NewProtos.CombatTypeArgument.SyncTransform, typeof(NewProtos.EvtSyncTransform) }, // Name don't equal
                { NewProtos.CombatTypeArgument.LightCoreMove, typeof(NewProtos.EvtLightCoreMove) }, // Name don't equal
                { NewProtos.CombatTypeArgument.BeingHealedNtf, typeof(NewProtos.EvtBeingHealedNotify) }, // Name don't equal
                { NewProtos.CombatTypeArgument.SkillAnchorPositionNtf, typeof(NewProtos.EvtSyncSkillAnchorPosition) }, // Name don't equal
                { NewProtos.CombatTypeArgument.GrapplingHookMove, typeof(NewProtos.EvtGrapplingHookMove) }, // Name don't equal
            };
            #endregion
            newutils = new();
            oldutils = new();
            foreach (var pair in messages)
            {
                newutils.Add(pair.Key, new(pair.Value.Name));
                oldutils.Add(Enum.Parse<OldProtos.CombatTypeArgument>(pair.Key.ToString()), new(pair.Value.Name));
            }
        }

        public string Handle(string data, bool isNewCmdid)
        {
            var jobj = JObject.Parse(data);
            if (jobj == null) throw new ArgumentException("Invalid json data!",     nameof(data));

            var combatjson = (string?)jobj["combatData"];
            if (combatjson == null)
            {
                Log.Dbug($"Combat Data not found in: {data}", "CombatInvokeEntryFix");
                return data;
            }

            if (isNewCmdid)
            {
                NewProtos.CombatInvokeEntry invoke;
                try
                {
                    invoke = NewProtos.CombatInvokeEntry.Parser.ParseJson(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.CombatInvokeEntry so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"jsondata: {data}", "CombatInvokeEntry(Client)");
                    return data;
                }
                if (newutils.ContainsKey(invoke.ArgumentType))
                {
                    try
                    {
                        var util = newutils[invoke.ArgumentType];
                        var newdata = invoke.CombatData.ToByteArray();
                        var olddata = util.NewShiftToOld(newdata);
                        var oldcombatdata = Convert.ToBase64String(olddata);
#if DEBUG
                        var newjson = util.GetJson(newdata, true);
                        var oldjson = util.GetJson(olddata, false);
                        var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                        var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                        if (newlines.Length != oldlines.Length)
                        {
                            Log.Warn($"CombatInvokeEntry({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                $"new: {newjson}\nold: {oldjson}", "CombatInvokeEntry(Client)");
                        }
#endif
                        jobj["combatData"] = oldcombatdata;
                        return jobj.ToString();
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                            $"{ex};\nInnerException:{ex.InnerException};\n" +
                            $"data: {combatjson}", "CombatInvokeEntryFix(Client)");
                        return data;
                    }
                }
                else
                {
                    if (invoke.CombatData.Length > 0)
                    {
                        Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                           $"data: {combatjson}", "CombatInvokeEntryFix(Client)");
                    }
                    return data;
                }
            }
            else
            {
                OldProtos.CombatInvokeEntry invoke;
                try
                {
                    invoke = OldProtos.CombatInvokeEntry.Parser.ParseJson(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.CombatInvokeEntry so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"jsondata: {data}", "CombatInvokeEntry(Server)");
                    return data;
                }
                if (oldutils.ContainsKey(invoke.ArgumentType))
                {
                    try
                    {
                        var util = oldutils[invoke.ArgumentType];
                        var olddata = invoke.CombatData.ToByteArray();
                        var newdata = util.OldShiftToNew(olddata);
                        var newcombatdata = Convert.ToBase64String(newdata);
#if DEBUG
                        var newjson = util.GetJson(newdata, true);
                        var oldjson = util.GetJson(olddata, false);
                        var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                        var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                        if (newlines.Length != oldlines.Length)
                        {
                            Log.Warn($"CombatInvokeEntry({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                $"new: {newjson}\nold: {oldjson}", "CombatInvokeEntry(Server)");
                        }
#endif
                        jobj["combatData"] = newcombatdata;
                        return jobj.ToString();
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                            $"{ex};\nInnerException:{ex.InnerException};\n" +
                            $"data: {combatjson}", "CombatInvokeEntryFix(Server)");
                        return data;
                    }
                }
                else
                {
                    if (invoke.CombatData.Length > 0)
                    {
                        Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                           $"data: {combatjson}", "CombatInvokeEntryFix(Server)");
                    }
                    return data;
                }
            }
        }

        public OldProtos.CombatInvokeEntry NewShiftToOld(NewProtos.CombatInvokeEntry message)
        {
            return OldProtos.ProtoSerialize.Discard_Unknown_fields_Parser
                .Parse<OldProtos.CombatInvokeEntry>(
                Handle(JsonFormatter.Default.Format(message), true));
        }

        public NewProtos.CombatInvokeEntry OldShiftToNew(OldProtos.CombatInvokeEntry message)
        {
            return NewProtos.ProtoSerialize.Discard_Unknown_fields_Parser
                .Parse<NewProtos.CombatInvokeEntry>(
                Handle(JsonFormatter.Default.Format(message), false));
        }
    }
}