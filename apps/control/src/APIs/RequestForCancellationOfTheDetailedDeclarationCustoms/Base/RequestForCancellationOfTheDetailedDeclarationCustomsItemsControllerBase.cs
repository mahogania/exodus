using Control.APIs;
using Control.APIs.Common;
using Control.APIs.Dtos;
using Control.APIs.Errors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Control.APIs;

[Route("api/[controller]")]
[ApiController()]
public abstract class RequestForCancellationOfTheDetailedDeclarationCustomsItemsControllerBase
    : ControllerBase
{
    protected readonly IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService _service;

    public RequestForCancellationOfTheDetailedDeclarationCustomsItemsControllerBase(
        IRequestForCancellationOfTheDetailedDeclarationCustomsItemsService service
    )
    {
        _service = service;
    }

    /// <summary>
    /// Create one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPost()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RequestForCancellationOfTheDetailedDeclarationCustoms>
    > CreateRequestForCancellationOfTheDetailedDeclarationCustoms(
        RequestForCancellationOfTheDetailedDeclarationCustomsCreateInput input
    )
    {
        var requestForCancellationOfTheDetailedDeclarationCustoms =
            await _service.CreateRequestForCancellationOfTheDetailedDeclarationCustoms(input);

        return CreatedAtAction(
            nameof(RequestForCancellationOfTheDetailedDeclarationCustoms),
            new { id = requestForCancellationOfTheDetailedDeclarationCustoms.Id },
            requestForCancellationOfTheDetailedDeclarationCustoms
        );
    }

    /// <summary>
    /// Delete one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpDelete("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> DeleteRequestForCancellationOfTheDetailedDeclarationCustoms(
        [FromRoute()] RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            await _service.DeleteRequestForCancellationOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }

    /// <summary>
    /// Find many REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)s
    /// </summary>
    [HttpGet()]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<List<RequestForCancellationOfTheDetailedDeclarationCustoms>>
    > RequestForCancellationOfTheDetailedDeclarationCustomsItems(
        [FromQuery()] RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(
            await _service.RequestForCancellationOfTheDetailedDeclarationCustomsItems(filter)
        );
    }

    /// <summary>
    /// Meta data about REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS) records
    /// </summary>
    [HttpPost("meta")]
    public async Task<
        ActionResult<MetadataDto>
    > RequestForCancellationOfTheDetailedDeclarationCustomsItemsMeta(
        [FromQuery()] RequestForCancellationOfTheDetailedDeclarationCustomsFindManyArgs filter
    )
    {
        return Ok(
            await _service.RequestForCancellationOfTheDetailedDeclarationCustomsItemsMeta(filter)
        );
    }

    /// <summary>
    /// Get one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpGet("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<
        ActionResult<RequestForCancellationOfTheDetailedDeclarationCustoms>
    > RequestForCancellationOfTheDetailedDeclarationCustoms(
        [FromRoute()] RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId
    )
    {
        try
        {
            return await _service.RequestForCancellationOfTheDetailedDeclarationCustoms(uniqueId);
        }
        catch (NotFoundException)
        {
            return NotFound();
        }
    }

    /// <summary>
    /// Update one REQUEST FOR CANCELLATION OF THE DETAILED DECLARATION (CUSTOMS)
    /// </summary>
    [HttpPatch("{Id}")]
    [Authorize(Roles = "user")]
    public async Task<ActionResult> UpdateRequestForCancellationOfTheDetailedDeclarationCustoms(
        [FromRoute()]
            RequestForCancellationOfTheDetailedDeclarationCustomsWhereUniqueInput uniqueId,
        [FromQuery()]
            RequestForCancellationOfTheDetailedDeclarationCustomsUpdateInput requestForCancellationOfTheDetailedDeclarationCustomsUpdateDto
    )
    {
        try
        {
            await _service.UpdateRequestForCancellationOfTheDetailedDeclarationCustoms(
                uniqueId,
                requestForCancellationOfTheDetailedDeclarationCustomsUpdateDto
            );
        }
        catch (NotFoundException)
        {
            return NotFound();
        }

        return NoContent();
    }
}
