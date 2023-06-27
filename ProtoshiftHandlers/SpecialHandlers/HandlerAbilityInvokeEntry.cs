using Google.Protobuf;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerAbilityInvokeEntry 
        : HandlerBase<NewProtos.AbilityInvokeEntry, OldProtos.AbilityInvokeEntry>
    {
        #region Base Type
        MessageParser<NewProtos.AbilityInvokeEntry> newproto_parser_base = NewProtos.AbilityInvokeEntry.Parser;
        MessageParser<OldProtos.AbilityInvokeEntry> oldproto_parser_base = OldProtos.AbilityInvokeEntry.Parser;
        #endregion
        #region Import Types
        HandlerAbilityInvokeArgument handler_AbilityInvokeArgument = HandlerAbilityInvokeArgument.GlobalInstance;
        HandlerAbilityInvokeEntryHead handler_AbilityInvokeEntryHead = HandlerAbilityInvokeEntryHead.GlobalInstance;
        HandlerForwardType handler_ForwardType = HandlerForwardType.GlobalInstance;
        #endregion
        #region Ability Data Import
        // Meta region, expected 15 protos, 22 records - 7 not found, OK
        HandlerAbilityMetaModifierChange handler_AbilityMetaModifierChange = HandlerAbilityMetaModifierChange.GlobalInstance;
        // HandlerAbilityMetaCommandModifierChangeRequest handler_AbilityMetaCommandModifierChangeRequest = // HandlerAbilityMetaCommandModifierChangeRequest.GlobalInstance; // not found
        HandlerAbilityMetaSpecialFloatArgument handler_AbilityMetaSpecialFloatArgument = HandlerAbilityMetaSpecialFloatArgument.GlobalInstance;
        HandlerAbilityScalarValueEntry handler_AbilityScalarValueEntry = HandlerAbilityScalarValueEntry.GlobalInstance; // Name don't equal
        HandlerAbilityString handler_AbilityString = HandlerAbilityString.GlobalInstance; // Name don't equal
        HandlerAbilityMetaReInitOverrideMap handler_AbilityMetaReInitOverrideMap = HandlerAbilityMetaReInitOverrideMap.GlobalInstance; // Name don't equal
        // HandlerAbilityScalarValueEntry handler_AbilityScalarValueEntry = // HandlerAbilityScalarValueEntry.GlobalInstance; // Name don't equal
        // HandlerAbilityString handler_AbilityString = // HandlerAbilityString.GlobalInstance; // Name don't equal
        // HandlerAbilityMetaAbilityElementStrength handler_AbilityMetaAbilityElementStrength = // HandlerAbilityMetaAbilityElementStrength.GlobalInstance; // not found
        HandlerAbilityMetaAddOrGetAbilityAndTrigger handler_AbilityMetaAddOrGetAbilityAndTrigger = HandlerAbilityMetaAddOrGetAbilityAndTrigger.GlobalInstance;
        HandlerAbilityMetaSetKilledState handler_AbilityMetaSetKilledState = HandlerAbilityMetaSetKilledState.GlobalInstance;
        HandlerAbilityMetaSetAbilityTrigger handler_AbilityMetaSetAbilityTrigger = HandlerAbilityMetaSetAbilityTrigger.GlobalInstance;
        HandlerAbilityMetaAddAbility handler_AbilityMetaAddAbility = HandlerAbilityMetaAddAbility.GlobalInstance; // Name don't equal
        // HandlerAbilityMetaRemoveAbility handler_AbilityMetaRemoveAbility = // HandlerAbilityMetaRemoveAbility.GlobalInstance; // not found
        HandlerAbilityMetaSetModifierApplyEntityId handler_AbilityMetaSetModifierApplyEntityId = HandlerAbilityMetaSetModifierApplyEntityId.GlobalInstance; // Name don't equal
        HandlerAbilityMetaModifierDurabilityChange handler_AbilityMetaModifierDurabilityChange = HandlerAbilityMetaModifierDurabilityChange.GlobalInstance;
        HandlerAbilityMetaElementReactionVisual handler_AbilityMetaElementReactionVisual = HandlerAbilityMetaElementReactionVisual.GlobalInstance;
        HandlerAbilityMetaSetPoseParameter handler_AbilityMetaSetPoseParameter = HandlerAbilityMetaSetPoseParameter.GlobalInstance;
        HandlerAbilityMetaUpdateBaseReactionDamage handler_AbilityMetaUpdateBaseReactionDamage = HandlerAbilityMetaUpdateBaseReactionDamage.GlobalInstance;
        HandlerAbilityMetaTriggerElementReaction handler_AbilityMetaTriggerElementReaction = HandlerAbilityMetaTriggerElementReaction.GlobalInstance;
        HandlerAbilityMetaLoseHp handler_AbilityMetaLoseHp = HandlerAbilityMetaLoseHp.GlobalInstance;
        HandlerAbilityMetaDurabilityIsZero handler_AbilityMetaDurabilityIsZero = HandlerAbilityMetaDurabilityIsZero.GlobalInstance;

        // Action region, expected 14 protos, 16 records - 2 not found, OK
        HandlerAbilityActionTriggerAbility handler_AbilityActionTriggerAbility = HandlerAbilityActionTriggerAbility.GlobalInstance;
        HandlerAbilityActionSetCrashDamage handler_AbilityActionSetCrashDamage = HandlerAbilityActionSetCrashDamage.GlobalInstance;
        // HandlerAbilityActionEffect handler_AbilityActionEffect = // HandlerAbilityActionEffect.GlobalInstance; // not found
        HandlerAbilityActionSummon handler_AbilityActionSummon = HandlerAbilityActionSummon.GlobalInstance;
        HandlerAbilityActionBlink handler_AbilityActionBlink = HandlerAbilityActionBlink.GlobalInstance;
        HandlerAbilityActionCreateGadget handler_AbilityActionCreateGadget = HandlerAbilityActionCreateGadget.GlobalInstance;
        // HandlerAbilityActionApplyLevelModifier handler_AbilityActionApplyLevelModifier = // HandlerAbilityActionApplyLevelModifier.GlobalInstance; // not found
        HandlerAbilityActionGenerateElemBall handler_AbilityActionGenerateElemBall = HandlerAbilityActionGenerateElemBall.GlobalInstance;
        HandlerAbilityActionSetRandomOverrideMapValue handler_AbilityActionSetRandomOverrideMapValue = HandlerAbilityActionSetRandomOverrideMapValue.GlobalInstance;
        HandlerAbilityActionServerMonsterLog handler_AbilityActionServerMonsterLog = HandlerAbilityActionServerMonsterLog.GlobalInstance;
        HandlerAbilityActionCreateTile handler_AbilityActionCreateTile = HandlerAbilityActionCreateTile.GlobalInstance;
        HandlerAbilityActionDestroyTile handler_AbilityActionDestroyTile = HandlerAbilityActionDestroyTile.GlobalInstance;
        HandlerAbilityActionFireAfterImage handler_AbilityActionFireAfterImage = HandlerAbilityActionFireAfterImage.GlobalInstance;
        HandlerAbilityActionDeductStamina handler_AbilityActionDeductStamina = HandlerAbilityActionDeductStamina.GlobalInstance;
        HandlerAbilityActionHitEffect handler_AbilityActionHitEffect = HandlerAbilityActionHitEffect.GlobalInstance;
        HandlerAbilityActionSetBulletTrackTarget handler_AbilityActionSetBulletTrackTarget = HandlerAbilityActionSetBulletTrackTarget.GlobalInstance;

        // Mixin region, expected 22 protos, 23 records - 3 not found, missing
        HandlerAbilityMixinAvatarSteerByCamera handler_AbilityMixinAvatarSteerByCamera = HandlerAbilityMixinAvatarSteerByCamera.GlobalInstance;
        // HandlerAbilityMixinMonsterDefend handler_AbilityMixinMonsterDefend = // HandlerAbilityMixinMonsterDefend.GlobalInstance; // not found
        HandlerAbilityMixinWindZone handler_AbilityMixinWindZone = HandlerAbilityMixinWindZone.GlobalInstance;
        HandlerAbilityMixinCostStamina handler_AbilityMixinCostStamina = HandlerAbilityMixinCostStamina.GlobalInstance;
        HandlerAbilityMixinEliteShield handler_AbilityMixinEliteShield = HandlerAbilityMixinEliteShield.GlobalInstance;
        HandlerAbilityMixinElementShield handler_AbilityMixinElementShield = HandlerAbilityMixinElementShield.GlobalInstance;
        HandlerAbilityMixinGlobalShield handler_AbilityMixinGlobalShield = HandlerAbilityMixinGlobalShield.GlobalInstance;
        HandlerAbilityMixinShieldBar handler_AbilityMixinShieldBar = HandlerAbilityMixinShieldBar.GlobalInstance;
        HandlerAbilityMixinWindSeedSpawner handler_AbilityMixinWindSeedSpawner = HandlerAbilityMixinWindSeedSpawner.GlobalInstance;
        HandlerAbilityMixinDoActionByElementReaction handler_AbilityMixinDoActionByElementReaction = HandlerAbilityMixinDoActionByElementReaction.GlobalInstance;
        HandlerAbilityMixinFieldEntityCountChange handler_AbilityMixinFieldEntityCountChange = HandlerAbilityMixinFieldEntityCountChange.GlobalInstance;
        HandlerAbilityMixinScenePropSync handler_AbilityMixinScenePropSync = HandlerAbilityMixinScenePropSync.GlobalInstance;
        HandlerAbilityMixinWidgetMpSupport handler_AbilityMixinWidgetMpSupport = HandlerAbilityMixinWidgetMpSupport.GlobalInstance;
        HandlerAbilityMixinDoActionBySelfModifierElementDurabilityRatio handler_AbilityMixinDoActionBySelfModifierElementDurabilityRatio = HandlerAbilityMixinDoActionBySelfModifierElementDurabilityRatio.GlobalInstance;
        HandlerAbilityMixinFireworksLauncher handler_AbilityMixinFireworksLauncher = HandlerAbilityMixinFireworksLauncher.GlobalInstance;
        // HandlerAbilityMixinAttackResultCreateCount handler_AbilityMixinAttackResultCreateCount = // HandlerAbilityMixinAttackResultCreateCount.GlobalInstance; // not found
        HandlerAbilityMixinUGCTimeControl handler_AbilityMixinUGCTimeControl = HandlerAbilityMixinUGCTimeControl.GlobalInstance; // Name don't equal
        HandlerAbilityMixinAvatarCombat handler_AbilityMixinAvatarCombat = HandlerAbilityMixinAvatarCombat.GlobalInstance;
        // HandlerAbilityMixinDeathZoneRegionalPlayMixin handler_AbilityMixinDeathZoneRegionalPlayMixin = // HandlerAbilityMixinDeathZoneRegionalPlayMixin.GlobalInstance; // not found
        HandlerAbilityMixinUIInteract handler_AbilityMixinUIInteract = HandlerAbilityMixinUIInteract.GlobalInstance; // Name don't equal
        HandlerAbilityMixinShootFromCamera handler_AbilityMixinShootFromCamera = HandlerAbilityMixinShootFromCamera.GlobalInstance;
        HandlerAbilityMixinEraseBrickActivity handler_AbilityMixinEraseBrickActivity = HandlerAbilityMixinEraseBrickActivity.GlobalInstance; // not found
        HandlerAbilityMixinBreakout handler_AbilityMixinBreakout = HandlerAbilityMixinBreakout.GlobalInstance; // not found
        #endregion

        #region Protocol Shift
        public override OldProtos.AbilityInvokeEntry NewShiftToOld(NewProtos.AbilityInvokeEntry? newprotocol)
        {
            OldProtos.AbilityInvokeEntry oldprotocol = new();
            if (newprotocol == null) return oldprotocol;
            // oldprotocol.AbilityData = newprotocol.AbilityData;
            oldprotocol.Head = handler_AbilityInvokeEntryHead.NewShiftToOld(newprotocol.Head);
            oldprotocol.EventId = newprotocol.EventId;
            oldprotocol.EntityId = newprotocol.EntityId;
            oldprotocol.TotalTickTime = newprotocol.TotalTickTime;
            oldprotocol.ForwardPeer = newprotocol.ForwardPeer;
            oldprotocol.ArgumentType = handler_AbilityInvokeArgument.NewShiftToOld(newprotocol.ArgumentType);
            oldprotocol.IsIgnoreAuth = newprotocol.IsIgnoreAuth;
            oldprotocol.ForwardType = handler_ForwardType.NewShiftToOld(newprotocol.ForwardType);
            switch (newprotocol.ArgumentType)
            {
                case NewProtos.AbilityInvokeArgument.None: break;
                case NewProtos.AbilityInvokeArgument.MetaModifierChange:
                    oldprotocol.AbilityData = handler_AbilityMetaModifierChange.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MetaCommandModifierChangeRequest:
                case NewProtos.AbilityInvokeArgument.MetaSpecialFloatArgument:
                    oldprotocol.AbilityData = handler_AbilityMetaSpecialFloatArgument.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaOverrideParam:
                    oldprotocol.AbilityData = handler_AbilityScalarValueEntry.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaClearOverrideParam:
                    oldprotocol.AbilityData = handler_AbilityString.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaReinitOverridemap:
                    // oldprotocol.AbilityData = handler_AbilityMetaReinitOverridemap.NewShiftToOld(newprotocol.AbilityData);
                    oldprotocol.AbilityData = handler_AbilityMetaReInitOverrideMap.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaGlobalFloatValue:
                    oldprotocol.AbilityData = handler_AbilityScalarValueEntry.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaClearGlobalFloatValue:
                    oldprotocol.AbilityData = handler_AbilityString.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MetaAbilityElementStrength:
                case NewProtos.AbilityInvokeArgument.MetaAddOrGetAbilityAndTrigger:
                    oldprotocol.AbilityData = handler_AbilityMetaAddOrGetAbilityAndTrigger.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaSetKilledState:
                    oldprotocol.AbilityData = handler_AbilityMetaSetKilledState.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaSetAbilityTrigger:
                    oldprotocol.AbilityData = handler_AbilityMetaSetAbilityTrigger.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaAddNewAbility:
                    oldprotocol.AbilityData = handler_AbilityMetaAddAbility.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MetaRemoveAbility:
                case NewProtos.AbilityInvokeArgument.MetaSetModifierApplyEntity:
                    oldprotocol.AbilityData = handler_AbilityMetaSetModifierApplyEntityId.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaModifierDurabilityChange:
                    oldprotocol.AbilityData = handler_AbilityMetaModifierDurabilityChange.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaElementReactionVisual:
                    oldprotocol.AbilityData = handler_AbilityMetaElementReactionVisual.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaSetPoseParameter:
                    oldprotocol.AbilityData = handler_AbilityMetaSetPoseParameter.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaUpdateBaseReactionDamage:
                    oldprotocol.AbilityData = handler_AbilityMetaUpdateBaseReactionDamage.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaTriggerElementReaction:
                    oldprotocol.AbilityData = handler_AbilityMetaTriggerElementReaction.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaLoseHp:
                    oldprotocol.AbilityData = handler_AbilityMetaLoseHp.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MetaDurabilityIsZero:
                    oldprotocol.AbilityData = handler_AbilityMetaDurabilityIsZero.NewShiftToOld(newprotocol.AbilityData);
                    break;

                case NewProtos.AbilityInvokeArgument.ActionTriggerAbility:
                    oldprotocol.AbilityData = handler_AbilityActionTriggerAbility.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionSetCrashDamage:
                    oldprotocol.AbilityData = handler_AbilityActionSetCrashDamage.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.ActionEffect:
                case NewProtos.AbilityInvokeArgument.ActionSummon:
                    oldprotocol.AbilityData = handler_AbilityActionSummon.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionBlink:
                    oldprotocol.AbilityData = handler_AbilityActionBlink.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionCreateGadget:
                    oldprotocol.AbilityData = handler_AbilityActionCreateGadget.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.ActionApplyLevelModifier:
                case NewProtos.AbilityInvokeArgument.ActionGenerateElemBall:
                    oldprotocol.AbilityData = handler_AbilityActionGenerateElemBall.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionSetRandomOverrideMapValue:
                    oldprotocol.AbilityData = handler_AbilityActionSetRandomOverrideMapValue.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionServerMonsterLog:
                    oldprotocol.AbilityData = handler_AbilityActionServerMonsterLog.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionCreateTile:
                    oldprotocol.AbilityData = handler_AbilityActionCreateTile.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionDestroyTile:
                    oldprotocol.AbilityData = handler_AbilityActionDestroyTile.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionFireAfterImage:
                    oldprotocol.AbilityData = handler_AbilityActionFireAfterImage.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionDeductStamina:
                    oldprotocol.AbilityData = handler_AbilityActionDeductStamina.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionHitEffect:
                    oldprotocol.AbilityData = handler_AbilityActionHitEffect.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.ActionSetBulletTrackTarget:
                    oldprotocol.AbilityData = handler_AbilityActionSetBulletTrackTarget.NewShiftToOld(newprotocol.AbilityData);
                    break;

                case NewProtos.AbilityInvokeArgument.MixinAvatarSteerByCamera:
                    oldprotocol.AbilityData = handler_AbilityMixinAvatarSteerByCamera.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MixinMonsterDefend:
                case NewProtos.AbilityInvokeArgument.MixinWindZone:
                    oldprotocol.AbilityData = handler_AbilityMixinWindZone.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinCostStamina:
                    oldprotocol.AbilityData = handler_AbilityMixinCostStamina.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinEliteShield:
                    oldprotocol.AbilityData = handler_AbilityMixinEliteShield.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinElementShield:
                    oldprotocol.AbilityData = handler_AbilityMixinElementShield.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinGlobalShield:
                    oldprotocol.AbilityData = handler_AbilityMixinGlobalShield.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinShieldBar:
                    oldprotocol.AbilityData = handler_AbilityMixinShieldBar.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinWindSeedSpawner:
                    oldprotocol.AbilityData = handler_AbilityMixinWindSeedSpawner.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinDoActionByElementReaction:
                    oldprotocol.AbilityData = handler_AbilityMixinDoActionByElementReaction.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinFieldEntityCountChange:
                    oldprotocol.AbilityData = handler_AbilityMixinFieldEntityCountChange.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinScenePropSync:
                    oldprotocol.AbilityData = handler_AbilityMixinScenePropSync.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinWidgetMpSupport:
                    oldprotocol.AbilityData = handler_AbilityMixinWidgetMpSupport.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinDoActionBySelfModifierElementDurabilityRatio:
                    oldprotocol.AbilityData = handler_AbilityMixinDoActionBySelfModifierElementDurabilityRatio.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinFireworksLauncher:
                    oldprotocol.AbilityData = handler_AbilityMixinFireworksLauncher.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MixinAttackResultCreateCount:
                case NewProtos.AbilityInvokeArgument.MixinUgcTimeControl:
                    // oldprotocol.AbilityData = handler_AbilityMixinUgcTimeControl.NewShiftToOld(newprotocol.AbilityData);
                    oldprotocol.AbilityData = handler_AbilityMixinUGCTimeControl.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinAvatarCombat:
                    oldprotocol.AbilityData = handler_AbilityMixinAvatarCombat.NewShiftToOld(newprotocol.AbilityData);
                    break;
                // case NewProtos.AbilityInvokeArgument.MixinDeathZoneRegionalPlayMixin:
                case NewProtos.AbilityInvokeArgument.MixinUiInteract:
                    // oldprotocol.AbilityData = handler_AbilityMixinUiInteract.NewShiftToOld(newprotocol.AbilityData);
                    oldprotocol.AbilityData = handler_AbilityMixinUIInteract.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinShootFromCamera:
                    oldprotocol.AbilityData = handler_AbilityMixinShootFromCamera.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinEraseBrickActivity:
                    oldprotocol.AbilityData = handler_AbilityMixinEraseBrickActivity.NewShiftToOld(newprotocol.AbilityData);
                    break;
                case NewProtos.AbilityInvokeArgument.MixinBreakout:
                    oldprotocol.AbilityData = handler_AbilityMixinBreakout.NewShiftToOld(newprotocol.AbilityData);
                    break;
                default:
                    if (!newprotocol.AbilityData.IsEmpty)
                        Log.Warn($"Not found map config for {newprotocol.ArgumentType} so not shifted, " +
                            $"bytes data not empty, new AbilityData: {newprotocol.AbilityData.ToBase64()}",
                            nameof(HandlerAbilityInvokeEntry));
                    break;
            }
            return oldprotocol;
        }

        public override NewProtos.AbilityInvokeEntry OldShiftToNew(OldProtos.AbilityInvokeEntry? oldprotocol)
        {
            NewProtos.AbilityInvokeEntry newprotocol = new();
            if (oldprotocol == null) return newprotocol;
            // newprotocol.AbilityData = oldprotocol.AbilityData;
            newprotocol.Head = handler_AbilityInvokeEntryHead.OldShiftToNew(oldprotocol.Head);
            newprotocol.EventId = oldprotocol.EventId;
            newprotocol.EntityId = oldprotocol.EntityId;
            newprotocol.TotalTickTime = oldprotocol.TotalTickTime;
            newprotocol.ForwardPeer = oldprotocol.ForwardPeer;
            newprotocol.ArgumentType = handler_AbilityInvokeArgument.OldShiftToNew(oldprotocol.ArgumentType);
            newprotocol.IsIgnoreAuth = oldprotocol.IsIgnoreAuth;
            newprotocol.ForwardType = handler_ForwardType.OldShiftToNew(oldprotocol.ForwardType);
            switch (oldprotocol.ArgumentType)
            {
                case OldProtos.AbilityInvokeArgument.None: break;
                case OldProtos.AbilityInvokeArgument.MetaModifierChange:
                    newprotocol.AbilityData = handler_AbilityMetaModifierChange.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MetaCommandModifierChangeRequest:
                case OldProtos.AbilityInvokeArgument.MetaSpecialFloatArgument:
                    newprotocol.AbilityData = handler_AbilityMetaSpecialFloatArgument.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaOverrideParam:
                    newprotocol.AbilityData = handler_AbilityScalarValueEntry.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaClearOverrideParam:
                    newprotocol.AbilityData = handler_AbilityString.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaReinitOverridemap:
                    // newprotocol.AbilityData = handler_AbilityMetaReinitOverridemap.OldShiftToNew(oldprotocol.AbilityData);
                    newprotocol.AbilityData = handler_AbilityMetaReInitOverrideMap.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaGlobalFloatValue:
                    newprotocol.AbilityData = handler_AbilityScalarValueEntry.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaClearGlobalFloatValue:
                    newprotocol.AbilityData = handler_AbilityString.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MetaAbilityElementStrength:
                case OldProtos.AbilityInvokeArgument.MetaAddOrGetAbilityAndTrigger:
                    newprotocol.AbilityData = handler_AbilityMetaAddOrGetAbilityAndTrigger.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaSetKilledState:
                    newprotocol.AbilityData = handler_AbilityMetaSetKilledState.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaSetAbilityTrigger:
                    newprotocol.AbilityData = handler_AbilityMetaSetAbilityTrigger.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaAddNewAbility:
                    newprotocol.AbilityData = handler_AbilityMetaAddAbility.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MetaRemoveAbility:
                case OldProtos.AbilityInvokeArgument.MetaSetModifierApplyEntity:
                    newprotocol.AbilityData = handler_AbilityMetaSetModifierApplyEntityId.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaModifierDurabilityChange:
                    newprotocol.AbilityData = handler_AbilityMetaModifierDurabilityChange.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaElementReactionVisual:
                    newprotocol.AbilityData = handler_AbilityMetaElementReactionVisual.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaSetPoseParameter:
                    newprotocol.AbilityData = handler_AbilityMetaSetPoseParameter.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaUpdateBaseReactionDamage:
                    newprotocol.AbilityData = handler_AbilityMetaUpdateBaseReactionDamage.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaTriggerElementReaction:
                    newprotocol.AbilityData = handler_AbilityMetaTriggerElementReaction.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaLoseHp:
                    newprotocol.AbilityData = handler_AbilityMetaLoseHp.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MetaDurabilityIsZero:
                    newprotocol.AbilityData = handler_AbilityMetaDurabilityIsZero.OldShiftToNew(oldprotocol.AbilityData);
                    break;

                case OldProtos.AbilityInvokeArgument.ActionTriggerAbility:
                    newprotocol.AbilityData = handler_AbilityActionTriggerAbility.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionSetCrashDamage:
                    newprotocol.AbilityData = handler_AbilityActionSetCrashDamage.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.ActionEffect:
                case OldProtos.AbilityInvokeArgument.ActionSummon:
                    newprotocol.AbilityData = handler_AbilityActionSummon.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionBlink:
                    newprotocol.AbilityData = handler_AbilityActionBlink.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionCreateGadget:
                    newprotocol.AbilityData = handler_AbilityActionCreateGadget.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.ActionApplyLevelModifier:
                case OldProtos.AbilityInvokeArgument.ActionGenerateElemBall:
                    newprotocol.AbilityData = handler_AbilityActionGenerateElemBall.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionSetRandomOverrideMapValue:
                    newprotocol.AbilityData = handler_AbilityActionSetRandomOverrideMapValue.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionServerMonsterLog:
                    newprotocol.AbilityData = handler_AbilityActionServerMonsterLog.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionCreateTile:
                    newprotocol.AbilityData = handler_AbilityActionCreateTile.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionDestroyTile:
                    newprotocol.AbilityData = handler_AbilityActionDestroyTile.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionFireAfterImage:
                    newprotocol.AbilityData = handler_AbilityActionFireAfterImage.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionDeductStamina:
                    newprotocol.AbilityData = handler_AbilityActionDeductStamina.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionHitEffect:
                    newprotocol.AbilityData = handler_AbilityActionHitEffect.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.ActionSetBulletTrackTarget:
                    newprotocol.AbilityData = handler_AbilityActionSetBulletTrackTarget.OldShiftToNew(oldprotocol.AbilityData);
                    break;

                case OldProtos.AbilityInvokeArgument.MixinAvatarSteerByCamera:
                    newprotocol.AbilityData = handler_AbilityMixinAvatarSteerByCamera.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MixinMonsterDefend:
                case OldProtos.AbilityInvokeArgument.MixinWindZone:
                    newprotocol.AbilityData = handler_AbilityMixinWindZone.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinCostStamina:
                    newprotocol.AbilityData = handler_AbilityMixinCostStamina.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinEliteShield:
                    newprotocol.AbilityData = handler_AbilityMixinEliteShield.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinElementShield:
                    newprotocol.AbilityData = handler_AbilityMixinElementShield.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinGlobalShield:
                    newprotocol.AbilityData = handler_AbilityMixinGlobalShield.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinShieldBar:
                    newprotocol.AbilityData = handler_AbilityMixinShieldBar.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinWindSeedSpawner:
                    newprotocol.AbilityData = handler_AbilityMixinWindSeedSpawner.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinDoActionByElementReaction:
                    newprotocol.AbilityData = handler_AbilityMixinDoActionByElementReaction.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinFieldEntityCountChange:
                    newprotocol.AbilityData = handler_AbilityMixinFieldEntityCountChange.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinScenePropSync:
                    newprotocol.AbilityData = handler_AbilityMixinScenePropSync.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinWidgetMpSupport:
                    newprotocol.AbilityData = handler_AbilityMixinWidgetMpSupport.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinDoActionBySelfModifierElementDurabilityRatio:
                    newprotocol.AbilityData = handler_AbilityMixinDoActionBySelfModifierElementDurabilityRatio.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinFireworksLauncher:
                    newprotocol.AbilityData = handler_AbilityMixinFireworksLauncher.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MixinAttackResultCreateCount:
                case OldProtos.AbilityInvokeArgument.MixinUgcTimeControl:
                    // newprotocol.AbilityData = handler_AbilityMixinUgcTimeControl.OldShiftToNew(oldprotocol.AbilityData);
                    newprotocol.AbilityData = handler_AbilityMixinUGCTimeControl.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinAvatarCombat:
                    newprotocol.AbilityData = handler_AbilityMixinAvatarCombat.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                // case OldProtos.AbilityInvokeArgument.MixinDeathZoneRegionalPlayMixin:
                case OldProtos.AbilityInvokeArgument.MixinUiInteract:
                    // newprotocol.AbilityData = handler_AbilityMixinUiInteract.OldShiftToNew(oldprotocol.AbilityData);
                    newprotocol.AbilityData = handler_AbilityMixinUIInteract.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinShootFromCamera:
                    newprotocol.AbilityData = handler_AbilityMixinShootFromCamera.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinEraseBrickActivity:
                    newprotocol.AbilityData = handler_AbilityMixinEraseBrickActivity.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                case OldProtos.AbilityInvokeArgument.MixinBreakout:
                    newprotocol.AbilityData = handler_AbilityMixinBreakout.OldShiftToNew(oldprotocol.AbilityData);
                    break;
                default:
                    if (!oldprotocol.AbilityData.IsEmpty)
                        Log.Warn($"Not found map config for {oldprotocol.ArgumentType} so not shifted, " +
                            $"bytes data not empty, old AbilityData: {oldprotocol.AbilityData.ToBase64()}",
                            nameof(HandlerAbilityInvokeEntry));
                    break;
            }
            return newprotocol;
        }
        #endregion

        public override byte[] NewShiftToOld(byte[] arr, int offset, int length)
            => NewShiftToOld(newproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] NewShiftToOld(ReadOnlySpan<byte> span)
            => NewShiftToOld(newproto_parser_base.ParseFrom(span)).ToByteArray();
        public override ByteString NewShiftToOld(ByteString bytes)
            => NewShiftToOld(newproto_parser_base.ParseFrom(bytes).ToByteString());
        public override byte[] OldShiftToNew(byte[] arr, int offset, int length)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(arr, offset, length)).ToByteArray();
        public override byte[] OldShiftToNew(ReadOnlySpan<byte> span)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(span)).ToByteArray();
        public override ByteString OldShiftToNew(ByteString bytes)
            => OldShiftToNew(oldproto_parser_base.ParseFrom(bytes).ToByteString());

        private static HandlerAbilityInvokeEntry _globalOnlyInstance = new HandlerAbilityInvokeEntry();
        public static HandlerAbilityInvokeEntry GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
