using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class OfficialReportsControllerBase : ControllerBase
{
    protected readonly IOfficialReportsService _service;

    public OfficialReportsControllerBase(IOfficialReportsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one OFFICIAL REPORT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<OfficialReport>> CreateOfficialReport(
        OfficialReportCreateInput input
    )
    {
        var officialReport = await _service.CreateOfficialReport(input);

        return CreatedAtAction(
            nameof(OfficialReport),
            new { id = officialReport.Id },
            officialReport
        );
    }

    /// <summary>
    ///     Delete one OFFICIAL REPORT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteOfficialReport(
        [FromRoute] OfficialReportWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteOfficialReport(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many OFFICIAL REPORTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<OfficialReport>>> OfficialReports(
        [FromQuery] OfficialReportFindManyArgs filter
    )
    {
        return Ok(await _service.OfficialReports(filter));
    }

    /// <summary>
    ///     Meta data about OFFICIAL REPORT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> OfficialReportsMeta(
        [FromQuery] OfficialReportFindManyArgs filter
    )
    {
        return Ok(await _service.OfficialReportsMeta(filter));
    }

    /// <summary>
    ///     Get one OFFICIAL REPORT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<OfficialReport>> OfficialReport(
        [FromRoute] OfficialReportWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.OfficialReport(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one OFFICIAL REPORT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOfficialReport(
        [FromRoute] OfficialReportWhereUniqueInput uniqueId,
        [FromQuery] OfficialReportUpdateInput officialReportUpdateDto
    )
    {
        try
        {
            await _service.UpdateOfficialReport(uniqueId, officialReportUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
