using Clre.APIs;
using Clre.APIs.Common;
using Clre.APIs.Dtos;
using Clre.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Clre.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonOriginCertificateRequestsControllerBase : ControllerBase
{
    protected readonly ICommonOriginCertificateRequestsService _service;

    public CommonOriginCertificateRequestsControllerBase(
        ICommonOriginCertificateRequestsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<CommonOriginCertificateRequest>
    > CreateCommonOriginCertificateRequest(CommonOriginCertificateRequestCreateInput input)
    {
        var commonOriginCertificateRequest = await _service.CreateCommonOriginCertificateRequest(
            input
        );

        return CreatedAtAction(
            nameof(CommonOriginCertificateRequest),
            new { id = commonOriginCertificateRequest.Id },
            commonOriginCertificateRequest
        );
    }

    /// <summary>
    /// Delete one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonOriginCertificateRequest(
        [FromRoute()] CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonOriginCertificateRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON ORIGIN CERTIFICATE REQUESTS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<CommonOriginCertificateRequest>>
    > CommonOriginCertificateRequests(
        [FromQuery()] CommonOriginCertificateRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonOriginCertificateRequests(filter));
    }

    /// <summary>
    /// Meta data about COMMON ORIGIN CERTIFICATE REQUEST records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonOriginCertificateRequestsMeta(
        [FromQuery()] CommonOriginCertificateRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonOriginCertificateRequestsMeta(filter));
    }

    /// <summary>
    /// Get one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonOriginCertificateRequest>> CommonOriginCertificateRequest(
        [FromRoute()] CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonOriginCertificateRequest(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COMMON ORIGIN CERTIFICATE REQUEST
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonOriginCertificateRequest(
        [FromRoute()] CommonOriginCertificateRequestWhereUniqueInput uniqueId,
        [FromQuery()]
            CommonOriginCertificateRequestUpdateInput commonOriginCertificateRequestUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonOriginCertificateRequest(
                uniqueId,
                commonOriginCertificateRequestUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
