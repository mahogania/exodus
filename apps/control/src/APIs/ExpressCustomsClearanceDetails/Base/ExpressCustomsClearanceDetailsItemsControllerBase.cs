using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExpressCustomsClearanceDetailsItemsControllerBase : ControllerBase
{
    protected readonly IExpressCustomsClearanceDetailsItemsService _service;

    public ExpressCustomsClearanceDetailsItemsControllerBase(
        IExpressCustomsClearanceDetailsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Express Customs Clearance Detail
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ExpressCustomsClearanceDetails>
    > CreateExpressCustomsClearanceDetails(ExpressCustomsClearanceDetailsCreateInput input)
    {
        var expressCustomsClearanceDetails = await _service.CreateExpressCustomsClearanceDetails(
            input
        );

        return CreatedAtAction(
            nameof(ExpressCustomsClearanceDetails),
            new { id = expressCustomsClearanceDetails.Id },
            expressCustomsClearanceDetails
        );
    }

    /// <summary>
    /// Delete one Express Customs Clearance Detail
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExpressCustomsClearanceDetails(
        [FromRoute()] ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteExpressCustomsClearanceDetails(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Express Customs Clearance Details
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ExpressCustomsClearanceDetails>>
    > ExpressCustomsClearanceDetailsItems(
        [FromQuery()] ExpressCustomsClearanceDetailsFindManyArgs filter
    )
    {
        return Ok(await _service.ExpressCustomsClearanceDetailsItems(filter));
    }

    /// <summary>
    /// Meta data about Express Customs Clearance Detail records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExpressCustomsClearanceDetailsItemsMeta(
        [FromQuery()] ExpressCustomsClearanceDetailsFindManyArgs filter
    )
    {
        return Ok(await _service.ExpressCustomsClearanceDetailsItemsMeta(filter));
    }

    /// <summary>
    /// Get one Express Customs Clearance Detail
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ExpressCustomsClearanceDetails>> ExpressCustomsClearanceDetails(
        [FromRoute()] ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ExpressCustomsClearanceDetails(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Express Customs Clearance Detail
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExpressCustomsClearanceDetails(
        [FromRoute()] ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId,
        [FromQuery()]
            ExpressCustomsClearanceDetailsUpdateInput expressCustomsClearanceDetailsUpdateDto
    )
    {
        try
        {
            await _service.UpdateExpressCustomsClearanceDetails(
                uniqueId,
                expressCustomsClearanceDetailsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a COMMON EXPRESS CLEARANCE record for EXPRESS CUSTOMS CLEARANCE DETAILS
    /// </summary>
    [HttpGet("{Id}/commonExpressClearances")]
    public async Task<ActionResult<List<CommonExpressClearance>>> GetCommonExpressClearance(
        [FromRoute()] ExpressCustomsClearanceDetailsWhereUniqueInput uniqueId
    )
    {
        var commonExpressClearance = await _service.GetCommonExpressClearance(uniqueId);
        return Ok(commonExpressClearance);
    }
}
