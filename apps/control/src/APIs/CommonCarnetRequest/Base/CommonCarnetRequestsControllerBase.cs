using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonCarnetRequestsControllerBase : ControllerBase
{
    protected readonly ICommonCarnetRequestsService _service;

    public CommonCarnetRequestsControllerBase(ICommonCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonCarnetRequest>> CreateCommonCarnetRequest(
        CommonCarnetRequestCreateInput input
    )
    {
        var commonCarnetRequest = await _service.CreateCommonCarnetRequest(input);

        return CreatedAtAction(
            nameof(CommonCarnetRequest),
            new { id = commonCarnetRequest.Id },
            commonCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Common Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Common Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> CommonCarnetRequests(
        [FromQuery()] CommonCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Common Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonCarnetRequestsMeta(
        [FromQuery()] CommonCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Common Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonCarnetRequest>> CommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonCarnetRequest(
        [FromRoute()] CommonCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CommonCarnetRequestUpdateInput commonCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonCarnetRequest(uniqueId, commonCarnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
