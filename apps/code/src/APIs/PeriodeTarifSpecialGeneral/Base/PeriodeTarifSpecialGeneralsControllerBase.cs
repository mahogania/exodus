using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PeriodeTarifSpecialGeneralsControllerBase : ControllerBase
{
    protected readonly IPeriodeTarifSpecialGeneralsService _service;

    public PeriodeTarifSpecialGeneralsControllerBase(IPeriodeTarifSpecialGeneralsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one PeriodeTarifSpecialGeneral
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PeriodeTarifSpecialGeneral>> CreatePeriodeTarifSpecialGeneral(
        PeriodeTarifSpecialGeneralCreateInput input
    )
    {
        var periodeTarifSpecialGeneral = await _service.CreatePeriodeTarifSpecialGeneral(input);

        return CreatedAtAction(
            nameof(PeriodeTarifSpecialGeneral),
            new { id = periodeTarifSpecialGeneral.Id },
            periodeTarifSpecialGeneral
        );
    }

    /// <summary>
    /// Delete one PeriodeTarifSpecialGeneral
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePeriodeTarifSpecialGeneral(
        [FromRoute()] PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePeriodeTarifSpecialGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PeriodeTarifSpecialGenerals
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PeriodeTarifSpecialGeneral>>> PeriodeTarifSpecialGenerals(
        [FromQuery()] PeriodeTarifSpecialGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.PeriodeTarifSpecialGenerals(filter));
    }

    /// <summary>
    /// Meta data about PeriodeTarifSpecialGeneral records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PeriodeTarifSpecialGeneralsMeta(
        [FromQuery()] PeriodeTarifSpecialGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.PeriodeTarifSpecialGeneralsMeta(filter));
    }

    /// <summary>
    /// Get one PeriodeTarifSpecialGeneral
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PeriodeTarifSpecialGeneral>> PeriodeTarifSpecialGeneral(
        [FromRoute()] PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PeriodeTarifSpecialGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PeriodeTarifSpecialGeneral
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePeriodeTarifSpecialGeneral(
        [FromRoute()] PeriodeTarifSpecialGeneralWhereUniqueInput uniqueId,
        [FromQuery()] PeriodeTarifSpecialGeneralUpdateInput periodeTarifSpecialGeneralUpdateDto
    )
    {
        try
        {
            await _service.UpdatePeriodeTarifSpecialGeneral(
                uniqueId,
                periodeTarifSpecialGeneralUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
