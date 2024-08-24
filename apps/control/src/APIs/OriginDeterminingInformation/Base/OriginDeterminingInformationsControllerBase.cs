using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class OriginDeterminingInformationsControllerBase : ControllerBase
{
    protected readonly IOriginDeterminingInformationsService _service;

    public OriginDeterminingInformationsControllerBase(
        IOriginDeterminingInformationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Origin Determining Information
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<OriginDeterminingInformation>
    > CreateOriginDeterminingInformation(OriginDeterminingInformationCreateInput input)
    {
        var originDeterminingInformation = await _service.CreateOriginDeterminingInformation(input);

        return CreatedAtAction(
            nameof(OriginDeterminingInformation),
            new { id = originDeterminingInformation.Id },
            originDeterminingInformation
        );
    }

    /// <summary>
    /// Delete one Origin Determining Information
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteOriginDeterminingInformation(
        [FromRoute()] OriginDeterminingInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteOriginDeterminingInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many INFORMATIONS FOR DETERMINING ORIGIN
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<OriginDeterminingInformation>>
    > OriginDeterminingInformations([FromQuery()] OriginDeterminingInformationFindManyArgs filter)
    {
        return Ok(await _service.OriginDeterminingInformations(filter));
    }

    /// <summary>
    /// Meta data about Origin Determining Information records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> OriginDeterminingInformationsMeta(
        [FromQuery()] OriginDeterminingInformationFindManyArgs filter
    )
    {
        return Ok(await _service.OriginDeterminingInformationsMeta(filter));
    }

    /// <summary>
    /// Get one Origin Determining Information
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<OriginDeterminingInformation>> OriginDeterminingInformation(
        [FromRoute()] OriginDeterminingInformationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.OriginDeterminingInformation(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Origin Determining Information
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateOriginDeterminingInformation(
        [FromRoute()] OriginDeterminingInformationWhereUniqueInput uniqueId,
        [FromQuery()] OriginDeterminingInformationUpdateInput originDeterminingInformationUpdateDto
    )
    {
        try
        {
            await _service.UpdateOriginDeterminingInformation(
                uniqueId,
                originDeterminingInformationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
