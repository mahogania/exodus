using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AuctionReportsControllerBase : ControllerBase
{
    protected readonly IAuctionReportsService _service;

    public AuctionReportsControllerBase(IAuctionReportsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one AUCTION REPORT
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AuctionReport>> CreateAuctionReport(
        AuctionReportCreateInput input
    )
    {
        var auctionReport = await _service.CreateAuctionReport(input);

        return CreatedAtAction(nameof(AuctionReport), new { id = auctionReport.Id }, auctionReport);
    }

    /// <summary>
    /// Delete one AUCTION REPORT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAuctionReport(
        [FromRoute()] AuctionReportWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAuctionReport(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many AUCTION REPORTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<AuctionReport>>> AuctionReports(
        [FromQuery()] AuctionReportFindManyArgs filter
    )
    {
        return Ok(await _service.AuctionReports(filter));
    }

    /// <summary>
    /// Meta data about AUCTION REPORT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AuctionReportsMeta(
        [FromQuery()] AuctionReportFindManyArgs filter
    )
    {
        return Ok(await _service.AuctionReportsMeta(filter));
    }

    /// <summary>
    /// Get one AUCTION REPORT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AuctionReport>> AuctionReport(
        [FromRoute()] AuctionReportWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AuctionReport(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one AUCTION REPORT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAuctionReport(
        [FromRoute()] AuctionReportWhereUniqueInput uniqueId,
        [FromQuery()] AuctionReportUpdateInput auctionReportUpdateDto
    )
    {
        try
        {
            await _service.UpdateAuctionReport(uniqueId, auctionReportUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
