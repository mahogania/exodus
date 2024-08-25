using Code.APIs;
using Code.APIs.Common;
using Code.APIs.Dtos;
using Code.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Code.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class PrixUnitaireDeclarationDetailsControllerBase : ControllerBase
{
    protected readonly IPrixUnitaireDeclarationDetailsService _service;

    public PrixUnitaireDeclarationDetailsControllerBase(
        IPrixUnitaireDeclarationDetailsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one PrixUnitaireDeclarationDetail
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<PrixUnitaireDeclarationDetail>
    > CreatePrixUnitaireDeclarationDetail(PrixUnitaireDeclarationDetailCreateInput input)
    {
        var prixUnitaireDeclarationDetail = await _service.CreatePrixUnitaireDeclarationDetail(
            input
        );

        return CreatedAtAction(
            nameof(PrixUnitaireDeclarationDetail),
            new { id = prixUnitaireDeclarationDetail.Id },
            prixUnitaireDeclarationDetail
        );
    }

    /// <summary>
    /// Delete one PrixUnitaireDeclarationDetail
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeletePrixUnitaireDeclarationDetail(
        [FromRoute()] PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeletePrixUnitaireDeclarationDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many PrixUnitaireDeclarationDetails
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<PrixUnitaireDeclarationDetail>>
    > PrixUnitaireDeclarationDetails([FromQuery()] PrixUnitaireDeclarationDetailFindManyArgs filter)
    {
        return Ok(await _service.PrixUnitaireDeclarationDetails(filter));
    }

    /// <summary>
    /// Meta data about PrixUnitaireDeclarationDetail records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> PrixUnitaireDeclarationDetailsMeta(
        [FromQuery()] PrixUnitaireDeclarationDetailFindManyArgs filter
    )
    {
        return Ok(await _service.PrixUnitaireDeclarationDetailsMeta(filter));
    }

    /// <summary>
    /// Get one PrixUnitaireDeclarationDetail
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<PrixUnitaireDeclarationDetail>> PrixUnitaireDeclarationDetail(
        [FromRoute()] PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.PrixUnitaireDeclarationDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one PrixUnitaireDeclarationDetail
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdatePrixUnitaireDeclarationDetail(
        [FromRoute()] PrixUnitaireDeclarationDetailWhereUniqueInput uniqueId,
        [FromQuery()]
            PrixUnitaireDeclarationDetailUpdateInput prixUnitaireDeclarationDetailUpdateDto
    )
    {
        try
        {
            await _service.UpdatePrixUnitaireDeclarationDetail(
                uniqueId,
                prixUnitaireDeclarationDetailUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
