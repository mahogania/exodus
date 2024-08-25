using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ModelValueEvaluationVerificationsControllerBase : ControllerBase
{
    protected readonly IModelValueEvaluationVerificationsService _service;

    public ModelValueEvaluationVerificationsControllerBase(
        IModelValueEvaluationVerificationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Model Value Evaluation Verification
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ModelValueEvaluationVerification>
    > CreateModelValueEvaluationVerification(ModelValueEvaluationVerificationCreateInput input)
    {
        var modelValueEvaluationVerification =
            await _service.CreateModelValueEvaluationVerification(input);

        return CreatedAtAction(
            nameof(ModelValueEvaluationVerification),
            new { id = modelValueEvaluationVerification.Id },
            modelValueEvaluationVerification
        );
    }

    /// <summary>
    /// Delete one Model Value Evaluation Verification
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteModelValueEvaluationVerification(
        [FromRoute()] ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteModelValueEvaluationVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Value Evaluation Model Verifications
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ModelValueEvaluationVerification>>
    > ModelValueEvaluationVerifications(
        [FromQuery()] ModelValueEvaluationVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.ModelValueEvaluationVerifications(filter));
    }

    /// <summary>
    /// Meta data about Model Value Evaluation Verification records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ModelValueEvaluationVerificationsMeta(
        [FromQuery()] ModelValueEvaluationVerificationFindManyArgs filter
    )
    {
        return Ok(await _service.ModelValueEvaluationVerificationsMeta(filter));
    }

    /// <summary>
    /// Get one Model Value Evaluation Verification
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ModelValueEvaluationVerification>
    > ModelValueEvaluationVerification(
        [FromRoute()] ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ModelValueEvaluationVerification(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Model Value Evaluation Verification
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateModelValueEvaluationVerification(
        [FromRoute()] ModelValueEvaluationVerificationWhereUniqueInput uniqueId,
        [FromQuery()]
            ModelValueEvaluationVerificationUpdateInput modelValueEvaluationVerificationUpdateDto
    )
    {
        try
        {
            await _service.UpdateModelValueEvaluationVerification(
                uniqueId,
                modelValueEvaluationVerificationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Articles Submitted For Verification record for Model Value Evaluation Verification
    /// </summary>
    [HttpGet("{Id}/articlesSubmittedForVerifications")]
    public async Task<
        ActionResult<List<ArticlesSubmittedForVerification>>
    > GetArticlesSubmittedForVerification(
        [FromRoute()] ModelValueEvaluationVerificationWhereUniqueInput uniqueId
    )
    {
        var articlesSubmittedForVerification = await _service.GetArticlesSubmittedForVerification(
            uniqueId
        );
        return Ok(articlesSubmittedForVerification);
    }
}
