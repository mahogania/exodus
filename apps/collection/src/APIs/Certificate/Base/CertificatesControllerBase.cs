using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class CertificatesControllerBase : ControllerBase
{
    protected readonly ICertificatesService _service;

    public CertificatesControllerBase(ICertificatesService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one CERTIFICATE
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Certificate>> CreateCertificate(CertificateCreateInput input)
    {
        var certificate = await _service.CreateCertificate(input);

        return CreatedAtAction(nameof(Certificate), new { id = certificate.Id }, certificate);
    }

    /// <summary>
    ///     Delete one CERTIFICATE
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCertificate(
        [FromRoute] CertificateWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCertificate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    ///     Find many CERTIFICATES
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Certificate>>> Certificates(
        [FromQuery] CertificateFindManyArgs filter
    )
    {
        return Ok(await _service.Certificates(filter));
    }

    /// <summary>
    ///     Meta data about CERTIFICATE records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CertificatesMeta(
        [FromQuery] CertificateFindManyArgs filter
    )
    {
        return Ok(await _service.CertificatesMeta(filter));
    }

    /// <summary>
    ///     Get one CERTIFICATE
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Certificate>> Certificate(
        [FromRoute] CertificateWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.Certificate(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    ///     Update one CERTIFICATE
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCertificate(
        [FromRoute] CertificateWhereUniqueInput uniqueId,
        [FromQuery] CertificateUpdateInput certificateUpdateDto
    )
    {
        try
        {
            await _service.UpdateCertificate(uniqueId, certificateUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
