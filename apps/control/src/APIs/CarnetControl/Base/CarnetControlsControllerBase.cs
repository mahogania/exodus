using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CarnetControlsControllerBase : ControllerBase
{
    protected readonly ICarnetControlsService _service;

    public CarnetControlsControllerBase(ICarnetControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Carnet Control
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetControl>> CreateCarnetControl(
        CarnetControlCreateInput input
    )
    {
        var carnetControl = await _service.CreateCarnetControl(input);

        return CreatedAtAction(nameof(CarnetControl), new { id = carnetControl.Id }, carnetControl);
    }

    /// <summary>
    /// Delete one Carnet Control
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCarnetControl(
        [FromRoute()] CarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Carnet Controls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CarnetControl>>> CarnetControls(
        [FromQuery()] CarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetControls(filter));
    }

    /// <summary>
    /// Meta data about Carnet Control records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CarnetControlsMeta(
        [FromQuery()] CarnetControlFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetControlsMeta(filter));
    }

    /// <summary>
    /// Get one Carnet Control
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetControl>> CarnetControl(
        [FromRoute()] CarnetControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CarnetControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Carnet Control
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCarnetControl(
        [FromRoute()] CarnetControlWhereUniqueInput uniqueId,
        [FromQuery()] CarnetControlUpdateInput carnetControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateCarnetControl(uniqueId, carnetControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Carnet Request record for CarnetControl
    /// </summary>
    [HttpGet("{Id}/commonCarnetRequests")]
    public async Task<ActionResult<List<CommonCarnetRequest>>> GetCommonCarnetRequest(
        [FromRoute()] CarnetControlWhereUniqueInput uniqueId
    )
    {
        var commonCarnetRequest = await _service.GetCommonCarnetRequest(uniqueId);
        return Ok(commonCarnetRequest);
    }
}
