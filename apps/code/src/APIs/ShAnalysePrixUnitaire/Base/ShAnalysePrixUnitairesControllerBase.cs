using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ShAnalysePrixUnitairesControllerBase : ControllerBase
{
    protected readonly IShAnalysePrixUnitairesService _service;

    public ShAnalysePrixUnitairesControllerBase(IShAnalysePrixUnitairesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ShAnalysePrixUnitaire
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalysePrixUnitaire>> CreateShAnalysePrixUnitaire(
        ShAnalysePrixUnitaireCreateInput input
    )
    {
        var shAnalysePrixUnitaire = await _service.CreateShAnalysePrixUnitaire(input);

        return CreatedAtAction(
            nameof(ShAnalysePrixUnitaire),
            new { id = shAnalysePrixUnitaire.Id },
            shAnalysePrixUnitaire
        );
    }

    /// <summary>
    /// Delete one ShAnalysePrixUnitaire
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteShAnalysePrixUnitaire(
        [FromRoute()] ShAnalysePrixUnitaireWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteShAnalysePrixUnitaire(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ShAnalysePrixUnitaires
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ShAnalysePrixUnitaire>>> ShAnalysePrixUnitaires(
        [FromQuery()] ShAnalysePrixUnitaireFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalysePrixUnitaires(filter));
    }

    /// <summary>
    /// Meta data about ShAnalysePrixUnitaire records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ShAnalysePrixUnitairesMeta(
        [FromQuery()] ShAnalysePrixUnitaireFindManyArgs filter
    )
    {
        return Ok(await _service.ShAnalysePrixUnitairesMeta(filter));
    }

    /// <summary>
    /// Get one ShAnalysePrixUnitaire
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ShAnalysePrixUnitaire>> ShAnalysePrixUnitaire(
        [FromRoute()] ShAnalysePrixUnitaireWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ShAnalysePrixUnitaire(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ShAnalysePrixUnitaire
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateShAnalysePrixUnitaire(
        [FromRoute()] ShAnalysePrixUnitaireWhereUniqueInput uniqueId,
        [FromQuery()] ShAnalysePrixUnitaireUpdateInput shAnalysePrixUnitaireUpdateDto
    )
    {
        try
        {
            await _service.UpdateShAnalysePrixUnitaire(uniqueId, shAnalysePrixUnitaireUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
