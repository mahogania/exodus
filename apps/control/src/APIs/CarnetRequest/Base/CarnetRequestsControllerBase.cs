using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CarnetRequestsControllerBase : ControllerBase
{
    protected readonly ICarnetRequestsService _service;

    public CarnetRequestsControllerBase(ICarnetRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Carnet Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetRequest>> CreateCarnetRequest(
        CarnetRequestCreateInput input
    )
    {
        var carnetRequest = await _service.CreateCarnetRequest(input);

        return CreatedAtAction(nameof(CarnetRequest), new { id = carnetRequest.Id }, carnetRequest);
    }

    /// <summary>
    /// Delete one Carnet Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Carnet Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CarnetRequest>>> CarnetRequests(
        [FromQuery()] CarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetRequests(filter));
    }

    /// <summary>
    /// Meta data about Carnet Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CarnetRequestsMeta(
        [FromQuery()] CarnetRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CarnetRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Carnet Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CarnetRequest>> CarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CarnetRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Carnet Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCarnetRequest(
        [FromRoute()] CarnetRequestWhereUniqueInput uniqueId,
        [FromQuery()] CarnetRequestUpdateInput carnetRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCarnetRequest(uniqueId, carnetRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
