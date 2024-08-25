using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseCollectionTemporairesControllerBase : ControllerBase
{
    protected readonly IShAnalyseCollectionTemporairesService _service;

    public ShAnalyseCollectionTemporairesControllerBase(
        IShAnalyseCollectionTemporairesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionTemporaire
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseCollectionTemporaire>
    > CreateShAnalyseCollectionTemporaire(ShAnalyseCollectionTemporaireCreateInput input)
    {
        var shAnalyseCollectionTemporaire = await _service.CreateShAnalyseCollectionTemporaire(
            input
        );

        return CreatedAtAction(
            nameof(ShAnalyseCollectionTemporaire),
            new { id = shAnalyseCollectionTemporaire.Id },
            shAnalyseCollectionTemporaire
        );
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionTemporaire
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseCollectionTemporaire(
        [FromRoute()] ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseCollectionTemporaire(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionTemporaires
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ShAnalyseCollectionTemporaire>>
    > ShAnalyseCollectionTemporaires([FromQuery()] ShAnalyseCollectionTemporaireFindManyArgs filter)
    {
        return Ok(await _service.ShAnalyseCollectionTemporaires(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionTemporaire records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseCollectionTemporairesMeta(
        [FromQuery()] ShAnalyseCollectionTemporaireFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionTemporairesMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseCollectionTemporaire
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollectionTemporaire>> ShAnalyseCollectionTemporaire(
        [FromRoute()] ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseCollectionTemporaire(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseCollectionTemporaire
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseCollectionTemporaire(
        [FromRoute()] ShAnalyseCollectionTemporaireWhereUniqueInput uniqueId,
        [FromQuery()]
            ShAnalyseCollectionTemporaireUpdateInput shAnalyseCollectionTemporaireUpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseCollectionTemporaire(
                uniqueId,
                shAnalyseCollectionTemporaireUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
