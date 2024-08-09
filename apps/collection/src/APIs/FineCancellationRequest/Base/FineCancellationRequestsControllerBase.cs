using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class FineCancellationRequestsControllerBase : ControllerBase
{
    protected readonly IFineCancellationRequestsService _service;

    public FineCancellationRequestsControllerBase(IFineCancellationRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one FINE CANCELLATION REQUEST
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineCancellationRequest>> CreateFineCancellationRequest(
        FineCancellationRequestCreateInput input
    )
    {
        var fineCancellationRequest = await _service.CreateFineCancellationRequest(input);

        return CreatedAtAction(
            nameof(FineCancellationRequest),
            new { id = fineCancellationRequest.Id },
            fineCancellationRequest
        );
    }

    /// <summary>
    /// Delete one FINE CANCELLATION REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFineCancellationRequest(
        [FromRoute()] FineCancellationRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFineCancellationRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many FINE CANCELLATION REQUESTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<FineCancellationRequest>>> FineCancellationRequests(
        [FromQuery()] FineCancellationRequestFindManyArgs filter
    )
    {
        return Ok(await _service.FineCancellationRequests(filter));
    }

    /// <summary>
    /// Meta data about FINE CANCELLATION REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FineCancellationRequestsMeta(
        [FromQuery()] FineCancellationRequestFindManyArgs filter
    )
    {
        return Ok(await _service.FineCancellationRequestsMeta(filter));
    }

    /// <summary>
    /// Get one FINE CANCELLATION REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineCancellationRequest>> FineCancellationRequest(
        [FromRoute()] FineCancellationRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FineCancellationRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one FINE CANCELLATION REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFineCancellationRequest(
        [FromRoute()] FineCancellationRequestWhereUniqueInput uniqueId,
        [FromQuery()] FineCancellationRequestUpdateInput fineCancellationRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateFineCancellationRequest(
                uniqueId,
                fineCancellationRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
