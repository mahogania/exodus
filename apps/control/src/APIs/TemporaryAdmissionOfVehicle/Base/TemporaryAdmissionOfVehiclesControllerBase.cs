using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TemporaryAdmissionOfVehiclesControllerBase : ControllerBase
{
    protected readonly ITemporaryAdmissionOfVehiclesService _service;

    public TemporaryAdmissionOfVehiclesControllerBase(ITemporaryAdmissionOfVehiclesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TemporaryAdmissionOfVehicle>> CreateTemporaryAdmissionOfVehicle(
        TemporaryAdmissionOfVehicleCreateInput input
    )
    {
        var temporaryAdmissionOfVehicle = await _service.CreateTemporaryAdmissionOfVehicle(input);

        return CreatedAtAction(
            nameof(TemporaryAdmissionOfVehicle),
            new { id = temporaryAdmissionOfVehicle.Id },
            temporaryAdmissionOfVehicle
        );
    }

    /// <summary>
    /// Delete one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTemporaryAdmissionOfVehicle(
        [FromRoute()] TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTemporaryAdmissionOfVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TEMPORARY ADMISSION OF VEHICLES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TemporaryAdmissionOfVehicle>>> TemporaryAdmissionOfVehicles(
        [FromQuery()] TemporaryAdmissionOfVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.TemporaryAdmissionOfVehicles(filter));
    }

    /// <summary>
    /// Meta data about TEMPORARY ADMISSION OF VEHICLE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TemporaryAdmissionOfVehiclesMeta(
        [FromQuery()] TemporaryAdmissionOfVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.TemporaryAdmissionOfVehiclesMeta(filter));
    }

    /// <summary>
    /// Get one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TemporaryAdmissionOfVehicle>> TemporaryAdmissionOfVehicle(
        [FromRoute()] TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TemporaryAdmissionOfVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TEMPORARY ADMISSION OF VEHICLE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTemporaryAdmissionOfVehicle(
        [FromRoute()] TemporaryAdmissionOfVehicleWhereUniqueInput uniqueId,
        [FromQuery()] TemporaryAdmissionOfVehicleUpdateInput temporaryAdmissionOfVehicleUpdateDto
    )
    {
        try
        {
            await _service.UpdateTemporaryAdmissionOfVehicle(
                uniqueId,
                temporaryAdmissionOfVehicleUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
