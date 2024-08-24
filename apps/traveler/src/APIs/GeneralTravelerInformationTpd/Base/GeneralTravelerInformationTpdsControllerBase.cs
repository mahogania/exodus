using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traveler.APIs;
using Traveler.APIs.Common;
using Traveler.APIs.Dtos;
using Traveler.APIs.Errors;

namespace Traveler.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class GeneralTravelerInformationTpdsControllerBase : ControllerBase
{
    protected readonly IGeneralTravelerInformationTpdsService _service;

    public GeneralTravelerInformationTpdsControllerBase(
        IGeneralTravelerInformationTpdsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one GeneralTravelerInformationTpd
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<GeneralTravelerInformationTpd>
    > CreateGeneralTravelerInformationTpd(GeneralTravelerInformationTpdCreateInput input)
    {
        var generalTravelerInformationTpd = await _service.CreateGeneralTravelerInformationTpd(
            input
        );

        return CreatedAtAction(
            nameof(GeneralTravelerInformationTpd),
            new { id = generalTravelerInformationTpd.Id },
            generalTravelerInformationTpd
        );
    }

    /// <summary>
    /// Delete one GeneralTravelerInformationTpd
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteGeneralTravelerInformationTpd(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteGeneralTravelerInformationTpd(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many GeneralTravelerInformationTpds
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<GeneralTravelerInformationTpd>>
    > GeneralTravelerInformationTpds([FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter)
    {
        return Ok(await _service.GeneralTravelerInformationTpds(filter));
    }

    /// <summary>
    /// Meta data about GeneralTravelerInformationTpd records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> GeneralTravelerInformationTpdsMeta(
        [FromQuery()] GeneralTravelerInformationTpdFindManyArgs filter
    )
    {
        return Ok(await _service.GeneralTravelerInformationTpdsMeta(filter));
    }

    /// <summary>
    /// Get one GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<GeneralTravelerInformationTpd>> GeneralTravelerInformationTpd(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.GeneralTravelerInformationTpd(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one GeneralTravelerInformationTpd
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateGeneralTravelerInformationTpd(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId,
        [FromQuery()]
            GeneralTravelerInformationTpdUpdateInput generalTravelerInformationTpdUpdateDto
    )
    {
        try
        {
            await _service.UpdateGeneralTravelerInformationTpd(
                uniqueId,
                generalTravelerInformationTpdUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Accompanied Baggage Entry and Exit record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/accompaniedBaggageEntryAndExits")]
    public async Task<
        ActionResult<List<AccompaniedBaggageEntryAndExit>>
    > GetAccompaniedBaggageEntryAndExit(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var accompaniedBaggageEntryAndExit = await _service.GetAccompaniedBaggageEntryAndExit(
            uniqueId
        );
        return Ok(accompaniedBaggageEntryAndExit);
    }

    /// <summary>
    /// Get a Appeal record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/appeals")]
    public async Task<ActionResult<List<Appeal>>> GetAppeal(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var appeal = await _service.GetAppeal(uniqueId);
        return Ok(appeal);
    }

    /// <summary>
    /// Get a Baggage Control Article record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/baggageControlArticles")]
    public async Task<ActionResult<List<BaggageControlArticle>>> GetBaggageControlArticle(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var baggageControlArticle = await _service.GetBaggageControlArticle(uniqueId);
        return Ok(baggageControlArticle);
    }

    /// <summary>
    /// Get a Exit Voucher record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/exitVouchers")]
    public async Task<ActionResult<List<ExitVoucher>>> GetExitVoucher(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var exitVoucher = await _service.GetExitVoucher(uniqueId);
        return Ok(exitVoucher);
    }

    /// <summary>
    /// Get a General Bond Note record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/generalBondNotes")]
    public async Task<ActionResult<List<GeneralBondNote>>> GetGeneralBondNote(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var generalBondNote = await _service.GetGeneralBondNote(uniqueId);
        return Ok(generalBondNote);
    }

    /// <summary>
    /// Get a Import Declaration record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/importDeclarations")]
    public async Task<ActionResult<List<ImportDeclaration>>> GetImportDeclaration(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var importDeclaration = await _service.GetImportDeclaration(uniqueId);
        return Ok(importDeclaration);
    }

    /// <summary>
    /// Get a Inspector Rating Modification History record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/inspectorRatingModificationHistories")]
    public async Task<
        ActionResult<List<InspectorRatingModificationHistory>>
    > GetInspectorRatingModificationHistory(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var inspectorRatingModificationHistory =
            await _service.GetInspectorRatingModificationHistory(uniqueId);
        return Ok(inspectorRatingModificationHistory);
    }

    /// <summary>
    /// Get a TPD Control record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/tpdControls")]
    public async Task<ActionResult<List<TpdControl>>> GetTpdControl(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var tpdControl = await _service.GetTpdControl(uniqueId);
        return Ok(tpdControl);
    }

    /// <summary>
    /// Get a TPD Entry and Exit History record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/tpdEntryAndExitHistories")]
    public async Task<ActionResult<List<TpdEntryAndExitHistory>>> GetTpdEntryAndExitHistory(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var tpdEntryAndExitHistory = await _service.GetTpdEntryAndExitHistory(uniqueId);
        return Ok(tpdEntryAndExitHistory);
    }

    /// <summary>
    /// Get a TPD Vehicle record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/tpdVehicles")]
    public async Task<ActionResult<List<TpdVehicle>>> GetTpdVehicle(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var tpdVehicle = await _service.GetTpdVehicle(uniqueId);
        return Ok(tpdVehicle);
    }

    /// <summary>
    /// Get a Traveler Search History record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/travelerSearchHistories")]
    public async Task<ActionResult<List<TravelerSearchHistory>>> GetTravelerSearchHistory(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var travelerSearchHistory = await _service.GetTravelerSearchHistory(uniqueId);
        return Ok(travelerSearchHistory);
    }

    /// <summary>
    /// Get a Travelers Articles Entry Exit record for GeneralTravelerInformationTpd
    /// </summary>
    [HttpGet("{Id}/travelersArticlesEntryExits")]
    public async Task<ActionResult<List<TravelersArticlesEntryExit>>> GetTravelersArticlesEntryExit(
        [FromRoute()] GeneralTravelerInformationTpdWhereUniqueInput uniqueId
    )
    {
        var travelersArticlesEntryExit = await _service.GetTravelersArticlesEntryExit(uniqueId);
        return Ok(travelersArticlesEntryExit);
    }
}
