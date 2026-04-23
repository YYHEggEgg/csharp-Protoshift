using PacketLogInspector.Hubs;
using PacketLogInspector.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.Secrets.json", optional: true, reloadOnChange: true);

// Listen on fixed port 18880 (> 10000, avoids common service conflicts)
var customUrls = builder.Configuration.GetValue<string>("HostUrls");
builder.WebHost.UseUrls(customUrls ?? "http://localhost:18880");

builder.Services.AddControllers();
builder.Services.AddSignalR();

// Core singleton services
builder.Services.AddSingleton<ProtoDeserializerService>();
builder.Services.AddSingleton<PacketLogService>();
builder.Services.AddSingleton<JsonDiffService>();

// File watcher as a hosted background service
builder.Services.AddHostedService<FileWatcherService>();

// CORS for any origin
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
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

// Auto-load default log file: check candidate paths in order
var logService = app.Services.GetRequiredService<PacketLogService>();
var defaultLogCandidates = new[]
{
    Path.GetFullPath(Path.Combine(app.Environment.ContentRootPath, "../csharp-Protoshift/Logs/latest.packet.log")),
    Path.GetFullPath(Path.Combine(app.Environment.ContentRootPath, "../bin/logs/latest.packet.log")),
};
foreach (var candidate in defaultLogCandidates)
{
    if (File.Exists(candidate))
    {
        app.Logger.LogInformation("Auto-loading default log file: {Path}", candidate);
        await logService.LoadFileAsync(candidate);
        break;
    }
}

await app.RunAsync();
