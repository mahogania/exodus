using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ValeurBoursieresControllerBase : ControllerBase
{
    protected readonly IValeurBoursieresService _service;

    public ValeurBoursieresControllerBase(IValeurBoursieresService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ValeurBoursiere
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValeurBoursiere>> CreateValeurBoursiere(
        ValeurBoursiereCreateInput input
    )
    {
        var valeurBoursiere = await _service.CreateValeurBoursiere(input);

        return CreatedAtAction(
            nameof(ValeurBoursiere),
            new { id = valeurBoursiere.Id },
            valeurBoursiere
        );
    }

    /// <summary>
    /// Delete one ValeurBoursiere
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteValeurBoursiere(
        [FromRoute()] ValeurBoursiereWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteValeurBoursiere(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ValeurBoursieres
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ValeurBoursiere>>> ValeurBoursieres(
        [FromQuery()] ValeurBoursiereFindManyArgs filter
    )
    {
        return Ok(await _service.ValeurBoursieres(filter));
    }

    /// <summary>
    /// Meta data about ValeurBoursiere records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ValeurBoursieresMeta(
        [FromQuery()] ValeurBoursiereFindManyArgs filter
    )
    {
        return Ok(await _service.ValeurBoursieresMeta(filter));
    }

    /// <summary>
    /// Get one ValeurBoursiere
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValeurBoursiere>> ValeurBoursiere(
        [FromRoute()] ValeurBoursiereWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ValeurBoursiere(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ValeurBoursiere
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateValeurBoursiere(
        [FromRoute()] ValeurBoursiereWhereUniqueInput uniqueId,
        [FromQuery()] ValeurBoursiereUpdateInput valeurBoursiereUpdateDto
    )
    {
        try
        {
            await _service.UpdateValeurBoursiere(uniqueId, valeurBoursiereUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
