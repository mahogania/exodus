using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ChangeInTheDetailedDeclarationsControllerBase : ControllerBase
{
    protected readonly IChangeInTheDetailedDeclarationsService _service;

    public ChangeInTheDetailedDeclarationsControllerBase(
        IChangeInTheDetailedDeclarationsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one Change in the Detailed Declaration
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<ChangeInTheDetailedDeclaration>
    > CreateChangeInTheDetailedDeclaration(ChangeInTheDetailedDeclarationCreateInput input)
    {
        var changeInTheDetailedDeclaration = await _service.CreateChangeInTheDetailedDeclaration(
            input
        );

        return CreatedAtAction(
            nameof(ChangeInTheDetailedDeclaration),
            new { id = changeInTheDetailedDeclaration.Id },
            changeInTheDetailedDeclaration
        );
    }

    /// <summary>
    /// Delete one Change in the Detailed Declaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteChangeInTheDetailedDeclaration(
        [FromRoute()] ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteChangeInTheDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many Change in the Detailed Declarations
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<ChangeInTheDetailedDeclaration>>
    > ChangeInTheDetailedDeclarations(
        [FromQuery()] ChangeInTheDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ChangeInTheDetailedDeclarations(filter));
    }

    /// <summary>
    /// Meta data about Change in the Detailed Declaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ChangeInTheDetailedDeclarationsMeta(
        [FromQuery()] ChangeInTheDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ChangeInTheDetailedDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one Change in the Detailed Declaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ChangeInTheDetailedDeclaration>> ChangeInTheDetailedDeclaration(
        [FromRoute()] ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ChangeInTheDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Change in the Detailed Declaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateChangeInTheDetailedDeclaration(
        [FromRoute()] ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()]
            ChangeInTheDetailedDeclarationUpdateInput changeInTheDetailedDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateChangeInTheDetailedDeclaration(
                uniqueId,
                changeInTheDetailedDeclarationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a COMMON DETAILED DECLARATION record for Change in the Detailed Declaration
    /// </summary>
    [HttpGet("{Id}/commonDetailedDeclarations")]
    public async Task<ActionResult<List<CommonDetailedDeclaration>>> GetCommonDetailedDeclaration(
        [FromRoute()] ChangeInTheDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var commonDetailedDeclaration = await _service.GetCommonDetailedDeclaration(uniqueId);
        return Ok(commonDetailedDeclaration);
    }
}
