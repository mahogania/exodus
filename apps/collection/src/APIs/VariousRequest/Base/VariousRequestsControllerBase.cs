using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class VariousRequestsControllerBase : ControllerBase
{
    protected readonly IVariousRequestsService _service;

    public VariousRequestsControllerBase(IVariousRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one VARIOUS REQUEST
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VariousRequest>> CreateVariousRequest(
        VariousRequestCreateInput input
    )
    {
        var variousRequest = await _service.CreateVariousRequest(input);

        return CreatedAtAction(
            nameof(VariousRequest),
            new { id = variousRequest.Id },
            variousRequest
        );
    }

    /// <summary>
    ///     Delete one VARIOUS REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteVariousRequest(
        [FromRoute] VariousRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteVariousRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many VARIOUS REQUESTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<VariousRequest>>> VariousRequests(
        [FromQuery] VariousRequestFindManyArgs filter
    )
    {
        return Ok(await _service.VariousRequests(filter));
    }

    /// <summary>
    ///     Meta data about VARIOUS REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> VariousRequestsMeta(
        [FromQuery] VariousRequestFindManyArgs filter
    )
    {
        return Ok(await _service.VariousRequestsMeta(filter));
    }

    /// <summary>
    ///     Get one VARIOUS REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<VariousRequest>> VariousRequest(
        [FromRoute] VariousRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.VariousRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one VARIOUS REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateVariousRequest(
        [FromRoute] VariousRequestWhereUniqueInput uniqueId,
        [FromQuery] VariousRequestUpdateInput variousRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateVariousRequest(uniqueId, variousRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
