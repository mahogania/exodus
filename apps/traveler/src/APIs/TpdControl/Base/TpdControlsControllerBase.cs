using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TpdControlsControllerBase : ControllerBase
{
    protected readonly ITpdControlsService _service;

    public TpdControlsControllerBase(ITpdControlsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one TpdControl
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdControl>> CreateTpdControl(TpdControlCreateInput input)
    {
        var tpdControl = await _service.CreateTpdControl(input);

        return CreatedAtAction(nameof(TpdControl), new { id = tpdControl.Id }, tpdControl);
    }

    /// <summary>
    /// Delete one TpdControl
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTpdControl(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTpdControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TpdControls
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TpdControl>>> TpdControls(
        [FromQuery()] TpdControlFindManyArgs filter
    )
    {
        return Ok(await _service.TpdControls(filter));
    }

    /// <summary>
    /// Meta data about TpdControl records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TpdControlsMeta(
        [FromQuery()] TpdControlFindManyArgs filter
    )
    {
        return Ok(await _service.TpdControlsMeta(filter));
    }

    /// <summary>
    /// Get one TpdControl
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TpdControl>> TpdControl(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TpdControl(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one TpdControl
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTpdControl(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
        [FromQuery()] TpdControlUpdateInput tpdControlUpdateDto
    )
    {
        try
        {
            await _service.UpdateTpdControl(uniqueId, tpdControlUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Baggage Control Article record for TpdControl
    /// </summary>
    [HttpGet("{Id}/baggageControlArticles")]
    public async Task<ActionResult<List<BaggageControlArticle>>> GetBaggageControlArticle(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId
    )
    {
        var baggageControlArticle = await _service.GetBaggageControlArticle(uniqueId);
        return Ok(baggageControlArticle);
    }

    /// <summary>
    /// Connect multiple GeneralTravelerInformationTpds records to TpdControl
    /// </summary>
    [HttpPost("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Disconnect multiple GeneralTravelerInformationTpds records from TpdControl
    /// </summary>
    [HttpDelete("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectGeneralTravelerInformationTpds(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Find multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    [HttpGet("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > FindGeneralTravelerInformationTpds(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Update multiple GeneralTravelerInformationTpds records for TpdControl
    /// </summary>
    [HttpPatch("{Id}/generalTravelerInformationTpds")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpds(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Connect multiple ImportDeclarations records to TpdControl
    /// </summary>
    [HttpPost("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectImportDeclarations(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Disconnect multiple ImportDeclarations records from TpdControl
    /// </summary>
    [HttpDelete("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectImportDeclarations(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Find multiple ImportDeclarations records for TpdControl
    /// </summary>
    [HttpGet("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ImportDeclaration>>> FindImportDeclarations(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
    /// Update multiple ImportDeclarations records for TpdControl
    /// </summary>
    [HttpPatch("{Id}/importDeclarations")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateImportDeclarations(
        [FromRoute()] TpdControlWhereUniqueInput uniqueId,
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
}
