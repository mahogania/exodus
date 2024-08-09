using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RequestForCommonCarnetsControllerBase : ControllerBase
{
    protected readonly IRequestForCommonCarnetsService _service;

    public RequestForCommonCarnetsControllerBase(IRequestForCommonCarnetsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one REQUEST FOR COMMON CARNET
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RequestForCommonCarnet>> CreateRequestForCommonCarnet(
        RequestForCommonCarnetCreateInput input
    )
    {
        var requestForCommonCarnet = await _service.CreateRequestForCommonCarnet(input);

        return CreatedAtAction(
            nameof(RequestForCommonCarnet),
            new { id = requestForCommonCarnet.Id },
            requestForCommonCarnet
        );
    }

    /// <summary>
    /// Delete one REQUEST FOR COMMON CARNET
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRequestForCommonCarnet(
        [FromRoute()] RequestForCommonCarnetWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRequestForCommonCarnet(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REQUEST FOR COMMON CARNETS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<RequestForCommonCarnet>>> RequestForCommonCarnets(
        [FromQuery()] RequestForCommonCarnetFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForCommonCarnets(filter));
    }

    /// <summary>
    /// Meta data about REQUEST FOR COMMON CARNET records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> RequestForCommonCarnetsMeta(
        [FromQuery()] RequestForCommonCarnetFindManyArgs filter
    )
    {
        return Ok(await _service.RequestForCommonCarnetsMeta(filter));
    }

    /// <summary>
    /// Get one REQUEST FOR COMMON CARNET
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<RequestForCommonCarnet>> RequestForCommonCarnet(
        [FromRoute()] RequestForCommonCarnetWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RequestForCommonCarnet(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REQUEST FOR COMMON CARNET
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRequestForCommonCarnet(
        [FromRoute()] RequestForCommonCarnetWhereUniqueInput uniqueId,
        [FromQuery()] RequestForCommonCarnetUpdateInput requestForCommonCarnetUpdateDto
    )
    {
        try
        {
            await _service.UpdateRequestForCommonCarnet(uniqueId, requestForCommonCarnetUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
