using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class FineRequestsControllerBase : ControllerBase
{
    protected readonly IFineRequestsService _service;

    public FineRequestsControllerBase(IFineRequestsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one FINE REQUEST
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineRequest>> CreateFineRequest(FineRequestCreateInput input)
    {
        var fineRequest = await _service.CreateFineRequest(input);

        return CreatedAtAction(nameof(FineRequest), new { id = fineRequest.Id }, fineRequest);
    }

    /// <summary>
    ///     Delete one FINE REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteFineRequest(
        [FromRoute] FineRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteFineRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many FINE REQUESTS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<FineRequest>>> FineRequests(
        [FromQuery] FineRequestFindManyArgs filter
    )
    {
        return Ok(await _service.FineRequests(filter));
    }

    /// <summary>
    ///     Meta data about FINE REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> FineRequestsMeta(
        [FromQuery] FineRequestFindManyArgs filter
    )
    {
        return Ok(await _service.FineRequestsMeta(filter));
    }

    /// <summary>
    ///     Get one FINE REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<FineRequest>> FineRequest(
        [FromRoute] FineRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.FineRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one FINE REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateFineRequest(
        [FromRoute] FineRequestWhereUniqueInput uniqueId,
        [FromQuery] FineRequestUpdateInput fineRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateFineRequest(uniqueId, fineRequestUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
