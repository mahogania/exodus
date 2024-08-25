using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalyseCollectionEntreprisesControllerBase : ControllerBase
{
    protected readonly IShAnalyseCollectionEntreprisesService _service;

    public ShAnalyseCollectionEntreprisesControllerBase(
        IShAnalyseCollectionEntreprisesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalyseCollectionEntreprise
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ShAnalyseCollectionEntreprise>
    > CreateShAnalyseCollectionEntreprise(ShAnalyseCollectionEntrepriseCreateInput input)
    {
        var shAnalyseCollectionEntreprise = await _service.CreateShAnalyseCollectionEntreprise(
            input
        );

        return CreatedAtAction(
            nameof(ShAnalyseCollectionEntreprise),
            new { id = shAnalyseCollectionEntreprise.Id },
            shAnalyseCollectionEntreprise
        );
    }

    /// <summary>
    /// Delete one ShAnalyseCollectionEntreprise
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalyseCollectionEntreprise(
        [FromRoute()] ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalyseCollectionEntreprise(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalyseCollectionEntreprises
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ShAnalyseCollectionEntreprise>>
    > ShAnalyseCollectionEntreprises([FromQuery()] ShAnalyseCollectionEntrepriseFindManyArgs filter)
    {
        return Ok(await _service.ShAnalyseCollectionEntreprises(filter));
    }

    /// <summary>
    /// Meta data about ShAnalyseCollectionEntreprise records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalyseCollectionEntreprisesMeta(
        [FromQuery()] ShAnalyseCollectionEntrepriseFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalyseCollectionEntreprisesMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalyseCollectionEntreprise
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalyseCollectionEntreprise>> ShAnalyseCollectionEntreprise(
        [FromRoute()] ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalyseCollectionEntreprise(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalyseCollectionEntreprise
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalyseCollectionEntreprise(
        [FromRoute()] ShAnalyseCollectionEntrepriseWhereUniqueInput uniqueId,
        [FromQuery()]
            ShAnalyseCollectionEntrepriseUpdateInput shAnalyseCollectionEntrepriseUpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalyseCollectionEntreprise(
                uniqueId,
                shAnalyseCollectionEntrepriseUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
