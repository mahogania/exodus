using Fret.APIs;
using Fret.APIs.Common;
using Fret.APIs.Dtos;
using Fret.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Fret.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonsControllerBase : ControllerBase
{
    protected readonly ICommonsService _service;

    public CommonsControllerBase(ICommonsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Common>> CreateCommon(CommonCreateInput input)
    {
        var common = await _service.CreateCommon(input);

        return CreatedAtAction(nameof(Common), new { id = common.Id }, common);
    }

    /// <summary>
    /// Delete one Common
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommon([FromRoute()] CommonWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteCommon(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Commons
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Common>>> Commons([FromQuery()] CommonFindManyArgs filter)
    {
        return Ok(await _service.Commons(filter));
    }

    /// <summary>
    /// Meta data about Common records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonsMeta(
        [FromQuery()] CommonFindManyArgs filter
    )
    {
        return Ok(await _service.CommonsMeta(filter));
    }

    /// <summary>
    /// Get one Common
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Common>> Common([FromRoute()] CommonWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Common(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommon(
        [FromRoute()] CommonWhereUniqueInput uniqueId,
        [FromQuery()] CommonUpdateInput commonUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommon(uniqueId, commonUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
