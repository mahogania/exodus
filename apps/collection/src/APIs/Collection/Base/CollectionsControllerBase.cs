using Collection.APIs;
using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CollectionsControllerBase : ControllerBase
{
    protected readonly ICollectionsService _service;

    public CollectionsControllerBase(ICollectionsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one COLLECTION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Collection>> CreateCollection(CollectionCreateInput input)
    {
        var collection = await _service.CreateCollection(input);

        return CreatedAtAction(nameof(Collection), new { id = collection.Id }, collection);
    }

    /// <summary>
    /// Delete one COLLECTION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCollection(
        [FromRoute()] CollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCollection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COLLECTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Collection>>> Collections(
        [FromQuery()] CollectionFindManyArgs filter
    )
    {
        return Ok(await _service.Collections(filter));
    }

    /// <summary>
    /// Meta data about COLLECTION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CollectionsMeta(
        [FromQuery()] CollectionFindManyArgs filter
    )
    {
        return Ok(await _service.CollectionsMeta(filter));
    }

    /// <summary>
    /// Get one COLLECTION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Collection>> Collection(
        [FromRoute()] CollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Collection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COLLECTION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCollection(
        [FromRoute()] CollectionWhereUniqueInput uniqueId,
        [FromQuery()] CollectionUpdateInput collectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateCollection(uniqueId, collectionUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
