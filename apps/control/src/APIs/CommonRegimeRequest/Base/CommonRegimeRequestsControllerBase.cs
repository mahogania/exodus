using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

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
    /// Create one Common Regime Request
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
    /// Delete one Common Regime Request
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
    /// Meta data about Common Regime Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonRegimeRequestsMeta(
        [FromQuery()] CommonRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonRegimeRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Common Regime Request
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
    /// Update one Common Regime Request
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
