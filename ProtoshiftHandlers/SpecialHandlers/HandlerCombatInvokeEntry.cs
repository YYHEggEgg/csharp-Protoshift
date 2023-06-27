
using Google.Protobuf;
using YYHEggEgg.Logger;

namespace csharp_Protoshift.Enhanced.Handlers.GeneratedCode
{
    public class HandlerCombatInvokeEntry 
        : HandlerBase<NewProtos.CombatInvokeEntry, OldProtos.CombatInvokeEntry>
    {
        #region Base Type
        MessageParser<NewProtos.CombatInvokeEntry> newproto_parser_base = NewProtos.CombatInvokeEntry.Parser;
        MessageParser<OldProtos.CombatInvokeEntry> oldproto_parser_base = OldProtos.CombatInvokeEntry.Parser;
        #endregion
        #region Import Types
        HandlerCombatTypeArgument handler_CombatTypeArgument = HandlerCombatTypeArgument.GlobalInstance;
        HandlerForwardType handler_ForwardType = HandlerForwardType.GlobalInstance;
        #endregion
        #region Combat Data Import
        HandlerEvtBeingHitInfo handler_EvtBeingHitInfo = HandlerEvtBeingHitInfo.GlobalInstance;
        HandlerEvtAnimatorStateChangedInfo handler_EvtAnimatorStateChangedInfo = HandlerEvtAnimatorStateChangedInfo.GlobalInstance;
        HandlerEvtFaceToDirInfo handler_EvtFaceToDirInfo = HandlerEvtFaceToDirInfo.GlobalInstance;
        HandlerEvtSetAttackTargetInfo handler_EvtSetAttackTargetInfo = HandlerEvtSetAttackTargetInfo.GlobalInstance;
        HandlerEvtRushMoveInfo handler_EvtRushMoveInfo = HandlerEvtRushMoveInfo.GlobalInstance;
        HandlerEvtAnimatorParameterInfo handler_EvtAnimatorParameterInfo = HandlerEvtAnimatorParameterInfo.GlobalInstance; // Name don't equal
        HandlerEntityMoveInfo handler_EntityMoveInfo = HandlerEntityMoveInfo.GlobalInstance; // Name don't equal
        HandlerEvtSyncEntityPositionInfo handler_EvtSyncEntityPositionInfo = HandlerEvtSyncEntityPositionInfo.GlobalInstance;
        HandlerEvtCombatSteerMotionInfo handler_EvtCombatSteerMotionInfo = HandlerEvtCombatSteerMotionInfo.GlobalInstance; // Name don't equal
        HandlerEvtCombatForceSetPosInfo handler_EvtCombatForceSetPosInfo = HandlerEvtCombatForceSetPosInfo.GlobalInstance; // Name don't equal
        HandlerEvtCompensatePosDiffInfo handler_EvtCompensatePosDiffInfo = HandlerEvtCompensatePosDiffInfo.GlobalInstance;
        HandlerEvtMonsterDoBlink handler_EvtMonsterDoBlink = HandlerEvtMonsterDoBlink.GlobalInstance; // Name don't equal
        HandlerEvtFixedRushMove handler_EvtFixedRushMove = HandlerEvtFixedRushMove.GlobalInstance; // Name don't equal
        HandlerEvtSyncTransform handler_EvtSyncTransform = HandlerEvtSyncTransform.GlobalInstance; // Name don't equal
        HandlerEvtLightCoreMove handler_EvtLightCoreMove = HandlerEvtLightCoreMove.GlobalInstance; // Name don't equal
        HandlerEvtBeingHealedNotify handler_EvtBeingHealedNotify = HandlerEvtBeingHealedNotify.GlobalInstance; // Name don't equal
        HandlerEvtSyncSkillAnchorPosition handler_EvtSyncSkillAnchorPosition = HandlerEvtSyncSkillAnchorPosition.GlobalInstance; // Name don't equal
        HandlerEvtGrapplingHookMove handler_EvtGrapplingHookMove = HandlerEvtGrapplingHookMove.GlobalInstance; // Name don't equal
        #endregion

        #region Protocol Shift
        public override OldProtos.CombatInvokeEntry NewShiftToOld(NewProtos.CombatInvokeEntry? newprotocol)
        {
            OldProtos.CombatInvokeEntry oldprotocol = new();
            if (newprotocol == null) return oldprotocol;
            // oldprotocol.CombatData = newprotocol.CombatData;
            oldprotocol.ForwardType = handler_ForwardType.NewShiftToOld(newprotocol.ForwardType);
            oldprotocol.ArgumentType = handler_CombatTypeArgument.NewShiftToOld(newprotocol.ArgumentType);
            switch (newprotocol.ArgumentType)
            {
                case NewProtos.CombatTypeArgument.EvtBeingHit:
                    oldprotocol.CombatData = handler_EvtBeingHitInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.AnimatorStateChanged:
                    oldprotocol.CombatData = handler_EvtAnimatorStateChangedInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.FaceToDir:
                    oldprotocol.CombatData = handler_EvtFaceToDirInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.SetAttackTarget:
                    oldprotocol.CombatData = handler_EvtSetAttackTargetInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.RushMove:
                    oldprotocol.CombatData = handler_EvtRushMoveInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.AnimatorParameterChanged:
                    // oldprotocol.CombatData = handler_EvtAnimatorParameterChangedInfo.NewShiftToOld(newprotocol.CombatData);
                    oldprotocol.CombatData = handler_EvtAnimatorParameterInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.EntityMove:
                    oldprotocol.CombatData = handler_EntityMoveInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.SyncEntityPosition:
                    oldprotocol.CombatData = handler_EvtSyncEntityPositionInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.SteerMotionInfo:
                    oldprotocol.CombatData = handler_EvtCombatSteerMotionInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.ForceSetPosInfo:
                    oldprotocol.CombatData = handler_EvtCombatForceSetPosInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.CompensatePosDiff:
                    oldprotocol.CombatData = handler_EvtCompensatePosDiffInfo.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.MonsterDoBlink:
                    oldprotocol.CombatData = handler_EvtMonsterDoBlink.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.FixedRushMove:
                    oldprotocol.CombatData = handler_EvtFixedRushMove.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.SyncTransform:
                    oldprotocol.CombatData = handler_EvtSyncTransform.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.LightCoreMove:
                    oldprotocol.CombatData = handler_EvtLightCoreMove.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.BeingHealedNtf:
                    oldprotocol.CombatData = handler_EvtBeingHealedNotify.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.SkillAnchorPositionNtf:
                    // oldprotocol.CombatData = handler_EvtSkillAnchorPosition.NewShiftToOld(newprotocol.CombatData);
                    oldprotocol.CombatData = handler_EvtSyncSkillAnchorPosition.NewShiftToOld(newprotocol.CombatData);
                    break;
                case NewProtos.CombatTypeArgument.GrapplingHookMove:
                    oldprotocol.CombatData = handler_EvtGrapplingHookMove.NewShiftToOld(newprotocol.CombatData);
                    break;
                default:
                    if (!newprotocol.CombatData.IsEmpty)
                        Log.Warn($"Not found map config for {newprotocol.ArgumentType} so not shifted, " +
                            $"bytes data not empty, new CombatData: {newprotocol.CombatData.ToBase64()}",
                            nameof(HandlerCombatInvokeEntry));
                    break;
            }
            return oldprotocol;
        }

        public override NewProtos.CombatInvokeEntry OldShiftToNew(OldProtos.CombatInvokeEntry? oldprotocol)
        {
            NewProtos.CombatInvokeEntry newprotocol = new();
            if (oldprotocol == null) return newprotocol;
            // newprotocol.CombatData = oldprotocol.CombatData;
            newprotocol.ForwardType = handler_ForwardType.OldShiftToNew(oldprotocol.ForwardType);
            newprotocol.ArgumentType = handler_CombatTypeArgument.OldShiftToNew(oldprotocol.ArgumentType);
            
            switch (oldprotocol.ArgumentType)
            {
                case OldProtos.CombatTypeArgument.EvtBeingHit:
                    newprotocol.CombatData = handler_EvtBeingHitInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.AnimatorStateChanged:
                    newprotocol.CombatData = handler_EvtAnimatorStateChangedInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.FaceToDir:
                    newprotocol.CombatData = handler_EvtFaceToDirInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.SetAttackTarget:
                    newprotocol.CombatData = handler_EvtSetAttackTargetInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.RushMove:
                    newprotocol.CombatData = handler_EvtRushMoveInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.AnimatorParameterChanged:
                    // newprotocol.CombatData = handler_EvtAnimatorParameterChangedInfo.OldShiftToNew(oldprotocol.CombatData);
                    newprotocol.CombatData = handler_EvtAnimatorParameterInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.EntityMove:
                    newprotocol.CombatData = handler_EntityMoveInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.SyncEntityPosition:
                    newprotocol.CombatData = handler_EvtSyncEntityPositionInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.SteerMotionInfo:
                    newprotocol.CombatData = handler_EvtCombatSteerMotionInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.ForceSetPosInfo:
                    newprotocol.CombatData = handler_EvtCombatForceSetPosInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.CompensatePosDiff:
                    newprotocol.CombatData = handler_EvtCompensatePosDiffInfo.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.MonsterDoBlink:
                    newprotocol.CombatData = handler_EvtMonsterDoBlink.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.FixedRushMove:
                    newprotocol.CombatData = handler_EvtFixedRushMove.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.SyncTransform:
                    newprotocol.CombatData = handler_EvtSyncTransform.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.LightCoreMove:
                    newprotocol.CombatData = handler_EvtLightCoreMove.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.BeingHealedNtf:
                    newprotocol.CombatData = handler_EvtBeingHealedNotify.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.SkillAnchorPositionNtf:
                    // newprotocol.CombatData = handler_EvtSkillAnchorPosition.OldShiftToNew(oldprotocol.CombatData);
                    newprotocol.CombatData = handler_EvtSyncSkillAnchorPosition.OldShiftToNew(oldprotocol.CombatData);
                    break;
                case OldProtos.CombatTypeArgument.GrapplingHookMove:
                    newprotocol.CombatData = handler_EvtGrapplingHookMove.OldShiftToNew(oldprotocol.CombatData);
                    break;
                default:
                    if (!oldprotocol.CombatData.IsEmpty)
                        Log.Warn($"Not found map config for {oldprotocol.ArgumentType} so not shifted, " +
                            $"bytes data not empty, old CombatData: {oldprotocol.CombatData.ToBase64()}",
                            nameof(HandlerCombatInvokeEntry));
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

        private static HandlerCombatInvokeEntry _globalOnlyInstance = new HandlerCombatInvokeEntry();
        public static HandlerCombatInvokeEntry GlobalInstance => _globalOnlyInstance;

        #region Inner Messages
        #endregion

        #region Inner Enums
        #endregion
    }
}
