using Microsoft.AspNetCore.SignalR;
using PacketLogInspector.Hubs;

namespace PacketLogInspector.Services;

/// <summary>
/// Background service that watches the loaded log file for changes
/// and triggers incremental loads, broadcasting updates via SignalR.
/// Also subscribes to file-path change events so the watcher follows file switches.
/// </summary>
public class FileWatcherService : IHostedService, IDisposable
{
    private readonly PacketLogService _logService;
    private readonly IHubContext<PacketLogHub> _hubContext;
    private readonly ILogger<FileWatcherService> _logger;
    private FileSystemWatcher? _watcher;
    private System.Threading.Timer? _debounceTimer;
    private readonly object _debounceLock = new();

    public FileWatcherService(
        PacketLogService logService,
        IHubContext<PacketLogHub> hubContext,
        ILogger<FileWatcherService> logger)
    {
        _logService = logService;
        _hubContext = hubContext;
        _logger = logger;

        // Subscribe to events from PacketLogService
        _logService.OnNewRecords += OnNewRecordsLoaded;
        _logService.OnFilePathChanged += SetupWatcher;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        // Watch the file that was loaded before service started (e.g. default auto-load)
        if (_logService.FilePath != null)
            SetupWatcher(_logService.FilePath);
        return Task.CompletedTask;
    }

    public void SetupWatcher(string? filePath)
    {
        _watcher?.Dispose();
        _watcher = null;

        if (filePath == null || !File.Exists(filePath)) return;

        var dir = Path.GetDirectoryName(filePath)!;
        var fileName = Path.GetFileName(filePath);

        _watcher = new FileSystemWatcher(dir, fileName)
        {
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size,
            EnableRaisingEvents = true
        };
        _watcher.Changed += OnFileChanged;
        _logger.LogInformation("Watching file: {Path}", filePath);
    }

    private void OnFileChanged(object sender, FileSystemEventArgs e)
    {
        // Debounce: coalesce rapid change notifications into a single load after 300ms
        lock (_debounceLock)
        {
            _debounceTimer?.Dispose();
            _debounceTimer = new System.Threading.Timer(async _ =>
            {
                await _logService.LoadIncrementalAsync();
            }, null, 300, Timeout.Infinite);
        }
    }

    private void OnNewRecordsLoaded(int count)
    {
        _ = _hubContext.Clients.All.SendAsync("NewRecordsAdded", count);
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _watcher?.Dispose();
        _debounceTimer?.Dispose();
        return Task.CompletedTask;
    }

    public void Dispose()
    {
        _watcher?.Dispose();
        _debounceTimer?.Dispose();
    }
}
