namespace csharp_Protoshift.KcpProxy
{
    public Func<byte[], uint, byte[]?>? OnServerPacketArrival;
    public Func<byte[], uint, byte[]?>? OnClientPacketArrival;
    public Func<byte[], uint, bool>? IsUrgentServerPacket;
    public Func<byte[], uint, bool>? IsUrgentClientPacket;
}