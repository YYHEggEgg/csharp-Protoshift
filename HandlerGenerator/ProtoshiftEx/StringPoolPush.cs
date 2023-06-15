namespace csharp_Protoshift.Enhanced.Handlers.Generator
{
    public partial class ProtocStringPoolManager
    {
        public void PushMessageResult(MessageResult message)
        {
            foreach (var commonField in message.commonFields) PushCommonResult(commonField);
            foreach (var mapField in message.mapFields) PushMapResult(mapField);
            foreach (var oneofField in message.oneofFields) PushOneofResult(oneofField);
            foreach (var messageBody in message.messageFields) PushMessageResult(messageBody);
        }

        public void PushCommonResult(CommonResult commonResult)
            => PushFieldName(commonResult.fieldName);

        public void PushMapResult(MapResult mapResult)
            => PushFieldName(mapResult.fieldName);

        public void PushOneofResult(OneofResult oneofResult)
        {
            PushFieldName(oneofResult.oneofEntryName);
            foreach (var commonField in oneofResult.oneofInnerFields) PushCommonResult(commonField);
        }
    }
}