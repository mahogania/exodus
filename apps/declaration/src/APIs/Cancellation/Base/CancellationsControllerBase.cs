using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Statement.APIs;
using Statement.APIs.Common;
using Statement.APIs.Dtos;
using Statement.APIs.Errors;

namespace Statement.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CancellationsControllerBase : ControllerBase
{
    protected readonly ICancellationsService _service;

    public CancellationsControllerBase(ICancellationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Cancellation
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Cancellation>> CreateCancellation(CancellationCreateInput input)
    {
        var cancellation = await _service.CreateCancellation(input);

        return CreatedAtAction(nameof(Cancellation), new { id = cancellation.Id }, cancellation);
    }

    /// <summary>
    /// Delete one Cancellation
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCancellation(
        [FromRoute()] CancellationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCancellation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Cancellations
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Cancellation>>> Cancellations(
        [FromQuery()] CancellationFindManyArgs filter
    )
    {
        return Ok(await _service.Cancellations(filter));
    }

    /// <summary>
    /// Meta data about Cancellation records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CancellationsMeta(
        [FromQuery()] CancellationFindManyArgs filter
    )
    {
        return Ok(await _service.CancellationsMeta(filter));
    }

    /// <summary>
    /// Get one Cancellation
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Cancellation>> Cancellation(
        [FromRoute()] CancellationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Cancellation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Cancellation
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCancellation(
        [FromRoute()] CancellationWhereUniqueInput uniqueId,
        [FromQuery()] CancellationUpdateInput cancellationUpdateDto
    )
    {
        try
        {
            await _service.UpdateCancellation(uniqueId, cancellationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
