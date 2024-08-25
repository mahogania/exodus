using Criteria.APIs;
using Criteria.APIs.Common;
using Criteria.APIs.Dtos;
using Criteria.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Criteria.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ForeignClientsControllerBase : ControllerBase
{
    protected readonly IForeignClientsService _service;

    public ForeignClientsControllerBase(IForeignClientsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Foreign Client
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ForeignClient>> CreateForeignClient(
        ForeignClientCreateInput input
    )
    {
        var foreignClient = await _service.CreateForeignClient(input);

        return CreatedAtAction(nameof(ForeignClient), new { id = foreignClient.Id }, foreignClient);
    }

    /// <summary>
    /// Delete one Foreign Client
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteForeignClient(
        [FromRoute()] ForeignClientWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteForeignClient(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Foreign Clients
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ForeignClient>>> ForeignClients(
        [FromQuery()] ForeignClientFindManyArgs filter
    )
    {
        return Ok(await _service.ForeignClients(filter));
    }

    /// <summary>
    /// Meta data about Foreign Client records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ForeignClientsMeta(
        [FromQuery()] ForeignClientFindManyArgs filter
    )
    {
        return Ok(await _service.ForeignClientsMeta(filter));
    }

    /// <summary>
    /// Get one Foreign Client
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ForeignClient>> ForeignClient(
        [FromRoute()] ForeignClientWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ForeignClient(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Foreign Client
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateForeignClient(
        [FromRoute()] ForeignClientWhereUniqueInput uniqueId,
        [FromQuery()] ForeignClientUpdateInput foreignClientUpdateDto
    )
    {
        try
        {
            await _service.UpdateForeignClient(uniqueId, foreignClientUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
