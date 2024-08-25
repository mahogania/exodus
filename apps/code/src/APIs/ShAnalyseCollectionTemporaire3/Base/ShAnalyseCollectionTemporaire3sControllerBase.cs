using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseCollectionTemporaire3sControllerBase : ControllerBase
{
    protected readonly IShAnalyseCollectionTemporaire3sService _service;

    public ShAnalyseCollectionTemporaire3sControllerBase(
        IShAnalyseCollectionTemporaire3sService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire3
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseCollectionTemporaire3>
    > CreateShAnalyseCollectionTemporaire3(ShAnalyseCollectionTemporaire3CreateInput input)
    {
        var shAnalyseCollectionTemporaire3 = await _service.CreateShAnalyseCollectionTemporaire3(
            input
        );

        return CreatedAtAction(
            nameof(ShAnalyseCollectionTemporaire3),
            new { id = shAnalyseCollectionTemporaire3.Id },
            shAnalyseCollectionTemporaire3
        );
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire3
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseCollectionTemporaire3(
        [FromRoute()] ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseCollectionTemporaire3(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire3s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ShAnalyseCollectionTemporaire3>>
    > ShAnalyseCollectionTemporaire3s(
        [FromQuery()] ShAnalyseCollectionTemporaire3FindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionTemporaire3s(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire3 records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseCollectionTemporaire3sMeta(
        [FromQuery()] ShAnalyseCollectionTemporaire3FindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionTemporaire3sMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire3
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollectionTemporaire3>> ShAnalyseCollectionTemporaire3(
        [FromRoute()] ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseCollectionTemporaire3(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire3
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseCollectionTemporaire3(
        [FromRoute()] ShAnalyseCollectionTemporaire3WhereUniqueInput uniqueId,
        [FromQuery()]
            ShAnalyseCollectionTemporaire3UpdateInput shAnalyseCollectionTemporaire3UpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseCollectionTemporaire3(
                uniqueId,
                shAnalyseCollectionTemporaire3UpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
