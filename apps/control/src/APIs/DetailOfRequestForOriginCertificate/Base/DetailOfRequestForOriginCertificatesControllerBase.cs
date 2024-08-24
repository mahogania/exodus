using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DetailOfRequestForOriginCertificatesControllerBase : ControllerBase
{
    protected readonly IDetailOfRequestForOriginCertificatesService _service;

    public DetailOfRequestForOriginCertificatesControllerBase(
        IDetailOfRequestForOriginCertificatesService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Detail of Request for Origin Certificate
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfRequestForOriginCertificate>
    > CreateDetailOfRequestForOriginCertificate(
        DetailOfRequestForOriginCertificateCreateInput input
    )
    {
        var detailOfRequestForOriginCertificate =
            await _service.CreateDetailOfRequestForOriginCertificate(input);

        return CreatedAtAction(
            nameof(DetailOfRequestForOriginCertificate),
            new { id = detailOfRequestForOriginCertificate.Id },
            detailOfRequestForOriginCertificate
        );
    }

    /// <summary>
    /// Delete one Detail of Request for Origin Certificate
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDetailOfRequestForOriginCertificate(
        [FromRoute()] DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDetailOfRequestForOriginCertificate(uniqueId);
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
        ActionResult<List<DetailOfRequestForOriginCertificate>>
    > DetailOfRequestForOriginCertificates(
        [FromQuery()] DetailOfRequestForOriginCertificateFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfRequestForOriginCertificates(filter));
    }

    /// <summary>
    /// Meta data about Detail of Request for Origin Certificate records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> DetailOfRequestForOriginCertificatesMeta(
        [FromQuery()] DetailOfRequestForOriginCertificateFindManyArgs filter
    )
    {
        return Ok(await _service.DetailOfRequestForOriginCertificatesMeta(filter));
    }

    /// <summary>
    /// Get one Detail of Request for Origin Certificate
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DetailOfRequestForOriginCertificate>
    > DetailOfRequestForOriginCertificate(
        [FromRoute()] DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DetailOfRequestForOriginCertificate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Detail of Request for Origin Certificate
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDetailOfRequestForOriginCertificate(
        [FromRoute()] DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId,
        [FromQuery()]
            DetailOfRequestForOriginCertificateUpdateInput detailOfRequestForOriginCertificateUpdateDto
    )
    {
        try
        {
            await _service.UpdateDetailOfRequestForOriginCertificate(
                uniqueId,
                detailOfRequestForOriginCertificateUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Common Origin Certificate Request record for Detail of Request for Origin Certificate
    /// </summary>
    [HttpGet("{Id}/commonOriginCertificateRequests")]
    public async Task<
        ActionResult<List<CommonOriginCertificateRequest>>
    > GetCommonOriginCertificateRequest(
        [FromRoute()] DetailOfRequestForOriginCertificateWhereUniqueInput uniqueId
    )
    {
        var commonOriginCertificateRequest = await _service.GetCommonOriginCertificateRequest(
            uniqueId
        );
        return Ok(commonOriginCertificateRequest);
    }
}
