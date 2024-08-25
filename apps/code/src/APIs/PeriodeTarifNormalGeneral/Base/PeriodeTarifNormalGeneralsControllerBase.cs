using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PeriodeTarifNormalGeneralsControllerBase : ControllerBase
{
    protected readonly IPeriodeTarifNormalGeneralsService _service;

    public PeriodeTarifNormalGeneralsControllerBase(IPeriodeTarifNormalGeneralsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one PeriodeTarifNormalGeneral
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PeriodeTarifNormalGeneral>> CreatePeriodeTarifNormalGeneral(
        PeriodeTarifNormalGeneralCreateInput input
    )
    {
        var periodeTarifNormalGeneral = await _service.CreatePeriodeTarifNormalGeneral(input);

        return CreatedAtAction(
            nameof(PeriodeTarifNormalGeneral),
            new { id = periodeTarifNormalGeneral.Id },
            periodeTarifNormalGeneral
        );
    }

    /// <summary>
    /// Delete one PeriodeTarifNormalGeneral
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePeriodeTarifNormalGeneral(
        [FromRoute()] PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePeriodeTarifNormalGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PeriodeTarifNormalGenerals
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PeriodeTarifNormalGeneral>>> PeriodeTarifNormalGenerals(
        [FromQuery()] PeriodeTarifNormalGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.PeriodeTarifNormalGenerals(filter));
    }

    /// <summary>
    /// Meta data about PeriodeTarifNormalGeneral records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PeriodeTarifNormalGeneralsMeta(
        [FromQuery()] PeriodeTarifNormalGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.PeriodeTarifNormalGeneralsMeta(filter));
    }

    /// <summary>
    /// Get one PeriodeTarifNormalGeneral
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PeriodeTarifNormalGeneral>> PeriodeTarifNormalGeneral(
        [FromRoute()] PeriodeTarifNormalGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PeriodeTarifNormalGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PeriodeTarifNormalGeneral
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePeriodeTarifNormalGeneral(
        [FromRoute()] PeriodeTarifNormalGeneralWhereUniqueInput uniqueId,
        [FromQuery()] PeriodeTarifNormalGeneralUpdateInput periodeTarifNormalGeneralUpdateDto
    )
    {
        try
        {
            await _service.UpdatePeriodeTarifNormalGeneral(
                uniqueId,
                periodeTarifNormalGeneralUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
