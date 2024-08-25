using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AnalysisRequestsControllerBase : ControllerBase
{
    protected readonly IAnalysisRequestsService _service;

    public AnalysisRequestsControllerBase(IAnalysisRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Analysis Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AnalysisRequest>> CreateAnalysisRequest(
        AnalysisRequestCreateInput input
    )
    {
        var analysisRequest = await _service.CreateAnalysisRequest(input);

        return CreatedAtAction(
            nameof(AnalysisRequest),
            new { id = analysisRequest.Id },
            analysisRequest
        );
    }

    /// <summary>
    /// Delete one Analysis Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAnalysisRequest(
        [FromRoute()] AnalysisRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteAnalysisRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Analysis Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<AnalysisRequest>>> AnalysisRequests(
        [FromQuery()] AnalysisRequestFindManyArgs filter
    )
    {
        return Ok(await _service.AnalysisRequests(filter));
    }

    /// <summary>
    /// Meta data about Analysis Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AnalysisRequestsMeta(
        [FromQuery()] AnalysisRequestFindManyArgs filter
    )
    {
        return Ok(await _service.AnalysisRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Analysis Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<AnalysisRequest>> AnalysisRequest(
        [FromRoute()] AnalysisRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.AnalysisRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Analysis Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAnalysisRequest(
        [FromRoute()] AnalysisRequestWhereUniqueInput uniqueId,
        [FromQuery()] AnalysisRequestUpdateInput analysisRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateAnalysisRequest(uniqueId, analysisRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Procedure record for Analysis Request
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetProcedure(
        [FromRoute()] AnalysisRequestWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetProcedure(uniqueId);
        return Ok(procedure);
    }

    /// <summary>
    /// Get a Sample Requests record for Analysis Request
    /// </summary>
    [HttpGet("{Id}/sampleRequests")]
    public async Task<ActionResult<List<SampleRequest>>> GetSampleRequests(
        [FromRoute()] AnalysisRequestWhereUniqueInput uniqueId
    )
    {
        var sampleRequest = await _service.GetSampleRequests(uniqueId);
        return Ok(sampleRequest);
    }
}
