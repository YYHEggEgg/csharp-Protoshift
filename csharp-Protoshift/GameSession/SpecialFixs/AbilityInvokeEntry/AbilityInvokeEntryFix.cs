using Google.Protobuf;
using Newtonsoft.Json.Linq;

namespace csharp_Protoshift.GameSession.SpecialFixs.AbilityInvokeEntry
{
    internal class AbilityInvokeEntryFix : ISpecialBytesSkillIssueFixer
        <NewProtos.AbilityInvokeArgument, OldProtos.AbilityInvokeArgument, 
        NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        public string Protoname => "AbilityInvokeEntry";

        private readonly Dictionary<NewProtos.AbilityInvokeArgument, Type> messages;

        public Dictionary<NewProtos.AbilityInvokeArgument, ProtoShiftUtils> newutils { get; }

        public Dictionary<OldProtos.AbilityInvokeArgument, ProtoShiftUtils> oldutils { get; }

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public AbilityInvokeEntryFix()
        {
            Mainutil_new = new(Protoname);
            Mainutil_old = new(Protoname);
            #region Hardcoded
            messages = new Dictionary<NewProtos.AbilityInvokeArgument, Type>
            {
                // Meta region, expected 15 protos, 22 records - 7 not found, OK
                { NewProtos.AbilityInvokeArgument.MetaModifierChange, typeof(NewProtos.AbilityMetaModifierChange) },
                // { NewProtos.AbilityInvokeArgument.MetaCommandModifierChangeRequest, typeof(NewProtos.AbilityMetaCommandModifierChangeRequest) },
                { NewProtos.AbilityInvokeArgument.MetaSpecialFloatArgument, typeof(NewProtos.AbilityMetaSpecialFloatArgument) },
                { NewProtos.AbilityInvokeArgument.MetaOverrideParam, typeof(NewProtos.AbilityScalarValueEntry) }, // Name don't equal
                // { NewProtos.AbilityInvokeArgument.MetaClearOverrideParam, typeof(NewProtos.AbilityMetaClearOverrideParam) },
                { NewProtos.AbilityInvokeArgument.MetaReinitOverridemap, typeof(NewProtos.AbilityMetaReInitOverrideMap) }, // Name don't equal
                { NewProtos.AbilityInvokeArgument.MetaGlobalFloatValue, typeof(NewProtos.AbilityScalarValueEntry) }, // Name don't equal
                { NewProtos.AbilityInvokeArgument.MetaClearGlobalFloatValue, typeof(NewProtos.AbilityString) }, // Name don't equal
                // { NewProtos.AbilityInvokeArgument.MetaAbilityElementStrength, typeof(NewProtos.AbilityMetaAbilityElementStrength) },
                { NewProtos.AbilityInvokeArgument.MetaAddOrGetAbilityAndTrigger, typeof(NewProtos.AbilityMetaAddOrGetAbilityAndTrigger) },
                { NewProtos.AbilityInvokeArgument.MetaSetKilledState, typeof(NewProtos.AbilityMetaSetKilledState) },
                { NewProtos.AbilityInvokeArgument.MetaSetAbilityTrigger, typeof(NewProtos.AbilityMetaSetAbilityTrigger) },
                { NewProtos.AbilityInvokeArgument.MetaAddNewAbility, typeof(NewProtos.AbilityMetaAddAbility) }, // Name don't equal
                // { NewProtos.AbilityInvokeArgument.MetaRemoveAbility, typeof(NewProtos.AbilityMetaRemoveAbility) },
                { NewProtos.AbilityInvokeArgument.MetaSetModifierApplyEntity, typeof(NewProtos.AbilityMetaSetModifierApplyEntityId) }, // Name don't equal
                { NewProtos.AbilityInvokeArgument.MetaModifierDurabilityChange, typeof(NewProtos.AbilityMetaModifierDurabilityChange) },
                { NewProtos.AbilityInvokeArgument.MetaElementReactionVisual, typeof(NewProtos.AbilityMetaElementReactionVisual) },
                { NewProtos.AbilityInvokeArgument.MetaSetPoseParameter, typeof(NewProtos.AbilityMetaSetPoseParameter) },
                { NewProtos.AbilityInvokeArgument.MetaUpdateBaseReactionDamage, typeof(NewProtos.AbilityMetaUpdateBaseReactionDamage) },
                { NewProtos.AbilityInvokeArgument.MetaTriggerElementReaction, typeof(NewProtos.AbilityMetaTriggerElementReaction) },
                { NewProtos.AbilityInvokeArgument.MetaLoseHp, typeof(NewProtos.AbilityMetaLoseHp) },
                { NewProtos.AbilityInvokeArgument.MetaDurabilityIsZero, typeof(NewProtos.AbilityMetaDurabilityIsZero) },

                // Action region, expected 14 protos, 16 records - 2 not found, OK
                { NewProtos.AbilityInvokeArgument.ActionTriggerAbility, typeof(NewProtos.AbilityActionTriggerAbility) },
                { NewProtos.AbilityInvokeArgument.ActionSetCrashDamage, typeof(NewProtos.AbilityActionSetCrashDamage) },
                // { NewProtos.AbilityInvokeArgument.ActionEffect, typeof(NewProtos.AbilityActionEffect) },
                { NewProtos.AbilityInvokeArgument.ActionSummon, typeof(NewProtos.AbilityActionSummon) },
                { NewProtos.AbilityInvokeArgument.ActionBlink, typeof(NewProtos.AbilityActionBlink) },
                { NewProtos.AbilityInvokeArgument.ActionCreateGadget, typeof(NewProtos.AbilityActionCreateGadget) },
                // { NewProtos.AbilityInvokeArgument.ActionApplyLevelModifier, typeof(NewProtos.AbilityActionApplyLevelModifier) },
                { NewProtos.AbilityInvokeArgument.ActionGenerateElemBall, typeof(NewProtos.AbilityActionGenerateElemBall) },
                { NewProtos.AbilityInvokeArgument.ActionSetRandomOverrideMapValue, typeof(NewProtos.AbilityActionSetRandomOverrideMapValue) },
                { NewProtos.AbilityInvokeArgument.ActionServerMonsterLog, typeof(NewProtos.AbilityActionServerMonsterLog) },
                { NewProtos.AbilityInvokeArgument.ActionCreateTile, typeof(NewProtos.AbilityActionCreateTile) },
                { NewProtos.AbilityInvokeArgument.ActionDestroyTile, typeof(NewProtos.AbilityActionDestroyTile) },
                { NewProtos.AbilityInvokeArgument.ActionFireAfterImage, typeof(NewProtos.AbilityActionFireAfterImage) },
                { NewProtos.AbilityInvokeArgument.ActionDeductStamina, typeof(NewProtos.AbilityActionDeductStamina) },
                { NewProtos.AbilityInvokeArgument.ActionHitEffect, typeof(NewProtos.AbilityActionHitEffect) },
                { NewProtos.AbilityInvokeArgument.ActionSetBulletTrackTarget, typeof(NewProtos.AbilityActionSetBulletTrackTarget) },

                // Mixin region, expected 22 protos, 23 records - 3 not found, missing
                { NewProtos.AbilityInvokeArgument.MixinAvatarSteerByCamera, typeof(NewProtos.AbilityMixinAvatarSteerByCamera) },
                // { NewProtos.AbilityInvokeArgument.MixinMonsterDefend, typeof(NewProtos.AbilityMixinMonsterDefend) },
                { NewProtos.AbilityInvokeArgument.MixinWindZone, typeof(NewProtos.AbilityMixinWindZone) },
                { NewProtos.AbilityInvokeArgument.MixinCostStamina, typeof(NewProtos.AbilityMixinCostStamina) },
                { NewProtos.AbilityInvokeArgument.MixinEliteShield, typeof(NewProtos.AbilityMixinEliteShield) },
                { NewProtos.AbilityInvokeArgument.MixinElementShield, typeof(NewProtos.AbilityMixinElementShield) },
                { NewProtos.AbilityInvokeArgument.MixinGlobalShield, typeof(NewProtos.AbilityMixinGlobalShield) },
                { NewProtos.AbilityInvokeArgument.MixinShieldBar, typeof(NewProtos.AbilityMixinShieldBar) },
                { NewProtos.AbilityInvokeArgument.MixinWindSeedSpawner, typeof(NewProtos.AbilityMixinWindSeedSpawner) },
                { NewProtos.AbilityInvokeArgument.MixinDoActionByElementReaction, typeof(NewProtos.AbilityMixinDoActionByElementReaction) },
                { NewProtos.AbilityInvokeArgument.MixinFieldEntityCountChange, typeof(NewProtos.AbilityMixinFieldEntityCountChange) },
                { NewProtos.AbilityInvokeArgument.MixinScenePropSync, typeof(NewProtos.AbilityMixinScenePropSync) },
                { NewProtos.AbilityInvokeArgument.MixinWidgetMpSupport, typeof(NewProtos.AbilityMixinWidgetMpSupport) },
                { NewProtos.AbilityInvokeArgument.MixinDoActionBySelfModifierElementDurabilityRatio, typeof(NewProtos.AbilityMixinDoActionBySelfModifierElementDurabilityRatio) },
                { NewProtos.AbilityInvokeArgument.MixinFireworksLauncher, typeof(NewProtos.AbilityMixinFireworksLauncher) },
                // { NewProtos.AbilityInvokeArgument.MixinAttackResultCreateCount, typeof(NewProtos.AbilityMixinAttackResultCreateCount) },
                { NewProtos.AbilityInvokeArgument.MixinUgcTimeControl, typeof(NewProtos.AbilityMixinUGCTimeControl) }, // Name don't equal
                { NewProtos.AbilityInvokeArgument.MixinAvatarCombat, typeof(NewProtos.AbilityMixinAvatarCombat) },
                // { NewProtos.AbilityInvokeArgument.MixinDeathZoneRegionalPlayMixin, typeof(NewProtos.AbilityMixinDeathZoneRegionalPlayMixin) },
                { NewProtos.AbilityInvokeArgument.MixinUiInteract, typeof(NewProtos.AbilityMixinUIInteract) }, // Name don't equal
                { NewProtos.AbilityInvokeArgument.MixinShootFromCamera, typeof(NewProtos.AbilityMixinShootFromCamera) },
                { NewProtos.AbilityInvokeArgument.MixinEraseBrickActivity, typeof(NewProtos.AbilityMixinEraseBrickActivity) },
                { NewProtos.AbilityInvokeArgument.MixinBreakout, typeof(NewProtos.AbilityMixinBreakout) }

            };
            #endregion
            newutils = new();
            oldutils = new();
            foreach (var pair in messages)
            {
                newutils.Add(pair.Key, new(pair.Value.Name));
                oldutils.Add(Enum.Parse<OldProtos.AbilityInvokeArgument>(pair.Key.ToString()), new(pair.Value.Name));
            }
        }

        public string Handle(string data, bool isNewCmdid)
        {
            var jobj = JObject.Parse(data);
            if (jobj == null) throw new ArgumentException("Invalid json data!", nameof(data));

            var abilityjson = (string?)jobj["abilityData"];
            if (abilityjson == null)
            {
                Log.Dbug($"Ability Data not found in: {data}", "AbilityInvokeEntryFix");
                return data;
            }

            if (isNewCmdid)
            {
                NewProtos.AbilityInvokeEntry invoke;
                try
                {
                    invoke = NewProtos.AbilityInvokeEntry.Parser.ParseJson(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvokeEntry so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"jsondata: {data}", "AbilityInvokeEntry(Client)");
                    return data;
                }
                if (newutils.ContainsKey(invoke.ArgumentType))
                {
                    try
                    {
                        var util = newutils[invoke.ArgumentType];
                        var newdata = invoke.AbilityData.ToByteArray();
                        var olddata = util.NewShiftToOld(newdata);
                        var oldabilitydata = Convert.ToBase64String(olddata);
#if DEBUG
                        var newjson = util.GetJson(newdata, true);
                        var oldjson = util.GetJson(olddata, false);
                        var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                        var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                        if (newlines.Length != oldlines.Length)
                        {
                            Log.Warn($"AbilityInvokeEntry({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                $"new: {newjson}\nold: {oldjson}", "AbilityInvokeEntry(Client)");
                        }
#endif
                        jobj["abilityData"] = oldabilitydata;
                        return jobj.ToString();
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                            $"{ex};\nInnerException:{ex.InnerException};\n" +
                            $"data: {abilityjson}", "AbilityInvokeEntryFix(Client)");
                        return data;
                    }
                }
                else
                {
                    if (invoke.AbilityData.Length > 0)
                    {
                        Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                           $"data: {abilityjson}", "AbilityInvokeEntryFix(Client)");
                    }
                    return data;
                }
            }
            else
            {
                OldProtos.AbilityInvokeEntry invoke;
                try
                {
                    invoke = OldProtos.AbilityInvokeEntry.Parser.ParseJson(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvokeEntry so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"jsondata: {data}", "AbilityInvokeEntry(Server)");
                    return data;
                }
                if (oldutils.ContainsKey(invoke.ArgumentType))
                {
                    try
                    {
                        var util = oldutils[invoke.ArgumentType];
                        var olddata = invoke.AbilityData.ToByteArray();
                        var newdata = util.OldShiftToNew(olddata);
                        var newabilitydata = Convert.ToBase64String(newdata);
#if DEBUG
                        var newjson = util.GetJson(newdata, true);
                        var oldjson = util.GetJson(olddata, false);
                        var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                        var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                        if (newlines.Length != oldlines.Length)
                        {
                            Log.Warn($"AbilityInvokeEntry({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                $"new: {newjson}\nold: {oldjson}", "AbilityInvokeEntry(Server)");
                        }
#endif
                        jobj["abilityData"] = newabilitydata;
                        return jobj.ToString();
                    }
                    catch (Exception ex)
                    {
                        Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                            $"{ex};\nInnerException:{ex.InnerException};\n" +
                            $"data: {abilityjson}", "AbilityInvokeEntryFix(Server)");
                        return data;
                    }
                }
                else
                {
                    if (invoke.AbilityData.Length > 0)
                    {
                        Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                           $"data: {abilityjson}", "AbilityInvokeEntryFix(Server)");
                    }
                    return data;
                }
            }
        }

        public OldProtos.AbilityInvokeEntry NewShiftToOld(NewProtos.AbilityInvokeEntry message)
        {
            return OldProtos.ProtoSerialize.Discard_Unknown_fields_Parser
                .Parse<OldProtos.AbilityInvokeEntry>(
                Handle(JsonFormatter.Default.Format(message), true));
        }

        public NewProtos.AbilityInvokeEntry OldShiftToNew(OldProtos.AbilityInvokeEntry message)
        {
            return NewProtos.ProtoSerialize.Discard_Unknown_fields_Parser
                .Parse<NewProtos.AbilityInvokeEntry>(
                Handle(JsonFormatter.Default.Format(message), false));
        }
    }
}
