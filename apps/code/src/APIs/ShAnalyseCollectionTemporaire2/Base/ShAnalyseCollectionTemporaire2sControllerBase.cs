using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseCollectionTemporaire2sControllerBase : ControllerBase
{
    protected readonly IShAnalyseCollectionTemporaire2sService _service;

    public ShAnalyseCollectionTemporaire2sControllerBase(
        IShAnalyseCollectionTemporaire2sService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire2
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseCollectionTemporaire2>
    > CreateShAnalyseCollectionTemporaire2(ShAnalyseCollectionTemporaire2CreateInput input)
    {
        var shAnalyseCollectionTemporaire2 = await _service.CreateShAnalyseCollectionTemporaire2(
            input
        );

        return CreatedAtAction(
            nameof(ShAnalyseCollectionTemporaire2),
            new { id = shAnalyseCollectionTemporaire2.Id },
            shAnalyseCollectionTemporaire2
        );
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire2
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseCollectionTemporaire2(
        [FromRoute()] ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseCollectionTemporaire2(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaire2s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ShAnalyseCollectionTemporaire2>>
    > ShAnalyseCollectionTemporaire2s(
        [FromQuery()] ShAnalyseCollectionTemporaire2FindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionTemporaire2s(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire2 records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseCollectionTemporaire2sMeta(
        [FromQuery()] ShAnalyseCollectionTemporaire2FindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionTemporaire2sMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire2
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollectionTemporaire2>> ShAnalyseCollectionTemporaire2(
        [FromRoute()] ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseCollectionTemporaire2(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire2
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseCollectionTemporaire2(
        [FromRoute()] ShAnalyseCollectionTemporaire2WhereUniqueInput uniqueId,
        [FromQuery()]
            ShAnalyseCollectionTemporaire2UpdateInput shAnalyseCollectionTemporaire2UpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseCollectionTemporaire2(
                uniqueId,
                shAnalyseCollectionTemporaire2UpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
