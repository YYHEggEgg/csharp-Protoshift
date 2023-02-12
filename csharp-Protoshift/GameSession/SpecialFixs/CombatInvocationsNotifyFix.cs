using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_Protoshift.GameSession.SpecialFixs
{
    internal class CombatInvocationsNotifyFix : ISpecialBytesSkillIssueFixer<NewProtos.CombatTypeArgument, OldProtos.CombatTypeArgument>
    {
        private readonly Dictionary<NewProtos.CombatTypeArgument, Type> messages;

        public string Protoname => "CombatInvocationsNotify";

        public NewProtos.ProtoSerialize Mainutil_new { get; }

        public OldProtos.ProtoSerialize Mainutil_old { get; }

        public string ApplyToVersion => "3.3.0";

        public Dictionary<NewProtos.CombatTypeArgument, ProtoShiftUtils> newutils { get; }

        public Dictionary<OldProtos.CombatTypeArgument, ProtoShiftUtils> oldutils { get; }

        public CombatInvocationsNotifyFix()
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

        public byte[] Handle(byte[] data, bool isNewCmdid)
        {
            if (isNewCmdid)
            {
                NewProtos.CombatInvocationsNotify notify;
                try
                {
                    notify = NewProtos.CombatInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing NewProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix");
                    return data;
                }
                foreach (var invoke in notify.InvokeList)
                {
                    if (newutils.ContainsKey(invoke.ArgumentType))
                    {
                        try
                        {
                            var newdata = invoke.CombatData.ToByteArray();
                            var olddata = newutils[invoke.ArgumentType].NewShiftToOld(newdata);
                            invoke.CombatData = ByteString.FromBase64(Convert.ToBase64String(olddata));
                        }
                        catch (Exception ex)
                        {
                            Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                                $"{ex};\nInnerException:{ex.InnerException};\n" +
                                $"data: {Mainutil_new.DeserializeToJson(data)}", "CombatInvocationsNotifyFix");
                            continue;
                        }
                    }
                    else
                    {
                        if (invoke.CombatData.Length > 0)
                        {
                            Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                                    $"data: {Mainutil_new.DeserializeToJson(data)}", "CombatInvocationsNotifyFix");
                            continue;
                        }
                    }
                }

                return notify.ToByteArray();
            }
            else
            {
                OldProtos.CombatInvocationsNotify notify;
                try
                {
                    notify = OldProtos.CombatInvocationsNotify.Parser.ParseFrom(data);
                }
                catch (Exception ex)
                {
                    Log.Erro("Error occurred when serializing OldProtos.CombatInvocationsNotify so not shifted: " +
                        $"{ex};\nInnerException:{ex.InnerException};\n" +
                        $"data: {Convert.ToHexString(data)}", "CombatInvocationsNotifyFix");
                    return data;
                }
                foreach (var invoke in notify.InvokeList)
                {
                    if (oldutils.ContainsKey(invoke.ArgumentType))
                    {
                        try
                        {
                            var olddata = invoke.CombatData.ToByteArray();
                            var newdata = oldutils[invoke.ArgumentType].OldShiftToNew(olddata);
                            invoke.CombatData = ByteString.FromBase64(Convert.ToBase64String(newdata));
                        }
                        catch (Exception ex)
                        {
                            Log.Erro($"Error occurred when serializing bytes data of {invoke.ArgumentType} so not shifted (probably wrong prototype): " +
                                $"{ex};\nInnerException:{ex.InnerException};\n" +
                                $"data: {Mainutil_old.DeserializeToJson(data)}", "CombatInvocationsNotifyFix");
                            continue;
                        }
                    }
                    else
                    {
                        if (invoke.CombatData.Length > 0)
                        {
                            Log.Erro($"Not found map config for {invoke.ArgumentType} so not shifted, bytes data not empty: " +
                                    $"data: {Mainutil_old.DeserializeToJson(data)}", "CombatInvocationsNotifyFix");
                            continue;
                        }
                    }
                }

                return notify.ToByteArray();
            }
        }
    }
}
