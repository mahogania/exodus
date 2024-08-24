using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TransitCarnetRequestsControllerBase : ControllerBase
{
    protected readonly ITransitCarnetRequestsService _service;

    public TransitCarnetRequestsControllerBase(ITransitCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Transit Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TransitCarnetRequest>> CreateTransitCarnetRequest(
        TransitCarnetRequestCreateInput input
    )
    {
        var transitCarnetRequest = await _service.CreateTransitCarnetRequest(input);

        return CreatedAtAction(
            nameof(TransitCarnetRequest),
            new { id = transitCarnetRequest.Id },
            transitCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Transit Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTransitCarnetRequest(
        [FromRoute()] TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTransitCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Transit Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TransitCarnetRequest>>> TransitCarnetRequests(
        [FromQuery()] TransitCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.TransitCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Transit Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TransitCarnetRequestsMeta(
        [FromQuery()] TransitCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.TransitCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Transit Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TransitCarnetRequest>> TransitCarnetRequest(
        [FromRoute()] TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TransitCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Transit Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTransitCarnetRequest(
        [FromRoute()] TransitCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] TransitCarnetRequestUpdateInput transitCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateTransitCarnetRequest(uniqueId, transitCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Transit Carnet Control record for Transit Carnet Request
    /// </summary>
    [HttpGet("{Id}/transitCarnetControls")]
    public async Task<ActionResult<List<TransitCarnetControl>>> GetTransitCarnetControl(
        [FromRoute()] TransitCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var transitCarnetControl = await _service.GetTransitCarnetControl(uniqueId);
        return Ok(transitCarnetControl);
    }
}
