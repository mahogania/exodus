using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CancellationRequestsControllerBase : ControllerBase
{
    protected readonly ICancellationRequestsService _service;

    public CancellationRequestsControllerBase(ICancellationRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Cancellation Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CancellationRequest>> CreateCancellationRequest(
        CancellationRequestCreateInput input
    )
    {
        var cancellationRequest = await _service.CreateCancellationRequest(input);

        return CreatedAtAction(
            nameof(CancellationRequest),
            new { id = cancellationRequest.Id },
            cancellationRequest
        );
    }

    /// <summary>
    /// Delete one Cancellation Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCancellationRequest(
        [FromRoute()] CancellationRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCancellationRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Cancellation Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CancellationRequest>>> CancellationRequests(
        [FromQuery()] CancellationRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CancellationRequests(filter));
    }

    /// <summary>
    /// Meta data about Cancellation Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CancellationRequestsMeta(
        [FromQuery()] CancellationRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CancellationRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Cancellation Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CancellationRequest>> CancellationRequest(
        [FromRoute()] CancellationRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CancellationRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Cancellation Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCancellationRequest(
        [FromRoute()] CancellationRequestWhereUniqueInput uniqueId,
        [FromQuery()] CancellationRequestUpdateInput cancellationRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCancellationRequest(uniqueId, cancellationRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Request record for Cancellation Request
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetRequest(
        [FromRoute()] CancellationRequestWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetRequest(uniqueId);
        return Ok(procedure);
    }
}
