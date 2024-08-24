using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailOfTheApprovalOfTheRegimeRequestsControllerBase : ControllerBase
{
    protected readonly IDetailOfTheApprovalOfTheRegimeRequestsService _service;

    public DetailOfTheApprovalOfTheRegimeRequestsControllerBase(
        IDetailOfTheApprovalOfTheRegimeRequestsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Detail of the approval of the Regime Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfTheApprovalOfTheRegimeRequest>
    > CreateDetailOfTheApprovalOfTheRegimeRequest(
        DetailOfTheApprovalOfTheRegimeRequestCreateInput input
    )
    {
        var detailOfTheApprovalOfTheRegimeRequest =
            await _service.CreateDetailOfTheApprovalOfTheRegimeRequest(input);

        return CreatedAtAction(
            nameof(DetailOfTheApprovalOfTheRegimeRequest),
            new { id = detailOfTheApprovalOfTheRegimeRequest.Id },
            detailOfTheApprovalOfTheRegimeRequest
        );
    }

    /// <summary>
    /// Delete one Detail of the approval of the Regime Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailOfTheApprovalOfTheRegimeRequest(
        [FromRoute()] DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailOfTheApprovalOfTheRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Details of the approval of the Regime Request
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailOfTheApprovalOfTheRegimeRequest>>
    > DetailOfTheApprovalOfTheRegimeRequests(
        [FromQuery()] DetailOfTheApprovalOfTheRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfTheApprovalOfTheRegimeRequests(filter));
    }

    /// <summary>
    /// Meta data about Detail of the approval of the Regime Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailOfTheApprovalOfTheRegimeRequestsMeta(
        [FromQuery()] DetailOfTheApprovalOfTheRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfTheApprovalOfTheRegimeRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Detail of the approval of the Regime Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfTheApprovalOfTheRegimeRequest>
    > DetailOfTheApprovalOfTheRegimeRequest(
        [FromRoute()] DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailOfTheApprovalOfTheRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Detail of the approval of the Regime Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailOfTheApprovalOfTheRegimeRequest(
        [FromRoute()] DetailOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailOfTheApprovalOfTheRegimeRequestUpdateInput detailOfTheApprovalOfTheRegimeRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailOfTheApprovalOfTheRegimeRequest(
                uniqueId,
                detailOfTheApprovalOfTheRegimeRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
