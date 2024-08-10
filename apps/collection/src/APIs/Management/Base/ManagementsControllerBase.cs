using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class ManagementsControllerBase : ControllerBase
{
    protected readonly IManagementsService _service;

    public ManagementsControllerBase(IManagementsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one MANAGEMENT
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Management>> CreateManagement(ManagementCreateInput input)
    {
        var management = await _service.CreateManagement(input);

        return CreatedAtAction(nameof(Management), new { id = management.Id }, management);
    }

    /// <summary>
    ///     Delete one MANAGEMENT
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteManagement(
        [FromRoute] ManagementWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteManagement(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many MANAGEMENTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Management>>> Managements(
        [FromQuery] ManagementFindManyArgs filter
    )
    {
        return Ok(await _service.Managements(filter));
    }

    /// <summary>
    ///     Meta data about MANAGEMENT records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ManagementsMeta(
        [FromQuery] ManagementFindManyArgs filter
    )
    {
        return Ok(await _service.ManagementsMeta(filter));
    }

    /// <summary>
    ///     Get one MANAGEMENT
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Management>> Management(
        [FromRoute] ManagementWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Management(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one MANAGEMENT
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateManagement(
        [FromRoute] ManagementWhereUniqueInput uniqueId,
        [FromQuery] ManagementUpdateInput managementUpdateDto
    )
    {
        try
        {
            await _service.UpdateManagement(uniqueId, managementUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
