using Microsoft.AspNetCore.Mvc;
using PacketLogInspector.Models;
using PacketLogInspector.Services;
using System.Globalization;
using System.Text;

namespace PacketLogInspector.Controllers;

[ApiController]
[Route("api")]
public class PacketsController : ControllerBase
{
    private readonly PacketLogService _logService;
    private readonly ProtoDeserializerService _deserializer;
    private readonly JsonDiffService _diffService;

    public PacketsController(
        PacketLogService logService,
        ProtoDeserializerService deserializer,
        JsonDiffService diffService)
    {
        _logService = logService;
        _deserializer = deserializer;
        _diffService = diffService;
    }

    [HttpGet("status")]
    public IActionResult GetStatus()
    {
        return Ok(new LogStatusDto(
            _logService.FilePath,
            _logService.TotalCount,
            _logService.EarliestTime?.ToString("yyyy-MM-dd HH:mm:ss.fff"),
            _logService.LatestTime?.ToString("yyyy-MM-dd HH:mm:ss.fff")));
    }

    [HttpGet("packets")]
    public IActionResult GetPackets(
        [FromQuery] string? packetName,
        [FromQuery] int? cmdId,
        [FromQuery] string? startTime,
        [FromQuery] string? endTime,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 50)
    {
        DateTime? start = ParseDateTime(startTime);
        DateTime? end = ParseDateTime(endTime);
        var (items, total) = _logService.GetFiltered(packetName, cmdId, start, end, page, pageSize);
        return Ok(new { items, total, page, pageSize });
    }

    [HttpGet("packets/{id:int}")]
    public IActionResult GetPacket(int id)
    {
        var record = _logService.GetById(id);
        if (record == null) return NotFound();

        var bodyJson = _deserializer.DeserializeBody(record);
        return Ok(new PacketDetailDto(
            record.Id,
            record.PacketTime.ToString("yyyy-MM-dd HH:mm:ss.fff"),
            record.Uid,
            record.PacketName,
            record.CmdId,
            record.SentByClient,
            record.HandleIntervalNanoseconds,
            record.ShiftedDataBytes.Length > 0,
            bodyJson));
    }

    [HttpGet("packets/{id:int}/diff")]
    public IActionResult GetDiff(int id)
    {
        var record = _logService.GetById(id);
        if (record == null) return NotFound();
        if (record.ShiftedDataBytes.Length == 0)
            return BadRequest(new { error = "This record has no shifted data." });

        var (original, modified) = _diffService.GetDiff(record);
        return Ok(new DiffResultDto(original, modified));
    }

    [HttpGet("packets/export")]
    public IActionResult Export(
        [FromQuery] string scope = "all",
        [FromQuery] bool includeShifted = false,
        [FromQuery] string? packetName = null,
        [FromQuery] int? cmdId = null,
        [FromQuery] string? startTime = null,
        [FromQuery] string? endTime = null,
        [FromQuery] string? selectedIds = null)
    {
        DateTime? start = ParseDateTime(startTime);
        DateTime? end = ParseDateTime(endTime);

        IList<PacketRecord> records;
        if (scope == "selected" && !string.IsNullOrEmpty(selectedIds))
        {
            var idSet = selectedIds.Split(',').Select(int.Parse).ToHashSet();
            records = _logService.GetAll().Where(r => idSet.Contains(r.Id)).ToList();
        }
        else if (scope == "filtered")
        {
            records = _logService.GetFilteredRecords(packetName, cmdId, start, end);
        }
        else
        {
            records = _logService.GetAll();
        }

        var sb = new StringBuilder();
        foreach (var r in records)
        {
            // Escape '|' inside JSON values to preserve PSV integrity
            var bodyJson = _deserializer.DeserializeBody(r).Replace("|", "\\u007C");
            var headBase64 = Convert.ToBase64String(r.HeadBytes);
            var timeStr = r.PacketTime.ToString("yyyy-MM-dd HH:mm:ss.fff");

            if (includeShifted)
            {
                var shiftedJson = _deserializer.DeserializeShifted(r).Replace("|", "\\u007C");
                sb.AppendLine(
                    $"{timeStr}|Info|{r.Uid}|{r.PacketName}|{r.CmdId}|{r.SentByClient}|{headBase64}|{bodyJson}|{r.HandleIntervalNanoseconds}|{shiftedJson}");
            }
            else
            {
                sb.AppendLine(
                    $"{timeStr}|Info|{r.Uid}|{r.PacketName}|{r.CmdId}|{r.SentByClient}|{headBase64}|{bodyJson}");
            }
        }

        var bytes = Encoding.UTF8.GetBytes(sb.ToString());
        return File(bytes, "text/plain; charset=utf-8", "export.packet.log");
    }

    [HttpGet("packets/histogram")]
    public IActionResult GetHistogram([FromQuery] int buckets = 60)
    {
        if (buckets < 1) buckets = 1;
        if (buckets > 500) buckets = 500;
        return Ok(_logService.GetHistogram(buckets));
    }

    private static DateTime? ParseDateTime(string? value)
    {
        if (string.IsNullOrWhiteSpace(value)) return null;
        return DateTime.Parse(value, null, DateTimeStyles.RoundtripKind);
    }
}
