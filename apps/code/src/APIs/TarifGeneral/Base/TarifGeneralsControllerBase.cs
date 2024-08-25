using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TarifGeneralsControllerBase : ControllerBase
{
    protected readonly ITarifGeneralsService _service;

    public TarifGeneralsControllerBase(ITarifGeneralsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TarifGeneral
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TarifGeneral>> CreateTarifGeneral(TarifGeneralCreateInput input)
    {
        var tarifGeneral = await _service.CreateTarifGeneral(input);

        return CreatedAtAction(nameof(TarifGeneral), new { id = tarifGeneral.Id }, tarifGeneral);
    }

    /// <summary>
    /// Delete one TarifGeneral
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTarifGeneral(
        [FromRoute()] TarifGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTarifGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TarifGenerals
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TarifGeneral>>> TarifGenerals(
        [FromQuery()] TarifGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.TarifGenerals(filter));
    }

    /// <summary>
    /// Meta data about TarifGeneral records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TarifGeneralsMeta(
        [FromQuery()] TarifGeneralFindManyArgs filter
    )
    {
        return Ok(await _service.TarifGeneralsMeta(filter));
    }

    /// <summary>
    /// Get one TarifGeneral
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TarifGeneral>> TarifGeneral(
        [FromRoute()] TarifGeneralWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TarifGeneral(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TarifGeneral
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTarifGeneral(
        [FromRoute()] TarifGeneralWhereUniqueInput uniqueId,
        [FromQuery()] TarifGeneralUpdateInput tarifGeneralUpdateDto
    )
    {
        try
        {
            await _service.UpdateTarifGeneral(uniqueId, tarifGeneralUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
