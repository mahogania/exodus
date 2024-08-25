using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShProfilsControllerBase : ControllerBase
{
    protected readonly IShProfilsService _service;

    public ShProfilsControllerBase(IShProfilsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShProfil
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShProfil>> CreateShProfil(ShProfilCreateInput input)
    {
        var shProfil = await _service.CreateShProfil(input);

        return CreatedAtAction(nameof(ShProfil), new { id = shProfil.Id }, shProfil);
    }

    /// <summary>
    /// Delete one ShProfil
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShProfil([FromRoute()] ShProfilWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteShProfil(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShProfils
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ShProfil>>> ShProfils(
        [FromQuery()] ShProfilFindManyArgs filter
    )
    {
        return Ok(await _service.ShProfils(filter));
    }

    /// <summary>
    /// Meta data about ShProfil records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShProfilsMeta(
        [FromQuery()] ShProfilFindManyArgs filter
    )
    {
        return Ok(await _service.ShProfilsMeta(filter));
    }

    /// <summary>
    /// Get one ShProfil
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShProfil>> ShProfil(
        [FromRoute()] ShProfilWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShProfil(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShProfil
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShProfil(
        [FromRoute()] ShProfilWhereUniqueInput uniqueId,
        [FromQuery()] ShProfilUpdateInput shProfilUpdateDto
    )
    {
        try
        {
            await _service.UpdateShProfil(uniqueId, shProfilUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
