using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DemandForRcoClresControllerBase : ControllerBase
{
    protected readonly IDemandForRcoClresService _service;

    public DemandForRcoClresControllerBase(IDemandForRcoClresService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Demand for RCO | CLRE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DemandForRcoClre>> CreateDemandForRcoClre(
        DemandForRcoClreCreateInput input
    )
    {
        var demandForRcoClre = await _service.CreateDemandForRcoClre(input);

        return CreatedAtAction(
            nameof(DemandForRcoClre),
            new { id = demandForRcoClre.Id },
            demandForRcoClre
        );
    }

    /// <summary>
    /// Delete one Demand for RCO | CLRE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDemandForRcoClre(
        [FromRoute()] DemandForRcoClreWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDemandForRcoClre(uniqueId);
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
    public async Task<ActionResult<List<DemandForRcoClre>>> DemandForRcoClres(
        [FromQuery()] DemandForRcoClreFindManyArgs filter
    )
    {
        return Ok(await _service.DemandForRcoClres(filter));
    }

    /// <summary>
    /// Meta data about Demand for RCO | CLRE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DemandForRcoClresMeta(
        [FromQuery()] DemandForRcoClreFindManyArgs filter
    )
    {
        return Ok(await _service.DemandForRcoClresMeta(filter));
    }

    /// <summary>
    /// Get one Demand for RCO | CLRE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DemandForRcoClre>> DemandForRcoClre(
        [FromRoute()] DemandForRcoClreWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DemandForRcoClre(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Demand for RCO | CLRE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDemandForRcoClre(
        [FromRoute()] DemandForRcoClreWhereUniqueInput uniqueId,
        [FromQuery()] DemandForRcoClreUpdateInput demandForRcoClreUpdateDto
    )
    {
        try
        {
            await _service.UpdateDemandForRcoClre(uniqueId, demandForRcoClreUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
