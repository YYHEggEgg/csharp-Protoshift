using PacketLogInspector.Models;
using System.Text;

namespace PacketLogInspector.Services;

/// <summary>
/// Singleton service that holds all loaded PacketRecord objects in memory,
/// tracks file position for incremental reads, and exposes filtered queries.
/// Thread-safe via ReaderWriterLockSlim.
/// </summary>
public class PacketLogService
{
    private readonly List<PacketRecord> _records = new();
    private readonly ReaderWriterLockSlim _lock = new();
    private readonly SemaphoreSlim _loadSemaphore = new(1, 1);
    private long _filePosition = 0;
    private string? _filePath;

    public event Action<int>? OnNewRecords;
    public event Action<string?>? OnFilePathChanged;

    public string? FilePath => _filePath;
    public DateTime? EarliestTime { get; private set; }
    public DateTime? LatestTime { get; private set; }

    public int TotalCount
    {
        get
        {
            _lock.EnterReadLock();
            try { return _records.Count; }
            finally { _lock.ExitReadLock(); }
        }
    }

    /// <summary>Replaces all records with contents of the given file.</summary>
    public async Task LoadFileAsync(string path)
    {
        _lock.EnterWriteLock();
        try
        {
            _records.Clear();
            _filePosition = 0;
            _filePath = path;
            EarliestTime = null;
            LatestTime = null;
        }
        finally
        {
            _lock.ExitWriteLock();
        }

        OnFilePathChanged?.Invoke(path);
        await LoadIncrementalAsync();
    }

    /// <summary>Reads new lines since the last read position.</summary>
    public async Task<int> LoadIncrementalAsync()
    {
        if (_filePath == null) return 0;

        // Skip if a load is already in progress
        if (!await _loadSemaphore.WaitAsync(0)) return 0;
        try
        {
            var newRecords = new List<PacketRecord>();
            long newPosition = _filePosition;

            try
            {
                using var stream = new FileStream(
                    _filePath, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite, bufferSize: 65536);
                stream.Seek(_filePosition, SeekOrigin.Begin);

                using var reader = new StreamReader(stream, Encoding.UTF8,
                    detectEncodingFromByteOrderMarks: true,
                    bufferSize: 4096, leaveOpen: true);

                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    line = line.Trim();
                    if (string.IsNullOrEmpty(line)) continue;
                    var record = PacketRecord.TryParse(line, 0);
                    if (record != null) newRecords.Add(record);
                }

                newPosition = stream.Position;
            }
            catch { return 0; }

            if (newRecords.Count == 0) return 0;

            _lock.EnterWriteLock();
            try
            {
                var startId = _records.Count + 1;
                foreach (var r in newRecords)
                {
                    r.Id = startId++;
                    _records.Add(r);
                    if (EarliestTime == null || r.PacketTime < EarliestTime) EarliestTime = r.PacketTime;
                    if (LatestTime == null || r.PacketTime > LatestTime) LatestTime = r.PacketTime;
                }
                _filePosition = newPosition;
            }
            finally { _lock.ExitWriteLock(); }

            OnNewRecords?.Invoke(newRecords.Count);
            return newRecords.Count;
        }
        finally { _loadSemaphore.Release(); }
    }

    public (IList<PacketSummaryDto> Items, int Total) GetFiltered(
        string? packetName, int? cmdId, DateTime? startTime, DateTime? endTime,
        int page, int pageSize)
    {
        _lock.EnterReadLock();
        try
        {
            var query = _records.AsEnumerable();
            if (!string.IsNullOrEmpty(packetName))
                query = query.Where(r => r.PacketName.Contains(packetName, StringComparison.OrdinalIgnoreCase));
            if (cmdId.HasValue)
                query = query.Where(r => r.CmdId == cmdId.Value);
            if (startTime.HasValue)
                query = query.Where(r => r.PacketTime >= startTime.Value);
            if (endTime.HasValue)
                query = query.Where(r => r.PacketTime <= endTime.Value);

            var filtered = query.ToList();
            var total = filtered.Count;
            var items = filtered
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(r => new PacketSummaryDto(
                    r.Id,
                    r.PacketTime.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                    r.PacketName,
                    r.CmdId,
                    r.SentByClient,
                    r.HandleIntervalNanoseconds,
                    r.ShiftedDataBytes?.Length > 0,
                    r.BodyBytes.Length,
                    r.ShiftedDataBytes?.Length ?? 0))
                .ToList();

            return (items, total);
        }
        finally { _lock.ExitReadLock(); }
    }

    public PacketRecord? GetById(int id)
    {
        _lock.EnterReadLock();
        try { return _records.FirstOrDefault(r => r.Id == id); }
        finally { _lock.ExitReadLock(); }
    }

    public IList<PacketRecord> GetAll()
    {
        _lock.EnterReadLock();
        try { return _records.ToList(); }
        finally { _lock.ExitReadLock(); }
    }

    public IList<PacketRecord> GetFilteredRecords(
        string? packetName, int? cmdId, DateTime? startTime, DateTime? endTime)
    {
        _lock.EnterReadLock();
        try
        {
            var query = _records.AsEnumerable();
            if (!string.IsNullOrEmpty(packetName))
                query = query.Where(r => r.PacketName.Contains(packetName, StringComparison.OrdinalIgnoreCase));
            if (cmdId.HasValue)
                query = query.Where(r => r.CmdId == cmdId.Value);
            if (startTime.HasValue)
                query = query.Where(r => r.PacketTime >= startTime.Value);
            if (endTime.HasValue)
                query = query.Where(r => r.PacketTime <= endTime.Value);
            return query.ToList();
        }
        finally { _lock.ExitReadLock(); }
    }

    /// <summary>Computes a time histogram over ALL records (no name/cmdId filter).</summary>
    public HistogramDto GetHistogram(int buckets = 60)
    {
        _lock.EnterReadLock();
        try
        {
            if (_records.Count == 0 || EarliestTime == null || LatestTime == null)
                return new HistogramDto([], null, null);

            var earliest = EarliestTime.Value;
            var latest = LatestTime.Value;
            var totalMs = (latest - earliest).TotalMilliseconds;

            if (totalMs <= 0)
            {
                var singleBucket = new HistogramBucketDto(
                    earliest.ToString("O"), latest.ToString("O"), _records.Count);
                return new HistogramDto([singleBucket],
                    earliest.ToString("O"), latest.ToString("O"));
            }

            var bucketMs = totalMs / buckets;
            var counts = new int[buckets];

            foreach (var r in _records)
            {
                var idx = (int)((r.PacketTime - earliest).TotalMilliseconds / bucketMs);
                if (idx >= buckets) idx = buckets - 1;
                if (idx < 0) idx = 0;
                counts[idx]++;
            }

            var result = Enumerable.Range(0, buckets).Select(i => new HistogramBucketDto(
                earliest.AddMilliseconds(i * bucketMs).ToString("O"),
                earliest.AddMilliseconds((i + 1) * bucketMs).ToString("O"),
                counts[i])).ToList();

            return new HistogramDto(result, earliest.ToString("O"), latest.ToString("O"));
        }
        finally { _lock.ExitReadLock(); }
    }
}
