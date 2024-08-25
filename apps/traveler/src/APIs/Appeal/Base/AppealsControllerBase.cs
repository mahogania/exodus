using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AppealsControllerBase : ControllerBase
{
    protected readonly IAppealsService _service;

    public AppealsControllerBase(IAppealsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Appeal
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> CreateAppeal(AppealCreateInput input)
    {
        var appeal = await _service.CreateAppeal(input);

        return CreatedAtAction(nameof(Appeal), new { id = appeal.Id }, appeal);
    }

    /// <summary>
    /// Delete one Appeal
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAppeal([FromRoute()] AppealWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteAppeal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Appeals
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Appeal>>> Appeals([FromQuery()] AppealFindManyArgs filter)
    {
        return Ok(await _service.Appeals(filter));
    }

    /// <summary>
    /// Meta data about Appeal records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AppealsMeta(
        [FromQuery()] AppealFindManyArgs filter
    )
    {
        return Ok(await _service.AppealsMeta(filter));
    }

    /// <summary>
    /// Get one Appeal
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> Appeal([FromRoute()] AppealWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Appeal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Appeal
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAppeal(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromQuery()] AppealUpdateInput appealUpdateDto
    )
    {
        try
        {
            await _service.UpdateAppeal(uniqueId, appealUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a General Bond Note record for Appeal
    /// </summary>
    [HttpGet("{Id}/generalBondNotes")]
    public async Task<ActionResult<List<GeneralBondNote>>> GetGeneralBondNote(
        [FromRoute()] AppealWhereUniqueInput uniqueId
    )
    {
        var generalBondNote = await _service.GetGeneralBondNote(uniqueId);
        return Ok(generalBondNote);
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to Appeal
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from Appeal
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for Appeal
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
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
