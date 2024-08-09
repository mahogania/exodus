using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RequestsControllerBase : ControllerBase
{
    protected readonly IRequestsService _service;

    public RequestsControllerBase(IRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Request
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Request>> CreateRequest(RequestCreateInput input)
    {
        var request = await _service.CreateRequest(input);

        return CreatedAtAction(nameof(Request), new { id = request.Id }, request);
    }

    /// <summary>
    /// Delete one Request
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRequest([FromRoute()] RequestWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Requests
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Request>>> Requests(
        [FromQuery()] RequestFindManyArgs filter
    )
    {
        return Ok(await _service.Requests(filter));
    }

    /// <summary>
    /// Meta data about Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RequestsMeta(
        [FromQuery()] RequestFindManyArgs filter
    )
    {
        return Ok(await _service.RequestsMeta(filter));
    }

    /// <summary>
    /// Get one Request
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Request>> Request([FromRoute()] RequestWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Request(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Request
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRequest(
        [FromRoute()] RequestWhereUniqueInput uniqueId,
        [FromQuery()] RequestUpdateInput requestUpdateDto
    )
    {
        try
        {
            await _service.UpdateRequest(uniqueId, requestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
