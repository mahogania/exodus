using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExtendedPeriodCarnetRequestsControllerBase : ControllerBase
{
    protected readonly IExtendedPeriodCarnetRequestsService _service;

    public ExtendedPeriodCarnetRequestsControllerBase(IExtendedPeriodCarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Extended Period Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExtendedPeriodCarnetRequest>> CreateExtendedPeriodCarnetRequest(
        ExtendedPeriodCarnetRequestCreateInput input
    )
    {
        var extendedPeriodCarnetRequest = await _service.CreateExtendedPeriodCarnetRequest(input);

        return CreatedAtAction(
            nameof(ExtendedPeriodCarnetRequest),
            new { id = extendedPeriodCarnetRequest.Id },
            extendedPeriodCarnetRequest
        );
    }

    /// <summary>
    /// Delete one Extended Period Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExtendedPeriodCarnetRequest(
        [FromRoute()] ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExtendedPeriodCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Extended Period Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ExtendedPeriodCarnetRequest>>> ExtendedPeriodCarnetRequests(
        [FromQuery()] ExtendedPeriodCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ExtendedPeriodCarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Extended Period Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExtendedPeriodCarnetRequestsMeta(
        [FromQuery()] ExtendedPeriodCarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.ExtendedPeriodCarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Extended Period Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExtendedPeriodCarnetRequest>> ExtendedPeriodCarnetRequest(
        [FromRoute()] ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExtendedPeriodCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Extended Period Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExtendedPeriodCarnetRequest(
        [FromRoute()] ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] ExtendedPeriodCarnetRequestUpdateInput extendedPeriodCarnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateExtendedPeriodCarnetRequest(
                uniqueId,
                extendedPeriodCarnetRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Carnet Request record for Extended Period Carnet Request
    /// </summary>
    [HttpGet("{Id}/commonCarnetRequests")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> GetCommonCarnetRequest(
        [FromRoute()] ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequest = await _service.GetCommonCarnetRequest(uniqueId);
        return Ok(commonCarnetRequest);
    }

    /// <summary>
    /// Get a Extended Period Carnet Control record for Extended Period Carnet Request
    /// </summary>
    [HttpGet("{Id}/extendedPeriodCarnetControls")]
    public async Task<
        ActionResult<List<ExtendedPeriodCarnetControl>>
    > GetExtendedPeriodCarnetControl(
        [FromRoute()] ExtendedPeriodCarnetRequestWhereUniqueInput uniqueId
    )
    {
        var extendedPeriodCarnetControl = await _service.GetExtendedPeriodCarnetControl(uniqueId);
        return Ok(extendedPeriodCarnetControl);
    }
}
