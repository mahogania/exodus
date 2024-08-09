using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class FineCausesControllerBase : ControllerBase
{
    protected readonly IFineCausesService _service;

    public FineCausesControllerBase(IFineCausesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one FINE CAUSE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineCause>> CreateFineCause(FineCauseCreateInput input)
    {
        var fineCause = await _service.CreateFineCause(input);

        return CreatedAtAction(nameof(FineCause), new { id = fineCause.Id }, fineCause);
    }

    /// <summary>
    /// Delete one FINE CAUSE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFineCause(
        [FromRoute()] FineCauseWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFineCause(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many FINE CAUSES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<FineCause>>> FineCauses(
        [FromQuery()] FineCauseFindManyArgs filter
    )
    {
        return Ok(await _service.FineCauses(filter));
    }

    /// <summary>
    /// Meta data about FINE CAUSE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FineCausesMeta(
        [FromQuery()] FineCauseFindManyArgs filter
    )
    {
        return Ok(await _service.FineCausesMeta(filter));
    }

    /// <summary>
    /// Get one FINE CAUSE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineCause>> FineCause(
        [FromRoute()] FineCauseWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FineCause(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one FINE CAUSE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFineCause(
        [FromRoute()] FineCauseWhereUniqueInput uniqueId,
        [FromQuery()] FineCauseUpdateInput fineCauseUpdateDto
    )
    {
        try
        {
            await _service.UpdateFineCause(uniqueId, fineCauseUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
