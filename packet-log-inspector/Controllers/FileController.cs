using Microsoft.AspNetCore.Mvc;
using PacketLogInspector.Models;
using PacketLogInspector.Services;

namespace PacketLogInspector.Controllers;

[ApiController]
[Route("api/file")]
public class FileController : ControllerBase
{
    private readonly PacketLogService _logService;

    public FileController(PacketLogService logService)
    {
        _logService = logService;
    }

    [HttpPost]
    public async Task<IActionResult> ChangeFile([FromBody] ChangeFileRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.FilePath))
            return BadRequest(new { error = "File path cannot be empty." });

        if (!System.IO.File.Exists(request.FilePath))
            return NotFound(new { error = $"File not found: {request.FilePath}" });

        await _logService.LoadFileAsync(request.FilePath);

        return Ok(new
        {
            message = "File loaded successfully.",
            path = request.FilePath,
            total = _logService.TotalCount
        });
    }

    /// <summary>
    /// Returns a directory listing for the virtual file browser.
    /// When <paramref name="path"/> is omitted, returns drives on Windows or "/" on Unix.
    /// Only directories and *.log files are listed.
    /// </summary>
    [HttpGet("ls")]
    public IActionResult ListDirectory([FromQuery] string? path)
    {
        try
        {
            // No path → root listing
            if (string.IsNullOrWhiteSpace(path))
            {
                if (OperatingSystem.IsWindows())
                {
                    var drives = DriveInfo.GetDrives()
                        .Where(d => d.IsReady)
                        .Select(d => new FsEntry(d.Name, d.RootDirectory.FullName, "dir", null))
                        .ToList();
                    return Ok(new DirectoryListingDto(null, null, true, drives));
                }
                // Unix: start at filesystem root
                path = "/";
            }

            if (!Directory.Exists(path))
                return NotFound(new { error = $"目录不存在: {path}" });

            var dirInfo = new DirectoryInfo(path);
            var parentPath = dirInfo.Parent?.FullName; // null when already at fs root

            var entries = new List<FsEntry>();

            // Subdirectories (exclude hidden/system on Windows)
            foreach (var d in dirInfo.GetDirectories().OrderBy(d => d.Name))
            {
                if (d.Attributes.HasFlag(FileAttributes.Hidden) ||
                    d.Attributes.HasFlag(FileAttributes.System))
                    continue;
                entries.Add(new FsEntry(d.Name, d.FullName, "dir", null));
            }

            // *.log files only
            foreach (var f in dirInfo.GetFiles("*.log").OrderBy(f => f.Name))
                entries.Add(new FsEntry(f.Name, f.FullName, "file", f.Length));

            return Ok(new DirectoryListingDto(dirInfo.FullName, parentPath, false, entries));
        }
        catch (UnauthorizedAccessException)
        {
            return StatusCode(403, new { error = "访问被拒绝" });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }
}
