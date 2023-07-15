NewProtos.AbilityScalarValueEntry newprotocol = new();
newprotocol.Key = oldprotocol.Key;
newprotocol.ValueType = oldprotocol.ValueType;
newprotocol.ValueOneofCase = oldprotocol.ValueOneofCase;
switch (newprotocol.ValueCase)
{
    case NewProtos.ValueOneofCase.FloatValue:
        newprotocol.FloatValue = oldprotocol.FloatValue;
    case ...;
}
return newprotocol;

NewProtos.QueryRegionListHttpRsp newprotocol = new();
newprotocol.Retcode = oldprotocol.Retcode;
foreach (RegionSimpleInfo each_oldprotocol in oldprotocol.RegionList)
{
    newprotocol.RegionList.Add(HandlerRegionSimpleInfo.NewShiftToOld(each_oldprotocol));
}
...
return newprotocol;

NewProtos.EntityRenderChangedInfo newprotocol = new();
foreach (KeyValuePair<string, UInt32> eachmap_oldprotocol in oldprotocol.ChangedRenderers)
{
    newprotocol.ChangedRenderers.Add(eachmap_oldprotocol.Key, eachmap_oldprotocol.Value);
}

interface IProtoshiftHandler
{
    IMessage<TNew> NewShiftToOld(IMessage<TOld> oldprotocol);
    IMessage<TOld> OldShiftToNew(IMessage<TNew> newprotocol);
}