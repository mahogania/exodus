using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class BaggageControlArticlesControllerBase : ControllerBase
{
    protected readonly IBaggageControlArticlesService _service;

    public BaggageControlArticlesControllerBase(IBaggageControlArticlesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one BaggageControlArticle
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<BaggageControlArticle>> CreateBaggageControlArticle(
        BaggageControlArticleCreateInput input
    )
    {
        var baggageControlArticle = await _service.CreateBaggageControlArticle(input);

        return CreatedAtAction(
            nameof(BaggageControlArticle),
            new { id = baggageControlArticle.Id },
            baggageControlArticle
        );
    }

    /// <summary>
    /// Delete one BaggageControlArticle
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteBaggageControlArticle(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteBaggageControlArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many BaggageControlArticles
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<BaggageControlArticle>>> BaggageControlArticles(
        [FromQuery()] BaggageControlArticleFindManyArgs filter
    )
    {
        return Ok(await _service.BaggageControlArticles(filter));
    }

    /// <summary>
    /// Meta data about BaggageControlArticle records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> BaggageControlArticlesMeta(
        [FromQuery()] BaggageControlArticleFindManyArgs filter
    )
    {
        return Ok(await _service.BaggageControlArticlesMeta(filter));
    }

    /// <summary>
    /// Get one BaggageControlArticle
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<BaggageControlArticle>> BaggageControlArticle(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.BaggageControlArticle(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one BaggageControlArticle
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateBaggageControlArticle(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] BaggageControlArticleUpdateInput baggageControlArticleUpdateDto
    )
    {
        try
        {
            await _service.UpdateBaggageControlArticle(uniqueId, baggageControlArticleUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to BaggageControlArticle
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.ConnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple GeneralTravelerInformationTpds records from BaggageControlArticle
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.DisconnectGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindGeneralTravelerInformationTpds(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple GeneralTravelerInformationTpds records for BaggageControlArticle
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()]
            GeneralTravelerInformationTpdWhereUniqueInput[] generalTravelerInformationTpdsId
    )
    {
        try
        {
            await _service.UpdateGeneralTravelerInformationTpds(
                uniqueId,
                generalTravelerInformationTpdsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple ImportDeclarations records to BaggageControlArticle
    /// </summary>
    [HttpPost("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportDeclarations(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.ConnectImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple ImportDeclarations records from BaggageControlArticle
    /// </summary>
    [HttpDelete("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportDeclarations(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.DisconnectImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    [HttpGet("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportDeclaration>>> FindImportDeclarations(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] ImportDeclarationFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindImportDeclarations(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple ImportDeclarations records for BaggageControlArticle
    /// </summary>
    [HttpPatch("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportDeclarations(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()] ImportDeclarationWhereUniqueInput[] importDeclarationsId
    )
    {
        try
        {
            await _service.UpdateImportDeclarations(uniqueId, importDeclarationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple TpdControls records to BaggageControlArticle
    /// </summary>
    [HttpPost("{Id}/tpdControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectTpdControls(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        try
        {
            await _service.ConnectTpdControls(uniqueId, tpdControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple TpdControls records from BaggageControlArticle
    /// </summary>
    [HttpDelete("{Id}/tpdControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectTpdControls(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()] TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        try
        {
            await _service.DisconnectTpdControls(uniqueId, tpdControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple TpdControls records for BaggageControlArticle
    /// </summary>
    [HttpGet("{Id}/tpdControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TpdControl>>> FindTpdControls(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromQuery()] TpdControlFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindTpdControls(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple TpdControls records for BaggageControlArticle
    /// </summary>
    [HttpPatch("{Id}/tpdControls")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTpdControls(
        [FromRoute()] BaggageControlArticleWhereUniqueInput uniqueId,
        [FromBody()] TpdControlWhereUniqueInput[] tpdControlsId
    )
    {
        try
        {
            await _service.UpdateTpdControls(uniqueId, tpdControlsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
