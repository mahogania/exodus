using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class VerificationResultsControllerBase : ControllerBase
{
    protected readonly IVerificationResultsService _service;

    public VerificationResultsControllerBase(IVerificationResultsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Verification Result
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VerificationResult>> CreateVerificationResult(
        VerificationResultCreateInput input
    )
    {
        var verificationResult = await _service.CreateVerificationResult(input);

        return CreatedAtAction(
            nameof(VerificationResult),
            new { id = verificationResult.Id },
            verificationResult
        );
    }

    /// <summary>
    /// Delete one Verification Result
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteVerificationResult(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteVerificationResult(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Verification Results
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<VerificationResult>>> VerificationResults(
        [FromQuery()] VerificationResultFindManyArgs filter
    )
    {
        return Ok(await _service.VerificationResults(filter));
    }

    /// <summary>
    /// Meta data about Verification Result records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> VerificationResultsMeta(
        [FromQuery()] VerificationResultFindManyArgs filter
    )
    {
        return Ok(await _service.VerificationResultsMeta(filter));
    }

    /// <summary>
    /// Get one Verification Result
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VerificationResult>> VerificationResult(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.VerificationResult(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Verification Result
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateVerificationResult(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId,
        [FromQuery()] VerificationResultUpdateInput verificationResultUpdateDto
    )
    {
        try
        {
            await _service.UpdateVerificationResult(uniqueId, verificationResultUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Verification record for Verification Result
    /// </summary>
    [HttpGet("{Id}/commonVerifications")]
    public async Task<ActionResult<List<CommonVerification>>> GetCommonVerification(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId
    )
    {
        var commonVerification = await _service.GetCommonVerification(uniqueId);
        return Ok(commonVerification);
    }

    /// <summary>
    /// Connect multiple Verification Result Details records to Verification Result
    /// </summary>
    [HttpPost("{Id}/verificationResultDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectVerificationResultDetails(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId,
        [FromQuery()] VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        try
        {
            await _service.ConnectVerificationResultDetails(uniqueId, verificationResultDetailsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Verification Result Details records from Verification Result
    /// </summary>
    [HttpDelete("{Id}/verificationResultDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectVerificationResultDetails(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId,
        [FromBody()] VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        try
        {
            await _service.DisconnectVerificationResultDetails(
                uniqueId,
                verificationResultDetailsId
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Verification Result Details records for Verification Result
    /// </summary>
    [HttpGet("{Id}/verificationResultDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<VerificationResultDetail>>> FindVerificationResultDetails(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId,
        [FromQuery()] VerificationResultDetailFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindVerificationResultDetails(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Verification Result Details records for Verification Result
    /// </summary>
    [HttpPatch("{Id}/verificationResultDetails")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateVerificationResultDetails(
        [FromRoute()] VerificationResultWhereUniqueInput uniqueId,
        [FromBody()] VerificationResultDetailWhereUniqueInput[] verificationResultDetailsId
    )
    {
        try
        {
            await _service.UpdateVerificationResultDetails(uniqueId, verificationResultDetailsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
