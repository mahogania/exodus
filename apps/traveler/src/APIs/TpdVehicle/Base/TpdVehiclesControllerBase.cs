using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TpdVehiclesControllerBase : ControllerBase
{
    protected readonly ITpdVehiclesService _service;

    public TpdVehiclesControllerBase(ITpdVehiclesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TpdVehicle
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdVehicle>> CreateTpdVehicle(TpdVehicleCreateInput input)
    {
        var tpdVehicle = await _service.CreateTpdVehicle(input);

        return CreatedAtAction(nameof(TpdVehicle), new { id = tpdVehicle.Id }, tpdVehicle);
    }

    /// <summary>
    /// Delete one TpdVehicle
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTpdVehicle(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTpdVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TpdVehicles
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TpdVehicle>>> TpdVehicles(
        [FromQuery()] TpdVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.TpdVehicles(filter));
    }

    /// <summary>
    /// Meta data about TpdVehicle records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TpdVehiclesMeta(
        [FromQuery()] TpdVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.TpdVehiclesMeta(filter));
    }

    /// <summary>
    /// Get one TpdVehicle
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdVehicle>> TpdVehicle(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TpdVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TpdVehicle
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTpdVehicle(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId,
        [FromQuery()] TpdVehicleUpdateInput tpdVehicleUpdateDto
    )
    {
        try
        {
            await _service.UpdateTpdVehicle(uniqueId, tpdVehicleUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdVehicle
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdVehicle
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for TpdVehicle
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] TpdVehicleWhereUniqueInput uniqueId,
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
