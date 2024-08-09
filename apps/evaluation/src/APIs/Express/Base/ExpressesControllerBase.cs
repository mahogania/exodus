using Evaluation.APIs;
using Evaluation.APIs.Common;
using Evaluation.APIs.Dtos;
using Evaluation.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ExpressesControllerBase : ControllerBase
{
    protected readonly IExpressesService _service;

    public ExpressesControllerBase(IExpressesService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Express
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Express>> CreateExpress(ExpressCreateInput input)
    {
        var express = await _service.CreateExpress(input);

        return CreatedAtAction(nameof(Express), new { id = express.Id }, express);
    }

    /// <summary>
    /// Delete one Express
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteExpress([FromRoute()] ExpressWhereUniqueInput uniqueId)
    {
        try
        {
            await _service.DeleteExpress(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Expresses
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<Express>>> Expresses(
        [FromQuery()] ExpressFindManyArgs filter
    )
    {
        return Ok(await _service.Expresses(filter));
    }

    /// <summary>
    /// Meta data about Express records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ExpressesMeta(
        [FromQuery()] ExpressFindManyArgs filter
    )
    {
        return Ok(await _service.ExpressesMeta(filter));
    }

    /// <summary>
    /// Get one Express
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<Express>> Express([FromRoute()] ExpressWhereUniqueInput uniqueId)
    {
        try
        {
            return await _service.Express(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Express
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateExpress(
        [FromRoute()] ExpressWhereUniqueInput uniqueId,
        [FromQuery()] ExpressUpdateInput expressUpdateDto
    )
    {
        try
        {
            await _service.UpdateExpress(uniqueId, expressUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
