using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailOfRequestForCertificateOfOriginsControllerBase : ControllerBase
{
    protected readonly IDetailOfRequestForCertificateOfOriginsService _service;

    public DetailOfRequestForCertificateOfOriginsControllerBase(
        IDetailOfRequestForCertificateOfOriginsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfRequestForCertificateOfOrigin>
    > CreateDetailOfRequestForCertificateOfOrigin(
        DetailOfRequestForCertificateOfOriginCreateInput input
    )
    {
        var detailOfRequestForCertificateOfOrigin =
            await _service.CreateDetailOfRequestForCertificateOfOrigin(input);

        return CreatedAtAction(
            nameof(DetailOfRequestForCertificateOfOrigin),
            new { id = detailOfRequestForCertificateOfOrigin.Id },
            detailOfRequestForCertificateOfOrigin
        );
    }

    /// <summary>
    /// Delete one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailOfRequestForCertificateOfOrigin(
        [FromRoute()] DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailOfRequestForCertificateOfOrigin(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DETAIL OF REQUEST FOR CERTIFICATE OF ORIGINS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<DetailOfRequestForCertificateOfOrigin>>
    > DetailOfRequestForCertificateOfOrigins(
        [FromQuery()] DetailOfRequestForCertificateOfOriginFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfRequestForCertificateOfOrigins(filter));
    }

    /// <summary>
    /// Meta data about DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailOfRequestForCertificateOfOriginsMeta(
        [FromQuery()] DetailOfRequestForCertificateOfOriginFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfRequestForCertificateOfOriginsMeta(filter));
    }

    /// <summary>
    /// Get one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfRequestForCertificateOfOrigin>
    > DetailOfRequestForCertificateOfOrigin(
        [FromRoute()] DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailOfRequestForCertificateOfOrigin(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DETAIL OF REQUEST FOR CERTIFICATE OF ORIGIN
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailOfRequestForCertificateOfOrigin(
        [FromRoute()] DetailOfRequestForCertificateOfOriginWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailOfRequestForCertificateOfOriginUpdateInput detailOfRequestForCertificateOfOriginUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailOfRequestForCertificateOfOrigin(
                uniqueId,
                detailOfRequestForCertificateOfOriginUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
