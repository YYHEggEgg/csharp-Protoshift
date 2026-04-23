namespace PacketLogInspector.Models;

public record PacketSummaryDto(
    int Id,
    string PacketTime,
    string PacketName,
    int CmdId,
    bool SentByClient,
    long HandleIntervalNanoseconds,
    bool HasShiftedData,
    int BodySize,
    int ShiftedDataSize);

public record PacketDetailDto(
    int Id,
    string PacketTime,
    uint Uid,
    string PacketName,
    int CmdId,
    bool SentByClient,
    long HandleIntervalNanoseconds,
    bool HasShiftedData,
    string BodyJson);

public record DiffResultDto(
    string OriginalJson,
    string ModifiedJson);

public record LogStatusDto(
    string? FilePath,
    int Total,
    string? Earliest,
    string? Latest);

public record ChangeFileRequest(string FilePath);

public record HistogramBucketDto(
    string StartTime,
    string EndTime,
    int Count);

public record HistogramDto(
    IList<HistogramBucketDto> Buckets,
    string? Earliest,
    string? Latest);

// File-system browser
public record FsEntry(string Name, string FullPath, string Type, long? Size);

public record DirectoryListingDto(
    string? CurrentPath,
    string? ParentPath,
    bool IsRoot,
    IList<FsEntry> Entries);
