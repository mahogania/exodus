using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class SecuritiesControllerBase : ControllerBase
{
    protected readonly ISecuritiesService _service;

    public SecuritiesControllerBase(ISecuritiesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one SECURITY
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Security>> CreateSecurity(SecurityCreateInput input)
    {
        var security = await _service.CreateSecurity(input);

        return CreatedAtAction(nameof(Security), new { id = security.Id }, security);
    }

    /// <summary>
    /// Delete one SECURITY
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteSecurity([FromRoute()] SecurityWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteSecurity(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many SECURITIES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Security>>> Securities(
        [FromQuery()] SecurityFindManyArgs filter
    )
    {
        return Ok(await _service.Securities(filter));
    }

    /// <summary>
    /// Meta data about SECURITY records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> SecuritiesMeta(
        [FromQuery()] SecurityFindManyArgs filter
    )
    {
        return Ok(await _service.SecuritiesMeta(filter));
    }

    /// <summary>
    /// Get one SECURITY
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Security>> Security(
        [FromRoute()] SecurityWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Security(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one SECURITY
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateSecurity(
        [FromRoute()] SecurityWhereUniqueInput uniqueId,
        [FromQuery()] SecurityUpdateInput securityUpdateDto
    )
    {
        try
        {
            await _service.UpdateSecurity(uniqueId, securityUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
