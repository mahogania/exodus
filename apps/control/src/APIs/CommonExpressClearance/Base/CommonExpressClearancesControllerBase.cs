using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonExpressClearancesControllerBase : ControllerBase
{
    protected readonly ICommonExpressClearancesService _service;

    public CommonExpressClearancesControllerBase(ICommonExpressClearancesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Express Clearance
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonExpressClearance>> CreateCommonExpressClearance(
        CommonExpressClearanceCreateInput input
    )
    {
        var commonExpressClearance = await _service.CreateCommonExpressClearance(input);

        return CreatedAtAction(
            nameof(CommonExpressClearance),
            new { id = commonExpressClearance.Id },
            commonExpressClearance
        );
    }

    /// <summary>
    /// Delete one Common Express Clearance
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonExpressClearance(
        [FromRoute()] CommonExpressClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonExpressClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON EXPRESS CLEARANCES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonExpressClearance>>> CommonExpressClearances(
        [FromQuery()] CommonExpressClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.CommonExpressClearances(filter));
    }

    /// <summary>
    /// Meta data about Common Express Clearance records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonExpressClearancesMeta(
        [FromQuery()] CommonExpressClearanceFindManyArgs filter
    )
    {
        return Ok(await _service.CommonExpressClearancesMeta(filter));
    }

    /// <summary>
    /// Get one Common Express Clearance
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonExpressClearance>> CommonExpressClearance(
        [FromRoute()] CommonExpressClearanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonExpressClearance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Express Clearance
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonExpressClearance(
        [FromRoute()] CommonExpressClearanceWhereUniqueInput uniqueId,
        [FromQuery()] CommonExpressClearanceUpdateInput commonExpressClearanceUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonExpressClearance(uniqueId, commonExpressClearanceUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
