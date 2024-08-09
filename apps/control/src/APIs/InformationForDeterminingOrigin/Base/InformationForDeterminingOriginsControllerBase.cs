using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class InformationForDeterminingOriginsControllerBase : ControllerBase
{
    protected readonly IInformationForDeterminingOriginsService _service;

    public InformationForDeterminingOriginsControllerBase(
        IInformationForDeterminingOriginsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationForDeterminingOrigin>
    > CreateInformationForDeterminingOrigin(InformationForDeterminingOriginCreateInput input)
    {
        var informationForDeterminingOrigin = await _service.CreateInformationForDeterminingOrigin(
            input
        );

        return CreatedAtAction(
            nameof(InformationForDeterminingOrigin),
            new { id = informationForDeterminingOrigin.Id },
            informationForDeterminingOrigin
        );
    }

    /// <summary>
    /// Delete one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteInformationForDeterminingOrigin(
        [FromRoute()] InformationForDeterminingOriginWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteInformationForDeterminingOrigin(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many INFORMATION FOR DETERMINING ORIGIN | CLRES
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<InformationForDeterminingOrigin>>
    > InformationForDeterminingOrigins(
        [FromQuery()] InformationForDeterminingOriginFindManyArgs filter
    )
    {
        return Ok(await _service.InformationForDeterminingOrigins(filter));
    }

    /// <summary>
    /// Meta data about INFORMATION FOR DETERMINING ORIGIN records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> InformationForDeterminingOriginsMeta(
        [FromQuery()] InformationForDeterminingOriginFindManyArgs filter
    )
    {
        return Ok(await _service.InformationForDeterminingOriginsMeta(filter));
    }

    /// <summary>
    /// Get one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<InformationForDeterminingOrigin>
    > InformationForDeterminingOrigin(
        [FromRoute()] InformationForDeterminingOriginWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.InformationForDeterminingOrigin(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one INFORMATION FOR DETERMINING ORIGIN
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateInformationForDeterminingOrigin(
        [FromRoute()] InformationForDeterminingOriginWhereUniqueInput uniqueId,
        [FromQuery()]
            InformationForDeterminingOriginUpdateInput informationForDeterminingOriginUpdateDto
    )
    {
        try
        {
            await _service.UpdateInformationForDeterminingOrigin(
                uniqueId,
                informationForDeterminingOriginUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
