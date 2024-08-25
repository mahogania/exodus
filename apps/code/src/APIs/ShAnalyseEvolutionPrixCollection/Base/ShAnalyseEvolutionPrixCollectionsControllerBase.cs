using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseEvolutionPrixCollectionsControllerBase : ControllerBase
{
    protected readonly IShAnalyseEvolutionPrixCollectionsService _service;

    public ShAnalyseEvolutionPrixCollectionsControllerBase(
        IShAnalyseEvolutionPrixCollectionsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseEvolutionPrixCollection
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseEvolutionPrixCollection>
    > CreateShAnalyseEvolutionPrixCollection(ShAnalyseEvolutionPrixCollectionCreateInput input)
    {
        var shAnalyseEvolutionPrixCollection =
            await _service.CreateShAnalyseEvolutionPrixCollection(input);

        return CreatedAtAction(
            nameof(ShAnalyseEvolutionPrixCollection),
            new { id = shAnalyseEvolutionPrixCollection.Id },
            shAnalyseEvolutionPrixCollection
        );
    }

    /// <summary>
    /// Delete one ShAnalyseEvolutionPrixCollection
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseEvolutionPrixCollection(
        [FromRoute()] ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseEvolutionPrixCollection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseEvolutionPrixCollections
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ShAnalyseEvolutionPrixCollection>>
    > ShAnalyseEvolutionPrixCollections(
        [FromQuery()] ShAnalyseEvolutionPrixCollectionFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseEvolutionPrixCollections(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseEvolutionPrixCollection records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseEvolutionPrixCollectionsMeta(
        [FromQuery()] ShAnalyseEvolutionPrixCollectionFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseEvolutionPrixCollectionsMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseEvolutionPrixCollection
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseEvolutionPrixCollection>
    > ShAnalyseEvolutionPrixCollection(
        [FromRoute()] ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseEvolutionPrixCollection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseEvolutionPrixCollection
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseEvolutionPrixCollection(
        [FromRoute()] ShAnalyseEvolutionPrixCollectionWhereUniqueInput uniqueId,
        [FromQuery()]
            ShAnalyseEvolutionPrixCollectionUpdateInput shAnalyseEvolutionPrixCollectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseEvolutionPrixCollection(
                uniqueId,
                shAnalyseEvolutionPrixCollectionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
