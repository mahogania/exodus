using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class IssuancesControllerBase : ControllerBase
{
    protected readonly IIssuancesService _service;

    public IssuancesControllerBase(IIssuancesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ISSUANCE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Issuance>> CreateIssuance(IssuanceCreateInput input)
    {
        var issuance = await _service.CreateIssuance(input);

        return CreatedAtAction(nameof(Issuance), new { id = issuance.Id }, issuance);
    }

    /// <summary>
    /// Delete one ISSUANCE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteIssuance([FromRoute()] IssuanceWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteIssuance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ISSUANCES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Issuance>>> Issuances(
        [FromQuery()] IssuanceFindManyArgs filter
    )
    {
        return Ok(await _service.Issuances(filter));
    }

    /// <summary>
    /// Meta data about ISSUANCE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> IssuancesMeta(
        [FromQuery()] IssuanceFindManyArgs filter
    )
    {
        return Ok(await _service.IssuancesMeta(filter));
    }

    /// <summary>
    /// Get one ISSUANCE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Issuance>> Issuance(
        [FromRoute()] IssuanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Issuance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ISSUANCE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateIssuance(
        [FromRoute()] IssuanceWhereUniqueInput uniqueId,
        [FromQuery()] IssuanceUpdateInput issuanceUpdateDto
    )
    {
        try
        {
            await _service.UpdateIssuance(uniqueId, issuanceUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
