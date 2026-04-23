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
    /// Error responses include a <c>parentPath</c> field so the client can offer a "go up" action.
    /// </summary>
    [HttpGet("ls")]
    public IActionResult ListDirectory([FromQuery] string? path)
    {
        // No path → root listing (always succeeds)
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
            path = "/";
        }

        if (!Directory.Exists(path))
            return NotFound(new { error = $"目录不存在: {path}" });

        var dirInfo = new DirectoryInfo(path);
        string? parentPath = dirInfo.Parent?.FullName; // null when already at fs root

        var entries = new List<FsEntry>();

        // Subdirectories — wrapped individually so one bad dir doesn't abort the whole listing
        try
        {
            foreach (var d in dirInfo.GetDirectories().OrderBy(d => d.Name))
            {
                if (d.Attributes.HasFlag(FileAttributes.Hidden) ||
                    d.Attributes.HasFlag(FileAttributes.System))
                    continue;
                entries.Add(new FsEntry(d.Name, d.FullName, "dir", null));
            }
        }
        catch (UnauthorizedAccessException)
        {
            // Can't enumerate subdirectories — return 403 with parentPath so client can go up
            return StatusCode(403, new { error = "访问被拒绝", parentPath });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message, parentPath });
        }

        // *.log files
        try
        {
            foreach (var f in dirInfo.GetFiles("*.log").OrderBy(f => f.Name))
                entries.Add(new FsEntry(f.Name, f.FullName, "file", f.Length));
        }
        catch (UnauthorizedAccessException) { /* skip — directories already listed */ }
        catch (Exception) { /* skip */ }

        return Ok(new DirectoryListingDto(dirInfo.FullName, parentPath, false, entries));
    }

    /// <summary>
    /// Returns server-side paths useful as navigation fallbacks: home directory and application base directory.
    /// </summary>
    [HttpGet("suggested-dirs")]
    public IActionResult GetSuggestedDirs()
    {
        var home = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        var appDir = AppContext.BaseDirectory;
        return Ok(new
        {
            home = string.IsNullOrEmpty(home) ? null : home,
            appDir
        });
    }
}
