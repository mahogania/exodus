using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class DeclarationOfValueOfTheDetailedDeclarationCustomsItemsControllerBase
    : ControllerBase
{
    protected readonly IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService _service;

    public DeclarationOfValueOfTheDetailedDeclarationCustomsItemsControllerBase(
        IDeclarationOfValueOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DeclarationOfValueOfTheDetailedDeclarationCustoms>
    > CreateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        DeclarationOfValueOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var declarationOfValueOfTheDetailedDeclarationCustoms =
            await _service.CreateDeclarationOfValueOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(DeclarationOfValueOfTheDetailedDeclarationCustoms),
            new { id = declarationOfValueOfTheDetailedDeclarationCustoms.Id },
            declarationOfValueOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    /// Delete one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteDeclarationOfValueOfTheDetailedDeclarationCustoms(
        [FromRoute()] DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteDeclarationOfValueOfTheDetailedDeclarationCustoms(uniqueId);
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
    public async Task<
        ActionResult<List<DeclarationOfValueOfTheDetailedDeclarationCustoms>>
    > DeclarationOfValueOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(await _service.DeclarationOfValueOfTheDetailedDeclarationCustomsItems(filter));
    }

    /// <summary>
    /// Meta data about DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > DeclarationOfValueOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] DeclarationOfValueOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(
            await _service.DeclarationOfValueOfTheDetailedDeclarationCustomsItemsMeta(filter)
        );
    }

    /// <summary>
    /// Get one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<DeclarationOfValueOfTheDetailedDeclarationCustoms>
    > DeclarationOfValueOfTheDetailedDeclarationCustoms(
        [FromRoute()] DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.DeclarationOfValueOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one DECLARATION OF VALUE OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateDeclarationOfValueOfTheDetailedDeclarationCustoms(
        [FromRoute()] DeclarationOfValueOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
            DeclarationOfValueOfTheDetailedDeclarationCustomsUpdateInput declarationOfValueOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateDeclarationOfValueOfTheDetailedDeclarationCustoms(
                uniqueId,
                declarationOfValueOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
