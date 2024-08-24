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
    /// Create one Temporary Admission Of Vehicle
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
    /// Delete one Temporary Admission Of Vehicle
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
    /// Meta data about Temporary Admission Of Vehicle records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TemporaryAdmissionOfVehiclesMeta(
        [FromQuery()] TemporaryAdmissionOfVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.TemporaryAdmissionOfVehiclesMeta(filter));
    }

    /// <summary>
    /// Get one Temporary Admission Of Vehicle
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
    /// Update one Temporary Admission Of Vehicle
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
