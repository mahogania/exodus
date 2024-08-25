using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class AppealsControllerBase : ControllerBase
{
    protected readonly IAppealsService _service;

    public AppealsControllerBase(IAppealsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Appeal
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> CreateAppeal(AppealCreateInput input)
    {
        var appeal = await _service.CreateAppeal(input);

        return CreatedAtAction(nameof(Appeal), new { id = appeal.Id }, appeal);
    }

    /// <summary>
    /// Delete one Appeal
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAppeal([FromRoute()] AppealWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteAppeal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Appeal On The Result Of The Verification Of The Evaluation Of ValuesItems
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Appeal>>> Appeals([FromQuery()] AppealFindManyArgs filter)
    {
        return Ok(await _service.Appeals(filter));
    }

    /// <summary>
    /// Meta data about Appeal records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AppealsMeta(
        [FromQuery()] AppealFindManyArgs filter
    )
    {
        return Ok(await _service.AppealsMeta(filter));
    }

    /// <summary>
    /// Get one Appeal
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> Appeal([FromRoute()] AppealWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Appeal(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Appeal
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAppeal(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromQuery()] AppealUpdateInput appealUpdateDto
    )
    {
        try
        {
            await _service.UpdateAppeal(uniqueId, appealUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Connect multiple Common Verifications records to Appeal
    /// </summary>
    [HttpPost("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> ConnectCommonVerifications(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromQuery()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.ConnectCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Disconnect multiple Common Verifications records from Appeal
    /// </summary>
    [HttpDelete("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DisconnectCommonVerifications(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromBody()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.DisconnectCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find multiple Common Verifications records for Appeal
    /// </summary>
    [HttpGet("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonVerification>>> FindCommonVerifications(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromQuery()] CommonVerificationFindManyArgs filter
    )
    {
        try
        {
            return Ok(await _service.FindCommonVerifications(uniqueId, filter));
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update multiple Common Verifications records for Appeal
    /// </summary>
    [HttpPatch("{Id}/commonVerifications")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonVerifications(
        [FromRoute()] AppealWhereUniqueInput uniqueId,
        [FromBody()] CommonVerificationWhereUniqueInput[] commonVerificationsId
    )
    {
        try
        {
            await _service.UpdateCommonVerifications(uniqueId, commonVerificationsId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
