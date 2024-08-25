using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ClearanceFretContainersControllerBase : ControllerBase
{
    protected readonly IClearanceFretContainersService _service;

    public ClearanceFretContainersControllerBase(IClearanceFretContainersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Clearance Fret Container
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClearanceFretContainer>> CreateClearanceFretContainer(
        ClearanceFretContainerCreateInput input
    )
    {
        var clearanceFretContainer = await _service.CreateClearanceFretContainer(input);

        return CreatedAtAction(
            nameof(ClearanceFretContainer),
            new { id = clearanceFretContainer.Id },
            clearanceFretContainer
        );
    }

    /// <summary>
    /// Delete one Clearance Fret Container
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteClearanceFretContainer(
        [FromRoute()] ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteClearanceFretContainer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Clearance Fret Containers
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ClearanceFretContainer>>> ClearanceFretContainers(
        [FromQuery()] ClearanceFretContainerFindManyArgs filter
    )
    {
        return Ok(await _service.ClearanceFretContainers(filter));
    }

    /// <summary>
    /// Meta data about Clearance Fret Container records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ClearanceFretContainersMeta(
        [FromQuery()] ClearanceFretContainerFindManyArgs filter
    )
    {
        return Ok(await _service.ClearanceFretContainersMeta(filter));
    }

    /// <summary>
    /// Get one Clearance Fret Container
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClearanceFretContainer>> ClearanceFretContainer(
        [FromRoute()] ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ClearanceFretContainer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Clearance Fret Container
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateClearanceFretContainer(
        [FromRoute()] ClearanceFretContainerWhereUniqueInput uniqueId,
        [FromQuery()] ClearanceFretContainerUpdateInput clearanceFretContainerUpdateDto
    )
    {
        try
        {
            await _service.UpdateClearanceFretContainer(uniqueId, clearanceFretContainerUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Clearance Fret Interface record for Clearance Fret Container
    /// </summary>
    [HttpGet("{Id}/clearanceFretInterfaces")]
    public async Task<ActionResult<List<ClearanceFretInterface>>> GetClearanceFretInterface(
        [FromRoute()] ClearanceFretContainerWhereUniqueInput uniqueId
    )
    {
        var clearanceFretInterface = await _service.GetClearanceFretInterface(uniqueId);
        return Ok(clearanceFretInterface);
    }
}
