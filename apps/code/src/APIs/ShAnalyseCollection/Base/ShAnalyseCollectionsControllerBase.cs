using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseCollectionsControllerBase : ControllerBase
{
    protected readonly IShAnalyseCollectionsService _service;

    public ShAnalyseCollectionsControllerBase(IShAnalyseCollectionsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseCollection
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollection>> CreateShAnalyseCollection(
        ShAnalyseCollectionCreateInput input
    )
    {
        var shAnalyseCollection = await _service.CreateShAnalyseCollection(input);

        return CreatedAtAction(
            nameof(ShAnalyseCollection),
            new { id = shAnalyseCollection.Id },
            shAnalyseCollection
        );
    }

    /// <summary>
    /// Delete one ShAnalyseCollection
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseCollection(
        [FromRoute()] ShAnalyseCollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseCollection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseCollections
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ShAnalyseCollection>>> ShAnalyseCollections(
        [FromQuery()] ShAnalyseCollectionFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollections(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseCollection records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseCollectionsMeta(
        [FromQuery()] ShAnalyseCollectionFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionsMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseCollection
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollection>> ShAnalyseCollection(
        [FromRoute()] ShAnalyseCollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseCollection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseCollection
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseCollection(
        [FromRoute()] ShAnalyseCollectionWhereUniqueInput uniqueId,
        [FromQuery()] ShAnalyseCollectionUpdateInput shAnalyseCollectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseCollection(uniqueId, shAnalyseCollectionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
