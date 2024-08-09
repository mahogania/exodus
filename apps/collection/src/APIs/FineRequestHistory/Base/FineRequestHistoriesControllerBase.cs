using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class FineRequestHistoriesControllerBase : ControllerBase
{
    protected readonly IFineRequestHistoriesService _service;

    public FineRequestHistoriesControllerBase(IFineRequestHistoriesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one FINE REQUEST HISTORY
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineRequestHistory>> CreateFineRequestHistory(
        FineRequestHistoryCreateInput input
    )
    {
        var fineRequestHistory = await _service.CreateFineRequestHistory(input);

        return CreatedAtAction(
            nameof(FineRequestHistory),
            new { id = fineRequestHistory.Id },
            fineRequestHistory
        );
    }

    /// <summary>
    /// Delete one FINE REQUEST HISTORY
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFineRequestHistory(
        [FromRoute()] FineRequestHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFineRequestHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many FINE REQUEST HISTORIES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<FineRequestHistory>>> FineRequestHistories(
        [FromQuery()] FineRequestHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.FineRequestHistories(filter));
    }

    /// <summary>
    /// Meta data about FINE REQUEST HISTORY records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FineRequestHistoriesMeta(
        [FromQuery()] FineRequestHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.FineRequestHistoriesMeta(filter));
    }

    /// <summary>
    /// Get one FINE REQUEST HISTORY
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineRequestHistory>> FineRequestHistory(
        [FromRoute()] FineRequestHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FineRequestHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one FINE REQUEST HISTORY
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFineRequestHistory(
        [FromRoute()] FineRequestHistoryWhereUniqueInput uniqueId,
        [FromQuery()] FineRequestHistoryUpdateInput fineRequestHistoryUpdateDto
    )
    {
        try
        {
            await _service.UpdateFineRequestHistory(uniqueId, fineRequestHistoryUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
