using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailedDeclarationVehiclesControllerBase : ControllerBase
{
    protected readonly IDetailedDeclarationVehiclesService _service;

    public DetailedDeclarationVehiclesControllerBase(IDetailedDeclarationVehiclesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAILED DECLARATION VEHICLE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailedDeclarationVehicle>> CreateDetailedDeclarationVehicle(
        DetailedDeclarationVehicleCreateInput input
    )
    {
        var detailedDeclarationVehicle = await _service.CreateDetailedDeclarationVehicle(input);

        return CreatedAtAction(
            nameof(DetailedDeclarationVehicle),
            new { id = detailedDeclarationVehicle.Id },
            detailedDeclarationVehicle
        );
    }

    /// <summary>
    /// Delete one DETAILED DECLARATION VEHICLE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailedDeclarationVehicle(
        [FromRoute()] DetailedDeclarationVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailedDeclarationVehicle(uniqueId);
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
    public async Task<ActionResult<List<DetailedDeclarationVehicle>>> DetailedDeclarationVehicles(
        [FromQuery()] DetailedDeclarationVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationVehicles(filter));
    }

    /// <summary>
    /// Meta data about DETAILED DECLARATION VEHICLE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailedDeclarationVehiclesMeta(
        [FromQuery()] DetailedDeclarationVehicleFindManyArgs filter
    )
    {
        return Ok(await _service.DetailedDeclarationVehiclesMeta(filter));
    }

    /// <summary>
    /// Get one DETAILED DECLARATION VEHICLE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<DetailedDeclarationVehicle>> DetailedDeclarationVehicle(
        [FromRoute()] DetailedDeclarationVehicleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailedDeclarationVehicle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAILED DECLARATION VEHICLE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailedDeclarationVehicle(
        [FromRoute()] DetailedDeclarationVehicleWhereUniqueInput uniqueId,
        [FromQuery()] DetailedDeclarationVehicleUpdateInput detailedDeclarationVehicleUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailedDeclarationVehicle(
                uniqueId,
                detailedDeclarationVehicleUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
