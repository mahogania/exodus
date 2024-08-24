using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RawMaterialsControllerBase : ControllerBase
{
    protected readonly IRawMaterialsService _service;

    public RawMaterialsControllerBase(IRawMaterialsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Raw Material
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RawMaterial>> CreateRawMaterial(RawMaterialCreateInput input)
    {
        var rawMaterial = await _service.CreateRawMaterial(input);

        return CreatedAtAction(nameof(RawMaterial), new { id = rawMaterial.Id }, rawMaterial);
    }

    /// <summary>
    /// Delete one Raw Material
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRawMaterial(
        [FromRoute()] RawMaterialWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRawMaterial(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RawMaterial>>> RawMaterials(
        [FromQuery()] RawMaterialFindManyArgs filter
    )
    {
        return Ok(await _service.RawMaterials(filter));
    }

    /// <summary>
    /// Meta data about Raw Material records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RawMaterialsMeta(
        [FromQuery()] RawMaterialFindManyArgs filter
    )
    {
        return Ok(await _service.RawMaterialsMeta(filter));
    }

    /// <summary>
    /// Get one Raw Material
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RawMaterial>> RawMaterial(
        [FromRoute()] RawMaterialWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RawMaterial(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Raw Material
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRawMaterial(
        [FromRoute()] RawMaterialWhereUniqueInput uniqueId,
        [FromQuery()] RawMaterialUpdateInput rawMaterialUpdateDto
    )
    {
        try
        {
            await _service.UpdateRawMaterial(uniqueId, rawMaterialUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Article record for RAW MATERIAL OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticle(
        [FromRoute()] RawMaterialWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticle(uniqueId);
        return Ok(article);
    }
}
