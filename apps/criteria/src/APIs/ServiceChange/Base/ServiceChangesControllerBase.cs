using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ServiceChangesControllerBase : ControllerBase
{
    protected readonly IServiceChangesService _service;

    public ServiceChangesControllerBase(IServiceChangesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Service Change
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ServiceChange>> CreateServiceChange(
        ServiceChangeCreateInput input
    )
    {
        var serviceChange = await _service.CreateServiceChange(input);

        return CreatedAtAction(nameof(ServiceChange), new { id = serviceChange.Id }, serviceChange);
    }

    /// <summary>
    /// Delete one Service Change
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteServiceChange(
        [FromRoute()] ServiceChangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteServiceChange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Service Changes
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ServiceChange>>> ServiceChanges(
        [FromQuery()] ServiceChangeFindManyArgs filter
    )
    {
        return Ok(await _service.ServiceChanges(filter));
    }

    /// <summary>
    /// Meta data about Service Change records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ServiceChangesMeta(
        [FromQuery()] ServiceChangeFindManyArgs filter
    )
    {
        return Ok(await _service.ServiceChangesMeta(filter));
    }

    /// <summary>
    /// Get one Service Change
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ServiceChange>> ServiceChange(
        [FromRoute()] ServiceChangeWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ServiceChange(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Service Change
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateServiceChange(
        [FromRoute()] ServiceChangeWhereUniqueInput uniqueId,
        [FromQuery()] ServiceChangeUpdateInput serviceChangeUpdateDto
    )
    {
        try
        {
            await _service.UpdateServiceChange(uniqueId, serviceChangeUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
