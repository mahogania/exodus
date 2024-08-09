using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ManageRecklessBiddersControllerBase : ControllerBase
{
    protected readonly IManageRecklessBiddersService _service;

    public ManageRecklessBiddersControllerBase(IManageRecklessBiddersService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one MANAGE RECKLESS BIDDER
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ManageRecklessBidder>> CreateManageRecklessBidder(
        ManageRecklessBidderCreateInput input
    )
    {
        var manageRecklessBidder = await _service.CreateManageRecklessBidder(input);

        return CreatedAtAction(
            nameof(ManageRecklessBidder),
            new { id = manageRecklessBidder.Id },
            manageRecklessBidder
        );
    }

    /// <summary>
    /// Delete one MANAGE RECKLESS BIDDER
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteManageRecklessBidder(
        [FromRoute()] ManageRecklessBidderWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteManageRecklessBidder(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MANAGE RECKLESS BIDDERS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ManageRecklessBidder>>> ManageRecklessBidders(
        [FromQuery()] ManageRecklessBidderFindManyArgs filter
    )
    {
        return Ok(await _service.ManageRecklessBidders(filter));
    }

    /// <summary>
    /// Meta data about MANAGE RECKLESS BIDDER records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ManageRecklessBiddersMeta(
        [FromQuery()] ManageRecklessBidderFindManyArgs filter
    )
    {
        return Ok(await _service.ManageRecklessBiddersMeta(filter));
    }

    /// <summary>
    /// Get one MANAGE RECKLESS BIDDER
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ManageRecklessBidder>> ManageRecklessBidder(
        [FromRoute()] ManageRecklessBidderWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ManageRecklessBidder(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one MANAGE RECKLESS BIDDER
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateManageRecklessBidder(
        [FromRoute()] ManageRecklessBidderWhereUniqueInput uniqueId,
        [FromQuery()] ManageRecklessBidderUpdateInput manageRecklessBidderUpdateDto
    )
    {
        try
        {
            await _service.UpdateManageRecklessBidder(uniqueId, manageRecklessBidderUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
