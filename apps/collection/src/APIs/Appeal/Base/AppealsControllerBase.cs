using Collection.APIs.Common;
using Collection.APIs.Dtos;
using Collection.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Collection.APIs;

[Route("api/[controller]")]
[ApiController]
public abstract class AppealsControllerBase : ControllerBase
{
    protected readonly IAppealsService _service;

    public AppealsControllerBase(IAppealsService service)
    {
        _service = service;
    }

    /// <summary>
    ///     Create one APPEAL
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> CreateAppeal(AppealCreateInput input)
    {
        var appeal = await _service.CreateAppeal(input);

        return CreatedAtAction(nameof(Appeal), new { id = appeal.Id }, appeal);
    }

    /// <summary>
    ///     Delete one APPEAL
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteAppeal([FromRoute] AppealWhereUniqueInput uniqueId)
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
    ///     Find many APPEALS
    /// </summary>
    [HttpGet]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Appeal>>> Appeals([FromQuery] AppealFindManyArgs filter)
    {
        return Ok(await _service.Appeals(filter));
    }

    /// <summary>
    ///     Meta data about APPEAL records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> AppealsMeta(
        [FromQuery] AppealFindManyArgs filter
    )
    {
        return Ok(await _service.AppealsMeta(filter));
    }

    /// <summary>
    ///     Get one APPEAL
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Appeal>> Appeal([FromRoute] AppealWhereUniqueInput uniqueId)
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
    ///     Update one APPEAL
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateAppeal(
        [FromRoute] AppealWhereUniqueInput uniqueId,
        [FromQuery] AppealUpdateInput appealUpdateDto
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
}
