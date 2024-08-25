using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PaysPreferentielsControllerBase : ControllerBase
{
    protected readonly IPaysPreferentielsService _service;

    public PaysPreferentielsControllerBase(IPaysPreferentielsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one PaysPreferentiel
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PaysPreferentiel>> CreatePaysPreferentiel(
        PaysPreferentielCreateInput input
    )
    {
        var paysPreferentiel = await _service.CreatePaysPreferentiel(input);

        return CreatedAtAction(
            nameof(PaysPreferentiel),
            new { id = paysPreferentiel.Id },
            paysPreferentiel
        );
    }

    /// <summary>
    /// Delete one PaysPreferentiel
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePaysPreferentiel(
        [FromRoute()] PaysPreferentielWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePaysPreferentiel(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PaysPreferentiels
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<PaysPreferentiel>>> PaysPreferentiels(
        [FromQuery()] PaysPreferentielFindManyArgs filter
    )
    {
        return Ok(await _service.PaysPreferentiels(filter));
    }

    /// <summary>
    /// Meta data about PaysPreferentiel records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PaysPreferentielsMeta(
        [FromQuery()] PaysPreferentielFindManyArgs filter
    )
    {
        return Ok(await _service.PaysPreferentielsMeta(filter));
    }

    /// <summary>
    /// Get one PaysPreferentiel
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PaysPreferentiel>> PaysPreferentiel(
        [FromRoute()] PaysPreferentielWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PaysPreferentiel(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PaysPreferentiel
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePaysPreferentiel(
        [FromRoute()] PaysPreferentielWhereUniqueInput uniqueId,
        [FromQuery()] PaysPreferentielUpdateInput paysPreferentielUpdateDto
    )
    {
        try
        {
            await _service.UpdatePaysPreferentiel(uniqueId, paysPreferentielUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
