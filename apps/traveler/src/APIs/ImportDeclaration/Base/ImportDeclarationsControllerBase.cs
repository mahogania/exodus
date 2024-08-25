using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ImportDeclarationsControllerBase : ControllerBase
{
    protected readonly IImportDeclarationsService _service;

    public ImportDeclarationsControllerBase(IImportDeclarationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one ImportDeclaration
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportDeclaration>> CreateImportDeclaration(
        ImportDeclarationCreateInput input
    )
    {
        var importDeclaration = await _service.CreateImportDeclaration(input);

        return CreatedAtAction(
            nameof(ImportDeclaration),
            new { id = importDeclaration.Id },
            importDeclaration
        );
    }

    /// <summary>
    /// Delete one ImportDeclaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteImportDeclaration(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteImportDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many ImportDeclarations
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportDeclaration>>> ImportDeclarations(
        [FromQuery()] ImportDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ImportDeclarations(filter));
    }

    /// <summary>
    /// Meta data about ImportDeclaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ImportDeclarationsMeta(
        [FromQuery()] ImportDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ImportDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one ImportDeclaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ImportDeclaration>> ImportDeclaration(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ImportDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one ImportDeclaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportDeclaration(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] ImportDeclarationUpdateInput importDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateImportDeclaration(uniqueId, importDeclarationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Baggage Control Article record for ImportDeclaration
    /// </summary>
    [HttpGet("{Id}/baggageControlArticles")]
    public async Task<ActionResult<List<BaggageControlArticle>>> GetBaggageControlArticle(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var baggageControlArticle = await _service.GetBaggageControlArticle(uniqueId);
        return Ok(baggageControlArticle);
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to ImportDeclaration
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from ImportDeclaration
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for ImportDeclaration
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId,
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
    /// Get a TPD Control record for ImportDeclaration
    /// </summary>
    [HttpGet("{Id}/tpdControls")]
    public async Task<ActionResult<List<TpdControl>>> GetTpdControl(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var tpdControl = await _service.GetTpdControl(uniqueId);
        return Ok(tpdControl);
    }

    /// <summary>
    /// Get a TPD Entry and Exit History record for ImportDeclaration
    /// </summary>
    [HttpGet("{Id}/tpdEntryAndExitHistories")]
    public async Task<ActionResult<List<TpdEntryAndExitHistory>>> GetTpdEntryAndExitHistory(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var tpdEntryAndExitHistory = await _service.GetTpdEntryAndExitHistory(uniqueId);
        return Ok(tpdEntryAndExitHistory);
    }

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for ImportDeclaration
    /// </summary>
    [HttpGet("{Id}/travelersArticlesEntryExits")]
    public async Task<ActionResult<List<TravelersArticlesEntryExit>>> GetTravelersArticlesEntryExit(
        [FromRoute()] ImportDeclarationWhereUniqueInput uniqueId
    )
    {
        var travelersArticlesEntryExit = await _service.GetTravelersArticlesEntryExit(uniqueId);
        return Ok(travelersArticlesEntryExit);
    }
}
