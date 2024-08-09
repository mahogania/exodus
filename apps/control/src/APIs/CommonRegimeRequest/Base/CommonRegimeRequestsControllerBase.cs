using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonRegimeRequestsControllerBase : ControllerBase
{
    protected readonly ICommonRegimeRequestsService _service;

    public CommonRegimeRequestsControllerBase(ICommonRegimeRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one COMMON REGIME REQUEST
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonRegimeRequest>> CreateCommonRegimeRequest(
        CommonRegimeRequestCreateInput input
    )
    {
        var commonRegimeRequest = await _service.CreateCommonRegimeRequest(input);

        return CreatedAtAction(
            nameof(CommonRegimeRequest),
            new { id = commonRegimeRequest.Id },
            commonRegimeRequest
        );
    }

    /// <summary>
    /// Delete one COMMON REGIME REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonRegimeRequest(
        [FromRoute()] CommonRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON REGIME REQUESTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonRegimeRequest>>> CommonRegimeRequests(
        [FromQuery()] CommonRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonRegimeRequests(filter));
    }

    /// <summary>
    /// Meta data about COMMON REGIME REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonRegimeRequestsMeta(
        [FromQuery()] CommonRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonRegimeRequestsMeta(filter));
    }

    /// <summary>
    /// Get one COMMON REGIME REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonRegimeRequest>> CommonRegimeRequest(
        [FromRoute()] CommonRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COMMON REGIME REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonRegimeRequest(
        [FromRoute()] CommonRegimeRequestWhereUniqueInput uniqueId,
        [FromQuery()] CommonRegimeRequestUpdateInput commonRegimeRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonRegimeRequest(uniqueId, commonRegimeRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
