using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonActiveGoodsRequestsControllerBase : ControllerBase
{
    protected readonly ICommonActiveGoodsRequestsService _service;

    public CommonActiveGoodsRequestsControllerBase(ICommonActiveGoodsRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Active Goods Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonActiveGoodsRequest>> CreateCommonActiveGoodsRequest(
        CommonActiveGoodsRequestCreateInput input
    )
    {
        var commonActiveGoodsRequest = await _service.CreateCommonActiveGoodsRequest(input);

        return CreatedAtAction(
            nameof(CommonActiveGoodsRequest),
            new { id = commonActiveGoodsRequest.Id },
            commonActiveGoodsRequest
        );
    }

    /// <summary>
    /// Delete one Common Active Goods Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonActiveGoodsRequest(
        [FromRoute()] CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonActiveGoodsRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON ACTIVE PERFECTIONING GOODS REQUESTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonActiveGoodsRequest>>> CommonActiveGoodsRequests(
        [FromQuery()] CommonActiveGoodsRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonActiveGoodsRequests(filter));
    }

    /// <summary>
    /// Meta data about Common Active Goods Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonActiveGoodsRequestsMeta(
        [FromQuery()] CommonActiveGoodsRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonActiveGoodsRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Common Active Goods Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonActiveGoodsRequest>> CommonActiveGoodsRequest(
        [FromRoute()] CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonActiveGoodsRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Active Goods Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonActiveGoodsRequest(
        [FromRoute()] CommonActiveGoodsRequestWhereUniqueInput uniqueId,
        [FromQuery()] CommonActiveGoodsRequestUpdateInput commonActiveGoodsRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonActiveGoodsRequest(
                uniqueId,
                commonActiveGoodsRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Journal record for Common Active Goods Request
    /// </summary>
    [HttpGet("{Id}/journals")]
    public async Task<ActionResult<List<Journal>>> GetJournal(
        [FromRoute()] CommonActiveGoodsRequestWhereUniqueInput uniqueId
    )
    {
        var journal = await _service.GetJournal(uniqueId);
        return Ok(journal);
    }
}
