using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class DetailsOfTheApprovalOfTheRegimeRequestsControllerBase : ControllerBase
{
    protected readonly IDetailsOfTheApprovalOfTheRegimeRequestsService _service;

    public DetailsOfTheApprovalOfTheRegimeRequestsControllerBase(
        IDetailsOfTheApprovalOfTheRegimeRequestsService service
    )
    {
        _service = service;
    }

    /// <summary>
    ///     Create one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfTheApprovalOfTheRegimeRequest>
    > CreateDetailsOfTheApprovalOfTheRegimeRequest(
        DetailsOfTheApprovalOfTheRegimeRequestCreateInput input
    )
    {
        var detailsOfTheApprovalOfTheRegimeRequest =
            await _service.CreateDetailsOfTheApprovalOfTheRegimeRequest(input);

        return CreatedAtAction(
            nameof(DetailsOfTheApprovalOfTheRegimeRequest),
            new { id = detailsOfTheApprovalOfTheRegimeRequest.Id },
            detailsOfTheApprovalOfTheRegimeRequest
        );
    }

    /// <summary>
    ///     Delete one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailsOfTheApprovalOfTheRegimeRequest(
        [FromRoute] DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailsOfTheApprovalOfTheRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many details of the approval of the regime requests
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailsOfTheApprovalOfTheRegimeRequest>>
    > DetailsOfTheApprovalOfTheRegimeRequests(
        [FromQuery] DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfTheApprovalOfTheRegimeRequests(filter));
    }

    /// <summary>
    ///     Meta data about DETAIL OF THE APPROVAL OF THE REGIME REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailsOfTheApprovalOfTheRegimeRequestsMeta(
        [FromQuery] DetailsOfTheApprovalOfTheRegimeRequestFindManyArgs filter
    )
    {
        return Ok(await _service.DetailsOfTheApprovalOfTheRegimeRequestsMeta(filter));
    }

    /// <summary>
    ///     Get one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailsOfTheApprovalOfTheRegimeRequest>
    > DetailsOfTheApprovalOfTheRegimeRequest(
        [FromRoute] DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailsOfTheApprovalOfTheRegimeRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one DETAIL OF THE APPROVAL OF THE REGIME REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailsOfTheApprovalOfTheRegimeRequest(
        [FromRoute] DetailsOfTheApprovalOfTheRegimeRequestWhereUniqueInput uniqueId,
        [FromQuery] DetailsOfTheApprovalOfTheRegimeRequestUpdateInput detailsOfTheApprovalOfTheRegimeRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailsOfTheApprovalOfTheRegimeRequest(
                uniqueId,
                detailsOfTheApprovalOfTheRegimeRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
