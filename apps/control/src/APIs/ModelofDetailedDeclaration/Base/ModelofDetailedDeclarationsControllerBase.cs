using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class ModelofDetailedDeclarationsControllerBase : ControllerBase
{
    protected readonly IModelofDetailedDeclarationsService _service;

    public ModelofDetailedDeclarationsControllerBase(IModelofDetailedDeclarationsService service)
    {
        _service = service;
    }

    /// <summary>
    /// Create one Model of Detailed Declaration
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ModelofDetailedDeclaration>> CreateModelofDetailedDeclaration(
        ModelofDetailedDeclarationCreateInput input
    )
    {
        var modelofDetailedDeclaration = await _service.CreateModelofDetailedDeclaration(input);

        return CreatedAtAction(
            nameof(ModelofDetailedDeclaration),
            new { id = modelofDetailedDeclaration.Id },
            modelofDetailedDeclaration
        );
    }

    /// <summary>
    /// Delete one Model of Detailed Declaration
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteModelofDetailedDeclaration(
        [FromRoute()] ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteModelofDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many MODEL/SPECIFICATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<List<ModelofDetailedDeclaration>>> ModelofDetailedDeclarations(
        [FromQuery()] ModelofDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ModelofDetailedDeclarations(filter));
    }

    /// <summary>
    /// Meta data about Model of Detailed Declaration records
    /// </summary>
    [HttpPost("meta")]
    public async Task<ActionResult<MetadataDto>> ModelofDetailedDeclarationsMeta(
        [FromQuery()] ModelofDetailedDeclarationFindManyArgs filter
    )
    {
        return Ok(await _service.ModelofDetailedDeclarationsMeta(filter));
    }

    /// <summary>
    /// Get one Model of Detailed Declaration
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult<ModelofDetailedDeclaration>> ModelofDetailedDeclaration(
        [FromRoute()] ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.ModelofDetailedDeclaration(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one Model of Detailed Declaration
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateModelofDetailedDeclaration(
        [FromRoute()] ModelofDetailedDeclarationWhereUniqueInput uniqueId,
        [FromQuery()] ModelofDetailedDeclarationUpdateInput modelofDetailedDeclarationUpdateDto
    )
    {
        try
        {
            await _service.UpdateModelofDetailedDeclaration(
                uniqueId,
                modelofDetailedDeclarationUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Get a Article record for Model of Detailed Declaration
    /// </summary>
    [HttpGet("{Id}/articles")]
    public async Task<ActionResult<List<Article>>> GetArticle(
        [FromRoute()] ModelofDetailedDeclarationWhereUniqueInput uniqueId
    )
    {
        var article = await _service.GetArticle(uniqueId);
        return Ok(article);
    }
}
