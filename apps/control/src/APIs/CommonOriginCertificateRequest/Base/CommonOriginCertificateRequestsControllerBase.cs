using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

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
    /// Create one Common Origin Certificate Request
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
    /// Delete one Common Origin Certificate Request
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
    /// Meta data about Common Origin Certificate Request records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonOriginCertificateRequestsMeta(
        [FromQuery()] CommonOriginCertificateRequestFindManyArgs filter
    )
    {
        return Ok(await _service.CommonOriginCertificateRequestsMeta(filter));
    }

    /// <summary>
    /// Get one Common Origin Certificate Request
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
    /// Update one Common Origin Certificate Request
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

    /// <summary>
    /// Get a Request record for Common Origin Certificate Request
    /// </summary>
    [HttpGet("{Id}/procedures")]
    public async Task<ActionResult<List<Procedure>>> GetRequest(
        [FromRoute()] CommonOriginCertificateRequestWhereUniqueInput uniqueId
    )
    {
        var procedure = await _service.GetRequest(uniqueId);
        return Ok(procedure);
    }
}
