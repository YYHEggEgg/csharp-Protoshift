using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    internal class AbilityInvocationsNotifyFix : ISpecialBytesSkillIssueFixer<NewProtos.AbilityInvokeArgument, OldProtos.AbilityInvokeArgument>
    {
        public string Protoname => "AbilityInvocationsNotify";

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        /// <summary>
        /// Only used for new proto -> old proto now.
        /// </summary>
        public OldProtos.ProtoSerialize Mainutil_old => throw new NotImplementedException();
        
        private readonly Dictionary<NewProtos.AbilityInvokeArgument, Type> messages;

        public string ApplyToVersion => "3.3.0";

        public Dictionary<NewProtos.AbilityInvokeArgument, ProtoShiftUtils> newutils { get; }

        public Dictionary<OldProtos.AbilityInvokeArgument, ProtoShiftUtils> oldutils { get; }

        public AbilityInvocationsNotifyFix()
        {
            NewProtos.QueryCmdId.TryGetSerializer("AbilityInvocationsNotify", out var newserializer);
            Mainutil_new = newserializer;
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

        public byte[] Handle(byte[] data, bool isNewCmdid)
        {
            if (isNewCmdid)
            {
                NewProtos.AbilityInvocationsNotify notify;
                try
                {
                    notify = NewProtos.AbilityInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Client)");
                    return data;
                }
                foreach (var invoke in notify.Invokes)
                {
                    if (newutils.ContainsKey(invoke.ArgumentType))
                    {
                        try
                        {
                            var util = newutils[invoke.ArgumentType];
                            var newdata = invoke.AbilityData.ToByteArray();
                            var olddata = util.NewShiftToOld(newdata);
                            invoke.AbilityData = ByteString.FromBase64(Convert.ToBase64String(olddata));
#if DEBUG
                            var newjson = util.GetJson(newdata, true);
                            var oldjson = util.GetJson(olddata, false);
                            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                            if (newlines.Length != oldlines.Length)
                            {
                                Log.Warn($"AbilityInvocationNotify({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                    $"new: {newjson}\nold: {oldjson}", "AbilityInvocationNotifyFix(Client)");
                            }
#endif
                        }
                        catch (Exception ex)
                        {
                            Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                                $"{ex};\nInnerException:{ex.InnerException};\n" +
                                $"data: {Mainutil_new.DeserializeToJson(data)}", "AbilityInvocationsNotifyFix(Client)");
                            continue;
                        }
                    }
                    else
                    {
                        if (invoke.AbilityData.Length > 0)
                        {
                            Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                                    $"data: {Mainutil_new.DeserializeToJson(data)}", "AbilityInvocationsNotifyFix(Client)");
                            continue;
                        }
                    }
                }

                return notify.ToByteArray();
            }
            else
            {
                OldProtos.AbilityInvocationsNotify notify;
                try
                {
                    notify = OldProtos.AbilityInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.AbilityInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "AbilityInvocationsNotifyFix(Server)");
                    return data;
                }
                foreach (var invoke in notify.Invokes)
                {
                    if (oldutils.ContainsKey(invoke.ArgumentType))
                    {
                        try
                        {
                            var util = oldutils[invoke.ArgumentType];
                            var olddata = invoke.AbilityData.ToByteArray();
                            var newdata = util.OldShiftToNew(olddata);
                            invoke.AbilityData = ByteString.FromBase64(Convert.ToBase64String(newdata));
#if DEBUG
                            var newjson = util.GetJson(newdata, true);
                            var oldjson = util.GetJson(olddata, false);
                            var newlines = HandlerSession.ConvertJsonString(newjson).Split('\n');
                            var oldlines = HandlerSession.ConvertJsonString(oldjson).Split('\n');

                            if (newlines.Length != oldlines.Length)
                            {
                                Log.Warn($"AbilityInvocationNotify({invoke.ArgumentType}) has an information lost in Special Fix Protoshift:\n" +
                                    $"new: {newjson}\nold: {oldjson}", "AbilityInvocationNotifyFix(Server)");
                            }
#endif
                        }
                        catch (Exception ex)
                        {
                            Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                                $"{ex};\nInnerException:{ex.InnerException};\n" +
                                $"data: {Mainutil_old.DeserializeToJson(data)}", "AbilityInvocationsNotifyFix(Server)");
                            continue;
                        }
                    }
                    else
                    {
                        if (invoke.AbilityData.Length > 0)
                        {
                            Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                                    $"data: {Mainutil_old.DeserializeToJson(data)}", "AbilityInvocationsNotifyFix(Server)");
                            continue;
                        }
                    }
                }

                return notify.ToByteArray();
            }
        }
    }
}
