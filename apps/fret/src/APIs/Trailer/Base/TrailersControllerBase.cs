using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TrailersControllerBase : ControllerBase
{
    protected readonly ITrailersService _service;

    public TrailersControllerBase(ITrailersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Remorque
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Trailer>> CreateTrailer(TrailerCreateInput input)
    {
        var trailer = await _service.CreateTrailer(input);

        return CreatedAtAction(nameof(Trailer), new { id = trailer.Id }, trailer);
    }

    /// <summary>
    /// Delete one Remorque
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTrailer([FromRoute()] TrailerWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteTrailer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Trailers
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Trailer>>> Trailers(
        [FromQuery()] TrailerFindManyArgs filter
    )
    {
        return Ok(await _service.Trailers(filter));
    }

    /// <summary>
    /// Meta data about Remorque records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TrailersMeta(
        [FromQuery()] TrailerFindManyArgs filter
    )
    {
        return Ok(await _service.TrailersMeta(filter));
    }

    /// <summary>
    /// Get one Remorque
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Trailer>> Trailer([FromRoute()] TrailerWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Trailer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Remorque
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTrailer(
        [FromRoute()] TrailerWhereUniqueInput uniqueId,
        [FromQuery()] TrailerUpdateInput trailerUpdateDto
    )
    {
        try
        {
            await _service.UpdateTrailer(uniqueId, trailerUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
