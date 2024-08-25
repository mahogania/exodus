using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ContainerValueAssessmentsControllerBase : ControllerBase
{
    protected readonly IContainerValueAssessmentsService _service;

    public ContainerValueAssessmentsControllerBase(IContainerValueAssessmentsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Container Value Assessment
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ContainerValueAssessment>> CreateContainerValueAssessment(
        ContainerValueAssessmentCreateInput input
    )
    {
        var containerValueAssessment = await _service.CreateContainerValueAssessment(input);

        return CreatedAtAction(
            nameof(ContainerValueAssessment),
            new { id = containerValueAssessment.Id },
            containerValueAssessment
        );
    }

    /// <summary>
    /// Delete one Container Value Assessment
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteContainerValueAssessment(
        [FromRoute()] ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteContainerValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Value Evaluation_Containers
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ContainerValueAssessment>>> ContainerValueAssessments(
        [FromQuery()] ContainerValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerValueAssessments(filter));
    }

    /// <summary>
    /// Meta data about Container Value Assessment records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ContainerValueAssessmentsMeta(
        [FromQuery()] ContainerValueAssessmentFindManyArgs filter
    )
    {
        return Ok(await _service.ContainerValueAssessmentsMeta(filter));
    }

    /// <summary>
    /// Get one Container Value Assessment
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ContainerValueAssessment>> ContainerValueAssessment(
        [FromRoute()] ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ContainerValueAssessment(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Container Value Assessment
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateContainerValueAssessment(
        [FromRoute()] ContainerValueAssessmentWhereUniqueInput uniqueId,
        [FromQuery()] ContainerValueAssessmentUpdateInput containerValueAssessmentUpdateDto
    )
    {
        try
        {
            await _service.UpdateContainerValueAssessment(
                uniqueId,
                containerValueAssessmentUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Verification record for Container Value Assessment
    /// </summary>
    [HttpGet("{Id}/commonVerifications")]
    public async Task<ActionResult<List<CommonVerification>>> GetCommonVerification(
        [FromRoute()] ContainerValueAssessmentWhereUniqueInput uniqueId
    )
    {
        var commonVerification = await _service.GetCommonVerification(uniqueId);
        return Ok(commonVerification);
    }
}
