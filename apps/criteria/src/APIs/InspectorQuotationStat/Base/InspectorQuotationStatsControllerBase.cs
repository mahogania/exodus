using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorQuotationStatsControllerBase : ControllerBase
{
    protected readonly IInspectorQuotationStatsService _service;

    public InspectorQuotationStatsControllerBase(IInspectorQuotationStatsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Inspector Quotation Stat
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationStat>> CreateInspectorQuotationStat(
        InspectorQuotationStatCreateInput input
    )
    {
        var inspectorQuotationStat = await _service.CreateInspectorQuotationStat(input);

        return CreatedAtAction(
            nameof(InspectorQuotationStat),
            new { id = inspectorQuotationStat.Id },
            inspectorQuotationStat
        );
    }

    /// <summary>
    /// Delete one Inspector Quotation Stat
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorQuotationStat(
        [FromRoute()] InspectorQuotationStatWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorQuotationStat(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Inspector Quotation Stats
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<InspectorQuotationStat>>> InspectorQuotationStats(
        [FromQuery()] InspectorQuotationStatFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationStats(filter));
    }

    /// <summary>
    /// Meta data about Inspector Quotation Stat records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorQuotationStatsMeta(
        [FromQuery()] InspectorQuotationStatFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorQuotationStatsMeta(filter));
    }

    /// <summary>
    /// Get one Inspector Quotation Stat
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<InspectorQuotationStat>> InspectorQuotationStat(
        [FromRoute()] InspectorQuotationStatWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorQuotationStat(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Inspector Quotation Stat
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorQuotationStat(
        [FromRoute()] InspectorQuotationStatWhereUniqueInput uniqueId,
        [FromQuery()] InspectorQuotationStatUpdateInput inspectorQuotationStatUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorQuotationStat(uniqueId, inspectorQuotationStatUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
