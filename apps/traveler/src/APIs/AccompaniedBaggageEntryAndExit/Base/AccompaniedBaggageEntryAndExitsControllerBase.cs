using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AccompaniedBaggageEntryAndExitsControllerBase : ControllerBase
{
    protected readonly IAccompaniedBaggageEntryAndExitsService _service;

    public AccompaniedBaggageEntryAndExitsControllerBase(
        IAccompaniedBaggageEntryAndExitsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<AccompaniedBaggageEntryAndExit>
    > CreateAccompaniedBaggageEntryAndExit(AccompaniedBaggageEntryAndExitCreateInput input)
    {
        var accompaniedBaggageEntryAndExit = await _service.CreateAccompaniedBaggageEntryAndExit(
            input
        );

        return CreatedAtAction(
            nameof(AccompaniedBaggageEntryAndExit),
            new { id = accompaniedBaggageEntryAndExit.Id },
            accompaniedBaggageEntryAndExit
        );
    }

    /// <summary>
    /// Delete one AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAccompaniedBaggageEntryAndExit(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAccompaniedBaggageEntryAndExit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many AccompaniedBaggageEntryAndExits
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<AccompaniedBaggageEntryAndExit>>
    > AccompaniedBaggageEntryAndExits(
        [FromQuery()] AccompaniedBaggageEntryAndExitFindManyArgs filter
    )
    {
        return Ok(await _service.AccompaniedBaggageEntryAndExits(filter));
    }

    /// <summary>
    /// Meta data about AccompaniedBaggageEntryAndExit records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AccompaniedBaggageEntryAndExitsMeta(
        [FromQuery()] AccompaniedBaggageEntryAndExitFindManyArgs filter
    )
    {
        return Ok(await _service.AccompaniedBaggageEntryAndExitsMeta(filter));
    }

    /// <summary>
    /// Get one AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AccompaniedBaggageEntryAndExit>> AccompaniedBaggageEntryAndExit(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AccompaniedBaggageEntryAndExit(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAccompaniedBaggageEntryAndExit(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
        [FromQuery()]
            AccompaniedBaggageEntryAndExitUpdateInput accompaniedBaggageEntryAndExitUpdateDto
    )
    {
        try
        {
            await _service.UpdateAccompaniedBaggageEntryAndExit(
                uniqueId,
                accompaniedBaggageEntryAndExitUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for AccompaniedBaggageEntryAndExit
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] AccompaniedBaggageEntryAndExitWhereUniqueInput uniqueId,
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
