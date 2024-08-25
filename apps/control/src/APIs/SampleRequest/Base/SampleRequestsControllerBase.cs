using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class SampleRequestsControllerBase : ControllerBase
{
    protected readonly ISampleRequestsService _service;

    public SampleRequestsControllerBase(ISampleRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Sample Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<SampleRequest>> CreateSampleRequest(
        SampleRequestCreateInput input
    )
    {
        var sampleRequest = await _service.CreateSampleRequest(input);

        return CreatedAtAction(nameof(SampleRequest), new { id = sampleRequest.Id }, sampleRequest);
    }

    /// <summary>
    /// Delete one Sample Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteSampleRequest(
        [FromRoute()] SampleRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteSampleRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Sample Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<SampleRequest>>> SampleRequests(
        [FromQuery()] SampleRequestFindManyArgs filter
    )
    {
        return Ok(await _service.SampleRequests(filter));
    }

    /// <summary>
    /// Meta data about Sample Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> SampleRequestsMeta(
        [FromQuery()] SampleRequestFindManyArgs filter
    )
    {
        return Ok(await _service.SampleRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Sample Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<SampleRequest>> SampleRequest(
        [FromRoute()] SampleRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.SampleRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Sample Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateSampleRequest(
        [FromRoute()] SampleRequestWhereUniqueInput uniqueId,
        [FromQuery()] SampleRequestUpdateInput sampleRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateSampleRequest(uniqueId, sampleRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Analysis Request record for Sample Request
    /// </summary>
    [HttpGet("{Id}/analysisRequests")]
    public async Task<ActionResult<List<AnalysisRequest>>> GetAnalysisRequest(
        [FromRoute()] SampleRequestWhereUniqueInput uniqueId
    )
    {
        var analysisRequest = await _service.GetAnalysisRequest(uniqueId);
        return Ok(analysisRequest);
    }

    /// <summary>
    /// Get a article record for Sample Request
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticle(
        [FromRoute()] SampleRequestWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticle(uniqueId);
        return Ok(article);
    }
}
