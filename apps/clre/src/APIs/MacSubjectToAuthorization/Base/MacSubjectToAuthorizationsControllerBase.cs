using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class MacSubjectToAuthorizationsControllerBase : ControllerBase
{
    protected readonly IMacSubjectToAuthorizationsService _service;

    public MacSubjectToAuthorizationsControllerBase(IMacSubjectToAuthorizationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<MacSubjectToAuthorization>> CreateMacSubjectToAuthorization(
        MacSubjectToAuthorizationCreateInput input
    )
    {
        var macSubjectToAuthorization = await _service.CreateMacSubjectToAuthorization(input);

        return CreatedAtAction(
            nameof(MacSubjectToAuthorization),
            new { id = macSubjectToAuthorization.Id },
            macSubjectToAuthorization
        );
    }

    /// <summary>
    /// Delete one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteMacSubjectToAuthorization(
        [FromRoute()] MacSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteMacSubjectToAuthorization(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MAC SUBJECT TO AUTHORIZATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<MacSubjectToAuthorization>>> MacSubjectToAuthorizations(
        [FromQuery()] MacSubjectToAuthorizationFindManyArgs filter
    )
    {
        return Ok(await _service.MacSubjectToAuthorizations(filter));
    }

    /// <summary>
    /// Meta data about MAC SUBJECT TO AUTHORIZATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> MacSubjectToAuthorizationsMeta(
        [FromQuery()] MacSubjectToAuthorizationFindManyArgs filter
    )
    {
        return Ok(await _service.MacSubjectToAuthorizationsMeta(filter));
    }

    /// <summary>
    /// Get one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<MacSubjectToAuthorization>> MacSubjectToAuthorization(
        [FromRoute()] MacSubjectToAuthorizationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.MacSubjectToAuthorization(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one MAC SUBJECT TO AUTHORIZATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateMacSubjectToAuthorization(
        [FromRoute()] MacSubjectToAuthorizationWhereUniqueInput uniqueId,
        [FromQuery()] MacSubjectToAuthorizationUpdateInput macSubjectToAuthorizationUpdateDto
    )
    {
        try
        {
            await _service.UpdateMacSubjectToAuthorization(
                uniqueId,
                macSubjectToAuthorizationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
