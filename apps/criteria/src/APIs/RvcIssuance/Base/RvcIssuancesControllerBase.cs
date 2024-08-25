using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RvcIssuancesControllerBase : ControllerBase
{
    protected readonly IRvcIssuancesService _service;

    public RvcIssuancesControllerBase(IRvcIssuancesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one RVC Issuance
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RvcIssuance>> CreateRvcIssuance(RvcIssuanceCreateInput input)
    {
        var rvcIssuance = await _service.CreateRvcIssuance(input);

        return CreatedAtAction(nameof(RvcIssuance), new { id = rvcIssuance.Id }, rvcIssuance);
    }

    /// <summary>
    /// Delete one RVC Issuance
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRvcIssuance(
        [FromRoute()] RvcIssuanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRvcIssuance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many RVC Issuances
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RvcIssuance>>> RvcIssuances(
        [FromQuery()] RvcIssuanceFindManyArgs filter
    )
    {
        return Ok(await _service.RvcIssuances(filter));
    }

    /// <summary>
    /// Meta data about RVC Issuance records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RvcIssuancesMeta(
        [FromQuery()] RvcIssuanceFindManyArgs filter
    )
    {
        return Ok(await _service.RvcIssuancesMeta(filter));
    }

    /// <summary>
    /// Get one RVC Issuance
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RvcIssuance>> RvcIssuance(
        [FromRoute()] RvcIssuanceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RvcIssuance(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one RVC Issuance
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRvcIssuance(
        [FromRoute()] RvcIssuanceWhereUniqueInput uniqueId,
        [FromQuery()] RvcIssuanceUpdateInput rvcIssuanceUpdateDto
    )
    {
        try
        {
            await _service.UpdateRvcIssuance(uniqueId, rvcIssuanceUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
