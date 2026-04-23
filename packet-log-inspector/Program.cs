using PacketLogInspector.Hubs;
using PacketLogInspector.Services;

var builder = WebApplication.CreateBuilder(args);

// Listen on fixed port 18880 (> 10000, avoids common service conflicts)
builder.WebHost.UseUrls("http://localhost:18880");

builder.Services.AddControllers();
builder.Services.AddSignalR();

// Core singleton services
builder.Services.AddSingleton<ProtoDeserializerService>();
builder.Services.AddSingleton<PacketLogService>();
builder.Services.AddSingleton<JsonDiffService>();

// File watcher as a hosted background service
builder.Services.AddHostedService<FileWatcherService>();

// CORS for Vite dev server (development only)
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5173")
              .AllowAnyMethod()
              .AllowAnyHeader()
              .AllowCredentials(); // Required for SignalR WebSocket
    });
});

var app = builder.Build();

// Eagerly instantiate ProtoDeserializerService so proto serializers are ready
// before the first request arrives (warm-up can take several seconds).
_ = app.Services.GetRequiredService<ProtoDeserializerService>();

app.UseCors();
app.UseStaticFiles(); // serves wwwroot/

app.MapControllers();
app.MapHub<PacketLogHub>("/packetHub");

// SPA fallback: serve index.html for all unmatched routes so Vue Router works
app.MapFallbackToFile("index.html");

// Auto-load default log file if present at ../csharp-Protoshift/Logs/latest.packet.log
var logService = app.Services.GetRequiredService<PacketLogService>();
var defaultLogPath = Path.GetFullPath(
    Path.Combine(app.Environment.ContentRootPath, "../csharp-Protoshift/Logs/latest.packet.log"));

if (File.Exists(defaultLogPath))
{
    app.Logger.LogInformation("Auto-loading default log file: {Path}", defaultLogPath);
    await logService.LoadFileAsync(defaultLogPath);
}

await app.RunAsync();
