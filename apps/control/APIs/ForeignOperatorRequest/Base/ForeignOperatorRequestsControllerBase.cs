using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ForeignOperatorRequestsControllerBase : ControllerBase
{
    protected readonly IForeignOperatorRequestsService _service;

    public ForeignOperatorRequestsControllerBase(IForeignOperatorRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Foreign Operator Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ForeignOperatorRequest>> CreateForeignOperatorRequest(
        ForeignOperatorRequestCreateInput input
    )
    {
        var foreignOperatorRequest = await _service.CreateForeignOperatorRequest(input);

        return CreatedAtAction(
            nameof(ForeignOperatorRequest),
            new { id = foreignOperatorRequest.Id },
            foreignOperatorRequest
        );
    }

    /// <summary>
    /// Delete one Foreign Operator Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteForeignOperatorRequest(
        [FromRoute()] ForeignOperatorRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteForeignOperatorRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many FOREIGN OPERATOR REQUESTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ForeignOperatorRequest>>> ForeignOperatorRequests(
        [FromQuery()] ForeignOperatorRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ForeignOperatorRequests(filter));
    }

    /// <summary>
    /// Meta data about Foreign Operator Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ForeignOperatorRequestsMeta(
        [FromQuery()] ForeignOperatorRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ForeignOperatorRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Foreign Operator Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ForeignOperatorRequest>> ForeignOperatorRequest(
        [FromRoute()] ForeignOperatorRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ForeignOperatorRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Foreign Operator Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateForeignOperatorRequest(
        [FromRoute()] ForeignOperatorRequestWhereUniqueInput uniqueId,
        [FromQuery()] ForeignOperatorRequestUpdateInput foreignOperatorRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateForeignOperatorRequest(uniqueId, foreignOperatorRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Request record for Foreign Operator Request
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetRequest(
        [FromRoute()] ForeignOperatorRequestWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetRequest(uniqueId);
        return Ok(procedure);
    }
}
