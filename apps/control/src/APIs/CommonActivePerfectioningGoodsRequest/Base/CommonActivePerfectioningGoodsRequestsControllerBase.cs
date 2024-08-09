using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonActivePerfectioningGoodsRequestsControllerBase : ControllerBase
{
    protected readonly ICommonActivePerfectioningGoodsRequestsService _service;

    public CommonActivePerfectioningGoodsRequestsControllerBase(
        ICommonActivePerfectioningGoodsRequestsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CommonActivePerfectioningGoodsRequest>
    > CreateCommonActivePerfectioningGoodsRequest(
        CommonActivePerfectioningGoodsRequestCreateInput input
    )
    {
        var commonActivePerfectioningGoodsRequest =
            await _service.CreateCommonActivePerfectioningGoodsRequest(input);

        return CreatedAtAction(
            nameof(CommonActivePerfectioningGoodsRequest),
            new { id = commonActivePerfectioningGoodsRequest.Id },
            commonActivePerfectioningGoodsRequest
        );
    }

    /// <summary>
    /// Delete one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonActivePerfectioningGoodsRequest(
        [FromRoute()] CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonActivePerfectioningGoodsRequest(uniqueId);
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
    public async Task<
        ActionResult<List<CommonActivePerfectioningGoodsRequest>>
    > CommonActivePerfectioningGoodsRequests(
        [FromQuery()] CommonActivePerfectioningGoodsRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonActivePerfectioningGoodsRequests(filter));
    }

    /// <summary>
    /// Meta data about COMMON ACTIVE PERFECTIONING GOODS REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonActivePerfectioningGoodsRequestsMeta(
        [FromQuery()] CommonActivePerfectioningGoodsRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonActivePerfectioningGoodsRequestsMeta(filter));
    }

    /// <summary>
    /// Get one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CommonActivePerfectioningGoodsRequest>
    > CommonActivePerfectioningGoodsRequest(
        [FromRoute()] CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonActivePerfectioningGoodsRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COMMON ACTIVE PERFECTIONING GOODS REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonActivePerfectioningGoodsRequest(
        [FromRoute()] CommonActivePerfectioningGoodsRequestWhereUniqueInput uniqueId,
        [FromQuery()]
            CommonActivePerfectioningGoodsRequestUpdateInput commonActivePerfectioningGoodsRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonActivePerfectioningGoodsRequest(
                uniqueId,
                commonActivePerfectioningGoodsRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
