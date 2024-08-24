using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RcoDemandsControllerBase : ControllerBase
{
    protected readonly IRcoDemandsService _service;

    public RcoDemandsControllerBase(IRcoDemandsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one RCO Demand
    /// </summary>
    [HttpPost()]
    public async Task<ActionResult<RCODemand>> CreateRcoDemand(RCODemandCreateInput input)
    {
        var rcoDemand = await _service.CreateRCODemand(input);

        return CreatedAtAction(nameof(RCODemand), new { id = rcoDemand.Id }, rcoDemand);
    }

    /// <summary>
    /// Delete one RCO Demand
    /// </summary>
    [HttpDelete("{Id}")]
    public async Task<ActionResult> DeleteRcoDemand(
        [FromRoute()] RCODemandWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRcoDemand(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Demand for RCO | CLRES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RCODemand>>> RcoDemands(
        [FromQuery()] RCODemandFindManyArgs filter
    )
    {
        return Ok(await _service.RcoDemands(filter));
    }

    /// <summary>
    /// Meta data about RCO Demand records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RcoDemandsMeta(
        [FromQuery()] RCODemandFindManyArgs filter
    )
    {
        return Ok(await _service.RcoDemandsMeta(filter));
    }

    /// <summary>
    /// Get one RCO Demand
    /// </summary>
    [HttpGet("{Id}")]
    public async Task<ActionResult<RCODemand>> RcoDemand(
        [FromRoute()] RCODemandWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RCODemand(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one RCO Demand
    /// </summary>
    [HttpPatch("{Id}")]
    public async Task<ActionResult> UpdateRcoDemand(
        [FromRoute()] RCODemandWhereUniqueInput uniqueId,
        [FromQuery()] RCODemandUpdateInput rcoDemandUpdateDto
    )
    {
        try
        {
            await _service.UpdateRcoDemand(uniqueId, rcoDemandUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
