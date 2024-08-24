using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InspectorRatingModificationHistoriesControllerBase : ControllerBase
{
    protected readonly IInspectorRatingModificationHistoriesService _service;

    public InspectorRatingModificationHistoriesControllerBase(
        IInspectorRatingModificationHistoriesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one InspectorRatingModificationHistory
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingModificationHistory>
    > CreateInspectorRatingModificationHistory(InspectorRatingModificationHistoryCreateInput input)
    {
        var inspectorRatingModificationHistory =
            await _service.CreateInspectorRatingModificationHistory(input);

        return CreatedAtAction(
            nameof(InspectorRatingModificationHistory),
            new { id = inspectorRatingModificationHistory.Id },
            inspectorRatingModificationHistory
        );
    }

    /// <summary>
    /// Delete one InspectorRatingModificationHistory
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInspectorRatingModificationHistory(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInspectorRatingModificationHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many InspectorRatingModificationHistories
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InspectorRatingModificationHistory>>
    > InspectorRatingModificationHistories(
        [FromQuery()] InspectorRatingModificationHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingModificationHistories(filter));
    }

    /// <summary>
    /// Meta data about InspectorRatingModificationHistory records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InspectorRatingModificationHistoriesMeta(
        [FromQuery()] InspectorRatingModificationHistoryFindManyArgs filter
    )
    {
        return Ok(await _service.InspectorRatingModificationHistoriesMeta(filter));
    }

    /// <summary>
    /// Get one InspectorRatingModificationHistory
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InspectorRatingModificationHistory>
    > InspectorRatingModificationHistory(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InspectorRatingModificationHistory(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one InspectorRatingModificationHistory
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInspectorRatingModificationHistory(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
        [FromQuery()]
            InspectorRatingModificationHistoryUpdateInput inspectorRatingModificationHistoryUpdateDto
    )
    {
        try
        {
            await _service.UpdateInspectorRatingModificationHistory(
                uniqueId,
                inspectorRatingModificationHistoryUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to InspectorRatingModificationHistory
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from InspectorRatingModificationHistory
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for InspectorRatingModificationHistory
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] InspectorRatingModificationHistoryWhereUniqueInput uniqueId,
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
