using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TextZoneForSpecifyingTheItinerariesControllerBase : ControllerBase
{
    protected readonly ITextZoneForSpecifyingTheItinerariesService _service;

    public TextZoneForSpecifyingTheItinerariesControllerBase(
        ITextZoneForSpecifyingTheItinerariesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<TextZoneForSpecifyingTheItinerary>
    > CreateTextZoneForSpecifyingTheItinerary(TextZoneForSpecifyingTheItineraryCreateInput input)
    {
        var textZoneForSpecifyingTheItinerary =
            await _service.CreateTextZoneForSpecifyingTheItinerary(input);

        return CreatedAtAction(
            nameof(TextZoneForSpecifyingTheItinerary),
            new { id = textZoneForSpecifyingTheItinerary.Id },
            textZoneForSpecifyingTheItinerary
        );
    }

    /// <summary>
    /// Delete one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTextZoneForSpecifyingTheItinerary(
        [FromRoute()] TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTextZoneForSpecifyingTheItinerary(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Text zone for specifying the itineraries
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<TextZoneForSpecifyingTheItinerary>>
    > TextZoneForSpecifyingTheItineraries(
        [FromQuery()] TextZoneForSpecifyingTheItineraryFindManyArgs filter
    )
    {
        return Ok(await _service.TextZoneForSpecifyingTheItineraries(filter));
    }

    /// <summary>
    /// Meta data about TEXT ZONE FOR SPECIFYING THE ITIRENARY records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TextZoneForSpecifyingTheItinerariesMeta(
        [FromQuery()] TextZoneForSpecifyingTheItineraryFindManyArgs filter
    )
    {
        return Ok(await _service.TextZoneForSpecifyingTheItinerariesMeta(filter));
    }

    /// <summary>
    /// Get one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<TextZoneForSpecifyingTheItinerary>
    > TextZoneForSpecifyingTheItinerary(
        [FromRoute()] TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TextZoneForSpecifyingTheItinerary(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TEXT ZONE FOR SPECIFYING THE ITIRENARY
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTextZoneForSpecifyingTheItinerary(
        [FromRoute()] TextZoneForSpecifyingTheItineraryWhereUniqueInput uniqueId,
        [FromQuery()]
            TextZoneForSpecifyingTheItineraryUpdateInput textZoneForSpecifyingTheItineraryUpdateDto
    )
    {
        try
        {
            await _service.UpdateTextZoneForSpecifyingTheItinerary(
                uniqueId,
                textZoneForSpecifyingTheItineraryUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
