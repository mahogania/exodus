using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

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
    /// Create one FOREIGN OPERATOR REQUEST
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
    /// Delete one FOREIGN OPERATOR REQUEST
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
    /// Meta data about FOREIGN OPERATOR REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ForeignOperatorRequestsMeta(
        [FromQuery()] ForeignOperatorRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ForeignOperatorRequestsMeta(filter));
    }

    /// <summary>
    /// Get one FOREIGN OPERATOR REQUEST
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
    /// Update one FOREIGN OPERATOR REQUEST
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
}
