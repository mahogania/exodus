using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ReexportCarnetRequestsControllerBase : ControllerBase
{
    protected readonly IReexportCarnetRequestsService _service;

    public ReexportCarnetRequestsControllerBase(IReexportCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Reexport Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReexportCarnetRequest>> CreateReexportCarnetRequest(
        ReexportCarnetRequestCreateInput input
    )
    {
        var reexportCarnetRequest = await _service.CreateReexportCarnetRequest(input);

        return CreatedAtAction(
            nameof(ReexportCarnetRequest),
            new { id = reexportCarnetRequest.Id },
            reexportCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Reexport Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteReexportCarnetRequest(
        [FromRoute()] ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteReexportCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Reexport Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ReexportCarnetRequest>>> ReexportCarnetRequests(
        [FromQuery()] ReexportCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ReexportCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Reexport Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ReexportCarnetRequestsMeta(
        [FromQuery()] ReexportCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ReexportCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Reexport Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ReexportCarnetRequest>> ReexportCarnetRequest(
        [FromRoute()] ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ReexportCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Reexport Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateReexportCarnetRequest(
        [FromRoute()] ReexportCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ReexportCarnetRequestUpdateInput reexportCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateReexportCarnetRequest(uniqueId, reexportCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Carnet Request record for Reexport Carnet Request
    /// </summary>
    [HttpGet("{Id}/carnetRequests")]
    public async Task<ActionResult<List<CarnetRequest>>> GetCarnetRequest(
        [FromRoute()] ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var carnetRequest = await _service.GetCarnetRequest(uniqueId);
        return Ok(carnetRequest);
    }

    /// <summary>
    /// Get a Reexport Carnet Control record for Reexport Carnet Request
    /// </summary>
    [HttpGet("{Id}/reexportCarnetControls")]
    public async Task<ActionResult<List<ReexportCarnetControl>>> GetReexportCarnetControl(
        [FromRoute()] ReexportCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var reexportCarnetControl = await _service.GetReexportCarnetControl(uniqueId);
        return Ok(reexportCarnetControl);
    }
}
