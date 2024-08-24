using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ItinerariesControllerBase : ControllerBase
{
    protected readonly IItinerariesService _service;

    public ItinerariesControllerBase(IItinerariesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Itinerary
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Itinerary>> CreateItinerary(ItineraryCreateInput input)
    {
        var itinerary = await _service.CreateItinerary(input);

        return CreatedAtAction(nameof(Itinerary), new { id = itinerary.Id }, itinerary);
    }

    /// <summary>
    /// Delete one Itinerary
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteItinerary(
        [FromRoute()] ItineraryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteItinerary(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TEXT ZONES FOR SPECIFYING THE ITIRENARY
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Itinerary>>> Itineraries(
        [FromQuery()] ItineraryFindManyArgs filter
    )
    {
        return Ok(await _service.Itineraries(filter));
    }

    /// <summary>
    /// Meta data about Itinerary records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ItinerariesMeta(
        [FromQuery()] ItineraryFindManyArgs filter
    )
    {
        return Ok(await _service.ItinerariesMeta(filter));
    }

    /// <summary>
    /// Get one Itinerary
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Itinerary>> Itinerary(
        [FromRoute()] ItineraryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Itinerary(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Itinerary
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateItinerary(
        [FromRoute()] ItineraryWhereUniqueInput uniqueId,
        [FromQuery()] ItineraryUpdateInput itineraryUpdateDto
    )
    {
        try
        {
            await _service.UpdateItinerary(uniqueId, itineraryUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
