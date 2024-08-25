using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonVerificationsControllerBase : ControllerBase
{
    protected readonly ICommonVerificationsService _service;

    public CommonVerificationsControllerBase(ICommonVerificationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Common Verification
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonVerification>> CreateCommonVerification(
        CommonVerificationCreateInput input
    )
    {
        var commonVerification = await _service.CreateCommonVerification(input);

        return CreatedAtAction(
            nameof(CommonVerification),
            new { id = commonVerification.Id },
            commonVerification
        );
    }

    /// <summary>
    /// Delete one Common Verification
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Common Verification Of The Evaluation Of Values Of The Detailed Declarations
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonVerification>>> CommonVerifications(
        [FromQuery()] CommonVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonVerifications(filter));
    }

    /// <summary>
    /// Meta data about Common Verification records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonVerificationsMeta(
        [FromQuery()] CommonVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonVerificationsMeta(filter));
    }

    /// <summary>
    /// Get one Common Verification
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonVerification>> CommonVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Common Verification
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
        [FromQuery()] CommonVerificationUpdateInput commonVerificationUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonVerification(uniqueId, commonVerificationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Appeal record for Common Verification
    /// </summary>
    [HttpGet("{Id}/appeals")]
    public async Task<ActionResult<List<Appeal>>> GetAppeal(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var appeal = await _service.GetAppeal(uniqueId);
        return Ok(appeal);
    }

    /// <summary>
    /// Get a Articles Submitted For Verification record for Common Verification
    /// </summary>
    [HttpGet("{Id}/articlesSubmittedForVerifications")]
    public async Task<
        ActionResult<List<ArticlesSubmittedForVerification>>
    > GetArticlesSubmittedForVerification([FromRoute()] CommonVerificationWhereUniqueInput uniqueId)
    {
        var articlesSubmittedForVerification = await _service.GetArticlesSubmittedForVerification(
            uniqueId
        );
        return Ok(articlesSubmittedForVerification);
    }

    /// <summary>
    /// Connect multiple Container Value Assessments records to Common Verification
    /// </summary>
    [HttpPost("{Id}/containerValueAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectContainerValueAssessments(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
        [FromQuery()] ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        try
        {
            await _service.ConnectContainerValueAssessments(uniqueId, containerValueAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Container Value Assessments records from Common Verification
    /// </summary>
    [HttpDelete("{Id}/containerValueAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectContainerValueAssessments(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
        [FromBody()] ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        try
        {
            await _service.DisconnectContainerValueAssessments(
                uniqueId,
                containerValueAssessmentsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Container Value Assessments records for Common Verification
    /// </summary>
    [HttpGet("{Id}/containerValueAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ContainerValueAssessment>>> FindContainerValueAssessments(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
        [FromQuery()] ContainerValueAssessmentFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindContainerValueAssessments(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Container Value Assessments records for Common Verification
    /// </summary>
    [HttpPatch("{Id}/containerValueAssessments")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateContainerValueAssessments(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
        [FromBody()] ContainerValueAssessmentWhereUniqueInput[] containerValueAssessmentsId
    )
    {
        try
        {
            await _service.UpdateContainerValueAssessments(uniqueId, containerValueAssessmentsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Taxes For Verification records to Common Verification
    /// </summary>
    [HttpPost("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectTaxesForVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
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
    /// Disconnect multiple Taxes For Verification records from Common Verification
    /// </summary>
    [HttpDelete("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectTaxesForVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
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
    /// Find multiple Taxes For Verification records for Common Verification
    /// </summary>
    [HttpGet("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<TaxForVerification>>> FindTaxesForVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
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
    /// Update multiple Taxes For Verification records for Common Verification
    /// </summary>
    [HttpPatch("{Id}/taxForVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTaxesForVerification(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId,
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

    /// <summary>
    /// Get a Verification Result record for Common Verification
    /// </summary>
    [HttpGet("{Id}/verificationResults")]
    public async Task<ActionResult<List<VerificationResult>>> GetVerificationResult(
        [FromRoute()] CommonVerificationWhereUniqueInput uniqueId
    )
    {
        var verificationResult = await _service.GetVerificationResult(uniqueId);
        return Ok(verificationResult);
    }
}
