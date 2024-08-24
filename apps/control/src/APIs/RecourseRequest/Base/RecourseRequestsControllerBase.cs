using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RecourseRequestsControllerBase : ControllerBase
{
    protected readonly IRecourseRequestsService _service;

    public RecourseRequestsControllerBase(IRecourseRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Recourse Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RecourseRequest>> CreateRecourseRequest(
        RecourseRequestCreateInput input
    )
    {
        var recourseRequest = await _service.CreateRecourseRequest(input);

        return CreatedAtAction(
            nameof(RecourseRequest),
            new { id = recourseRequest.Id },
            recourseRequest
        );
    }

    /// <summary>
    /// Delete one Recourse Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRecourseRequest(
        [FromRoute()] RecourseRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRecourseRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REQUEST FOR RECOURSES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RecourseRequest>>> RecourseRequests(
        [FromQuery()] RecourseRequestFindManyArgs filter
    )
    {
        return Ok(await _service.RecourseRequests(filter));
    }

    /// <summary>
    /// Meta data about Recourse Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RecourseRequestsMeta(
        [FromQuery()] RecourseRequestFindManyArgs filter
    )
    {
        return Ok(await _service.RecourseRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Recourse Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RecourseRequest>> RecourseRequest(
        [FromRoute()] RecourseRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RecourseRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Recourse Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRecourseRequest(
        [FromRoute()] RecourseRequestWhereUniqueInput uniqueId,
        [FromQuery()] RecourseRequestUpdateInput recourseRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateRecourseRequest(uniqueId, recourseRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Journal record for Recourse Request
    /// </summary>
    [HttpGet("{Id}/journals")]
    public async Task<ActionResult<List<Journal>>> GetJournal(
        [FromRoute()] RecourseRequestWhereUniqueInput uniqueId
    )
    {
        var journal = await _service.GetJournal(uniqueId);
        return Ok(journal);
    }
}
