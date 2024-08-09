using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class CommonDetailedDeclarationsControllerBase : ControllerBase
{
    protected readonly ICommonDetailedDeclarationsService _service;

    public CommonDetailedDeclarationsControllerBase(ICommonDetailedDeclarationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one COMMON DETAILED DECLARATION
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonDetailedDeclaration>> CreateCommonDetailedDeclaration(
        CommonDetailedDeclarationCreateInput input
    )
    {
        var commonDetailedDeclaration = await _service.CreateCommonDetailedDeclaration(input);

        return CreatedAtAction(
            nameof(CommonDetailedDeclaration),
            new { id = commonDetailedDeclaration.Id },
            commonDetailedDeclaration
        );
    }

    /// <summary>
    /// Delete one COMMON DETAILED DECLARATION
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteCommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteCommonDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many COMMON DETAILED DECLARATIONS
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> CommonDetailedDeclarations(
        [FromQuery()] CommonDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarations(filter));
    }

    /// <summary>
    /// Meta data about COMMON DETAILED DECLARATION records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> CommonDetailedDeclarationsMeta(
        [FromQuery()] CommonDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.CommonDetailedDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one COMMON DETAILED DECLARATION
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<CommonDetailedDeclaration>> CommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.CommonDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one COMMON DETAILED DECLARATION
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateCommonDetailedDeclaration(
        [FromRoute()] CommonDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] CommonDetailedDeclarationUpdateInput commonDetailedDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateCommonDetailedDeclaration(
                uniqueId,
                commonDetailedDeclarationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
