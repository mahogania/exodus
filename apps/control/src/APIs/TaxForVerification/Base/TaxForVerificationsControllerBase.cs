using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TaxForVerificationsControllerBase : ControllerBase
{
    protected readonly ITaxForVerificationsService _service;

    public TaxForVerificationsControllerBase(ITaxForVerificationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Tax For Verification
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TaxForVerification>> CreateTaxForVerification(
        TaxForVerificationCreateInput input
    )
    {
        var taxForVerification = await _service.CreateTaxForVerification(input);

        return CreatedAtAction(
            nameof(TaxForVerification),
            new { id = taxForVerification.Id },
            taxForVerification
        );
    }

    /// <summary>
    /// Delete one Tax For Verification
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTaxForVerification(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTaxForVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Tax For Verifications
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TaxForVerification>>> TaxForVerifications(
        [FromQuery()] TaxForVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.TaxForVerifications(filter));
    }

    /// <summary>
    /// Meta data about Tax For Verification records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TaxForVerificationsMeta(
        [FromQuery()] TaxForVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.TaxForVerificationsMeta(filter));
    }

    /// <summary>
    /// Get one Tax For Verification
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<TaxForVerification>> TaxForVerification(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TaxForVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Tax For Verification
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTaxForVerification(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId,
        [FromQuery()] TaxForVerificationUpdateInput taxForVerificationUpdateDto
    )
    {
        try
        {
            await _service.UpdateTaxForVerification(uniqueId, taxForVerificationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Articles Submitted For Verifications record for Tax For Verification
    /// </summary>
    [HttpGet("{Id}/articlesSubmittedForVerifications")]
    public async Task<
        ActionResult<List<ArticlesSubmittedForVerification>>
    > GetArticlesSubmittedForVerifications(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId
    )
    {
        var articlesSubmittedForVerification = await _service.GetArticlesSubmittedForVerifications(
            uniqueId
        );
        return Ok(articlesSubmittedForVerification);
    }

    /// <summary>
    /// Connect multiple Common Verifications records to Tax For Verification
    /// </summary>
    [HttpPost("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonVerifications(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId,
        [FromQuery()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.ConnectCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Verifications records from Tax For Verification
    /// </summary>
    [HttpDelete("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonVerifications(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId,
        [FromBody()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.DisconnectCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Verifications records for Tax For Verification
    /// </summary>
    [HttpGet("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonVerification>>> FindCommonVerifications(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId,
        [FromQuery()] CommonVerificationFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonVerifications(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Verifications records for Tax For Verification
    /// </summary>
    [HttpPatch("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonVerifications(
        [FromRoute()] TaxForVerificationWhereUniqueInput uniqueId,
        [FromBody()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.UpdateCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
