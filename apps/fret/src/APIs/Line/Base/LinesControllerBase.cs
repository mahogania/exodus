using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class LinesControllerBase : ControllerBase
{
    protected readonly ILinesService _service;

    public LinesControllerBase(ILinesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Ligne
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Line>> CreateLine(LineCreateInput input)
    {
        var line = await _service.CreateLine(input);

        return CreatedAtAction(nameof(Line), new { id = line.Id }, line);
    }

    /// <summary>
    /// Delete one Ligne
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteLine([FromRoute()] LineWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteLine(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Lines
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Line>>> Lines([FromQuery()] LineFindManyArgs filter)
    {
        return Ok(await _service.Lines(filter));
    }

    /// <summary>
    /// Meta data about Ligne records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> LinesMeta([FromQuery()] LineFindManyArgs filter)
    {
        return Ok(await _service.LinesMeta(filter));
    }

    /// <summary>
    /// Get one Ligne
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Line>> Line([FromRoute()] LineWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Line(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Ligne
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateLine(
        [FromRoute()] LineWhereUniqueInput uniqueId,
        [FromQuery()] LineUpdateInput lineUpdateDto
    )
    {
        try
        {
            await _service.UpdateLine(uniqueId, lineUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
