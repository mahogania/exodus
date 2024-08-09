using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RequestForRecoursesControllerBase : ControllerBase
{
    protected readonly IRequestForRecoursesService _service;

    public RequestForRecoursesControllerBase(IRequestForRecoursesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one REQUEST FOR RECOURSE
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RequestForRecourse>> CreateRequestForRecourse(
        RequestForRecourseCreateInput input
    )
    {
        var requestForRecourse = await _service.CreateRequestForRecourse(input);

        return CreatedAtAction(
            nameof(RequestForRecourse),
            new { id = requestForRecourse.Id },
            requestForRecourse
        );
    }

    /// <summary>
    /// Delete one REQUEST FOR RECOURSE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRequestForRecourse(
        [FromRoute()] RequestForRecourseWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRequestForRecourse(uniqueId);
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
    public async Task<ActionResult<List<RequestForRecourse>>> RequestForRecourses(
        [FromQuery()] RequestForRecourseFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForRecourses(filter));
    }

    /// <summary>
    /// Meta data about REQUEST FOR RECOURSE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RequestForRecoursesMeta(
        [FromQuery()] RequestForRecourseFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForRecoursesMeta(filter));
    }

    /// <summary>
    /// Get one REQUEST FOR RECOURSE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RequestForRecourse>> RequestForRecourse(
        [FromRoute()] RequestForRecourseWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RequestForRecourse(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REQUEST FOR RECOURSE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRequestForRecourse(
        [FromRoute()] RequestForRecourseWhereUniqueInput uniqueId,
        [FromQuery()] RequestForRecourseUpdateInput requestForRecourseUpdateDto
    )
    {
        try
        {
            await _service.UpdateRequestForRecourse(uniqueId, requestForRecourseUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
