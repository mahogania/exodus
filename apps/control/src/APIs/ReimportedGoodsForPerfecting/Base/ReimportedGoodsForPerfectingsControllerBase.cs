using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReimportedGoodsForPerfectingsControllerBase : ControllerBase
{
    protected readonly IReimportedGoodsForPerfectingsService _service;

    public ReimportedGoodsForPerfectingsControllerBase(
        IReimportedGoodsForPerfectingsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ReimportedGoodsForPerfecting>
    > CreateReimportedGoodsForPerfecting(ReimportedGoodsForPerfectingCreateInput input)
    {
        var reimportedGoodsForPerfecting = await _service.CreateReimportedGoodsForPerfecting(input);

        return CreatedAtAction(
            nameof(ReimportedGoodsForPerfecting),
            new { id = reimportedGoodsForPerfecting.Id },
            reimportedGoodsForPerfecting
        );
    }

    /// <summary>
    /// Delete one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReimportedGoodsForPerfecting(
        [FromRoute()] ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReimportedGoodsForPerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REIMPORTED GOODS FOR PERFECTINGS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ReimportedGoodsForPerfecting>>
    > ReimportedGoodsForPerfectings([FromQuery()] ReimportedGoodsForPerfectingFindManyArgs filter)
    {
        return Ok(await _service.ReimportedGoodsForPerfectings(filter));
    }

    /// <summary>
    /// Meta data about REIMPORTED GOODS FOR PERFECTING records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReimportedGoodsForPerfectingsMeta(
        [FromQuery()] ReimportedGoodsForPerfectingFindManyArgs filter
    )
    {
        return Ok(await _service.ReimportedGoodsForPerfectingsMeta(filter));
    }

    /// <summary>
    /// Get one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReimportedGoodsForPerfecting>> ReimportedGoodsForPerfecting(
        [FromRoute()] ReimportedGoodsForPerfectingWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ReimportedGoodsForPerfecting(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REIMPORTED GOODS FOR PERFECTING
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReimportedGoodsForPerfecting(
        [FromRoute()] ReimportedGoodsForPerfectingWhereUniqueInput uniqueId,
        [FromQuery()] ReimportedGoodsForPerfectingUpdateInput reimportedGoodsForPerfectingUpdateDto
    )
    {
        try
        {
            await _service.UpdateReimportedGoodsForPerfecting(
                uniqueId,
                reimportedGoodsForPerfectingUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
