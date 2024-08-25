using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ArticlesSubmittedForVerificationsControllerBase : ControllerBase
{
    protected readonly IArticlesSubmittedForVerificationsService _service;

    public ArticlesSubmittedForVerificationsControllerBase(
        IArticlesSubmittedForVerificationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Articles Submitted For Verification
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlesSubmittedForVerification>
    > CreateArticlesSubmittedForVerification(ArticlesSubmittedForVerificationCreateInput input)
    {
        var articlesSubmittedForVerification =
            await _service.CreateArticlesSubmittedForVerification(input);

        return CreatedAtAction(
            nameof(ArticlesSubmittedForVerification),
            new { id = articlesSubmittedForVerification.Id },
            articlesSubmittedForVerification
        );
    }

    /// <summary>
    /// Delete one Articles Submitted For Verification
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteArticlesSubmittedForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteArticlesSubmittedForVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Articles Submitted For Verifications
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ArticlesSubmittedForVerification>>
    > ArticlesSubmittedForVerifications(
        [FromQuery()] ArticlesSubmittedForVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlesSubmittedForVerifications(filter));
    }

    /// <summary>
    /// Meta data about Articles Submitted For Verification records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ArticlesSubmittedForVerificationsMeta(
        [FromQuery()] ArticlesSubmittedForVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.ArticlesSubmittedForVerificationsMeta(filter));
    }

    /// <summary>
    /// Get one Articles Submitted For Verification
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ArticlesSubmittedForVerification>
    > ArticlesSubmittedForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ArticlesSubmittedForVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Articles Submitted For Verification
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateArticlesSubmittedForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        [FromQuery()]
            ArticlesSubmittedForVerificationUpdateInput articlesSubmittedForVerificationUpdateDto
    )
    {
        try
        {
            await _service.UpdateArticlesSubmittedForVerification(
                uniqueId,
                articlesSubmittedForVerificationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Common Verification records to Articles Submitted For Verification
    /// </summary>
    [HttpPost("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Common Verification records from Articles Submitted For Verification
    /// </summary>
    [HttpDelete("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
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
    /// Find multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    [HttpGet("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonVerification>>> FindCommonVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
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
    /// Update multiple Common Verification records for Articles Submitted For Verification
    /// </summary>
    [HttpPatch("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
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

    /// <summary>
    /// Connect multiple Taxes For Verification records to Articles Submitted For Verification
    /// </summary>
    [HttpPost("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectTaxesForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        [FromQuery()] TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        try
        {
            await _service.ConnectTaxesForVerification(uniqueId, taxForVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Taxes For Verification records from Articles Submitted For Verification
    /// </summary>
    [HttpDelete("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectTaxesForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        [FromBody()] TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        try
        {
            await _service.DisconnectTaxesForVerification(uniqueId, taxForVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    [HttpGet("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TaxForVerification>>> FindTaxesForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        [FromQuery()] TaxForVerificationFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindTaxesForVerification(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Taxes For Verification records for Articles Submitted For Verification
    /// </summary>
    [HttpPatch("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTaxesForVerification(
        [FromRoute()] ArticlesSubmittedForVerificationWhereUniqueInput uniqueId,
        [FromBody()] TaxForVerificationWhereUniqueInput[] taxForVerificationsId
    )
    {
        try
        {
            await _service.UpdateTaxesForVerification(uniqueId, taxForVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
