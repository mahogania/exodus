using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ClearanceFretInterfacesControllerBase : ControllerBase
{
    protected readonly IClearanceFretInterfacesService _service;

    public ClearanceFretInterfacesControllerBase(IClearanceFretInterfacesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Clearance Fret Interface
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClearanceFretInterface>> CreateClearanceFretInterface(
        ClearanceFretInterfaceCreateInput input
    )
    {
        var clearanceFretInterface = await _service.CreateClearanceFretInterface(input);

        return CreatedAtAction(
            nameof(ClearanceFretInterface),
            new { id = clearanceFretInterface.Id },
            clearanceFretInterface
        );
    }

    /// <summary>
    /// Delete one Clearance Fret Interface
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteClearanceFretInterface(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteClearanceFretInterface(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Dedouanement Fret Interfaces
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ClearanceFretInterface>>> ClearanceFretInterfaces(
        [FromQuery()] ClearanceFretInterfaceFindManyArgs filter
    )
    {
        return Ok(await _service.ClearanceFretInterfaces(filter));
    }

    /// <summary>
    /// Meta data about Clearance Fret Interface records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ClearanceFretInterfacesMeta(
        [FromQuery()] ClearanceFretInterfaceFindManyArgs filter
    )
    {
        return Ok(await _service.ClearanceFretInterfacesMeta(filter));
    }

    /// <summary>
    /// Get one Clearance Fret Interface
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ClearanceFretInterface>> ClearanceFretInterface(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ClearanceFretInterface(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Clearance Fret Interface
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateClearanceFretInterface(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId,
        [FromQuery()] ClearanceFretInterfaceUpdateInput clearanceFretInterfaceUpdateDto
    )
    {
        try
        {
            await _service.UpdateClearanceFretInterface(uniqueId, clearanceFretInterfaceUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Clearance Fret Container records to Clearance Fret Interface
    /// </summary>
    [HttpPost("{Id}/clearanceFretContainers")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectClearanceFretContainer(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId,
        [FromQuery()] ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        try
        {
            await _service.ConnectClearanceFretContainer(uniqueId, clearanceFretContainersId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Clearance Fret Container records from Clearance Fret Interface
    /// </summary>
    [HttpDelete("{Id}/clearanceFretContainers")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectClearanceFretContainer(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId,
        [FromBody()] ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        try
        {
            await _service.DisconnectClearanceFretContainer(uniqueId, clearanceFretContainersId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    [HttpGet("{Id}/clearanceFretContainers")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ClearanceFretContainer>>> FindClearanceFretContainer(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId,
        [FromQuery()] ClearanceFretContainerFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindClearanceFretContainer(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Clearance Fret Container records for Clearance Fret Interface
    /// </summary>
    [HttpPatch("{Id}/clearanceFretContainers")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateClearanceFretContainer(
        [FromRoute()] ClearanceFretInterfaceWhereUniqueInput uniqueId,
        [FromBody()] ClearanceFretContainerWhereUniqueInput[] clearanceFretContainersId
    )
    {
        try
        {
            await _service.UpdateClearanceFretContainer(uniqueId, clearanceFretContainersId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
