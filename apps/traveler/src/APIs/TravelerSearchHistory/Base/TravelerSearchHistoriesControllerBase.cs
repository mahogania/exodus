using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TravelerSearchHistoriesControllerBase : ControllerBase
{
    protected readonly ITravelerSearchHistoriesService _service;

    public TravelerSearchHistoriesControllerBase(ITravelerSearchHistoriesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TravelerSearchHistory
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TravelerSearchHistory>> CreateTravelerSearchHistory(
        TravelerSearchHistoryCreateInput input
    )
    {
        var travelerSearchHistory = await _service.CreateTravelerSearchHistory(input);

        return CreatedAtAction(
            nameof(TravelerSearchHistory),
            new { id = travelerSearchHistory.Id },
            travelerSearchHistory
        );
    }

    /// <summary>
    /// Delete one TravelerSearchHistory
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTravelerSearchHistory(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTravelerSearchHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TravelerSearchHistories
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TravelerSearchHistory>>> TravelerSearchHistories(
        [FromQuery()] TravelerSearchHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.TravelerSearchHistories(filter));
    }

    /// <summary>
    /// Meta data about TravelerSearchHistory records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TravelerSearchHistoriesMeta(
        [FromQuery()] TravelerSearchHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.TravelerSearchHistoriesMeta(filter));
    }

    /// <summary>
    /// Get one TravelerSearchHistory
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TravelerSearchHistory>> TravelerSearchHistory(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TravelerSearchHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TravelerSearchHistory
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTravelerSearchHistory(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId,
        [FromQuery()] TravelerSearchHistoryUpdateInput travelerSearchHistoryUpdateDto
    )
    {
        try
        {
            await _service.UpdateTravelerSearchHistory(uniqueId, travelerSearchHistoryUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TravelerSearchHistory
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId,
        [FromQuery()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.ConnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from TravelerSearchHistory
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.DisconnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId,
        [FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindGeneralTravelerInformationTpds(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for TravelerSearchHistory
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] TravelerSearchHistoryWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.UpdateGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
