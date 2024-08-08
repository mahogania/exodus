using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class VehiclesControllerBase : ControllerBase
{
    protected readonly IVehiclesService _service;

    public VehiclesControllerBase(IVehiclesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Vehicule
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Vehicle>> CreateVehicle(VehicleCreateInput input)
    {
        var vehicle = await _service.CreateVehicle(input);

        return CreatedAtAction(nameof(Vehicle), new { id = vehicle.Id }, vehicle);
    }

    /// <summary>
    /// Delete one Vehicule
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteVehicle([FromRoute()] VehicleWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Vehicles
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Vehicle>>> Vehicles(
        [FromQuery()] VehicleFindManyArgs filter
    )
    {
        return Ok(await _service.Vehicles(filter));
    }

    /// <summary>
    /// Meta data about Vehicule records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> VehiclesMeta(
        [FromQuery()] VehicleFindManyArgs filter
    )
    {
        return Ok(await _service.VehiclesMeta(filter));
    }

    /// <summary>
    /// Get one Vehicule
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Vehicle>> Vehicle([FromRoute()] VehicleWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Vehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Vehicule
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateVehicle(
        [FromRoute()] VehicleWhereUniqueInput uniqueId,
        [FromQuery()] VehicleUpdateInput vehicleUpdateDto
    )
    {
        try
        {
            await _service.UpdateVehicle(uniqueId, vehicleUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
