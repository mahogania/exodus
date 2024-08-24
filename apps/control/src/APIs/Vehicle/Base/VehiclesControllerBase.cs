using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

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
    /// Create one Vehicle
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Vehicle>> CreateVehicle(VehicleCreateInput input)
    {
        var vehicle = await _service.CreateVehicle(input);

        return CreatedAtAction(nameof(Vehicle), new { id = vehicle.Id }, vehicle);
    }

    /// <summary>
    /// Delete one Vehicle
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
    /// Find many DETAILED DECLARATION VEHICLES
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
    /// Meta data about Vehicle records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> VehiclesMeta(
        [FromQuery()] VehicleFindManyArgs filter
    )
    {
        return Ok(await _service.VehiclesMeta(filter));
    }

    /// <summary>
    /// Get one Vehicle
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
    /// Update one Vehicle
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

    /// <summary>
    /// Get a Articles record for DETAILED DECLARATION VEHICLE
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticles(
        [FromRoute()] VehicleWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticles(uniqueId);
        return Ok(article);
    }
}
