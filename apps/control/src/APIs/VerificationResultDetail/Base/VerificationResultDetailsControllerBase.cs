using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class VerificationResultDetailsControllerBase : ControllerBase
{
    protected readonly IVerificationResultDetailsService _service;

    public VerificationResultDetailsControllerBase(IVerificationResultDetailsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Verification Result Detail
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VerificationResultDetail>> CreateVerificationResultDetail(
        VerificationResultDetailCreateInput input
    )
    {
        var verificationResultDetail = await _service.CreateVerificationResultDetail(input);

        return CreatedAtAction(
            nameof(VerificationResultDetail),
            new { id = verificationResultDetail.Id },
            verificationResultDetail
        );
    }

    /// <summary>
    /// Delete one Verification Result Detail
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteVerificationResultDetail(
        [FromRoute()] VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteVerificationResultDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Verification Result Details
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<VerificationResultDetail>>> VerificationResultDetails(
        [FromQuery()] VerificationResultDetailFindManyArgs filter
    )
    {
        return Ok(await _service.VerificationResultDetails(filter));
    }

    /// <summary>
    /// Meta data about Verification Result Detail records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> VerificationResultDetailsMeta(
        [FromQuery()] VerificationResultDetailFindManyArgs filter
    )
    {
        return Ok(await _service.VerificationResultDetailsMeta(filter));
    }

    /// <summary>
    /// Get one Verification Result Detail
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VerificationResultDetail>> VerificationResultDetail(
        [FromRoute()] VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.VerificationResultDetail(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Verification Result Detail
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateVerificationResultDetail(
        [FromRoute()] VerificationResultDetailWhereUniqueInput uniqueId,
        [FromQuery()] VerificationResultDetailUpdateInput verificationResultDetailUpdateDto
    )
    {
        try
        {
            await _service.UpdateVerificationResultDetail(
                uniqueId,
                verificationResultDetailUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Verification Result record for Verification Result Detail
    /// </summary>
    [HttpGet("{Id}/verificationResults")]
    public async Task<ActionResult<List<VerificationResult>>> GetVerificationResult(
        [FromRoute()] VerificationResultDetailWhereUniqueInput uniqueId
    )
    {
        var verificationResult = await _service.GetVerificationResult(uniqueId);
        return Ok(verificationResult);
    }
}
