using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ContainersControllerBase : ControllerBase
{
    protected readonly IContainersService _service;

    public ContainersControllerBase(IContainersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Conteneur
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Container>> CreateContainer(ContainerCreateInput input)
    {
        var container = await _service.CreateContainer(input);

        return CreatedAtAction(nameof(Container), new { id = container.Id }, container);
    }

    /// <summary>
    /// Delete one Conteneur
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteContainer(
        [FromRoute()] ContainerWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteContainer(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Containers
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Container>>> Containers(
        [FromQuery()] ContainerFindManyArgs filter
    )
    {
        return Ok(await _service.Containers(filter));
    }

    /// <summary>
    /// Meta data about Conteneur records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ContainersMeta(
        [FromQuery()] ContainerFindManyArgs filter
    )
    {
        return Ok(await _service.ContainersMeta(filter));
    }

    /// <summary>
    /// Get one Conteneur
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Container>> Container(
        [FromRoute()] ContainerWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Container(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Conteneur
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateContainer(
        [FromRoute()] ContainerWhereUniqueInput uniqueId,
        [FromQuery()] ContainerUpdateInput containerUpdateDto
    )
    {
        try
        {
            await _service.UpdateContainer(uniqueId, containerUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
