using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ValueDeclarationsControllerBase : ControllerBase
{
    protected readonly IValueDeclarationsService _service;

    public ValueDeclarationsControllerBase(IValueDeclarationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Value Declaration
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValueDeclaration>> CreateValueDeclaration(
        ValueDeclarationCreateInput input
    )
    {
        var valueDeclaration = await _service.CreateValueDeclaration(input);

        return CreatedAtAction(
            nameof(ValueDeclaration),
            new { id = valueDeclaration.Id },
            valueDeclaration
        );
    }

    /// <summary>
    /// Delete one Value Declaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteValueDeclaration(
        [FromRoute()] ValueDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteValueDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ValueDeclaration>>> ValueDeclarations(
        [FromQuery()] ValueDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ValueDeclarations(filter));
    }

    /// <summary>
    /// Meta data about Value Declaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ValueDeclarationsMeta(
        [FromQuery()] ValueDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ValueDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one Value Declaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ValueDeclaration>> ValueDeclaration(
        [FromRoute()] ValueDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ValueDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Value Declaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateValueDeclaration(
        [FromRoute()] ValueDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] ValueDeclarationUpdateInput valueDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateValueDeclaration(uniqueId, valueDeclarationUpdateDto);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATIONS record for DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclarations(
        [FromRoute()] ValueDeclarationWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclarations(uniqueId);
        return Ok(commonDetailedDeclaration);
    }
}
