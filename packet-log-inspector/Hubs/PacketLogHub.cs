using Microsoft.AspNetCore.SignalR;

namespace PacketLogInspector.Hubs;

/// <summary>
/// SignalR hub used for server-to-client push notifications.
/// Client event: NewRecordsAdded(int count)
/// </summary>
public class PacketLogHub : Hub
{
    // No client-to-server methods needed.
    // The server broadcasts "NewRecordsAdded" via IHubContext<PacketLogHub>.
}
