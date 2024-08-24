using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class TemporaryAdmissionForPerfectionsControllerBase : ControllerBase
{
    protected readonly ITemporaryAdmissionForPerfectionsService _service;

    public TemporaryAdmissionForPerfectionsControllerBase(
        ITemporaryAdmissionForPerfectionsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Temporary Admission For Perfection
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<TemporaryAdmissionForPerfection>
    > CreateTemporaryAdmissionForPerfection(TemporaryAdmissionForPerfectionCreateInput input)
    {
        var temporaryAdmissionForPerfection = await _service.CreateTemporaryAdmissionForPerfection(
            input
        );

        return CreatedAtAction(
            nameof(TemporaryAdmissionForPerfection),
            new { id = temporaryAdmissionForPerfection.Id },
            temporaryAdmissionForPerfection
        );
    }

    /// <summary>
    /// Delete one Temporary Admission For Perfection
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteTemporaryAdmissionForPerfection(
        [FromRoute()] TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteTemporaryAdmissionForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many TEMPORARY ADMISSION FOR PERFECTIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<TemporaryAdmissionForPerfection>>
    > TemporaryAdmissionForPerfections(
        [FromQuery()] TemporaryAdmissionForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.TemporaryAdmissionForPerfections(filter));
    }

    /// <summary>
    /// Meta data about Temporary Admission For Perfection records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> TemporaryAdmissionForPerfectionsMeta(
        [FromQuery()] TemporaryAdmissionForPerfectionFindManyArgs filter
    )
    {
        return Ok(await _service.TemporaryAdmissionForPerfectionsMeta(filter));
    }

    /// <summary>
    /// Get one Temporary Admission For Perfection
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<TemporaryAdmissionForPerfection>
    > TemporaryAdmissionForPerfection(
        [FromRoute()] TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.TemporaryAdmissionForPerfection(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Temporary Admission For Perfection
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateTemporaryAdmissionForPerfection(
        [FromRoute()] TemporaryAdmissionForPerfectionWhereUniqueInput uniqueId,
        [FromQuery()]
            TemporaryAdmissionForPerfectionUpdateInput temporaryAdmissionForPerfectionUpdateDto
    )
    {
        try
        {
            await _service.UpdateTemporaryAdmissionForPerfection(
                uniqueId,
                temporaryAdmissionForPerfectionUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
