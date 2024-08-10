using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class RefundRequestsControllerBase : ControllerBase
{
    protected readonly IRefundRequestsService _service;

    public RefundRequestsControllerBase(IRefundRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one REFUND REQUEST
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RefundRequest>> CreateRefundRequest(
        RefundRequestCreateInput input
    )
    {
        var refundRequest = await _service.CreateRefundRequest(input);

        return CreatedAtAction(nameof(RefundRequest), new { id = refundRequest.Id }, refundRequest);
    }

    /// <summary>
    ///     Delete one REFUND REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRefundRequest(
        [FromRoute] RefundRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRefundRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many REFUND REQUESTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RefundRequest>>> RefundRequests(
        [FromQuery] RefundRequestFindManyArgs filter
    )
    {
        return Ok(await _service.RefundRequests(filter));
    }

    /// <summary>
    ///     Meta data about REFUND REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RefundRequestsMeta(
        [FromQuery] RefundRequestFindManyArgs filter
    )
    {
        return Ok(await _service.RefundRequestsMeta(filter));
    }

    /// <summary>
    ///     Get one REFUND REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RefundRequest>> RefundRequest(
        [FromRoute] RefundRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RefundRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one REFUND REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRefundRequest(
        [FromRoute] RefundRequestWhereUniqueInput uniqueId,
        [FromQuery] RefundRequestUpdateInput refundRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateRefundRequest(uniqueId, refundRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
